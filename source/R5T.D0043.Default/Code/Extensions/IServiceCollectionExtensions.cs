using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0043.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalRepositoryDirectoryPathsListTextFileSerializer"/> implementation of <see cref="ILocalRepositoryDirectoryPathsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLocalRepositoryDirectoryPathsListTextFileSerializer(this IServiceCollection services)
        {
            services.AddSingleton<ILocalRepositoryDirectoryPathsListTextFileSerializer, LocalRepositoryDirectoryPathsListTextFileSerializer>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="LocalRepositoryDirectoryPathsListTextFileSerializer"/> implementation of <see cref="ILocalRepositoryDirectoryPathsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ILocalRepositoryDirectoryPathsListTextFileSerializer> AddLocalRepositoryDirectoryPathsListTextFileSerializerAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ILocalRepositoryDirectoryPathsListTextFileSerializer>(() => services.AddLocalRepositoryDirectoryPathsListTextFileSerializer());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RemoteRepositoryUrlsListTextFileSerializer"/> implementation of <see cref="IRemoteRepositoryUrlsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRemoteRepositoryUrlsListTextFileSerializer(this IServiceCollection services)
        {
            services.AddSingleton<IRemoteRepositoryUrlsListTextFileSerializer, RemoteRepositoryUrlsListTextFileSerializer>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RemoteRepositoryUrlsListTextFileSerializer"/> implementation of <see cref="IRemoteRepositoryUrlsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRemoteRepositoryUrlsListTextFileSerializer> AddRemoteRepositoryUrlsListTextFileSerializerAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IRemoteRepositoryUrlsListTextFileSerializer>(() => services.AddRemoteRepositoryUrlsListTextFileSerializer());
            return serviceAction;
        }
    }
}
