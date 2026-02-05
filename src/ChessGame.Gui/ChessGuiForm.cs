namespace ChessGame.Gui {
    using ChessGame.Gui.Component;
    using ChessGamer.Services;
    using System.Reactive.Linq;
    using System.Reactive.Subjects;
    using System.Threading;
    using Timer = System.Timers.Timer;

    public partial class ChessGuiForm : Form {
        private readonly Board _board;
        private readonly BoardComponent _boardComponent;
        private readonly CapturedPartsComponent _capturedWhiteComponent;
        private readonly CapturedPartsComponent _capturedBlackComponent;
        private readonly SynchronizationContext _synchronizationContext;

        private ISubject<bool> InitializeGamer;

        private bool _whitesTurn = true;
        private Timer _gameTimer;
        private TimeSpan _gameTimerSpan;
        private double _totalTimeWhite = 0;
        private double _totalTimeBlack = 0;
        public ChessGuiForm() {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;

            _board = new Board();
            _board.SubjectPlay.ObserveOn(_synchronizationContext).Subscribe(WhoToPlay);


            InitializeGamer = new Subject<bool>();
            _capturedWhiteComponent = new CapturedPartsComponent("You");
            _capturedBlackComponent = new CapturedPartsComponent("Robot");
            _boardComponent = new BoardComponent(_board, _capturedWhiteComponent, _capturedBlackComponent, InitializeGamer);

            Initialize();
        }

        private void WhoToPlay(ConsoleColor color) {
            switch (color) {
                case ConsoleColor.Yellow:
                    _whitesTurn = false;
                    lbl_Play.Text = $"Black Play";
                    break;
                case ConsoleColor.White:
                    _whitesTurn = true;
                    lbl_Play.Text = $"{color} Play";
                    break;
            }
        }

        private void Initialize() {
            this.BackColor = Color.Peru;

            _boardComponent.Dock = DockStyle.Fill;
            panel_Board.Controls.Add(_boardComponent);

            _capturedWhiteComponent.BackColor = Color.Beige;
            _capturedWhiteComponent.Dock = DockStyle.Bottom;
            _capturedWhiteComponent.SetInitializePiece(Color.Black);
            panel_CapturedWhite.Controls.Add(_capturedWhiteComponent);

            _capturedBlackComponent.BackColor = Color.Beige;
            _capturedBlackComponent.Dock = DockStyle.Top;
            _capturedBlackComponent.SetInitializePiece(Color.White);
            panel__CapturedBlack.Controls.Add(_capturedBlackComponent);
        }

        private void btn_NewGamer_Click(object sender, EventArgs e) {
            StartGamerForm form = new StartGamerForm();
            form.SubjectTime.ObserveOn(_synchronizationContext).Subscribe(SetTimeGamer);
            form.Show();
        }

        private void SetTimeGamer(TimeSpan span) {
            _gameTimerSpan = span;
            InitializeGamer.OnNext(true);

            lbl_TimeBlack.Text = _gameTimerSpan.ToString();
            lbl_TimeWhite.Text = _gameTimerSpan.ToString();

            _gameTimer = new Timer(span.TotalSeconds * 2);


            _gameTimer.Interval = 1000;

            _gameTimer.Elapsed += (x, y) => {
                if (_whitesTurn) {
                    var time = TimeSpan.FromSeconds(_gameTimerSpan.TotalSeconds - _totalTimeWhite);
                    _totalTimeWhite++;
                    _synchronizationContext.Post((x) => {
                        lbl_TimeWhite.Text = time.ToString();
                    }, null);
                    if (time.TotalSeconds == 0) {
                        _gameTimer.Stop();
                        InitializeGamer.OnNext(false);
                        MessageBox.Show("As brancas perdem o jogo");
                    }
                } else {
                    var time = TimeSpan.FromSeconds(_gameTimerSpan.TotalSeconds - _totalTimeBlack);
                    _totalTimeBlack++;
                    _synchronizationContext.Post((x) => {
                        lbl_TimeBlack.Text = time.ToString();
                    }, null);
                    if (time.TotalSeconds == 0) {
                        _gameTimer.Stop();
                        InitializeGamer.OnNext(false);
                        MessageBox.Show("As pretas perdem o jogo");
                    }
                }
            };
            _gameTimer.Start();
        }
    }
}
