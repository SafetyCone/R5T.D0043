using System;
using System.Collections.Generic;

using R5T.D0042.Stagira;
using R5T.T0010;


namespace R5T.D0043.Default
{
    public class LocalRepositoryDirectoryPathsListTextFileSerializer : TypedStringsListTextFileSerializerBase<LocalRepositoryDirectoryPathsList, LocalRepositoryDirectoryPath>,
        ILocalRepositoryDirectoryPathsListTextFileSerializer
    {
        protected override Func<string, LocalRepositoryDirectoryPath> TypedStringConstructor => LocalRepositoryDirectoryPath.From;
    }
}
