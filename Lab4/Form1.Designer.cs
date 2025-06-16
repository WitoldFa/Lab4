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
            radio90 = new RadioButton();
            radio180 = new RadioButton();
            radio270 = new RadioButton();
            btnRotate = new Button();
            btnInvert = new Button();
            btnUpsideDown = new Button();

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

            // radio90
            // 
            radio90.AutoSize = true;
            radio90.BackColor = Color.FromArgb(255, 128, 128);
            radio90.Location = new Point(169, 37);
            radio90.Name = "radio90";
            radio90.Size = new Size(46, 24);
            radio90.TabIndex = 2;
            radio90.TabStop = true;
            radio90.Text = "90";
            radio90.UseVisualStyleBackColor = false;
            // 
            // radio180
            // 
            radio180.AutoSize = true;
            radio180.BackColor = Color.FromArgb(255, 128, 128);
            radio180.Location = new Point(169, 67);
            radio180.Name = "radio180";
            radio180.Size = new Size(54, 24);
            radio180.TabIndex = 3;
            radio180.TabStop = true;
            radio180.Text = "180";
            radio180.UseVisualStyleBackColor = false;
            // 
            // radio270
            // 
            radio270.AutoSize = true;
            radio270.BackColor = Color.FromArgb(255, 128, 128);
            radio270.Location = new Point(169, 94);
            radio270.Name = "radio270";
            radio270.Size = new Size(54, 24);
            radio270.TabIndex = 4;
            radio270.TabStop = true;
            radio270.Text = "270";
            radio270.UseVisualStyleBackColor = false;
            // 
            // btnRotate
            // 
            btnRotate.BackColor = Color.FromArgb(255, 128, 128);
            btnRotate.Location = new Point(164, 124);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(94, 29);
            btnRotate.TabIndex = 5;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = false;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnInvert
            // 
            btnInvert.BackColor = SystemColors.ActiveCaption;
            btnInvert.Location = new Point(164, 159);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(122, 29);
            btnInvert.TabIndex = 6;
            btnInvert.Text = "Invert Colors";
            btnInvert.UseVisualStyleBackColor = false;
            btnInvert.Click += btnInvert_Click;
            // 
            // btnUpsideDown
            // 
            btnUpsideDown.BackColor = SystemColors.ActiveCaption;
            btnUpsideDown.Location = new Point(164, 194);
            btnUpsideDown.Name = "btnUpsideDown";
            btnUpsideDown.Size = new Size(122, 29);
            btnUpsideDown.TabIndex = 7;
            btnUpsideDown.Text = "Upside Down";
            btnUpsideDown.UseVisualStyleBackColor = false;
            btnUpsideDown.Click += btnUpsideDown_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(btnGreenOnly);

            Controls.Add(btnUpsideDown);
            Controls.Add(btnInvert);
            Controls.Add(btnRotate);
            Controls.Add(radio270);
            Controls.Add(radio180);
            Controls.Add(radio90);

            Controls.Add(btnLoad);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLoad;

        private Button btnGreenOnly;

        private RadioButton radio90;
        private RadioButton radio180;
        private RadioButton radio270;
        private Button btnRotate;
        private Button btnInvert;
        private Button btnUpsideDown;

    }
}
