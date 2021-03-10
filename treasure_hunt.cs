using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasure_hunt_v1
{
    class Program
    {
        static void tutorial1d_3()
        {
            Console.Clear();
            Console.WriteLine("                                                          TUTORIAL");
            Console.WriteLine();
            Console.WriteLine("                                  ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║      LOUNGE          Turn: P                                 ║");
            Console.WriteLine("                                  ║     + - - - +        Dice: 3                                 ║");
            Console.WriteLine("                                  ║     | P | C |        Life of P: 1                            ║");
            Console.WriteLine("                                  ║     + - - - +        Life of C: 1                            ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║           ------------- Round 1 -----------------            ║");
            Console.WriteLine("                                  ║      1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5       ║");
            Console.WriteLine("                                  ║    + - - - - - - - - - - - - - - - - - - - - - - - - - +     ║");
            Console.WriteLine("                                  ║    | . . > . . . @ # . . N . L . . < . . * . . . X . T |     ║");
            Console.WriteLine("                                  ║    + - - - - - - - - - - - - - - - - - - - - - - - - - +     ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║     LOUNGE           Turn: P                                 ║");
            Console.WriteLine("                                  ║     + - - - +        Dice: 3                                 ║");
            Console.WriteLine("                                  ║     | . | C |        Life of P: 1                            ║");
            Console.WriteLine("                                  ║     + - - - +        Life of C: 1                            ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║           ------------- Round 1 -----------------            ║");
            Console.WriteLine("                                  ║      1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5       ║");
            Console.WriteLine("                                  ║    + - - - - - - - - - - - - - - - - - - - - - - - - - +     ║");
            Console.WriteLine("                                  ║    | . . P . . . @ # . . N . L . . < . . * . . . X . T |     ║");
            Console.WriteLine("                                  ║    + - - - - - - - - - - - - - - - - - - - - - - - - - +     ║");
            Console.WriteLine("                                  ║        Go right 3 steps                                      ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║     LOUNGE           Turn: C                                 ║");
            Console.WriteLine("                                  ║     + - - - +        Dice: 2                                 ║");
            Console.WriteLine("                                  ║     | . | . |        Life of P: 1                            ║");
            Console.WriteLine("                                  ║     + - - - +        Life of C: 1                            ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║           ------------- Round 1 -----------------            ║");
            Console.WriteLine("                                  ║      1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5       ║");
            Console.WriteLine("                                  ║    + - - - - - - - - - - - - - - - - - - - - - - - - - +     ║");
            Console.WriteLine("                                  ║    | . C > . . P @ # . . N . L . . < . . * . . . X . T |     ║");
            Console.WriteLine("                                  ║    + - - - - - - - - - - - - - - - - - - - - - - - - - +     ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║        (1)Back                               Play Game(2)    ║");
            Console.WriteLine("                                  ║       <--------                               -------->      ║");
            Console.WriteLine("                                  ╚══════════════════════════════════════════════════════════════╝");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '1')
            {
                tutorial1d_2();
            }
            else if (info.KeyChar == '2')
            {
                
            }
            else
            {
                tutorial1d_3();
            }
        }
        static void tutorial1d_2()
        {
            Console.Clear();
            Console.WriteLine("                                                          TUTORIAL");
            Console.WriteLine();
            Console.WriteLine("                                  ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║                     GAME PLAYING RULES                       ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # Initially, players have one life each. If player loses    ║");
            Console.WriteLine("                                  ║ his lifes, other player wins.                                ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # In 1D board, the moves by throwing dice are always to     ║");
            Console.WriteLine("                                  ║ the right.                                                   ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # If the player comes to a reward/penalty square, and this  ║");
            Console.WriteLine("                                  ║ reward/penalty sends the player to another reward/penalty,   ║");
            Console.WriteLine("                                  ║ all subsequent rewards/penalties are applied.                ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # In the case of exceeding the board limits, the player     ║");
            Console.WriteLine("                                  ║ cannot move and stays in his/her place, other player's turn  ║");
            Console.WriteLine("                                  ║ begins.                                                      ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # If the players meet on the same square, the newcomer      ║");
            Console.WriteLine("                                  ║ sends the another player to the starting point.              ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║    (1)Back                                   Next(2)         ║");
            Console.WriteLine("                                  ║    <-------                                  ------>         ║");
            Console.WriteLine("                                  ╚══════════════════════════════════════════════════════════════╝");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '1')
            {
                tutorial1d_1();
            }
            else if (info.KeyChar == '2')
            {
                tutorial1d_3();
            }
            else
            {
                tutorial1d_2();
            }
        }
        static void tutorial1d_1()
        {
            Console.Clear();
            Console.WriteLine("                                                          TUTORIAL");
            Console.WriteLine();
            Console.WriteLine("                                  ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║                    GENERAL INFORMATION                       ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # Initially, each player waits in the starting lounge.      ║");
            Console.WriteLine("                                  ║  # Player(P) plays the game first.                           ║");
            Console.WriteLine("                                  ║  # Players throw the dice in each turn to move on the board. ║");
            Console.WriteLine("                                  ║  # According to the number on the dice, players take step.   ║");
            Console.WriteLine("                                  ║  # After both players play, round number is updated.         ║");
            Console.WriteLine("                                  ║  # The first player who reaches the treasure wins the game.  ║");
            Console.WriteLine("                                  ║  # 1D board has 1x25 squares.                                ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║                     GAME ELEMENTS                            ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # 2 player: P(player) & C(computer)                         ║");
            Console.WriteLine("                                  ║  # Treasure point: T                                         ║");
            Console.WriteLine("                                  ║  # Rewards/Penalties:                                        ║");
            Console.WriteLine("                                  ║     1. @: Go back to the starting point                      ║");
            Console.WriteLine("                                  ║     2. #: Wait 1 round                                       ║");
            Console.WriteLine("                                  ║     3. >: Go right 3 steps                                   ║");
            Console.WriteLine("                                  ║     4. <: Go left 3 steps                                    ║");
            Console.WriteLine("                                  ║     5. *: Move again the same number of steps                ║");
            Console.WriteLine("                                  ║     6. L: Gain 1 life                                        ║");
            Console.WriteLine("                                  ║     7. X: Lose 1 life                                        ║");
            Console.WriteLine("                                  ║     8. N: Find the nearest reward/penalty and apply it       ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║     (1)Menu                                   Next(2)        ║");
            Console.WriteLine("                                  ║     <------                                   ------>        ║");
            Console.WriteLine("                                  ╚══════════════════════════════════════════════════════════════╝");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '2')
            {
                tutorial1d_2();
            }
            else if (info.KeyChar == '1')
            {
                menu();
            }
            else
            {
                tutorial1d_1();
            }

        }
        static void tutorial2d_1()
        {
            Console.Clear();
            Console.WriteLine("                                                          TUTORIAL");
            Console.WriteLine();
            Console.WriteLine("                                  ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║                    GENERAL INFORMATION                       ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # Initially, each player waits in the starting lounge.      ║");
            Console.WriteLine("                                  ║  # Player(P) plays the game first.                           ║");
            Console.WriteLine("                                  ║  # Players throw the dice in each turn to move on the board. ║");
            Console.WriteLine("                                  ║  # According to the number on the dice, players take step.   ║");
            Console.WriteLine("                                  ║  # After both players play, round number is updated.         ║");
            Console.WriteLine("                                  ║  # The first player who reaches the treasure wins the game.  ║");
            Console.WriteLine("                                  ║  # 1D board has 12x12 squares.                               ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║                     GAME ELEMENTS                            ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # 2 player: P(player) & C(computer)                         ║");
            Console.WriteLine("                                  ║  # Treasure point: T                                         ║");
            Console.WriteLine("                                  ║  # Rewards/Penalties:                                        ║");
            Console.WriteLine("                                  ║     1. @: Go back to the starting point                      ║");
            Console.WriteLine("                                  ║     2. #: Wait 1 round                                       ║");
            Console.WriteLine("                                  ║     3. >: Go right 3 steps                                   ║");
            Console.WriteLine("                                  ║     4. <: Go left 3 steps                                    ║");
            Console.WriteLine("                                  ║     5. *: Move again the same number of steps                ║");
            Console.WriteLine("                                  ║     6. L: Gain 1 life                                        ║");
            Console.WriteLine("                                  ║     7. X: Lose 1 life                                        ║");
            Console.WriteLine("                                  ║     8. N: Find the nearest reward/penalty and apply it       ║");
            Console.WriteLine("                                  ║     8. v: Go down 3 steps                                    ║");
            Console.WriteLine("                                  ║     8. ^: Go up 3 steps                                      ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║     (1)Menu                                   Next(2)        ║");
            Console.WriteLine("                                  ║     <------                                   ------>        ║");
            Console.WriteLine("                                  ╚══════════════════════════════════════════════════════════════╝");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '2')
            {
                tutorial2d_2();
            }
            else if (info.KeyChar == '1')
            {
                menu();
            }
            else
            {
                tutorial2d_1();
            }
        }
        static void tutorial2d_2()
        {
            Console.Clear();
            Console.WriteLine("                                                          TUTORIAL");
            Console.WriteLine();
            Console.WriteLine("                                  ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║                     GAME PLAYING RULES                       ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # Initially, players have one life each. If player loses    ║");
            Console.WriteLine("                                  ║ his lifes, other player wins.                                ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # In 1D board, the moves by throwing dice are always to     ║");
            Console.WriteLine("                                  ║ the right.                                                   ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # If the player comes to a reward/penalty square, and this  ║");
            Console.WriteLine("                                  ║ reward/penalty sends the player to another reward/penalty,   ║");
            Console.WriteLine("                                  ║ all subsequent rewards/penalties are applied.                ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # In the case of exceeding the board limits, the player     ║");
            Console.WriteLine("                                  ║ cannot move and stays in his/her place, other player's turn  ║");
            Console.WriteLine("                                  ║ begins.                                                      ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║  # If the players meet on the same square, the newcomer      ║");
            Console.WriteLine("                                  ║ sends the another player to the starting point.              ║");
            Console.WriteLine("                                  ║                                                              ║");
            Console.WriteLine("                                  ║    (1)Back                                   Next(2)         ║");
            Console.WriteLine("                                  ║    <-------                                  ------>         ║");
            Console.WriteLine("                                  ╚══════════════════════════════════════════════════════════════╝");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '1')
            {
                tutorial2d_1();
            }
            else if (info.KeyChar == '2')
            {
                tutorial2d_3();
            }
            else
            {
                tutorial2d_2();
            }
        }
        static void tutorial2d_3()
        {
            Console.Clear();
            Console.WriteLine("                                                          TUTORIAL");
            Console.WriteLine();
            Console.WriteLine("                                  ╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                  ║                                                            ║");
            Console.WriteLine("                                  ║  LOUNGE        ------------- Round 1 -----------------     ║");
            Console.WriteLine("                                  ║ + - - - +            1 2 3 4 5 6 7 8 9 0 1 2               ║");
            Console.WriteLine("                                  ║ | P | C |          + - - - - - - - - - - - - +             ║");
            Console.WriteLine("                                  ║ + - - - +         1| . . . . ^ . v . . . . L |             ║");
            Console.WriteLine("                                  ║                   2| . . # . . * X > . . . . |             ║");
            Console.WriteLine("                                  ║ Turn: P           3| L . . N . . < . . . v . |             ║");
            Console.WriteLine("                                  ║ Dice: 3           4| @ . . . L . . @ . L . . |             ║");
            Console.WriteLine("                                  ║ Direction: v      5| @ . . . N . . . . # N . |             ║");
            Console.WriteLine("                                  ║ Life of P: 1      6| . . . v . . . . . . . . |             ║");
            Console.WriteLine("                                  ║ Life of C: 1      7| . @ . . # . . > . . * . |             ║");
            Console.WriteLine("                                  ║                   8| . . . . . . . . X . . < |             ║");
            Console.WriteLine("                                  ║                   9| . < . . . * . . . . . . |             ║");
            Console.WriteLine("                                  ║                   0| * . . X . ^ . . v . . . |             ║");
            Console.WriteLine("                                  ║                   1| . # ^ X . . . . . . > . |             ║");
            Console.WriteLine("                                  ║                   2| . > . . . < N . . ^ . T |             ║");
            Console.WriteLine("                                  ║                    + - - - - - - - - - - - - +             ║");
            Console.WriteLine("                                  ║                                                            ║");
            Console.WriteLine("                                  ║  LOUNGE        ------------- Round 1 -----------------     ║");
            Console.WriteLine("                                  ║ + - - - +            1 2 3 4 5 6 7 8 9 0 1 2               ║");
            Console.WriteLine("                                  ║ | . | C |          + - - - - - - - - - - - - +             ║");
            Console.WriteLine("                                  ║ + - - - +         1| . . . . ^ . v . . . . L |             ║");
            Console.WriteLine("                                  ║                   2| . . # . . * X > . . . . |             ║");
            Console.WriteLine("                                  ║ Turn: P           3| P . . N . . < . . . v . |             ║");
            Console.WriteLine("                                  ║ Dice: 3           4| @ . . . L . . @ . L . . |             ║");
            Console.WriteLine("                                  ║ Direction: v      5| @ . . . N . . . . # N . |             ║");
            Console.WriteLine("                                  ║ Life of P: 2      6| . . . v . . . . . . . . |             ║");
            Console.WriteLine("                                  ║ Life of C: 1      7| . @ . . # . . > . . * . |             ║");
            Console.WriteLine("                                  ║                   8| . . . . . . . . X . . < |             ║");
            Console.WriteLine("                                  ║ P gain 1 life     9| . < . . . * . . . . . . |             ║");
            Console.WriteLine("                                  ║                   0| * . . X . ^ . . v . . . |             ║");
            Console.WriteLine("                                  ║                   1| . # ^ X . . . . . . > . |             ║");
            Console.WriteLine("                                  ║                   2| . > . . . < N . . ^ . T |             ║");
            Console.WriteLine("                                  ║                    + - - - - - - - - - - - - +             ║");
            Console.WriteLine("                                  ║                                                            ║");
            Console.WriteLine("                                  ║                                            Play Game(2)    ║");
            Console.WriteLine("                                  ║                                           ------------->   ║");
            Console.WriteLine("                                  ╚════════════════════════════════════════════════════════════╝");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '1')
            {
                tutorial1d_2();
            }
            else if (info.KeyChar == '2')
            {

            }
            else
            {
                tutorial1d_3();
            }
        }
        static void menu()
        {
            Console.Clear();


            //Coloured text with Console.Color command.
            int a;//Created an integer variable for creating game title.

            //Console.SetCursorPosition commands for " T " 
            Console.SetCursorPosition(8, 1);
            Console.Write("XXXXXXXXXXXX");
            Console.SetCursorPosition(8, 2);
            Console.Write("XXXXXXXXXXXX");
            for (a = 3; a < 10; a++)
            {
                Console.SetCursorPosition(13, a);
                Console.Write("XXX");

            }

            //Console.SetCursorPosition commands for " R " 
            for (a = 1; a < 10; a++)
            {
                Console.SetCursorPosition(22, a);
                Console.Write("XX");
            }
            Console.SetCursorPosition(24, 1);
            Console.Write("XX");
            Console.SetCursorPosition(26, 2);
            Console.Write("XXX");
            Console.SetCursorPosition(28, 3);
            Console.Write("XXX");
            Console.SetCursorPosition(26, 4);
            Console.Write("XXX");
            Console.SetCursorPosition(24, 5);
            Console.Write("XXX");
            Console.SetCursorPosition(23, 6);
            Console.Write("XXX");
            Console.SetCursorPosition(25, 7);
            Console.Write("XXX");
            Console.SetCursorPosition(26, 8);
            Console.Write("XXX");
            Console.SetCursorPosition(27, 9);
            Console.Write("XXX");


            //Console.SetCursorPosition commands for " E " 
            Console.SetCursorPosition(33, 1);
            Console.Write("XXXXXXXXX");
            Console.SetCursorPosition(33, 5);
            Console.Write("XXXXXXXXX");
            Console.SetCursorPosition(33, 9);
            Console.Write("XXXXXXXXX");
            Console.SetCursorPosition(33, 2);
            Console.Write("XXX");
            Console.SetCursorPosition(33, 3);
            Console.Write("XXX");
            Console.SetCursorPosition(33, 4);
            Console.Write("XXX");
            Console.SetCursorPosition(33, 6);
            Console.Write("XXX");
            Console.SetCursorPosition(33, 7);
            Console.Write("XXX");
            Console.SetCursorPosition(33, 8);
            Console.Write("XXX");

            //Console.SetCursorPosition commands for " A "
            Console.SetCursorPosition(49, 1);
            Console.Write("XXX");
            Console.SetCursorPosition(46, 2);
            Console.Write("XXX");
            Console.SetCursorPosition(44, 3);
            Console.Write("XXX");
            Console.SetCursorPosition(51, 2);
            Console.Write("XXX");
            Console.SetCursorPosition(53, 3);
            Console.Write("XXX");
            Console.SetCursorPosition(47, 6);
            Console.Write("XXXXXXX");

            for (a = 4; a < 10; a++)
            {
                Console.SetCursorPosition(44, a);
                Console.Write("XX");
            }

            for (a = 4; a < 10; a++)
            {
                Console.SetCursorPosition(55, a);
                Console.Write("XX");
            }

            //Console.SetCursorPosition commands for " S "
            Console.SetCursorPosition(60, 1);
            Console.Write("XXXXXXXXX");
            Console.SetCursorPosition(68, 2);
            Console.Write("XX");
            Console.SetCursorPosition(59, 2);
            Console.Write("XX");
            Console.SetCursorPosition(59, 3);
            Console.Write("XX");
            Console.SetCursorPosition(59, 4);
            Console.Write("XX");
            Console.SetCursorPosition(60, 5);
            Console.Write("XXXXXXXX");
            Console.SetCursorPosition(67, 6);
            Console.Write("XX");
            Console.SetCursorPosition(67, 7);
            Console.Write("XX");
            Console.SetCursorPosition(67, 8);
            Console.Write("XX");
            Console.SetCursorPosition(60, 9);
            Console.Write("XXXXXXXX");
            Console.SetCursorPosition(59, 8);
            Console.Write("XX");

            //Console.SetCursorPosition commands for " U "

            for (a = 1; a < 10; a++)
            {
                Console.SetCursorPosition(72, a);
                Console.WriteLine("XX");
            }
            for (a = 1; a < 10; a++)
            {
                Console.SetCursorPosition(82, a);
                Console.WriteLine("XX");
            }

            Console.SetCursorPosition(73, 9);
            Console.WriteLine("XXXXXXXXX");

            //Console.SetCursorPosition commands for " R " 
            for (a = 1; a < 10; a++)
            {
                Console.SetCursorPosition(86, a);
                Console.Write("XX");
            }
            Console.SetCursorPosition(88, 1);
            Console.Write("XX");
            Console.SetCursorPosition(90, 2);
            Console.Write("XXX");
            Console.SetCursorPosition(92, 3);
            Console.Write("XXX");
            Console.SetCursorPosition(90, 4);
            Console.Write("XXX");
            Console.SetCursorPosition(88, 5);
            Console.Write("XXX");
            Console.SetCursorPosition(87, 6);
            Console.Write("XXX");
            Console.SetCursorPosition(89, 7);
            Console.Write("XXX");
            Console.SetCursorPosition(90, 8);
            Console.Write("XXX");
            Console.SetCursorPosition(91, 9);
            Console.Write("XXX");

            //Console.SetCursorPosition commands for " E " 
            Console.SetCursorPosition(97, 1);
            Console.Write("XXXXXXXXX");
            Console.SetCursorPosition(97, 5);
            Console.Write("XXXXXXXXX");
            Console.SetCursorPosition(97, 9);
            Console.Write("XXXXXXXXX");
            Console.SetCursorPosition(97, 2);
            Console.Write("XXX");
            Console.SetCursorPosition(97, 3);
            Console.Write("XXX");
            Console.SetCursorPosition(97, 4);
            Console.Write("XXX");
            Console.SetCursorPosition(97, 6);
            Console.Write("XXX");
            Console.SetCursorPosition(97, 7);
            Console.Write("XXX");
            Console.SetCursorPosition(97, 8);
            Console.Write("XXX");

            //Console.SetCursorPosition commands for " H "

            for (a = 11; a < 18; a++)
            {
                Console.SetCursorPosition(30, a);
                Console.Write("XX");
            }
            for (a = 11; a < 18; a++)
            {
                Console.SetCursorPosition(40, a);
                Console.Write("XX");
            }

            Console.SetCursorPosition(32, 14);
            Console.WriteLine("XXXXXXXX");

            //Console.SetCursorPosition commands for " U "

            for (a = 11; a < 18; a++)
            {
                Console.SetCursorPosition(44, a);
                Console.WriteLine("XX");
            }
            for (a = 11; a < 18; a++)
            {
                Console.SetCursorPosition(54, a);
                Console.WriteLine("XX");
            }

            Console.SetCursorPosition(45, 17);
            Console.WriteLine("XXXXXXXXX");

            //Console.SetCursorPosition commands for " U "

            for (a = 11; a < 18; a++)
            {
                Console.SetCursorPosition(58, a);
                Console.WriteLine("XX");
            }
            for (a = 11; a < 18; a++)
            {
                Console.SetCursorPosition(68, a);
                Console.WriteLine("XX");
            }

            Console.SetCursorPosition(59, 11);
            Console.WriteLine("XX");
            Console.SetCursorPosition(61, 12);
            Console.WriteLine("XX");
            Console.SetCursorPosition(62, 13);
            Console.WriteLine("XX");
            Console.SetCursorPosition(63, 14);
            Console.WriteLine("XX");
            Console.SetCursorPosition(64, 15);
            Console.WriteLine("XX");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("XX");
            Console.SetCursorPosition(67, 17);
            Console.WriteLine("XX");

            //Console.SetCursorPosition commands for " T "
            Console.SetCursorPosition(72, 11);
            Console.Write("XXXXXXXXXX");

            for (a = 12; a < 18; a++)
            {
                Console.SetCursorPosition(76, a);
                Console.Write("XX");

            }



            //Game options
            Console.SetCursorPosition(50, 22);
            Console.WriteLine("1. Play Game");
            Console.SetCursorPosition(50, 24);
            Console.WriteLine("2. Exit");


            //Take Key vairable.
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.SetCursorPosition(46, 12);
                    Console.WriteLine("1D BOARD  (Press 1)");
                    Console.SetCursorPosition(41, 14);
                    Console.WriteLine("    2D BOARD  (Press 2)");
                    ConsoleKeyInfo info1 = Console.ReadKey();
                    switch (info1.KeyChar)
                    {
                        case '1':
                            Console.Clear();
                            game_1d();
                            break;
                        case '2':
                            Console.Clear();
                            game_2d();
                            break;
                    }
                    break;
                case '2':
                    Environment.Exit(1);//Exit the game.
                    break;
            }
        }
        static void game_1d()
        {
            Console.WriteLine("Do you want to see tutorial?(Y/N)");
            ConsoleKeyInfo info = Console.ReadKey();
            if(info.KeyChar=='y'|| info.KeyChar == 'Y')
            {
                tutorial1d_1();
            }
            else { }
            Console.Clear();
            board:
            string WinnerMessage = null;
            int choice3;
            int x;
            Console.SetCursorPosition(2, 4); Console.WriteLine("LOUNGE");
            Console.SetCursorPosition(1, 5); Console.Write("+ - - - +");
            Console.SetCursorPosition(1, 6); Console.Write("| . | . |");
            Console.SetCursorPosition(1, 7); Console.Write("+ - - - +");
            Console.SetCursorPosition(25, 4); Console.Write("1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5");
            Console.SetCursorPosition(23, 5); Console.Write("+ - - - - - - - - - - - - - - - - - - - - - - - - - +");
            Console.SetCursorPosition(23, 6); Console.Write("|");
            string[] Map = new string[26];
            for (int i = 1; i < Map.Length; i++)
            {
                Map[i] = ".";

            }
            Map[25] = "T";
            int[] PerkValue = new int[26];
            for (int i = 0; i < PerkValue.Length; i++)
            {
                PerkValue[i] = 0;
            }
            int[] PerksControl = new int[26];
            for (int i = 0; i < PerksControl.Length; i++)
            {
                PerksControl[i] = 0;
            }
            PerksControl[25] = 9;
            Console.SetCursorPosition(75, 6); Console.Write("|");
            Console.SetCursorPosition(23, 7); Console.Write("+ - - - - - - - - - - - - - - - - - - - - - - - - - +");

            int[] Perks = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Random rdm = new Random();
            for (int i = 0; i < 8; i++)
            {
                int choice1 = rdm.Next(Perks.Length - i);
                int temp = Perks[7 - i];
                Perks[7 - i] = Perks[choice1];
                choice3 = Perks[choice1];
                Perks[choice1] = temp;
               
                while (0 == 0)
                {

                    x = rdm.Next(0, 25);
                    PerksControl[x] = 1;
                    if (Map[x] == ".")
                    {
                        if (choice3 == 1)
                        {
                            Map[x] = (Convert.ToChar(64)).ToString(); PerkValue[x] = 1; break;
                        }
                        else if (choice3 == 2)
                        {
                            Map[x] = (Convert.ToChar(35)).ToString(); PerkValue[x] = 2; break;
                        }
                        else if (choice3 == 3)
                        {
                            Map[x] = (Convert.ToChar(62)).ToString(); PerkValue[x] = 3; break;
                        }
                        else if (choice3 == 4)
                        {
                            Map[x] = (Convert.ToChar(60)).ToString(); PerkValue[x] = 4; break;
                        }
                        else if (choice3 == 5)
                        {
                            Map[x] = (Convert.ToChar(42)).ToString(); PerkValue[x] = 5; break;
                        }
                        else if (choice3 == 6)
                        {
                            Map[x] = (Convert.ToChar(76)).ToString(); PerkValue[x] = 6; break;
                        }
                        else if (choice3 == 7)
                        {
                            Map[x] = (Convert.ToChar(88)).ToString(); PerkValue[x] = 7; break;
                        }
                        else if (choice3 == 8)
                        {
                            Map[x] = (Convert.ToChar(78)).ToString(); PerkValue[x] = 8; break;
                        }
                    }
                }
                
               

            }
            //game starts here ------------------------------------------------------------- 25, 6
            int dice, direction = 1;
            int lifeP = 1, lifeC = 1;
            int SumPx = 23;
            int SumCx = 23;
            int controlPx = 0;
            int controlCx = 0;
            int round = 1;
            int counter20 = 0;
            int LastMove = 0;
            int tempValue = 0;
            bool Pflag = false, Cflag = false;
            bool FreezeP = false, FreezeC = false;
            bool tempFlag = false;
            Console.SetCursorPosition(90, 3); Console.Write("Turn: ");
            Console.SetCursorPosition(90, 4); Console.Write("Dice: ");
            Console.SetCursorPosition(90, 5); Console.Write("Life of P: ");
            Console.SetCursorPosition(90, 6); Console.Write("Life of C: ");
            Console.ResetColor();
            while (0 == 0)
            {
                
                Console.SetCursorPosition(25, 2); Console.Write("--------------------- Round {0} ---------------------", round);
                // p rounds
                while (0 == 0)
                {
                    if (FreezeP == true)
                    {
                        FreezeP = false; break;
                    }
                    for (int i = 1; i < Map.Length; i++)
                    {

                        Console.SetCursorPosition(23 + 2 * i, 6); Console.Write(Map[i]);

                    }
                    if (Pflag == false)
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(3, 6); Console.Write("P"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(3, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumPx, 6); Console.Write("P"); Console.ResetColor();
                    }
                    if (Cflag == false)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(7, 6); Console.Write("C"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(7, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumCx, 6); Console.Write("C"); Console.ResetColor();
                    }

                    dice = rdm.Next(1, 7); Console.SetCursorPosition(96, 4); Console.Write(dice);
                    Console.SetCursorPosition(96, 3); Console.Write("P");
                    Console.SetCursorPosition(101, 5); Console.Write(lifeP);
                    Console.SetCursorPosition(101, 6); Console.Write(lifeC);
                    controls:
                    if (counter20 == 20)
                    {
                        counter20 = 0; break;
                    }

                    if (direction == 1)
                    {
                        if (counter20 == 0)
                            Console.ReadLine();
                        if (Pflag == false)
                        {
                            if (counter20 == 0)
                            {
                                Pflag = true;
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumPx + 2 * dice, 6); Console.Write("P");
                                SumPx = SumPx + 2 * dice; controlPx = dice + controlPx;
                                Console.ResetColor();
                            }

                            //controls--------  
                            if (controlPx == controlCx)
                            {
                                Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("!!P is on the C. C will back to the lounge!! ");
                                Console.ReadLine();
                                Cflag = false; SumCx = 23;
                                controlCx = 0;
                            }
                            if (PerksControl[controlPx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlPx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Pflag = false; SumPx = 23;
                                    controlPx = 0;
                                }
                                else if (PerkValue[controlPx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeP = true;
                                }
                                else if (PerkValue[controlPx] == 3 || tempValue == 3)
                                {
                                    if (controlPx + 3 <= 25)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        SumPx = SumPx + 6; controlPx = controlPx + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, 6); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlPx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go lef 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx - 6; controlPx = controlPx - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, 6); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    if (counter20 == 0 && controlPx + dice <= 25)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Move again the same number of steps in the same direction");
                                        Console.ReadLine();
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx + 2 * dice, 6); Console.Write("P");
                                        SumPx = SumPx + 2 * dice; controlPx = dice + controlPx;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!P exceeds map limits!!"); }


                                }
                                else if (PerkValue[controlPx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("L gain 1 life");
                                    tempValue = 0;
                                    lifeP++;
                                }
                                else if (PerkValue[controlPx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("L lose 1 life");
                                    tempValue = 0;
                                    lifeP--;
                                }
                                else if (PerkValue[controlPx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlPx; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > controlPx - i)
                                            {
                                                road = controlPx - i; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    for (int i = controlPx + 1; i < 26; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > i - controlPx)
                                            {
                                                road = i - controlPx; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls;
                                }

                            }

                        }
                        else
                        {
                            if (counter20 == 0)
                            {
                                Console.SetCursorPosition(96, 3); Console.Write("P");
                                controlPx = dice + controlPx;
                                if (controlPx > 25)
                                {
                                    controlPx = controlPx - dice; break;
                                }
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumPx + 2 * dice, 6); Console.Write("P");
                                SumPx = SumPx + 2 * dice;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx)
                            {
                                Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("!!P is on the C. C will back to the lounge!! ");
                                Console.ReadLine();
                                Cflag = false; SumCx = 23;
                                controlCx = 0;
                            }
                            if (PerksControl[controlPx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlPx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Pflag = false; SumPx = 23;
                                    controlPx = 0;
                                }
                                else if (PerkValue[controlPx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeP = true;
                                }
                                else if (PerkValue[controlPx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlPx + 3 <= 25)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx + 6; controlPx = controlPx + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, 6); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!P exceeds map limit!!"); Console.ReadLine(); }
                                }
                                else if (PerkValue[controlPx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlPx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx - 6; controlPx = controlPx - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, 6); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!P exceeds map limit!!"); Console.ReadLine(); }
                                }
                                else if (PerkValue[controlPx] == 5 || tempValue == 5)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    if (counter20 == 0 && controlPx + dice <= 25)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx + 2 * dice, 6); Console.Write("P");
                                        SumPx = SumPx + 2 * dice; controlPx = dice + controlPx;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                    else if (counter20 != 0 && controlPx + LastMove <= 25 && controlPx + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx + 2 * LastMove, 6); Console.Write("P");
                                        SumPx = SumPx + 2 * LastMove; controlPx = LastMove + controlPx;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                }
                                else if (PerkValue[controlPx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("L gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP++;
                                }
                                else if (PerkValue[controlPx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("L lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP--;
                                }
                                else if (PerkValue[controlPx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlPx; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > controlPx - i)
                                            {
                                                road = controlPx - i; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    for (int i = controlPx + 1; i < 26; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > i - controlPx)
                                            {
                                                road = i - controlPx; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls;
                                }

                            }
                        }
                    }

                    tempFlag = false; tempValue = 0; LastMove = 0; counter20 = 0; break;
                }
                if (lifeC <= 0)
                {

                    Console.SetCursorPosition(101, 6); Console.Write(lifeC);
                    WinnerMessage = "C die. P wins the game";
                    break;
                }
                else if (PerksControl[controlPx] == 9)
                {
                    WinnerMessage = "P wins, P reaches treasure"; break;
                }
                if (lifeP <= 0)
                {
                    Console.SetCursorPosition(101, 5); Console.Write(lifeP);
                    WinnerMessage = "P die. C wins the game"; break;

                }
                else if (PerksControl[controlCx] == 9)
                {
                    WinnerMessage = "C wins, C reaches treasure"; break;
                }
                while (0 == 0)
                {
                    if (FreezeC == true)
                    {
                        FreezeC = false; break;
                    }
                    Console.SetCursorPosition(61, 6); Console.Write("C");
                    for (int i = 1; i < Map.Length; i++)
                    {
                        Console.SetCursorPosition(23 + 2 * i, 6); Console.Write(Map[i]);

                    }

                    if (Pflag == false)
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(3, 6); Console.Write("P"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(3, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumPx, 6); Console.Write("P"); Console.ResetColor();
                    }
                    if (Cflag == false)
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(7, 6); Console.Write("C"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(7, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumCx, 6); Console.Write("C"); Console.ResetColor();
                    }

                    dice = rdm.Next(1, 7); Console.SetCursorPosition(96, 4); Console.Write(dice);
                    Console.SetCursorPosition(96, 3); Console.Write("C");
                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");

                    //movement setup
                    controls2:
                    if (counter20 == 20)
                    {
                        counter20 = 0; break;
                    }

                    if (direction == 1)
                    {
                        if (counter20 == 0)
                            Console.ReadLine();
                        if (Cflag == false)
                        {
                            if (counter20 == 0)
                            {
                                Cflag = true;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumCx + 2 * dice, 6); Console.Write("C");
                                SumCx = SumCx + 2 * dice; controlCx = dice + controlCx;
                                Console.ResetColor();
                            }
                            //controls--------

                            if (controlPx == controlCx)
                            {
                                Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("!!C is on the P. P will back to the lounge!! ");
                                Console.ReadLine();
                                Pflag = false; SumPx = 23;
                                controlPx = 0;
                            }
                            if (PerksControl[controlCx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlCx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Cflag = false; SumCx = 23;
                                    controlCx = 0;
                                }
                                else if (PerkValue[controlCx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeC = true;
                                }
                                else if (PerkValue[controlCx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlCx + 3 <= 25)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx + 6; controlCx = controlCx + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, 6); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!C exceeds map limits!!"); Console.ReadLine(); }
                                }
                                else if (PerkValue[controlCx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlCx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx - 6; controlCx = controlCx - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, 6); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 12); Console.WriteLine("Go right 3 steps"); Console.ReadLine(); }
                                }
                                else if (PerkValue[controlCx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlCx + dice <= 25)
                                    {

                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * dice, 6); Console.Write("C");
                                        SumCx = SumCx + 2 * dice; controlCx = dice + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                    else if (counter20 != 0 && controlCx + LastMove <= 25 && controlCx + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * LastMove, 6); Console.Write("C");
                                        SumCx = SumCx + 2 * LastMove; controlCx = LastMove + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                }
                                else if (PerkValue[controlCx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("C gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC++;
                                }
                                else if (PerkValue[controlCx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("C lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC--;
                                }
                                else if (PerkValue[controlCx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlCx; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > controlCx - i)
                                            {
                                                road = controlCx - i; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    for (int i = controlCx + 1; i < 26; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > i - controlCx)
                                            {
                                                road = i - controlCx; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls2;
                                }
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                            Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                            Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                            Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                            Console.SetCursorPosition(96, 3); Console.Write("C");
                            if (counter20 == 0)
                            {

                                controlCx = dice + controlCx;
                                if (controlCx > 25)
                                {
                                    controlCx = controlCx - dice; break;
                                }
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumCx + 2 * dice, 6); Console.Write("C");
                                SumCx = SumCx + 2 * dice;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx)
                            {
                                Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 12); Console.WriteLine("!!C is on the P. P will back to the lounge!! ");
                                Console.ReadLine();
                                Pflag = false; SumPx = 23;
                                controlPx = 0;
                            }
                            if (PerksControl[controlCx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlCx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Cflag = false; SumCx = 23;
                                    controlCx = 0;
                                }
                                else if (PerkValue[controlCx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeC = true;
                                }
                                else if (PerkValue[controlCx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlCx + 3 <= 25)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx + 6; controlCx = controlCx + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, 6); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlCx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 12); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx - 6; controlCx = controlCx - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, 6); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 13); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlCx + dice <= 25)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * dice, 6); Console.Write("C");
                                        SumCx = SumCx + 2 * dice; controlCx = dice + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                    else if (counter20 != 0 && controlCx + LastMove <= 25 && controlCx + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * LastMove, 6); Console.Write("C");
                                        SumCx = SumCx + 2 * LastMove; controlCx = LastMove + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                }
                                else if (PerkValue[controlCx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("C gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC++;
                                }
                                else if (PerkValue[controlCx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("C lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC--;
                                }
                                else if (PerkValue[controlCx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 12); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlCx; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > controlCx - i)
                                            {
                                                road = controlCx - i; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    for (int i = controlCx + 1; i < 26; i++)
                                    {
                                        if (PerksControl[i] == 1)
                                        {
                                            if (road > i - controlCx)
                                            {
                                                road = i - controlCx; tempValue = PerkValue[i];
                                            }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls2;
                                }
                            }
                        }
                    }
                    tempFlag = false; tempValue = 0; LastMove = 0; counter20 = 0; break;
                }

                if (lifeC <= 0)
                {
                    Console.SetCursorPosition(101, 6); Console.Write(lifeC);
                    WinnerMessage = "C die. P wins the game";
                    break;
                }
                else if (PerksControl[controlPx] == 9)
                {
                    WinnerMessage = "P wins, P reaches treasure"; break;
                }
                if (lifeP <= 0)
                {
                    Console.SetCursorPosition(101, 5); Console.Write(lifeP);
                    WinnerMessage = "P die. C wins the game";
                    break;
                }
                else if (PerksControl[controlCx] == 9)
                {
                    WinnerMessage = "C wins, C reaches treasure"; break;
                }
                round++;
            }
            Console.SetCursorPosition(24, 14); Console.WriteLine("                                                                                           ");
            Console.SetCursorPosition(24, 13); Console.WriteLine("                                                                                           ");
            Console.SetCursorPosition(24, 12); Console.WriteLine("                                                                                           ");
            Console.SetCursorPosition(24, 11); Console.WriteLine("                                                                                           ");
            Console.SetCursorPosition(24, 13); Console.WriteLine(WinnerMessage);
            Console.SetCursorPosition(24, 14); Console.WriteLine("If you want to play one more game, type 'Y' ");
            string key1 = Console.ReadLine();
            key1 = key1.ToLower();
            if (key1 == "y")
            {
                Console.Clear(); goto board;
            }
        }
        static void game_2d()
        {
            Console.WriteLine("Do you want to see tutorial?(Y/N)");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == 'y' || info.KeyChar == 'Y')
            {
                tutorial2d_1();
            }
            else { }
            board:
            Console.Clear();
            string winner = null;
            string loser = null;
            int Selection1 = 100;
            int Selection2;
            int x, y;
            //board main design
            Console.SetCursorPosition(2, 4); Console.WriteLine("LOUNGE");
            Console.SetCursorPosition(1, 5); Console.Write("+ - - - +");
            Console.SetCursorPosition(1, 6); Console.Write("| . | . |");
            Console.SetCursorPosition(1, 7); Console.Write("+ - - - +");
            Console.SetCursorPosition(25, 4); Console.Write("1 2 3 4 5 6 7 8 9 0 1 2");
            Console.SetCursorPosition(23, 5); Console.Write("+ - - - - - - - - - - - - +");
            Console.SetCursorPosition(21, 15); Console.Write("0 |");
            Console.SetCursorPosition(21, 16); Console.Write("1 |");
            Console.SetCursorPosition(21, 17); Console.Write("2 |");
            Console.SetCursorPosition(23, 18); Console.Write("+ - - - - - - - - - - - - +");
            Console.SetCursorPosition(49, 15); Console.Write("|");
            Console.SetCursorPosition(49, 16); Console.Write("|");
            Console.SetCursorPosition(49, 17); Console.Write("|");
            Console.SetCursorPosition(55, 6); Console.Write("Turn: ");
            Console.SetCursorPosition(55, 7); Console.Write("Dice: ");
            Console.SetCursorPosition(55, 8); Console.Write("Direction: ");
            Console.SetCursorPosition(55, 9); Console.Write("Life of C: ");
            Console.SetCursorPosition(55, 10); Console.Write("Life of P: ");

            for (int i = 1; i <= 9; i++)
            {
                Console.SetCursorPosition(21, 5 + i); Console.Write("{0} |", i);
                Console.SetCursorPosition(49, 5 + i); Console.Write("|");
            }

            // map assignment with array
            string[,] Map = new string[13, 13];
            for (int i = 1; i < Map.GetLength(0); i++)
            {
                for (int j = 1; j < Map.GetLength(1); j++)
                {
                    Map[i, j] = ".";
                }
            }
            Map[12, 12] = "T";
            int[,] PerkValue = new int[13, 13];
            for (int i = 1; i < Map.GetLength(0); i++)
            {
                for (int j = 1; j < Map.GetLength(1); j++)
                {
                    PerkValue[i, j] = 0;
                }
            }
            int[,] PerksControl = new int[13, 13];
            for (int i = 1; i < PerksControl.GetLength(0); i++)
            {
                for (int j = 1; j < PerksControl.GetLength(1); j++)
                {
                    PerksControl[i, j] = 0;
                }
            }
            PerksControl[12, 12] = 2;

            //penalties and rewards(perks) assignments
            int[] Perks = new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10 };
            Random rdm = new Random();
            for (int i = 1; i <= 40; i++)
            {
                Selection1 = rdm.Next(41 - i);
                int temp = Perks[40 - i];
                Selection2 = Perks[Selection1];
                Perks[40 - i] = Perks[Selection1];
                Perks[Selection1] = temp;

                CoordinateSelection:
                int Xcounter = 0;
                int Ycounter = 0;
                y = rdm.Next(1, Map.GetLength(0));
                x = rdm.Next(1, Map.GetLength(1));
                for (int j = 1; j <= 12; j++)
                {
                    if (PerksControl[x, j] == 1)
                        Ycounter++;
                }
                for (int j = 1; j <= 12; j++)
                {
                    if (PerksControl[j, y] == 1)
                        Xcounter++;
                }
                if (Xcounter == 4 || Ycounter == 4 || PerksControl[x, y] == 1 || PerksControl[x, y] == 2)
                    goto CoordinateSelection;

                PerksControl[x, y] = 1;
                if (Selection2 == 1)
                { Map[x, y] = (Convert.ToChar(64)).ToString(); PerkValue[x, y] = 1; }
                else if (Selection2 == 2)
                { Map[x, y] = (Convert.ToChar(35)).ToString(); PerkValue[x, y] = 2; }
                else if (Selection2 == 3)
                { Map[x, y] = (Convert.ToChar(62)).ToString(); PerkValue[x, y] = 3; }
                else if (Selection2 == 4)
                { Map[x, y] = (Convert.ToChar(60)).ToString(); PerkValue[x, y] = 4; }
                else if (Selection2 == 5)
                { Map[x, y] = (Convert.ToChar(42)).ToString(); PerkValue[x, y] = 5; }
                else if (Selection2 == 6)
                { Map[x, y] = (Convert.ToChar(76)).ToString(); PerkValue[x, y] = 6; }
                else if (Selection2 == 7)
                { Map[x, y] = (Convert.ToChar(88)).ToString(); PerkValue[x, y] = 7; }
                else if (Selection2 == 8)
                { Map[x, y] = (Convert.ToChar(78)).ToString(); PerkValue[x, y] = 8; }
                else if (Selection2 == 9)
                { Map[x, y] = (Convert.ToChar(118)).ToString(); PerkValue[x, y] = 9; }
                else if (Selection2 == 10)
                { Map[x, y] = (Convert.ToChar(94)).ToString(); PerkValue[x, y] = 10; }

            }
            //game starts here ------------------------------------------------------------- 25, 6
            int dice, direction;
            int lifeP = 1, lifeC = 1;
            int SumPx = 23; int sumPy = 5;
            int SumCx = 23; int sumCy = 5;
            int controlPx = 0, controlPy = 0;
            int controlCx = 0, controlCy = 0;
            int round = 1;
            int counter20 = 0;
            int LastMove = 0;
            int tempValue = 0;
            bool Pflag = false, Cflag = false;
            bool FreezeP = false, FreezeC = false;
            bool tempFlag = false;
            while (0 == 0)
            {
                
                Console.SetCursorPosition(25, 2); Console.Write("--------------------- Round {0} ---------------------", round);
                // p rounds
                while (0 == 0)
                {
                    if (FreezeP == true)
                    { FreezeP = false; break; }
                    Console.SetCursorPosition(61, 6); Console.Write("P");
                    for (int i = 1; i < Map.GetLength(0); i++)
                    {
                        for (int j = 1; j < Map.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(23 + 2 * j, 5 + i); Console.Write(Map[i, j]);
                        }
                    }
                    // Flag checkpoint
                    if (Pflag == false)
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(3, 6); Console.Write("P"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(3, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P"); Console.ResetColor();
                    }
                    if (Cflag == false)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(7, 6); Console.Write("C"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(7, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C"); Console.ResetColor();
                    }

                    dice = rdm.Next(1, 7);
                    direction = rdm.Next(1, 3);  // 1 = >  2 = v
                    Console.SetCursorPosition(61, 7); Console.Write(dice);
                    Console.SetCursorPosition(66, 9); Console.Write(lifeC);
                    Console.SetCursorPosition(66, 10); Console.Write(lifeP);
                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                    //movement setup
                    controls:
                    if (counter20 == 20)
                    { counter20 = 0; break; }

                    if (direction == 1)
                    {
                        Console.SetCursorPosition(66, 8); Console.Write(">");
                        if (counter20 == 0)
                            Console.ReadLine();
                        if (Pflag == false)
                        {
                            if (counter20 == 0)
                            {
                                Pflag = true;
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumPx + 2 * dice, sumPy + 1); Console.Write("P");
                                SumPx = SumPx + 2 * dice; controlPx = dice + controlPx;
                                sumPy = sumPy + 1; controlPy = 1 + controlPy;
                                Console.ResetColor();
                            }
                            //controls--------                                                 

                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!P is on the C. C will back to the lounge!! ");
                                Console.ReadLine();
                                Cflag = false; SumCx = 23; sumCy = 5;
                                controlCx = 0; controlCy = 0;
                            }
                            if (PerksControl[controlPy, controlPx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlPy, controlPx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Pflag = false; SumPx = 23; sumPy = 5;
                                    controlPx = 0; controlPy = 0;
                                }
                                else if (PerkValue[controlPy, controlPx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeP = true;
                                }
                                else if (PerkValue[controlPy, controlPx] == 3 || tempValue == 3)
                                {
                                    if (controlPx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        SumPx = SumPx + 6; controlPx = controlPx + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlPx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx - 6; controlPx = controlPx - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlPx + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx + 2 * dice, sumPy); Console.Write("P");
                                        SumPx = SumPx + 2 * dice; controlPx = dice + controlPx;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }

                                }
                                else if (PerkValue[controlPy, controlPx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP++;
                                }
                                else if (PerkValue[controlPy, controlPx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP--;
                                }
                                else if (PerkValue[controlPy, controlPx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlPy; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > controlPy - i)
                                            { road = controlPy - i; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = controlPy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > i - controlPy)
                                            { road = i - controlPy; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlPx; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > controlPx - i)
                                            { road = controlPx - i; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    for (int i = controlPx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > i - controlPx)
                                            { road = i - controlPx; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls;
                                }
                                else if (PerkValue[controlPy, controlPx] == 9 || tempValue == 9)
                                {
                                    if (controlPy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumPy = sumPy + 3; controlPy = controlPy + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("P exceeds map limits"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlPy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumPy = sumPy - 3; controlPy = controlPy - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("P exceeds map limits"); }
                                }
                            }

                        }
                        else
                        {
                            if (counter20 == 0)
                            {
                                controlPx = dice + controlPx;
                                if (controlPx > 12)
                                { controlPx = controlPx - dice; break; }
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumPx + 2 * dice, sumPy); Console.Write("P");
                                SumPx = SumPx + 2 * dice;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!P is on the C. C will back to the lounge!! ");
                                Console.ReadLine();
                                Cflag = false; SumCx = 23; sumCy = 5;
                                controlCx = 0; controlCy = 0;
                            }
                            if (PerksControl[controlPy, controlPx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlPy, controlPx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Pflag = false; SumPx = 23; sumPy = 5;
                                    controlPx = 0; controlPy = 0;
                                }
                                else if (PerkValue[controlPy, controlPx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeP = true;
                                }
                                else if (PerkValue[controlPy, controlPx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlPx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx + 6; controlPx = controlPx + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlPx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx - 6; controlPx = controlPx - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlPx + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx + 2 * dice, sumPy); Console.Write("P");
                                        SumPx = SumPx + 2 * dice; controlPx = dice + controlPx;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                    else if (counter20 != 0 && controlPx + LastMove <= 12 && controlPx + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx + 2 * LastMove, sumPy); Console.Write("P");
                                        SumPx = SumPx + 2 * LastMove; controlPx = LastMove + controlPx;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                }
                                else if (PerkValue[controlPy, controlPx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP++;
                                }
                                else if (PerkValue[controlPy, controlPx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP--;
                                }
                                else if (PerkValue[controlPy, controlPx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlPy; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > controlPy - i)
                                            { road = controlPy - i; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = controlPy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > i - controlPy)
                                            { road = i - controlPy; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlPx; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > controlPx - i)
                                            { road = controlPx - i; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    for (int i = controlPx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > i - controlPx)
                                            { road = i - controlPx; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls;
                                }
                                else if (PerkValue[controlPy, controlPx] == 9 || tempValue == 9)
                                {
                                    if (controlPy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumPy = sumPy + 3; controlPy = controlPy + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("P exceeds map limits"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlPy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumPy = sumPy - 3; controlPy = controlPy - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("P exceeds map limits"); }
                                }
                            }
                        }
                    }
                    if (direction == 2)
                    {
                        Console.SetCursorPosition(66, 8); Console.Write("v"); Console.ReadLine();
                        if (Pflag == false)
                        {
                            if (counter20 == 0)
                            {
                                Pflag = true;
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumPx + 2, sumPy + dice); Console.Write("P");
                                controlPx = 1 + controlPx; SumPx = SumPx + 2;
                                sumPy = sumPy + dice; controlPy = dice + controlPy;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!P is on the C. C will back to the lounge!! ");
                                Console.ReadLine();
                                Cflag = false; SumCx = 23; sumCy = 5;
                                controlCx = 0; controlCy = 0;
                            }
                            if (PerksControl[controlPy, controlPx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlPy, controlPx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Pflag = false; SumPx = 23; sumPy = 5;
                                    controlPx = 0; controlPy = 0;
                                }
                                else if (PerkValue[controlPy, controlPx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeP = true;
                                }
                                else if (PerkValue[controlPy, controlPx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlPx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx + 6; controlPx = controlPx + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlPx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx - 6; controlPx = controlPx - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlPy + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy + dice); Console.Write("P");
                                        sumPy = sumPy + dice; controlPy = dice + controlPy;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                    else if (counter20 != 0 && controlPy + LastMove <= 12 && controlPy + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy + LastMove); Console.Write("P");
                                        sumPy = sumPy + LastMove; controlPy = LastMove + controlPy;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                }
                                else if (PerkValue[controlPy, controlPx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP++;
                                }
                                else if (PerkValue[controlPy, controlPx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP--;
                                }
                                else if (PerkValue[controlPy, controlPx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlPy; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > controlPy - i)
                                            { road = controlPy - i; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = controlPy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > i - controlPy)
                                            { road = i - controlPy; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlPx; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > controlPx - i)
                                            { road = controlPx - i; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    for (int i = controlPx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > i - controlPx)
                                            { road = i - controlPx; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls;
                                }
                                else if (PerkValue[controlPy, controlPx] == 9 || tempValue == 9)
                                {
                                    if (controlPy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumPy = sumPy + 3; controlPy = controlPy + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 35); Console.WriteLine("P exceeds map limits"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlPy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumPy = sumPy - 3; controlPy = controlPy - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 35); Console.WriteLine("P exceeds map limits"); }
                                }
                            }
                        }
                        else
                        {
                            if (counter20 == 0)
                            {
                                controlPy = dice + controlPy;
                                if (controlPy > 12)
                                { controlPy = controlPy - dice; break; }
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumPx, sumPy + dice); Console.Write("P");
                                sumPy = sumPy + dice;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!P is on the C. C will back to the lounge!! ");
                                Console.ReadLine();
                                Cflag = false; SumCx = 23; sumCy = 5;
                                controlCx = 0; controlCy = 0;
                            }
                            if (PerksControl[controlPy, controlPx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlPy, controlPx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Pflag = false; SumPx = 23; sumPy = 5;
                                    controlPx = 0; controlPy = 0;
                                }
                                else if (PerkValue[controlPy, controlPx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeP = true;
                                }
                                else if (PerkValue[controlPy, controlPx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlPx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx + 6; controlPx = controlPx + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlPx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumPx = SumPx - 6; controlPx = controlPx - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!P exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlPy + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy + dice); Console.Write("P");
                                        sumPy = sumPy + dice; controlPy = dice + controlPy;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                    else if (counter20 != 0 && controlPy + LastMove <= 12 && controlPy + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy + LastMove); Console.Write("P");
                                        sumPy = sumPy + LastMove; controlPy = LastMove + controlPy;
                                        Console.ResetColor(); counter20++; goto controls;
                                    }
                                }
                                else if (PerkValue[controlPy, controlPx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP++;
                                }
                                else if (PerkValue[controlPy, controlPx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("P lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeP--;
                                }
                                else if (PerkValue[controlPy, controlPx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlPy; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > controlPy - i)
                                            { road = controlPy - i; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = controlPy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlPx] == 1)
                                        {
                                            if (road > i - controlPy)
                                            { road = i - controlPy; tempValue = PerkValue[i, controlPx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlPx; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > controlPx - i)
                                            { road = controlPx - i; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    for (int i = controlPx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlPy, i] == 1)
                                        {
                                            if (road > i - controlPx)
                                            { road = i - controlPx; tempValue = PerkValue[controlPy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls;
                                }
                                else if (PerkValue[controlPy, controlPx] == 9 || tempValue == 9)
                                {
                                    if (controlPy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumPy = sumPy + 3; controlPy = controlPy + 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("P exceeds map limits"); }
                                }
                                else if (PerkValue[controlPy, controlPx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlPy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumPy = sumPy - 3; controlPy = controlPy - 3;
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("P exceeds map limits"); }
                                }
                            }
                        }
                    }

                    tempFlag = false; tempValue = 0; LastMove = 0; counter20 = 0; break;
                }
                //win checkpoint 1

                if (lifeC <= 0 || PerksControl[controlPy, controlPx] == 2)
                {
                    winner = "P"; loser = "C";
                    break;
                }
                if (lifeP <= 0 || PerksControl[controlCy, controlCx] == 2)
                {
                    winner = "C"; loser = "P";
                    break;
                }

                // c rounds
                while (0 == 0)
                {
                    if (FreezeC == true)
                    { FreezeC = false; break; }
                    Console.SetCursorPosition(61, 6); Console.Write("C");
                    for (int i = 1; i < Map.GetLength(0); i++)
                    {
                        for (int j = 1; j < Map.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(23 + 2 * j, 5 + i); Console.Write(Map[i, j]);
                        }
                    }
                    // Flag checkpoint
                    if (Pflag == false)
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(3, 6); Console.Write("P"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(3, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumPx, sumPy); Console.Write("P"); Console.ResetColor();
                    }
                    if (Cflag == false)
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(7, 6); Console.Write("C"); Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(7, 6); Console.Write(".");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C"); Console.ResetColor();
                    }

                    dice = rdm.Next(1, 7);
                    direction = rdm.Next(1, 3);  // 1 = >  2 = v
                    Console.SetCursorPosition(61, 7); Console.Write(dice);
                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                    //movement setup
                    controls2:
                    if (counter20 == 20)
                    { counter20 = 0; break; }
                    if (direction == 1)
                    {
                        Console.SetCursorPosition(66, 8); Console.Write(">");
                        if (counter20 == 0)
                            Console.ReadLine();
                        if (Cflag == false)
                        {
                            if (counter20 == 0)
                            {
                                Cflag = true;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumCx + 2 * dice, sumCy + 1); Console.Write("C");
                                SumCx = SumCx + 2 * dice; controlCx = dice + controlCx;
                                sumCy = sumCy + 1; controlCy = 1 + controlCy;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!C is on the P. P will back to the lounge!! ");
                                Console.ReadLine();
                                Pflag = false; SumPx = 23; sumPy = 5;
                                controlPx = 0; controlPy = 0;
                            }
                            if (PerksControl[controlCy, controlCx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlCy, controlCx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Cflag = false; SumCx = 23; sumCy = 5;
                                    controlCx = 0; controlCy = 0;
                                }
                                else if (PerkValue[controlCy, controlCx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeC = true;
                                }
                                else if (PerkValue[controlCy, controlCx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlCx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx + 6; controlCx = controlCx + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlCx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx - 6; controlCx = controlCx - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlCx + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * dice, sumCy); Console.Write("C");
                                        SumCx = SumCx + 2 * dice; controlCx = dice + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                    else if (counter20 != 0 && controlCx + LastMove <= 12 && controlCx + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * LastMove, sumCy); Console.Write("C");
                                        SumCx = SumCx + 2 * LastMove; controlCx = LastMove + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                }
                                else if (PerkValue[controlCy, controlCx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC++;
                                }
                                else if (PerkValue[controlCy, controlCx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC--;
                                }
                                else if (PerkValue[controlCy, controlCx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlCy; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > controlCy - i)
                                            { road = controlCy - i; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = controlCy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > i - controlCy)
                                            { road = i - controlCy; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlCx; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > controlCx - i)
                                            { road = controlCx - i; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    for (int i = controlCx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > i - controlCx)
                                            { road = i - controlCx; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls2;
                                }
                                else if (PerkValue[controlCy, controlCx] == 9 || tempValue == 9)
                                {
                                    if (controlCy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumCy = sumCy + 3; controlCy = controlCy + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlCy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumCy = sumCy - 3; controlCy = controlCy - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                            }
                        }
                        else
                        {
                            if (counter20 == 0)
                            {
                                controlCx = dice + controlCx;
                                if (controlCx > 12)
                                { controlCx = controlCx - dice; break; }
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumCx + 2 * dice, sumCy); Console.Write("C");
                                SumCx = SumCx + 2 * dice;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!C is on the P. P will back to the lounge!! ");
                                Console.ReadLine();
                                Pflag = false; SumPx = 23; sumPy = 5;
                                controlPx = 0; controlPy = 0;
                            }
                            if (PerksControl[controlCy, controlCx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlCy, controlCx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Cflag = false; SumCx = 23; sumCy = 5;
                                    controlCx = 0; controlCy = 0;
                                }
                                else if (PerkValue[controlCy, controlCx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeC = true;
                                }
                                else if (PerkValue[controlCy, controlCx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlCx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx + 6; controlCx = controlCx + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlCx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx - 6; controlCx = controlCx - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlCx + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * dice, sumCy); Console.Write("C");
                                        SumCx = SumCx + 2 * dice; controlCx = dice + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                    else if (counter20 != 0 && controlCx + LastMove <= 12 && controlCx + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx + 2 * LastMove, sumCy); Console.Write("C");
                                        SumCx = SumCx + 2 * LastMove; controlCx = LastMove + controlCx;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                }
                                else if (PerkValue[controlCy, controlCx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC++;
                                }
                                else if (PerkValue[controlCy, controlCx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC--;
                                }
                                else if (PerkValue[controlCy, controlCx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlCy; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > controlCy - i)
                                            { road = controlCy - i; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = controlCy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > i - controlCy)
                                            { road = i - controlCy; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlCx; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > controlCx - i)
                                            { road = controlCx - i; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    for (int i = controlCx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > i - controlCx)
                                            { road = i - controlCx; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls2;
                                }
                                else if (PerkValue[controlCy, controlCx] == 9 || tempValue == 9)
                                {
                                    if (controlCy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumCy = sumCy + 3; controlCy = controlCy + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlCy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumCy = sumCy - 3; controlCy = controlCy - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                            }
                        }
                    }
                    if (direction == 2)
                    {
                        Console.SetCursorPosition(66, 8); Console.Write("v"); Console.ReadLine();
                        if (Cflag == false)
                        {
                            if (counter20 == 0)
                            {
                                Cflag = true;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumCx + 2, sumCy + dice); Console.Write("C");
                                controlCx = 1 + controlCx; SumCx = SumCx + 2;
                                sumCy = sumCy + dice; controlCy = dice + controlCy;
                                Console.ResetColor();
                                //controls--------
                            }
                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!C is on the P. P will back to the lounge!! ");
                                Console.ReadLine();
                                Pflag = false; SumPx = 23; sumPy = 5;
                                controlPx = 0; controlPy = 0;
                            }
                            if (PerksControl[controlCy, controlCx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlCy, controlCx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Cflag = false; SumCx = 23; sumCy = 5;
                                    controlCx = 0; controlCy = 0;
                                }
                                else if (PerkValue[controlCy, controlCx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeC = true;
                                }
                                else if (PerkValue[controlCy, controlCx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlCx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx + 6; controlCx = controlCx + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlCx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx - 6; controlCx = controlCx - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlCy + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy + dice); Console.Write("C");
                                        sumCy = sumCy + dice; controlCy = dice + controlCy;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                    else if (counter20 != 0 && controlCy + LastMove <= 12 && controlCy + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy + LastMove); Console.Write("C");
                                        sumCy = sumCy + LastMove; controlCy = LastMove + controlCy;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                }
                                else if (PerkValue[controlCy, controlCx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC++;
                                }
                                else if (PerkValue[controlCy, controlCx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC--;
                                }
                                else if (PerkValue[controlCy, controlCx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlCy; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > controlCy - i)
                                            { road = controlCy - i; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = controlCy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > i - controlCy)
                                            { road = i - controlCy; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlCx; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > controlCx - i)
                                            { road = controlCx - i; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    for (int i = controlCx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > i - controlCx)
                                            { road = i - controlCx; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls2;
                                }
                                else if (PerkValue[controlCy, controlCx] == 9 || tempValue == 9)
                                {
                                    if (controlCy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumCy = sumCy + 3; controlCy = controlCy + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlCy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumCy = sumCy - 3; controlCy = controlCy - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                            }
                        }
                        else
                        {
                            if (counter20 == 0)
                            {
                                controlCy = dice + controlCy;
                                if (controlCy > 12)
                                { controlCy = controlCy - dice; break; }
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(SumCx, sumCy + dice); Console.Write("C");
                                sumCy = sumCy + dice;
                                Console.ResetColor();
                            }
                            //controls--------
                            if (controlPx == controlCx && controlPy == controlCy)
                            {
                                Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                Console.SetCursorPosition(24, 20); Console.WriteLine("!!C is on the P. P will back to the lounge!! ");
                                Console.ReadLine();
                                Pflag = false; SumPx = 23; sumPy = 5;
                                controlPx = 0; controlPy = 0;
                            }
                            if (PerksControl[controlCy, controlCx] == 1 || tempValue != 0)
                            {
                                if (PerkValue[controlCy, controlCx] == 1 || tempValue == 1)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Go back to the starting point");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    Cflag = false; SumCx = 23; sumCy = 5;
                                    controlCx = 0; controlCy = 0;
                                }
                                else if (PerkValue[controlCy, controlCx] == 2 || tempValue == 2)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Wait 1 round");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    FreezeC = true;
                                }
                                else if (PerkValue[controlCy, controlCx] == 3 || tempValue == 3)
                                {
                                    tempValue = 0;
                                    if (controlCx + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go right 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx + 6; controlCx = controlCx + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 4 || tempValue == 4)
                                {
                                    tempValue = 0;
                                    if (controlCx - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go left 3 steps");
                                        Console.ReadLine();
                                        SumCx = SumCx - 6; controlCx = controlCx - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 1; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("!!C exceeds map limits!!"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 5 || tempValue == 5)
                                {
                                    tempValue = 0;
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Move again the same number of steps in the same direction");
                                    Console.ReadLine();
                                    if (counter20 == 0 && controlCy + dice <= 12)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy + dice); Console.Write("C");
                                        sumCy = sumCy + dice; controlCy = dice + controlCy;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                    else if (counter20 != 0 && controlCy + LastMove <= 12 && controlCy + LastMove >= 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy + LastMove); Console.Write("C");
                                        sumCy = sumCy + LastMove; controlCy = LastMove + controlCy;
                                        Console.ResetColor(); counter20++; goto controls2;
                                    }
                                }
                                else if (PerkValue[controlCy, controlCx] == 6 || tempValue == 6)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C gain 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC++;
                                }
                                else if (PerkValue[controlCy, controlCx] == 7 || tempValue == 7)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("C lose 1 life");
                                    Console.ReadLine();
                                    tempValue = 0;
                                    lifeC--;
                                }
                                else if (PerkValue[controlCy, controlCx] == 8 && tempFlag == false)
                                {
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                    Console.SetCursorPosition(24, 20); Console.WriteLine("Find the nearest reward/penalty and apply it");
                                    Console.ReadLine();
                                    int road = 100;
                                    for (int i = 1; i < controlCy; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > controlCy - i)
                                            { road = controlCy - i; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = controlCy + 1; i < 13; i++)
                                    {
                                        if (PerksControl[i, controlCx] == 1)
                                        {
                                            if (road > i - controlCy)
                                            { road = i - controlCy; tempValue = PerkValue[i, controlCx]; }
                                        }
                                    }
                                    for (int i = 1; i < controlCx; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > controlCx - i)
                                            { road = controlCx - i; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    for (int i = controlCx + 1; i < 13; i++)
                                    {
                                        if (PerksControl[controlCy, i] == 1)
                                        {
                                            if (road > i - controlCx)
                                            { road = i - controlCx; tempValue = PerkValue[controlCy, i]; }
                                        }
                                    }
                                    tempFlag = true; road = 0; goto controls2;
                                }
                                else if (PerkValue[controlCy, controlCx] == 9 || tempValue == 9)
                                {
                                    if (controlCy + 3 <= 12)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go down 3 steps");
                                        Console.ReadLine();
                                        tempValue = 0;
                                        sumCy = sumCy + 3; controlCy = controlCy + 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = 3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                                else if (PerkValue[controlCy, controlCx] == 10 || tempValue == 10)
                                {
                                    tempValue = 0;
                                    if (controlCy - 3 >= 1)
                                    {
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(24, 20); Console.WriteLine("Go up 3 steps");
                                        Console.ReadLine();
                                        sumCy = sumCy - 3; controlCy = controlCy - 3;
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(SumCx, sumCy); Console.Write("C");
                                        Console.ResetColor(); direction = 2; counter20++; LastMove = -3; goto controls2;

                                    }
                                    else { Console.SetCursorPosition(24, 21); Console.WriteLine("C exceeds map limits"); }
                                }
                            }
                        }
                    }

                    tempFlag = false; tempValue = 0; LastMove = 0; counter20 = 0; break;
                }

                if (lifeC <= 0 || PerksControl[controlPy, controlPx] == 2)
                {
                    winner = "P"; loser = "C";
                    break;
                }
                if (lifeP <= 0 || PerksControl[controlCy, controlCx] == 2)
                {
                    winner = "C"; loser = "P";
                    break;
                }
                round++;
            }
            Console.SetCursorPosition(24, 20); Console.WriteLine("                                                                                           ");
            Console.SetCursorPosition(24, 21); Console.WriteLine("                                                                                           ");
            Console.SetCursorPosition(24, 20);
            Console.SetCursorPosition(58, 12); Console.Write(loser + " Lost");
            Console.SetCursorPosition(58, 13); Console.Write(winner + " Wins the game");
            Console.SetCursorPosition(58, 14); Console.WriteLine("If you want to play one more game, type 'Y' ");
            string key1 = Console.ReadLine();
            key1 = key1.ToLower();
            if (key1 == "y")
            {
                Console.Clear(); goto board;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(125, 40);
                menu();
        }

    }
}
 

