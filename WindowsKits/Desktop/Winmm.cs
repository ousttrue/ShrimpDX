using System.Runtime.InteropServices;


namespace WindowsKits
{
    public static class Winmm
    {
        const string DLLNAME = "Winmm.dll";

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/timeapi/nf-timeapi-timegettime
        /// </summary>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern uint timeGetTime(

        );
    }
}
