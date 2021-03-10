This is a group project that are made for CME1251 Project Based Learning class at first year of computer engineering department at Dokuz Eylul University. 03-12-2018

Group Members:
  
   Emirhan KAYA - https://github.com/EmirhanK17
   Pınar BEŞİR
   
   
The aim of the project is to develop a two-player, two-level strategy game in which rewards and penalties determine the way of players to the treasure. The first player who reaches the treasure wins the game.
   
Initially, each player waits in the starting lounge of the game board. Player (P) plays the game first. Players throw the dice in each turn to move on the board. According to the number on the dice, players take step. After both players play, round number is updated. The first player who reaches the treasure wins the game. The game includes 2 boards: 1 dimensional board and 2 dimensional board. User can select the board type from the menu at the beginning of the game. Boards consist of squares. 1D board has 1 x 25 squares, and 2D board has 12 x 12 squares.

Game Elements:
  
    2 players: P (Player) &amp; C (Computer)
    Treasure point: T
    Rewards/penalties:
    @ : Go back to the starting point
    # : Wait 1 hand
    ► : Go right 3 steps
    ◄ : Go left 3 steps
    * : Move again the same number of steps in the same direction
    L : Gain 1 life
    X : Lose 1 life
    N : Find the nearest reward/penalty and apply it
    ▼ : Go down 3 steps
    ▲ : Go up 3 steps
    
Game Initialization:

    Rewards / penalties and the walls are placed on the board randomly at the beginning of the game. Rewards and penalties cannot be located on the treasure square. Boards        consist of randomly placed penalties or rewards for the players. In 1D board, there are randomly generated 8 rewards / penalties (1 set of 1D rewards/penalties (8 types): @, #, ►, ◄, *, L, X, and N) In 2D board there are randomly generated 40 rewards / penalties (4 sets of all rewards/penalties (10 types)). 2D rewards/penalties also include: and . There can be no more than 4 rewards/penalties in the same row or column.
    
    
Game Playing Rules:

    Initially players have one life each. If a player loses all his lifes, other player wins. In 1D board, the moves by throwing dice are always to the right. In 2D board, the moves by throwing dice are to the right or down randomly. If the player comes to a reward/penalty square, and this reward/penalty sends the player to another reward/penalty, all the subsequent rewards/penalties are applied (max. 20 rewards/penalties). In the case of exceeding the board limits, the player cannot move and stays in his/her place, other player's turn begins. If the players meet on the same square, the newcomer sends the other player to the starting point.
    

  
