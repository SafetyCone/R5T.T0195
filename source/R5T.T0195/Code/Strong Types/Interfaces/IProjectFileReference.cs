using System;

using R5T.T0172;
using R5T.T0178;


namespace R5T.T0195
{
    /// <summary>
    /// <inheritdoc cref="IProjectFilePath" path="/summary"/>
    /// <para>
    /// Quality-of-life name for <see cref="IProjectFilePath"/>.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectFileReference : IStrongTypeMarker,
        IProjectFilePath
    {
    }
}
