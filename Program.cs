using System;
using Classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos nossa classe Funcionario
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Tsuka");
            fun.Mostrar(1);
            Console.Beep();
        }
    }
}
