namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;

    public partial class KingComponenet : UserControl {
        public Color Color { get; private set; }
        public Subject<EventArgs> Subject { get; set; }
        public KingComponenet() {
            InitializeComponent();
            Subject = new Subject<EventArgs>();
        }
        public void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\KingWhite.png");
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\KingBlack.png");
                this.BackgroundImage = myimage;
            }
        }

        private void KingComponenet_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
