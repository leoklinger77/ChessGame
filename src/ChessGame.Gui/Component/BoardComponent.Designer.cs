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
            panelLeft.SuspendLayout();
            panelLow.SuspendLayout();
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
    }
}
