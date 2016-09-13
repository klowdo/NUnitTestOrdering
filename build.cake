//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var verbosity = Argument<Verbosity>("verbosity", Verbosity.Minimal);

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var baseName = "NUnitTestOrdering";
var buildDir = Directory("./build") + Directory(configuration);
var assemblyInfoFile = Directory("./src") + File("CommonAssemblyInfo.cs");
var dotCoverResultFile = buildDir + File("CoverageResults.dcvr");


//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() => {
    CleanDirectory(buildDir);
	CleanDirectories("./src/**/bin");
	CleanDirectories("./src/**/obj");
});

Task("Rebuild")
	.IsDependentOn("Clean")
	.IsDependentOn("Build");

Task("Restore-NuGet-Packages")
    .Does(() => {
    NuGetRestore($"./{baseName}.sln");
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() => {
        MSBuild($"./{baseName}.sln", settings => 
            settings.SetConfiguration(configuration)
                    .UseToolVersion(MSBuildToolVersion.VS2015)
                    .SetVerbosity(verbosity)
                    );
});

Task("Test")
    .IsDependentOn("Build")
	.Description("Run all unit tests - under code coverage")
    .Does(() => {
        DotCoverAnalyse(
			tool => {
				tool.NUnit3("./build/" + configuration + "/**/*.Tests.dll", new NUnit3Settings {
					NoHeader = true,
					NoColor = false,
					TeamCity = TeamCity.IsRunningOnTeamCity,
					OutputFile = buildDir + File("NUnitTestResults.xml"),
					Full = true
				});
			},
			dotCoverResultFile,
			new DotCoverAnalyseSettings () 
				.WithFilter($"+:{baseName}")
				.WithFilter("-:*.Tests")
        );
});

Task("NuGet-Test")
	.IsDependentOn("Rebuild")
	.Description("Run all unit tests in preperation nupack")
	.Does(() => {
		NUnit3("./build/" + configuration + "/**/*.Tests.dll", new NUnit3Settings {
			NoHeader = true,
			NoColor = false,
			TeamCity = TeamCity.IsRunningOnTeamCity,
			OutputFile = buildDir + File("NUnitTestResults.xml"),
			Full = true
		});
});

Task("TeamCity")
	.IsDependentOn("Test");

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("None");

Task("Default")
    .IsDependentOn("Test");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);