using System;

using R5T.T0131;


namespace R5T.L0049
{
    [ValuesMarker]
    public partial interface IWindowsSpecialDirectoryPaths : IValuesMarker
    {
        /// <summary>
        /// Gets the current user's user directory path.
        /// <para>
        /// <inheritdoc cref="Documentation.UserDirectoryPathExample" path="/summary"/>
        /// </para>
        /// </summary>
        public IUserDirectoryPath UserProfile => Instances.OperatingSystemOperator.Get_SpecialDirectoryPath(
            Environment.SpecialFolder.UserProfile,
            Instances.StringOperator_Extensions.ToUserDirectoryPath);
    }
}
