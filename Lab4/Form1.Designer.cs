namespace Lab4
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
            pictureBox1 = new PictureBox();
            btnLoad = new Button();
            btnGreenOnly = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(343, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 369);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(164, 368);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnGreenOnly
            // 
            btnGreenOnly.BackColor = Color.FromArgb(128, 255, 128);
            btnGreenOnly.Location = new Point(164, 333);
            btnGreenOnly.Name = "btnGreenOnly";
            btnGreenOnly.Size = new Size(101, 29);
            btnGreenOnly.TabIndex = 2;
            btnGreenOnly.Text = "Green Only";
            btnGreenOnly.UseVisualStyleBackColor = false;
            btnGreenOnly.Click += btnGreenOnly_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGreenOnly);
            Controls.Add(btnLoad);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLoad;
        private Button btnGreenOnly;
    }
}
