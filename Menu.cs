using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;

            MostrarTela();
            MostrarOpcoes();

            var option = short.Parse(Console.ReadLine());
            EscolherOpcoes(option);
        }

        public static void MostrarTela()
        {
            Lines();

            for(var lines = 0; lines <= 10; lines++){

                Console.Write("|");
                for(int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Lines();
        }

        public static void Lines()
        {
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void MostrarOpcoes()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("Escolha uma opção abaixo: ");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.WriteLine("Opção: ");
        }

        public static void EscolherOpcoes(short option)
        {
            switch(option){
                case 1: Editor.Show(); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}