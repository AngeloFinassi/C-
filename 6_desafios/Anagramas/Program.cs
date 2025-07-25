static bool IsPalindrome(string word1, string word2)
{
    //verificar se é string
    //if verificar, se for vazia, se não for string: return false
    if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
    {
        return false;
    }

    string w1_invt = "";

    //normlizar, tolower, rodar um loop inverso para salvar word1 ao contrario
    string w1 = word1.ToLower().Trim();
    string w2 = word2.ToLower().Trim();

    //cria w1 invertida
    for (int i = w1.Length - 1; i >= 0; i--)
    {
        w1_invt += w1[i];
    }

    //se contador = len word2 ent é igual, return true 
    return w1_invt == w2;
}

Console.WriteLine(IsPalindrome("amor", "roma"));
Console.WriteLine(IsPalindrome("abc", "cba"));
Console.WriteLine(IsPalindrome("123", "321"));
Console.WriteLine(IsPalindrome("124", "321"));
Console.WriteLine(IsPalindrome("", ""));
