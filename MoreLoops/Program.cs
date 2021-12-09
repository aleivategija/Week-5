using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;
            

            for(int i = 0; i < 3; i++)
            {
                if (cpuRandom < userRandom)
                {
                    userScore = userScore + 1;
                    Console.WriteLine($"Skoor on {userScore}:{cpuScore} kasutajale");
                }
                
                else if(cpuRandom> userRandom)
                {
                    cpuScore = cpuScore + 1;
                    Console.WriteLine($"Skoor on {cpuScore}:{userScore} arvutile");
                }
                break;
            }

            if (cpuRandom < userRandom)
            {
                Console.WriteLine($"Kasutaja on m2ngu v6itnud {userScore} punktiga.");

            }

            else if (cpuRandom > userRandom)
            {
                Console.WriteLine($"Arvuti on m2ngu v6itnud {cpuScore} punktiga.");
            }
            
            else
            {
                Console.WriteLine("Viik!");
            }
            




        }
    }
}
