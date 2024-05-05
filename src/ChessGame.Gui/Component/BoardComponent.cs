namespace ChessGame.Gui.Component {
    using ChessGamer.Pieces;
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
        private readonly CapturedPartsComponent _capturedWhiteComponent;
        private readonly CapturedPartsComponent _capturedBlackComponent;

        private IDictionary<string, SelectPosition> _validPosition;
        private IDictionary<string, UserControl> _pieceControl;
        public BoardComponent(Board board, CapturedPartsComponent capturedWhiteComponent, CapturedPartsComponent capturedBlackComponent) {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;
            EventPiecePosition = new Subject<PiecePosition>();
            ObservableEventClient = EventPiecePosition;
            ObservableEventClient.ObserveOn(_synchronizationContext).Subscribe(PossibleMoves);

            _validPosition = new Dictionary<string, SelectPosition>();
            _pieceControl = new Dictionary<string, UserControl>();

            this.BackColor = Color.Beige;
            PlacingThePieces();
            Board = board;
            _capturedWhiteComponent = capturedWhiteComponent;
            _capturedBlackComponent = capturedBlackComponent;
        }

        private void panelChess_Click(object sender, EventArgs e) {
            TableLayoutPanel tableLayoutPanel = sender as TableLayoutPanel;

            Point relativePoint = tableLayoutPanel.PointToClient(Cursor.Position);

            int cellWidth = tableLayoutPanel.Width / tableLayoutPanel.ColumnCount;
            int cellHeight = tableLayoutPanel.Height / tableLayoutPanel.RowCount;

            int column = relativePoint.X / cellWidth;
            int row = relativePoint.Y / cellHeight;

            EventPiecePosition.OnNext(new PiecePosition(row, column));
        }

        private void PossibleMoves(PiecePosition clickPosition) {
            var key = clickPosition.GetKey();
            if (_validPosition.TryGetValue(key, out var positionValid)) {
                if (Board.TryMove(positionValid.Origin, clickPosition, out var ransom1)) {
                    try {
                        _validPosition.Clear();
                        panelChess.Invalidate();
                        var controlKey = GetKey(positionValid.Origin.Column, positionValid.Origin.Row);
                        if (_pieceControl.TryGetValue(controlKey, out var control)) {
                            var controlKeyDestionation = GetKey(positionValid.Destination.Column, positionValid.Destination.Row);

                            if (positionValid.Destination.FieldAttacked && _pieceControl.TryGetValue(controlKeyDestionation, out var capture)) {
                                if (Board.IsWhite) {
                                    _capturedBlackComponent.IncrementCount(capture);
                                } else {
                                    _capturedWhiteComponent.IncrementCount(capture);
                                }
                                panelChess.Controls.Remove(capture);
                            }
                            panelChess.Controls.Remove(control);

                            if (!positionValid.Destination.FieldAttacked) {
                                panelChess.SetCellPosition(control, new TableLayoutPanelCellPosition(positionValid.Destination.Column, positionValid.Destination.Row));
                                panelChess.Controls.Add(control);
                            }

                            _pieceControl.Remove(controlKey);
                            _pieceControl.Add(controlKeyDestionation, control);
                        }
                        return;
                    } catch (Exception ex) {

                    }
                }
            }

            if (!Board.TryGetField(clickPosition, out var field, out var ransom)) {
                return;
            }

            _validPosition.Clear();

            _validPosition = Board.GetValidFilds(field);

            panelChess.Invalidate();
        }

        private void chessBoard_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if ((e.Column + e.Row) % 2 == 1) {
                e.Graphics.FillRectangle(Brushes.Tan, e.CellBounds);
            } else {
                e.Graphics.FillRectangle(Brushes.Beige, e.CellBounds);
            }
            var key = new PiecePosition(e.Row, e.Column);
            if (_validPosition.TryGetValue(key.GetKey(), out _)) {
                e.Graphics.FillRectangle(Brushes.GreenYellow, e.CellBounds);
            }
        }

        private void PlacingThePieces() {


            for (int row = 0; row < 8; row++) {
                for (int column = 0; column < 8; column++) {

                    if (row == 0 || row == 7) {
                        var collor = row == 0 ? ColorBlack : ColorWhite;
                        switch (column) {
                            case 0:
                                _pieceControl.Add();
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Tower(collor));
                                break;
                            case 1:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Horse(collor));
                                break;
                            case 2:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Bishop(collor));
                                break;
                            case 3:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Dama(collor));
                                break;
                            case 4:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new King(collor));
                                break;
                            case 5:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Bishop(collor));
                                break;
                            case 6:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Horse(collor));
                                break;
                            case 7:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Tower(collor));
                                break;
                        }
                    } else if (row == 1) {

                        _fields[row, column] = new Field(PiecePosition.Position(row, column), new Pawn(ColorBlack));

                    } else if (row == 6) {

                        _fields[row, column] = new Field(PiecePosition.Position(row, column), new Pawn(ColorWhite));

                    } else {
                        _fields[row, column] = new Field(PiecePosition.Position(row, column));
                    }
                }
            }

            //White
            pawnA2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 0), pawnA2);

            pawnB2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 1), pawnB2);

            pawnC2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 2), pawnC2);

            pawnD2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 3), pawnD2);

            pawnE2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 4), pawnE2);

            pawnF2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 5), pawnF2);

            pawnG2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 6), pawnG2);

            pawnH2.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(6, 7), pawnH2);


            towerA1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 0), pawnA7);

            horseB1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 1), pawnA7);

            bishopC1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 2), pawnA7);

            damaD1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 3), pawnA7);

            kingE1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 4), pawnA7);

            bishopF1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 5), pawnA7);

            horseG1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 6), pawnA7);

            towerH1.SetInitializePiece(Color.White);
            _pieceControl.Add(GetKey(7, 7), pawnA7);

            pawnA2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnB2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnC2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnD2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnE2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnF2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnG2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnH2.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            towerA1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            towerH1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            horseB1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            horseG1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            bishopC1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            bishopF1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            damaD1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            kingE1.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });

            ////Black
            pawnA7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 0), pawnA7);

            pawnB7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 1), pawnB7);

            pawnC7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 2), pawnC7);

            pawnD7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 3), pawnD7);

            pawnE7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 4), pawnE7);

            pawnF7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 5), pawnF7);

            pawnG7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 6), pawnG7);

            pawnH7.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(1, 7), pawnH7);



            towerA8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 0), towerA8);

            horseB8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 1), horseB8);

            bishopC8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 2), bishopC8);

            damaD8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 3), damaD8);

            kingE8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 4), kingE8);

            bishopF8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 5), bishopF8);

            horseG8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 6), horseG8);

            towerH8.SetInitializePiece(Color.Black);
            _pieceControl.Add(GetKey(0, 7), towerH8);

            pawnB7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnA7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnC7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnD7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnE7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnF7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnG7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            pawnH7.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            towerA8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            towerH8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            horseB8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            horseG8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            bishopC8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            bishopF8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            damaD8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
            kingE8.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });

        }

        public string GetKey(int column, int row) {
            return $"Column: {column} | Row: {row}";
        }
    }
}
