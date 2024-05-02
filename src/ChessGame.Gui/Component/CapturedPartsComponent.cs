namespace ChessGame.Gui.Component {
    using System.Windows.Forms;

    public partial class CapturedPartsComponent : UserControl {
        private readonly string _nameComponent;
        public CapturedPartsComponent(string nameComponent) {
            InitializeComponent();
            _nameComponent = nameComponent;
            lbl_NameComponent.Text = _nameComponent;
        }
    }
}
