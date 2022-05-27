using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Samostoyatel_naya
{
    public partial class Form3 : Form
    {
        private string name;
        private string name1;

        public Form3()
        {
            InitializeComponent();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                name1 = Path.GetFileNameWithoutExtension(name);
                this.Text = name1;
                textBox1.Text = File.ReadLines(name).ElementAtOrDefault(0);
                textBox2.Text = File.ReadLines(name).ElementAtOrDefault(1);
                textBox3.Text = File.ReadLines(name).ElementAtOrDefault(2);
                textBox4.Text = File.ReadLines(name).ElementAtOrDefault(3);
                textBox5.Text = File.ReadLines(name).ElementAtOrDefault(4);
                textBox6.Text = File.ReadLines(name).ElementAtOrDefault(5);
                textBox7.Text = File.ReadLines(name).ElementAtOrDefault(6);
                textBox8.Text = File.ReadLines(name).ElementAtOrDefault(7);
                textBox9.Text = File.ReadLines(name).ElementAtOrDefault(8);
                textBox10.Text = File.ReadLines(name).ElementAtOrDefault(9);
                textBox11.Text = File.ReadLines(name).ElementAtOrDefault(10);
                textBox12.Text = File.ReadLines(name).ElementAtOrDefault(11);
                textBox13.Text = File.ReadLines(name).ElementAtOrDefault(12);
                textBox14.Text = File.ReadLines(name).ElementAtOrDefault(13);
                textBox15.Text = File.ReadLines(name).ElementAtOrDefault(14);
                textBox16.Text = File.ReadLines(name).ElementAtOrDefault(15);
                textBox17.Text = File.ReadLines(name).ElementAtOrDefault(16);
                textBox18.Text = File.ReadLines(name).ElementAtOrDefault(17);
                textBox19.Text = File.ReadLines(name).ElementAtOrDefault(18);
                textBox20.Text = File.ReadLines(name).ElementAtOrDefault(19);
                textBox21.Text = File.ReadLines(name).ElementAtOrDefault(20);
                textBox22.Text = File.ReadLines(name).ElementAtOrDefault(21);
                textBox23.Text = File.ReadLines(name).ElementAtOrDefault(22);
                textBox24.Text = File.ReadLines(name).ElementAtOrDefault(23);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar !=46)
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Text != name1)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name = saveFileDialog1.FileName;
                    File.AppendAllText(name, textBox1.Text);
                    File.AppendAllText(name, "\n" + textBox2.Text);
                    File.AppendAllText(name, "\n" + textBox3.Text);
                    File.AppendAllText(name, "\n" + textBox4.Text);
                    File.AppendAllText(name, "\n" + textBox5.Text);
                    File.AppendAllText(name, "\n" + textBox6.Text);
                    File.AppendAllText(name, "\n" + textBox7.Text);
                    File.AppendAllText(name, "\n" + textBox8.Text);
                    File.AppendAllText(name, "\n" + textBox9.Text);
                    File.AppendAllText(name, "\n" + textBox10.Text);
                    File.AppendAllText(name, "\n" + textBox11.Text);
                    File.AppendAllText(name, "\n" + textBox12.Text);
                    File.AppendAllText(name, "\n" + textBox13.Text);
                    File.AppendAllText(name, "\n" + textBox14.Text);
                    File.AppendAllText(name, "\n" + textBox15.Text);
                    File.AppendAllText(name, "\n" + textBox16.Text);
                    File.AppendAllText(name, "\n" + textBox17.Text);
                    File.AppendAllText(name, "\n" + textBox18.Text);
                    File.AppendAllText(name, "\n" + textBox19.Text);
                    File.AppendAllText(name, "\n" + textBox20.Text);
                    File.AppendAllText(name, "\n" + textBox21.Text);
                    File.AppendAllText(name, "\n" + textBox22.Text);
                    File.AppendAllText(name, "\n" + textBox23.Text);
                    File.AppendAllText(name, "\n" + textBox24.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox16.Clear();
                    textBox17.Clear();
                    textBox18.Clear();
                    textBox19.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox24.Clear();
                    this.Text = "Редактор";
                }
            }
            else
            {
                File.WriteAllText(name, string.Empty);
                File.AppendAllText(name, textBox1.Text);
                File.AppendAllText(name, "\n" + textBox2.Text);
                File.AppendAllText(name, "\n" + textBox3.Text);
                File.AppendAllText(name, "\n" + textBox4.Text);
                File.AppendAllText(name, "\n" + textBox5.Text);
                File.AppendAllText(name, "\n" + textBox6.Text);
                File.AppendAllText(name, "\n" + textBox7.Text);
                File.AppendAllText(name, "\n" + textBox8.Text);
                File.AppendAllText(name, "\n" + textBox9.Text);
                File.AppendAllText(name, "\n" + textBox10.Text);
                File.AppendAllText(name, "\n" + textBox11.Text);
                File.AppendAllText(name, "\n" + textBox12.Text);
                File.AppendAllText(name, "\n" + textBox13.Text);
                File.AppendAllText(name, "\n" + textBox14.Text);
                File.AppendAllText(name, "\n" + textBox15.Text);
                File.AppendAllText(name, "\n" + textBox16.Text);
                File.AppendAllText(name, "\n" + textBox17.Text);
                File.AppendAllText(name, "\n" + textBox18.Text);
                File.AppendAllText(name, "\n" + textBox19.Text);
                File.AppendAllText(name, "\n" + textBox20.Text);
                File.AppendAllText(name, "\n" + textBox21.Text);
                File.AppendAllText(name, "\n" + textBox22.Text);
                File.AppendAllText(name, "\n" + textBox23.Text);
                File.AppendAllText(name, "\n" + textBox24.Text);
                MessageBox.Show("Данные обновлены");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
                textBox19.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                this.Text = "Редактор";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не указана фамилия");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не указано имя");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Не указано отчество");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Не указана дата рождения");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Не указано место рождения");
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Не указан телефон");
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("Не указана фамилия отца");
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Не указано имя отца");
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Не указано отчество отца");
            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("Не указана фамилия матери");
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("Не указано имя матери");
            }
            if (textBox12.Text == "")
            {
                MessageBox.Show("Не указано отчество матери");
            }
            if (textBox13.Text == "")
            {
                MessageBox.Show("Не указан телефон отца");
            }
            if (textBox14.Text == "")
            {
                MessageBox.Show("Не указан телефон матери");
            }
            if (textBox15.Text == "")
            {
                MessageBox.Show("Не указан ВУЗ");
            }
            if (textBox16.Text == "")
            {
                MessageBox.Show("Не указан институт");
            }
            if (textBox17.Text == "")
            {
                MessageBox.Show("Не указана кафедра");
            }
            if (textBox18.Text == "")
            {
                MessageBox.Show("Не указана специальность");
            }
            if (textBox19.Text == "")
            {
                MessageBox.Show("Не указана группа");
            }
            if (textBox20.Text == "")
            {
                MessageBox.Show("Не указан экзамен по русскому");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не указан экзамен по физике");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не указан экзамен по математике");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не указан средний балл аттестата");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не указаны интересы");
            }
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != ',')
                e.Handled = true;
        }
    }  
}
