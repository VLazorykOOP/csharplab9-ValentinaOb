using System;
using System.Collections;
using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


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

}
static void one(){

string file = File.ReadAllText("1.txt");

Stack<int> st = new Stack<int>();
Stack<char> st1 = new Stack<char>();
Stack<int> res = new Stack<int>();


foreach (char i in file){
    if (char.IsDigit(i)){
        st.Push(i-'0');
    }

    else if (i == 'M' || i == 'm'){
        st1.Push(i);
    }
}

if(st1.Count > 0){
while (st.Count > 0){
    int n = st.Pop();
    int n1 = st.Pop();
    char m = st1.Pop();

    if(m=='M'){
        res.Push(Math.Max(n, n1));
    }
    else{
        res.Push(Math.Min(n, n1));
    }
}
if (st.Count == 0){
    int n = res.ElementAt(0);
    int n1 = res.ElementAt(1);
    char m = st1.Pop();

    if(m=='M'){
        res.Push(Math.Max(n, n1));
    }
    else{
        res.Push(Math.Min(n, n1));
    }
}
}
 
 foreach (int i in res){
    Console.WriteLine(i);
 }

Console.WriteLine("\n");

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

    string file = File.ReadAllText("2.txt");
    string[] str=file.Split("\n");
    
    int[] years= new int[3];
    string[]s1=str[0].Split(",");
    string[]s2=str[1].Split(",");
    string[]s3=str[2].Split(",");
    List<int> years2= new List<int>();

    ArrayList a = new ArrayList();
    ArrayList a1 = new ArrayList();

    
    Console.WriteLine("People: ");
    foreach(string i in str ){
        Console.WriteLine(i);
    }

    for(int i = 0;i<3;i++){
        string s =str[i].ToString();
        string[] st=str[i].Split(",");
        years[i]=int.Parse(st[3]);
    }

    for(int i = 0;i<3;i++){
        if(years[i] < 30){
            a.Add(i);
        }
    }

    for(int i = 0;i<3;i++){
        if(years[i] >= 30){
            a1.Add(i);
        }
    }

    Console.WriteLine("Result: ");

int k=0;



foreach(int m in a ){
    foreach(var j in str ){
        if(k==m){
            Console.WriteLine(j);   
        }
        k++;
    }
    k=0;
    }    

    foreach(int m in a1 ){
    foreach(var j in str ){
        if(k==m){
            Console.WriteLine(j);   
        }
        k++;
    }
    k=0;
    }    


/*
    a.GetEnumerator().MoveNext();
    th t = new th();
    t.GetEnumerator();
    th t1=(th)t.Clone();
    t.GetEnumerator();
    t.CompareTo(t1);

*/

Console.WriteLine("\n");

}

public class th : IEnumerable, IComparable, ICloneable{
    public ArrayList st;
    public ArrayList st1;

    public th()
        {
            st = new ArrayList();
            st1 = new ArrayList();
        }
    public IEnumerator GetEnumerator()
        {
            return st.GetEnumerator();
        }

    public int CompareTo(object obj)
        {
            int s =st.Count;
            if(s!=0) {return s.CompareTo(st.Count);}
        else{
                throw new ArgumentException("Error");
            }
        }

    public object Clone()
        {
            th t = new th();
            return t;
        }
}

static void four(){

    
Console.WriteLine("N: ");
 int n = Convert.ToInt32(Console.ReadLine());
double[] numb=new double[n];

}

public class musician{
    List<string> disk = new List<string>();
    
    
    public void add_disk(){
        Console.WriteLine("Name of Disk: ");
        disk.Add(Console.ReadLine());
    }

    public void delite_disk(){
        Console.WriteLine("Delite ");
        disk.RemoveAt(-1);
    }

    public void show(){
        foreach (string i in disk){
            Console.WriteLine(i);
        }
    }


}


}}