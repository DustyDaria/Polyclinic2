namespace Polyclinic2
{
    partial class AdmChooseDiz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listStatusDiz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchReaderBox = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridViewDiz = new System.Windows.Forms.DataGridView();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambulatoryTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termOfDisability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispensaryAccounting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateOfTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewPat = new System.Windows.Forms.DataGridView();
            this.id_userP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialStatus_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentState_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.listStatusPat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(632, 667);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 72);
            this.label2.TabIndex = 40;
            this.label2.Text = "Для удаления \r\nданных диагноза пациента, \r\nвыберите ID ДИАГНОЗА, \r\nа затем нажмит" +
    "е на кнопку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1129, 667);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 72);
            this.label5.TabIndex = 39;
            this.label5.Text = "Для изменения \r\nданных диагноза пациента, \r\nвыберите ID ДИАГНОЗА, \r\nа затем нажми" +
    "те на кнопку";
            // 
            // listStatusDiz
            // 
            this.listStatusDiz.FormattingEnabled = true;
            this.listStatusDiz.Items.AddRange(new object[] {
            "ID",
            "Диагноз пациента",
            "Амбулаторное лечение",
            "Срок нетрудоспособности",
            "Диспансерный учет",
            "Дата начала лечения"});
            this.listStatusDiz.Location = new System.Drawing.Point(659, 85);
            this.listStatusDiz.Margin = new System.Windows.Forms.Padding(4);
            this.listStatusDiz.Name = "listStatusDiz";
            this.listStatusDiz.Size = new System.Drawing.Size(281, 24);
            this.listStatusDiz.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(654, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 50);
            this.label1.TabIndex = 37;
            this.label1.Text = "Выберите критерий поиска\r\nпо ДИАГНОЗАМ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(868, 667);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 62);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(1359, 667);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(267, 62);
            this.buttonChange.TabIndex = 35;
            this.buttonChange.Text = "Изменить данные";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(252, 667);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 62);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(421, 26);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(133, 62);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchReaderBox
            // 
            this.searchReaderBox.Location = new System.Drawing.Point(28, 28);
            this.searchReaderBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchReaderBox.Name = "searchReaderBox";
            this.searchReaderBox.Size = new System.Drawing.Size(335, 22);
            this.searchReaderBox.TabIndex = 32;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(1449, 28);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(70, 25);
            this.userName.TabIndex = 31;
            this.userName.Text = "label1";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(1778, 667);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 62);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridViewDiz
            // 
            this.dataGridViewDiz.AllowUserToOrderColumns = true;
            this.dataGridViewDiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.diagnosis,
            this.ambulatoryTreatment,
            this.termOfDisability,
            this.dispensaryAccounting,
            this.startDateOfTreatment});
            this.dataGridViewDiz.Location = new System.Drawing.Point(25, 182);
            this.dataGridViewDiz.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDiz.Name = "dataGridViewDiz";
            this.dataGridViewDiz.Size = new System.Drawing.Size(871, 457);
            this.dataGridViewDiz.TabIndex = 29;
            this.dataGridViewDiz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiz_CellContentClick);
            // 
            // id_user
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_user.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_user.HeaderText = "ID";
            this.id_user.Name = "id_user";
            this.id_user.Width = 40;
            // 
            // diagnosis
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosis.DefaultCellStyle = dataGridViewCellStyle2;
            this.diagnosis.HeaderText = "Диагноз";
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Width = 150;
            // 
            // ambulatoryTreatment
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ambulatoryTreatment.DefaultCellStyle = dataGridViewCellStyle3;
            this.ambulatoryTreatment.HeaderText = "Амбулаторное лечение";
            this.ambulatoryTreatment.Name = "ambulatoryTreatment";
            // 
            // termOfDisability
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termOfDisability.DefaultCellStyle = dataGridViewCellStyle4;
            this.termOfDisability.HeaderText = "Срок нетрудоспособности";
            this.termOfDisability.Name = "termOfDisability";
            this.termOfDisability.Width = 120;
            // 
            // dispensaryAccounting
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispensaryAccounting.DefaultCellStyle = dataGridViewCellStyle5;
            this.dispensaryAccounting.HeaderText = "Диспансерный учет";
            this.dispensaryAccounting.Name = "dispensaryAccounting";
            // 
            // startDateOfTreatment
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateOfTreatment.DefaultCellStyle = dataGridViewCellStyle6;
            this.startDateOfTreatment.HeaderText = "Дата начала лечения";
            this.startDateOfTreatment.Name = "startDateOfTreatment";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(28, 60);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 49);
            this.buttonUpdate.TabIndex = 41;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewPat
            // 
            this.dataGridViewPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_userP,
            this.fio_patient,
            this.birth_patient,
            this.socialStatus_patient,
            this.currentState_patient});
            this.dataGridViewPat.Location = new System.Drawing.Point(904, 182);
            this.dataGridViewPat.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPat.Name = "dataGridViewPat";
            this.dataGridViewPat.Size = new System.Drawing.Size(1059, 457);
            this.dataGridViewPat.TabIndex = 42;
            this.dataGridViewPat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPat_CellContentClick);
            // 
            // id_userP
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_userP.DefaultCellStyle = dataGridViewCellStyle7;
            this.id_userP.HeaderText = "ID";
            this.id_userP.Name = "id_userP";
            this.id_userP.Width = 40;
            // 
            // fio_patient
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_patient.DefaultCellStyle = dataGridViewCellStyle8;
            this.fio_patient.HeaderText = "ФИО пациента";
            this.fio_patient.Name = "fio_patient";
            this.fio_patient.Width = 280;
            // 
            // birth_patient
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_patient.DefaultCellStyle = dataGridViewCellStyle9;
            this.birth_patient.HeaderText = "Дата рождения пациента";
            this.birth_patient.Name = "birth_patient";
            this.birth_patient.Width = 120;
            // 
            // socialStatus_patient
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.socialStatus_patient.DefaultCellStyle = dataGridViewCellStyle10;
            this.socialStatus_patient.HeaderText = "Социальный статус пациента";
            this.socialStatus_patient.Name = "socialStatus_patient";
            this.socialStatus_patient.Width = 160;
            // 
            // currentState_patient
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentState_patient.DefaultCellStyle = dataGridViewCellStyle11;
            this.currentState_patient.HeaderText = "Текущее состояние пациента";
            this.currentState_patient.Name = "currentState_patient";
            this.currentState_patient.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 667);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 72);
            this.label3.TabIndex = 43;
            this.label3.Text = "Для добавления \r\nданных диагноза пациента, \r\nвыберите ID ПАЦИЕНТА, \r\nа затем нажм" +
    "ите на кнопку";
            // 
            // listStatusPat
            // 
            this.listStatusPat.FormattingEnabled = true;
            this.listStatusPat.Items.AddRange(new object[] {
            "ID",
            "ФИО пациента",
            "Дата рождения пациента",
            "Социальный статус пациента",
            "Текущее состояние пациента"});
            this.listStatusPat.Location = new System.Drawing.Point(1028, 85);
            this.listStatusPat.Margin = new System.Windows.Forms.Padding(4);
            this.listStatusPat.Name = "listStatusPat";
            this.listStatusPat.Size = new System.Drawing.Size(281, 24);
            this.listStatusPat.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1023, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 50);
            this.label4.TabIndex = 45;
            this.label4.Text = "Выберите критерий поиска\r\nпо ПАЦИЕНТАМ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(811, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "label1";
            // 
            // AdmChooseDiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 793);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listStatusPat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPat);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listStatusDiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchReaderBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewDiz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdmChooseDiz";
            this.Text = "AdmChooseDiz";
            this.Load += new System.EventHandler(this.AdmChooseDiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listStatusDiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchReaderBox;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewDiz;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambulatoryTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn termOfDisability;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispensaryAccounting;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateOfTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_userP;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialStatus_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentState_patient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox listStatusPat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}