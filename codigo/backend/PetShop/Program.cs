using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            string data;
            int quantCaoGrande, quantCaoPequeno;
            DateTime dataEscolhida;
            double valor;
            MelhorPet melhorPet = new MelhorPet();// instanciar 

            melhorPet.ListaDosPetshop();//chamae metodo para criar listas dos pets 

            melhorPet.Exibir();//teste

            //Inicio interação com usuario
            //Console.WriteLine("Vamos achar o melhor petShop para você:\n");
            Console.WriteLine("Digite a data que deseja levar o seu pet:\n");
            data = Console.ReadLine(); // ler resposta do usuario

            if (DateTime.TryParseExact(data, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataEscolhida))// converte strimg inserida pelo usuario em data time
            {
                //conversão for bem-sucedida, exiba a data
                Console.WriteLine("Você inseriu a data: " + dataEscolhida + "\n");//conversão for bem-sucedida, exibir data

                Console.WriteLine("Digite a quantidade de Cachorros de porte grande:\n");
                quantCaoGrande = int.Parse(Console.ReadLine()); // ler resposta do usuario
                Console.WriteLine("\n");

                Console.WriteLine("Digite a quantidade de Cachorros de porte pequeno:\n");
                quantCaoPequeno = int.Parse(Console.ReadLine()); // ler resposta do usuario
                Console.WriteLine("\n");

                //chamar metodo
                valor = melhorPet.MelhorPetShop(dataEscolhida, quantCaoGrande, quantCaoPequeno);
                Console.WriteLine("Valor total:"+ valor +" reais \n");

            }
            else
            {
                // Se a conversão falhar, exiba uma mensagem de erro
                Console.WriteLine("Formato de data inválido. + \n");
            }  
        }
    }
}
