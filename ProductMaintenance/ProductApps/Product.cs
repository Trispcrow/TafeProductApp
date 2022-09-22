using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal totalDelivery;
        private decimal totalWrap;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }
        public decimal TotalDelivery
        {
            get { return totalDelivery; }
            set { totalDelivery = value; }
        }

        public decimal TotalWrap
        {
            get { return totalWrap; }
            set { totalWrap = value; }
        }

        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            Delivery = 25;
            Wrapping = 5;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total payment plus delivery

        public void calTotalDelivery()
        {
            TotalDelivery = TotalPayment + Delivery;
        }
        // calc total plus wrap
        public void calTotalWrap()
        {
            TotalWrap = TotalDelivery + Wrapping;
        }
    }
}
