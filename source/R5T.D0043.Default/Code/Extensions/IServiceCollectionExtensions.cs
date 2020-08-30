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

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndLocalDirectoryPathMappingStringSerializer"/> implementation of <see cref="IRepositoryNameAndLocalDirectoryPathMappingStringSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRepositoryNameAndLocalDirectoryPathMappingStringSerializer(this IServiceCollection services)
        {
            services.AddSingleton<IRepositoryNameAndLocalDirectoryPathMappingStringSerializer, RepositoryNameAndLocalDirectoryPathMappingStringSerializer>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndLocalDirectoryPathMappingStringSerializer"/> implementation of <see cref="IRepositoryNameAndLocalDirectoryPathMappingStringSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoryNameAndLocalDirectoryPathMappingStringSerializer> AddRepositoryNameAndLocalDirectoryPathMappingStringSerializerAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IRepositoryNameAndLocalDirectoryPathMappingStringSerializer>(() => services.AddRepositoryNameAndLocalDirectoryPathMappingStringSerializer());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer"/> implementation of <see cref="IRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer(this IServiceCollection services,
            IServiceAction<IRepositoryNameAndLocalDirectoryPathMappingStringSerializer> repositoryNameAndLocalDirectoryPathMappingStringSerializerAction)
        {
            services
                .AddSingleton<IRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer, RepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer>()
                .Run(repositoryNameAndLocalDirectoryPathMappingStringSerializerAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer"/> implementation of <see cref="IRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer> AddRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializerAction(this IServiceCollection services,
            IServiceAction<IRepositoryNameAndLocalDirectoryPathMappingStringSerializer> repositoryNameAndLocalDirectoryPathMappingStringSerializerAction)
        {
            var serviceAction = ServiceAction.New<IRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer>(() => services.AddRepositoryNameAndLocalDirectoryPathMappingsListTextFileSerializer(
                repositoryNameAndLocalDirectoryPathMappingStringSerializerAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndRemoteUrlMappingStringSerializer"/> implementation of <see cref="IRepositoryNameAndRemoteUrlMappingStringSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRepositoryNameAndRemoteUrlMappingStringSerializer(this IServiceCollection services)
        {
            services.AddSingleton<IRepositoryNameAndRemoteUrlMappingStringSerializer, RepositoryNameAndRemoteUrlMappingStringSerializer>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndRemoteUrlMappingStringSerializer"/> implementation of <see cref="IRepositoryNameAndRemoteUrlMappingStringSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoryNameAndRemoteUrlMappingStringSerializer> AddRepositoryNameAndRemoteUrlMappingStringSerializerAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IRepositoryNameAndRemoteUrlMappingStringSerializer>(() => services.AddRepositoryNameAndRemoteUrlMappingStringSerializer());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndRemoteUrlMappingsListTextFileSerializer"/> implementation of <see cref="IRepositoryNameAndRemoteUrlMappingsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRepositoryNameAndRemoteUrlMappingsListTextFileSerializer(this IServiceCollection services,
            IServiceAction<IRepositoryNameAndRemoteUrlMappingStringSerializer> repositoryNameAndRemoteUrlMappingStringSerializerAction)
        {
            services
                .AddSingleton<IRepositoryNameAndRemoteUrlMappingsListTextFileSerializer, RepositoryNameAndRemoteUrlMappingsListTextFileSerializer>()
                .Run(repositoryNameAndRemoteUrlMappingStringSerializerAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RepositoryNameAndRemoteUrlMappingsListTextFileSerializer"/> implementation of <see cref="IRepositoryNameAndRemoteUrlMappingsListTextFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoryNameAndRemoteUrlMappingsListTextFileSerializer>
            AddRepositoryNameAndRemoteUrlMappingsListTextFileSerializerAction(this IServiceCollection services,
            IServiceAction<IRepositoryNameAndRemoteUrlMappingStringSerializer> repositoryNameAndRemoteUrlMappingStringSerializerAction)
        {
            var serviceAction = ServiceAction.New<IRepositoryNameAndRemoteUrlMappingsListTextFileSerializer>(() => services.AddRepositoryNameAndRemoteUrlMappingsListTextFileSerializer(
                repositoryNameAndRemoteUrlMappingStringSerializerAction));

            return serviceAction;
        }
    }
}
