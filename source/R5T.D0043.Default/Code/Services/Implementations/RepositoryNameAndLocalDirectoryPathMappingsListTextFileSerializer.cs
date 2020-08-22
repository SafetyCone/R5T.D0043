using System;

using R5T.D0042.Default;
using R5T.T0010;


namespace R5T.D0043.Default
{
    public class RepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer
        : StringSerializerBasedTypedListTextFileSerializerBase<RepositoryNameAndLocalDirectoryPathMappingsList, RepositoryNameAndLocalDirectoryPathMapping>,
        IRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer
    {
        public RepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer(
            IRepositoryNameAndLocalDirectoryPathMappingStringSerializer repositoryNameAndLocalDirectoryPathMappingStringSerializer)
            : base(repositoryNameAndLocalDirectoryPathMappingStringSerializer)
        {
        }
    }
}
