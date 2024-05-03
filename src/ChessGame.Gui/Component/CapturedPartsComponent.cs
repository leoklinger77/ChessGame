namespace ChessGame.Gui.Component {
    using ChessGame.Gui.Component.Piece;
    using System;
    using System.Reactive.Linq;
    using System.Reactive.Subjects;
    using System.Threading;
    using System.Windows.Forms;

    public partial class CapturedPartsComponent : UserControl {
        private readonly string _nameComponent;

        private readonly SynchronizationContext _synchronizationContext;

        private readonly CapturedCountComponent _countkingComponent;
        private readonly CapturedCountComponent _CountDamaComponent;
        private readonly CapturedCountComponent _countBishopComponent;
        private readonly CapturedCountComponent _countTowerComponent;
        private readonly CapturedCountComponent _countHorseComponent;
        private readonly CapturedCountComponent _countPawnComponent;

        private readonly KingComponenet _kingComponenet;
        private readonly DamaComponent _damaComponenet;
        private readonly TowerComponent _towerComponenet;
        private readonly BishopComponent _bishopComponenet;
        private readonly HorseComponent _horseComponenet;
        private readonly PawnComponent _pawnComponenet;

        private readonly ISubject<UserControl> _subjectIncrement;
        private readonly IObservable<UserControl> _observableIncrement;
        private readonly ISubject<UserControl> _subjectDecrement;
        private readonly IObservable<UserControl> _observableDecrement;

        private IDictionary<Type, CapturedCountComponent> _control = new Dictionary<Type, CapturedCountComponent>();

        public CapturedPartsComponent(string nameComponent) {
            InitializeComponent();

            _nameComponent = nameComponent;

            _kingComponenet = new KingComponenet();
            _damaComponenet = new DamaComponent();
            _towerComponenet = new TowerComponent();
            _bishopComponenet = new BishopComponent();
            _horseComponenet = new HorseComponent();
            _pawnComponenet = new PawnComponent();

            _countkingComponent = new CapturedCountComponent(_kingComponenet);
            _CountDamaComponent = new CapturedCountComponent(_damaComponenet);
            _countBishopComponent = new CapturedCountComponent(_bishopComponenet);
            _countTowerComponent = new CapturedCountComponent(_towerComponenet);
            _countHorseComponent = new CapturedCountComponent(_horseComponenet);
            _countPawnComponent = new CapturedCountComponent(_pawnComponenet);

            _control.Add(typeof(KingComponenet), _countkingComponent);
            _control.Add(typeof(DamaComponent), _CountDamaComponent);
            _control.Add(typeof(TowerComponent), _countTowerComponent);
            _control.Add(typeof(BishopComponent), _countBishopComponent);
            _control.Add(typeof(HorseComponent), _countHorseComponent);
            _control.Add(typeof(PawnComponent), _countPawnComponent);

            _synchronizationContext = SynchronizationContext.Current;
            _subjectIncrement = new Subject<UserControl>();
            _observableIncrement = _subjectIncrement.ObserveOn(_synchronizationContext).AsObservable();
            _observableIncrement.Subscribe((control) => HandlerControl(control, OperatorType.Increment));

            _subjectDecrement = new Subject<UserControl>();
            _observableDecrement = _subjectDecrement.ObserveOn(_synchronizationContext).AsObservable();
            _observableDecrement.Subscribe((control) => HandlerControl(control, OperatorType.Increment));
            Initialize();
        }

        public void IncrementCount(UserControl control) {
             _subjectIncrement.OnNext(control);
        }

        public void DecrementCount(UserControl control) {
             _subjectDecrement.OnNext(control);
        }

        public void SetInitializePiece(Color color) {
            _kingComponenet.SetInitializePiece(color);
            _damaComponenet.SetInitializePiece(color);
            _towerComponenet.SetInitializePiece(color);
            _bishopComponenet.SetInitializePiece(color);
            _horseComponenet.SetInitializePiece(color);
            _pawnComponenet.SetInitializePiece(color);
        }

        private void Initialize() {
            lbl_NameComponent.Text = _nameComponent;

            _countkingComponent.Dock = DockStyle.Fill;
            _CountDamaComponent.Dock = DockStyle.Fill;
            _countTowerComponent.Dock = DockStyle.Fill;
            _countBishopComponent.Dock = DockStyle.Fill;
            _countHorseComponent.Dock = DockStyle.Fill;
            _countPawnComponent.Dock = DockStyle.Fill;

            panel_King.Controls.Add(_countkingComponent);
            panel_Dama.Controls.Add(_CountDamaComponent);
            panel_Tower.Controls.Add(_countTowerComponent);
            panel_Bishop.Controls.Add(_countBishopComponent);
            panel_Horse.Controls.Add(_countHorseComponent);
            panel_Pawn.Controls.Add(_countPawnComponent);
        }

        private void HandlerControl(UserControl control, OperatorType type) {
            var typeControl = control.GetType();
            if (_control.TryGetValue(typeControl, out var component)) {
                switch (type) {
                    case OperatorType.Increment:
                        component.IncrementCount();
                        break;
                    case OperatorType.Decrement:
                        component.DecrementCount();
                        break;                    
                }
            }
        }
    }

    internal enum OperatorType : ushort {
        Increment,
        Decrement
    }
}
