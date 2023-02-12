string[] GetArrayOfStringLessOfThreeChar(string[] arrayOfString)
{
    int arrayLength = arrayOfString.Length;
    int counter = 0;
    int numbOfElementsLessThreeChars = 0;
    while (counter < arrayLength)
    {
        if (arrayOfString[counter].Length <= 3) numbOfElementsLessThreeChars++;
        counter++;
    }

    string[] arrayReturn = new string[numbOfElementsLessThreeChars];

    if (numbOfElementsLessThreeChars > 0)
    {
        counter = 0;
        int counterArRet = 0;
        while (counter < arrayLength)
        {
            if (arrayOfString[counter].Length <= 3)
            {
                arrayReturn[counterArRet] = arrayOfString[counter];
                counterArRet++;
            };
            counter++;
        }
    }

    return arrayReturn;
}

void Write2DArrayOfString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + "\t");
    }

    Console.WriteLine();
}


string[] array = {"Понедельник", "пн.", "вторник", "Вт", "срд"};
string[] arrayElementsLessThanThreeChar = GetArrayOfStringLessOfThreeChar(array);
Console.WriteLine("Initial array:");
Write2DArrayOfString(array);
Console.WriteLine("An array of strings of the original array whose length is less than 3 characters:");
Write2DArrayOfString(arrayElementsLessThanThreeChar);

