namespace ChessGame.Gui {
    partial class StartGamerForm {
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            cb_Time = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_Start = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Game Mode";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(211, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "vs Computer";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(125, 36);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(80, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "vs Human";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Time Control";
            // 
            // cb_Time
            // 
            cb_Time.FormattingEnabled = true;
            cb_Time.Items.AddRange(new object[] { "None", "1 Min", "5 Min", "15 Min", "30 Min", "45 Min", "1 Hour", "1:30 Hour", "2:00 Hour", "2:30 Hour", "3:00 Hour" });
            cb_Time.Location = new Point(125, 79);
            cb_Time.Name = "cb_Time";
            cb_Time.Size = new Size(180, 23);
            cb_Time.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "White Pieces";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Black Pieces";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 8;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(88, 222);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(75, 23);
            btn_Start.TabIndex = 9;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // button2
            // 
            button2.Location = new Point(170, 222);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // StartGamerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 265);
            Controls.Add(button2);
            Controls.Add(btn_Start);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_Time);
            Controls.Add(label2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "StartGamerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartGamer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private ComboBox cb_Time;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_Start;
        private Button button2;
    }
}