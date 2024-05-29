/******************************************************************************

                Ejercicio estructura de decisión múltiple
Se desea un programa que ayude diciendo 
las preferencias según el género:
- Si es un hombre menor de edad sus preferencias son:
    Figuras de acción, Caricaturas, Series TV
- Si es un hombre mayor de edad sus preferencias son:
    cine, picnic y filantropía
- Si es una mujer menor de edad sus preferencias son:
    Muñecas, Maquillaje, Series TV
- Si es una mujer mayor de edad sus preferencias son:
    Maquillaje, Series TV, Cine, filantropía
*******************************************************************************/
using System;
class programa {
  static void Main() {
        // variables
        Console.WriteLine("Escribir 'hombre' o 'mujer' ");
        string genero = Console.ReadLine(); // hombre, mujer
        Console.WriteLine("Escribir edad en números ");
        int edad = Int32.parse(Console.ReadLine());
        // validaciones
        if( genero == "hombre" ){
            
        }
        if( genero == "mujer" ){
            
        }
    }
}
