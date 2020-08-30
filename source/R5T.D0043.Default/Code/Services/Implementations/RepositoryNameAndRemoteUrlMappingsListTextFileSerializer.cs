using System;

using R5T.D0042.Default;
using R5T.T0010;


namespace R5T.D0043.Default
{
    public class RepositoryNameAndRemoteUrlMappingsListTextFileSerializer
        : StringSerializerBasedTypedListTextFileSerializerBase<RepositoryNameAndRemoteUrlMappingsList, RepositoryNameAndRemoteUrlMapping>,
        IRepositoryNameAndRemoteUrlMappingsListTextFileSerializer
    {
        public RepositoryNameAndRemoteUrlMappingsListTextFileSerializer(
            IRepositoryNameAndRemoteUrlMappingStringSerializer repositoryNameAndRemoteUrlMappingStringSerializer)
            : base(repositoryNameAndRemoteUrlMappingStringSerializer)
        {
        }
    }
}
