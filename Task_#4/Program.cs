/*
Решение задачи нахождения Факториала числа N
*/
double Factorial (int n) // также решается через int
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++) // при использовании int - программа начинает выдавать отрицательные числа, это не правильно. Зато double с этим справляется
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//Console.WriteLine(Factorial(5)); // 1*2*3 = 6