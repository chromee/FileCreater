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

namespace FileCreater
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i < 51; i++)
                comboBox1.Items.Add(i);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectNumber = comboBox1.SelectedIndex + 2;

            for (int i = 1; i < selectNumber; i++)
            {
                System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(@textBox1.Text + @"\" + @textBox2.Text + i + "話");
            }
        }
        

    }
}
