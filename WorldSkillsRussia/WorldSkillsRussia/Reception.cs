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
    public partial class Reception : Form
    {
        public Reception()
        {
            InitializeComponent();
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.popular_group". При необходимости она может быть перемещена или удалена.
            this.popular_groupTableAdapter.Fill(this.dbDataSet.popular_group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.message_categories". При необходимости она может быть перемещена или удалена.
            this.message_categoriesTableAdapter.Fill(this.dbDataSet.message_categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.federal_districts". При необходимости она может быть перемещена или удалена.
            this.federal_districtsTableAdapter.Fill(this.dbDataSet.federal_districts);

            label2.Text = Data.Events.name;

            textBox8.Text = Data.User.first_name;
            textBox9.Text = Data.User.second_name;
            textBox7.Text = Data.User.patronymic;
            textBox3.Text = Data.User.telephone;
            textBox2.Text = Data.User.email;
            textBox1.Text = Data.User.age.ToString();

            //message_textListBox.Text = Data.Messages.message_text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
