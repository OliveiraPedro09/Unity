class Album(){
    public string Name {get; set;} = string.Empty;

    public int AlbumDuration => musics.Sum(music => music.Duration);
    
    private List<Music> musics = new List<Music>();

    public void MusicFind( Music music ){
        musics.Add(music);
    }

    public void ShowAlbum(){
        Console.WriteLine("Nome: " + Name);
        Console.WriteLine("Duração: " + AlbumDuration + " segundos");
        foreach (Music music in musics){
            music.ShowMusic();
        }
    }
}