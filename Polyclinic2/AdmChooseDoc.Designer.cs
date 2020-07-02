namespace Polyclinic2
{
    partial class AdmChooseDoc
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
            this.dataGridViewDoc = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.searchReaderBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.polyclinicDataSet = new Polyclinic2.PolyclinicDataSet();
            this.buttonUpdateClick = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUALIFICATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPECIALIZATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoc
            // 
            this.dataGridViewDoc.AllowUserToOrderColumns = true;
            this.dataGridViewDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIO,
            this.POSITION,
            this.QUALIFICATION,
            this.SPECIALIZATION});
            this.dataGridViewDoc.Location = new System.Drawing.Point(25, 92);
            this.dataGridViewDoc.Name = "dataGridViewDoc";
            this.dataGridViewDoc.Size = new System.Drawing.Size(1033, 371);
            this.dataGridViewDoc.TabIndex = 0;
            this.dataGridViewDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoc_CellContentClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(958, 487);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 50);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(828, 19);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 20);
            this.userName.TabIndex = 2;
            this.userName.Text = "label1";
            // 
            // searchReaderBox
            // 
            this.searchReaderBox.Location = new System.Drawing.Point(24, 19);
            this.searchReaderBox.Name = "searchReaderBox";
            this.searchReaderBox.Size = new System.Drawing.Size(252, 20);
            this.searchReaderBox.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(319, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 50);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(25, 487);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 50);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(718, 487);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(200, 50);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Изменить данные";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(367, 487);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 50);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(507, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберите критерий поиска";
            // 
            // listStatus
            // 
            this.listStatus.FormattingEnabled = true;
            this.listStatus.Items.AddRange(new object[] {
            "ID",
            "ФИО сотрудника",
            "Должность",
            "Квалификация",
            "Специализация"});
            this.listStatus.Location = new System.Drawing.Point(511, 52);
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(212, 21);
            this.listStatus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(545, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 60);
            this.label5.TabIndex = 15;
            this.label5.Text = "Для изменения \r\nданных пользователя, \r\nвыберите его ID, \r\nа затем нажмите на кноп" +
    "ку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(194, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 60);
            this.label2.TabIndex = 16;
            this.label2.Text = "Для удаления \r\nданных пользователя, \r\nвыберите его ID, \r\nа затем нажмите на кнопк" +
    "у";
            // 
            // polyclinicDataSet
            // 
            this.polyclinicDataSet.DataSetName = "PolyclinicDataSet";
            this.polyclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdateClick
            // 
            this.buttonUpdateClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateClick.Location = new System.Drawing.Point(24, 46);
            this.buttonUpdateClick.Name = "buttonUpdateClick";
            this.buttonUpdateClick.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdateClick.TabIndex = 30;
            this.buttonUpdateClick.Text = "Обновить данные";
            this.buttonUpdateClick.UseVisualStyleBackColor = true;
            this.buttonUpdateClick.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_user";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "fio_doctor";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.FIO.HeaderText = "ФИО сотрудника";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 300;
            // 
            // POSITION
            // 
            this.POSITION.DataPropertyName = "position_doctor";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POSITION.DefaultCellStyle = dataGridViewCellStyle3;
            this.POSITION.HeaderText = "Должность ";
            this.POSITION.Name = "POSITION";
            this.POSITION.ReadOnly = true;
            this.POSITION.Width = 210;
            // 
            // QUALIFICATION
            // 
            this.QUALIFICATION.DataPropertyName = "qualification_doctor";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QUALIFICATION.DefaultCellStyle = dataGridViewCellStyle4;
            this.QUALIFICATION.HeaderText = "Квалификация";
            this.QUALIFICATION.Name = "QUALIFICATION";
            this.QUALIFICATION.ReadOnly = true;
            this.QUALIFICATION.Width = 220;
            // 
            // SPECIALIZATION
            // 
            this.SPECIALIZATION.DataPropertyName = "specialization_doctor";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SPECIALIZATION.DefaultCellStyle = dataGridViewCellStyle5;
            this.SPECIALIZATION.HeaderText = "Специализация";
            this.SPECIALIZATION.Name = "SPECIALIZATION";
            this.SPECIALIZATION.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SPECIALIZATION.Width = 220;
            // 
            // AdmChooseDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 566);
            this.Controls.Add(this.buttonUpdateClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchReaderBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewDoc);
            this.Name = "AdmChooseDoc";
            this.Text = "AdmChooseDoc";
            this.Load += new System.EventHandler(this.AdmChooseDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoc;
        private PolyclinicDataSet polyclinicDataSet;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox searchReaderBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUALIFICATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPECIALIZATION;
    }
}