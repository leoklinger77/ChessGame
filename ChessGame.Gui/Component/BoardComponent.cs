namespace ChessGame.Gui.Component {
    using ChessGamer.Services;
    using System;
    using System.Reactive.Linq;

    public partial class BoardComponent : UserControl {
        public IObservable<EventArgs> ObservablePawn { get; set; }
        public bool SelectPiece { get; set; } = false;
        public Point SelectPoint { get; set; }
        public Board Board { get; set; }

        public BoardComponent(Board board) {
            InitializeComponent();
            this.BackColor = Color.Beige;
            PlacingThePieces();
            Board = board;
        }

        public void PlacingThePieces() {
            //White
            pawnA2.SetInitializePiece(Color.White);
            pawnA2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnB2.SetInitializePiece(Color.White);
            pawnB2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnC2.SetInitializePiece(Color.White);
            pawnC2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnD2.SetInitializePiece(Color.White);
            pawnD2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnE2.SetInitializePiece(Color.White);
            pawnE2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnF2.SetInitializePiece(Color.White);
            pawnF2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnG2.SetInitializePiece(Color.White);
            pawnG2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnH2.SetInitializePiece(Color.White);
            pawnH2.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            towerA1.SetInitializePiece(Color.White);
            towerA1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            towerH1.SetInitializePiece(Color.White);
            towerH1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            horseB1.SetInitializePiece(Color.White);
            horseB1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            horseG1.SetInitializePiece(Color.White);
            horseG1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            bishopC1.SetInitializePiece(Color.White);
            bishopC1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            bishopF1.SetInitializePiece(Color.White);
            bishopF1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            }); ;
            damaD1.SetInitializePiece(Color.White);
            damaD1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            kingE1.SetInitializePiece(Color.White);
            kingE1.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });

            //Black
            pawnA7.SetInitializePiece(Color.Black);
            pawnA7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnB7.SetInitializePiece(Color.Black);
            pawnB7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnC7.SetInitializePiece(Color.Black);
            pawnC7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnD7.SetInitializePiece(Color.Black);
            pawnD7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnE7.SetInitializePiece(Color.Black);
            pawnE7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnF7.SetInitializePiece(Color.Black);
            pawnF7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnG7.SetInitializePiece(Color.Black);
            pawnG7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            pawnH7.SetInitializePiece(Color.Black);
            pawnH7.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            towerA8.SetInitializePiece(Color.Black);
            towerA8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            towerH8.SetInitializePiece(Color.Black);
            towerH8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            horseB8.SetInitializePiece(Color.Black);
            horseB8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            horseG8.SetInitializePiece(Color.Black);
            horseG8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            bishopC8.SetInitializePiece(Color.Black);
            bishopC8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            bishopF8.SetInitializePiece(Color.Black);
            bishopF8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            damaD8.SetInitializePiece(Color.Black);
            damaD8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
            kingE8.SetInitializePiece(Color.Black);
            kingE8.Subject.Subscribe((e) => {
                panelChess_Click(null, e);
            });
        }

        private void chessBoard_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if ((e.Column + e.Row) % 2 == 1) {
                e.Graphics.FillRectangle(Brushes.Tan, e.CellBounds);
            } else {
                e.Graphics.FillRectangle(Brushes.Beige, e.CellBounds);
            }
        }

        private void panelChess_Click(object sender, EventArgs e) {
            var cellPos = GetRowColIndex(panelChess, panelChess.PointToClient(Cursor.Position));
            if (cellPos == Point.Empty) {
                return;
            }

            SelectPoint = cellPos;
            PossibleMoves();
        }

        private void PossibleMoves() {
            if (!Board.TryGetField(SelectPoint, out var field, out var ransom)) {
                return;
            }

            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var fieldMark = Board.Fields()[i, j];
                    if (fieldMark.ValidPosition) {
                        
                        var bla = panelChess.GetControlFromPosition(j, i).BackColor = Color.Aquamarine;
                        panelChess.Update();
                    }
                }
            }
        }      



        private Point GetRowColIndex(TableLayoutPanel tlp, Point point) {
            if (point.X > tlp.Width || point.Y > tlp.Height) {
                return Point.Empty;
            }

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--) {
                w -= widths[i];
            }
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--) {
                h -= heights[i];
            }

            int row = i + 1;

            return new Point(col, row);
        }
    }
}
