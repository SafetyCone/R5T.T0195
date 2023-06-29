using System;

using R5T.T0172;


namespace R5T.T0195.Extensions
{
    public static class StringExtensions
    {
        public static IProjectFileReference ToProjectFileReference(this IProjectFilePath value)
        {
            return Instances.StringOperator_Extensions.ToProjectFileReference(value);
        }

        public static IProjectFileReference ToProjectFileReference(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectFileReference(value);
        }
    }
}
