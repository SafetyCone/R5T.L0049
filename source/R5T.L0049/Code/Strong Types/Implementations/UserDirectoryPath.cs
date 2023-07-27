using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0049
{
    /// <inheritdoc cref="IUserDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class UserDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IUserDirectoryPath
    {
        public UserDirectoryPath(string value)
            : base(value)
        {
        }
    }
}