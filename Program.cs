using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _numerosInteiros = new int[2];

            Console.WriteLine("------ Sequência Pares ------\n Digite dois valores inteiros, em seguida será exibido todos os números pares entre zero e o número digitado.\n");

            for(int i = 0; i < _numerosInteiros.Length; i++){
                Console.Write($"Digite o {i+1}º valor: ");
                int.TryParse(Console
                .ReadLine()
                .ToString(), out _numerosInteiros[i]);
            }

            int _maiorValor = _numerosInteiros[0] > _numerosInteiros[1] ? _numerosInteiros[0] : _numerosInteiros[1];
            int _menorValor = _numerosInteiros[0] < _numerosInteiros[1] ? _numerosInteiros[0] : _numerosInteiros[1];

            Console.WriteLine($"\nNumeros pares inteiros entre {_menorValor} e {_maiorValor}:");

            for(int i = 0;_menorValor <= _maiorValor;i++){
                if(_menorValor%2==0 && _menorValor>=0) Console.Write($"{_menorValor} ");
                _menorValor++;
            }
        }    
    }
}
