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
            this.graphButton = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Button();
            this.structure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).BeginInit();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(662, 391);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(156, 23);
            this.load.TabIndex = 0;
            this.load.Text = "&Abrir";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // detect
            // 
            this.detect.Location = new System.Drawing.Point(662, 420);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(156, 23);
            this.detect.TabIndex = 0;
            this.detect.Text = "&Detectar";
            this.detect.UseVisualStyleBackColor = true;
            this.detect.Click += new System.EventHandler(this.detect_Click);
            // 
            // pictureB
            // 
            this.pictureB.Location = new System.Drawing.Point(12, 12);
            this.pictureB.Name = "pictureB";
            this.pictureB.Size = new System.Drawing.Size(644, 488);
            this.pictureB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureB.TabIndex = 1;
            this.pictureB.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // graphButton
            // 
            this.graphButton.Enabled = false;
            this.graphButton.Location = new System.Drawing.Point(662, 449);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(156, 23);
            this.graphButton.TabIndex = 3;
            this.graphButton.Text = "Ver grafo";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // path
            // 
            this.path.Enabled = false;
            this.path.Location = new System.Drawing.Point(662, 478);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(156, 23);
            this.path.TabIndex = 4;
            this.path.Text = "Camino";
            this.path.UseVisualStyleBackColor = true;
            this.path.Click += new System.EventHandler(this.path_Click);
            // 
            // structure
            // 
            this.structure.AcceptsReturn = true;
            this.structure.Location = new System.Drawing.Point(662, 33);
            this.structure.Multiline = true;
            this.structure.Name = "structure";
            this.structure.ReadOnly = true;
            this.structure.Size = new System.Drawing.Size(156, 272);
            this.structure.TabIndex = 5;
            this.structure.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estructura del Grafo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.structure);
            this.Controls.Add(this.path);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureB);
            this.Controls.Add(this.detect);
            this.Controls.Add(this.load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Button path;
        private System.Windows.Forms.TextBox structure;
        private System.Windows.Forms.Label label2;
    }
}

