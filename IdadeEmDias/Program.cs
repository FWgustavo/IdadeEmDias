using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos meses se passaram do seu aniversário: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dias se passaram depois que você fez mesversário: ");
            int dias = int.Parse(Console.ReadLine());

            int total_ano = anos * 365;
            int total_mes = mes * 30;
            int total = total_ano + total_mes + dias;
            Console.WriteLine("A sua idade em dias é: " + total);
            Console.ReadKey();
            
        }
    }
}
