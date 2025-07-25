// LISTA (Array dinâmico) - use isso na maioria das vezes!
// Precisa de 'using System.Collections.Generic;'
List<string> frutas = new List<string>();
frutas.Add("Maçã");
frutas.Add("Banana");
frutas.Add("Laranja");

Console.WriteLine($"Primeira fruta: {frutas[0]}");
Console.WriteLine($"Temos {frutas.Count} frutas.");

// DICIONÁRIO (Chave-Valor) - perfeito para contagens e lookups rápidos
Dictionary<string, int> pontuacoes = new Dictionary<string, int>();
pontuacoes["Jogador1"] = 100;
pontuacoes["Jogador2"] = 85;

if (pontuacoes.ContainsKey("Jogador1"))
{
    Console.WriteLine($"Pontuação do Jogador1: {pontuacoes["Jogador1"]}");
}

// ARRAY (Tamanho fixo)
int[] numeros = new int[3]; // cria um array de 3 posições, todas com valor 0
numeros[0] = 10;
numeros[1] = 20;

int[] outrosNumeros = { 11, 22, 33 }; // inicialização rápida
Console.WriteLine($"Tamanho do array: {outrosNumeros.Length}"); // .Length é o tamanho
