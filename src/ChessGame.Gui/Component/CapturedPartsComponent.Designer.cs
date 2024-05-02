namespace ChessGame.Gui.Component {
    partial class CapturedPartsComponent {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturedPartsComponent));
            System.Reactive.Subjects.Subject<EventArgs> subject_16 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_17 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_18 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_19 = new System.Reactive.Subjects.Subject<EventArgs>();
            System.Reactive.Subjects.Subject<EventArgs> subject_110 = new System.Reactive.Subjects.Subject<EventArgs>();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            damaComponent1 = new Piece.DamaComponent();
            towerComponent1 = new Piece.TowerComponent();
            bishopComponent1 = new Piece.BishopComponent();
            tableLayoutPanel4 = new TableLayoutPanel();
            horseComponent1 = new Piece.HorseComponent();
            pawnComponent1 = new Piece.PawnComponent();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel_SelectPiece = new Panel();
            panel2 = new Panel();
            lbl_NameComponent = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(331, 244);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(325, 140);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(damaComponent1, 0, 0);
            tableLayoutPanel3.Controls.Add(towerComponent1, 1, 0);
            tableLayoutPanel3.Controls.Add(bishopComponent1, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(319, 64);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // damaComponent1
            // 
            damaComponent1.BackColor = Color.Transparent;
            damaComponent1.BackgroundImage = (Image)resources.GetObject("damaComponent1.BackgroundImage");
            damaComponent1.BackgroundImageLayout = ImageLayout.Stretch;
            damaComponent1.Location = new Point(3, 3);
            damaComponent1.Name = "damaComponent1";
            damaComponent1.Size = new Size(73, 58);
            damaComponent1.Subject = subject_16;
            damaComponent1.TabIndex = 0;
            // 
            // towerComponent1
            // 
            towerComponent1.BackColor = Color.Transparent;
            towerComponent1.BackgroundImage = (Image)resources.GetObject("towerComponent1.BackgroundImage");
            towerComponent1.BackgroundImageLayout = ImageLayout.Stretch;
            towerComponent1.Location = new Point(109, 3);
            towerComponent1.Name = "towerComponent1";
            towerComponent1.Size = new Size(73, 58);
            towerComponent1.Subject = subject_17;
            towerComponent1.TabIndex = 1;
            // 
            // bishopComponent1
            // 
            bishopComponent1.BackColor = Color.Transparent;
            bishopComponent1.BackgroundImage = (Image)resources.GetObject("bishopComponent1.BackgroundImage");
            bishopComponent1.BackgroundImageLayout = ImageLayout.Stretch;
            bishopComponent1.Location = new Point(215, 3);
            bishopComponent1.Name = "bishopComponent1";
            bishopComponent1.Size = new Size(73, 58);
            bishopComponent1.Subject = subject_18;
            bishopComponent1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(horseComponent1, 0, 0);
            tableLayoutPanel4.Controls.Add(pawnComponent1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 73);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(319, 64);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // horseComponent1
            // 
            horseComponent1.BackColor = Color.Transparent;
            horseComponent1.BackgroundImage = (Image)resources.GetObject("horseComponent1.BackgroundImage");
            horseComponent1.BackgroundImageLayout = ImageLayout.Stretch;
            horseComponent1.Location = new Point(3, 3);
            horseComponent1.Name = "horseComponent1";
            horseComponent1.Size = new Size(73, 58);
            horseComponent1.Subject = subject_19;
            horseComponent1.TabIndex = 3;
            // 
            // pawnComponent1
            // 
            pawnComponent1.BackColor = Color.Transparent;
            pawnComponent1.BackgroundImage = (Image)resources.GetObject("pawnComponent1.BackgroundImage");
            pawnComponent1.BackgroundImageLayout = ImageLayout.Stretch;
            pawnComponent1.Color = Color.Empty;
            pawnComponent1.Location = new Point(109, 3);
            pawnComponent1.Name = "pawnComponent1";
            pawnComponent1.Size = new Size(73, 58);
            pawnComponent1.Subject = subject_110;
            pawnComponent1.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel5.Controls.Add(panel_SelectPiece, 0, 0);
            tableLayoutPanel5.Controls.Add(panel2, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 149);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(325, 92);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // panel_SelectPiece
            // 
            panel_SelectPiece.Dock = DockStyle.Fill;
            panel_SelectPiece.Location = new Point(3, 3);
            panel_SelectPiece.Name = "panel_SelectPiece";
            panel_SelectPiece.Size = new Size(107, 86);
            panel_SelectPiece.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_NameComponent);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(116, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 86);
            panel2.TabIndex = 1;
            // 
            // lbl_NameComponent
            // 
            lbl_NameComponent.AutoSize = true;
            lbl_NameComponent.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NameComponent.Location = new Point(2, 12);
            lbl_NameComponent.Name = "lbl_NameComponent";
            lbl_NameComponent.Size = new Size(201, 65);
            lbl_NameComponent.TabIndex = 0;
            lbl_NameComponent.Text = "Level 20";
            // 
            // CapturedPartsComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CapturedPartsComponent";
            Size = new Size(331, 244);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Piece.DamaComponent damaComponent1;
        private Piece.TowerComponent towerComponent1;
        private Piece.BishopComponent bishopComponent1;
        private Piece.HorseComponent horseComponent1;
        private Piece.PawnComponent pawnComponent1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel_SelectPiece;
        private Panel panel2;
        private Label lbl_NameComponent;
    }
}
