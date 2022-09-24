using System;
using System.Text;
using System.Threading.Tasks;

namespace tugas_calculator
{
	class Program
	{
		static void Main(string[] args)
		{
            int hasil;
            Console.Write("Enter the action to be performed \n");
            Console.Write("Press 1 for Addition \n");
            Console.Write("Press 2 for Substraction \n");
            Console.Write("Press 3 for Multiplication \n");
            Console.Write("Press 4 for Division \n");
            
            string operation = Console.ReadLine();
            

            Console.Write("Enter 1st input \n");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd input \n");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "1":
                    hasil = angka1 + angka2;
                    Console.WriteLine("The result is " + hasil);
                    break;
                case "2":
                    hasil = angka1 - angka2;
                    Console.WriteLine("The result is " + hasil);
                    break;
                case "3":
                    hasil = angka1 * angka2;
                    Console.WriteLine("The result is " + hasil);
                    break;
                case "4":
                    hasil = angka1 / angka2;
                    Console.WriteLine("The result is " + hasil);
                    break;
                default:
                    Console.WriteLine("Salah Input!");
                    break;
            }
		}
	}

}
