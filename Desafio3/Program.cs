using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  palavra1; //declare as suas variaveis
        String  palavra2;
        String  palavra3;

        palavra1 = Console.ReadLine(); //insira suas variaveis
        palavra2 = Console.ReadLine();
        palavra3 = Console.ReadLine();

      if ((palavra1 == "vertebrado") && (palavra2 == "ave")  && (palavra3 == "carnivoro")) {
        Console.WriteLine("aguia");
    }

     if ((palavra1 == "vertebrado") && (palavra2 == "ave")  && (palavra3 == "onivoro")) {
        Console.WriteLine("pomba");
    }

     if ((palavra1 == "vertebrado") && (palavra2 == "mamifero")  && (palavra3 == "onivoro")) {
        Console.WriteLine("homem");
    }

     if ((palavra1 == "vertebrado") && (palavra2 == "mamifero")  && (palavra3 == "herbivoro")) {
        Console.WriteLine("vaca");
    }

     if ((palavra1 == "invertebrado") && (palavra2 == "inseto")  && (palavra3 == "hematofago")) {
        Console.WriteLine("pulga");
    }

     if ((palavra1 == "invertebrado") && (palavra2 == "inseto")  && (palavra3 == "herbivoro")) {
        Console.WriteLine("lagarta");
    }

     if ((palavra1 == "invertebrado") && (palavra2 == "anelideo")  && (palavra3 == "hematofago")) {
        Console.WriteLine("sanguessuga");
    }

     if ((palavra1 == "invertebrado") && (palavra2 == "anelideo")  && (palavra3 == "onivoro")) {
        Console.WriteLine("minhoca");
    }

     


  }
}