using System;

using R5T.T0131;
using R5T.T0199;
using R5T.T0199.Extensions;


namespace R5T.L0049
{
    /// <summary>
    /// The default Windows environment variables (Windows 10).
    /// </summary>
    /// <remarks>
    /// Sources:
    /// <list type="bullet">
    /// <item><see href="https://pureinfotech.com/list-environment-variables-windows-10/"/></item>
    /// <item><see href="https://superuser.com/questions/217504/is-there-a-list-of-windows-special-directories-shortcuts-like-temp"/></item>
    /// </list>
    /// </remarks>
    [ValuesMarker]
    public partial interface IWindowsEnvironmentVariableNames : IValuesMarker
    {
        /// <summary>
        /// %PATH%
        /// </summary>
        public IEnvironmentVariableName Path => "PATH".ToEnvironmentVariableName();

        /// <summary>
        /// %USERPROFILE%
        /// </summary>
        public IEnvironmentVariableName UserProfile => "USERPROFILE".ToEnvironmentVariableName();
    }
}
