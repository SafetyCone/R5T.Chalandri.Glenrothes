using System;

using R5T.Glenrothes;
using R5T.Ilioupoli;
using R5T.Lombardy;


namespace R5T.Chalandri.Glenrothes
{
    public class TestingDataDirectoryContentPathsProvider : ITestingDataDirectoryContentPathsProvider
    {
        private ITestingDataDirectoryPathProvider TestingDataDirectoryPathProvider { get; }
        private ITestingDataDirectoryContentConventions TestingDataDirectoryContentConventions { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public TestingDataDirectoryContentPathsProvider(
            ITestingDataDirectoryPathProvider testingDataDirectoryPathProvider,
            ITestingDataDirectoryContentConventions testingDataDirectoryContentConventions,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.TestingDataDirectoryPathProvider = testingDataDirectoryPathProvider;
            this.TestingDataDirectoryContentConventions = testingDataDirectoryContentConventions;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetBasicTextFilePath()
        {
            var testingDataDirectoryPath = this.TestingDataDirectoryPathProvider.GetTestingDataDirectoryPath();

            var basicTextFileName = this.TestingDataDirectoryContentConventions.BasicTextFileName;

            var basicTextFilePath = this.StringlyTypedPathOperator.GetFilePath(testingDataDirectoryPath, basicTextFileName);
            return basicTextFilePath;
        }
    }
}
