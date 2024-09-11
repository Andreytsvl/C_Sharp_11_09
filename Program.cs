
// int [,] matrix = new int[3,5]; 
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = rnd.Next(1,1000);
//         Console.Write($"{matrix[i,j]} ");

//         // matrix[i,j] = rnd.Next(1,11);
//     }
//     Console.WriteLine();
// }

// string str = "Hello";
// Console.Write(str[0]);


string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

