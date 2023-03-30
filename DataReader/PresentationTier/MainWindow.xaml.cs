using System;
using System.Collections.Generic;
using System.IO;
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
using LogicTier;

namespace PresentationTier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private bool _condition = false;
        private static String _filename;
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void clickBtnLoadData(object sender, RoutedEventArgs e)
        {
            _condition = true;
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
           if (result == true && File.Exists(dlg.FileName))
            {
                _filename = dlg.FileName;
                Core core = new Core(_filename, _condition);
                this.DataContext = core;
            }
            else
            {
                MessageBox.Show("Error path");
            }

        }
    }
}
