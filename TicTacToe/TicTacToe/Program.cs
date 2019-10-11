using System;

namespace ticTacToe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char player1Play = 'X';
        static char player2Play = 'O';
        static int youWin = 0;

        static void Main(string[] args)
        {

            {
                Console.WriteLine(player1Play);
                Console.WriteLine(player2Play);
                if (player1Play == 0)
                {
                    Console.Write(player1Play);
                }
                else
                {
                    Console.Write(player2Play);
                }



                youWin = WhoWon();

                while (youWin != 1 && youWin != -1) ;


                if (youWin == 0)

                {

                    Console.WriteLine("Player1 Won");

                }

                if (youWin == 1)
                {
                    Console.WriteLine("Player2 Won");
                }

                else
                {
                    Console.WriteLine("Draw");

                }


               int WhoWon()

                {
                    if (arr[1] == arr[2] && arr[2] == arr[3])

                    {

                        return 1;

                    }

                    else if (arr[4] == arr[5] && arr[5] == arr[6])

                    {

                        return 1;

                    }

                    else if (arr[6] == arr[7] && arr[7] == arr[8])

                    {

                        return 1;

                    }


                    else if (arr[1] == arr[4] && arr[4] == arr[7])

                    {

                        return 1;

                    }


                    else if (arr[2] == arr[5] && arr[5] == arr[8])

                    {

                        return 1;

                    }

                    else if (arr[3] == arr[6] && arr[6] == arr[9])

                    {

                        return 1;

                    }

                    else if (arr[1] == arr[5] && arr[5] == arr[9])

                    {

                        return 1;

                    }

                    else if (arr[3] == arr[5] && arr[5] == arr[7])

                    {

                        return 1;
                    }


                    else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                    {

                        return -1;

                    }

                    else

                    {

                        return 0;
                    }
                }
            }
    }
    }
}