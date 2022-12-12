void myArray(string [] arr)
{
    //string[] array = new string[arr.Length];
    string[] myArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=3) 
        {
            myArray[i] = arr[i];
        }
    Console.WriteLine(myArray[i]);  
    }

}

string [] inputArray = {"123","Heelo","456","abc","weddings"};

myArray(inputArray);


