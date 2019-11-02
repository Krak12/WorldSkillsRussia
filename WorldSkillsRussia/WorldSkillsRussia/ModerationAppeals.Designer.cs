namespace WorldSkillsRussia
{
    partial class ModerationAppeals
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.messagecategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new WorldSkillsRussia.dbDataSet();
            this.message_categoriesTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.message_categoriesTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.federaldistrictsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.federal_districtsTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.federal_districtsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.statusmessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status_messageTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.status_messageTableAdapter();
            this.messagesTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.messagesTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new WorldSkillsRussia.dbDataSetTableAdapters.TableAdapterManager();
            this.popular_groupTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.popular_groupTableAdapter();
            this.userTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.userTableAdapter();
            this.message_textListBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userListBox = new System.Windows.Forms.ListBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.populargroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messagecategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federaldistrictsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmessageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 38);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 38);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.messagecategoriesBindingSource;
            this.comboBox1.DisplayMember = "message_categories";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 39);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id_message_categories";
            // 
            // messagecategoriesBindingSource
            // 
            this.messagecategoriesBindingSource.DataMember = "message_categories";
            this.messagecategoriesBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // message_categoriesTableAdapter
            // 
            this.message_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.federaldistrictsBindingSource;
            this.comboBox2.DisplayMember = "federal_districts";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 39);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Id_federal_districts";
            // 
            // federaldistrictsBindingSource
            // 
            this.federaldistrictsBindingSource.DataMember = "federal_districts";
            this.federaldistrictsBindingSource.DataSource = this.dbDataSet;
            // 
            // federal_districtsTableAdapter
            // 
            this.federal_districtsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.statusmessageBindingSource;
            this.comboBox3.DisplayMember = "status_message";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(13, 194);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(216, 39);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "Id_status_message";
            // 
            // statusmessageBindingSource
            // 
            this.statusmessageBindingSource.DataMember = "status_message";
            this.statusmessageBindingSource.DataSource = this.dbDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.messagesBindingSource;
            this.comboBox4.DisplayMember = "processed";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 240);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(216, 39);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "Id_message";
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "messages";
            this.messagesBindingSource.DataSource = this.dbDataSet;
            // 
            // status_messageTableAdapter
            // 
            this.status_messageTableAdapter.ClearBeforeFill = true;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 285);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 252);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Модерация обращений";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eventsTableAdapter = null;
            this.tableAdapterManager.federal_districtsTableAdapter = this.federal_districtsTableAdapter;
            this.tableAdapterManager.message_categoriesTableAdapter = this.message_categoriesTableAdapter;
            this.tableAdapterManager.message_processingTableAdapter = null;
            this.tableAdapterManager.messagesTableAdapter = this.messagesTableAdapter;
            this.tableAdapterManager.popular_groupTableAdapter = this.popular_groupTableAdapter;
            this.tableAdapterManager.popular_messagesTableAdapter = null;
            this.tableAdapterManager.staff_eventTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.status_messageTableAdapter = this.status_messageTableAdapter;
            this.tableAdapterManager.type_messageTableAdapter = null;
            this.tableAdapterManager.type_staffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldSkillsRussia.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // popular_groupTableAdapter
            // 
            this.popular_groupTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // message_textListBox
            // 
            this.message_textListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.messagesBindingSource, "message_text", true));
            this.message_textListBox.FormattingEnabled = true;
            this.message_textListBox.ItemHeight = 31;
            this.message_textListBox.Location = new System.Drawing.Point(247, 148);
            this.message_textListBox.Name = "message_textListBox";
            this.message_textListBox.Size = new System.Drawing.Size(532, 221);
            this.message_textListBox.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(812, 148);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(376, 221);
            this.listBox2.TabIndex = 12;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.dbDataSet;
            // 
            // userListBox
            // 
            this.userListBox.DataSource = this.userBindingSource;
            this.userListBox.DisplayMember = "first_name";
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 31;
            this.userListBox.Location = new System.Drawing.Point(247, 392);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(725, 66);
            this.userListBox.TabIndex = 12;
            this.userListBox.ValueMember = "Id_user";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.populargroupBindingSource;
            this.comboBox5.DisplayMember = "content";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(322, 478);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(650, 39);
            this.comboBox5.TabIndex = 13;
            this.comboBox5.ValueMember = "Id_popular_group";
            // 
            // populargroupBindingSource
            // 
            this.populargroupBindingSource.DataMember = "popular_group";
            this.populargroupBindingSource.DataSource = this.dbDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1010, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "В эфир";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 559);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 38);
            this.textBox4.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 74);
            this.button3.TabIndex = 16;
            this.button3.Text = "отклонить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(492, 523);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 74);
            this.button4.TabIndex = 17;
            this.button4.Text = "в обработку";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(677, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 74);
            this.button5.TabIndex = 18;
            this.button5.Text = "завершено";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(851, 523);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 74);
            this.button6.TabIndex = 19;
            this.button6.Text = "в группу популярных";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(279, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 34);
            this.label2.TabIndex = 20;
            // 
            // ModerationAppeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldSkillsRussia.Properties.Resources.Прямая_линия_с_Владимиром_Путиным;
            this.ClientSize = new System.Drawing.Size(1200, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.message_textListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ModerationAppeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модерация обращений";
            this.Load += new System.EventHandler(this.ModerationAppeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messagecategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.federaldistrictsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmessageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource messagecategoriesBindingSource;
        private dbDataSetTableAdapters.message_categoriesTableAdapter message_categoriesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource federaldistrictsBindingSource;
        private dbDataSetTableAdapters.federal_districtsTableAdapter federal_districtsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource statusmessageBindingSource;
        private dbDataSetTableAdapters.status_messageTableAdapter status_messageTableAdapter;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private dbDataSetTableAdapters.messagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox message_textListBox;
        private System.Windows.Forms.ListBox listBox2;
        private dbDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ListBox userListBox;
        private dbDataSetTableAdapters.popular_groupTableAdapter popular_groupTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource populargroupBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
    }
}