namespace ChessGame.Gui.Component.Piece {
    using System.Reactive.Subjects;
    using System.Reflection;

    public partial class TowerComponent : FieldComponent {        
        public TowerComponent() {
            InitializeComponent();            
        }

        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {                
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "TowerWhite.png"));
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "TowerBlack.png"));
                this.BackgroundImage = myimage;
            }
        }

        private void TowerComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
