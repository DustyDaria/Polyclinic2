namespace Polyclinic2
{
    partial class MainDoctorForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.buttonPersonalAcc = new System.Windows.Forms.Button();
            this.buttonChoosePat = new System.Windows.Forms.Button();
            this.buttonChooseDiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(683, 288);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 62);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(17, 16);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(85, 29);
            this.userName.TabIndex = 3;
            this.userName.Text = "label2";
            // 
            // buttonPersonalAcc
            // 
            this.buttonPersonalAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPersonalAcc.Location = new System.Drawing.Point(880, 16);
            this.buttonPersonalAcc.Name = "buttonPersonalAcc";
            this.buttonPersonalAcc.Size = new System.Drawing.Size(220, 62);
            this.buttonPersonalAcc.TabIndex = 4;
            this.buttonPersonalAcc.Text = "Личный кабинет";
            this.buttonPersonalAcc.UseVisualStyleBackColor = true;
            this.buttonPersonalAcc.Click += new System.EventHandler(this.buttonPersonalAcc_Click);
            // 
            // buttonChoosePat
            // 
            this.buttonChoosePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChoosePat.Location = new System.Drawing.Point(86, 157);
            this.buttonChoosePat.Name = "buttonChoosePat";
            this.buttonChoosePat.Size = new System.Drawing.Size(150, 62);
            this.buttonChoosePat.TabIndex = 5;
            this.buttonChoosePat.Text = "Пациенты";
            this.buttonChoosePat.UseVisualStyleBackColor = true;
            this.buttonChoosePat.Click += new System.EventHandler(this.buttonChoosePat_Click);
            // 
            // buttonChooseDiz
            // 
            this.buttonChooseDiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseDiz.Location = new System.Drawing.Point(398, 157);
            this.buttonChooseDiz.Name = "buttonChooseDiz";
            this.buttonChooseDiz.Size = new System.Drawing.Size(150, 62);
            this.buttonChooseDiz.TabIndex = 6;
            this.buttonChooseDiz.Text = "Диагнозы";
            this.buttonChooseDiz.UseVisualStyleBackColor = true;
            this.buttonChooseDiz.Click += new System.EventHandler(this.buttonChooseDiz_Click);
            // 
            // MainDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 402);
            this.Controls.Add(this.buttonChooseDiz);
            this.Controls.Add(this.buttonChoosePat);
            this.Controls.Add(this.buttonPersonalAcc);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.buttonExit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainDoctorForm";
            this.Text = "MainDoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonPersonalAcc;
        private System.Windows.Forms.Button buttonChoosePat;
        private System.Windows.Forms.Button buttonChooseDiz;
    }
}