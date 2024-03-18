using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Zoológico de Madisson");

            Zoo zoo = new Zoo();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Ver animales y sus características");
                Console.WriteLine("2. Darle de comer a los animales");
                Console.WriteLine("3. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        zoo.VerAnimales();
                        break;
                    case "2":
                        zoo.DarDeComer();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }

    class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void EmitirSonido()
        {
            Console.WriteLine("El animal emite un sonido.");
        }
    }

    class Leon : Animal
    {
        public Leon(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("¡Rugido!");
        }
    }

    class Mono : Animal
    {
        public Mono(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("¡Ooooh ooooh aaaaah!");
        }
    }

    class Serpiente : Animal
    {
        public Serpiente(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("¡Sssssss!");
        }
    }

    class Zoo
    {
        private Animal[] animales;

        public Zoo()
        {
            animales = new Animal[]
            {
                new Leon("León", 5),
                new Mono("Mono", 10),
                new Serpiente("Serpiente", 3),
                new Elefante("Elefante", 6),
                new Tigre("Tigre", 10),
                new Oso("Oso", 15),
                new Cocodrilo("Cocodrilo", 9),
                new Pinguino("Pinguino", 3),
                new Lobo("Lobo", 11),
                new Cebra("Cebra", 1),
                new Rinoceronte("Rinoceronte", 12),
                new Panda("Panda", 8),
                new PavoReal("Pavo Real", 4),
                new OsoPolar("Osopolar", 23),
                new Camello("Camello", 42),

               
            };
        }

        class Elefante : Animal
        {
            public Elefante(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Barrito!");
            }
        }


        class Tigre : Animal
        {
            public Tigre(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Roarrrr!");
            }
        }

        class Oso : Animal
        {
            public Oso(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Gruñido!");
            }
        }

        class Cocodrilo : Animal
        {
            public Cocodrilo(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Siseo!");
            }
        }
        class Pinguino   : Animal
        {
            public Pinguino(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡graznido!");
            }
        }
        class Lobo : Animal
        {
            public Lobo(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Aullido!");
            }
        }
        class Cebra : Animal
        {
            public Cebra(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Yip!");
            }
        }
        class Rinoceronte : Animal
        {
            public Rinoceronte (string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Barrita!");
            }
        }
        class Panda : Animal
        {
            public Panda(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡chillido!");
            }
        }
        class PavoReal : Animal
        {
            public PavoReal(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Glúglú!");
            }
        }
        class Tortuga : Animal
        {
            public Tortuga(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Ahhhhhh!");
            }
        }
        class OsoPolar : Animal
        {
            public OsoPolar(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Grrrroar!");
            }
        }
        class Camello : Animal
        {
            public Camello(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override void EmitirSonido()
            {
                Console.WriteLine("¡Ronquido!");
            }
        }

        public void VerAnimales()
        {
            Console.WriteLine("Animales en el zoológico:");
            foreach (Animal animal in animales)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}, Edad: {animal.Edad}");
                animal.EmitirSonido();
            }
        }

        public void DarDeComer()
        {
            Console.WriteLine("¡Es hora de alimentar a los animales!");
            foreach (Animal animal in animales)
            {
                if (animal is Leon)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con carne.");
                }
                else if (animal is Mono)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con bananas.");
                }
                else if (animal is Serpiente)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con ratones.");
                }
                else if (animal is Elefante)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con hierbas y cortezas.");
                }
                else if (animal is Tigre)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con carne.");
                }
                else if (animal is Oso)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con carne, pescado y bayas.");
                }
                else if (animal is Cocodrilo)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con carne, pescado.");
                }
                else if (animal is Pinguino)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Peces, Crustaceos krill.");
                }
                else if (animal is Lobo)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Carne y aves");
                }
                else if (animal is Cebra)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Hierbas y frutas");
                }
                else if (animal is Rinoceronte)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Hierbas, carne y frutas");
                }
                else if (animal is Panda)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Hierbas, carne, bambú y frutas");

                }
                else if (animal is PavoReal)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Hierbas y frutas");

                }
                else if (animal is Tortuga)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Hierbas y frutas");

                }

                else if (animal is OsoPolar)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Focas anilladas");

                }
                else if (animal is Camello)
                {
                    Console.WriteLine($"Se alimenta a {animal.Nombre} con Pasto y plantas de desierto");

                }


            }
        }
    }
}
