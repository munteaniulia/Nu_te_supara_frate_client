
namespace Nu_te_supara_frate
{
    partial class Inreg
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
            this.bNext = new System.Windows.Forms.Button();
            this.NumeJucator = new System.Windows.Forms.RichTextBox();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNext
            // 
            this.bNext.BackColor = System.Drawing.Color.DarkViolet;
            this.bNext.Location = new System.Drawing.Point(452, 606);
            this.bNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(99, 41);
            this.bNext.TabIndex = 0;
            this.bNext.Text = "NEXT";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // NumeJucator
            // 
            this.NumeJucator.BackColor = System.Drawing.Color.DarkViolet;
            this.NumeJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeJucator.Location = new System.Drawing.Point(177, 311);
            this.NumeJucator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumeJucator.Name = "NumeJucator";
            this.NumeJucator.Size = new System.Drawing.Size(173, 38);
            this.NumeJucator.TabIndex = 1;
            this.NumeJucator.Text = "";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.DarkViolet;
            this.bExit.Location = new System.Drawing.Point(12, 606);
            this.bExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(99, 41);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "EXIT";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Inreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nu_te_supara_frate.Properties.Resources.ccad6e522137e80d24471c13494219cf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 658);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.NumeJucator);
            this.Controls.Add(this.bNext);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inreg";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.RichTextBox NumeJucator;
        private System.Windows.Forms.Button bExit;
    }
}

