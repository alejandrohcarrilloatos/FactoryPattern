using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserFactory factory = null;


            Console.WriteLine("Hola Mundo Factory!");
            Console.WriteLine("¿Que tipo usuario desea crear? \na) ProjectManager \nb) FunctionalAnalyst \nC) Developer");

            string userType = Console.ReadLine();

            switch (userType.ToLower())
            {
                case "a":
                    factory = new ProjectManagerFactory(0, "Usuario PM", "Jhon", "K", "Maney");
                    break;
                case "b":
                    factory = new FunctionalAnalystFactory(1, "Usuario FA", "Elmer", "Homero", "Mc");
                    break;
                case "c":
                    factory = new ProjectManagerFactory(2, "Usuario DEV", "Soila", "Q", "Programa");
                    break;

            }

            User user = factory.CreateUser();
            Console.WriteLine("La informacion del usuario se muestra a continuacion: \n----------------------------------------------------");
            Console.WriteLine("User Type: {0} \nUserName : {1} \nNombre : {2}\nApellido Paterno : {3} \nApellido Materno : {4}", user.UserType, user.UserName, user.Nombre, user.ApellidoPaterno, user.ApellidoMaterno);

            Console.ReadKey();
        }
    }
}
