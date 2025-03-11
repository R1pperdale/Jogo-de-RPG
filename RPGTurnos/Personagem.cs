using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTurnos
{
    public class Personagem
    {
        string nome;
        string classe;
        int pontosdevida;
        int pontosdeenergia;
        int experiencia;
        int nivel;
        int ataque;
        int resistencia;
        int vidapornivel;
        int energiapornivel;

        Personagem Char = new Personagem();

        public void criacaoPersonagem()
        {
            Console.WriteLine("Insira o nome do seu personagem");
            nome = Console.ReadLine();
            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("CLASSES DISPONÍVEIS:");
                Console.WriteLine("");
                Console.WriteLine("1 - Guerreiro");
                Console.WriteLine("2 - Arqueiro");
                Console.WriteLine("3 - Mago");
                Console.WriteLine("4 - Clérigo");
                Console.WriteLine("");
                Console.WriteLine("Escreva qual a classe do seu personagem");
                classe = Console.ReadLine();
            } while (classe != "Guerreiro" && classe != "Arqueiro" && classe != "Mago" && classe != "Clérigo");

            Console.Clear();
            Console.WriteLine("Bem vindo " + nome + "! Você pertence a classe " + classe + ".Seus pontos de atributos são: ");
            if (classe == "Guerreiro")
            {
                construirGuerreiro();
                Console.ReadKey();
            }
            else if (classe == "Arqueiro")
            {
                construirArqueiro();
                Console.ReadKey();
            }
            else if (classe == "Mago")
            {
                construirMago();
                Console.ReadKey();
            }
            else if (classe == "Clérigo")
            {
                construirClerigo();
                Console.ReadKey();
            }
        }

        public void construirGuerreiro()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida= 200;
            pontosdeenergia = 50;
            ataque = 10;
            resistencia = 10;
            vidapornivel = 25;
            energiapornivel = 5;
            Console.WriteLine("Nível: " +nivel);
            Console.WriteLine("Experiência: " +experiencia);
            Console.WriteLine("Pontos de Vida: " +pontosdevida);
            Console.WriteLine("Pontos de Energia: " +pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível" + energiapornivel);
        }

        public void construirArqueiro()
        {   
            experiencia = 0;
            nivel = 1;
            pontosdevida= 125;
            pontosdeenergia = 125;
            ataque = 14;
            resistencia = 6;
            vidapornivel = 15;
            energiapornivel = 15;
            Console.WriteLine("Nível: " + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível" + energiapornivel);
        }

        public void construirMago()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida= 75;
            pontosdeenergia = 175;
            ataque = 16;
            resistencia = 4;
            vidapornivel = 5;
            energiapornivel = 25;
            Console.WriteLine("Nível: " + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível" + energiapornivel);
        }

        public void construirClerigo()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida= 100;
            pontosdeenergia = 150;
            ataque = 8;
            resistencia = 12;
            vidapornivel = 10;
            energiapornivel = 20;
            Console.WriteLine("Nível: " + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível" + energiapornivel);
        }
    

    }
}