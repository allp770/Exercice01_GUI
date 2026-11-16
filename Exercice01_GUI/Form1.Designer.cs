namespace Exercice01_GUI
{
    partial class FrmNombreCache
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
            this.grpValeur = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.grpReponse = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.grpValeur.SuspendLayout();
            this.grpReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpValeur
            // 
            this.grpValeur.Controls.Add(this.btnValider);
            this.grpValeur.Controls.Add(this.txtValeur);
            this.grpValeur.Location = new System.Drawing.Point(34, 24);
            this.grpValeur.Name = "grpValeur";
            this.grpValeur.Size = new System.Drawing.Size(271, 94);
            this.grpValeur.TabIndex = 0;
            this.grpValeur.TabStop = false;
            this.grpValeur.Text = "groupBox1";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.Location = new System.Drawing.Point(200, 38);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(52, 22);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(6, 38);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(177, 22);
            this.txtValeur.TabIndex = 0;
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);
            // 
            // grpReponse
            // 
            this.grpReponse.Controls.Add(this.lblMessage);
            this.grpReponse.Location = new System.Drawing.Point(34, 145);
            this.grpReponse.Name = "grpReponse";
            this.grpReponse.Size = new System.Drawing.Size(271, 94);
            this.grpReponse.TabIndex = 1;
            this.grpReponse.TabStop = false;
            this.grpReponse.Text = "groupBox1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(20, 47);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuitter.Image = global::Exercice01_GUI.Properties.Resources.quitter;
            this.btnQuitter.Location = new System.Drawing.Point(353, 145);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(116, 93);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRejouer.Image = global::Exercice01_GUI.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(353, 24);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(117, 93);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.UseVisualStyleBackColor = false;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // FrmNombreCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 273);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.grpReponse);
            this.Controls.Add(this.grpValeur);
            this.Name = "FrmNombreCache";
            this.Text = "nombre caché";
            this.Load += new System.EventHandler(this.FrmNombreCache_Load);
            this.grpValeur.ResumeLayout(false);
            this.grpValeur.PerformLayout();
            this.grpReponse.ResumeLayout(false);
            this.grpReponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpValeur;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.GroupBox grpReponse;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

