using System;

using R5T.T0141;


namespace R5T.L0049.Construction
{
    /// <summary>
    /// See R5T.S0091.IDemonstrations.
    /// </summary>
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Get_UserProfileDirectoryPath()
        {
            var directoryPath = Instances.WindowsSpecialDirectoryPaths.UserProfile;

            Console.WriteLine(directoryPath);
        }
    }
}
