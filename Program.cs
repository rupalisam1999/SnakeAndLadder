using System;

namespace SnakeAndLadder
{
    class Program

    {
        //Initializing Constants
        const int LADDER = 1;
        const int NOPLAY = 2;
        const int SNAKE = 3;

        public int GetDiesNo()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public int GetOption()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public int FirstPlay()
        {
            Random random = new Random();
            return random.Next(1, 3);
        }
        public int Play(int options, int position, int noOnDie)
        {

            switch (options)
            {
                case LADDER:
                    position += noOnDie;
                    position = position > 100 ? position -= noOnDie : position;

                    break;
                case SNAKE:
                    position -= noOnDie;
                    //turnery operator
                    position = position < 0 ? 0 : position;
                    break;
                case NOPLAY:

                    break;
            }

            return position;
        }


        static void Main(string[] args)
        {

            Program p = new Program();

            string turn = "";
            const string PLAYERONESYMBOL = "Rupali";
            const string PLAYERTWOSYMBOL = "Computer";
            int playerOnePosition = 0;
            int playerTwoPosition = 0;


            int checkWhoWillPlayFirst = p.FirstPlay();

            if (checkWhoWillPlayFirst == 1)
            {
                turn = PLAYERONESYMBOL;
            }
            else
            {
                turn = PLAYERTWOSYMBOL;
            }

            int dieCount = 0;
            while (playerOnePosition != 100 || playerTwoPosition != 100)
            {
                if (turn == PLAYERONESYMBOL)
                {
                    int diesNO = p.GetDiesNo();
                    int option = p.GetOption();
                    playerOnePosition = p.Play(option, playerOnePosition, diesNO);
                    if (option == 1)
                    {
                        diesNO = p.GetDiesNo();
                        option = p.GetOption();
                        playerOnePosition = p.Play(option, playerOnePosition, diesNO);
                    }
                    if (playerOnePosition == 100)
                    {
                        Console.WriteLine($"Player {PLAYERONESYMBOL} is winner ");
                        break;
                    }
                    turn = PLAYERTWOSYMBOL;

                }
                else
                {
                    int diesNO = p.GetDiesNo();
                    int option = p.GetOption();
                    playerTwoPosition = p.Play(option, playerTwoPosition, diesNO);
                    if (option == LADDER)
                    {
                        diesNO = p.GetDiesNo();
                        option = p.GetOption();
                        playerTwoPosition = p.Play(option, playerTwoPosition, diesNO);
                    }
                    if (playerTwoPosition == 100)
                    {
                        Console.WriteLine($"Player {PLAYERTWOSYMBOL} is winner ");
                        break;
                    }
                    turn = PLAYERONESYMBOL;
                }

                dieCount++;
                Console.WriteLine($"Die Roll No : {dieCount} Player {PLAYERONESYMBOL} Position {playerOnePosition} And Player {PLAYERTWOSYMBOL} Position {playerTwoPosition}");
            }
            Console.WriteLine($"Player {PLAYERONESYMBOL} Position is {playerOnePosition} and Player {PLAYERTWOSYMBOL} Position is {playerTwoPosition}");
        }
    }

}

