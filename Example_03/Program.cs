// Упорядочить массив от мин до макс
/* Алгоритм сортировки метода выбора */

int[] arr = { 1, 4, 7, 8, 9, 4, 6, 8, 3 };

void PrintArray(int[] array){
    int count = array.Length;
    for(int i = 0; i < count; i++){
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

void Selection(int[] array){
    for(int i = 0; i < array.Length - 1; i++){
        int minPosition = i;  
        for(int j = i + 1; j < array.Length; j++){
            if(array[j] < array[minPosition]){
               array[i] = minPosition;
            }
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
Selection(arr);
PrintArray(arr);