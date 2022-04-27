using System;

using R5T.D0042;
using R5T.T0010;
using R5T.T0064;


namespace R5T.D0043
{
    [ServiceDefinitionMarker]
    public interface IRepositoryNameAndRemoteUrlMappingsListTextFileSerializer : ITextFileSerializer<RepositoryNameAndRemoteUrlMappingsList>, IServiceDefinition
    {
    }
}
