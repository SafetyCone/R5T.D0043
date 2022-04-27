using System;

using R5T.D0042.Stagira;
using R5T.T0010;
using R5T.T0064;


namespace R5T.D0043.Default
{
    [ServiceImplementationMarker]
    public class LocalRepositoryDirectoryPathsListTextFileSerializer : TypedStringsListTextFileSerializerBase<LocalRepositoryDirectoryPathsList, LocalRepositoryDirectoryPath>,
        ILocalRepositoryDirectoryPathsListTextFileSerializer,
        IServiceImplementation
    {
        protected override Func<string, LocalRepositoryDirectoryPath> TypedStringConstructor => LocalRepositoryDirectoryPath.From;
    }
}
