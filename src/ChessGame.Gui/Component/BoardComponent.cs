namespace ChessGame.Gui.Component {
    using ChessGame.Gui.Component.Piece;
    using ChessGamer.Services;
    using System;
    using System.Reactive.Linq;
    using System.Reactive.Subjects;
    using System.Threading;
    using System.Windows.Forms;

    public partial class BoardComponent : UserControl {
        private ISubject<PiecePosition> EventPiecePosition;
        private IObservable<PiecePosition> ObservableEventClient;
        private IObservable<SelectPosition> ObservableRock;

        private SynchronizationContext _synchronizationContext;
        private Board Board { get; set; }
        private readonly CapturedPartsComponent _capturedWhiteComponent;
        private readonly CapturedPartsComponent _capturedBlackComponent;

        private IDictionary<string, SelectPosition> _validPosition;
        private IDictionary<string, UserControl> _pieceControl;

        private bool InitializeGame = false;

        public BoardComponent(Board board, CapturedPartsComponent capturedWhiteComponent, CapturedPartsComponent capturedBlackComponent, ISubject<bool> subjectInitGamer) {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;
            EventPiecePosition = new Subject<PiecePosition>();
            ObservableEventClient = EventPiecePosition;
            ObservableEventClient.ObserveOn(_synchronizationContext).Subscribe(PossibleMoves);

            _validPosition = new Dictionary<string, SelectPosition>();
            _pieceControl = new Dictionary<string, UserControl>();
            _pieceControl = new Dictionary<string, UserControl>();

            this.BackColor = Color.Beige;
            PlacingThePieces();
            Board = board;

            ObservableRock = board.SubjectRock;
            ObservableRock.ObserveOn(_synchronizationContext).Subscribe(Rock);

            _capturedWhiteComponent = capturedWhiteComponent;
            _capturedBlackComponent = capturedBlackComponent;

            subjectInitGamer.ObserveOn(_synchronizationContext).Subscribe((x) => {
                InitializeGame = x;
            });
        }



        private void panelChess_Click(object sender, EventArgs e) {
            TableLayoutPanel tableLayoutPanel = sender as TableLayoutPanel;

            Point relativePoint = tableLayoutPanel.PointToClient(Cursor.Position);

            int cellWidth = tableLayoutPanel.Width / tableLayoutPanel.ColumnCount;
            int cellHeight = tableLayoutPanel.Height / tableLayoutPanel.RowCount;

            int column = relativePoint.X / cellWidth;
            int row = relativePoint.Y / cellHeight;

            if (InitializeGame) {
                EventPiecePosition.OnNext(new PiecePosition(row, column));
            }
        }

        private void PossibleMoves(PiecePosition clickPosition) {
            var key = clickPosition.GetKey();
            if (_validPosition.TryGetValue(key, out var position)) {
                if (Board.TryMove(position.Origin, clickPosition, out var ransom1)) {
                    var move = TryMoveControl(position);
                    if (move) {
                        return;
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

        private bool TryMoveControl(SelectPosition position) {
            try {
                _validPosition.Clear();
                panelChess.Invalidate();
                var controlKey = position.GetOriginKey();
                if (_pieceControl.TryGetValue(controlKey, out var control)) {
                    var controlKeyDestionation = GetKey(position.Destination.Row, position.Destination.Column);

                    if (_pieceControl.TryGetValue(controlKeyDestionation, out var capture)) {
                        if (Board.IsWhite) {
                            _capturedBlackComponent.IncrementCount(capture);
                        } else {
                            _capturedWhiteComponent.IncrementCount(capture);
                        }
                        panelChess.Controls.Remove(capture);
                    }
                    panelChess.Controls.Remove(control);
                    _pieceControl.Remove(controlKey);
                    if (_pieceControl.ContainsKey(controlKeyDestionation)) {
                        _pieceControl[controlKeyDestionation] = control;
                    } else {
                        _pieceControl.Add(controlKeyDestionation, control);
                    }

                    if (!position.Destination.ValidPosition) {
                        panelChess.SetCellPosition(control, new TableLayoutPanelCellPosition(position.Destination.Column, position.Destination.Row));
                        panelChess.Controls.Add(control);
                    }

                    return true;
                }
                return false;
            } catch (Exception ex) {
                return false;
            }
        }

        private void Rock(SelectPosition position) {
            var controlKey = position.GetOriginKey();
            if (_pieceControl.TryGetValue(controlKey, out var control)) {
                panelChess.Controls.Remove(control);
                _pieceControl.Remove(controlKey);

                panelChess.SetCellPosition(control, new TableLayoutPanelCellPosition(position.Destination.Column, position.Destination.Row));
                panelChess.Controls.Add(control);
            }
            //_validPosition.Add(position.GetDestinationKey(), position);
            //panelChess.Invalidate();
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
                    var key = GetKey(row, column);
                    FieldComponent component = null;
                    if (row == 0 || row == 7) {
                        var color = row == 0 ? Color.Black : Color.White;
                        switch (column) {
                            case 0:
                                component = new TowerComponent();
                                break;
                            case 1:
                                component = new HorseComponent();
                                break;
                            case 2:
                                component = new BishopComponent();
                                break;
                            case 3:
                                component = new DamaComponent();
                                break;
                            case 4:
                                component = new KingComponent();
                                break;
                            case 5:
                                component = new BishopComponent();
                                break;
                            case 6:
                                component = new HorseComponent();
                                break;
                            case 7:
                                component = new TowerComponent();
                                break;
                        }
                        component.SetInitializePiece(color);
                    } else if (row == 1) {

                        component = new PawnComponent();
                        component.SetInitializePiece(Color.Black);

                    } else if (row == 6) {

                        component = new PawnComponent();
                        component.SetInitializePiece(Color.White);
                    }

                    if (component != null) {

                        component.Subject.Subscribe((e) => { panelChess_Click(panelChess, e); });
                        _pieceControl.Add(key, component);

                        panelChess.SetCellPosition(component, new TableLayoutPanelCellPosition(column, row));
                        panelChess.Controls.Add(component);
                    }
                }
            }
        }

        public string GetKey(int row, int column) {
            return $"Row: {row} | Column: {column}";
        }
    }
}
