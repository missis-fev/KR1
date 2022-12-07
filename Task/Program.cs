//Программа, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам.  
// Первоначальный массив задан на старте выполнения алгоритма.

string[] array = new string[] { "Hello", "2", "world", ":-" }; 
string[] result = ArrayLess(array, 3);

string[] ArrayLess(string[] input, int n) {
    string[] output = new string[Count(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int Count(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
