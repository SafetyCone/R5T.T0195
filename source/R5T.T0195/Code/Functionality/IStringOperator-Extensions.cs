using System;

using R5T.T0132;
using R5T.T0172;


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

        public IProjectFileReference ToProjectFileReference(IProjectFilePath projectFilePath)
        {
            var output = new ProjectFileReference(projectFilePath.Value);
            return output;
        }
    }
}
