class Musica
{
    public string nome;
    public string genero;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {nome}");
        Console.WriteLine($"Genero: {genero}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        } else
        {
            Console.WriteLine("Adquirida o plano Plus+");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
        
    }
}
