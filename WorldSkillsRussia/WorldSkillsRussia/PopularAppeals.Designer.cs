namespace WorldSkillsRussia
{
    partial class PopularAppeals
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
            System.Windows.Forms.Label contentLabel;
            System.Windows.Forms.Label message_textLabel;
            System.Windows.Forms.Label federal_districtsLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dbDataSet = new WorldSkillsRussia.dbDataSet();
            this.popular_groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popular_groupTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.popular_groupTableAdapter();
            this.tableAdapterManager = new WorldSkillsRussia.dbDataSetTableAdapters.TableAdapterManager();
            this.federal_districtsTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.federal_districtsTableAdapter();
            this.messagesTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.messagesTableAdapter();
            this.contentComboBox = new System.Windows.Forms.ComboBox();
            this.populargroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.message_textTextBox = new System.Windows.Forms.TextBox();
            this.federal_districtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.media_contentListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.populargroupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            contentLabel = new System.Windows.Forms.Label();
            message_textLabel = new System.Windows.Forms.Label();
            federal_districtsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular_groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federal_districtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contentLabel
            // 
            contentLabel.Location = new System.Drawing.Point(22, 307);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(172, 64);
            contentLabel.TabIndex = 4;
            contentLabel.Text = "Популярная группа";
            // 
            // message_textLabel
            // 
            message_textLabel.Location = new System.Drawing.Point(194, 307);
            message_textLabel.Name = "message_textLabel";
            message_textLabel.Size = new System.Drawing.Size(183, 64);
            message_textLabel.TabIndex = 7;
            message_textLabel.Text = "Обращение";
            // 
            // federal_districtsLabel
            // 
            federal_districtsLabel.Location = new System.Drawing.Point(374, 307);
            federal_districtsLabel.Name = "federal_districtsLabel";
            federal_districtsLabel.Size = new System.Drawing.Size(206, 64);
            federal_districtsLabel.TabIndex = 8;
            federal_districtsLabel.Text = "Федеральный округ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(306, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 34);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Популярные обращения";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.populargroupBindingSource1;
            this.comboBox1.DisplayMember = "content";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 39);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id_popular_group";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popular_groupBindingSource
            // 
            this.popular_groupBindingSource.DataMember = "popular_group";
            this.popular_groupBindingSource.DataSource = this.dbDataSet;
            // 
            // popular_groupTableAdapter
            // 
            this.popular_groupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eventsTableAdapter = null;
            this.tableAdapterManager.federal_districtsTableAdapter = this.federal_districtsTableAdapter;
            this.tableAdapterManager.message_categoriesTableAdapter = null;
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
            // federal_districtsTableAdapter
            // 
            this.federal_districtsTableAdapter.ClearBeforeFill = true;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // contentComboBox
            // 
            this.contentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.popular_groupBindingSource, "content", true));
            this.contentComboBox.DataSource = this.populargroupBindingSource;
            this.contentComboBox.DisplayMember = "content";
            this.contentComboBox.FormattingEnabled = true;
            this.contentComboBox.Location = new System.Drawing.Point(21, 373);
            this.contentComboBox.Name = "contentComboBox";
            this.contentComboBox.Size = new System.Drawing.Size(173, 39);
            this.contentComboBox.TabIndex = 7;
            this.contentComboBox.ValueMember = "Id_popular_group";
            // 
            // populargroupBindingSource
            // 
            this.populargroupBindingSource.DataMember = "popular_group";
            this.populargroupBindingSource.DataSource = this.dbDataSet;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "messages";
            this.messagesBindingSource.DataSource = this.dbDataSet;
            // 
            // message_textTextBox
            // 
            this.message_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messagesBindingSource, "message_text", true));
            this.message_textTextBox.Location = new System.Drawing.Point(200, 374);
            this.message_textTextBox.Name = "message_textTextBox";
            this.message_textTextBox.Size = new System.Drawing.Size(177, 38);
            this.message_textTextBox.TabIndex = 8;
            // 
            // federal_districtsBindingSource
            // 
            this.federal_districtsBindingSource.DataMember = "federal_districts";
            this.federal_districtsBindingSource.DataSource = this.dbDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.federal_districtsBindingSource;
            this.comboBox2.DisplayMember = "federal_districts";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(380, 373);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 39);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "Id_federal_districts";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(577, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 64);
            this.label3.TabIndex = 11;
            this.label3.Text = "Голоса";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(583, 373);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(131, 39);
            this.comboBox3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Голосовать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // media_contentListBox
            // 
            this.media_contentListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.messagesBindingSource, "media_content", true));
            this.media_contentListBox.FormattingEnabled = true;
            this.media_contentListBox.ItemHeight = 31;
            this.media_contentListBox.Location = new System.Drawing.Point(732, 256);
            this.media_contentListBox.Name = "media_contentListBox";
            this.media_contentListBox.Size = new System.Drawing.Size(442, 314);
            this.media_contentListBox.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(732, 576);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 38);
            this.textBox1.TabIndex = 15;
            // 
            // populargroupBindingSource1
            // 
            this.populargroupBindingSource1.DataMember = "popular_group";
            this.populargroupBindingSource1.DataSource = this.dbDataSet;
            // 
            // PopularAppeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldSkillsRussia.Properties.Resources.Прямая_линия_с_Владимиром_Путиным;
            this.ClientSize = new System.Drawing.Size(1200, 631);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.media_contentListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(federal_districtsLabel);
            this.Controls.Add(message_textLabel);
            this.Controls.Add(this.message_textTextBox);
            this.Controls.Add(this.contentComboBox);
            this.Controls.Add(contentLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PopularAppeals";
            this.Text = "Популярные обращения";
            this.Load += new System.EventHandler(this.PopularAppeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular_groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.federal_districtsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource popular_groupBindingSource;
        private dbDataSetTableAdapters.popular_groupTableAdapter popular_groupTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dbDataSetTableAdapters.messagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.ComboBox contentComboBox;
        private System.Windows.Forms.BindingSource populargroupBindingSource;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private dbDataSetTableAdapters.federal_districtsTableAdapter federal_districtsTableAdapter;
        private System.Windows.Forms.TextBox message_textTextBox;
        private System.Windows.Forms.BindingSource federal_districtsBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox media_contentListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource populargroupBindingSource1;
    }
}