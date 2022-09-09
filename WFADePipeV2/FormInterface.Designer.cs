namespace WFADePipeV2
{
    partial class FormInterface
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
            this.labelTypeDeDe = new System.Windows.Forms.Label();
            this.labelValeurDe = new System.Windows.Forms.Label();
            this.labelTotalObtenu = new System.Windows.Forms.Label();
            this.textBoxValeurDe = new System.Windows.Forms.TextBox();
            this.textBoxTotalObtenu = new System.Windows.Forms.TextBox();
            this.buttonBrasser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeDeDe
            // 
            this.labelTypeDeDe.AutoSize = true;
            this.labelTypeDeDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypeDeDe.Location = new System.Drawing.Point(68, 9);
            this.labelTypeDeDe.Name = "labelTypeDeDe";
            this.labelTypeDeDe.Size = new System.Drawing.Size(165, 41);
            this.labelTypeDeDe.TabIndex = 0;
            this.labelTypeDeDe.Text = "Type de dé";
            // 
            // labelValeurDe
            // 
            this.labelValeurDe.AutoSize = true;
            this.labelValeurDe.Location = new System.Drawing.Point(33, 68);
            this.labelValeurDe.Name = "labelValeurDe";
            this.labelValeurDe.Size = new System.Drawing.Size(99, 20);
            this.labelValeurDe.TabIndex = 1;
            this.labelValeurDe.Text = "Valeur du dé :";
            // 
            // labelTotalObtenu
            // 
            this.labelTotalObtenu.AutoSize = true;
            this.labelTotalObtenu.Location = new System.Drawing.Point(33, 105);
            this.labelTotalObtenu.Name = "labelTotalObtenu";
            this.labelTotalObtenu.Size = new System.Drawing.Size(100, 20);
            this.labelTotalObtenu.TabIndex = 2;
            this.labelTotalObtenu.Text = "Total obtenu :";
            // 
            // textBoxValeurDe
            // 
            this.textBoxValeurDe.Location = new System.Drawing.Point(138, 68);
            this.textBoxValeurDe.Name = "textBoxValeurDe";
            this.textBoxValeurDe.ReadOnly = true;
            this.textBoxValeurDe.Size = new System.Drawing.Size(125, 27);
            this.textBoxValeurDe.TabIndex = 3;
            // 
            // textBoxTotalObtenu
            // 
            this.textBoxTotalObtenu.Location = new System.Drawing.Point(138, 105);
            this.textBoxTotalObtenu.Name = "textBoxTotalObtenu";
            this.textBoxTotalObtenu.ReadOnly = true;
            this.textBoxTotalObtenu.Size = new System.Drawing.Size(125, 27);
            this.textBoxTotalObtenu.TabIndex = 4;
            // 
            // buttonBrasser
            // 
            this.buttonBrasser.Location = new System.Drawing.Point(33, 146);
            this.buttonBrasser.Name = "buttonBrasser";
            this.buttonBrasser.Size = new System.Drawing.Size(230, 29);
            this.buttonBrasser.TabIndex = 5;
            this.buttonBrasser.Text = "Brasser";
            this.buttonBrasser.UseVisualStyleBackColor = true;
            this.buttonBrasser.Click += new System.EventHandler(this.buttonBrasser_Click);
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 226);
            this.Controls.Add(this.buttonBrasser);
            this.Controls.Add(this.textBoxTotalObtenu);
            this.Controls.Add(this.textBoxValeurDe);
            this.Controls.Add(this.labelTotalObtenu);
            this.Controls.Add(this.labelValeurDe);
            this.Controls.Add(this.labelTypeDeDe);
            this.Name = "FormInterface";
            this.Text = "Jeu de dé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTypeDeDe;
        private Label labelValeurDe;
        private Label labelTotalObtenu;
        private TextBox textBoxValeurDe;
        private TextBox textBoxTotalObtenu;
        private Button buttonBrasser;
    }
}