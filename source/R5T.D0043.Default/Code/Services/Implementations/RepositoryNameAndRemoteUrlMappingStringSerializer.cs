using System;
using System.Threading.Tasks;

using R5T.D0044.Default;
using R5T.T0010;

using R5T.Magyar;


namespace R5T.D0043.Default
{
    public class RepositoryNameAndRemoteUrlMappingStringSerializer : TokenizedStringSerializerBase<RepositoryNameAndRemoteUrlMapping>, IRepositoryNameAndRemoteUrlMappingStringSerializer
    {
        public override Task<string[]> GetTokens(RepositoryNameAndRemoteUrlMapping value)
        {
            var tokens = ArrayHelper.From(
                value.RepositoryName.Value,
                value.RemoteRepositoryUrl.Value);

            return Task.FromResult(tokens);
        }

        protected override Task<RepositoryNameAndRemoteUrlMapping> DeserializeTokens(string[] tokens)
        {
            var repositoryNameToken = tokens[0];
            var remoteRepositoryUrlToken = tokens[1];

            var repositoryName = RepositoryName.From(repositoryNameToken);
            var remoteRepositoryUrl = RemoteRepositoryUrl.From(remoteRepositoryUrlToken);

            var mapping = new RepositoryNameAndRemoteUrlMapping(repositoryName, remoteRepositoryUrl);

            return Task.FromResult(mapping);
        }
    }
}
