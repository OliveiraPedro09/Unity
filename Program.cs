Album album = new Album();

album.Name = "The Dark Side of the Moon";

Music music1 = new Music();
music1.Name = "Speak to Me";
music1.Artist = "Pink Floyd";
music1.Duration = 105;

Music music2 = new Music();
music2.Name = "Breathe";
music2.Artist = "Pink Floyd";
music2.Duration = 249;

album.MusicFind(music1);
album.MusicFind(music2);

album.ShowAlbum();