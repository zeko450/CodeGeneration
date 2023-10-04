namespace CodeGeneration
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenerate = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtLoad = new System.Windows.Forms.Label();
            this.txtWait = new System.Windows.Forms.Label();
            this.txtComplete = new System.Windows.Forms.Label();
            this.textPlatform = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(506, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "My passwords";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodeGen";
            // 
            // txtGenerate
            // 
            this.txtGenerate.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGenerate.Location = new System.Drawing.Point(148, 232);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(528, 35);
            this.txtGenerate.TabIndex = 3;
            this.txtGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTimer.Location = new System.Drawing.Point(366, 209);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 20);
            this.lblTimer.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 37);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // txtLoad
            // 
            this.txtLoad.AutoSize = true;
            this.txtLoad.BackColor = System.Drawing.Color.White;
            this.txtLoad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoad.Location = new System.Drawing.Point(112, 339);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(74, 22);
            this.txtLoad.TabIndex = 6;
            this.txtLoad.Text = "Loading";
            this.txtLoad.Visible = false;
            // 
            // txtWait
            // 
            this.txtWait.AutoSize = true;
            this.txtWait.BackColor = System.Drawing.Color.White;
            this.txtWait.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWait.Location = new System.Drawing.Point(85, 424);
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(122, 22);
            this.txtWait.TabIndex = 7;
            this.txtWait.Text = "Please wait ...";
            this.txtWait.Visible = false;
            // 
            // txtComplete
            // 
            this.txtComplete.AutoSize = true;
            this.txtComplete.BackColor = System.Drawing.Color.LightCoral;
            this.txtComplete.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplete.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtComplete.Location = new System.Drawing.Point(27, 377);
            this.txtComplete.Name = "txtComplete";
            this.txtComplete.Size = new System.Drawing.Size(258, 34);
            this.txtComplete.TabIndex = 8;
            this.txtComplete.Text = "Password Generated";
            this.txtComplete.Visible = false;
            // 
            // textPlatform
            // 
            this.textPlatform.BackColor = System.Drawing.Color.White;
            this.textPlatform.Location = new System.Drawing.Point(322, 183);
            this.textPlatform.Name = "textPlatform";
            this.textPlatform.Size = new System.Drawing.Size(169, 26);
            this.textPlatform.TabIndex = 9;
            this.textPlatform.Click += new System.EventHandler(this.textPlatform_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Account type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CodeGeneration.Properties.Resources.CodeGenBG2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(820, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPlatform);
            this.Controls.Add(this.txtComplete);
            this.Controls.Add(this.txtWait);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtGenerate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximumSize = new System.Drawing.Size(842, 557);
            this.MinimumSize = new System.Drawing.Size(842, 557);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator and Code Storage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenerate;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txtLoad;
        private System.Windows.Forms.Label txtWait;
        private System.Windows.Forms.Label txtComplete;
        private System.Windows.Forms.TextBox textPlatform;
        private System.Windows.Forms.Label label2;
    }
}

