using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ATV_EXER2_16._11._2020
{
    class Funcionario
    {
        //Encapsulamento
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHrs { get; set; }

        //Construtor
        public Funcionario(string nome, int horas, double valor)
        {
            Nome = nome;
            Horas = horas;
            ValorHrs = valor;
        }

        //Calcula quanto o funcionário ganha
        public virtual double Pagamento()
        {
            return ValorHrs * Horas;
        }
    }
}
