using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Constant
            const  int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;

            int position = 0;

            Random random = new Random();
            int dieCount = 0;
           
            while (position != 100)
            {
                int noOnDie = random.Next(1, 7);
                dieCount++;
                Console.WriteLine($"No On Die {noOnDie}");

                int options = random.Next(1, 4);
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

                Console.WriteLine($"die count:{dieCount} position: {position}");

            
            }
            Console.WriteLine("POSITION " + position);
        }

    }
}
