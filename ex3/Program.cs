double[] arr = new double[5];
for (int i = 0; i < arr.Length; i++)
{   
    double a = new Random().NextDouble()*(10.0 - 1.0)*1.0;
    arr[i] = a;
    string astr = arr[i].ToString("F2");
    System.Console.WriteLine(astr);
}
double max = 0;
double min = 0;
for (int i = 1; i < arr.Length; i++)
{
   if(arr[i] > arr[i-1]){
    max = arr[i];
   }
}
System.Console.WriteLine("MAX: "+max.ToString("F2"));

for (int i = 1; i < arr.Length; i++)
{
   if(arr[i] < arr[i-1]){
    min = arr[i];
   }
}
System.Console.WriteLine("MIN: "+min.ToString("F2"));
double raz = max-min;
System.Console.WriteLine("Разница: "+ raz.ToString("F2"));