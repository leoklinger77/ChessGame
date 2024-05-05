namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;

    public partial class TowerComponent : FieldComponent {        
        public TowerComponent() {
            InitializeComponent();            
        }

        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\TowerWhite.png");
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(@"C:\develop\custom\ChessGame\Piece\TowerBlack.png");
                this.BackgroundImage = myimage;
            }
        }

        private void TowerComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
