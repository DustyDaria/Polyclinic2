using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic2
{
    public partial class ChangeDoc : Form
    {
        DataBase dataBase = new DataBase();

        public int cellID, returnIDmain; 

        public string Log = String.Empty, Pass = String.Empty, FIO = String.Empty; //После инициализации лучше сразу присваивать 
        public string Position = String.Empty, Qualif = String.Empty, Specializ = String.Empty; //переменным значение пустой строки

        public string loginChange = String.Empty, passChange = String.Empty, fioChange = String.Empty;
        public string positionChange = String.Empty, qualifChange = String.Empty, specializChange = String.Empty;

        public ChangeDoc(int ID, int IDmain) 
        {
            InitializeComponent();
            cellID = ID; //присваиваем глобальным переменным значение переменной, полученной в аргументах при создании формы
            returnIDmain = IDmain; 
            
            string queryLog = String.Format("Select login From Users Where id_user = '{0}'", cellID); //все данные получаются из БД по 
            string queryPass = String.Format("Select password From Users Where id_user = '{0}'", cellID);//айдишнику (который мы выбрали нажав по ячейке ID)
            string queryFIO = String.Format("Select fio_doctor From Doctor Where id_user = '{0}'", cellID);
            string queryPosition = String.Format("Select position_doctor From Doctor Where id_user = '{0}'", cellID);
            string queryQualif = String.Format("Select qualification_doctor From Doctor Where id_user = '{0}'", cellID);
            string querySpecializ = String.Format("Select specialization_doctor From Doctor Where id_user = '{0}'", cellID);


            //Получаем данные из БД и записываем их в необходимые переменные
            Log = dataBase.getResult(queryLog);
            Pass = dataBase.getResult(queryPass);
            FIO = dataBase.getResult(queryFIO);
            Position = dataBase.getResult(queryPosition);
            Qualif = dataBase.getResult(queryQualif);
            Specializ = dataBase.getResult(querySpecializ);


            // Заполняем текстовые поля полученными данными
            logBox.Text = Log;
            passBox.Text = Pass;
            fioBox.Text = FIO;
            positionBox.Text = Position;
            qualifBox.Text = Qualif;
            specializBox.Text = Specializ;
        } //На этой строчке форма полностью загрузилась

        private void buttonChange_Click(object sender, EventArgs e) //Кнопка "Изменить"
        {
            //Записываем все данные, полученные из текстовых полей в переменные
            loginChange = logBox.Text;
            passChange = passBox.Text;
            fioChange = fioBox.Text;
            positionChange = positionBox.Text;
            qualifChange = qualifBox.Text;
            specializChange = specializBox.Text;


            //Проверка на незаполненные поля
            if (loginChange == "")
                MessageBox.Show("Введите логин");
            else if (passChange == "")
                MessageBox.Show("Введите пароль");
            else if (fioChange == "")
                MessageBox.Show("Введите ФИО врача");
            else if (positionChange == "")
                MessageBox.Show("Введите должность врача");
            else if (qualifChange == "")
                MessageBox.Show("Введите квалификацию врача");
            else if (specializChange == "")
                MessageBox.Show("Введите специализацию врача");
            else // если все поля заполнены сработает эта ветка
            {
                string queryProfile = String.Format("Update Doctor Set fio_doctor = '" + fioChange + "', position_doctor = '" //Запрос на обновление данных 
                    + positionChange + "', qualification_doctor = '" + qualifChange + "', specialization_doctor = '" // в таблице доктора в БД 
                    + specializChange + "' Where id_user = '" + cellID + "'");
                dataBase.Update(queryProfile); //Вызов метода для обновления данных в БД (передача запроса)

                //Запрос на обновление данных в таблице юзера в БД 
                string queryUsers = String.Format("Update Users Set login = '"+loginChange+"', password = '"+passChange+"' Where id_user = '"+cellID+"'");
                dataBase.Update(queryUsers); //Вызов метода для обновления данных в БД (передача запроса)

                MessageBox.Show("Пользователь изменен"); //Оповещение
            }

            ChooseDoc admChooseDoc = new ChooseDoc(returnIDmain); //Возврат на предыдущую форму (в параметр как раз передаем ID авторизованного пользователя)
            this.Hide();
            admChooseDoc.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e) //Кнопка выхода
        {
            ChooseDoc admChooseDoc = new ChooseDoc(returnIDmain);
            this.Hide();
            admChooseDoc.Show();
        }
    }
}
