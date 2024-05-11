using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unPetitExoSympa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddToList(ListBox lb, TextBox tb)
        {
            if(!string.IsNullOrEmpty(tb.Text))
            {
                lb.Items.Add(tb.Text);
                tb.Text = "";
                tb.Focus();
            }
        }

        private void btnAddLeftList_Click(object sender, EventArgs e)
        {
            AddToList(this.lb_LeftList, this.tbLeft);
        }

        private void btn_AddListRight_Click(object sender, EventArgs e)
        {
            AddToList(this.lb_RightList, this.tbRight);
        }

        private void RemoveFromList(ListBox lb)
        {
            if(lb.SelectedIndex >= 0)
            {
                lb.Items.RemoveAt(lb.SelectedIndex);
            }
        }

        private void btn_RemoveLeftElt_Click(object sender, EventArgs e)
        {
            RemoveFromList(this.lb_LeftList);
        }

        private void btn_RemoveRightElement_Click(object sender, EventArgs e)
        {
            RemoveFromList(this.lb_RightList);
        }

        private void SwitchElement(ListBox lb_from, ListBox lb_destination)
        {
            if(lb_from.SelectedIndex >= 0)
            {
                lb_destination.Items.Add(lb_from.SelectedItem);
                lb_from.Items.Remove(lb_from.SelectedItem);
            }
        }

        private void bt_LefttoRight_Click(object sender, EventArgs e)
        {
            SwitchElement(this.lb_LeftList, this.lb_RightList);

        }

        private void bt_RighttoLeft_Click(object sender, EventArgs e)
        {
            SwitchElement(this.lb_RightList, this.lb_LeftList);
        }

        private void bt_Quit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes vous sur de vouloir quitter ?", "Tp 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
