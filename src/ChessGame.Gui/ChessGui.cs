namespace ChessGame.Gui {
    using ChessGame.Gui.Component;
    using ChessGamer.Services;

    public partial class ChessGui : Form {
        private readonly Board _board;
        private readonly BoardComponent _boardComponent;
        private readonly CapturedPartsComponent _capturedWhiteComponent;
        private readonly CapturedPartsComponent _capturedBlackComponent;
        public ChessGui() {
            InitializeComponent();
            
            _board = new Board();
            _capturedWhiteComponent = new CapturedPartsComponent("You");
            _capturedBlackComponent = new CapturedPartsComponent("Robot");
            _boardComponent = new BoardComponent(_board, _capturedWhiteComponent, _capturedBlackComponent);

            Initialize();
        }

        private void Initialize() {
            this.BackColor = Color.Peru;

            _boardComponent.Dock = DockStyle.Fill;
            panel_Board.Controls.Add(_boardComponent);

            _capturedWhiteComponent.BackColor = Color.Beige;
            _capturedWhiteComponent.Dock = DockStyle.Fill;
            _capturedWhiteComponent.SetInitializePiece(Color.Black);
            panel_CapturedWhite.Controls.Add(_capturedWhiteComponent);

            _capturedBlackComponent.BackColor = Color.Beige;
            _capturedBlackComponent.Dock = DockStyle.Fill;
            _capturedBlackComponent.SetInitializePiece(Color.White);
            panel__CapturedBlack.Controls.Add(_capturedBlackComponent);
        }
    }
}
