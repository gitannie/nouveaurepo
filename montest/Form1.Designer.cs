﻿namespace montest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "1er bouton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bouton collabo1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 96);
            this.button3.TabIndex = 2;
            this.button3.Text = "Collabo3 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttun5
            // 
            this.button5.Location = new System.Drawing.Point(37, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 34);
            this.button5.TabIndex = 3;
            this.button5.Text = "Bouton Collabo6";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 73);
            this.button5.TabIndex = 3;
            this.button5.Text = "Bouton collabo5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

