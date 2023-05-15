using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0195
{
    /// <inheritdoc cref="IProjectFileReference"/>
    [StrongTypeImplementationMarker]
    public class ProjectFileReference : TypedBase<string>, IStrongTypeMarker,
        IProjectFileReference
    {
        public ProjectFileReference(string value)
            : base(value)
        {
        }
    }
}
