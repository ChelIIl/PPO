namespace EntityFrForm
{
    partial class INFO
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
            this.Mark = new System.Windows.Forms.Label();
            this.Probeg = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.mark_t = new System.Windows.Forms.TextBox();
            this.probeg_t = new System.Windows.Forms.TextBox();
            this.colour_t = new System.Windows.Forms.TextBox();
            this.year_t = new System.Windows.Forms.TextBox();
            this.about_t = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark.Location = new System.Drawing.Point(29, 9);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(71, 28);
            this.Mark.TabIndex = 11;
            this.Mark.Text = "Mark";
            // 
            // Probeg
            // 
            this.Probeg.AutoSize = true;
            this.Probeg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Probeg.Location = new System.Drawing.Point(20, 63);
            this.Probeg.Name = "Probeg";
            this.Probeg.Size = new System.Drawing.Size(97, 28);
            this.Probeg.TabIndex = 12;
            this.Probeg.Text = "Probeg";
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour.Location = new System.Drawing.Point(278, 63);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(90, 28);
            this.Colour.TabIndex = 13;
            this.Colour.Text = "Colour";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(288, 9);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(66, 28);
            this.year.TabIndex = 14;
            this.year.Text = "Year";
            // 
            // mark_t
            // 
            this.mark_t.Location = new System.Drawing.Point(17, 40);
            this.mark_t.Name = "mark_t";
            this.mark_t.Size = new System.Drawing.Size(100, 20);
            this.mark_t.TabIndex = 15;
            // 
            // probeg_t
            // 
            this.probeg_t.Location = new System.Drawing.Point(17, 94);
            this.probeg_t.Name = "probeg_t";
            this.probeg_t.Size = new System.Drawing.Size(100, 20);
            this.probeg_t.TabIndex = 16;
            // 
            // colour_t
            // 
            this.colour_t.Location = new System.Drawing.Point(268, 94);
            this.colour_t.Name = "colour_t";
            this.colour_t.Size = new System.Drawing.Size(100, 20);
            this.colour_t.TabIndex = 17;
            // 
            // year_t
            // 
            this.year_t.Location = new System.Drawing.Point(268, 40);
            this.year_t.Name = "year_t";
            this.year_t.Size = new System.Drawing.Size(100, 20);
            this.year_t.TabIndex = 18;
            // 
            // about_t
            // 
            this.about_t.Location = new System.Drawing.Point(12, 169);
            this.about_t.Multiline = true;
            this.about_t.Name = "about_t";
            this.about_t.Size = new System.Drawing.Size(356, 123);
            this.about_t.TabIndex = 19;
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(12, 138);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(80, 28);
            this.about.TabIndex = 20;
            this.about.Text = "About";
            // 
            // INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 304);
            this.Controls.Add(this.about);
            this.Controls.Add(this.about_t);
            this.Controls.Add(this.year_t);
            this.Controls.Add(this.colour_t);
            this.Controls.Add(this.probeg_t);
            this.Controls.Add(this.mark_t);
            this.Controls.Add(this.year);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.Probeg);
            this.Controls.Add(this.Mark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "INFO";
            this.Text = "INFO";
            this.Load += new System.EventHandler(this.INFO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label Probeg;
        private System.Windows.Forms.Label Colour;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TextBox mark_t;
        private System.Windows.Forms.TextBox probeg_t;
        private System.Windows.Forms.TextBox colour_t;
        private System.Windows.Forms.TextBox year_t;
        private System.Windows.Forms.TextBox about_t;
        private System.Windows.Forms.Label about;
    }
}