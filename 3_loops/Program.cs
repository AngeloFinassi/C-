List<int> notas = new List<int> { 10, 5, 8, 3, 9, 7, 4, 6 };

//Exemplo 1: Pegar todas as notas aprovadas (>= 7)
//O jeito tradicional:
List<int> aprovados = new List<int>();
int sum = 0;

foreach (int nota in notas)
{
    if (nota >= 7)
    {
        aprovados.Add(nota*2);

    }
}

//transform the list to a unique string, selecting the elements by ", "
Console.WriteLine(string.Join(", ", aprovados));

//Sum abot the sum grades
for (int i = 0; i < aprovados.Count; i++)
{
    sum += aprovados[i];
}

Console.WriteLine(sum);

// WHILE
int contador = 3;
while (contador > 0)
{
    Console.WriteLine($"Contador regressivo: {contador}");
    contador--;
}

//O jeito com LINQ:
var aprovadosLinq = notas.Where(nota => nota >= 7).ToList();

//Exemplo 2: Dobrar o valor de cada nota
var notasDobro = notas.Select(nota => nota * 2).ToList();

//Exemplo 3: Achar a primeira nota acima de 8
int primeiraNotaAlta = notas.FirstOrDefault(nota => nota > 8); // 

//Exemplo 4: Somar todas as notas
int soma = notas.Sum();

//teria q usar joi em todos para passar lista, valores printaveis
// Console.WriteLine($"Aprovados:{aprovados}, DoubleAprov:{notasDobro},FirstHigherThan8:{primeiraNotaAlta}");

//Não gostei, mas pelo oq entendi é isso como funfa no C#
Console.WriteLine($"Aprovados: [{string.Join(", ", aprovadosLinq)}]");
Console.WriteLine($"Notas com dobro do valor: [{string.Join(", ", notasDobro)}]");
Console.WriteLine($"Primeira nota maior que 8: {primeiraNotaAlta}");
Console.WriteLine($"Soma de todas as notas: {soma}");
