using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  subfilo = Console.ReadLine();
        String  classe = Console.ReadLine();
        String  dietaAlimentar = Console.ReadLine();


    if ((subfilo == "vertebrado") && ( classe == "ave") && (dietaAlimentar == "carnivoro")) {
      Console.WriteLine("aguia");
    }else if ((subfilo == "vertebrado") && ( classe == "ave") && (dietaAlimentar == "onivoro")) {
      Console.WriteLine("pomba");
    }else if ((subfilo == "vertebrado") && ( classe == "mamifero") && (dietaAlimentar == "onivoro")) {
      Console.WriteLine("homem");
    }else if ((subfilo == "vertebrado") && ( classe == "mamifero") && (dietaAlimentar == "herbivoro")) {
      Console.WriteLine("vaca");
    }else if ((subfilo == "invertebrado") && ( classe == "inseto") && (dietaAlimentar == "hematofago")) {
      Console.WriteLine("pulga");
    }else if ((subfilo == "invertebrado") && ( classe == "inseto") && (dietaAlimentar == "herbivoro")) {
      Console.WriteLine("lagarta");
    }else if ((subfilo == "invertebrado") && ( classe == "anelideo") && (dietaAlimentar == "hematofago")) {
      Console.WriteLine("sanguessuga");
    } else {
      Console.WriteLine("minhoca");
    }
  }
}