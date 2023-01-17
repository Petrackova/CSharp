//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа]
int num =  new Random().Next(100,1000);
Console.WriteLine(num);
int firssNum = ((num/100)*10)+(num%10);
Console.WriteLine(firssNum);

