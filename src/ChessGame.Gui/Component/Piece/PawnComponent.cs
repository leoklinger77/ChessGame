namespace ChessGame.Gui.Component.Piece {
    using ChessGamer.Services;
    using System;
    using System.Reactive.Subjects;
    public partial class PawnComponent : UserControl {
        public Color Color { get; set; }
        public Subject<EventArgs> Subject { get; set; }
        public PawnComponent() {
            InitializeComponent();
            Subject = new Subject<EventArgs>();
        }

        public void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\PawnWhite.png");
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\PawnBlack.png");
                this.BackgroundImage = myimage;
            }
        }

        private void PawnComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
