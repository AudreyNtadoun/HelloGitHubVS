namespace HelloGitHubVS
{
    partial class HelloGitHubVSForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.helloButton.Location = new System.Drawing.Point(98, 65);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(202, 58);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Hello GitHub";
            this.helloButton.UseVisualStyleBackColor = false;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // HelloGitHubVSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 229);
            this.Controls.Add(this.helloButton);
            this.Name = "HelloGitHubVSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub et Git pour Visual Studio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
    }
}

