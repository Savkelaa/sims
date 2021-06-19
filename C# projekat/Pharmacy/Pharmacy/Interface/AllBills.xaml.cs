﻿using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pharmacy.Interface
{
    public partial class AllBills : Window
    {
        User u = new User();

        BillController billController = new BillController();


        public AllBills(User user)
        {
            u = user;
            InitializeComponent();
            

          //  ObservableCollection<Bill> bills = new ObservableCollection<Bill>(billController.GetAll());

            this.gridBills.ItemsSource = u.Bills;
        }
    }
}
