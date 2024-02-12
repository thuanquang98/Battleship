# Console Battleship Game
## Goal
- Play the classic battleship board game on the CLI with an AI or your friend. 

## Getting Started
### Prerequisites

### Installation
1. Download and run the .exe file

## How-to
### The Menu
-  When the game is started, the console will be opened and display 4 options
    -   "(1) - Singleplayer"
    -   "(2) - Multiplayer"
    -   "(3) - Help"
    -   "(4) - Exit"
- Choose any of the options by entering the number that corresponds to the option you want to choose and then pressing Enter
### The Game
- This battleship game will have the same rules as the traditional board game. Whoever destroys all the ships of the opponent first wins!
- This game will also include abilities that the player can use against the opponent. Abilities include:
    - Strafe run - attack 4 cells in a line vertically or horizontally on the opponent board
    - Bombardment - Fires 4 shots at 4 random cells on the opponent board
    - Mine - Place a mine on your board, if the opponent hits the mine, it will randomly damage one of the ships of the opponent
    - Precision Strike - Attack 4 cell square on the opponent board
#### Start phase
   - Player will get to choose where to place their ships
   - Their ships include:
       - carrier (5 cells)
       - battleship (4 cells)
       - cruise (3 cells)
       - submarine (3 cells)
       - patrol boat (2 cells)
   - In the command line, the prompt will tell you the ship's name and the number of cells it takes up
       - it will ask for 'v' or 'h' to decide the ship's placement vertically or horizontally
       - it will ask for the starting cell and end cell in the following format `[row 1-10][col A-J] [row 1-10][col A-J]`
       - it will prompt an error message accordingly based on what the user error is. e.g "You can only place the ship vertically or horizontally"
   - After the player places their ships on the board, the game itself will randomly decide who start
#### Battle phase
   - The player will given two modes to choose from the prompt
       - (1) Fire mode - ask for cell coordinate to fire with the following format [column][row]
       - (2) Skill mode - display a list of available weapons
       - (3) Help mode - display how to play the game and command to play
       - (0) Exit (enter 'y' or 'n' to confirm the choice)
    

#### End phase
   - The game will end when either all player's ships have been sunk or a player quits the game.
