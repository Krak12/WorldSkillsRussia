namespace WorldSkillsRussia
{
    partial class EssentialTreatment
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dbDataSet = new WorldSkillsRussia.dbDataSet();
            this.populargroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popular_groupTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.popular_groupTableAdapter();
            this.messagecategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.message_categoriesTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.message_categoriesTableAdapter();
            this.federaldistrictsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.federal_districtsTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.federal_districtsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.messagesTableAdapter();
            this.tableAdapterManager = new WorldSkillsRussia.dbDataSetTableAdapters.TableAdapterManager();
            this.message_textListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagecategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federaldistrictsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(661, 38);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(157, 38);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(157, 38);
            this.textBox6.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Эфирные обращения";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.messagecategoriesBindingSource;
            this.comboBox1.DisplayMember = "message_categories";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(448, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 39);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "Id_message_categories";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.populargroupBindingSource;
            this.comboBox2.DisplayMember = "content";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(320, 39);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "Id_popular_group";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.federaldistrictsBindingSource;
            this.comboBox3.DisplayMember = "federal_districts";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(774, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(320, 39);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "Id_federal_districts";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // populargroupBindingSource
            // 
            this.populargroupBindingSource.DataMember = "popular_group";
            this.populargroupBindingSource.DataSource = this.dbDataSet;
            // 
            // popular_groupTableAdapter
            // 
            this.popular_groupTableAdapter.ClearBeforeFill = true;
            // 
            // messagecategoriesBindingSource
            // 
            this.messagecategoriesBindingSource.DataMember = "message_categories";
            this.messagecategoriesBindingSource.DataSource = this.dbDataSet;
            // 
            // message_categoriesTableAdapter
            // 
            this.message_categoriesTableAdapter.ClearBeforeFill = true;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(13, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1176, 252);
            this.listBox1.TabIndex = 19;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "messages";
            this.messagesBindingSource.DataSource = this.dbDataSet;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.status_messageTableAdapter = null;
            this.tableAdapterManager.type_messageTableAdapter = null;
            this.tableAdapterManager.type_staffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldSkillsRussia.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // message_textListBox
            // 
            this.message_textListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.messagesBindingSource, "message_text", true));
            this.message_textListBox.FormattingEnabled = true;
            this.message_textListBox.ItemHeight = 31;
            this.message_textListBox.Location = new System.Drawing.Point(782, 466);
            this.message_textListBox.Name = "message_textListBox";
            this.message_textListBox.Size = new System.Drawing.Size(406, 159);
            this.message_textListBox.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 73);
            this.button2.TabIndex = 21;
            this.button2.Text = "Потметить как отвечен ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EssentialTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldSkillsRussia.Properties.Resources.Прямая_линия_с_Владимиром_Путиным;
            this.ClientSize = new System.Drawing.Size(1200, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.message_textListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EssentialTreatment";
            this.Text = "Эфирные обращения";
            this.Load += new System.EventHandler(this.EssentialTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagecategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.federaldistrictsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource populargroupBindingSource;
        private dbDataSetTableAdapters.popular_groupTableAdapter popular_groupTableAdapter;
        private System.Windows.Forms.BindingSource messagecategoriesBindingSource;
        private dbDataSetTableAdapters.message_categoriesTableAdapter message_categoriesTableAdapter;
        private System.Windows.Forms.BindingSource federaldistrictsBindingSource;
        private dbDataSetTableAdapters.federal_districtsTableAdapter federal_districtsTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private dbDataSetTableAdapters.messagesTableAdapter messagesTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox message_textListBox;
        private System.Windows.Forms.Button button2;
    }
}