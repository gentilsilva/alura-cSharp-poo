Album johnMayer = new Album();
johnMayer.Nome = "Continuum";

Musica musicaUm = new Musica();
musicaUm.Nome = "Gravity";
musicaUm.Duracao = 245;

Musica musicaDois = new Musica();
musicaDois.Nome = "Daughters";
musicaDois.Duracao = 238;

johnMayer.AdicionarMusica(musicaUm);
johnMayer.AdicionarMusica(musicaDois);

johnMayer.ExibirMusicasDoAlbum();