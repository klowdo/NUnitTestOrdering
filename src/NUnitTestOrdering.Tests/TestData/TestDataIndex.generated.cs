﻿// ******************************************************************************
//  © 2016 Sebastiaan Dammann - damsteen.nl
// 
//  File:           : Test.cs
//  Project         : NUnitTestOrdering.Tests
// ******************************************************************************

// <autogenerated>
// This file is generated by TestDataIndex.tt. Any changes will be lost
// when the file is regenerated. Do not edit this file.
// </autogenerated>

namespace NUnitTestOrdering.Tests.IntegrationTests {
    using System.Diagnostics.CodeAnalysis;
    using System.Xml.Linq;
    using NUnit.Framework;
    using NUnitTestOrdering.Tests.TestData;
    using Support;

    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public sealed partial class MethodOrdering {
        [Test]
        public void Simple() {
            // Given
            var input = TestDataDirectories.MethodOrdering.Simple();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Simple_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Simple_AssertResultsFile(ResultsDocument testResults);

    }

    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public sealed partial class PlainFixtureOrdering {
        [Test]
        public void HierarchySetupTeardown() {
            // Given
            var input = TestDataDirectories.PlainFixtureOrdering.HierarchySetupTeardown();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                HierarchySetupTeardown_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void HierarchySetupTeardown_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void NestedDeepHierarchy() {
            // Given
            var input = TestDataDirectories.PlainFixtureOrdering.NestedDeepHierarchy();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                NestedDeepHierarchy_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void NestedDeepHierarchy_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void OneDeepHierarchy() {
            // Given
            var input = TestDataDirectories.PlainFixtureOrdering.OneDeepHierarchy();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                OneDeepHierarchy_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void OneDeepHierarchy_AssertResultsFile(ResultsDocument testResults);

    }

    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public sealed partial class TestExecution {
        [Test]
        public void Fail_NestedDeepHierarchy_OtherTestsRunInRoot() {
            // Given
            var input = TestDataDirectories.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Fail_NestedDeepHierarchy_OtherTestsRunInRoot_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Fail_NestedDeepHierarchy_OtherTestsRunInRoot_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash() {
            // Given
            var input = TestDataDirectories.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void Fail_OneDeepHierarchy_OtherTestsRun() {
            // Given
            var input = TestDataDirectories.TestExecution.Fail_OneDeepHierarchy_OtherTestsRun();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Fail_OneDeepHierarchy_OtherTestsRun_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Fail_OneDeepHierarchy_OtherTestsRun_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void Fail_OneDeepHierarchy_OtherTestsSkipped() {
            // Given
            var input = TestDataDirectories.TestExecution.Fail_OneDeepHierarchy_OtherTestsSkipped();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Fail_OneDeepHierarchy_OtherTestsSkipped_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Fail_OneDeepHierarchy_OtherTestsSkipped_AssertResultsFile(ResultsDocument testResults);

    }

    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public sealed partial class TestIntegrity {
        [Test]
        public void OrderedWithOrderAttribute() {
            // Given
            var input = TestDataDirectories.TestIntegrity.OrderedWithOrderAttribute();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                OrderedWithOrderAttribute_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void OrderedWithOrderAttribute_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void Single() {
            // Given
            var input = TestDataDirectories.TestIntegrity.Single();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Single_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Single_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void Single_WithActionAttribute() {
            // Given
            var input = TestDataDirectories.TestIntegrity.Single_WithActionAttribute();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Single_WithActionAttribute_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Single_WithActionAttribute_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void Single_WithSetupFixture() {
            // Given
            var input = TestDataDirectories.TestIntegrity.Single_WithSetupFixture();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Single_WithSetupFixture_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Single_WithSetupFixture_AssertResultsFile(ResultsDocument testResults);

        [Test]
        public void Single_WithSetupTeardown() {
            // Given
            var input = TestDataDirectories.TestIntegrity.Single_WithSetupTeardown();
            string expectedResult = input.ReadResultsFile();

            // When
            string result;
            XDocument rawResultsDocument;
            using (TestRunner testRunner = new TestRunner(input)) {
                result = testRunner.Run();

                rawResultsDocument = testRunner.TestResultsDocument;
            }

            // Then
            Assert.That(result, Is.EqualTo(expectedResult));

            if (rawResultsDocument != null) {
                Single_WithSetupTeardown_AssertResultsFile(new ResultsDocument(rawResultsDocument));
            }
        }

        partial void Single_WithSetupTeardown_AssertResultsFile(ResultsDocument testResults);

    }

}

namespace NUnitTestOrdering.Tests.TestData {
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Reflection;
    using System.Text;

    public class TestDataDirectory {
       public string [] Files { get; set; }
       public string ExpectedResultFile { get;set; }

       public string ReadResultsFile() {
           Assembly thisAssembly = this.GetType().Assembly;
           StringBuilder resultsFile = new StringBuilder();

           Stream stream = thisAssembly.GetManifestResourceStream(this.ExpectedResultFile);
           if (stream == null) {
               throw new InvalidOperationException("Unknown manifest resource stream " + this.ExpectedResultFile);
           }

           using (StreamReader sr = new StreamReader(stream)) {
               string line;
               while ((line = sr.ReadLine()) != null) {
                   if (line.Length == 0 || line[0] == '#') {
                       // Skip "comment" line
                       continue;
                   }

                   resultsFile.AppendLine(line);
               }
           }

           resultsFile.Remove(resultsFile.Length - Environment.NewLine.Length, Environment.NewLine.Length);
           return resultsFile.ToString();
       }
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class TestDataDirectories {
		private static readonly string ThisAssemblyName = typeof(TestDataDirectory).Assembly.GetName().Name;

        public static class MethodOrdering {
            public static TestDataDirectory Simple() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.MethodOrdering.Simple.Test.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.MethodOrdering.Simple.ExpectedTestResult.txt"
                };
            }
        }

        public static class PlainFixtureOrdering {
            public static TestDataDirectory HierarchySetupTeardown() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.HierarchySetupTeardown.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.HierarchySetupTeardown.RootOrderedTestFixture.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.PlainFixtureOrdering.HierarchySetupTeardown.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory NestedDeepHierarchy() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.NestedDeepHierarchy.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.NestedDeepHierarchy.DeepOrderedTestFixtureFirst.cs",
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.NestedDeepHierarchy.DeepOrderedTestFixtureFirst_Child.cs",
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.NestedDeepHierarchy.RootOrderedTestFixture.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.PlainFixtureOrdering.NestedDeepHierarchy.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory OneDeepHierarchy() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.OneDeepHierarchy.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.PlainFixtureOrdering.OneDeepHierarchy.RootOrderedTestFixture.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.PlainFixtureOrdering.OneDeepHierarchy.ExpectedTestResult.txt"
                };
            }
        }

        public static class TestExecution {
            public static TestDataDirectory Fail_NestedDeepHierarchy_OtherTestsRunInRoot() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot.DeepOrderedTestFixtureFirst.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot.DeepOrderedTestFixtureFirst_Child.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot.RootOrderedTestFixture.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash.DeepOrderedTestFixtureFirst.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash.DeepOrderedTestFixtureFirst_Child.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash.RootOrderedTestFixture.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestExecution.Fail_NestedDeepHierarchy_OtherTestsRunInRoot_NestedCrash.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory Fail_OneDeepHierarchy_OtherTestsRun() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_OneDeepHierarchy_OtherTestsRun.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_OneDeepHierarchy_OtherTestsRun.RootOrderedTestFixture.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestExecution.Fail_OneDeepHierarchy_OtherTestsRun.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory Fail_OneDeepHierarchy_OtherTestsSkipped() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_OneDeepHierarchy_OtherTestsSkipped.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.TestExecution.Fail_OneDeepHierarchy_OtherTestsSkipped.RootOrderedTestFixture.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestExecution.Fail_OneDeepHierarchy_OtherTestsSkipped.ExpectedTestResult.txt"
                };
            }
        }

        public static class TestIntegrity {
            public static TestDataDirectory OrderedWithOrderAttribute() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestIntegrity.OrderedWithOrderAttribute.Test.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestIntegrity.OrderedWithOrderAttribute.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory Single() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestIntegrity.Single.Test.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestIntegrity.Single.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory Single_WithActionAttribute() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestIntegrity.Single_WithActionAttribute.AssemblyInfo.cs",
                             ThisAssemblyName + "." + "TestData.TestIntegrity.Single_WithActionAttribute.Test.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestIntegrity.Single_WithActionAttribute.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory Single_WithSetupFixture() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestIntegrity.Single_WithSetupFixture.GlobalSetUpFixture.cs",
                             ThisAssemblyName + "." + "TestData.TestIntegrity.Single_WithSetupFixture.NamespaceSetUpFixture.cs",
                             ThisAssemblyName + "." + "TestData.TestIntegrity.Single_WithSetupFixture.Test.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestIntegrity.Single_WithSetupFixture.ExpectedTestResult.txt"
                };
            }
            public static TestDataDirectory Single_WithSetupTeardown() {
                return new TestDataDirectory {
                    Files = new [] {
                             ThisAssemblyName + "." + "TestData.TestIntegrity.Single_WithSetupTeardown.Test.cs",
                             ThisAssemblyName + "." + @"TestData.Common.cs"
                        },

                    ExpectedResultFile = ThisAssemblyName + ".TestData.TestIntegrity.Single_WithSetupTeardown.ExpectedTestResult.txt"
                };
            }
        }

   }
}