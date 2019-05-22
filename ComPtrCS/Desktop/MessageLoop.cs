using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


namespace ComPtrCS
{
    public class FPSTimer
    {
        uint m_last;
        int m_msInFrame;

        public FPSTimer(int fps)
        {
            m_last = Winmm.timeGetTime();
            m_msInFrame = 1000 / fps - 5;
        }

        public void Update(Action frameAction)
        {
            var now = Winmm.timeGetTime();
            var delta = (int)(now - m_last);
            if (delta > m_msInFrame)
            {
                frameAction();
                m_last = now;
            }
            else
            {
                Thread.Sleep(m_msInFrame - delta);
            }
        }
    }

    public class MessageLoop
    {
        class CustomSynchronizationContext : SynchronizationContext
        {
            Queue<(SendOrPostCallback, object)> m_queue = new Queue<(SendOrPostCallback, object)>();
            public override void Post(SendOrPostCallback d, object state)
            {
                lock (((ICollection)m_queue).SyncRoot)
                {
                    m_queue.Enqueue((d, state));
                }
            }

            List<(SendOrPostCallback, object)> m_dequeue = new List<(SendOrPostCallback, object)>();
            public void Process()
            {
                lock (((ICollection)m_queue).SyncRoot)
                {
                    m_dequeue.AddRange(m_queue);
                    m_queue.Clear();
                }

                foreach (var (callback, obj) in m_dequeue)
                {
                    callback(obj);
                }
                m_dequeue.Clear();
            }
        }

        [ThreadStatic]
        static CustomSynchronizationContext s_context;
        public static void EnsureContext()
        {
            if (s_context == null)
            {
                s_context = new CustomSynchronizationContext();
                SynchronizationContext.SetSynchronizationContext(s_context);
            }
        }

        public static void ProcessMessage(out bool isQuit)
        {
            EnsureContext();

            var msg = default(MSG);
            while (User32.PeekMessageW(ref msg, 0, 0, 0, PM.REMOVE))
            {
                if (msg.message == WM.QUIT)
                {
                    isQuit = true;
                    return;
                }
                User32.TranslateMessage(ref msg);
                User32.DispatchMessage(ref msg);
            }
            isQuit = false;

            // process tasks
            s_context.Process();
        }

        public static void Run(Action draw, int fps)
        {
            var timer = new FPSTimer(1000 / fps);
            while (true)
            {
                bool isQuit;
                ProcessMessage(out isQuit);
                if (isQuit)
                {
                    return;
                }

                timer.Update(draw);
            }
        }
    }
}
