using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_4300_9_10_Class
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.Write("Please enter a value between 1 and 100: ");
            try
            {
                string input = Console.ReadLine();
                int user_input = int.Parse(input);

                if ((user_input > 0) && (user_input < 101))
                {
                    Console.WriteLine("You have entered " + user_input.ToString());
                    int x = 0;

                    while (x < user_input)
                    {
                        Console.WriteLine("This is the current integer value in the loop: " + x);
                        x++;
                    }

                }

                else if ((user_input < 1) || (user_input > 99))
                {
                    Console.Write("Error: Value Not Valid. Enter Valid Number: ");

                    bool correct = false;

                    while (!correct)
                    {
                        input = Console.ReadLine();
                        user_input = int.Parse(input);

                        if ((user_input > 0) && (user_input < 101))
                        {
                            Console.WriteLine("You have entered " + user_input.ToString());
                            correct = true;

                            int x = 0;

                            while (x < user_input)
                            {
                                Console.WriteLine("This is the current integer value in the loop: " + x);
                                x++;
                            }

                        }
                        else
                        {
                            Console.Write("Error: Value Not Valid. Enter Valid Number: ");
                        }

                    }

                }

                string closePrgm = "1";
                while (closePrgm != "0")
                {
                    Console.WriteLine("Press 0 to exit: ");
                    closePrgm = Console.ReadLine();
                }
                return;
                
            }
            catch
            {
                string input = Console.ReadLine();
                int user_input = int.Parse(input);

                if ((user_input > 0) && (user_input < 101))
                    Console.WriteLine("error");
            }
                }
            }
        } 
    

