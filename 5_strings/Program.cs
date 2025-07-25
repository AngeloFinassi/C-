string frase = "  O Rato roeu a roupa do Rei de Roma  ";

string s1 = frase.Trim();                   // "O Rato roeu a roupa do Rei de Roma" (remove espaços no início e fim)
string s2 = frase.ToLower();                // "  o rato roeu a roupa do rei de roma  "
string s3 = frase.ToUpper();                // "  O RATO ROEU A ROUPA DO REI DE ROMA  "
bool s4 = frase.Contains("Rei");            // true
string s5 = s1.Substring(7, 4);             // "roeu" (começa no índice 7, pega 4 caracteres)
string[] palavras = s1.Split(' ');          // Divide a string em um array de strings usando o espaço
                                            // Resultado: ["O", "Rato", "roeu", ...]

// Verificar se é nula ou vazia (MUITO IMPORTANTE)
string vazia = "";
string nula = null;
if (string.IsNullOrEmpty(vazia))
{
    Console.WriteLine("A string 'vazia' é nula ou vazia.");
}
