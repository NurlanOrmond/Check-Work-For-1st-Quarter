

String [] GetWords ()
{
   String [] text = new String [4]; 
    System.Console.WriteLine("\n\nInput 4 Words:");
    for (int i = 0; i < text.Length; i++)
    {
        text [i] = Console.ReadLine();
    }
    return text;

}

String [] ResultArray (String [] array)
{
    String [] resultArray = new String [4];
    for (int i = 0, j =0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            resultArray[j] = array [i];
            j++;    

        }
    }
    return resultArray;
}

void PrintArray (String [] array)
{
    System.Console.Write("\nHere are words containing 3 symbols: ");
    
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine("\n\n");
}

PrintArray (ResultArray(
            GetWords()
            ));





