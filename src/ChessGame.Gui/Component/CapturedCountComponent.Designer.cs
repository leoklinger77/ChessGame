namespace ChessGame.Gui.Component {
    partial class CapturedCountComponent {
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_Piece = new Panel();
            lbl_Count = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel_Piece, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_Count, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(150, 118);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_Piece
            // 
            panel_Piece.Dock = DockStyle.Fill;
            panel_Piece.Location = new Point(3, 3);
            panel_Piece.Name = "panel_Piece";
            panel_Piece.Size = new Size(99, 112);
            panel_Piece.TabIndex = 0;
            // 
            // label1
            // 
            lbl_Count.AutoSize = true;
            lbl_Count.Dock = DockStyle.Bottom;
            lbl_Count.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Count.Location = new Point(108, 81);
            lbl_Count.Name = "lbl_Count";
            lbl_Count.Size = new Size(39, 37);
            lbl_Count.TabIndex = 1;
            lbl_Count.Text = "0";
            lbl_Count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CapturedCountComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CapturedCountComponent";
            Size = new Size(150, 118);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_Piece;
        private Label lbl_Count;
    }
}
