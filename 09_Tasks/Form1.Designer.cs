namespace _09_Tasks
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
            btnBaixar = new Button();
            txtResultado = new RichTextBox();
            label1 = new Label();
            txtSite = new TextBox();
            SuspendLayout();
            // 
            // btnBaixar
            // 
            btnBaixar.Location = new Point(179, 359);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(111, 54);
            btnBaixar.TabIndex = 0;
            btnBaixar.Text = "Fazer Download";
            btnBaixar.UseVisualStyleBackColor = true;
            btnBaixar.Click += btnBaixar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 110);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(464, 201);
            txtResultado.TabIndex = 1;
            txtResultado.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 2;
            label1.Text = "Site";
            // 
            // txtSite
            // 
            txtSite.Location = new Point(44, 21);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(221, 23);
            txtSite.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(txtSite);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(btnBaixar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaixar;
        private RichTextBox txtResultado;
        private Label label1;
        private TextBox txtSite;
    }
}