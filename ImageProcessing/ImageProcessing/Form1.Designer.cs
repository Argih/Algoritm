namespace ImageProcessing
{
    partial class Form1
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
            this.load = new System.Windows.Forms.Button();
            this.detect = new System.Windows.Forms.Button();
            this.pictureB = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).BeginInit();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(463, 270);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 0;
            this.load.Text = "&Abrir";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // detect
            // 
            this.detect.Location = new System.Drawing.Point(463, 311);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(75, 23);
            this.detect.TabIndex = 0;
            this.detect.Text = "&Detectar";
            this.detect.UseVisualStyleBackColor = true;
            this.detect.Click += new System.EventHandler(this.detect_Click);
            // 
            // pictureB
            // 
            this.pictureB.Location = new System.Drawing.Point(12, 12);
            this.pictureB.Name = "pictureB";
            this.pictureB.Size = new System.Drawing.Size(441, 322);
            this.pictureB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureB.TabIndex = 1;
            this.pictureB.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureB);
            this.Controls.Add(this.detect);
            this.Controls.Add(this.load);
            this.Name = "Form1";
            this.Text = "Analisis de imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button detect;
        private System.Windows.Forms.PictureBox pictureB;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label1;
    }
}

