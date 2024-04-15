using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    
    internal class Petshop
    {
        //variaves
        public string nomePetshop { get; }
        public double precoCaoGrandeDiaSemana{ get; }
        public double precoCaoGrandeFimSemana{ get; }
        public double precoPequenoDiaSemana{ get; }
        public double precoPequenoFimSemana{ get; }
        public double distancia { get; }
        
        //Construtor
        public Petshop(string nomePetshop, double precoCaoGrandeFimSemana, double precoCaoGrandeDiaSemana, double precoPequenoFimSemana, double precoPequenoDiaSemana, double distancia)
        {
            this.nomePetshop = nomePetshop;
            this.precoCaoGrandeDiaSemana = precoCaoGrandeDiaSemana;
            this.precoCaoGrandeFimSemana = precoCaoGrandeFimSemana;
            this.precoPequenoDiaSemana = precoPequenoDiaSemana;
            this.precoPequenoFimSemana = precoPequenoFimSemana;
            this.distancia = distancia;
        }

        //Metodos
    }
}
