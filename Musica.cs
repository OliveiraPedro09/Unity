class Music{
    public string Name {get; set;} = string.Empty;
    public string Artist {get; set;} = string.Empty;
    public string Album {get; set;} = string.Empty;
    public string Genre {get; set;} = string.Empty;
    public int Duration {get; set;}
    public bool Availability {get; set;}
    public string Description => $"A música {Name} é do artista {Artist} e está disponível no álbum {Album}.";

    public void ShowMusic(){
        Console.WriteLine("Nome: " + Name);
        Console.WriteLine("Artista: " + Artist);
        Console.WriteLine("Album: " + Album);
        Console.WriteLine("Genero: " + Genre);
        Console.WriteLine("Duracao: " + Duration);
        if (Availability){
            Console.WriteLine("Disponivel");
        } else {
            Console.WriteLine("Indisponivel, adquira o plano Premium");
        }
        Console.WriteLine(Description);
    }
}