namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;

    public partial class BishopComponent : FieldComponent {
        public BishopComponent() {
            InitializeComponent();
        }
        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\BishopWhite.png");
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\BishopBlack.png");
                this.BackgroundImage = myimage;
            }
        }

        private void BishopComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
