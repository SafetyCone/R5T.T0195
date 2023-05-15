using System;


namespace R5T.T0195.Extensions
{
    public static class StringExtensions
    {
        public static IProjectFileReference ToProjectFileReference(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectFileReference(value);
        }
    }
}
