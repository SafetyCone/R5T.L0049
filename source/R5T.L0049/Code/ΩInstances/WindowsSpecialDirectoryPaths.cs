using System;


namespace R5T.L0049
{
    public class WindowsSpecialDirectoryPaths : IWindowsSpecialDirectoryPaths
    {
        #region Infrastructure

        public static IWindowsSpecialDirectoryPaths Instance { get; } = new WindowsSpecialDirectoryPaths();


        private WindowsSpecialDirectoryPaths()
        {
        }

        #endregion
    }
}
