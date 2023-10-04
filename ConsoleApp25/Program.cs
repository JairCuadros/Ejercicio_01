Console.WriteLine("Ingrese el valor de n: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("==================================");
double resultadoF = 0;
for (int i = 1; i <= n; i++)
{
    double suma = (16 - i) / (3.0 * i);
    resultadoF += (16.0 - i) / (3 * i);
    Console.WriteLine($"resultado {i} : {suma}");
}
Console.WriteLine("==================================");
Console.WriteLine($"Resultado final: {resultadoF}");