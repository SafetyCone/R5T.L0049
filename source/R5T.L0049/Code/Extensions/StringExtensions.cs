using System;


namespace R5T.L0049.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToUserDirectoryPath(string)"/>
        public static IUserDirectoryPath ToUserDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToUserDirectoryPath(value);
        }
    }
}
