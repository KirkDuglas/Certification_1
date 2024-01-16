// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = { "123", "15678", "-21", "com", "p", "user", "BI"};
string[] GetShortArray(string[] array)
 {
    int count = 0; //количество элементов в массиве длина которых <=3. (далее этот параметр буду использовать как размер нового массива)
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }
        string[] resultArray = new string[count]; // инициализация массива размер = количество элементов длиной <=3 из первоначального массива 
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                resultArray[index] = array[i];
                index++;
            }
        }

        return resultArray;
 }
string[] result = GetShortArray(array);
Console.WriteLine ($"Массив после: [ {string.Join("; ",result)}]");