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
    public partial class SubmissionAppeal : Form
    {
        public SubmissionAppeal()
        {
            InitializeComponent();
        }

        private void SubmissionAppeal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.messages". При необходимости она может быть перемещена или удалена.
            this.messagesTableAdapter.Fill(this.dbDataSet.messages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.message_categories". При необходимости она может быть перемещена или удалена.
            this.message_categoriesTableAdapter.Fill(this.dbDataSet.message_categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.federal_districts". При необходимости она может быть перемещена или удалена.
            this.federal_districtsTableAdapter.Fill(this.dbDataSet.federal_districts);

            label1.Text = Data.Events.name;

            var userTA = new dbDataSetTableAdapters.userTableAdapter();
            Data.User = userTA.GetDataByFederalDistricts(comboBox1.Text.Trim()).First();

            Data.User.first_name = textBox1.Text;
            Data.User.second_name = textBox2.Text;
            Data.User.patronymic = textBox3.Text;
            Data.User.telephone = textBox4.Text;
            Data.User.email = textBox5.Text;
            Data.User.age = int.Parse(textBox6.Text);

        }
    }
}
