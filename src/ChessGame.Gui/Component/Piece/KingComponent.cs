namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;
    using System.Reflection;

    public partial class KingComponent : FieldComponent {       
        public KingComponent() {
            InitializeComponent();            
        }

        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {                
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "KingWhite.png"));
                this.BackgroundImage = myimage;
            } else {
                
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "KingBlack.png"));
                this.BackgroundImage = myimage;
            }
        }

        private void KingComponenet_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
