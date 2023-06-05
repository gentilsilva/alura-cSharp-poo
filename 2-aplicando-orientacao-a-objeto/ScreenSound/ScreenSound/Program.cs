Musica musicaUm = new Musica();
musicaUm.Nome = "Roxane";
musicaUm.Artista = "The Police";
musicaUm.Duracao = 273;
musicaUm.Disponivel = true;
Console.WriteLine(musicaUm.DescricaoResumida);

Musica musicaDois = new Musica();
musicaDois.Nome = "Vertigo";
musicaDois.Artista = "U2";
musicaDois.Duracao = 367;
musicaDois.Disponivel = false;

musicaUm.ExibirFichaTecnica();
musicaDois.ExibirFichaTecnica();