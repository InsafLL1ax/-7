using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba51DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba51DataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.laba51DataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba51DataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.laba51DataSet.Оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba51DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.laba51DataSet.Студенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            студентыBindingSource.EndEdit();
            оценкиBindingSource.EndEdit();
            предметыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(laba51DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
