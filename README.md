
# Games Engines Assignment

Helen Murphy
C15303381
DT282-4

## Games Description
### Maze Generation
For my game I made a procedurally generated maze. The maze is created by first spawning a grid, of number rows and columns of the users choosing. Once the grid is made, it then follows an algorithm, called GridDestroyMazeAlgorithm in my code. This algorithm randomly selects a number between 1 and 4, this is then taken as a cardinal direction. The game visits each cell in the grid, picks a direction, then destroys the wall in that direction creating a path. Once the path is completed the code goes back over the grid checking that each cell has been visited, if the cell has not been visited, a wall is destroyed to add it to the path, creating some deadends. 
### User and End-Point
The user is simply a cube, with rotational and directional controls. It is spawned in after the maze has been completed at 0,0. The end point is a small neon green circle that the user must find to finish the game. This point has an ontrigggerenter function so that when the player enters the circle the game finishes. This End-point is spawned in after the player, i originally tried to make it choose a random point within the maze, but it ended up near the player sometimes so decided to spawn it at the opposite side of the map.

## Development
The Maze generation algorithms I got off watching many tutorials online and putting them together. I developed the prodecurally generated numbers function myself. All the player and end point was created by myself, I reused my tank controller script on the player

## What I'm proud of
I'm most proud of randomising the numbers and applying it to the directions. This means that everytime it is initialised the maze is different. I thought it was a simple but effective way of doing that.

## YouTube
[!Youtube[(http://img.youtube.com/vi/5A4s1o-0ato/0.jpg)](https://youtu.be/5A4s1o-0ato "Games Engines")
