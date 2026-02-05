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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel_Tower = new Panel();
            panel_Dama = new Panel();
            panel_King = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel_Pawn = new Panel();
            panel_Horse = new Panel();
            panel_Bishop = new Panel();
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
            tableLayoutPanel3.Controls.Add(panel_Tower, 2, 0);
            tableLayoutPanel3.Controls.Add(panel_Dama, 1, 0);
            tableLayoutPanel3.Controls.Add(panel_King, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(319, 64);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel_Tower
            // 
            panel_Tower.Dock = DockStyle.Fill;
            panel_Tower.Location = new Point(215, 3);
            panel_Tower.Name = "panel_Tower";
            panel_Tower.Size = new Size(101, 58);
            panel_Tower.TabIndex = 2;
            // 
            // panel_Dama
            // 
            panel_Dama.Dock = DockStyle.Fill;
            panel_Dama.Location = new Point(109, 3);
            panel_Dama.Name = "panel_Dama";
            panel_Dama.Size = new Size(100, 58);
            panel_Dama.TabIndex = 1;
            // 
            // panel_King
            // 
            panel_King.Dock = DockStyle.Fill;
            panel_King.Location = new Point(3, 3);
            panel_King.Name = "panel_King";
            panel_King.Size = new Size(100, 58);
            panel_King.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(panel_Pawn, 0, 0);
            tableLayoutPanel4.Controls.Add(panel_Horse, 0, 0);
            tableLayoutPanel4.Controls.Add(panel_Bishop, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 73);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(319, 64);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel_Pawn
            // 
            panel_Pawn.Dock = DockStyle.Fill;
            panel_Pawn.Location = new Point(215, 3);
            panel_Pawn.Name = "panel_Pawn";
            panel_Pawn.Size = new Size(101, 58);
            panel_Pawn.TabIndex = 3;
            // 
            // panel_Horse
            // 
            panel_Horse.Dock = DockStyle.Fill;
            panel_Horse.Location = new Point(109, 3);
            panel_Horse.Name = "panel_Horse";
            panel_Horse.Size = new Size(100, 58);
            panel_Horse.TabIndex = 2;
            // 
            // panel_Bishop
            // 
            panel_Bishop.Dock = DockStyle.Fill;
            panel_Bishop.Location = new Point(3, 3);
            panel_Bishop.Name = "panel_Bishop";
            panel_Bishop.Size = new Size(100, 58);
            panel_Bishop.TabIndex = 1;
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
            lbl_NameComponent.Dock = DockStyle.Fill;
            lbl_NameComponent.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NameComponent.Location = new Point(0, 0);
            lbl_NameComponent.Name = "lbl_NameComponent";
            lbl_NameComponent.Size = new Size(206, 86);
            lbl_NameComponent.TabIndex = 0;
            lbl_NameComponent.Text = "You";
            lbl_NameComponent.TextAlign = ContentAlignment.MiddleRight;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel_SelectPiece;
        private Panel panel2;
        private Label lbl_NameComponent;
        private Panel panel_Tower;
        private Panel panel_Dama;
        private Panel panel_King;
        private Panel panel_Pawn;
        private Panel panel_Horse;
        private Panel panel_Bishop;
    }
}
