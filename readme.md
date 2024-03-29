#Setup
* UnitTestcases execute as it is. There are two failing testcases which require the implemention of the JSON and XML Parser
* to test the failed Testcases, the dummy returned lists in file XMLInputFileParser.cs and JSONInputFileParser.cs be modified to the expected in the UnitTest Cases.
* The console app expects the first argument passed as a file path for the input file.
* The project can also be run in debug mode as project properties have been changed to include argument as a valid file path.
* Additional DLL was required Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll

## Solution Thought Process Steps
* TDD being followed
* Create Test Cases
* Create required classes for Asserts to fail
* Include dll Microsoft.VisualStudio.QualityTools.UnitTestFramework to be able to use  CollectionAssert.AreEqual for comparing two lists
* Implement Factory Design pattern to handle the parsing of input file depending on file extension
* Change implmentation pattern to Strategy as best suited as described in https://code-maze.com/strategy/
* When should Stratgey Pattern be used :- "We should use this pattern whenever we have different variations for some functionality in an object and we want to switch from one variation to another in a runtime."
* Generate Models for JSON and XML file using online tool
* Refactor code and testcases 

## To Do
* Implement logic to Parse JSON and XML file based on generated model and fetch required data
* Add more Unit Test CAses for valid scenarios.
* Optimise code to remove redundant code for file validity and checks
* Implement code to detect poorly formatted file or corrupt file.
* Scalability
	* Implement Participant object from which Horse/OtherParticipants can derive
	* Implement Logging and provide various method to output results

##Note on timeline
* I wasnt able to dedicate entire 2 hours at a stretch to it and had to suspend the task after aruond 1:45mins
* Total duration taken for the assignment shouldnt be more than 2hours excluding final documentation.