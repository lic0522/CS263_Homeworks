using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Ticket
    {
        public double StartValue { get { return 200; } } //原價
        public string TicketItem { set; get; } //項目
        public double Qty { set; get; } //張數
        public double Discount { set; get; } //折扣

        public Ticket()
        {
        }

        public Ticket(string ticketItem, double qty, double discount)
        {
            this.TicketItem = ticketItem;
            this.Qty = qty;
            this.Discount = discount;
            this.Price = this.StartValue * this.Discount;
            this.sum = this.Price * this.Qty;
        }

        public double Price { set; get; } //原價*折扣

        public double Sum
        {
            get { return this.sum; }
            set { this.sum = this.Price * this.Qty; }
        }

        private double sum; //原價*折扣*購買量

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("購票類別:{0}\n購買數量:{1}張\n折扣:{2}%\n單價:{3}\n總計:{4}\n",
                this.TicketItem, this.Qty, this.Discount * 100, this.Price, this.sum);

            return result;
        }
    }
}