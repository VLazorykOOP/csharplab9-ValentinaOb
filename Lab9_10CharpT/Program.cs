using System;
using System.Collections;


// See https://aka.ms/new-console-template for more information

namespace Pr{
  class Program
  {
static void Main(string[] args){
      Console.WriteLine("\nLab 8");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { one();  break;}
    case 2: { two();  break;}
    case 3: { three();  break;}
    case 4: { four();  break;}
  }


static void one(){

string file = File.ReadAllText("1.txt");

Stack st = new Stack();
 
 for(int i = 0;i<4;i++){
    int n = Convert.ToInt32(Console.ReadLine());
    st.Push(n);
 }   


Console.WriteLine("Stack: ");
foreach(var elem in st)
        {
            Console.WriteLine(elem);
        }

Console.WriteLine("Result: ");


Console.WriteLine("\n");

}
}
static void two(){
    var people = new Queue<string[]>();
    int[] years= new int[3];
    int[] years1= new int[3];
    List<int> years2= new List<int>();

    string file = File.ReadAllText("2.txt");
    string[] str=file.Split("\n");
    

    people.Enqueue(str);
    
    Console.WriteLine("People: ");
    foreach(var j in people ){
        for(int i = 0;i<3;i++){
        Console.WriteLine(j[i]);}
    }
    

    for(int i = 0;i<3;i++){
        string[] s =people.Peek();
        string[] st=str[i].Split(",");
        years[i]=int.Parse(st[3]);
    }


    for(int i = 0;i<3;i++){
        if(years[i] < 30){
            years2.Add(i);
        }
    }

    for(int i = 0;i<3;i++){
        if(years[i] >= 30){
            years2.Add(i);
        }
    }

    Console.WriteLine("Result: ");

int k=0;

foreach(var j in people )
foreach(int m in years2 ){
    for(int i = 0;i<3;i++){
        if(k==m){
            Console.WriteLine(j[i]);   
        }
        k++;
    }
    k=0;
    }
    
    
    
}

static void three(){
    
Console.WriteLine("\n");

}

static void four(){

    
Console.WriteLine("N: ");
 int n = Convert.ToInt32(Console.ReadLine());
double[] numb=new double[n];

}



}}