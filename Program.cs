using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Persona
{
    class Program
    {
        
        public class Persona
        {
            public string name;
            public Persona()
            {
                name = "Unknown";
            }
            public Persona(string nm)
            {
                name = nm;
            }
            public void SetName(string NewName)
            {
                name = NewName;
            }
        }

        static void Main()
        {
            Persona persona1 = new Persona();
            Console.WriteLine(persona1.name);

            persona1.SetName("Julio Fallas Diaz");
            Console.WriteLine(persona1.name);

            Persona persona2 = new Persona("Bob Patiño");
            Console.WriteLine(persona2.name);

            Console.WriteLine("Prescione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        
    }
}
