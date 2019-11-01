namespace WorldSkillsRussia
{
    partial class EventManagement
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dbDataSet = new WorldSkillsRussia.dbDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new WorldSkillsRussia.dbDataSetTableAdapters.TableAdapterManager();
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(157, 38);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(157, 38);
            this.textBox6.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Управление текущим или предстоящим мероприятием";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(998, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 38);
            this.textBox1.TabIndex = 25;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.dbDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eventsTableAdapter = null;
            this.tableAdapterManager.federal_districtsTableAdapter = null;
            this.tableAdapterManager.message_categoriesTableAdapter = null;
            this.tableAdapterManager.message_processingTableAdapter = null;
            this.tableAdapterManager.messagesTableAdapter = null;
            this.tableAdapterManager.popular_groupTableAdapter = null;
            this.tableAdapterManager.popular_messagesTableAdapter = null;
            this.tableAdapterManager.staff_eventTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.status_messageTableAdapter = null;
            this.tableAdapterManager.type_messageTableAdapter = null;
            this.tableAdapterManager.type_staffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldSkillsRussia.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // staffListBox
            // 
            this.staffListBox.DataSource = this.staffBindingSource;
            this.staffListBox.DisplayMember = "first_name";
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.ItemHeight = 31;
            this.staffListBox.Location = new System.Drawing.Point(13, 179);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(1175, 190);
            this.staffListBox.TabIndex = 26;
            this.staffListBox.ValueMember = "Id_satff";
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(13, 376);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 190);
            this.listBox1.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(13, 581);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(457, 38);
            this.textBox10.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(287, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(661, 34);
            this.label2.TabIndex = 44;
            // 
            // EventManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldSkillsRussia.Properties.Resources.Прямая_линия_с_Владимиром_Путиным;
            this.ClientSize = new System.Drawing.Size(1199, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.staffListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EventManagement";
            this.Text = "Управление мероприятием";
            this.Load += new System.EventHandler(this.EventManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private dbDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label2;
    }
}