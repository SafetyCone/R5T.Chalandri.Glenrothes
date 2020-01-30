using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Glenrothes;
using R5T.Ilioupoli;
using R5T.Lombardy;


namespace R5T.Chalandri.Glenrothes
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TestingDataDirectoryContentPathsProvider"/> implementation of <see cref="ITestingDataDirectoryContentPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGlenrothesTestingDataDirectoryContentPathsProvider(this IServiceCollection services,
            ServiceAction<ITestingDataDirectoryPathProvider> addTestingDataDirectoryPathProvider,
            ServiceAction<ITestingDataDirectoryContentConventions> addTestingDataDirectoryContentConventions,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<ITestingDataDirectoryContentPathsProvider, TestingDataDirectoryContentPathsProvider>()
                .RunServiceAction(addTestingDataDirectoryPathProvider)
                .RunServiceAction(addTestingDataDirectoryContentConventions)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TestingDataDirectoryContentPathsProvider"/> implementation of <see cref="ITestingDataDirectoryContentPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ITestingDataDirectoryContentPathsProvider> AddGlenrothesTestingDataDirectoryContentPathsProviderAction(this IServiceCollection services,
            ServiceAction<ITestingDataDirectoryPathProvider> addTestingDataDirectoryPathProvider,
            ServiceAction<ITestingDataDirectoryContentConventions> addTestingDataDirectoryContentConventions,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<ITestingDataDirectoryContentPathsProvider>(() => services.AddGlenrothesTestingDataDirectoryContentPathsProviderAction(
                addTestingDataDirectoryPathProvider,
                addTestingDataDirectoryContentConventions,
                addStringlyTypedPathOperator));
            return serviceAction;
        }
    }
}
