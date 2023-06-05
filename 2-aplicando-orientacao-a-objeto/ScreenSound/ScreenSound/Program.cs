Banda johnMayer = new Banda("John Mayer");

Album albumJohnMayer = new Album("Continuum");

Musica musicaUm = new Musica(johnMayer, "Gravity")
{
    Duracao = 245,
    Disponivel = true,
};

Musica musicaDois = new Musica(johnMayer, "Daughters")
{
    Duracao = 238,
    Disponivel = false,
};

albumJohnMayer.AdicionarMusica(musicaUm);
albumJohnMayer.AdicionarMusica(musicaDois);
johnMayer.AdicionarAlbum(albumJohnMayer);

musicaUm.ExibirFichaTecnica();
musicaDois.ExibirFichaTecnica();
albumJohnMayer.ExibirMusicasDoAlbum();
johnMayer.ExibirDiscografia();