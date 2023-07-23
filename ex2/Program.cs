int[] arr = new int[10];
int sum = 0;
for(int i = 0; i < arr.Length; i++){
    arr[i] = new Random().Next(-10, 11);
    System.Console.Write("["+arr[i]+"]"+" ");
}
System.Console.WriteLine();
for(int i = 1; i < arr.Length; i+=2){
    sum = sum + arr[i];
}
System.Console.WriteLine(sum);