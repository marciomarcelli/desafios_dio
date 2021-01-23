using System;

class Desafio {
    static void Main() {
      
        string[] entrada = Console.ReadLine().Split(" ");
        int horasDeViagem = Int32.Parse(entrada[0]);
        int velocidadeMedia = Int32.Parse(entrada[1]);
        double distanciaPercorrida = velocidadeMedia * horasDeViagem;
        double distanciaPorLitro = 12;
        double quantidadeLitrosCombustivel = distanciaPercorrida / distanciaPorLitro;
        
        Console.WriteLine(quantidadeLitrosCombustivel.ToString("N3"));
    }
}