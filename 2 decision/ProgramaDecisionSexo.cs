/******************************************************************************
Autor:          Julian A. Peña
Fecha:          2024-05-22
Descripción:    Programa con decisiones para
                determinar el sexo de un usuario.
*******************************************************************************/

using System;
class Programa {
  static void Main() {
    // variables
    bool sexoMasculino; 
    // capturar información del usuario
    Console.Write("Digite true si es hombre: ");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    // validación
    if (sexoMasculino == true)
    { 
        Console.WriteLine("Felicidades, es hombre"); 
    }
    else{
        Console.WriteLine("Felicidades, es mujer"); 
    }
    Console.WriteLine("Finalizada la ejecución");
  }
}
