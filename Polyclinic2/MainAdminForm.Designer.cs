namespace Polyclinic2
{
    partial class MainAdminForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonChooseDoc = new System.Windows.Forms.Button();
            this.buttonChoosePat = new System.Windows.Forms.Button();
            this.buttonChooseDiz = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(294, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChooseDoc
            // 
            this.buttonChooseDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseDoc.Location = new System.Drawing.Point(16, 59);
            this.buttonChooseDoc.Name = "buttonChooseDoc";
            this.buttonChooseDoc.Size = new System.Drawing.Size(100, 50);
            this.buttonChooseDoc.TabIndex = 1;
            this.buttonChooseDoc.Text = "Врачи";
            this.buttonChooseDoc.UseVisualStyleBackColor = true;
            this.buttonChooseDoc.Click += new System.EventHandler(this.buttonChooseDoc_Click);
            // 
            // buttonChoosePat
            // 
            this.buttonChoosePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChoosePat.Location = new System.Drawing.Point(157, 59);
            this.buttonChoosePat.Name = "buttonChoosePat";
            this.buttonChoosePat.Size = new System.Drawing.Size(100, 50);
            this.buttonChoosePat.TabIndex = 2;
            this.buttonChoosePat.Text = "Пациенты";
            this.buttonChoosePat.UseVisualStyleBackColor = true;
            this.buttonChoosePat.Click += new System.EventHandler(this.buttonChoosePat_Click);
            // 
            // buttonChooseDiz
            // 
            this.buttonChooseDiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseDiz.Location = new System.Drawing.Point(294, 59);
            this.buttonChooseDiz.Name = "buttonChooseDiz";
            this.buttonChooseDiz.Size = new System.Drawing.Size(100, 50);
            this.buttonChooseDiz.TabIndex = 3;
            this.buttonChooseDiz.Text = "Диагнозы";
            this.buttonChooseDiz.UseVisualStyleBackColor = true;
            this.buttonChooseDiz.Click += new System.EventHandler(this.buttonChooseDiz_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(12, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(66, 24);
            this.userName.TabIndex = 4;
            this.userName.Text = "label1";
            this.userName.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 245);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.buttonChooseDiz);
            this.Controls.Add(this.buttonChoosePat);
            this.Controls.Add(this.buttonChooseDoc);
            this.Controls.Add(this.button1);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonChooseDoc;
        private System.Windows.Forms.Button buttonChoosePat;
        private System.Windows.Forms.Button buttonChooseDiz;
        private System.Windows.Forms.Label userName;
    }
}