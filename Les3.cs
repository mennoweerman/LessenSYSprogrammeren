using System;

namespace Opdracht3
{


    class Program
    {

        static void Main(string[] args)
        {
            RoomInside room = new RoomInside(10, 10);
            
        }

        private class Tile
        {

        }

        private class RoomInside
        {
            private Tile[][] tiles;

            public RoomInside(int width, int height)
            {
                this.tiles = new Tile[height][];

                for (int i = 0; i < height; i++)
                {
                    this.tiles[i] = new Tile[width];

                    for (int j = 0; j < width; j++)
                    {
                        this.tiles[i][j] = new Tile();
                        
                    }
                }
            }
        }

       
    }
}
    
    

