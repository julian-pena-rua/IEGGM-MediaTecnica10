/***********************************************************************
Autor:          Julián A. Peña
Fecha:          29-05-2024 
github:         https://github.com/julian-pena-rua
Descripción:    


    ************
    App con Menú
    ************
    Se solicita crear una minicalculadora que realice:
    - Suma
    - Resta
    - Multiplicación
    - División
    Debe terminar la ejecución al usuario elegir opción "Salir"
***********************************************************************/
using System;
using System.Threading;

class Program {
    static void Main(string[] args) {		
    // 1 Pantalla bienvenida (imagen ASCII)
    Console.WriteLine("                                                    			");
    Console.WriteLine("                       :#*-.                        			");
    Console.WriteLine("                     :%%%%##%%%%*-.                 			");  			
    Console.WriteLine("                   .#*--=-=+#%%%%##%%%#+:           			");
    Console.WriteLine("                  .##-+--===-=+*%%%%%##%%%+:        			");
    Console.WriteLine("                .*#**#%%*=-==:===-:.-+#%%%%+        			");
    Console.WriteLine("               .*####***#%%#=-=-:=-::..:#%*.        			");
    Console.WriteLine("              .*#****###*++*%%#+-=::-:.-%*.         			");
    Console.WriteLine("            .*#%#%**##%##*******+*#%#+%#:           			");
    Console.WriteLine("           .*####**##%**##%*#*****+++*#-            			");
    Console.WriteLine("          *****++##%***##*###*+###*+#=              			");
    Console.WriteLine("         ****#*+#****#*%+**##+#***+#=               			");
    Console.WriteLine("        +**+*++*###****+#*#*=+##%=*+                			");
    Console.WriteLine("       :+#*++**+%#*=+#*%==+*%++*.                   			");
    Console.WriteLine("         .=##+-+##+***+=+#%#-+#.                    			");
    Console.WriteLine("              .-*#+==--*%%*=#:                      			");
    Console.WriteLine("                 .-*#*==*+-#:                       			");
    Console.WriteLine("                    .-*#*=+:    					");           
    Console.WriteLine("                        :=-     					");
    Console.WriteLine("       Bienvenido a la MiniCalculadora ");
    Thread.Sleep(3000); // 3 segundos = 3000 milisegundos
    Console.Clear();
    
    // 2 Mostrar menú de opciones
    Console.WriteLine("Menú de opciones");
    Console.WriteLine("Seleccionar la opción deseada:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. Divisón");
    Console.WriteLine("5. Salir");
    
    // 3 capturar opción elegida por usuario
    Console.Write("Digitar numero deseado: ");
    int opcion = Int32.Parse(Console.ReadLine());
    
    // 4 Validar opción elegida
    // 5 Mostrar resultado o finalizar ejecución
    }
}
