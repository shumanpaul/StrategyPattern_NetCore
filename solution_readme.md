## Solution Thought Process Steps
* Create Test Cases
* Create required classes for Asserts to fail
* Include dll Microsoft.VisualStudio.QualityTools.UnitTestFramework to be able to use  CollectionAssert.AreEqual for comparing two lists
* Implement Factory Design pattern to handle the parsing of input file depending on file extension
* Change implmentation pattern to Strategy as best suited as described in https://code-maze.com/strategy/
* When should Stratgey Pattern be used :- "We should use this pattern whenever we have different variations for some functionality in an object and we want to switch from one variation to another in a runtime."
