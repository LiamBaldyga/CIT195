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

            /*
            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            */


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

            public void setAlbum(string album)
            {
                Album = album;
            }

            public void setGenre(Genre genre)
            {
                Genre = genre;
            }

            public string display()
            {
                return $"Title: {Title} \nArtist: {Artist} \nLength: {Length} \nAlbum: {Album} \nGenre: {Genre}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int numSongs = int.Parse(Console.ReadLine());

            Music[] musicArray = new Music[numSongs];

            try
            {
                for (int i = 0; i < numSongs; i++)
                {
                    Console.WriteLine($"---------- Song {i+1} ----------");
                    
                    Console.WriteLine("What is the song title?");
                    musicArray[i].setTitle(Console.ReadLine());

                    Console.WriteLine("What is the artist?");
                    musicArray[i].setArtist(Console.ReadLine());

                    Console.WriteLine("What is the album?");
                    musicArray[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("What is the length of the song?");
                    musicArray[i].setLength(Console.ReadLine());

                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("R - Rock \nP - Pop \nH - Hip Hop \nJ - Jazz \nC - Country");
                    char genre = char.Parse(Console.ReadLine().ToUpper());

                    switch (genre)
                    {
                        case 'R':
                            musicArray[i].setGenre(Genre.Rock);
                            break;
                        case 'P':
                            musicArray[i].setGenre(Genre.Pop);
                            break;
                        case 'H':
                            musicArray[i].setGenre(Genre.HipHop);
                            break;
                        case 'J':
                            musicArray[i].setGenre(Genre.Jazz);
                            break;
                        case 'C':
                            musicArray[i].setGenre(Genre.Country);
                            break;
                        default:
                            musicArray[i].setGenre(Genre.Pop);
                            break;
                    }
                }
            } catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                for(int i = 0; i < numSongs; i++)
                {
                    Console.WriteLine($"---------- Song {i + 1} ----------");
                    Console.WriteLine($"{musicArray[i].display()}");
                }
            }
           

        }
    }
}