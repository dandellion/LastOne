int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))

            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

string [] InitMatrix(int massiveLength)
{
    string [] matrix = new string [massiveLength];
    for (int i = 0; i < massiveLength; i++)
    {
        matrix[i] = Console.ReadLine();
        
    }
    return matrix;
}

void PrintMatrix(string[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         Console.Write($"{matrix[i]}  ");
             
    }
}

string [] CreateNewMassiveLess3 (string[] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         if (matrix[i].Length<=3)
         count++;
             
    }
    string [] newMatrix = new string [count];
    int j=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         if (matrix[i].Length<=3)
         {
            newMatrix[j]=matrix[i];
            j++;
         }
          
    }
    return newMatrix;
}

int massiveLength = GetNumber("Введите число элеместов массива");
string [] originalMassive = InitMatrix(massiveLength);
PrintMatrix(originalMassive);
Console.WriteLine();
string [] newMassive = CreateNewMassiveLess3(originalMassive);

PrintMatrix(newMassive);
