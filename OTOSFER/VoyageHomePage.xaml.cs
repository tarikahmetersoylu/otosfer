﻿using OTOSFER.Classes;
using OTOSFER.UserControls;
using OTOSFER;
using System;
using System.Collections.Generic;
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

namespace OTOSFER
{
    /// <summary>
    /// VoyageHomePage.xaml etkileşim mantığı
    /// </summary>
    public partial class VoyageHomePage : Window
    {
        
        public VoyageHomePage()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void VoyageAddbtn_Click(object sender, RoutedEventArgs e)
        {
            CallUserControls.Add_Uc(icerik,new VoyageAddUc());
        }

        private void VoyageListbtn_Click(object sender, RoutedEventArgs e)
        {
            CallUserControls.Add_Uc(icerik, new VoyageListUc());
        }

        private void PastVoyagebtn_Click(object sender, RoutedEventArgs e)
        {
            
            ChooseDateForPastVoyageList cdfpvl = new ChooseDateForPastVoyageList();
            cdfpvl.ShowDialog();
        }
        public void Call()
        {
            CallUserControls.Add_Uc(icerik, new PastVoyageListUc());
        }

        private void MountCalculate_Click(object sender, RoutedEventArgs e)
        {
            ChooseDateForMountCalculate cdfmc = new ChooseDateForMountCalculate();
            cdfmc.ShowDialog();
        }
    }
}