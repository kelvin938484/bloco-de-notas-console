using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloco_de_notas_console
{
    internal class Program
    {
        static void EditarTexto()
        {
            string titulo;
            Console.WriteLine("escreva o titulo do texto que deseja editar:");
            titulo = Console.ReadLine();
            StreamWriter Sw = new StreamWriter($"C:\\bloco de notas console\\{titulo}.txt");
            Console.WriteLine("escreva a anotação:");
            var conteudo = Console.ReadLine();
            Sw.WriteLine(conteudo);
            Sw.Close();
            App();
        }
static void App()
        {
            int escolha = 0;
            Console.WriteLine("bem vindo ao bloco de notas\n");
            Console.WriteLine("escolha uma opção\n");
            Console.WriteLine("1 - criar nova anotação\n");
            Console.WriteLine("2 - visualizar anotação existente\n");
            Console.WriteLine("3 - editar anotacão existente\n");
            Console.WriteLine("4 - onde ficam minhas anotações?");
            escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    CriarTexto();
                    break;
                case 2:
                    VisualizarTexto();
                    
                    break;
                case 3:
                    EditarTexto();
                    break;
                case 4:
                    Console.WriteLine("seus textos ficam no caminho:\n");
                    Console.WriteLine("C:\\bloco de notas console\n" );
                    Console.WriteLine("Aviso: se você mudar o nome da pasta\n este programa não podera ler os arquivos\n");
                    App();
                    break;
            }
        }
        static void VisualizarTexto()
        {
            string titulo;
            string line;
            Console.WriteLine("escreva o nome do texto que deseja visualizar:\n");
            titulo = Console.ReadLine();
            StreamReader Sr = new StreamReader($"C:\\bloco de notas console\\{titulo}.txt");
            line = Sr.ReadLine();
            Console.Write("o conteudo do texto e:\n");
            while (line != null)
            {
                Console.WriteLine(line);
                line = Sr.ReadLine();   
            }
            Sr.Close();
            App();
        }
        static void CriarTexto()
        {
            string titulo;
            Console.WriteLine("escreva um titulo:\n");
            titulo = Console.ReadLine();
            StreamWriter Sw = new StreamWriter($"C:\\bloco de notas console\\{titulo}.txt");
            Console.WriteLine("escreva a anotação:\n");
            var conteudo = Console.ReadLine();
            Sw.WriteLine(conteudo);
            Sw.Close();
            App();
            
        }
        static void Main(string[] args)
        {
            App();
        }
    }
}
