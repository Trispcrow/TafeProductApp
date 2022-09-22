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
        private double price;
        private int quantity;
        private double totalPayment;
        private double totalDelivery;
        private double totalWrap;
        private double totalGST;
        private double delivery;
        private double wrapping;
        private double gst;

        private double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }
        public double TotalDelivery
        {
            get { return totalDelivery; }
            set { totalDelivery = value; }
        }

        public double TotalWrap
        {
            get { return totalWrap; }
            set { totalWrap = value; }
        }

        public double TotalGST
        {
            get { return totalGST; }
            set { totalGST = value; }
        }

        private double Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private double Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private double GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            Delivery = 25;
            Wrapping = 5;
            GST = 0.1;
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
        // calc total gst
        public void calTotalGST()
        {
            TotalGST = (TotalPayment * GST) + TotalWrap;
        }
    }
}
