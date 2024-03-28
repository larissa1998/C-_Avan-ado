namespace _07_Eventos
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
            btnVideoEncode = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnVideoEncode
            // 
            btnVideoEncode.Location = new System.Drawing.Point(150, 227);
            btnVideoEncode.Name = "btnVideoEncode";
            btnVideoEncode.Size = new System.Drawing.Size(148, 52);
            btnVideoEncode.TabIndex = 0;
            btnVideoEncode.Text = "Video Encode";
            btnVideoEncode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(453, 380);
            Controls.Add(btnVideoEncode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnVideoEncode;
    }
}
