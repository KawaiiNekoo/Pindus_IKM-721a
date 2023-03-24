using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pindus_IKM_721a
{
    public partial class Form1 : Form
    {
        private bool Mode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Mode = true;
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Минуло 25 секунд", "Увага");
            tClock.Start();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                tClock.Start();
                tbInput.Enabled = true;
                tbInput.Focus();
                bStart.Text = "Стоп"; 
                this.Mode = false;
            }
            else
            {
                tClock.Stop();
                tbInput.Enabled = false;
                bStart.Text = "Пуск";
                this.Mode = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if ((e.KeyChar >= '0') & (e.KeyChar <= '9') | (e.KeyChar == (char)8))
            {
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("Неправильний символ", "Помилка");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }
    }
}
