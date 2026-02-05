namespace ChessGame.Gui {
    partial class ChessGuiForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessGuiForm));
            tableLayoutPanel2 = new TableLayoutPanel();
            panel__CapturedBlack = new Panel();
            lbl_Play = new Label();
            lbl_TimeBlack = new Label();
            panel_Board = new Panel();
            panel_CapturedWhite = new Panel();
            lbl_TimeWhite = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_ToGoBack = new Button();
            btn_Advence = new Button();
            btn_NewGamer = new Button();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel2.SuspendLayout();
            panel__CapturedBlack.SuspendLayout();
            panel_CapturedWhite.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            panel__CapturedBlack.Controls.Add(lbl_Play);
            panel__CapturedBlack.Controls.Add(lbl_TimeBlack);
            panel__CapturedBlack.Dock = DockStyle.Fill;
            panel__CapturedBlack.Location = new Point(3, 3);
            panel__CapturedBlack.Name = "panel__CapturedBlack";
            panel__CapturedBlack.Size = new Size(303, 778);
            panel__CapturedBlack.TabIndex = 2;
            // 
            // lbl_Play
            // 
            lbl_Play.AutoSize = true;
            lbl_Play.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Play.Location = new Point(67, 727);
            lbl_Play.Name = "lbl_Play";
            lbl_Play.Size = new Size(170, 45);
            lbl_Play.TabIndex = 4;
            lbl_Play.Text = "White Play";
            // 
            // lbl_TimeBlack
            // 
            lbl_TimeBlack.AutoSize = true;
            lbl_TimeBlack.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TimeBlack.Location = new Point(86, 253);
            lbl_TimeBlack.Name = "lbl_TimeBlack";
            lbl_TimeBlack.Size = new Size(136, 45);
            lbl_TimeBlack.TabIndex = 3;
            lbl_TimeBlack.Text = "00:00:00";
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
            panel_CapturedWhite.Controls.Add(lbl_TimeWhite);
            panel_CapturedWhite.Controls.Add(tableLayoutPanel1);
            panel_CapturedWhite.Controls.Add(btn_NewGamer);
            panel_CapturedWhite.Dock = DockStyle.Fill;
            panel_CapturedWhite.Location = new Point(1112, 3);
            panel_CapturedWhite.Name = "panel_CapturedWhite";
            panel_CapturedWhite.Size = new Size(304, 778);
            panel_CapturedWhite.TabIndex = 1;
            // 
            // lbl_TimeWhite
            // 
            lbl_TimeWhite.AutoSize = true;
            lbl_TimeWhite.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TimeWhite.Location = new Point(85, 488);
            lbl_TimeWhite.Name = "lbl_TimeWhite";
            lbl_TimeWhite.Size = new Size(136, 45);
            lbl_TimeWhite.TabIndex = 2;
            lbl_TimeWhite.Text = "00:00:00";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 311);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(298, 115);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btn_ToGoBack, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_Advence, 1, 0);
            tableLayoutPanel3.Controls.Add(button1, 2, 0);
            tableLayoutPanel3.Controls.Add(button2, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 60);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(292, 52);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_ToGoBack
            // 
            btn_ToGoBack.BackgroundImage = (Image)resources.GetObject("btn_ToGoBack.BackgroundImage");
            btn_ToGoBack.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ToGoBack.Location = new Point(0, 0);
            btn_ToGoBack.Margin = new Padding(0);
            btn_ToGoBack.Name = "btn_ToGoBack";
            btn_ToGoBack.Size = new Size(73, 52);
            btn_ToGoBack.TabIndex = 1;
            btn_ToGoBack.UseVisualStyleBackColor = true;
            // 
            // btn_Advence
            // 
            btn_Advence.BackgroundImage = (Image)resources.GetObject("btn_Advence.BackgroundImage");
            btn_Advence.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Advence.Location = new Point(73, 0);
            btn_Advence.Margin = new Padding(0);
            btn_Advence.Name = "btn_Advence";
            btn_Advence.Size = new Size(73, 52);
            btn_Advence.TabIndex = 2;
            btn_Advence.UseVisualStyleBackColor = true;
            // 
            // btn_NewGamer
            // 
            btn_NewGamer.Location = new Point(101, 155);
            btn_NewGamer.Name = "btn_NewGamer";
            btn_NewGamer.Size = new Size(110, 44);
            btn_NewGamer.TabIndex = 0;
            btn_NewGamer.Text = "New Gamer";
            btn_NewGamer.UseVisualStyleBackColor = true;
            btn_NewGamer.Click += btn_NewGamer_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(146, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(73, 52);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(219, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(73, 52);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // ChessGuiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 784);
            Controls.Add(tableLayoutPanel2);
            Name = "ChessGuiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            tableLayoutPanel2.ResumeLayout(false);
            panel__CapturedBlack.ResumeLayout(false);
            panel__CapturedBlack.PerformLayout();
            panel_CapturedWhite.ResumeLayout(false);
            panel_CapturedWhite.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Component.BoardComponent boardComponent1;
        private Component.BoardComponent boardComponent2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel_Board;
        private Panel panel__CapturedBlack;
        private Panel panel_CapturedWhite;
        private Button btn_NewGamer;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_ToGoBack;
        private Button btn_Advence;
        private Label lbl_TimeWhite;
        private Label lbl_TimeBlack;
        private Label lbl_Play;
        private Button button1;
        private Button button2;
    }
}