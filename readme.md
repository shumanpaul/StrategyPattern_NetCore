#Setup
* UnitTestcases execute as it is. There are two failing testcases which require the implemention of the JSON and XML Parser
* to test the failed Testcases, the dummy returned lists in file XMLInputFileParser.cs and JSONInputFileParser.cs be modified to the expected in the UnitTest Cases.
* The console app expects the first argument passed as a file path for the input file.
* The project can also be run in debug mode as project properties have been changed to include argument as a valid file path.
* Additional DLL was required Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll