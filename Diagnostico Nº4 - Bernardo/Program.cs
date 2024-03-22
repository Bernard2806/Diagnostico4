using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Using for timers
using System.Threading;

namespace Diagnostico_Nº4___Bernardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do{
                int i = PrintMenu();
                SelActivity(i);
            } while (true);
        }

        private static int PrintMenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            string ASCIIMenu = @"
             
  _____  _                             _   _                      _  _   
 |  __ \(_)                           | | (_)                    | || |  
 | |  | |_  __ _  __ _ _ __   ___  ___| |_ _  ___ ___    ______  | || |_ 
 | |  | | |/ _` |/ _` | '_ \ / _ \/ __| __| |/ __/ _ \  |______| |__   _|
 | |__| | | (_| | (_| | | | | (_) \__ \ |_| | (_| (_) |             | |  
 |_____/|_|\__,_|\__, |_| |_|\___/|___/\__|_|\___\___/              |_|  
                  __/ |                                                  
                 |___/                                                   

            ";
            Console.WriteLine(ASCIIMenu);
            Console.WriteLine("");
            Console.WriteLine("Presione Cualquier Tecla para Continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("/////////////////////");
            Console.WriteLine("/// Diagnostico 4 ///");
            Console.WriteLine("///  Actividades  ///");
            Console.WriteLine("/////////////////////");
            Console.WriteLine("///    [1 - 5]    ///");
            Console.WriteLine("/////////////////////");
            int sel = int.Parse(Console.ReadLine());
            return sel;
        }

        private static void SelActivity(int seleccion)
        {
            switch (seleccion){

                case 1:
                    Activity1(); 
                    break;
                case 2:
                    Activity2();
                    break;
                case 3:
                    Activity3();
                    break;
                case 4:
                    Activity4();
                    break;
                case 5:
                    Activity5();
                    break;
                default:
                    ErrorText("[ERROR 404]: No se Selecciono Niguna Actividad Existente");
                    ExitProgram();
                    break;
            }
            Console.WriteLine("Presione Cualquier Tecla para Continuar...");
            Console.ReadKey();
        }

        private static void Activity1() {
            string[] ListSongs = new string[5];
            int x = 0;
            while (x < ListSongs.Length)
            {
                Console.Clear();
                Console.WriteLine("Ingrese una Cancion [" + x + "]: ");
                ListSongs[x] = Console.ReadLine();
                x++;
            }
            Console.WriteLine("Acontinuacion se mostraran las canciones:");
            Console.ReadKey();
            Console.Clear();
            x = 0;
            while (x < ListSongs.Length)
            {
                Console.WriteLine("Cancion [" + x + "]:" + ListSongs[x]);
                x++;
            } 
        }

        private static void Activity2(){
            string[] ListSongs = new string[5];
            for (int i = 0; i < ListSongs.Length; i++){
                Console.Clear();
                Console.WriteLine("Ingrese una Cancion [" + i + "]: ");
                ListSongs[i] = Console.ReadLine();
            }
            Console.WriteLine("Acontinuacion se mostraran las canciones:");
            Console.ReadKey();
            Console.Clear();
            for (int x = 0; x < ListSongs.Length; x++) Console.WriteLine("Cancion [" + x + "]:" + ListSongs[x]);
        }

        private static void Activity3()
        {

        }

        private static void Activity4()
        {

        }

        private static void Activity5()
        {

        }
        private static void ExitProgram(){
            string ASCIIError = @"
            
      (    (        )   (     
      )\ ) )\ )  ( /(   )\ )  
 (   (()/((()/(  )\()) (()/(  
 )\   /(_))/(_))((_)\   /(_)) 
((_) (_)) (_))    ((_) (_))   
| __|| _ \| _ \  / _ \ | _ \  
| _| |   /|   / | (_) ||   /  
|___||_|_\|_|_\  \___/ |_|_\  
                              

            ";
            Console.Clear();
            if (Console.BackgroundColor == ConsoleColor.Red) Console.WriteLine(ASCIIError);
            Console.Write("Saliendo del Programa");
            for (int x = 0; x < 4; x++){
                Thread.Sleep(500);
                Console.Write(".");
            }
            Environment.Exit(0);
        }

        private static void ErrorText(string Text){
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(Text);
            Thread.Sleep(1000);
        }
    }
}
