namespace Proje_Bilgi_Yarışması
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
            btna = new Button();
            btnb = new Button();
            btnc = new Button();
            btnd = new Button();
            richTextBox1 = new RichTextBox();
            LblSoru = new Label();
            LblDoğru = new Label();
            LblYanlış = new Label();
            Lbls = new Label();
            Lbld = new Label();
            Lbly = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnsonraki = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btna
            // 
            btna.Location = new Point(31, 294);
            btna.Name = "btna";
            btna.Size = new Size(258, 49);
            btna.TabIndex = 1;
            btna.Text = "A";
            btna.UseVisualStyleBackColor = true;
            btna.Click += btna_Click;
            // 
            // btnb
            // 
            btnb.Location = new Point(321, 294);
            btnb.Name = "btnb";
            btnb.Size = new Size(258, 49);
            btnb.TabIndex = 2;
            btnb.Text = "B";
            btnb.UseVisualStyleBackColor = true;
            btnb.Click += btnb_Click;
            // 
            // btnc
            // 
            btnc.Location = new Point(31, 401);
            btnc.Name = "btnc";
            btnc.Size = new Size(258, 49);
            btnc.TabIndex = 3;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // btnd
            // 
            btnd.Location = new Point(321, 401);
            btnd.Name = "btnd";
            btnd.Size = new Size(258, 49);
            btnd.TabIndex = 4;
            btnd.Text = "D";
            btnd.UseVisualStyleBackColor = true;
            btnd.Click += btnd_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(31, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(548, 242);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // LblSoru
            // 
            LblSoru.AutoSize = true;
            LblSoru.Location = new Point(602, 41);
            LblSoru.Name = "LblSoru";
            LblSoru.Size = new Size(101, 28);
            LblSoru.TabIndex = 6;
            LblSoru.Text = "Soru No :";
            // 
            // LblDoğru
            // 
            LblDoğru.AutoSize = true;
            LblDoğru.Location = new Point(621, 103);
            LblDoğru.Name = "LblDoğru";
            LblDoğru.Size = new Size(82, 28);
            LblDoğru.TabIndex = 7;
            LblDoğru.Text = "Doğru :";
            // 
            // LblYanlış
            // 
            LblYanlış.AutoSize = true;
            LblYanlış.Location = new Point(626, 168);
            LblYanlış.Name = "LblYanlış";
            LblYanlış.Size = new Size(77, 28);
            LblYanlış.TabIndex = 8;
            LblYanlış.Text = "Yanlış :";
            // 
            // Lbls
            // 
            Lbls.AutoSize = true;
            Lbls.Location = new Point(735, 41);
            Lbls.Name = "Lbls";
            Lbls.Size = new Size(24, 28);
            Lbls.TabIndex = 9;
            Lbls.Text = "0";
            // 
            // Lbld
            // 
            Lbld.AutoSize = true;
            Lbld.Location = new Point(735, 103);
            Lbld.Name = "Lbld";
            Lbld.Size = new Size(24, 28);
            Lbld.TabIndex = 10;
            Lbld.Text = "0";
            // 
            // Lbly
            // 
            Lbly.AutoSize = true;
            Lbly.Location = new Point(735, 168);
            Lbly.Name = "Lbly";
            Lbly.Size = new Size(24, 28);
            Lbly.TabIndex = 11;
            Lbly.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(736, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(617, 364);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // btnsonraki
            // 
            btnsonraki.Location = new Point(654, 251);
            btnsonraki.Name = "btnsonraki";
            btnsonraki.Size = new Size(149, 44);
            btnsonraki.TabIndex = 14;
            btnsonraki.Text = "sonraki >>";
            btnsonraki.UseVisualStyleBackColor = true;
            btnsonraki.Click += btnsonraki_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 469);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 15;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 469);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 16;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 497);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsonraki);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Lbly);
            Controls.Add(Lbld);
            Controls.Add(Lbls);
            Controls.Add(LblYanlış);
            Controls.Add(LblDoğru);
            Controls.Add(LblSoru);
            Controls.Add(richTextBox1);
            Controls.Add(btnd);
            Controls.Add(btnc);
            Controls.Add(btnb);
            Controls.Add(btna);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btna;
        private Button btnb;
        private Button btnc;
        private Button btnd;
        private RichTextBox richTextBox1;
        private Label LblSoru;
        private Label LblDoğru;
        private Label LblYanlış;
        private Label Lbls;
        private Label Lbld;
        private Label Lbly;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnsonraki;
        private Label label1;
        private Label label2;
    }
}
