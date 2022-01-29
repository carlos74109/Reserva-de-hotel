using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTryCath.Entidade
{
    internal class Reserva
    {
        public int numeroQuarto;
        public DateTime chekin;
        public DateTime chekout;

        public Reserva()
        {

        }

        public Reserva(int numeroQuarto, DateTime chekin, DateTime chekout)
        {
            this.numeroQuarto = numeroQuarto;
            this.chekin = chekin;
            this.chekout = chekout;
        }

        public int Duracao()
        {
            TimeSpan duracao = chekout.Subtract(chekin);
            return (int)duracao.TotalDays;
        }

        public void updateDatas(DateTime chekin, DateTime checkout)
        {
            this.chekin = chekin;
            chekout = checkout;
        }

        public override string ToString()
        {
            return "Quarto "
                + numeroQuarto
                + chekin.ToString(" dd/MM/YYYY")
                + ", chek-out: "
                + chekin.ToString(" dd/MM/YYYY")
                + ", "
                + Duracao()
                + " noites";
        }
    }
}
