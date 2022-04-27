using System;

using R5T.D0044;
using R5T.T0010;
using R5T.T0064;


namespace R5T.D0043
{
    [ServiceDefinitionMarker]
    public interface IRepositoryNameAndLocalDirectoryPathMappingStringSerializer : IStringSerializer<RepositoryNameAndLocalDirectoryPathMapping>, IServiceDefinition
    {
    }
}
