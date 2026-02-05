namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;
    using System.Reflection;

    public partial class BishopComponent : FieldComponent {
        public BishopComponent() {
            InitializeComponent();
        }
        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {                
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "BishopWhite.png"));
                this.BackgroundImage = myimage;
            } else {
                
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "BishopBlack.png"));
                this.BackgroundImage = myimage;
            }
        }

        private void BishopComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
