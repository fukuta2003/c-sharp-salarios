using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SalarioFuncionariosListas {
    class Employess {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Situation { get; set; }

        public Employess(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
            Situation = "admitted";
        }

        public void increaseSalary(double percentage) {
            Salary += ((Salary * percentage) / 100);
        }

        public void fired() {
            Situation = "Fired";
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Situation;
        }
    }
}
