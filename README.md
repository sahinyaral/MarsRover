# MarsRover 
NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading.

Input:
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. 
The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.

The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation.
Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

Output:
The output for each rover should be its final co-ordinates and heading

Input and Output Example
Test Input: 55 12N LMLMLMLMM -> Expected Output:1 3 N
Test Input: 55 33E MMRMMRMRRM -> Expected Output:5 1 E

Test Input: 55 12N LMLMLMLMM 33E MMRMMRMRRM -> Expected Output: 1 3 N 5 1 E
