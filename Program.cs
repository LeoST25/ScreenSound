Musica musica1 = new Musica();
musica1.nome = "Roxanne";
musica1.genero = "Rock";
musica1.artista = "The Police";
musica1.duracao = 187;
musica1.disponivel = true;


Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica1.genero = "Heavy Metal";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.disponivel = false;

musica1.ExibirFichaTecnica();
Console.WriteLine("\n");
musica2.ExibirFichaTecnica();
Console.WriteLine("\n");
musica1.ExibirNomeEArtista();
Console.WriteLine("\n");
musica2.ExibirNomeEArtista();