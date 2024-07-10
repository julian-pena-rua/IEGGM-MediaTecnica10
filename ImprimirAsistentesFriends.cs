/*


    Los personajes de Friends están 
    organizando un evento y necesitan 
    un programa en C# para imprimir 
    los nombres de los asistentes. 
    Chandler, Joey, Monica, Rachel, Ross, Phoebe
*/
using System;
class MiSegundoVector {
  static void Main() {
    
    // declaración y asignación de un vector dinámico
    string[] asistentes = {
        "Chandler", 
        "Joey", 
        "Monica", 
        "Rachel", 
        "Ross", 
        "Phoebe"};
    
    /* imprimir un dato del vector de manera dinámica
       recorrer imprimiendo el vector */
    for (int p = 0; p < 6; p++){
        Console.WriteLine(asistentes[p]);
    }
  }
}
