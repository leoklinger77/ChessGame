using ChessGame.Gui.Component.Piece;

namespace ChessGame.Gui.Component {
    partial class BoardComponent {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardComponent));
            System.Reactive.Subjects.Subject<EventArgs> subject_11 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_12 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_13 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_14 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_15 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_16 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_17 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_18 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_19 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_110 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_111 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_112 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_113 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_114 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_115 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_116 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_117 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_118 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_119 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_120 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_121 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_122 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_123 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_124 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_125 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_126 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_127 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_128 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_129 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_130 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_131 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_132 = new System.Reactive.Subjects.Subject<EventArgs>();
            panelLeft = new TableLayoutPanel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panelLow = new TableLayoutPanel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelChess = new TableLayoutPanel();
            pawnA2 = new PawnComponent();
            pawnB2 = new PawnComponent();
            pawnC2 = new PawnComponent();
            pawnD2 = new PawnComponent();
            pawnF2 = new PawnComponent();
            pawnG2 = new PawnComponent();
            pawnH7 = new PawnComponent();
            pawnG7 = new PawnComponent();
            pawnF7 = new PawnComponent();
            pawnE7 = new PawnComponent();
            pawnD7 = new PawnComponent();
            pawnB7 = new PawnComponent();
            pawnC7 = new PawnComponent();
            pawnA7 = new PawnComponent();
            kingE8 = new KingComponenet();
            kingE1 = new KingComponenet();
            bishopF1 = new BishopComponent();
            bishopC1 = new BishopComponent();
            bishopF8 = new BishopComponent();
            bishopC8 = new BishopComponent();
            horseG8 = new HorseComponent();
            horseB8 = new HorseComponent();
            horseG1 = new HorseComponent();
            horseB1 = new HorseComponent();
            towerH8 = new TowerComponent();
            towerA8 = new TowerComponent();
            towerH1 = new TowerComponent();
            towerA1 = new TowerComponent();
            damaD8 = new DamaComponent();
            damaD1 = new DamaComponent();
            pawnH2 = new PawnComponent();
            pawnE2 = new PawnComponent();
            panelLeft.SuspendLayout();
            panelLow.SuspendLayout();
            panelChess.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelLeft.ColumnCount = 1;
            panelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLeft.Controls.Add(label16, 0, 7);
            panelLeft.Controls.Add(label15, 0, 6);
            panelLeft.Controls.Add(label14, 0, 5);
            panelLeft.Controls.Add(label13, 0, 4);
            panelLeft.Controls.Add(label12, 0, 3);
            panelLeft.Controls.Add(label11, 0, 2);
            panelLeft.Controls.Add(label10, 0, 1);
            panelLeft.Controls.Add(label9, 0, 0);
            panelLeft.Location = new Point(1, 1);
            panelLeft.Name = "panelLeft";
            panelLeft.RowCount = 8;
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLeft.Size = new Size(34, 727);
            panelLeft.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(3, 630);
            label16.Name = "label16";
            label16.Size = new Size(28, 97);
            label16.TabIndex = 7;
            label16.Text = "1";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(3, 540);
            label15.Name = "label15";
            label15.Size = new Size(28, 90);
            label15.TabIndex = 6;
            label15.Text = "2";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(3, 450);
            label14.Name = "label14";
            label14.Size = new Size(28, 90);
            label14.TabIndex = 5;
            label14.Text = "3";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 360);
            label13.Name = "label13";
            label13.Size = new Size(28, 90);
            label13.TabIndex = 4;
            label13.Text = "4";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(3, 270);
            label12.Name = "label12";
            label12.Size = new Size(28, 90);
            label12.TabIndex = 3;
            label12.Text = "5";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 180);
            label11.Name = "label11";
            label11.Size = new Size(28, 90);
            label11.TabIndex = 2;
            label11.Text = "6";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 90);
            label10.Name = "label10";
            label10.Size = new Size(28, 90);
            label10.TabIndex = 1;
            label10.Text = "7";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(28, 90);
            label9.TabIndex = 0;
            label9.Text = "8";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLow
            // 
            panelLow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLow.ColumnCount = 8;
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelLow.Controls.Add(label8, 0, 0);
            panelLow.Controls.Add(label7, 0, 0);
            panelLow.Controls.Add(label6, 0, 0);
            panelLow.Controls.Add(label5, 0, 0);
            panelLow.Controls.Add(label4, 0, 0);
            panelLow.Controls.Add(label3, 0, 0);
            panelLow.Controls.Add(label2, 0, 0);
            panelLow.Controls.Add(label1, 0, 0);
            panelLow.Location = new Point(34, 728);
            panelLow.Name = "panelLow";
            panelLow.RowCount = 1;
            panelLow.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLow.Size = new Size(841, 29);
            panelLow.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(528, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 29);
            label8.TabIndex = 7;
            label8.Text = "F";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(423, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 29);
            label7.TabIndex = 6;
            label7.Text = "E";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(738, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 29);
            label6.TabIndex = 5;
            label6.Text = "H";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(633, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 29);
            label5.TabIndex = 4;
            label5.Text = "G";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(108, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 29);
            label4.TabIndex = 3;
            label4.Text = "B";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 2;
            label3.Text = "A";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(318, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 29);
            label2.TabIndex = 1;
            label2.Text = "D";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(213, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 29);
            label1.TabIndex = 0;
            label1.Text = "C";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelChess
            // 
            panelChess.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChess.ColumnCount = 8;
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelChess.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelChess.Controls.Add(pawnA2, 0, 6);
            panelChess.Controls.Add(pawnB2, 1, 6);
            panelChess.Controls.Add(pawnC2, 2, 6);
            panelChess.Controls.Add(pawnD2, 3, 6);
            panelChess.Controls.Add(pawnF2, 5, 6);
            panelChess.Controls.Add(pawnG2, 6, 6);
            panelChess.Controls.Add(pawnH7, 7, 1);
            panelChess.Controls.Add(pawnG7, 6, 1);
            panelChess.Controls.Add(pawnF7, 5, 1);
            panelChess.Controls.Add(pawnE7, 4, 1);
            panelChess.Controls.Add(pawnD7, 3, 1);
            panelChess.Controls.Add(pawnB7, 1, 1);
            panelChess.Controls.Add(pawnC7, 2, 1);
            panelChess.Controls.Add(pawnA7, 0, 1);
            panelChess.Controls.Add(kingE8, 4, 0);
            panelChess.Controls.Add(kingE1, 4, 7);
            panelChess.Controls.Add(bishopF1, 5, 7);
            panelChess.Controls.Add(bishopC1, 2, 7);
            panelChess.Controls.Add(bishopF8, 5, 0);
            panelChess.Controls.Add(bishopC8, 2, 0);
            panelChess.Controls.Add(horseG8, 6, 0);
            panelChess.Controls.Add(horseB8, 1, 0);
            panelChess.Controls.Add(horseG1, 6, 7);
            panelChess.Controls.Add(horseB1, 1, 7);
            panelChess.Controls.Add(towerH8, 7, 0);
            panelChess.Controls.Add(towerA8, 0, 0);
            panelChess.Controls.Add(towerH1, 7, 7);
            panelChess.Controls.Add(towerA1, 0, 7);
            panelChess.Controls.Add(damaD8, 3, 0);
            panelChess.Controls.Add(damaD1, 3, 7);
            panelChess.Controls.Add(pawnH2, 7, 6);
            panelChess.Controls.Add(pawnE2, 4, 6);
            panelChess.Location = new Point(34, 1);
            panelChess.Name = "panelChess";
            panelChess.RowCount = 8;
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelChess.Size = new Size(841, 727);
            panelChess.TabIndex = 7;
            panelChess.CellPaint += chessBoard_CellPaint;
            panelChess.MouseClick += panelChess_Click;
            // 
            // pawnA2
            // 
            pawnA2.BackColor = Color.Transparent;
            pawnA2.BackgroundImage = (Image)resources.GetObject("pawnA2.BackgroundImage");
            pawnA2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnA2.Color = Color.Empty;
            pawnA2.Location = new Point(3, 543);
            pawnA2.Name = "pawnA2";
            pawnA2.Size = new Size(99, 84);
            pawnA2.Subject = subject_11;
            pawnA2.TabIndex = 2;
            // 
            // pawnB2
            // 
            pawnB2.BackColor = Color.Transparent;
            pawnB2.BackgroundImage = (Image)resources.GetObject("pawnB2.BackgroundImage");
            pawnB2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnB2.Color = Color.Empty;
            pawnB2.Location = new Point(108, 543);
            pawnB2.Name = "pawnB2";
            pawnB2.Size = new Size(99, 84);
            pawnB2.Subject = subject_12;
            pawnB2.TabIndex = 3;
            // 
            // pawnC2
            // 
            pawnC2.BackColor = Color.Transparent;
            pawnC2.BackgroundImage = (Image)resources.GetObject("pawnC2.BackgroundImage");
            pawnC2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnC2.Color = Color.Empty;
            pawnC2.Location = new Point(213, 543);
            pawnC2.Name = "pawnC2";
            pawnC2.Size = new Size(99, 84);
            pawnC2.Subject = subject_13;
            pawnC2.TabIndex = 4;
            // 
            // pawnD2
            // 
            pawnD2.BackColor = Color.Transparent;
            pawnD2.BackgroundImage = (Image)resources.GetObject("pawnD2.BackgroundImage");
            pawnD2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnD2.Color = Color.Empty;
            pawnD2.Location = new Point(318, 543);
            pawnD2.Name = "pawnD2";
            pawnD2.Size = new Size(99, 84);
            pawnD2.Subject = subject_14;
            pawnD2.TabIndex = 5;
            // 
            // pawnF2
            // 
            pawnF2.BackColor = Color.Transparent;
            pawnF2.BackgroundImage = (Image)resources.GetObject("pawnF2.BackgroundImage");
            pawnF2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnF2.Color = Color.Empty;
            pawnF2.Location = new Point(528, 543);
            pawnF2.Name = "pawnF2";
            pawnF2.Size = new Size(99, 84);
            pawnF2.Subject = subject_15;
            pawnF2.TabIndex = 7;
            // 
            // pawnG2
            // 
            pawnG2.BackColor = Color.Transparent;
            pawnG2.BackgroundImage = (Image)resources.GetObject("pawnG2.BackgroundImage");
            pawnG2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnG2.Color = Color.Empty;
            pawnG2.Location = new Point(633, 543);
            pawnG2.Name = "pawnG2";
            pawnG2.Size = new Size(99, 84);
            pawnG2.Subject = subject_16;
            pawnG2.TabIndex = 8;
            // 
            // pawnH7
            // 
            pawnH7.BackColor = Color.Transparent;
            pawnH7.BackgroundImage = (Image)resources.GetObject("pawnH7.BackgroundImage");
            pawnH7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnH7.Color = Color.Empty;
            pawnH7.Location = new Point(738, 93);
            pawnH7.Name = "pawnH7";
            pawnH7.Size = new Size(100, 84);
            pawnH7.Subject = subject_17;
            pawnH7.TabIndex = 10;
            // 
            // pawnG7
            // 
            pawnG7.BackColor = Color.Transparent;
            pawnG7.BackgroundImage = (Image)resources.GetObject("pawnG7.BackgroundImage");
            pawnG7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnG7.Color = Color.Empty;
            pawnG7.Location = new Point(633, 93);
            pawnG7.Name = "pawnG7";
            pawnG7.Size = new Size(99, 84);
            pawnG7.Subject = subject_18;
            pawnG7.TabIndex = 11;
            // 
            // pawnF7
            // 
            pawnF7.BackColor = Color.Transparent;
            pawnF7.BackgroundImage = (Image)resources.GetObject("pawnF7.BackgroundImage");
            pawnF7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnF7.Color = Color.Empty;
            pawnF7.Location = new Point(528, 93);
            pawnF7.Name = "pawnF7";
            pawnF7.Size = new Size(99, 84);
            pawnF7.Subject = subject_19;
            pawnF7.TabIndex = 12;
            // 
            // pawnE7
            // 
            pawnE7.BackColor = Color.Transparent;
            pawnE7.BackgroundImage = (Image)resources.GetObject("pawnE7.BackgroundImage");
            pawnE7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnE7.Color = Color.Empty;
            pawnE7.Location = new Point(423, 93);
            pawnE7.Name = "pawnE7";
            pawnE7.Size = new Size(99, 84);
            pawnE7.Subject = subject_110;
            pawnE7.TabIndex = 13;
            // 
            // pawnD7
            // 
            pawnD7.BackColor = Color.Transparent;
            pawnD7.BackgroundImage = (Image)resources.GetObject("pawnD7.BackgroundImage");
            pawnD7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnD7.Color = Color.Empty;
            pawnD7.Location = new Point(318, 93);
            pawnD7.Name = "pawnD7";
            pawnD7.Size = new Size(99, 84);
            pawnD7.Subject = subject_111;
            pawnD7.TabIndex = 14;
            // 
            // pawnB7
            // 
            pawnB7.BackColor = Color.Transparent;
            pawnB7.BackgroundImage = (Image)resources.GetObject("pawnB7.BackgroundImage");
            pawnB7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnB7.Color = Color.Empty;
            pawnB7.Location = new Point(108, 93);
            pawnB7.Name = "pawnB7";
            pawnB7.Size = new Size(99, 84);
            pawnB7.Subject = subject_112;
            pawnB7.TabIndex = 15;
            // 
            // pawnC7
            // 
            pawnC7.BackColor = Color.Transparent;
            pawnC7.BackgroundImage = (Image)resources.GetObject("pawnC7.BackgroundImage");
            pawnC7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnC7.Color = Color.Empty;
            pawnC7.Location = new Point(213, 93);
            pawnC7.Name = "pawnC7";
            pawnC7.Size = new Size(99, 84);
            pawnC7.Subject = subject_113;
            pawnC7.TabIndex = 16;
            // 
            // pawnA7
            // 
            pawnA7.BackColor = Color.Transparent;
            pawnA7.BackgroundImage = (Image)resources.GetObject("pawnA7.BackgroundImage");
            pawnA7.BackgroundImageLayout = ImageLayout.Stretch;
            pawnA7.Color = Color.Empty;
            pawnA7.Location = new Point(3, 93);
            pawnA7.Name = "pawnA7";
            pawnA7.Size = new Size(99, 84);
            pawnA7.Subject = subject_114;
            pawnA7.TabIndex = 17;
            // 
            // kingE8
            // 
            kingE8.BackColor = Color.Transparent;
            kingE8.BackgroundImage = (Image)resources.GetObject("kingE8.BackgroundImage");
            kingE8.BackgroundImageLayout = ImageLayout.Stretch;
            kingE8.Location = new Point(423, 3);
            kingE8.Name = "kingE8";
            kingE8.Size = new Size(99, 84);
            kingE8.Subject = subject_115;
            kingE8.TabIndex = 18;
            // 
            // kingE1
            // 
            kingE1.BackColor = Color.Transparent;
            kingE1.BackgroundImage = (Image)resources.GetObject("kingE1.BackgroundImage");
            kingE1.BackgroundImageLayout = ImageLayout.Stretch;
            kingE1.Location = new Point(423, 633);
            kingE1.Name = "kingE1";
            kingE1.Size = new Size(99, 91);
            kingE1.Subject = subject_116;
            kingE1.TabIndex = 19;
            // 
            // bishopF1
            // 
            bishopF1.BackColor = Color.Transparent;
            bishopF1.BackgroundImage = (Image)resources.GetObject("bishopF1.BackgroundImage");
            bishopF1.BackgroundImageLayout = ImageLayout.Stretch;
            bishopF1.Location = new Point(528, 633);
            bishopF1.Name = "bishopF1";
            bishopF1.Size = new Size(99, 91);
            bishopF1.Subject = subject_117;
            bishopF1.TabIndex = 20;
            // 
            // bishopC1
            // 
            bishopC1.BackColor = Color.Transparent;
            bishopC1.BackgroundImage = (Image)resources.GetObject("bishopC1.BackgroundImage");
            bishopC1.BackgroundImageLayout = ImageLayout.Stretch;
            bishopC1.Location = new Point(213, 633);
            bishopC1.Name = "bishopC1";
            bishopC1.Size = new Size(99, 91);
            bishopC1.Subject = subject_118;
            bishopC1.TabIndex = 21;
            // 
            // bishopF8
            // 
            bishopF8.BackColor = Color.Transparent;
            bishopF8.BackgroundImage = (Image)resources.GetObject("bishopF8.BackgroundImage");
            bishopF8.BackgroundImageLayout = ImageLayout.Stretch;
            bishopF8.Location = new Point(528, 3);
            bishopF8.Name = "bishopF8";
            bishopF8.Size = new Size(99, 84);
            bishopF8.Subject = subject_119;
            bishopF8.TabIndex = 22;
            // 
            // bishopC8
            // 
            bishopC8.BackColor = Color.Transparent;
            bishopC8.BackgroundImage = (Image)resources.GetObject("bishopC8.BackgroundImage");
            bishopC8.BackgroundImageLayout = ImageLayout.Stretch;
            bishopC8.Location = new Point(213, 3);
            bishopC8.Name = "bishopC8";
            bishopC8.Size = new Size(99, 84);
            bishopC8.Subject = subject_120;
            bishopC8.TabIndex = 23;
            // 
            // horseG8
            // 
            horseG8.BackColor = Color.Transparent;
            horseG8.BackgroundImage = (Image)resources.GetObject("horseG8.BackgroundImage");
            horseG8.BackgroundImageLayout = ImageLayout.Stretch;
            horseG8.Location = new Point(633, 3);
            horseG8.Name = "horseG8";
            horseG8.Size = new Size(99, 84);
            horseG8.Subject = subject_121;
            horseG8.TabIndex = 24;
            // 
            // horseB8
            // 
            horseB8.BackColor = Color.Transparent;
            horseB8.BackgroundImage = (Image)resources.GetObject("horseB8.BackgroundImage");
            horseB8.BackgroundImageLayout = ImageLayout.Stretch;
            horseB8.Location = new Point(108, 3);
            horseB8.Name = "horseB8";
            horseB8.Size = new Size(99, 84);
            horseB8.Subject = subject_122;
            horseB8.TabIndex = 25;
            // 
            // horseG1
            // 
            horseG1.BackColor = Color.Transparent;
            horseG1.BackgroundImage = (Image)resources.GetObject("horseG1.BackgroundImage");
            horseG1.BackgroundImageLayout = ImageLayout.Stretch;
            horseG1.Location = new Point(633, 633);
            horseG1.Name = "horseG1";
            horseG1.Size = new Size(99, 91);
            horseG1.Subject = subject_123;
            horseG1.TabIndex = 26;
            // 
            // horseB1
            // 
            horseB1.BackColor = Color.Transparent;
            horseB1.BackgroundImage = (Image)resources.GetObject("horseB1.BackgroundImage");
            horseB1.BackgroundImageLayout = ImageLayout.Stretch;
            horseB1.Location = new Point(108, 633);
            horseB1.Name = "horseB1";
            horseB1.Size = new Size(99, 91);
            horseB1.Subject = subject_124;
            horseB1.TabIndex = 27;
            // 
            // towerH8
            // 
            towerH8.BackColor = Color.Transparent;
            towerH8.BackgroundImage = (Image)resources.GetObject("towerH8.BackgroundImage");
            towerH8.BackgroundImageLayout = ImageLayout.Stretch;
            towerH8.Location = new Point(738, 3);
            towerH8.Name = "towerH8";
            towerH8.Size = new Size(100, 84);
            towerH8.Subject = subject_125;
            towerH8.TabIndex = 28;
            // 
            // towerA8
            // 
            towerA8.BackColor = Color.Transparent;
            towerA8.BackgroundImage = (Image)resources.GetObject("towerA8.BackgroundImage");
            towerA8.BackgroundImageLayout = ImageLayout.Stretch;
            towerA8.Location = new Point(3, 3);
            towerA8.Name = "towerA8";
            towerA8.Size = new Size(99, 84);
            towerA8.Subject = subject_126;
            towerA8.TabIndex = 29;
            // 
            // towerH1
            // 
            towerH1.BackColor = Color.Transparent;
            towerH1.BackgroundImage = (Image)resources.GetObject("towerH1.BackgroundImage");
            towerH1.BackgroundImageLayout = ImageLayout.Stretch;
            towerH1.Location = new Point(738, 633);
            towerH1.Name = "towerH1";
            towerH1.Size = new Size(100, 91);
            towerH1.Subject = subject_127;
            towerH1.TabIndex = 30;
            // 
            // towerA1
            // 
            towerA1.BackColor = Color.Transparent;
            towerA1.BackgroundImage = (Image)resources.GetObject("towerA1.BackgroundImage");
            towerA1.BackgroundImageLayout = ImageLayout.Stretch;
            towerA1.Location = new Point(3, 633);
            towerA1.Name = "towerA1";
            towerA1.Size = new Size(99, 91);
            towerA1.Subject = subject_128;
            towerA1.TabIndex = 31;
            // 
            // damaD8
            // 
            damaD8.BackColor = Color.Transparent;
            damaD8.BackgroundImage = (Image)resources.GetObject("damaD8.BackgroundImage");
            damaD8.BackgroundImageLayout = ImageLayout.Stretch;
            damaD8.Location = new Point(318, 3);
            damaD8.Name = "damaD8";
            damaD8.Size = new Size(99, 84);
            damaD8.Subject = subject_129;
            damaD8.TabIndex = 32;
            // 
            // damaD1
            // 
            damaD1.BackColor = Color.Transparent;
            damaD1.BackgroundImage = (Image)resources.GetObject("damaD1.BackgroundImage");
            damaD1.BackgroundImageLayout = ImageLayout.Stretch;
            damaD1.Location = new Point(318, 633);
            damaD1.Name = "damaD1";
            damaD1.Size = new Size(99, 91);
            damaD1.Subject = subject_130;
            damaD1.TabIndex = 33;
            // 
            // pawnH2
            // 
            pawnH2.BackColor = Color.Transparent;
            pawnH2.BackgroundImage = (Image)resources.GetObject("pawnH2.BackgroundImage");
            pawnH2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnH2.Color = Color.Empty;
            pawnH2.Location = new Point(738, 543);
            pawnH2.Name = "pawnH2";
            pawnH2.Size = new Size(100, 84);
            pawnH2.Subject = subject_131;
            pawnH2.TabIndex = 9;
            // 
            // pawnE2
            // 
            pawnE2.BackColor = Color.Transparent;
            pawnE2.BackgroundImage = (Image)resources.GetObject("pawnE2.BackgroundImage");
            pawnE2.BackgroundImageLayout = ImageLayout.Stretch;
            pawnE2.Color = Color.Empty;
            pawnE2.Location = new Point(423, 543);
            pawnE2.Name = "pawnE2";
            pawnE2.Size = new Size(99, 84);
            pawnE2.Subject = subject_132;
            pawnE2.TabIndex = 6;
            // 
            // BoardComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            Controls.Add(panelLeft);
            Controls.Add(panelLow);
            Controls.Add(panelChess);
            Name = "BoardComponent";
            Size = new Size(876, 757);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelLow.ResumeLayout(false);
            panelLow.PerformLayout();
            panelChess.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel panelLeft;
        private TableLayoutPanel panelLow;
        private TableLayoutPanel panelChess;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private PawnComponent pawnA2;
        private PawnComponent pawnB2;
        private PawnComponent pawnC2;
        private PawnComponent pawnD2;
        private PawnComponent pawnE2;
        private PawnComponent pawnF2;
        private PawnComponent pawnG2;
        private PawnComponent pawnH2;
        private PawnComponent pawnH7;
        private PawnComponent pawnG7;
        private PawnComponent pawnF7;
        private PawnComponent pawnE7;
        private PawnComponent pawnD7;
        private PawnComponent pawnB7;
        private PawnComponent pawnC7;
        private PawnComponent pawnA7;
        private KingComponenet kingE8;
        private KingComponenet kingE1;
        private BishopComponent bishopF1;
        private BishopComponent bishopC1;
        private BishopComponent bishopF8;
        private BishopComponent bishopC8;
        private HorseComponent horseG8;
        private HorseComponent horseB8;
        private HorseComponent horseG1;
        private HorseComponent horseB1;
        private TowerComponent towerH8;
        private TowerComponent towerA8;
        private TowerComponent towerH1;
        private TowerComponent towerA1;
        private DamaComponent damaD8;
        private DamaComponent damaD1;
    }
}
