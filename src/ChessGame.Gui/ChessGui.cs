namespace ChessGame.Gui {
    using ChessGamer.Services;

    public partial class ChessGui : Form {
        public Board Board { get; set; }
        public ChessGui() {
            Board = new Board();
            InitializeComponent();
            this.BackColor = Color.Beige;

            towerWhiteCount.SetInitializePiece(Color.White);
            pawnWhiteCount.SetInitializePiece(Color.White);
            bishopWhiteCount.SetInitializePiece(Color.White);
            horseWhiteCount.SetInitializePiece(Color.White);
            kingWhiteCount.SetInitializePiece(Color.White);
            damaWhiteCount.SetInitializePiece(Color.White);
        }
    }
}
