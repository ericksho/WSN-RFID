namespace CSharpRFIDDemo
{
    partial class Home
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
            this.CSPicture = new System.Windows.Forms.PictureBox();
            this.CSLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CSPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CSPicture
            // 
            this.CSPicture.Image = global::CSharpRFIDDemo.Properties.Resources.connectionNo;
            this.CSPicture.Location = new System.Drawing.Point(40, 20);
            this.CSPicture.Name = "CSPicture";
            this.CSPicture.Size = new System.Drawing.Size(201, 201);
            this.CSPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CSPicture.TabIndex = 0;
            this.CSPicture.TabStop = false;
            // 
            // CSLabel
            // 
            this.CSLabel.AutoSize = true;
            this.CSLabel.Location = new System.Drawing.Point(70, 224);
            this.CSLabel.Name = "CSLabel";
            this.CSLabel.Size = new System.Drawing.Size(150, 25);
            this.CSLabel.TabIndex = 1;
            this.CSLabel.Text = "Desconectado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 1025);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CSLabel);
            this.Controls.Add(this.CSPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WSN Chile - RFID Reader Server";
            ((System.ComponentModel.ISupportInitialize)(this.CSPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CSPicture;
        private System.Windows.Forms.Label CSLabel;
        private System.Windows.Forms.Button button1;

    }
}