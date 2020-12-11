using System;

namespace Classes
{
    public class Funcionario
    {
        public string[] lista = {"Paulo", "Tsuka"};

        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice){
            Console.ForegroundColor = ConsoleColor.Blue;
            if(indice < lista.Length){
                Console.WriteLine(lista[indice]);
            }
            Console.ResetColor();    
        }

        public void Mostrar(string busca){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                if(item == busca){
                   Console.WriteLine("Resultado da busca :" + item);

                }
                Console.ResetColor();
            }
        }

    }
}