namespace CIT_195_Lesson_3_FunWithMusic
{
    internal class Program
    {
        enum Genre
        {
            ClassicRock,
            ProgRock,
            PunkRock,
            Jazz,
            Classical
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            /* public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            } */

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album) { 
                Album = album; 
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title = " + Title + "\nArtist = " + Artist + "\nAlbum = " + Album + "\nLength = " + Length + "\nGenre = " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs will you be entering? ");
            int numSongs = int.Parse(Console.ReadLine());
            Music[] collection = new Music[numSongs];

            try
            {
                for (int i = 0; i < numSongs; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Name the song title: ");
                    string tempTitle = Console.ReadLine();
                    collection[i].setTitle(tempTitle);
                    Console.WriteLine("Name the artist: ");
                    string tempArtist = Console.ReadLine();
                    collection[i].setArtist(tempArtist);
                    Console.WriteLine("Name the album the song comes from: ");
                    string tempAlbum = Console.ReadLine();
                    collection[i].setAlbum(tempAlbum);
                    Console.WriteLine("How long is the song? mm:ss");
                    string tempLength = Console.ReadLine();
                    collection[i].setLength(tempLength);
                    Console.WriteLine("R = Classic Rock\nG = Prog Rock\nU = Punk Rock\nJ = Jazz\nL = Classical");
                    Genre tempGenre = Genre.ClassicRock;
                    char s = char.Parse(Console.ReadLine());

                    switch (s)
                    {
                        case 'R':
                            tempGenre = Genre.ClassicRock;
                            break;
                        case 'G':
                            tempGenre = Genre.ProgRock;
                            break;
                        case 'U':
                            tempGenre = Genre.PunkRock;
                            break;
                        case 'J':
                            tempGenre = Genre.Jazz;
                            break;
                        case 'L':
                            tempGenre = Genre.Classical;
                            break;
                    }
                    collection[i].setGenre(tempGenre);
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int x = 0; x < numSongs; x++)
                    Console.WriteLine($"{collection[x].Display()}");
            }
        }
    }
}
