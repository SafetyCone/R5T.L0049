using System;

using R5T.T0132;


namespace R5T.L0049.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IUserDirectoryPath"/>
        public IUserDirectoryPath ToUserDirectoryPath(string value)
        {
            var output = new UserDirectoryPath(value);
            return output;
        }
    }
}
