/*
    son variables para almacenar múltiples datos
*/



using System;
class MiPrimerVector {
  static void Main() {
    
    // declaración y asignación de un vector directa
    string[] nombres = {"julian", "efrain", "la maria"};
    
    // imprimir un dato del vector de manera directa
    Console.WriteLine(nombres[0]);
    
    /* imprimir un dato del vector de manera dinámica
       recorrer imprimiendo el vector */
    for (int i = 0; i <= 2; i++) {
        Console.WriteLine(nombres[i]);
    }
  }
}
