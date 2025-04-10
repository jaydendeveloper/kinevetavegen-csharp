using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static kinevetavegen.GameData;

namespace kinevetavegen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            generateTiles();
            generateHutWays();
            generateHuts();
            renderPieces();
        }


        public Piece selectedPiece = new Piece();
        public string currentTeam = "yellow";

        void renderPieces()
        {
            foreach (Piece[] teamPieces in pieces.Values)
            {
                foreach (Piece piece in teamPieces)
                {
                    bool inHut = piece.inHut;

                    Tile currentTile = inHut ? hutMap[piece.tileId] : gameMap[piece.tileId];
                    Rectangle pieceRectangle = new Rectangle();
                    pieceRectangle.Stroke = Brushes.Black;
                    pieceRectangle.Width = 30;
                    pieceRectangle.Height = 30;
                    pieceRectangle.RadiusX = 30;
                    pieceRectangle.RadiusY = 30;

                    switch (piece.team)
                    {
                        case "red":
                            pieceRectangle.Fill = Brushes.Red;
                            break;
                        case "blue":
                            pieceRectangle.Fill = Brushes.Blue;
                            break;
                        case "yellow":
                            pieceRectangle.Fill = Brushes.Yellow;
                            break;
                        case "green":
                            pieceRectangle.Fill = Brushes.Green;
                            break;
                        default:
                            pieceRectangle.Fill = Brushes.White;
                            break;
                    }

                    pieceRectangle.MouseLeftButtonUp += (sender, e) => piece.onClick(this, currentTeam);

                    Grid.SetRow(pieceRectangle, currentTile.row);
                    Grid.SetColumn(pieceRectangle, currentTile.column);
                    gameGrid.Children.Add(pieceRectangle);
                }
            }
        }

        void generateHuts()
        {
            foreach (Tile hut in hutMap.Values)
            {
                Rectangle tile = new Rectangle();
                tile.Stroke = Brushes.Black;
                tile.Width = 50;
                tile.Height = 50;

                tile.RadiusX = 50;
                tile.RadiusY = 50;

                switch (hut.teamSpawn)
                {
                    case "red":
                        tile.Fill = Brushes.Red;
                        break;
                    case "blue":
                        tile.Fill = Brushes.Blue;
                        break;
                    case "yellow":
                        tile.Fill = Brushes.Yellow;
                        break;
                    case "green":
                        tile.Fill = Brushes.Green;
                        break;
                    default:
                        tile.Fill = Brushes.White;
                        break;
                }

                Grid.SetRow(tile, hut.row);
                Grid.SetColumn(tile, hut.column);
                gameGrid.Children.Add(tile);
            }
        }

        void generateHutWays()
        {
            foreach (Tile hutWay in hutWayMap.Values){
                Rectangle tile = new Rectangle();
                tile.Stroke = Brushes.Black;
                tile.Width = 50;
                tile.Height = 50;

                tile.RadiusX = 50;
                tile.RadiusY = 50;

               switch (hutWay.teamSpawn)
               {
                    case "red":
                        tile.Fill = Brushes.Red;
                        break;
                     case "blue":
                         tile.Fill = Brushes.Blue;
                         break;
                     case "yellow":
                         tile.Fill = Brushes.Yellow;
                         break;
                     case "green":
                         tile.Fill = Brushes.Green;
                         break;
                      default:
                         tile.Fill = Brushes.White;
                         break;
               }

                Grid.SetRow(tile, hutWay.row);
                Grid.SetColumn(tile, hutWay.column);
                gameGrid.Children.Add(tile);
            }
        }

        void generateTiles()
        {
            foreach (Tile gameTile in gameMap.Values)
            {
                Rectangle tile = new Rectangle();
                tile.Stroke = Brushes.Black;

                tile.Width = 50;
                tile.Height = 50;

                tile.RadiusX = 50;
                tile.RadiusY = 50;
                switch (gameTile.type)
                {
                    case "spawn":
                        switch(gameTile.teamSpawn)
                        {
                            case "red":
                                tile.Fill = Brushes.Red;
                                tile.Opacity = 0.6;
                                break;
                            case "blue":
                                tile.Fill = Brushes.Blue;
                                tile.Opacity = 0.6;
                                break;
                            case "yellow":
                                tile.Fill = Brushes.Yellow;
                                tile.Opacity = 0.6;
                                break;
                            case "green":
                                tile.Fill = Brushes.Green;
                                tile.Opacity = 0.6;
                                break;
                            default:
                                tile.Fill = Brushes.White;
                                break;
                        }
                        break;
                    default:
                        tile.Fill = Brushes.White;
                        break;
                }

                Grid.SetRow(tile, gameTile.row);
                Grid.SetColumn(tile, gameTile.column);
                gameGrid.Children.Add(tile);
            }
        }
    }
}
