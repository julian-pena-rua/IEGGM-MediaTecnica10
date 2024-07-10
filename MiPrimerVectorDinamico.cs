/*
    son variables para almacenar múltiples datos
*/

using System;
class MiPrimerVector {
  static void Main() {
    
    // declaración
    string[] nombres = new string[3];
    
    // asignación de un vector dinámico
    for (int i = 0; i <= 2; i++) {
        nombres[i] = Console.ReadLine();
    }
    
    /* imprimir un dato del vector de manera dinámica
       recorrer imprimiendo el vector */
    for (int i = 0; i <= 2; i++) {
        Console.WriteLine(nombres[i]);
    }
  }
}
