using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Currency_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currency1;
        public string currency2;
        public MainWindow()
        {
            InitializeComponent();
            

        }

            currency = right_combo_box.SelectedIndex;
            Trace.WriteLine(currency);
        }
        private void convert(object sender, RoutedEventArgs e)
        {
            Text_right.Text = Text_left.Text;
            Trace.WriteLine(right_combo_box.Items.Count);
            Trace.WriteLine(right_combo_box.Items.IndexOf(0));
          
           
        }


        private void left_combo_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value = (ComboBoxItem)left_combo_box.SelectedItem;
            currency1 = selected_value.Name;
            Text_left.Text = currency1;  
        }

        private void right_combo_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value = (ComboBoxItem)right_combo_box.SelectedItem;
            currency2 = selected_value.Name;
            Text_right.Text = currency2;



        }



            currency = right_combo_box.SelectedIndex;
            Trace.WriteLine(currency);
        }
        private void convert(object sender, RoutedEventArgs e)
        {
            Text_right.Text = Text_left.Text;
            Trace.WriteLine(right_combo_box.Items.Count);
            Trace.WriteLine(right_combo_box.Items.IndexOf(0));
          
           
        }


        private void minimize_win(object sender, RoutedEventArgs e)
        {

        }
        private void resize_win(object sender, RoutedEventArgs e)
        {

        }
        private void close_win(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
