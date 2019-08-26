#Implementaion Notes
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