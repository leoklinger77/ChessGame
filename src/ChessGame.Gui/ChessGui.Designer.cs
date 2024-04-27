namespace ChessGame.Gui {
    partial class ChessGui {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessGui));
            tableLayoutPanel1 = new TableLayoutPanel();
            boardComponent2 = new Component.BoardComponent(Board);
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            bishopBlackCount = new Component.Piece.BishopComponent();
            damaBlackCount = new Component.Piece.DamaComponent();
            horseBlackCount = new Component.Piece.HorseComponent();
            kingBlackCount = new Component.Piece.KingComponenet();
            towerBlackCount = new Component.Piece.TowerComponent();
            pawnBlackCount = new Component.Piece.PawnComponent();
            groupBox1 = new GroupBox();
            bishopWhiteCount = new Component.Piece.BishopComponent();
            damaWhiteCount = new Component.Piece.DamaComponent();
            horseWhiteCount = new Component.Piece.HorseComponent();
            kingWhiteCount = new Component.Piece.KingComponenet();
            towerWhiteCount = new Component.Piece.TowerComponent();
            pawnWhiteCount = new Component.Piece.PawnComponent();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(boardComponent2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1235, 784);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // boardComponent2
            // 
            boardComponent2.BackColor = Color.Beige;
            boardComponent2.Dock = DockStyle.Fill;
            boardComponent2.Location = new Point(3, 3);
            boardComponent2.Name = "boardComponent2";
            boardComponent2.Size = new Size(858, 778);
            boardComponent2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(867, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 778);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(bishopBlackCount);
            groupBox2.Controls.Add(damaBlackCount);
            groupBox2.Controls.Add(horseBlackCount);
            groupBox2.Controls.Add(kingBlackCount);
            groupBox2.Controls.Add(towerBlackCount);
            groupBox2.Controls.Add(pawnBlackCount);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 211);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pretas";
            // 
            // bishopBlackCount
            // 
            bishopBlackCount.BackColor = Color.Transparent;
            bishopBlackCount.BackgroundImage = (Image)resources.GetObject("bishopBlackCount.BackgroundImage");
            bishopBlackCount.BackgroundImageLayout = ImageLayout.Stretch;
            bishopBlackCount.Location = new Point(142, 118);
            bishopBlackCount.Name = "bishopBlackCount";
            bishopBlackCount.Size = new Size(87, 87);
            bishopBlackCount.TabIndex = 5;
            // 
            // damaBlackCount
            // 
            damaBlackCount.BackColor = Color.Transparent;
            damaBlackCount.BackgroundImage = (Image)resources.GetObject("damaBlackCount.BackgroundImage");
            damaBlackCount.BackgroundImageLayout = ImageLayout.Stretch;
            damaBlackCount.Location = new Point(142, 22);
            damaBlackCount.Name = "damaBlackCount";
            damaBlackCount.Size = new Size(87, 90);
            damaBlackCount.TabIndex = 4;
            // 
            // horseBlackCount
            // 
            horseBlackCount.BackColor = Color.Transparent;
            horseBlackCount.BackgroundImage = (Image)resources.GetObject("horseBlackCount.BackgroundImage");
            horseBlackCount.BackgroundImageLayout = ImageLayout.Stretch;
            horseBlackCount.Location = new Point(252, 118);
            horseBlackCount.Name = "horseBlackCount";
            horseBlackCount.Size = new Size(87, 87);
            horseBlackCount.TabIndex = 3;
            // 
            // kingBlackCount
            // 
            kingBlackCount.BackColor = Color.Transparent;
            kingBlackCount.BackgroundImage = (Image)resources.GetObject("kingBlackCount.BackgroundImage");
            kingBlackCount.BackgroundImageLayout = ImageLayout.Stretch;
            kingBlackCount.Location = new Point(252, 22);
            kingBlackCount.Name = "kingBlackCount";
            kingBlackCount.Size = new Size(87, 90);
            kingBlackCount.TabIndex = 2;
            // 
            // towerBlackCount
            // 
            towerBlackCount.BackColor = Color.Transparent;
            towerBlackCount.BackgroundImage = (Image)resources.GetObject("towerBlackCount.BackgroundImage");
            towerBlackCount.BackgroundImageLayout = ImageLayout.Stretch;
            towerBlackCount.Location = new Point(23, 22);
            towerBlackCount.Name = "towerBlackCount";
            towerBlackCount.Size = new Size(89, 90);
            towerBlackCount.TabIndex = 1;
            // 
            // pawnBlackCount
            // 
            pawnBlackCount.BackColor = Color.Transparent;
            pawnBlackCount.BackgroundImage = (Image)resources.GetObject("pawnBlackCount.BackgroundImage");
            pawnBlackCount.BackgroundImageLayout = ImageLayout.Stretch;
            pawnBlackCount.Color = Color.Empty;
            pawnBlackCount.Location = new Point(23, 118);
            pawnBlackCount.Name = "pawnBlackCount";
            pawnBlackCount.Size = new Size(89, 87);
            pawnBlackCount.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(bishopWhiteCount);
            groupBox1.Controls.Add(damaWhiteCount);
            groupBox1.Controls.Add(horseWhiteCount);
            groupBox1.Controls.Add(kingWhiteCount);
            groupBox1.Controls.Add(towerWhiteCount);
            groupBox1.Controls.Add(pawnWhiteCount);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(3, 567);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Brancas";
            // 
            // bishopWhiteCount
            // 
            bishopWhiteCount.BackColor = Color.Transparent;
            bishopWhiteCount.BackgroundImage = (Image)resources.GetObject("bishopWhiteCount.BackgroundImage");
            bishopWhiteCount.BackgroundImageLayout = ImageLayout.Stretch;
            bishopWhiteCount.Location = new Point(140, 110);
            bishopWhiteCount.Name = "bishopWhiteCount";
            bishopWhiteCount.Size = new Size(87, 87);
            bishopWhiteCount.TabIndex = 11;
            // 
            // damaWhiteCount
            // 
            damaWhiteCount.BackColor = Color.Transparent;
            damaWhiteCount.BackgroundImage = (Image)resources.GetObject("damaWhiteCount.BackgroundImage");
            damaWhiteCount.BackgroundImageLayout = ImageLayout.Stretch;
            damaWhiteCount.Location = new Point(140, 14);
            damaWhiteCount.Name = "damaWhiteCount";
            damaWhiteCount.Size = new Size(87, 90);
            damaWhiteCount.TabIndex = 10;
            // 
            // horseWhiteCount
            // 
            horseWhiteCount.BackColor = Color.Transparent;
            horseWhiteCount.BackgroundImage = (Image)resources.GetObject("horseWhiteCount.BackgroundImage");
            horseWhiteCount.BackgroundImageLayout = ImageLayout.Stretch;
            horseWhiteCount.Location = new Point(250, 110);
            horseWhiteCount.Name = "horseWhiteCount";
            horseWhiteCount.Size = new Size(87, 87);
            horseWhiteCount.TabIndex = 9;
            // 
            // kingWhiteCount
            // 
            kingWhiteCount.BackColor = Color.Transparent;
            kingWhiteCount.BackgroundImage = (Image)resources.GetObject("kingWhiteCount.BackgroundImage");
            kingWhiteCount.BackgroundImageLayout = ImageLayout.Stretch;
            kingWhiteCount.Location = new Point(250, 14);
            kingWhiteCount.Name = "kingWhiteCount";
            kingWhiteCount.Size = new Size(87, 90);
            kingWhiteCount.TabIndex = 8;
            // 
            // towerWhiteCount
            // 
            towerWhiteCount.BackColor = Color.Transparent;
            towerWhiteCount.BackgroundImage = (Image)resources.GetObject("towerWhiteCount.BackgroundImage");
            towerWhiteCount.BackgroundImageLayout = ImageLayout.Stretch;
            towerWhiteCount.Location = new Point(21, 14);
            towerWhiteCount.Name = "towerWhiteCount";
            towerWhiteCount.Size = new Size(89, 90);
            towerWhiteCount.TabIndex = 7;
            // 
            // pawnWhiteCount
            // 
            pawnWhiteCount.BackColor = Color.Transparent;
            pawnWhiteCount.BackgroundImage = (Image)resources.GetObject("pawnWhiteCount.BackgroundImage");
            pawnWhiteCount.BackgroundImageLayout = ImageLayout.Stretch;
            pawnWhiteCount.Color = Color.Empty;
            pawnWhiteCount.Location = new Point(21, 110);
            pawnWhiteCount.Name = "pawnWhiteCount";
            pawnWhiteCount.Size = new Size(89, 87);
            pawnWhiteCount.TabIndex = 6;
            // 
            // ChessGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 784);
            Controls.Add(tableLayoutPanel1);
            Name = "ChessGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Component.BoardComponent boardComponent1;
        private TableLayoutPanel tableLayoutPanel1;
        private Component.BoardComponent boardComponent2;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Component.Piece.BishopComponent bishopBlackCount;
        private Component.Piece.DamaComponent damaBlackCount;
        private Component.Piece.HorseComponent horseBlackCount;
        private Component.Piece.KingComponenet kingBlackCount;
        private Component.Piece.TowerComponent towerBlackCount;
        private Component.Piece.PawnComponent pawnBlackCount;
        private Component.Piece.BishopComponent bishopWhiteCount;
        private Component.Piece.DamaComponent damaWhiteCount;
        private Component.Piece.HorseComponent horseWhiteCount;
        private Component.Piece.KingComponenet kingWhiteCount;
        private Component.Piece.TowerComponent towerWhiteCount;
        private Component.Piece.PawnComponent pawnWhiteCount;
    }
}