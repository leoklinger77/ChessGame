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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel__CapturedBlack = new Panel();
            panel_Board = new Panel();
            panel_CapturedWhite = new Panel();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 800F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel__CapturedBlack, 0, 0);
            tableLayoutPanel2.Controls.Add(panel_Board, 1, 0);
            tableLayoutPanel2.Controls.Add(panel_CapturedWhite, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1419, 784);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel__CapturedBlack
            // 
            panel__CapturedBlack.Dock = DockStyle.Top;
            panel__CapturedBlack.Location = new Point(3, 3);
            panel__CapturedBlack.Name = "panel__CapturedBlack";
            panel__CapturedBlack.Size = new Size(303, 242);
            panel__CapturedBlack.TabIndex = 2;
            // 
            // panel_Board
            // 
            panel_Board.Dock = DockStyle.Fill;
            panel_Board.Location = new Point(312, 3);
            panel_Board.Name = "panel_Board";
            panel_Board.Size = new Size(794, 778);
            panel_Board.TabIndex = 0;
            // 
            // panel_CapturedWhite
            // 
            panel_CapturedWhite.Dock = DockStyle.Bottom;
            panel_CapturedWhite.Location = new Point(1112, 539);
            panel_CapturedWhite.Name = "panel_CapturedWhite";
            panel_CapturedWhite.Size = new Size(304, 242);
            panel_CapturedWhite.TabIndex = 1;
            // 
            // ChessGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 784);
            Controls.Add(tableLayoutPanel2);
            Name = "ChessGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Component.BoardComponent boardComponent1;
        private Component.BoardComponent boardComponent2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel_Board;
        private Panel panel__CapturedBlack;
        private Panel panel_CapturedWhite;
    }
}