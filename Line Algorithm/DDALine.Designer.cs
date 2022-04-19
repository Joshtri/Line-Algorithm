namespace Line_Algorithm
{
    partial class DDALine
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
            this.Tawal_X = new System.Windows.Forms.TextBox();
            this.TAkhir_x = new System.Windows.Forms.TextBox();
            this.TAwal_y = new System.Windows.Forms.TextBox();
            this.TAkhir_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(627, 204);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "CETAK";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Tawal_X
            // 
            this.Tawal_X.Location = new System.Drawing.Point(544, 64);
            this.Tawal_X.Name = "Tawal_X";
            this.Tawal_X.Size = new System.Drawing.Size(100, 20);
            this.Tawal_X.TabIndex = 1;
            // 
            // TAkhir_x
            // 
            this.TAkhir_x.Location = new System.Drawing.Point(544, 118);
            this.TAkhir_x.Name = "TAkhir_x";
            this.TAkhir_x.Size = new System.Drawing.Size(100, 20);
            this.TAkhir_x.TabIndex = 2;
            // 
            // TAwal_y
            // 
            this.TAwal_y.Location = new System.Drawing.Point(688, 64);
            this.TAwal_y.Name = "TAwal_y";
            this.TAwal_y.Size = new System.Drawing.Size(100, 20);
            this.TAwal_y.TabIndex = 3;
            // 
            // TAkhir_y
            // 
            this.TAkhir_y.Location = new System.Drawing.Point(688, 118);
            this.TAkhir_y.Name = "TAkhir_y";
            this.TAkhir_y.Size = new System.Drawing.Size(100, 20);
            this.TAkhir_y.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tawal (x0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Takhir(x0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tawal (y0)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Takhir(x0)";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(501, 426);
            this.Canvas.TabIndex = 9;
            this.Canvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TAkhir_y);
            this.Controls.Add(this.TAwal_y);
            this.Controls.Add(this.TAkhir_x);
            this.Controls.Add(this.Tawal_X);
            this.Controls.Add(this.Draw);
            this.Name = "Form1";
            this.Text = "Line Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox Tawal_X;
        private System.Windows.Forms.TextBox TAkhir_x;
        private System.Windows.Forms.TextBox TAwal_y;
        private System.Windows.Forms.TextBox TAkhir_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Canvas;
    }
}

