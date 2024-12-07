namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            next = new Button();
            previous = new Button();
            select = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(644, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // next
            // 
            next.BackColor = Color.SteelBlue;
            next.Cursor = Cursors.Hand;
            next.FlatStyle = FlatStyle.Popup;
            next.Location = new Point(399, 464);
            next.Name = "next";
            next.Size = new Size(107, 41);
            next.TabIndex = 1;
            next.Text = "Next";
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // previous
            // 
            previous.BackColor = Color.SteelBlue;
            previous.Cursor = Cursors.Hand;
            previous.FlatStyle = FlatStyle.Popup;
            previous.Location = new Point(173, 464);
            previous.Name = "previous";
            previous.Size = new Size(107, 41);
            previous.TabIndex = 2;
            previous.Text = "Previous";
            previous.UseVisualStyleBackColor = false;
            previous.Click += previous_Click;
            // 
            // select
            // 
            select.BackColor = Color.SteelBlue;
            select.Cursor = Cursors.Hand;
            select.FlatStyle = FlatStyle.Popup;
            select.Location = new Point(286, 455);
            select.Name = "select";
            select.Size = new Size(107, 41);
            select.TabIndex = 3;
            select.Text = "Select";
            select.UseVisualStyleBackColor = false;
            select.Click += select_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(669, 517);
            Controls.Add(select);
            Controls.Add(previous);
            Controls.Add(next);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gallery";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button next;
        private Button previous;
        private Button select;
    }
}
