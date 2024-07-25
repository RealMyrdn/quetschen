namespace quetschen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 13);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Zu komprimierender Text.";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(377, 423);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(677, 443);
            button1.Name = "button1";
            button1.Size = new Size(95, 24);
            button1.TabIndex = 1;
            button1.Text = "komprimieren";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(397, 13);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(377, 423);
            textBox2.TabIndex = 2;
            textBox2.Text = "Hier wird der komprimierte Text stehen.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 454);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 3;
            label1.Text = "Zeichen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 454);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 454);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 5;
            label3.Text = "Zeichen:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 454);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 480);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(800, 519);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(800, 519);
            Name = "Form1";
            Text = "Algorithmus zum Komprimieren";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
