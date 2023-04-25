
namespace Client
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label код_специальностиLabel;
            System.Windows.Forms.Label оценкаLabel;
            System.Windows.Forms.Label расшифровка_предметаLabel;
            this.laba51DataSet = new Client.Laba51DataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new Client.Laba51DataSetTableAdapters.СтудентыTableAdapter();
            this.tableAdapterManager = new Client.Laba51DataSetTableAdapters.TableAdapterManager();
            this.студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.студентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.код_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.оценкиTableAdapter = new Client.Laba51DataSetTableAdapters.ОценкиTableAdapter();
            this.оценкаTextBox = new System.Windows.Forms.TextBox();
            this.предметыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметыTableAdapter = new Client.Laba51DataSetTableAdapters.ПредметыTableAdapter();
            this.расшифровка_предметаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            фИОLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            код_специальностиLabel = new System.Windows.Forms.Label();
            оценкаLabel = new System.Windows.Forms.Label();
            расшифровка_предметаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laba51DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).BeginInit();
            this.студентыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laba51DataSet
            // 
            this.laba51DataSet.DataSetName = "Laba51DataSet";
            this.laba51DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.laba51DataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Client.Laba51DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = this.оценкиTableAdapter;
            this.tableAdapterManager.ПредметыTableAdapter = this.предметыTableAdapter;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            // 
            // студентыBindingNavigator
            // 
            this.студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентыBindingNavigator.BindingSource = this.студентыBindingSource;
            this.студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.студентыBindingNavigatorSaveItem});
            this.студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентыBindingNavigator.Name = "студентыBindingNavigator";
            this.студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентыBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.студентыBindingNavigator.TabIndex = 0;
            this.студентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // студентыBindingNavigatorSaveItem
            // 
            this.студентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.студентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("студентыBindingNavigatorSaveItem.Image")));
            this.студентыBindingNavigatorSaveItem.Name = "студентыBindingNavigatorSaveItem";
            this.студентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.студентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.студентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.студентыBindingNavigatorSaveItem_Click);
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(163, 94);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 1;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(206, 91);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 2;
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(155, 132);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(45, 13);
            группаLabel.TabIndex = 5;
            группаLabel.Text = "Группа:";
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(206, 129);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(100, 20);
            this.группаTextBox.TabIndex = 6;
            // 
            // код_специальностиLabel
            // 
            код_специальностиLabel.AutoSize = true;
            код_специальностиLabel.Location = new System.Drawing.Point(91, 158);
            код_специальностиLabel.Name = "код_специальностиLabel";
            код_специальностиLabel.Size = new System.Drawing.Size(109, 13);
            код_специальностиLabel.TabIndex = 6;
            код_специальностиLabel.Text = "Код специальности:";
            // 
            // код_специальностиTextBox
            // 
            this.код_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Код специальности", true));
            this.код_специальностиTextBox.Location = new System.Drawing.Point(206, 155);
            this.код_специальностиTextBox.Name = "код_специальностиTextBox";
            this.код_специальностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_специальностиTextBox.TabIndex = 7;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // оценкаLabel
            // 
            оценкаLabel.AutoSize = true;
            оценкаLabel.Location = new System.Drawing.Point(152, 239);
            оценкаLabel.Name = "оценкаLabel";
            оценкаLabel.Size = new System.Drawing.Size(48, 13);
            оценкаLabel.TabIndex = 7;
            оценкаLabel.Text = "Оценка:";
            // 
            // оценкаTextBox
            // 
            this.оценкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка", true));
            this.оценкаTextBox.Location = new System.Drawing.Point(206, 236);
            this.оценкаTextBox.Name = "оценкаTextBox";
            this.оценкаTextBox.Size = new System.Drawing.Size(100, 20);
            this.оценкаTextBox.TabIndex = 8;
            // 
            // предметыBindingSource
            // 
            this.предметыBindingSource.DataMember = "Предметы";
            this.предметыBindingSource.DataSource = this.laba51DataSet;
            // 
            // предметыTableAdapter
            // 
            this.предметыTableAdapter.ClearBeforeFill = true;
            // 
            // расшифровка_предметаLabel
            // 
            расшифровка_предметаLabel.AutoSize = true;
            расшифровка_предметаLabel.Location = new System.Drawing.Point(145, 203);
            расшифровка_предметаLabel.Name = "расшифровка_предметаLabel";
            расшифровка_предметаLabel.Size = new System.Drawing.Size(55, 13);
            расшифровка_предметаLabel.TabIndex = 9;
            расшифровка_предметаLabel.Text = "Предмет:";
            // 
            // расшифровка_предметаTextBox
            // 
            this.расшифровка_предметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.предметыBindingSource, "Расшифровка предмета", true));
            this.расшифровка_предметаTextBox.Location = new System.Drawing.Point(206, 200);
            this.расшифровка_предметаTextBox.Name = "расшифровка_предметаTextBox";
            this.расшифровка_предметаTextBox.Size = new System.Drawing.Size(100, 20);
            this.расшифровка_предметаTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Таблица";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "СтудентыОценки";
            this.оценкиBindingSource.DataSource = this.студентыBindingSource;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 40);
            this.button4.TabIndex = 14;
            this.button4.Text = "Таблица оценки";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 40);
            this.button5.TabIndex = 15;
            this.button5.Text = "Таблица Предметы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(расшифровка_предметаLabel);
            this.Controls.Add(this.расшифровка_предметаTextBox);
            this.Controls.Add(оценкаLabel);
            this.Controls.Add(this.оценкаTextBox);
            this.Controls.Add(код_специальностиLabel);
            this.Controls.Add(this.код_специальностиTextBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.студентыBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laba51DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).EndInit();
            this.студентыBindingNavigator.ResumeLayout(false);
            this.студентыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Laba51DataSet laba51DataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private Laba51DataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private Laba51DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator студентыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton студентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox;
        private Laba51DataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox код_специальностиTextBox;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private Laba51DataSetTableAdapters.ПредметыTableAdapter предметыTableAdapter;
        private System.Windows.Forms.TextBox оценкаTextBox;
        private System.Windows.Forms.BindingSource предметыBindingSource;
        private System.Windows.Forms.TextBox расшифровка_предметаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}