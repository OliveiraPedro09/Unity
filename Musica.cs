class Music{
    public string name = string.Empty;
    public string artist = string.Empty;
    public string album = string.Empty;
    public string genre = string.Empty;
    public int duration;
    public bool availability;

    public void ShowMusic(){
        Console.WriteLine("Nome: " + name);
        Console.WriteLine("Artista: " + artist);
        Console.WriteLine("Album: " + album);
        Console.WriteLine("Genero: " + genre);
        Console.WriteLine("Duracao: " + duration);
        Console.WriteLine("Disponibilidade: " + availability);
        if (availability){
            Console.WriteLine("Disponivel");
        } else {
            Console.WriteLine("Indisponivel, adquira o plano Premium");
        }
    }
}