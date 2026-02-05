namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;
    using System.Reflection;

    public partial class DamaComponent : FieldComponent {        
        public DamaComponent() {
            InitializeComponent();
            
        }
        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "DamaWhite.png"));
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "DamaBlack.png"));
                this.BackgroundImage = myimage;
            }
        }

        private void DamaComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
