using System;
using System.Collections.Generic;

class Program {
  
  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    string figurinhaNumero = Console.ReadLine();
    var figurinhas = new List<string>();
    
    while (!String.IsNullOrEmpty(figurinhaNumero))
    {
      if (!figurinhas.Contains(figurinhaNumero))
        figurinhas.Add(figurinhaNumero);
        
      figurinhaNumero = Console.ReadLine();
    }
    
    
    int numeroDeFigurinhasFaltaComprar = numeroDeFigurinhas - figurinhas.Count;
    
    Console.WriteLine(numeroDeFigurinhasFaltaComprar);
    
  }  

}