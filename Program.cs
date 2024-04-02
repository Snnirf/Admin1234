namespace Frinna_Candelaria_Number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Admin";

            string password = "Admin1234";

            int Tries = 3;

            while (Tries >= 1)
            {
                Console.Write("Username : ");
                string a = Console.ReadLine();

                Console.Write("Password : ");
                string b = Console.ReadLine();

                if (a == username && b == password) break;
                else
                {
                    Tries--;
                    Console.WriteLine("Invalid Credentials");
                    Console.WriteLine();

                    if (Tries >= 1)
                    {
                        Console.WriteLine(Tries + " Please try again.");
                        Console.WriteLine();
                    }
                }
            }
            if (Tries >= 1)
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("The maximum number of attempts has been reached.");
            }
        }
    }
}