using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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

      
        private string showRadioMessage()
        {  
            string message = null;
            
            if(rbGuest.IsChecked == true) 
            {
                message = "This is the selected value";
                MessageBox.Show(message);
            }
            if (rbAdmin.IsChecked == true)
            {
                message = "This is the selected value";
                MessageBox.Show(message);
            }
            if (rbStudent.IsChecked == true)
            {
                message = "This is the selected value";
                MessageBox.Show(message);
            }
            if (rbTeacher.IsChecked == true)
            {
                message = $"This is the selected value ";
                MessageBox.Show(message);
            }
            
            
            List<RadioButton> radioList = new List<RadioButton> { rbAdmin, rbGuest, rbStudent, rbTeacher };

            if (string.IsNullOrEmpty(message) == true) 
            {
                Random random = new Random();
                int isRandom = random.Next(0,radioList.Count);
                radioList[isRandom].IsChecked = true;
                
                
            }
            return message;

         



        }

        private void selectedBtn_Click_1(object sender, RoutedEventArgs e)
        {
            showRadioMessage();
           
           
        }
        
    }
}
