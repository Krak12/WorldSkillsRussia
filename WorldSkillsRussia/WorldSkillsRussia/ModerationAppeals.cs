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
    public partial class ModerationAppeals : Form
    {
        public ModerationAppeals()
        {
            InitializeComponent();
        }

        private void ModerationAppeals_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.MessageList". При необходимости она может быть перемещена или удалена.
            this.messageListTableAdapter.FillMessageList(this.dbDataSet.MessageList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.popular_group". При необходимости она может быть перемещена или удалена.
            this.popular_groupTableAdapter.Fill(this.dbDataSet.popular_group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.dbDataSet.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.dbDataSet.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.messages". При необходимости она может быть перемещена или удалена.
            this.messagesTableAdapter.Fill(this.dbDataSet.messages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.status_message". При необходимости она может быть перемещена или удалена.
            this.status_messageTableAdapter.Fill(this.dbDataSet.status_message);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.federal_districts". При необходимости она может быть перемещена или удалена.
            this.federal_districtsTableAdapter.Fill(this.dbDataSet.federal_districts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.message_categories". При необходимости она может быть перемещена или удалена.
            this.message_categoriesTableAdapter.Fill(this.dbDataSet.message_categories);

            textBox1.Text = Data.staffAutorized.first_name;
            //var typeStaffTA = new dbDataSetTableAdapters.type_staffTableAdapter();
            //Data.TypeStaff = typeStaffTA.GetDataByTypeStaff(textBox2.Text.Trim()).First();
            label2.Text = Data.Events.name;
            
            //message_textListBox.Text = Data.Messages.message_text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
