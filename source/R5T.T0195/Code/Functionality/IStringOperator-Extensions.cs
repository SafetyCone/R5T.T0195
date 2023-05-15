using System;

using R5T.T0132;


namespace R5T.T0195.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IProjectFileReference ToProjectFileReference(string value)
        {
            var output = new ProjectFileReference(value);
            return output;
        }
    }
}
