using DesafioTryCath.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTryCath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero do quarto: ");
            int numeroQuarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Data do check-in (DD/MM/YYYY)");
            DateTime chekin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Data do chek-out");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if(checkout <= chekin)
            {
                Console.WriteLine("Erro, a data do check-out, tem que ser posterior ao check-in");
            }else
            {
                Reserva reserva = new Reserva(numeroQuarto, chekin, checkout);
                Console.WriteLine(reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");

                Console.WriteLine("Data do check-in (DD/MM/YYYY)");
                chekin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Data do chek-out");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if(chekin < now || checkout < now)
                {
                    Console.WriteLine("Erro na reserva, tem que ser datas futuras");
                }else if(checkout <= chekin)
                {
                    Console.WriteLine("Erro na reserva: A reserva tem que ser datas futuras ");
                }
                else
                {
                    reserva.updateDatas(chekin, checkout);
                    Console.WriteLine(reserva);
                }

            }



        }
    }
}
