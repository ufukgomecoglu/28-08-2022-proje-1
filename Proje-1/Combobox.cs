using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1
{
    public partial class Combobox : Form
    {
        public Combobox()
        {
            InitializeComponent();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            string data = "";
            data = $"Selected Value = {comboBoxName.SelectedValue}\nSelected Index = {comboBoxName.SelectedIndex}\nSelected Text = {comboBoxName.Text}\nSelected Item = {comboBoxName.SelectedItem.ToString()} ";
            MessageBox.Show(data);
        }

        private void Combobox_Load(object sender, EventArgs e)
        {
            DataModel dataModel = new DataModel();
            //comboBoxName.ValueMember = "ID";
            //comboBoxName.DataSource = dataModel.GetUser();
            List < User > users = dataModel.GetUser();
            List<User1> user1s = new List<User1>();
            foreach (User item in users)
            {
                user1s.Add(new User1 { ID = item.ID, NameSurneme = item.Name + " " + item.Surname});
            }
            comboBoxName.DisplayMember = "NameSurneme";
            comboBoxName.ValueMember = "ID";
            comboBoxName.DataSource = user1s;

        }
        private class User1
        {
            public int ID { get; set; }
            public string NameSurneme { get; set; }
        }

        //private void comboBoxName_Format(object sender, ListControlConvertEventArgs e)
        //{
        //    string name = ((User)e.ListItem).Name;
        //    string surname = ((User)e.ListItem).Surname;
        //    e.Value = $"{name} {surname}";
        //}
    }
}
