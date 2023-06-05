class Musica
{
    public string? Nome { get; set; }
    public string? Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";   // Na maioria dos casos, em operações somente de leitura é feito por lambda (Funções anônimas)
    private Genero Genero { get; set; }

    // Essa é uma outra alternativa, mas pouco utilizada
    //{ 
    //    get
    //    {
    //        return $"A música {Nome} pertence à banda {Artista}";
    //    } 
    //}

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

}

