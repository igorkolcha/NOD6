using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOD6
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }




// Ваша строка подключения для SQLite
static string connectionString = @"Data Source=NOD.db;Version=3;";

    // Предполагается, что методы textBoxФамилия.Text, textBoxИмя.Text и textBoxОтчество.Text доступны
    // в контексте вызова, или же они должны быть переданы как параметры.
    // Я перепишу метод, чтобы он принимал данные для вставки как параметры для лучшей архитектуры.

    /// <summary>
    /// Выполняет команду INSERT в базу данных SQLite, используя параметризованный запрос.
    /// </summary>
    /// <param name="connectionString">Строка подключения к базе данных SQLite.</param>
    /// <param name="Фамилия">Текст из textBoxФамилия.</param>
    /// <param name="Имя">Текст из textBoxИмя.</param>
    /// <param name="Отчество">Текст из textBoxОтчество.</param>
    void InsertTables(string connectionString, string Фамилия, string Имя, string Отчество)
    {
        // Используем SQLiteConnection
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            try
            {
                // Попытка открытия соединения
                connection.Open();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Нет подключения к базе данных SQLite: {ex.Message}");
                return; // Выходим в случае ошибки подключения
            }

            // 1. Используем SQLiteCommand для выполнения не-SELECT запроса
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                try
                {
                    // Формируем полное ФИО
                    string fullFIO = $"{Фамилия} {Имя} {Отчество}";

                    // 2. Используем параметризованный запрос! 
                    // Это очень важно для безопасности и корректной работы с данными.
                    command.CommandText = "INSERT INTO shch (fio) VALUES (@FIO)";

                    // 3. Добавляем параметр
                    command.Parameters.AddWithValue("@FIO", fullFIO);

                    // 4. Выполняем команду, которая не возвращает набор данных
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Добавлен работник: {Фамилия} {Имя}");
                    }
                    else
                    {
                        MessageBox.Show("Запись не была добавлена.");
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Ошибка при выполнении INSERT-запроса: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла общая ошибка: {ex.Message}");
                }
                // Соединение закроется автоматически благодаря using для SQLiteConnection
            }
        }
    }
    private void button_FormAE_Click(object sender, EventArgs e)
        {
            if(textBox_FormAE_LastName.Text == "")
            {
                MessageBox.Show("Введите фамилию");
            }
            else if(textBox_FormAE_FirsName.Text == "")
            {
                {
                    MessageBox.Show("Введите фамилию");
                }
            }
            else if(textBox_FormAE_Patronymic.Text == "")
            {
                MessageBox.Show("Введите фамилию");
            }
            else
            { InsertTables(connectionString, textBox_FormAE_LastName.Text, textBox_FormAE_FirsName.Text, textBox_FormAE_Patronymic.Text); }
        }
    }
}
