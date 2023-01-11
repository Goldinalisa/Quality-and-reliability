using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr3_Quality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        /// <summary>
        /// Авторизация пользователя в системе.
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        public void Autorization(string login, string password)
        {
            Console.WriteLine("Ввод логина и пароля");
        }

        /// <summary>
        /// Регистрация пользователя в системе.
        /// </summary>
        /// <param name="email">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <param name="lasttName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronymic">Отчество</param>
        public void Autentification(string email, string password, string lasttName, string firstName, string patronymic)
        {
            Console.WriteLine("Ввод личных данных для регистрации нового пользователя");
        }

        /// <summary>
        /// Создание заявки.
        /// </summary>
        /// <param name="idUser">Идентификатор менеджера</param>
        /// <param name="idClient">Идентификатор клиента</param>
        /// <param name="idB">Идентификатор заявки</param>
        /// <param name="TypeAds">Вид вывески</param>
        public void CreateBid(int idUser,int idClient, int idB, string TypeAds)
        {
            Console.WriteLine("Создание заявки");
        }

        /// <summary>
        /// Удаление заявки.
        /// </summary>
        /// <param name="idB">Идентификатор заявки</param>
        public void DeleteBid(int idB)
        {
            Console.WriteLine("Удаление заявки");
        }

        /// <summary>
        /// Редактирование заявки.
        /// </summary>
        /// <param name="idB">Идентфиикатор заявки</param>
        public void EditBid(int idB)
        {
            Console.WriteLine("Редактирование заявки");
        }

        /// <summary>
        /// Передача заявки.
        /// </summary>
        /// <param name="idUserFrom">Идентификатор передающего заявку менеджера</param>
        /// <param name="idUserTo">Идентификатор принимающего заявку менеджера</param>
        /// <param name="idB">Идентификатор заявки</param>
        public void СonveyBid(int idUserFrom, int idUserTo, int idB)
        {
            Console.WriteLine("Передача заявки");
        }

        /// <summary>
        /// Сохранение изменений.
        /// </summary>
        /// <param name="idB">Идентификатор заявки</param>
        /// <param name="idUser">Идентификатор менеджера</param>
        public void SaveChanges(int idB, int idUser)
        {
            Console.WriteLine("Сохранение изменений");
        }

        /// <summary>
        /// Функция выхода из системы
        /// </summary>
        /// <param name="idUser">Идентификатор менеджера</param>
        public void SignOut(int idUser)
        {
          
        }

        /// <summary>
        /// Функция закрытия заявки.
        /// </summary>
        /// <param name="idUser">Идентификатор менеджера</param>
        /// <param name="idB">Идентификатор клиента</param>
        public void CloseBid(int idUser, int idB)
        {

        }

        /// <summary>
        /// Функция проверки роли пользователя
        /// </summary>
        /// <param name="idUser">Идентификатор менеджера</param>
        public void CheckRole(int idUser)
        {

        }

    }
}

