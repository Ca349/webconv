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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();


            bool? response = openFileDialog.ShowDialog();


            //Determines if the open button clicked, then ask for a file.

            if (response == true)
            {
                string filepath = openFileDialog.FileName;

                string outputpath = "Output/output.html/";

                // Convert The File (I know one line of code lol)


                File.Copy(filepath, outputpath, true);
            }




            {

            }
        }
    }
}
