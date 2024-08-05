/******************************************************************************

Autor: Julián A. Peña
Fecha: 2024-06-05
Descripción: Programa aprendizaje ciclos o bucles
             Calcular promedio para nota.
             El docente brinda 4 notas y debe calcular el promedio.
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    // variables
    int nota = 0;
    int promedio = 0;
    
    // bienvenida a la app
    Console.WriteLine("Bienvenido a miniApp promedio notas.");
    
    // solicitud notas
    for (int i = 0; i <= 3; i++) 
    {
        Console.WriteLine("Docente, favor ingresar la nota " + i + ", luego presionar enter");
        nota = nota + Int32.Parse(Console.ReadLine());
    }
    promedio = nota / 4;
    // mostrar promedio
    Console.WriteLine("El promedio es: " + promedio);
  }
}
