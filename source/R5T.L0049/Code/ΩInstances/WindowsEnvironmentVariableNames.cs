using System;


namespace R5T.L0049
{
    public class WindowsEnvironmentVariableNames : IWindowsEnvironmentVariableNames
    {
        #region Infrastructure

        public static IWindowsEnvironmentVariableNames Instance { get; } = new WindowsEnvironmentVariableNames();


        private WindowsEnvironmentVariableNames()
        {
        }

        #endregion
    }
}
