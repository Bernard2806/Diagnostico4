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

        private static void SelActivity(int seleccion){
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
            while (x < ListSongs.Length){
                Console.Clear();
                Console.WriteLine("Ingrese una Cancion [" + x + "]: ");
                ListSongs[x] = Console.ReadLine();
                x++;
            }
            Console.Clear();
            Console.WriteLine("Acontinuacion se mostraran las canciones:");
            Console.ReadKey();
            Console.Clear();
            x = 0;
            while (x < ListSongs.Length){
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
            Console.Clear();
            Console.WriteLine("Acontinuacion se mostraran las canciones:");
            Console.ReadKey();
            Console.Clear();
            for (int x = 0; x < ListSongs.Length; x++) Console.WriteLine("Cancion [" + x + "]:" + ListSongs[x]);
        }

        private static void Activity3(){
            string[] NameList = new string[5];
            int[] AgeList = new int[5];
            int x = 0;
            while (x < NameList.Length){
                Console.Clear();
                Console.WriteLine("Ingrese el Nombre de la Persona [" + x + "]: ");
                NameList[x] = Console.ReadLine();
                Console.WriteLine("Ingrese la Edad de la Persona [" + x + "]: ");
                AgeList[x] = int.Parse(Console.ReadLine());
                x++;
            }
            Console.Clear();
            Console.WriteLine("Acontinuacion se mostraran los Nombres y la Edad:");
            Console.ReadKey();
            Console.Clear();
            x = 0;
            while (x < NameList.Length)
            {
                Console.WriteLine("Persona Nº" + x);
                Console.WriteLine("Nombre: " + NameList[x]);
                Console.WriteLine("Edad: " + AgeList[x]);
                x++;
            }
        }

        private static void Activity4(){
            string[] NameList = new string[5];
            int[] AgeList = new int[5];
            for(int i = 0; i < NameList.Length; i++){
                Console.Clear();
                Console.WriteLine("Ingrese el Nombre de la Persona [" + i + "]: ");
                NameList[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la Edad de la Persona [" + i + "]: ");
                AgeList[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Acontinuacion se mostraran los Nombres y la Edad:");
            Console.ReadKey();
            Console.Clear();
            for (int x = 0; x < NameList.Length; x++){
                Console.WriteLine("Persona Nº" + x);
                Console.WriteLine("Nombre: " + NameList[x]);
                Console.WriteLine("Edad: " + AgeList[x]);
            }
        }

        private static void Activity5(){
            int[] ListNum1 = new int[5];
            int[] ListNum2 = new int[5];
            int[] ListRes = new int[5];

            for(int i = 0; i < ListNum1.Length; i++){
                Console.Clear();
                Console.WriteLine("Pos: " + i);
                Console.WriteLine("Ingrese el N1 para la suma:");
                ListNum1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el N2 para la suma:");
                ListNum2[i] = int.Parse(Console.ReadLine());
                ListRes[i] = ListNum1[i] + ListNum2[i];
            }
            Console.Clear();
            Console.WriteLine("Acontinuacion se mostraran los resultados:");
            Console.ReadKey();
            Console.Clear();
            for (int x = 0; x < ListNum1.Length; x++){
                Console.WriteLine("Suma [" + x + "]: " + ListNum1[x] + " + " + ListNum2[x] + " = " + ListRes[x]);
            }
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
