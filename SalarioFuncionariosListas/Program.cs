using System;
using System.Globalization;
using System.Collections.Generic;


namespace SalarioFuncionariosListas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projeto em Ingles");
            Console.WriteLine("How many employess will be registered:");
            int qt = int.Parse(Console.ReadLine());

            int id = 0;
            string name = "";
            double salary = 0;

            List<Employess> Lista = new List<Employess>();

            for (int i = 0; i < qt; i++)
            {
                Console.WriteLine("Employee #{0}", i + 1);
                Console.Write("ID.........:");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name.......:");
                name = Console.ReadLine();
                Console.Write("Salary.....:");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Lista.Add(new Employess(id, name, salary));
            }

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Enter the employed ID that will have salary increase:");
            int xReg = int.Parse(Console.ReadLine());

            Employess emp = Lista.Find(x => x.Id == xReg);
            if (emp != null)
            {
                Console.Write("Enter with percentage:");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(perc);
            }
            else
            {
                Console.WriteLine("employeed id not exists");
            }


            Console.WriteLine("Enter the employed ID that will have FIRED:");
            int xFI = int.Parse(Console.ReadLine());
            emp = Lista.Find(x => x.Id == xFI);
            if (emp != null)
            {
                emp.fired();
            }
            else
            {
                Console.WriteLine("employeed id not exists");
            }


            Console.WriteLine("-----------------------------");
            Console.WriteLine("REGISTERED EMPLOYESS");
            foreach (Employess obj in Lista)
            {
                Console.WriteLine(obj);
            }




        }
    }
}
