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
    case 31: { three1();  break;}
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
 
Console.WriteLine("\nResult: ");
 
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

    Console.WriteLine("\nResult: ");

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

    Console.WriteLine("\nResult: ");


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
    


Console.WriteLine("A: ");

    a.GetEnumerator().MoveNext();
    IEnumerator r = a.GetEnumerator();
        while (r.MoveNext())
        {
            Object obj = r.Current;
            Console.WriteLine(obj);
        }
    
    a1.GetEnumerator().MoveNext();
    IEnumerator r1 = a1.GetEnumerator();
        while (r1.MoveNext())
        {
            Object obj = r1.Current;
            Console.WriteLine(obj);
        }


    th tt = new th();
    th t1=(th)tt.Clone();
    tt.CompareTo(t1);

Console.WriteLine("\n");

}

public class th : IEnumerable, IComparable, ICloneable{
    public ArrayList st;
    public ArrayList st1;
    public int pos=-1;

    public th()
        {
            st = new ArrayList();
            st1 = new ArrayList();
        }
    public IEnumerator GetEnumerator()
    {
        return (IEnumerator)st;
    }
    public bool MoveNext()
    {
        if (pos < st.Count - 1)
        {
            ++pos;
            return true;
        }
        return false;
    }
    public void Reset()
    {
        pos = -1;
    }
    public object Current
    {
        get
        {
            return st[pos];
        }
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

static void three1(){

string file = File.ReadAllText("1.txt");

ArrayList st=new ArrayList();
ArrayList st1=new ArrayList();
ArrayList res=new ArrayList();


foreach (char i in file){
    if (char.IsDigit(i)){
        st.Add(i-'0');
    }

    else if (i == 'M' || i == 'm'){
        st1.Add(i);
    }
}

if(st1.Count > 0){
while (st.Count > 0){
    
    int n = (int)st[st.Count-1];
    st.RemoveAt(st.Count-1);
    int n1 = (int)st[st.Count-1];
    st.RemoveAt(st.Count-1);

    char m = (char)(st1[st1.Count-1]);
    st1.RemoveAt(st1.Count-1);

    if(m=='M'){
        res.Add(Math.Max(n, n1));
    }
    else{
        res.Add(Math.Min(n, n1));
    }
}
if (st.Count == 0){
    int n = (int)(res[0]);
    int n1 = (int)(res[1]);
    char m = (char)(st1[0]);
    st1.RemoveAt(st1.Count-1);

    if(m=='M'){
        res.Add(Math.Max(n, n1));
    }
    else{
        res.Add(Math.Min(n, n1));
    }
}
}
 Console.WriteLine("\nResult");
 res.GetEnumerator().MoveNext();
    th1 t = new th1();
    IEnumerator r = res.GetEnumerator();
        while (r.MoveNext())
        {
            Object obj = r.Current;
            Console.WriteLine(obj);
        }


Console.WriteLine("\n");
        
    th1 t1=(th1)t.Clone();
    t.CompareTo(res);

}

public class th1 : IEnumerable, IComparable, ICloneable{
    public ArrayList st;
    public ArrayList st1;
    public int pos = -1;

    public th1()
        {
            st = new ArrayList();
            st1 = new ArrayList();
        }
        
    public IEnumerator GetEnumerator()
    {
        return (IEnumerator)st;
    }
    public bool MoveNext()
    {
        if (pos < st.Count - 1)
        {
            ++pos;
            return true;
        }
        return false;
    }
    public void Reset()
    {
        pos = -1;
    }
    public object Current
    {
        get
        {
            return st[pos];
        }
    }


    public int CompareTo(object obj)
        {
            int s =st.Count;
            if(s!=0) {return s.CompareTo(st.Count);}
        else
            {
                throw new Exception("Error");
            }
        }

    public object Clone()
        {
            th1 t = new th1();
            return t;
        }
}

static void four(){

    Hashtable ht = new Hashtable();
    
    Console.WriteLine("N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    string[] cdname=new string[n];
    string[] songname=new string[n];
    string[] artistname=new string[n];
    
    cd c =new cd();
    song s =new song();

    for(int i = 0; i < n;i++){
        Console.WriteLine("Name of cd: ");
        cdname[i]=Console.ReadLine();
        c.add_disk(cdname[i]);

        Console.WriteLine("Name of song & artist : ");
        songname[i]=Console.ReadLine();
        artistname[i]=Console.ReadLine();
        
        s.add_song(songname[i],artistname[i]);
    }

    for(int i = 0; i < n;i++){
        ht.Add(artistname[i],songname[i]);
    }

    Console.WriteLine("\nCd: ");
    c.show();

    Console.WriteLine("\nSong: ");
    s.show();

    Console.WriteLine("Add cd: ");
    Console.WriteLine("Name of cd: ");    
    string name =Console.ReadLine();
    c.add_disk(name);

    Console.WriteLine("\nCd: ");
    c.show();

    Console.WriteLine("Add song: ");
    Console.WriteLine("Name of song & artist: ");    
    name =Console.ReadLine();
    string namea =Console.ReadLine();
    s.add_song(name,namea);

    Console.WriteLine("\nSong: ");
    s.show();

    Console.WriteLine("Delete cd: ");
    c.delite_disk();

    Console.WriteLine("Delete song: ");
    s.delite_song();

    Console.WriteLine("\nCd: ");
    c.show();
    Console.WriteLine("\nSong: ");
    s.show();

    Console.WriteLine("\nCatalog: ");
    c.show();
    s.show();

    Console.WriteLine("\nDisk: ");
    s.show();


    Console.WriteLine("\nSearch for artist: ");
    Console.WriteLine("\nArtist: ");
    namea =Console.ReadLine();
    Console.WriteLine(ht[namea]);
    
}

public class cd{
    //public string Name { get; set; }
    //public List<song> Songs { get; set; }
    List<string> disk=new List<string>();
    
    public void add_disk(string name){
        //Console.WriteLine("Name of Disk: ");
        //disk.Add(Console.ReadLine());
        disk.Add(name);
    }
   

    public void delite_disk(){
        Console.WriteLine("Delite ");
        disk.RemoveAt(disk.Count-1);
    }

    public void show(){
        foreach (string i in disk){
            Console.WriteLine(i);
        }
    }
 
/*
 public musician(string name)
        {
            Name = name;
            Songs = new List<song>();
        }
*/

}

public class song{
    List<string> songs=new List<string>();
    List<string> artist=new List<string>();
    
    public void add_song(string names,string namea){
        //Console.WriteLine("Name of Song: ");
        //songs.Add(Console.ReadLine());
        songs.Add(names);
        artist.Add(namea);
    }
   

    public void delite_song(){
        Console.WriteLine("Delite ");
        songs.RemoveAt(songs.Count-1);
        artist.RemoveAt(artist.Count-1);
    }

    public void show(){
        for (int i = 0;i<songs.Count;i++){
            Console.WriteLine(songs[i]+"  -  "+artist[i]);
        }
    }

    /*
    public string Name { get; set; }

        public song(string name)
        {
            Name = name;
        }

        public string show()
        {
            return Name;
        }
*/

    }






}}