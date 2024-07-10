/*


    
    Un cliente solicita una mini app en consola que imprima frases 
    de forma aleatoria cada que es ejecutado.
*/
using System;
class MiSegundoVector {
  static void Main() {
    string[] frases = {
      "Nunca es demasiado tarde para ser lo que podrías haber sido",
      "Aprender de los errores es de sabios",
      "La adversidad te hace reconocerte a ti mismo"
    };
    
    // aleatorio
    Random aleatorio = new Random();
    int posicion = aleatorio.Next(0,2);
    
    // imprimir frase aleatoria
    Console.WriteLine(frases[posicion]);
    
  }
}
