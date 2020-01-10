using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db1DataSet.services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.db1DataSet.services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db1DataSet.paid". При необходимости она может быть перемещена или удалена.
            this.paidTableAdapter.Fill(this.db1DataSet.paid);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db1DataSet.paid_z". При необходимости она может быть перемещена или удалена.
            this.paid_zTableAdapter.Fill(this.db1DataSet.paid_z);

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            paidzBindingSource.Filter = comboBox1.DisplayMember + " = " + comboBox1.Text.ToString();
        }
    }
}
