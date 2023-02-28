namespace L3B
{
    partial class Lift
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
            this.liftBar = new System.Windows.Forms.TrackBar();
            this.etaj1 = new System.Windows.Forms.CheckBox();
            this.etaj2 = new System.Windows.Forms.CheckBox();
            this.etaj3 = new System.Windows.Forms.CheckBox();
            this.etaj4 = new System.Windows.Forms.CheckBox();
            this.parter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.liftBar)).BeginInit();
            this.SuspendLayout();
            // 
            // liftBar
            // 
            this.liftBar.Location = new System.Drawing.Point(198, 12);
            this.liftBar.Maximum = 4;
            this.liftBar.Name = "liftBar";
            this.liftBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.liftBar.Size = new System.Drawing.Size(45, 332);
            this.liftBar.TabIndex = 0;
            // 
            // etaj1
            // 
            this.etaj1.AutoSize = true;
            this.etaj1.Location = new System.Drawing.Point(138, 246);
            this.etaj1.Name = "etaj1";
            this.etaj1.Size = new System.Drawing.Size(54, 19);
            this.etaj1.TabIndex = 1;
            this.etaj1.Text = "etaj 1";
            this.etaj1.UseVisualStyleBackColor = true;
            // 
            // etaj2
            // 
            this.etaj2.AutoSize = true;
            this.etaj2.Location = new System.Drawing.Point(138, 170);
            this.etaj2.Name = "etaj2";
            this.etaj2.Size = new System.Drawing.Size(54, 19);
            this.etaj2.TabIndex = 2;
            this.etaj2.Text = "etaj 2";
            this.etaj2.UseVisualStyleBackColor = true;
            // 
            // etaj3
            // 
            this.etaj3.AutoSize = true;
            this.etaj3.Location = new System.Drawing.Point(138, 95);
            this.etaj3.Name = "etaj3";
            this.etaj3.Size = new System.Drawing.Size(54, 19);
            this.etaj3.TabIndex = 3;
            this.etaj3.Text = "etaj 3";
            this.etaj3.UseVisualStyleBackColor = true;
            // 
            // etaj4
            // 
            this.etaj4.AutoSize = true;
            this.etaj4.Location = new System.Drawing.Point(138, 21);
            this.etaj4.Name = "etaj4";
            this.etaj4.Size = new System.Drawing.Size(54, 19);
            this.etaj4.TabIndex = 4;
            this.etaj4.Text = "etaj 4";
            this.etaj4.UseVisualStyleBackColor = true;
            // 
            // parter
            // 
            this.parter.AutoSize = true;
            this.parter.Location = new System.Drawing.Point(135, 316);
            this.parter.Name = "parter";
            this.parter.Size = new System.Drawing.Size(57, 19);
            this.parter.TabIndex = 5;
            this.parter.Text = "parter";
            this.parter.UseVisualStyleBackColor = true;
            // 
            // Lift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 356);
            this.Controls.Add(this.parter);
            this.Controls.Add(this.etaj4);
            this.Controls.Add(this.etaj3);
            this.Controls.Add(this.etaj2);
            this.Controls.Add(this.etaj1);
            this.Controls.Add(this.liftBar);
            this.Name = "Lift";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.liftBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar liftBar;
        private CheckBox etaj1;
        private CheckBox etaj2;
        private CheckBox etaj3;
        private CheckBox etaj4;
        private CheckBox parter;
    }
}