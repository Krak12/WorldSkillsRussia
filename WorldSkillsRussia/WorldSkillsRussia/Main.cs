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

            textBox3.UseSystemPasswordChar = true;

            var eventTA = new dbDataSetTableAdapters.eventsTableAdapter();
            Data.Events = eventTA.GetDataByName(comboBox1.Text.Trim()).First();

            textBox1.Text = Data.Events.name;
            textBox4.Text = Data.Events.year.ToString();
            textBox5.Text = Data.Events.description;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // настройка ввода логина или пароля
            var staffTA = new dbDataSetTableAdapters.staffTableAdapter();
            var staffs = staffTA.GetDataByLoginAndPass(textBox2.Text, textBox3.Text);

            if (staffs.Count == 0)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // переходы по формам, зависящие от Id_staff_type_staff
            Data.staffAutorized = staffTA.GetDataByLogin(textBox2.Text.Trim()).First();

            if (Data.staffAutorized.Id_staff_type_staff == 3)
            {
                Form ma = new ModerationAppeals();
                Hide();
                DialogResult res = ma.ShowDialog();
                if (res != DialogResult.Cancel)
                {
                    Show();
                }
                else Close();
            }
            else if (Data.staffAutorized.Id_staff_type_staff == 5)
            {
                Form et = new EssentialTreatment();
                Hide();
                DialogResult res = et.ShowDialog();
                if (res != DialogResult.Cancel)
                {
                    Show();
                }
                else Close();
            }
            else if (Data.staffAutorized.Id_staff_type_staff == 2)
            {
                Form r = new Reception();
                Hide();
                DialogResult res = r.ShowDialog();
                if (res != DialogResult.Cancel)
                {
                    Show();
                }
                else Close();
            }
            else if (Data.staffAutorized.Id_staff_type_staff == 1)
            {
                Form em = new EventManagement();
                Hide();
                DialogResult res = em.ShowDialog();
                if (res != DialogResult.Cancel)
                {
                    Show();
                }
                else Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sa = new SubmissionAppeal();
            Hide();
            DialogResult res = sa.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form pa = new PopularAppeals();
            Hide();
            DialogResult res = pa.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }
    }
}
