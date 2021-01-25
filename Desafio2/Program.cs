using System;

class Program {
  
  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhas];
    int[] figurinhasCompradas = new int[numeroDeFigurinhasCompradas];
    int i, count=0, aux;
    bool flag = false;

    for(i = 0; i < numeroDeFigurinhasCompradas; i++)
    {
        aux = Int32.Parse(Console.ReadLine());
        if(count > 0){            
            for(int j=0; j < count; j++){
                if(aux == figurinhasCompradas[j]){
                    flag = true;
                }
            }
            if(flag == false){
                figurinhasCompradas[count] = aux;
                count++;
            }
            
        }else{
            figurinhasCompradas[count] = aux;
            count++;
        }
        flag = false;
    }
    totalDeFigurinhas = numeroDeFigurinhas -count;
    if(totalDeFigurinhas < 0){
        totalDeFigurinhas = 0;
    }
    
    Console.WriteLine(totalDeFigurinhas);
  }

}