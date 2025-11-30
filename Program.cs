/* 

int CountElements(string[] inputArray, string element){}
   Gitt en array med strenger og elementet som skal telles,
   itererer over listen og returner antall ganger elementet dukker opp i listen */

 
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

/*
Returner gjennomsnittet av de to midterste verdiene ved partall. */



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