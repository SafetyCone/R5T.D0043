﻿using System;

using R5T.D0042.Default;
using R5T.T0010;
using R5T.T0064;


namespace R5T.D0043.Default
{
    [ServiceImplementationMarker]
    public class RepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer
        : StringSerializerBasedTypedListTextFileSerializerBase<RepositoryNameAndLocalDirectoryPathMappingsList, RepositoryNameAndLocalDirectoryPathMapping>,
        IRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer,
        IServiceImplementation
    {
        public RepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer(
            IRepositoryNameAndLocalDirectoryPathMappingStringSerializer repositoryNameAndLocalDirectoryPathMappingStringSerializer)
            : base(repositoryNameAndLocalDirectoryPathMappingStringSerializer)
        {
        }
    }
}
