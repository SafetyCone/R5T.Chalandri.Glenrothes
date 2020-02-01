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

        private string GetFilePath(string fileName)
        {
            var testingDataDirectoryPath = this.TestingDataDirectoryPathProvider.GetTestingDataDirectoryPath();

            var filePath = this.StringlyTypedPathOperator.GetFilePath(testingDataDirectoryPath, fileName);
            return filePath;
        }

        public string GetBasicTextFilePath()
        {
            var basicTextFileName = this.TestingDataDirectoryContentConventions.BasicTextFileName;

            var basicTextFilePath = this.GetFilePath(basicTextFileName);
            return basicTextFilePath;
        }

        public string GetExampleVisualStudioSolutionFilePath()
        {
            var exampleVisualStudioSolutionFileName = this.TestingDataDirectoryContentConventions.ExampleVisualStudioSolutionFileName;

            var exampleVisualStudioSolutionFilePath = this.GetFilePath(exampleVisualStudioSolutionFileName);
            return exampleVisualStudioSolutionFilePath;
        }

        public string GetNewVisualStudio2017SolutionFilePath()
        {
            var newVisualStudio2017SolutionFileName = this.TestingDataDirectoryContentConventions.NewVisualStudio2017SolutionFileName;

            var exampleVisualStudioSolutionFilePath = this.GetFilePath(newVisualStudio2017SolutionFileName);
            return exampleVisualStudioSolutionFilePath;
        }
    }
}
