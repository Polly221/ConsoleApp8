Random random = new Random();
int[] arr1 = new int[2];
int[] arr2 = new int[2];
int[] arr3 = new int[2];
int[] arr4 = new int[2];
double temp1 = 0;
double temp2 = 0;
double temp3 = 0;
double temp4 = 0;
double temp5 = 0;
double temp6 = 0;
double temp7 = 0;
double temp8 = 0;
Console.Write("1 массив = ");
for (int i = 0; i < 2; i++)
{

    arr1[i] = random.Next(1, 10);
    temp1 = arr1[0];
    temp2 = arr1[1];

}

Console.Write(string.Join(", ", arr1));
Console.Write("\n2 массив = ");
for (int i = 0; i < 2; i++)
{
    arr2[i] = random.Next(1, 10);
    temp3 = arr2[0];
    temp4 = arr2[1];

}
Console.WriteLine(string.Join(", ", arr2));
var average1 = arr1.Average();
var average2 = arr2.Average();

Console.WriteLine($"\ncр. ариф. 1 и 2 массивов = {((temp1 + temp3) / 2)} , {((temp2 + temp4)/2)}");
Console.WriteLine();
Console.Write("3 массив = ");
for (int i = 0; i < 2; i++)
{

    arr3[i] = random.Next(1, 10);
    temp5 = arr3[0];
    temp6 = arr3[1];

}

Console.Write(string.Join(", ", arr3));
Console.Write("\n4 массив = ");
for (int i = 0; i < 2; i++)
{
    arr4[i] = random.Next(1, 10);
    temp7 = arr4[0];
    temp8 = arr4[1];

}
Console.WriteLine(string.Join(", ", arr4));
var average3 = arr1.Average();
var average4 = arr2.Average();

Console.WriteLine($"\ncр. ариф. 3 и 4 массивов = {((temp5 + temp7) / 2)} , {((temp6 + temp8) / 2)}");
Console.WriteLine();
Console.Write("Произведение ср.арифметических: ");
Console.Write($"\ncр. ариф. 1 и 2 массивов = {((temp1 + temp3) / 2)} , {((temp2 + temp4) / 2)}");
Console.WriteLine($"\ncр. ариф. 3 и 4 массивов = {((temp5 + temp7) / 2)} , {((temp6 + temp8) / 2)}");
Console.WriteLine();
Console.WriteLine($"Произведение = { (((temp1 + temp3) / 2)*((temp5 + temp7) / 2))} , {((temp2 + temp4) / 2)*((temp6 + temp8) / 2)}");