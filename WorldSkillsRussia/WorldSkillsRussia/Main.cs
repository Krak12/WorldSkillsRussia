using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsRussia
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.events". При необходимости она может быть перемещена или удалена.
            this.eventsTableAdapter.Fill(this.dbDataSet.events);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // настройка ввода логина или пароля
            var staffTA = new dbDataSetTableAdapters.staffTableAdapter();
            var staffs = staffTA.GetDataByLoginAndPass(textBox2.Text, textBox3.Text);

            if (staffs.Count == 0)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // переходы по формам, зависящие от type_staff
            Data.staffAutorized = staffTA.GetDataByLogin(textBox2.Text.Trim()).First();

            if (Data.staffAutorized.Id_staff_type_staff == 1)
            {
                Form t = new Treatments();
                Hide();
                DialogResult res = t.ShowDialog();
                if (res != DialogResult.Cancel)
                {
                    Show();
                }
                else Close();
            }
        }
    }
}
