using System;
using System.IO;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR - ESC para sair");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("Deseja Salvar o arquivo?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            var option = short.Parse(Console.ReadLine());
            OpcoesArquivo(option, file); 
        }

        public static void OpcoesArquivo(short option, StringBuilder file)
        {
            switch(option)
            {
                case 1: SalvarArquivo(file); break;
                default: Viewer.Show(file.ToString()); break;
            }
        }

        public static void SalvarArquivo(StringBuilder file)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho que deseja salvar o arquivo");
            var path = Console.ReadLine();
            
            using(var newFile = new StreamWriter(path))
            {
                newFile.Write(file);
            }

            Viewer.Show(file.ToString());
        }
    }
}