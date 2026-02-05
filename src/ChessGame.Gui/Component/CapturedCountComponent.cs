namespace ChessGame.Gui.Component {
    public partial class CapturedCountComponent : UserControl {
        private int _count = 0;
        public CapturedCountComponent(UserControl userControl) {
            InitializeComponent();
            userControl.Dock = DockStyle.Fill;
            panel_Piece.Controls.Add(userControl);
        }

        public void IncrementCount() {
            _count++;
            CountUpdate();
        }

        public void DecrementCount() {
            if (_count - 1 == 0) {
                return;
            }
            _count--;
            CountUpdate();
        }

        private void CountUpdate() {
            lbl_Count.Text = _count.ToString();
        }
    }
}
