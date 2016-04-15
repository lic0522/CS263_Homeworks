using DiscountClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicket
{
    public partial class Form1 : Form
    {
        private List<Ticket> tickets;
        public double price;
        public double sum;
        public double scale;
        public Student student = new Student();
        public Special special = new Special();
        private Ticket ticket = new Ticket();

        public Form1()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            ticketComboBox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            discauntCase();
            ticket = new Ticket(ticketComboBox.Text, (int)qtyUpDown.Value, scale);
            tickets.Add(ticket);
            messageTextBox.Text = string.Format("{0}\n", ticket);
        }

        private void ticketComboBox_SelectedIndexChanged(object sender, EventArgs e) //票種
        {
            discauntCase();
            costTextBox.Text = string.Format("{0}", price);
            discountTextBox.Text = string.Format("{0}折", scale * 10);
            discountLabel.Visible = ticketComboBox.SelectedIndex == 1 | ticketComboBox.SelectedIndex == 2;
            discountTextBox.Visible = ticketComboBox.SelectedIndex == 1 | ticketComboBox.SelectedIndex == 2;
        }

        private void qtyUpDown_ValueChanged(object sender, EventArgs e) //數量
        {
            ticket.Qty = (int)qtyUpDown.Value;
            double Cost = ticket.Sum;
        }

        private void discauntCase()
        {
            switch (ticketComboBox.SelectedIndex)
            {
                case 0:
                    scale = 1;
                    price = ticket.StartValue * scale;
                    break;

                case 1:
                    scale = student.Scale;
                    price = ticket.StartValue * scale;
                    break;

                case 2:
                    scale = special.Scale;
                    price = ticket.StartValue * scale;
                    break;

                default:
                    scale = 1;
                    price = ticket.StartValue * scale;
                    break;
            }
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            costTextBox.Enabled = false;
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            discountTextBox.Enabled = false;
        }
    }
}