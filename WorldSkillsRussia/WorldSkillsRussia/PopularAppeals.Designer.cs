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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopularAppeals));
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
            this.popular_groupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.popular_groupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contentComboBox = new System.Windows.Forms.ComboBox();
            this.populargroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.messagesTableAdapter();
            this.message_textTextBox = new System.Windows.Forms.TextBox();
            this.federal_districtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.federal_districtsTableAdapter = new WorldSkillsRussia.dbDataSetTableAdapters.federal_districtsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            contentLabel = new System.Windows.Forms.Label();
            message_textLabel = new System.Windows.Forms.Label();
            federal_districtsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular_groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular_groupBindingNavigator)).BeginInit();
            this.popular_groupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federal_districtsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 39);
            this.comboBox1.TabIndex = 3;
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
            // popular_groupBindingNavigator
            // 
            this.popular_groupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.popular_groupBindingNavigator.BindingSource = this.popular_groupBindingSource;
            this.popular_groupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.popular_groupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.popular_groupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.popular_groupBindingNavigatorSaveItem});
            this.popular_groupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.popular_groupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.popular_groupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.popular_groupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.popular_groupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.popular_groupBindingNavigator.Name = "popular_groupBindingNavigator";
            this.popular_groupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.popular_groupBindingNavigator.Size = new System.Drawing.Size(1200, 25);
            this.popular_groupBindingNavigator.TabIndex = 4;
            this.popular_groupBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // popular_groupBindingNavigatorSaveItem
            // 
            this.popular_groupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.popular_groupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("popular_groupBindingNavigatorSaveItem.Image")));
            this.popular_groupBindingNavigatorSaveItem.Name = "popular_groupBindingNavigatorSaveItem";
            this.popular_groupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.popular_groupBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.popular_groupBindingNavigatorSaveItem.Click += new System.EventHandler(this.popular_groupBindingNavigatorSaveItem_Click);
            // 
            // contentLabel
            // 
            contentLabel.Location = new System.Drawing.Point(22, 307);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(172, 64);
            contentLabel.TabIndex = 4;
            contentLabel.Text = "Популярная группа";
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
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // message_textLabel
            // 
            message_textLabel.Location = new System.Drawing.Point(194, 307);
            message_textLabel.Name = "message_textLabel";
            message_textLabel.Size = new System.Drawing.Size(183, 64);
            message_textLabel.TabIndex = 7;
            message_textLabel.Text = "Обращение";
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
            // federal_districtsTableAdapter
            // 
            this.federal_districtsTableAdapter.ClearBeforeFill = true;
            // 
            // federal_districtsLabel
            // 
            federal_districtsLabel.Location = new System.Drawing.Point(374, 307);
            federal_districtsLabel.Name = "federal_districtsLabel";
            federal_districtsLabel.Size = new System.Drawing.Size(206, 64);
            federal_districtsLabel.TabIndex = 8;
            federal_districtsLabel.Text = "Федеральный округ";
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
            // PopularAppeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldSkillsRussia.Properties.Resources.Прямая_линия_с_Владимиром_Путиным;
            this.ClientSize = new System.Drawing.Size(1200, 631);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(federal_districtsLabel);
            this.Controls.Add(message_textLabel);
            this.Controls.Add(this.message_textTextBox);
            this.Controls.Add(this.contentComboBox);
            this.Controls.Add(contentLabel);
            this.Controls.Add(this.popular_groupBindingNavigator);
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
            ((System.ComponentModel.ISupportInitialize)(this.popular_groupBindingNavigator)).EndInit();
            this.popular_groupBindingNavigator.ResumeLayout(false);
            this.popular_groupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.populargroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.federal_districtsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingNavigator popular_groupBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton popular_groupBindingNavigatorSaveItem;
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
    }
}