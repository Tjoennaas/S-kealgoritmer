/* 

int CountElements(string[] inputArray, string element){}
   Gitt en array med strenger og elementet som skal telles,
   itererer over listen og returner antall ganger elementet dukker opp i listen */

 /*
int CountElements(string[] inputArray, string element)
{
    int count = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] == element)
        {
            count++;
        }
    }

    return count;
}

string[] names = { "Lise", "Ole", "Lise", "Per" };

int antall = CountElements(names, "Lise");


//---------------------------------------//


int antallElementer(string[] inputArray, string element)
{
    

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] == element)
        {
            return i;
        }
    }

return -1; //vis elementet ikke finnes
}
string[] arr = { "A", "B", "C", "B" };

int resultat = antallElementer(arr, "B");

//---------------------------------------//
//---------------------------------------//




T FirstElement<T>(T[] inputArray)
{
    if (inputArray.Length == 0)
    {
      throw new InvalidOperationException();
    }
return inputArray[0];
}
    string[] navn2 = { "Lise", "Ole", "Per" };
       Console.WriteLine(FirstElement(navn2));


T LastElement<T>(T[] inputArray)
{
    if (inputArray.Length == 0)
    {
      throw new InvalidOperationException();
    }

   //return inputArray.Length - 1; -> returnerer tallet for siste index
   //-> returnerer selve elementet
    return inputArray[inputArray.Length-1]; 
}
   
       Console.WriteLine(LastElement(navn2));

       

T MidelElement<T>(T[] inputArray)
{
    if (inputArray.Length == 0)
    {
      throw new InvalidOperationException();
    }

return inputArray[inputArray.Length / 2];

   }
      Console.WriteLine(MidelElement(navn2));



  //---------------------------------------//


Returner gjennomsnittet av de to midterste verdiene ved partall. 



int GetMedian(int[] inputArray)
{

   int[] arr = (int[])inputArray;

    int length = arr.Length;
    int mid = length / 2;


    if (length % 2 != 0)
    {
        return arr[mid];
    }

    return (arr[mid - 1] + arr[mid]) / 2;
}
GetMedian(new int[] { 1, 3, 5 });       
GetMedian(new int[] { 1, 2, 3, 4 });


//---------------------------------------//
//---------------------------------------//





public class Node
{
    public string Data { get; private set; }
    public Node? Next { get; private set; }

    public Node(string data)
    {
        Data = data;
        Next = null;
    }

    public void SetNext(Node node)
    {
        Next = node;
    }

    public override string ToString()
    {
        return Data;
    }


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tester Node-klassen...\n");

        var node = new Node("Hei");
        Console.WriteLine(node.Data == "Hei" ? "OK: Data settes riktig" : "FAIL");
        Console.WriteLine(node.Next == null ? "OK: Next er null" : "FAIL");

        var first = new Node("første");
        var second = new Node("andre");
        first.SetNext(second);

        Console.WriteLine(first.Next == second
            ? "OK: SetNext fungerer"
            : "FAIL");

        
        Console.WriteLine(first.ToString() == "første"
            ? "OK: ToString returnerer Data"
            : "FAIL");

        Console.WriteLine("\nFerdig!");

    }}}


*/




using System;
using System.Collections.Generic;

public class Node
{
    public string Data { get; private set; }//Teksten som noden lagrer
    public Node? Next { get; private set; } //Node kan være null, ingen nexr videre



//Konstruktør som lagrer data next peker ikke på noen ny node enda
//a.SetNext(b);  // a.Next peker nå på b
    public Node(string data)
    {
        Data = data;
        Next = null;
    }

//Peker på ny node.
    public void SetNext(Node node)
    {
        Next = node;
    }
    
    //Skive ut data.
        public override string ToString()
    {
        return Data;
    }
}

public class LinkedList
{

//Head: Første noden i lista
    public Node? Head { get; private set; }

    public LinkedList()
    {
        Head = null;
    }

//Dersom listen er tom, så vil den første noden bli head
    public void AddToTail(Node node)
    {
        if (Head == null)
        {
            Head = node;
            return;
        }

// Når curent.Next ikke er null, så plaseres noden sist i listen
        var current = Head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.SetNext(node);
    }


//Den nye noden skal plaseres på starten altså være den nye head
    public void AddToHead(Node node)
    {
        node.SetNext(Head);
        Head = node;
    }

    public override string ToString()
    {
        var nodes = new List<string>();
        var curr = Head;
        while (curr is not null)
        {
            nodes.Add(curr.Data);
            curr = curr.Next;
        }
        return string.Join(" -> ", nodes);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var list = new LinkedList();

        list.AddToTail(new Node("A"));
        list.AddToTail(new Node("B"));
        list.AddToTail(new Node("C"));

        Console.WriteLine(list);   

        list.AddToHead(new Node("Start"));

        Console.WriteLine(list);   
    }
}
