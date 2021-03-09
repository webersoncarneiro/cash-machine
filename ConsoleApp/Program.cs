using System;
using System.Globalization;

namespace ConsoleApp{

    class Program{

        static void Main(string[] args) {     
            
            ContaBancaria conta;

            //define a data atual
            DateTime d = DateTime.Now;
            Console.WriteLine("Goiânia, " + d);
            Console.WriteLine();
            Console.WriteLine("Welcome to the eletronic Box !! ");

            //inicia as operações
            Console.WriteLine("For initialization the operations, click 'ENTER' ");
            string teclad = Console.ReadLine();
            if (teclad == "ENTER") {
                Console.WriteLine("Welcome to the box client ");
            }
            //informações de entrada(cliente)
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Insert the number to the count :");
            int count = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("What is your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("What is the name the your bank ? :");
            string bank = Console.ReadLine();

            //condicional se haverá depósito ou não
            Console.WriteLine("there will be initial deposit y/n ?");
            char initial = char.Parse(Console.ReadLine());
            if (initial == 'y' || initial == 'Y') {
                Console.WriteLine("Enter with initial value :");
                double DepositInitial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(count, name, bank, DepositInitial);
            }
            else{
                conta = new ContaBancaria(count, name, bank);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("written account data :");
            Console.WriteLine(conta);

            //condicional  de depósito
            Console.WriteLine();
            Console.WriteLine("There will be deposity y/n ? : ");
            char dep = char.Parse(Console.ReadLine());
            if (dep == 'Y' || dep == 'y'){
                Console.WriteLine("Enter with value deposity:");
                double deposity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposity(deposity);
                Console.WriteLine("updated data : ");
                Console.WriteLine(conta);
            }
            else {
                Console.WriteLine(conta);
            }
            //condicional de saque
            Console.WriteLine();
            Console.WriteLine("There will be looting ? y/n : ");
            char loot = char.Parse(Console.ReadLine());
            if (loot == 'y' || loot == 'Y') {
                Console.WriteLine("Enter with value looting : ");
                double looting = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Looting(looting);
                Console.WriteLine("Updated data : ");
                Console.WriteLine(conta);
            } else{
                Console.WriteLine(conta);
            }

            //finalizando a operação
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Want to end the operation y/n ? ");
            char finish = char.Parse(Console.ReadLine());
                  if (finish == 'Y' || finish == 'y'){
                    Console.WriteLine("Finished operation ! ");
            } else{
                Console.WriteLine("Start the operation again !");
            }
        }

    }
}

