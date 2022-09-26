float sum = 1;
float num = int.Parse(Console.ReadLine());
float x = num;
float i = 1;
float fact = 1;
float degree = 1;
float e = flo
float degreeE = 1;
while (sum <= Math.Pow(Math.E, num))
{
    Console.WriteLine(fact * i);
    degree = degree * x;
    fact = fact * i;
    sum += (degree / fact);
    i++;
}

Console.WriteLine(sum);

//int i = 1;
//int x = int.Parse(Console.ReadLine());
//int fact = 1;
//while (fact < 64)
//{
//    fact = fact * x;
//}