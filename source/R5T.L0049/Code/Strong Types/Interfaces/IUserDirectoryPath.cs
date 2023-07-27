using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.L0049
{
    /// <summary>
    /// Strongly-types a string as the path of a user's directory.
    /// <para>
    /// <inheritdoc cref="Documentation.UserDirectoryPathExample" path="/summary"/>
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IUserDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}