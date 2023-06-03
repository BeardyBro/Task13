Console.WriteLine("Let`s find third digit");
Console.WriteLine("Insert number");
int num = Convert.ToInt32(Console.ReadLine());
if (num<100)
{
    Console.WriteLine("Third digit doesn`t exist");
}
else if (num==100 || num==1000 || num==10000 || num==100000 || num==1000000 || num==10000000)
Console.Write(0);
else if (num>100 && num<1000)
{
    Console.WriteLine(num%10);
}
else if (num>1000 && num<10000)
Console.Write((num/10)%10);
else if (num>10000 && num<100000)
Console.Write((num/100)%10);
else if (num>100000 && num<1000000)
Console.Write((num/1000)%10);
else if (num>1000000 && num<10000000)
Console.Write((num/10000)%10);