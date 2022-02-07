using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public static Users USER { get; set; }
        Model1 db = new Model1();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль");
                return;
            }
            Users usr = db.Users.Find(textBox1.Text);
            if ((usr != null) && (usr.psw == textBox2.Text))
            {
                USER = usr;
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет");
                return;
            }
        }

        private void lPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demDataSet);

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demDataSet.LP". При необходимости она может быть перемещена или удалена.
            this.lPTableAdapter.Fill(this.demDataSet.LP);

        }
    }
}
