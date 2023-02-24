string[] words = new string[] {"hello", "2", "world", ":-)"};
int newArrayLenght = GetNewLen(words);
string[] newArray = GenerateNewArray(words, newArrayLenght);

PrintArray(words);
Console.Write(" -> ");
PrintArray(newArray);

int GetNewLen(string[] inputArray)
{
    int counter = 0;
    for(int i=0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length <= 3)
        {
            counter ++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] inputArray, int newLenght)
{
    string[] resultArray = new string[newLenght];
    int j = 0;
    for(int i=0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length <= 3)
        {
            resultArray[j] = inputArray[i];
            j++;
        }
    }
    return resultArray;
}

void PrintArray(string[] inputArray)
{
    string result = "";
    result += "[";
    for (int i = 0; i < inputArray.Length; i++)
    {
        result += inputArray[i];
        if(inputArray[i] != inputArray[inputArray.Length-1])
        {
            result += ",";
        }
    }
    result += "]";
    Console.Write(result);
}

