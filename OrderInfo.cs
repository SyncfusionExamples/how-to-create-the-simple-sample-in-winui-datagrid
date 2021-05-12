using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;
        List<ProductInfo> productDetails;

        public int OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerID");
            }
        }

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set
            {
                shippingCity = value;
                OnPropertyChanged("ShipCity");
            }
        }

        public List<ProductInfo> ProductDetails
        {
            get { return productDetails; }
            set
            {
                productDetails = value;
                OnPropertyChanged("ProductDetails");
            }
        }

        public OrderInfo()
        {

        }
        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity, List<ProductInfo> productdetails)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.ProductDetails = productdetails;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    public class ProductInfo : INotifyPropertyChanged
    {
        int orderId;
        string productName;

        public int OrderID
        {
            get { return orderId; }
            set
            {
                orderId = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
