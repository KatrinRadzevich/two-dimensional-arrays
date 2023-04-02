int lenght = 4;
string[] array = new string[lenght];
Console.WriteLine("Введите 4 элемента первоначального массива.Каждый элемент вводится через ENTER: ");
array = FillArray(array);
// Делим массив от пользователя на 4 разных массива
string[] leftPartOrArray = GetLeftPartOfArray(array);
string[] rightPartOrArray = GetRightPartOfArray(array);
string[] firstElement = GetLeftPartOfArray(leftPartOrArray);
string[] secondElement = GetRightPartOfArray(leftPartOrArray);
string[] thirdElement = GetLeftPartOfArray(rightPartOrArray);
string[] fourthElement = GetRightPartOfArray(rightPartOrArray);
// Полученные массивы конвертим в строки
string first = string.Concat(firstElement);
string second = string.Concat(secondElement);
string third = string.Concat(thirdElement);
string fourth = string.Concat(fourthElement);
// Поиск размера результирующего массива и заполнение результирующего массива
// int lengthOfResultArray = GetSizeOfFinalArray(first, second, third, fourth);
// string[] resultArray = new string[lengthOfResultArray];
// resultArray = GetResultArray(resultArray, first, second, third, fourth);

string[] resultArray;
resultArray = GetResultArray(first, second, third, fourth);

Console.Write("[" + String.Join(", ", array) + "] -> [" + String.Join(",  ", resultArray) + "]");
// Метод заполнения массива от пользователя
string[] FillArray(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        someArray[i] = Console.ReadLine();
    }
    return someArray;
}
// Взятие левой части массива как отдельного нового массива
string[] GetLeftPartOfArray(string[] inArray)
{
    int mid = (inArray.Length + 1) / 2;
    string[] someArray = inArray[..mid];
    return someArray;
}
// Взятие правой части массива как отдельного нового массива
string[] GetRightPartOfArray(string[] inArray)
{
    int mid = (inArray.Length + 1) / 2;
    string[] someArray = inArray[mid..];
    return someArray;
}
// Метод на нахождение размерности результирующего массива и его заполнения
string[] GetResultArray(string first, string second, string third, string fourth)
{
    int size = 0;
    if (first.Length <= 3) size++;
    if (second.Length <= 3) size++;
    if (third.Length <= 3) size++;
    if (fourth.Length <= 3) size++;
    string[] resultArray = new string[size];
    int i = 0;
    while (i < resultArray.Length)
    {
        if (first.Length <= 3)
        {
            resultArray[i] = first;
            i++;
        }
        if (second.Length <= 3)
        {
            resultArray[i] = second;
            i++;
        }
        if (third.Length <= 3)
        {
            resultArray[i] = third;
            i++;
        }
        if (fourth.Length <= 3)
        {
            resultArray[i] = fourth;
            i++;
        }
    }
    return resultArray;
}
