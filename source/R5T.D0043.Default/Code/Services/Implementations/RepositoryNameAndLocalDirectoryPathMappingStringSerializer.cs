using System;
using System.Threading.Tasks;

using R5T.D0044.Default;
using R5T.T0010;
using R5T.T0064;


namespace R5T.D0043.Default
{
    [ServiceImplementationMarker]
    public class RepositoryNameAndLocalDirectoryPathMappingStringSerializer : TokenizedStringSerializerBase<RepositoryNameAndLocalDirectoryPathMapping>, IRepositoryNameAndLocalDirectoryPathMappingStringSerializer,
        IServiceImplementation
    {
        public override Task<string[]> GetTokens(RepositoryNameAndLocalDirectoryPathMapping value)
        {
            var tokens = ArrayHelper.From(
                value.RepositoryName.Value,
                value.LocalRepositoryDirectoryPath.Value);

            return Task.FromResult(tokens);
        }

        protected override Task<RepositoryNameAndLocalDirectoryPathMapping> DeserializeTokens(string[] tokens)
        {
            var repositoryNameToken = tokens[0];
            var localRepositoryDirectoryPathToken = tokens[1];

            var repositoryName = RepositoryName.From(repositoryNameToken);
            var localRepositoryDirectoryPath = LocalRepositoryDirectoryPath.From(localRepositoryDirectoryPathToken);

            var mapping = new RepositoryNameAndLocalDirectoryPathMapping(repositoryName, localRepositoryDirectoryPath);

            return Task.FromResult(mapping);
        }
    }
}
