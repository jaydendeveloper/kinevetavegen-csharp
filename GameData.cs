using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kinevetavegen
{
   public class GameData
    {
        public struct Tile
        {
            public int number;
            public int row;
            public int column;
            public string type;
            public string teamSpawn;
        }

        public static Dictionary<int, Tile> gameMap = new Dictionary<int, Tile>() {
            {1, new Tile{
                number=1,
                column=2,
                row=6,
                type="spawn",
                teamSpawn="red",
            }},
            {2, new Tile{
                number=2,
                column=3,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {3, new Tile{
                number=3,
                column=4,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {4, new Tile{
                number=4,
                column=5,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {5, new Tile{
                number=5,
                column=6,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {6, new Tile{
                number=6,
                column=6,
                row=5,
                type="tile",
                teamSpawn="",
            }},
            {7, new Tile{
                number=6,
                column=6,
                row=5,
                type="tile",
                teamSpawn="",
            }},
            {8, new Tile{
                number=7,
                column=6,
                row=4,
                type="tile",
                teamSpawn="",
            }},
            {9, new Tile{
                number=8,
                column=6,
                row=3,
                type="tile",
                teamSpawn="",
            }},
            {10, new Tile{
                number=10,
                column=6,
                row=2,
                type="tile",
                teamSpawn="",
            }},
            {11, new Tile{
                number=11,
                column=7,
                row=2,
                type="tile",
                teamSpawn="",
            }},
            {12, new Tile{
                number=12,
                column=8,
                row=2,
                type="spawn",
                teamSpawn="blue",
            }},
            {13, new Tile{
                number=13,
                column=8,
                row=3,
                type="tile",
                teamSpawn="",
            }},
            {14, new Tile{
                number=14,
                column=8,
                row=4,
                type="tile",
                teamSpawn="",
            }},
            {15, new Tile{
                number=15,
                column=8,
                row=5,
                type="tile",
                teamSpawn="",
            }},
            {16, new Tile{
                number=16,
                column=8,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {17, new Tile{
                number=17,
                column=9,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {18, new Tile{
                number=18,
                column=10,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {19, new Tile{
                number=19,
                column=11,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {20, new Tile{
                number=20,
                column=12,
                row=6,
                type="tile",
                teamSpawn="",
            }},
            {21, new Tile{
                number=21,
                column=12,
                row=7,
                type="tile",
                teamSpawn="",
            }},
            {22, new Tile{
                number=22,
                column=12,
                row=8,
                type="spawn",
                teamSpawn="green",
            }},
            {23, new Tile{
                number=23,
                column=11,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {24, new Tile{
                number=24,
                column=10,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {25, new Tile{
                number=25,
                column=9,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {26, new Tile{
                number=26,
                column=8,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {27, new Tile{
                number=27,
                column=8,
                row=9,
                type="tile",
                teamSpawn="",
            }},
            {28, new Tile{
                number=28,
                column=8,
                row=10,
                type="tile",
                teamSpawn="",
            }},
            {29, new Tile{
                number=29,
                column=8,
                row=11,
                type="tile",
                teamSpawn="",
            }},
            {30, new Tile{
                number=30,
                column=8,
                row=12,
                type="tile",
                teamSpawn="",
            }},
            {31, new Tile{
                number=31,
                column=7,
                row=12,
                type="tile",
                teamSpawn="",
            }},
            {32, new Tile{
                number=32,
                column=6,
                row=12,
                type="spawn",
                teamSpawn="yellow",
            }},
            {33, new Tile{
                number=33,
                column=6,
                row=11,
                type="tile",
                teamSpawn="",
            }},
            {34, new Tile{
                number=34,
                column=6,
                row=10,
                type="tile",
                teamSpawn="",
            }},
            {35, new Tile{
                number=35,
                column=6,
                row=9,
                type="tile",
                teamSpawn="",
            }},
            {36, new Tile{
                number=36,
                column=6,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {37, new Tile{
                number=37,
                column=5,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {38, new Tile{
                number=38,
                column=4,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {39, new Tile{
                number=39,
                column=3,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {40, new Tile{
                number=40,
                column=2,
                row=8,
                type="tile",
                teamSpawn="",
            }},
            {41, new Tile{
                number=40,
                column=2,
                row=7,
                type="tile",
                teamSpawn="",
            }},
        };

        public static Dictionary<int, Tile> hutWayMap = new Dictionary<int, Tile>() {
            {1, new Tile{
                number=1,
                column=3,
                row=7,
                type="hutWay",
                teamSpawn="red",
            }},
            {2, new Tile{
                number=2,
                column=4,
                row=7,
                type="hutWay",
                teamSpawn="red",
            }},
            {3, new Tile{
                number=3,
                column=5,
                row=7,
                type="hutWay",
                teamSpawn="red",
            }},
            {4, new Tile{
                number=4,
                column=6,
                row=7,
                type="hutWay",
                teamSpawn="red",
            }},
            {5, new Tile{
                number=5,
                column=7,
                row=3,
                type="hutWay",
                teamSpawn="blue",
            }},
            {6, new Tile{
                number=6,
                column=7,
                row=4,
                type="hutWay",
                teamSpawn="blue",
            }},
            {7, new Tile{
                number=7,
                column=7,
                row=5,
                type="hutWay",
                teamSpawn="blue",
            }},
            {8, new Tile{
                number=8,
                column=7,
                row=6,
                type="hutWay",
                teamSpawn="blue"
            }},
            {9, new Tile{
                number=9,
                column=11,
                row=7,
                type="hutWay",
                teamSpawn="green",
            }},
            {10, new Tile{
                number=10,
                column=10,
                row=7,
                type="hutWay",
                teamSpawn="green",
            }},
            {11, new Tile{
                number=11,
                column=9,
                row=7,
                type="hutWay",
                teamSpawn="green",
            }},
            {12, new Tile{
                number=12,
                column=8,
                row=7,
                type="hutWay",
                teamSpawn="green"
            }},
            {13, new Tile{
                number=13,
                column=7,
                row=11,
                type="hutWay",
                teamSpawn="yellow",
            }},
            {14, new Tile{
                number=14,
                column=7,
                row=10,
                type="hutWay",
                teamSpawn="yellow",
            }},
            {15, new Tile{
                number=15,
                column=7,
                row=9,
                type="hutWay",
                teamSpawn="yellow",
            }},
            {16, new Tile{
                number=16,
                column=7,
                row=8,
                type="hutWay",
                teamSpawn="yellow"
            }},
        };

        public static Dictionary<int, Tile> hutMap = new Dictionary<int, Tile>() {

            {1, new Tile{
                number=1,
                column=3,
                row=12,
                type="hut",
                teamSpawn="yellow"
            }},
            {2, new Tile{
                number=2,
                column=2,
                row=12,
                type="hut",
                teamSpawn="yellow"
            }},
            {3, new Tile{
                number=3,
                column=2,
                row=11,
                type="hut",
                teamSpawn="yellow"
            }},
            {4, new Tile{
                number=4,
                column=3,
                row=11,
                type="hut",
                teamSpawn="yellow"
            }},
            {5, new Tile{
                number=5,
                column=3,
                row=2,
                type="hut",
                teamSpawn="red"
            }},
            {6, new Tile{
                number=6,
                column=3,
                row=3,
                type="hut",
                teamSpawn="red"
            }},
            {7, new Tile{
                number=7,
                column=2,
                row=2,
                type="hut",
                teamSpawn="red"
            }},
            {8, new Tile{
                number=8,
                column=2,
                row=3,
                type="hut",
                teamSpawn="red"
            }},
            {9, new Tile{
                number=9,
                column=12,
                row=2,
                type="hut",
                teamSpawn="blue"
            }},
            {10, new Tile{
                number=10,
                column=11,
                row=2,
                type="hut",
                teamSpawn="blue"
            }},
            {11, new Tile{
                number=11,
                column=12,
                row=3,
                type="hut",
                teamSpawn="blue"
            }},
            {12, new Tile{
                number=12,
                column=11,
                row=3,
                type="hut",
                teamSpawn="blue"
            }},
            {13, new Tile{
                number=13,
                column=11,
                row=12,
                type="hut",
                teamSpawn="green"
            }},
            {14, new Tile{
                number=14,
                column=11,
                row=11,
                type="hut",
                teamSpawn="green"
            }},
            {15, new Tile{
                number=15,
                column=12,
                row=12,
                type="hut",
                teamSpawn="green"
            }},
            {16, new Tile{
                number=16,
                column=12,
                row=11,
                type="hut",
                teamSpawn="green"
            }},

        };
        public struct Piece
        {
            public string team;
            public int number;
            public int tileId;
            public bool inHut;
            public void onClick(MainWindow mainWindow, string currentTeam)
            {
                if (team == currentTeam)
                {
                    mainWindow.selectedPiece = this;
                    MessageBox.Show(team + " " + number + " " + tileId + " selected");
                }
            }
        }

        public static Dictionary<string, Piece[]> pieces = new Dictionary<string, Piece[]>()
{
    { "red", new Piece[4] {
        new Piece {
            team = "red",
            number = 1,
            tileId = 5,
            inHut = true,
        },
        new Piece {
            team = "red",
            number = 2,
            tileId = 6,
            inHut = true
        },
        new Piece {
            team = "red",
            number = 3,
            tileId = 7,
            inHut = true
        },
        new Piece {
            team = "red",
            number = 4,
            tileId = 8,
            inHut = true
        }
    }},
    { "blue", new Piece[4] {
        new Piece {
            team = "blue",
            number = 1,
            tileId = 9,
            inHut = true
        },
        new Piece {
            team = "blue",
            number = 2,
            tileId = 10,
            inHut = true
        },
        new Piece {
            team = "blue",
            number = 3,
            tileId = 11,
            inHut = true
        },
        new Piece {
            team = "blue",
            number = 4,
            tileId = 12,
            inHut = true
        }
    }},
    { "yellow", new Piece[4] {
        new Piece {
            team = "yellow",
            number = 1,
            tileId = 1,
            inHut = true
        },
        new Piece {
            team = "yellow",
            number = 2,
            tileId = 2,
            inHut = true
        },
        new Piece {
            team = "yellow",
            number = 3,
            tileId = 3,
            inHut = true
        },
        new Piece {
            team = "yellow",
            number = 4,
            tileId = 4,
            inHut = true
        }
    }},
    { "green", new Piece[4] {
        new Piece {
            team = "green",
            number = 1,
            tileId = 13,
            inHut = true
        },
        new Piece {
            team = "green",
            number = 2,
            tileId = 14,
            inHut = true
        },
        new Piece {
            team = "green",
            number = 3,
            tileId = 15,
            inHut = true
        },
        new Piece {
            team = "green",
            number = 4,
            tileId = 16,
            inHut = true
        }
    }}
};
    }
}
