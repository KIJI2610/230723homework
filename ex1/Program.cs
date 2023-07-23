System.Console.WriteLine("Весь массив: ");
int[] arr = new int[10];
int count = 0;
for(int i = 0; i < arr.Length; i++){
    arr[i] = new Random().Next(100, 1000);
    System.Console.Write("["+arr[i]+"]"+" ");
}
System.Console.WriteLine();
System.Console.WriteLine("Четные значения:");
for(int i = 0; i < arr.Length; i++){
    if(arr[i]%2 == 0){
        System.Console.Write("["+arr[i]+"]"+" ");
        count++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Количество четных значений: "+count);