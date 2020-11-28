using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ATV_EXER2_16._11._2020
{
    class Tercerizado : Funcionario
    {
        //Encapsulamento
        private double Adicional { get; set; }

        //Construtor
        public Tercerizado(string nome, int horas, double valor, double adicional) 
            : base(nome, horas, valor)
        {
            Adicional = adicional;
        }

        //Calcular quanto o funcionário tercerizado ganha e com adicional
        public override double Pagamento()
        {
            return ValorHrs * Horas + Adicional * 1.1;
        }
    }
}
