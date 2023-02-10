using System;

namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Rock,
            Pop,
            HipHop,
            Jazz,
            Country
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title = title;
            }

            public void setLength(string length)
            {
                Length = length;
            }

            public string display()
            {
                return $"Title: {Title} \nArtist: {Artist} \nLength: {Length} \nAlbum: {Album} \nGenre: {Genre}";
            }
        }

        static void Main(string[] args)
        {
            string tempTitle;
            string tempArtist;
            string tempAlbum;
            string tempLength;
            Genre tempGenre;

            Console.WriteLine("What is the title of your favorite song?");
            tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            tempArtist = Console.ReadLine();
            Console.WriteLine("What is the name of the album?");
            tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("R - Rock \nP - Pop \nH - Hip Hop \nJ - Jazz \nC - Country");
            char genre = char.Parse(Console.ReadLine().ToUpper());

            switch (genre)
            {
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                default:
                    tempGenre = Genre.Pop;
                    break;
            }


            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine(music.display() + "\n");
            Music moreMusic = music;
            Console.WriteLine("What is the next song on the album?");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("What is the length of the song?");
            moreMusic.setLength(Console.ReadLine());
            Console.WriteLine(moreMusic.display());
        }
    }
}