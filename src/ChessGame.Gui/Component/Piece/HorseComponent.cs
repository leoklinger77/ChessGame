namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;
    using System.Reflection;

    public partial class HorseComponent : FieldComponent {        
        public HorseComponent() {
            InitializeComponent();            
        }

        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "HorseWhite.png"));
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "HorseBlack.png"));
                this.BackgroundImage = myimage;
            }
        }

        private void HorseComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
