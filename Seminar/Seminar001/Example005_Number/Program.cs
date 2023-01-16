Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if ((number1> 100) && (number1<999))
{
    Console.WriteLine(number1%10);
}
else {
   Console.WriteLine("Число не трехзначное"); 
}