namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;

    public partial class DamaComponent : UserControl {
        public Color Color { get; private set; }
        public Subject<EventArgs> Subject { get; set; }
        public DamaComponent() {
            InitializeComponent();
            Subject = new Subject<EventArgs>();
        }
        public void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\DamaWhite.png");
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\DamaBlack.png");
                this.BackgroundImage = myimage;
            }
        }

        private void DamaComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
