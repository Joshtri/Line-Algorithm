namespace Line_Algorithm
{
    partial class Bresenham_Algorithm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Draw = new System.Windows.Forms.Button();
            this.Tawalx = new System.Windows.Forms.TextBox();
            this.Takhirx = new System.Windows.Forms.TextBox();
            this.Tawaly = new System.Windows.Forms.TextBox();
            this.Takhiry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Canva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(630, 211);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "CETAK";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Tawalx
            // 
            this.Tawalx.Location = new System.Drawing.Point(536, 74);
            this.Tawalx.Name = "Tawalx";
            this.Tawalx.Size = new System.Drawing.Size(100, 20);
            this.Tawalx.TabIndex = 1;
            // 
            // Takhirx
            // 
            this.Takhirx.Location = new System.Drawing.Point(536, 129);
            this.Takhirx.Name = "Takhirx";
            this.Takhirx.Size = new System.Drawing.Size(100, 20);
            this.Takhirx.TabIndex = 2;
            // 
            // Tawaly
            // 
            this.Tawaly.Location = new System.Drawing.Point(688, 74);
            this.Tawaly.Name = "Tawaly";
            this.Tawaly.Size = new System.Drawing.Size(100, 20);
            this.Tawaly.TabIndex = 3;
            // 
            // Takhiry
            // 
            this.Takhiry.Location = new System.Drawing.Point(688, 129);
            this.Takhiry.Name = "Takhiry";
            this.Takhiry.Size = new System.Drawing.Size(100, 20);
            this.Takhiry.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tawal (x0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tawal (y0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Takhir(x1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Takhir(y1)";
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Canva.Location = new System.Drawing.Point(2, 2);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(502, 443);
            this.Canva.TabIndex = 9;
            this.Canva.TabStop = false;
            // 
            // Bresenham_Algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Takhiry);
            this.Controls.Add(this.Tawaly);
            this.Controls.Add(this.Takhirx);
            this.Controls.Add(this.Tawalx);
            this.Controls.Add(this.Draw);
            this.Name = "Bresenham_Algorithm";
            this.Text = "Bresenham_Algorithm";
            this.Load += new System.EventHandler(this.Bresenham_Algorithm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox Tawalx;
        private System.Windows.Forms.TextBox Takhirx;
        private System.Windows.Forms.TextBox Tawaly;
        private System.Windows.Forms.TextBox Takhiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Canva;
    }
}