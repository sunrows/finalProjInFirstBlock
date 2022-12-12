void myArray(string[] arr)
{
    //string[] array = new string[arr.Length];
    string[] myArray = new string[arr.Length];
    Console.Write("myArray = [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            myArray[i] = arr[i];
            //Console.Write(string.Join(", ", (myArray[i]))); - Это почему то не работает!
            Console.Write(myArray[i] + " ");
        }
    }
    Console.Write("]");
}

string[] inputArray = { "123", "Heelo", "456", "abc", "weddings" };

myArray(inputArray);


