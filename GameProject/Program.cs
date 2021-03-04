using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "Tarlan",
                LastName = "Abdullayev",
                IdentityNumber = 12345
            });
           
                
                Console.WriteLine("Teşekkürler");
        }
    }
}
