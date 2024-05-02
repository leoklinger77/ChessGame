namespace ChessGame.Gui.Component {
    using ChessGamer.Services;
    using System;
    using System.Reactive.Linq;
    using System.Reactive.Subjects;
    using System.Threading;
    using System.Windows.Forms;

    public partial class BoardComponent : UserControl {
        private ISubject<PiecePosition> EventPiecePosition;
        private IObservable<PiecePosition> ObservableEventClient;
        private SynchronizationContext _synchronizationContext;
        private Board Board { get; set; }

        private IDictionary<string, Tuple<PiecePosition, Field>> _validPosition;
        public BoardComponent(Board board) {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;
            EventPiecePosition = new Subject<PiecePosition>();
            ObservableEventClient = EventPiecePosition;
            ObservableEventClient.ObserveOn(_synchronizationContext).Subscribe(PossibleMoves);

            _validPosition = new Dictionary<string, Tuple<PiecePosition, Field>>();

            this.BackColor = Color.Beige;
            PlacingThePieces();
            Board = board;
        }

        public void PlacingThePieces() {
            //White
            pawnA2.SetInitializePiece(Color.White);
            pawnA2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnB2.SetInitializePiece(Color.White);
            pawnB2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnC2.SetInitializePiece(Color.White);
            pawnC2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnD2.SetInitializePiece(Color.White);
            pawnD2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnE2.SetInitializePiece(Color.White);
            pawnE2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnF2.SetInitializePiece(Color.White);
            pawnF2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnG2.SetInitializePiece(Color.White);
            pawnG2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnH2.SetInitializePiece(Color.White);
            pawnH2.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            towerA1.SetInitializePiece(Color.White);
            towerA1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            towerH1.SetInitializePiece(Color.White);
            towerH1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            horseB1.SetInitializePiece(Color.White);
            horseB1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            horseG1.SetInitializePiece(Color.White);
            horseG1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            bishopC1.SetInitializePiece(Color.White);
            bishopC1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            bishopF1.SetInitializePiece(Color.White);
            bishopF1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            }); ;
            damaD1.SetInitializePiece(Color.White);
            damaD1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            kingE1.SetInitializePiece(Color.White);
            kingE1.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });

            //Black
            pawnA7.SetInitializePiece(Color.Black);
            pawnA7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnB7.SetInitializePiece(Color.Black);
            pawnB7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnC7.SetInitializePiece(Color.Black);
            pawnC7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnD7.SetInitializePiece(Color.Black);
            pawnD7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnE7.SetInitializePiece(Color.Black);
            pawnE7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnF7.SetInitializePiece(Color.Black);
            pawnF7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnG7.SetInitializePiece(Color.Black);
            pawnG7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            pawnH7.SetInitializePiece(Color.Black);
            pawnH7.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            towerA8.SetInitializePiece(Color.Black);
            towerA8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            towerH8.SetInitializePiece(Color.Black);
            towerH8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            horseB8.SetInitializePiece(Color.Black);
            horseB8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            horseG8.SetInitializePiece(Color.Black);
            horseG8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            bishopC8.SetInitializePiece(Color.Black);
            bishopC8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            bishopF8.SetInitializePiece(Color.Black);
            bishopF8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            damaD8.SetInitializePiece(Color.Black);
            damaD8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
            kingE8.SetInitializePiece(Color.Black);
            kingE8.Subject.Subscribe((e) => {
                panelChess_Click(panelChess, e);
            });
        }

        private void chessBoard_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {

            if ((e.Column + e.Row) % 2 == 1) {
                e.Graphics.FillRectangle(Brushes.Tan, e.CellBounds);
            } else {
                e.Graphics.FillRectangle(Brushes.Beige, e.CellBounds);
            }

            var key = new PiecePosition(e.Column, e.Row);
            if (_validPosition.TryGetValue(GetKey(key), out _)) {
                e.Graphics.FillRectangle(Brushes.GreenYellow, e.CellBounds);
            }
        }

        private void panelChess_Click(object sender, EventArgs e) {
            TableLayoutPanel tableLayoutPanel = sender as TableLayoutPanel;

            Point relativePoint = tableLayoutPanel.PointToClient(Cursor.Position);

            int cellWidth = tableLayoutPanel.Width / tableLayoutPanel.ColumnCount;
            int cellHeight = tableLayoutPanel.Height / tableLayoutPanel.RowCount;

            int column = relativePoint.X / cellWidth;
            int row = relativePoint.Y / cellHeight;

            EventPiecePosition.OnNext(new PiecePosition(column, row));
        }

        private UserControl GetUserControlAtPosition(int row, int column) {
            foreach (Control control in panelChess.Controls) {
                var tablePanelPossion = panelChess.GetCellPosition(control);
                if (tablePanelPossion.Row == row && tablePanelPossion.Column == column) {
                    return control as UserControl;
                }
            }
            return null;
        }

        private void PossibleMoves(PiecePosition clickPosition) {

            if (_validPosition.TryGetValue(GetKey(clickPosition), out var positionValid)) {
                if (Board.TryMove(positionValid.Item2, clickPosition, out var ransom1)) {

                    _validPosition.Clear();
                    panelChess.Invalidate();

                    var pieceComponent = GetUserControlAtPosition(positionValid.Item2.Row, positionValid.Item2.Column);
                    var capture = GetUserControlAtPosition(clickPosition.Row, clickPosition.Column);
                    if (capture != null) {
                        panelChess.Controls.Remove(capture);
                    }
                    panelChess.Controls.Remove(pieceComponent);
                    if (!positionValid.Item2.FieldAttacked) {
                        panelChess.SetCellPosition(pieceComponent, new TableLayoutPanelCellPosition(clickPosition.Column, clickPosition.Row));
                        panelChess.Controls.Add(pieceComponent);
                    }
                    return;
                }
            }

            if (!Board.TryGetField(clickPosition, out var field, out var ransom)) {
                return;
            }

            _validPosition.Clear();
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var fieldMark = Board.Fields()[i, j];
                    if (fieldMark.ValidPosition) {
                        var position = new PiecePosition(fieldMark.Column, fieldMark.Row);
                        var tuple = new Tuple<PiecePosition, Field>(position, field);
                        _validPosition.Add(GetKey(position), tuple);
                    }
                }
            }
            panelChess.Invalidate();
        }

        private string GetKey(PiecePosition position) {
            return position.ToString();
        }
    }
}
