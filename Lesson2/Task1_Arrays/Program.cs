//Создание массива и просто выдление для него памяти.
int[] arr = new int[5];
//Дальнейшее заполнение массива вручную
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

//Console.WriteLine(arr[5]);

//Создание массива, выделение для него памяти и тут же заполнение массива значениями
int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

//Автоматическое создание и выделение памяти для массива
int[] arr3 = { 1, 2, 3, 4, 5 };