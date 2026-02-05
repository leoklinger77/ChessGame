namespace ChessGame.Gui {
    using System.Reactive.Subjects;

    public partial class StartGamerForm : Form {
        public ISubject<TimeSpan> SubjectTime = new Subject<TimeSpan>();
        public StartGamerForm() {
            InitializeComponent();

            cb_Time.SelectedIndex = 0;
        }

        private void btn_Start_Click(object sender, EventArgs e) {
            switch (cb_Time.SelectedIndex) {
                case 1:
                    SubjectTime.OnNext(TimeSpan.FromMinutes(1));
                    break;
                case 2:
                    SubjectTime.OnNext(TimeSpan.FromMinutes(5));
                    break;
                case 3:
                    SubjectTime.OnNext(TimeSpan.FromMinutes(15));
                    break;
                case 4:
                    SubjectTime.OnNext(TimeSpan.FromMinutes(30));
                    break;
                case 5:
                    SubjectTime.OnNext(TimeSpan.FromMinutes(45));
                    break;
                case 6:
                    SubjectTime.OnNext(TimeSpan.FromMinutes(60));
                    break;
                case 7:
                    SubjectTime.OnNext(TimeSpan.FromHours(1.5));
                    break;
                case 8:
                    SubjectTime.OnNext(TimeSpan.FromHours(2));
                    break;
                case 9:
                    SubjectTime.OnNext(TimeSpan.FromHours(2.5));
                    break;
                case 10:
                    SubjectTime.OnNext(TimeSpan.FromHours(3));
                    break;
                default:
                    break;
            }


            this.Close();
        }
    }
}
