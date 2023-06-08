Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


void TestaArrayInt()
{
    float media = 0;
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");
    
    for(int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"Índice = [{i}] = {idades[i]}");
        media += idades[i];
    }

    media = media / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}
//TestaArrayInt();

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    string palavraBuscada;

    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}º palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    palavraBuscada = Console.ReadLine();

    foreach(string palavra in arrayDePalavras)
    {
        if(palavra.Equals(palavraBuscada))
        {
            Console.WriteLine($"Palavra encontrada = {palavraBuscada}.");
            break;
        }
    }
}
//TestaBuscarPalavra();

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

void TestaMediana(Array array)
{
    if(array == null || array.Length == 0) Console.WriteLine("Array para cálculo de mediana está vazio ou nulo.");

    double[] numerosOrdenados = (double[]) array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanhoArray = numerosOrdenados.Length;
    int meio = tamanhoArray / 2;
    double mediana = (tamanhoArray % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}
TestaMediana(amostra);