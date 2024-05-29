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
    Console.Write("Digitar opción deseada: ");
    int opcion = Int32.Parse(Console.ReadLine());

    // 3.5 capturar los números elegidos por el usuario
    Console.Write("\nDigitar numero 1: ");
    int numero1 = Int32.Parse(Console.ReadLine());
    Console.Write("\nDigitar numero 2: ");
    int numero2 = Int32.Parse(Console.ReadLine());
    
    // 4 Validar opción elegida
    if( opcion == 1){
        Console.WriteLine("La suma es: " + (numero1+numero2));
    }
    
    if( opcion == 2){
        Console.WriteLine("La resta es: " + (numero1-numero2));
    }
    
    if( opcion == 3){
        Console.WriteLine("La multiplicación es: " + (numero1*numero2));
    }
    
    if( opcion == 4){
        if ( numero1 != 0 || numero2 !=0){
            Console.WriteLine("La división es: " + (numero1/numero2));    
        }
        else{
            Console.WriteLine("No se puede dividir por cero.");    
        }
        
    }
    
    
    
    // 5 Mostrar resultado o finalizar ejecución
    }
}
