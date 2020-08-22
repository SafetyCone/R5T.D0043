using System;
using System.Threading.Tasks;

using R5T.T0010;

using R5T.Magyar;


namespace R5T.D0043.Default
{
    public class RepositoryNameAndLocalDirectoryPathMappingStringSerializer : IRepositoryNameAndLocalDirectoryPathMappingStringSerializer
    {
        public const char TokenSeparatorChar = '|';


        public static char[] Separators { get; } = ArrayHelper.From(RepositoryNameAndLocalDirectoryPathMappingStringSerializer.TokenSeparatorChar);


        public Task<RepositoryNameAndLocalDirectoryPathMapping> Deserialize(string @string)
        {
            var tokens = @string.Split(RepositoryNameAndLocalDirectoryPathMappingStringSerializer.Separators);

            var repositoryNameToken = tokens[0];
            var localRepositoryDirectoryPathToken = tokens[1];

            var repositoryName = RepositoryName.From(repositoryNameToken);
            var localRepositoryDirectoryPath = LocalRepositoryDirectoryPath.From(localRepositoryDirectoryPathToken);

            var mapping = new RepositoryNameAndLocalDirectoryPathMapping(repositoryName, localRepositoryDirectoryPath);

            return Task.FromResult(mapping);
        }

        public Task<string> Serialize(RepositoryNameAndLocalDirectoryPathMapping value)
        {
            var @string = $"{value.RepositoryName.Value}{RepositoryNameAndLocalDirectoryPathMappingStringSerializer.TokenSeparatorChar}{value.LocalRepositoryDirectoryPath.Value}";

            return Task.FromResult(@string);
        }
    }
}
