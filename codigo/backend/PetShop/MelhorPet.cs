using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class MelhorPet
    {
        //variaveis
        private Petshop petshop; //referencia a classe petshop
        public List<Petshop> ListaDePetShop = new List<Petshop>(3);// Lista com todos os petshops

        //Construtor
        public MelhorPet() 
        {
            
        }

        //Metodos

        public void ListaDosPetshop() 
        {
            Petshop petshop1 = new Petshop("Meu Canino Feliz", 48, 40, 24, 20, 2);// criar pet
            ListaDePetShop.Add(petshop1); //add na lista     

            Petshop petshop2 = new Petshop("Vai Rex", 55, 50, 20, 15, 1.7);
            ListaDePetShop.Add(petshop2);

            Petshop petshop3 = new Petshop("ChowChawgas", 45, 45, 30, 30, 0.8);
            ListaDePetShop.Add(petshop3);
            Console.WriteLine("\n");
        }

        public double MelhorPetShop(DateTime dataDigitada, int nCaoGrande, int nCaoPequeno)
        {
            int nCaoG = nCaoGrande;
            int nCaoP = nCaoPequeno;
            double resultadoPet1 = 0;
            double resultadoPet2 = 0;
            double resultadoPet3 = 0;

            if (dataDigitada.DayOfWeek == DayOfWeek.Saturday || dataDigitada.DayOfWeek == DayOfWeek.Sunday) // se for sabado ou domingo
            {
                //Valor do Pet 1 = Meu Canino Feliz
                double preco1Grande = ListaDePetShop[0].precoCaoGrandeFimSemana;
                double preco1Pequeno = ListaDePetShop[0].precoPequenoFimSemana;
                resultadoPet1 = (nCaoG * preco1Grande) + (nCaoP * preco1Pequeno);
                Console.WriteLine(" resultado meu canino felix = " + resultadoPet1 + "\n");//teste

                //Valor do Pet 2 = Vai Rex
                double preco2Grande = ListaDePetShop[1].precoCaoGrandeFimSemana;
                double preco2Pequeno = ListaDePetShop[1].precoPequenoFimSemana;
                resultadoPet2 = (nCaoG * preco2Grande) + (nCaoP * preco2Pequeno);
                Console.WriteLine(" resultado meu canino felix = " + resultadoPet2 + "\n");//teste

                //Valor do Pet 3 = Chow
                double preco3Grande = ListaDePetShop[2].precoCaoGrandeFimSemana;
                double preco3Pequeno = ListaDePetShop[2].precoPequenoFimSemana;
                resultadoPet3 = (nCaoG * preco3Grande) + (nCaoP * preco3Pequeno);
                Console.WriteLine(" resultado chow = " + resultadoPet3 + "\n");//teste

                if (resultadoPet1 < resultadoPet2 && resultadoPet1 < resultadoPet3)
                {
                    Console.WriteLine("O melhor pet é: Meu Canino Feliz ");
                    return resultadoPet1;
                }
                else if (resultadoPet2 < resultadoPet1 && resultadoPet2 < resultadoPet3)
                {
                    Console.WriteLine("O melhor pet é: Vai Rex ");
                    return resultadoPet2;
                }
                else if (resultadoPet3 < resultadoPet1 && resultadoPet3 < resultadoPet2)
                {
                    Console.WriteLine("O melhor pet é: ChowChawgas ");
                    return resultadoPet3;
                }
                else if (resultadoPet1 == resultadoPet2)
                {
                    if (ListaDePetShop[0].distancia > ListaDePetShop[1].distancia)
                    {
                        Console.WriteLine("O melhor pet é: Meu Canino Feliz ");
                        return resultadoPet1;
                    }
                    else
                    {
                        Console.WriteLine("O melhor pet é: Vai Rex ");
                        return resultadoPet2;
                    }
                }
                else if (resultadoPet1 == resultadoPet3)
                {
                    if (ListaDePetShop[0].distancia > ListaDePetShop[2].distancia)
                    {
                        Console.WriteLine("O melhor pet é: Meu Canino Feliz ");
                        return resultadoPet1;
                    }
                    else
                    {
                        Console.WriteLine("O melhor pet é: ChowChawgas ");
                        return resultadoPet3;
                    }
                }
                else if (resultadoPet2 == resultadoPet3)
                {
                    if (ListaDePetShop[1].distancia > ListaDePetShop[2].distancia)
                    {
                        Console.WriteLine("O melhor pet é: Vai Rex ");
                        return resultadoPet2;

                    }
                    else
                    {
                        Console.WriteLine("O melhor pet é: ChowChawgas ");
                        return resultadoPet3;
                    }
                }
                else { return 0; }
            }
            else // se for dia de semana
            {
                //Valor do Pet 1 = Meu Canino Feliz
                double preco1Grande = ListaDePetShop[0].precoCaoGrandeDiaSemana;
                double preco1Pequeno = ListaDePetShop[0].precoPequenoDiaSemana;
                resultadoPet1 = (nCaoG * preco1Grande) + (nCaoP * preco1Pequeno);
                Console.WriteLine(" resultado meu canino feliz = " + resultadoPet1 + "\n");//teste

                //Valor do Pet 2 = Vai Rex
                double preco2Grande = ListaDePetShop[1].precoCaoGrandeDiaSemana;
                double preco2Pequeno = ListaDePetShop[1].precoPequenoDiaSemana;
                resultadoPet2 = (nCaoG * preco2Grande) + (nCaoP * preco2Pequeno);
                Console.WriteLine(" resultado meu canino felix = " + resultadoPet2 + "\n");//teste

                //Valor do Pet 3 = Chow
                double preco3Grande = ListaDePetShop[2].precoCaoGrandeDiaSemana;
                double preco3Pequeno = ListaDePetShop[2].precoPequenoDiaSemana;
                resultadoPet3 = (nCaoG * preco3Grande) + (nCaoP * preco3Pequeno);
                Console.WriteLine(" resultado chow = " + resultadoPet3 + "\n");//teste

                if (resultadoPet1 < resultadoPet2 && resultadoPet1 < resultadoPet3)
                {
                    Console.WriteLine("O melhor pet é: Meu Canino Feliz ");
                    return resultadoPet1; 
                }
                else if (resultadoPet2 < resultadoPet1 && resultadoPet2 < resultadoPet3)
                {
                    Console.WriteLine("O melhor pet é: Vai Rex ");
                    return resultadoPet2; 
                }
                else if (resultadoPet3 < resultadoPet1 && resultadoPet3 < resultadoPet2)
                {
                    Console.WriteLine("O melhor pet é: ChowChawgas ");
                    return resultadoPet3;  
                }
                else if (resultadoPet1 == resultadoPet2)
                {
                    if (ListaDePetShop[0].distancia > ListaDePetShop[1].distancia)
                    {
                        Console.WriteLine("O melhor pet é: Meu Canino Feliz ");
                        return resultadoPet1;
                    }
                    else
                    {
                        Console.WriteLine("O melhor pet é: Vai Rex ");
                        return resultadoPet2; 
                    }
                }
                else if (resultadoPet1 == resultadoPet3)
                {
                    if (ListaDePetShop[0].distancia > ListaDePetShop[2].distancia)
                    {
                        Console.WriteLine("O melhor pet é: Meu Canino Feliz ");
                        return resultadoPet1;
                    }
                    else
                    {
                        Console.WriteLine("O melhor pet é: ChowChawgas ");
                        return resultadoPet3;
                    }
                }
                else if(resultadoPet2 == resultadoPet3)
                {
                    if (ListaDePetShop[1].distancia > ListaDePetShop[2].distancia)
                    {
                        Console.WriteLine("O melhor pet é: Vai Rex ");
                        return resultadoPet2;
                        
                    }
                    else
                    {
                        Console.WriteLine("O melhor pet é: ChowChawgas ");
                        return resultadoPet3;
                    }
                }
                else { return 0; }
            }
        }
        public void Exibir() //teste
        {
            for (int i = 0; i < ListaDePetShop.Count; i++) // teste: mostrar o que esta na lista
            {
                Console.WriteLine("nome do Pet: " + ListaDePetShop[i].nomePetshop);
                Console.WriteLine("Preço Cao Grande Dia Semana: " + ListaDePetShop[i].precoCaoGrandeDiaSemana);
                Console.WriteLine("Preço Cao Grande Fim Semana: " + ListaDePetShop[i].precoCaoGrandeFimSemana);
                Console.WriteLine("Preço Cao Pequeno Dia Semana: " + ListaDePetShop[i].precoPequenoDiaSemana);
                Console.WriteLine("Preço Cao Pequeno Fim Semana: " + ListaDePetShop[i].precoPequenoFimSemana);
                Console.WriteLine("Distancia: " + ListaDePetShop[i].distancia + " km \n");
            }
             
        }
    }
}
