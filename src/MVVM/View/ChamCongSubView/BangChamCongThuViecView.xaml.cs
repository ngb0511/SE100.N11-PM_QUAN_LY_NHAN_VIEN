﻿using QuanLyNhanVien.WindowView;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyNhanVien.MVVM.View.ChamCongSubView
{
    /// <summary>
    /// Interaction logic for BangChamCongThuViecView.xaml
    /// </summary>
    public partial class BangChamCongThuViecView : UserControl
    {
        public BangChamCongThuViecView()
        {
            InitializeComponent();
        }

        private void btnThemCong_Click(object sender, RoutedEventArgs e)
        {
            ChamCongThuViec chamCong = new ChamCongThuViec();
            chamCong.ShowDialog();
        }
    }
}
