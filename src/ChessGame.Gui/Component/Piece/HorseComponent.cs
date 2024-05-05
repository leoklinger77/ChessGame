namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;

    public partial class HorseComponent : FieldComponent {        
        public HorseComponent() {
            InitializeComponent();            
        }

        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\HorseWhite.png");
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\HorseBlack.png");
                this.BackgroundImage = myimage;
            }
        }

        private void HorseComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
