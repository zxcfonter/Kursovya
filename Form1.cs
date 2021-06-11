using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Регистратура_поликлиники.ModelBD;

namespace Регистратура_поликлиники
{
    public partial class Form1 : Form
    {
        ModelBD.Model1 connected = new ModelBD.Model1();
       // private int index;

        public Form1()
        {
            InitializeComponent();
            connected.Регистратура.Load();
            dataGridView1.DataSource = connected.Регистратура.Local.ToBindingList();
        }

        private void addBd_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Регистратура clientadd = new Регистратура();
                clientadd.ФИО = form.textBox1.Text;
                clientadd.Врач = form.textBox2.Text;
                clientadd.Кабинет = form.textBox3.Text;
                clientadd.Время = form.textBox5.Text;


                // clientadd.GenderCode = form.comboBox1.Text;

                connected.Регистратура.Add(clientadd);
                connected.SaveChanges();
                MessageBox.Show("Добавлено");

            }
        }

       


        public bool x = true;

        private void sortBD_Click(object sender, EventArgs e)
        {

            dataGridView1.Sort(dataGridView1.Columns[0], x ? ListSortDirection.Ascending : ListSortDirection.Descending);
            x = !x;
        }

        private void CloseBD_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RedactBD_Click(object sender, EventArgs e)
        {
            Form2 formedit = new Form2();
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int index = dataGridView1.SelectedRows[0].Index;
                int id = index;
                bool convert = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);


                Регистратура clientedit = connected.Регистратура.Find(id);

                formedit.textBox1.Text = clientedit.ФИО;
                formedit.textBox2.Text = clientedit.Врач;
                formedit.textBox3.Text = clientedit.Кабинет;
                formedit.textBox5.Text = clientedit.Время;


                // formedit.comboBox1.Text = clientedit.GenderCode;

                DialogResult resultedit = formedit.ShowDialog(this);
                if (resultedit == DialogResult.OK)
                {

                    clientedit.ФИО = formedit.textBox1.Text;
                    clientedit.Врач = formedit.textBox2.Text;
                    clientedit.Кабинет = formedit.textBox3.Text;
                    clientedit.Время = formedit.textBox5.Text;


                    // clientedit.GenderCode = formedit.comboBox1.SelectedItem.ToString();

                    connected.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Запись обновлена");
                }
            }
        }

        private void deleteBD_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

            {

                int Index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, Index].Value.ToString(), out id);


                if (converted == true)

                {

                    Регистратура ClientDel = connected.Регистратура.Find(id);
                    connected.Регистратура.Remove(ClientDel);
                    connected.SaveChanges();
                    string buff = ClientDel.ФИО;
                    MessageBox.Show("Запись " + buff + " удалена");

                }
            }
            else
            {

                MessageBox.Show("Строчка не выбрана");

            }
        }
    }
    }
