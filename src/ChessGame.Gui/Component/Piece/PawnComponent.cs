namespace ChessGame.Gui.Component.Piece {
    using System;
    using System.Drawing;
    using System.Reactive.Subjects;
    using System.Reflection;

    public partial class PawnComponent : FieldComponent {
        public PawnComponent() {
            InitializeComponent();
            Subject = new Subject<EventArgs>();
        }

        public override void SetInitializePiece(Color color) {
            Color = color;
            if (Color == Color.White) {
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "PawnWhite.png"));
                this.BackgroundImage = myimage;
            } else {
                Image myimage = new Bitmap(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Piece", "PawnBlack.png"));
                this.BackgroundImage = myimage;
            }
        }

        private void PawnComponent_Click(object sender, EventArgs e) {
            Subject.OnNext(e);
        }
    }
}
