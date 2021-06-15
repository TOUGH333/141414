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

namespace WpfApp39
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


        private void BtnOut_Click(object sender, RoutedEventArgs e)
        {
            

            string Name = NameBox.Text;
            string Group = GroupBox.Text;
            string Date = DateBox.Text;
            string Ball = BallBox.Text;

            listbox.Items.Add($"{Name}       {Group}      {Ball}     {Date}  ");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {






            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:/Saverepos/Сохранение.txt"))
            {
                for (int i = 0; i < listbox.Items.Count; i++)
                    sw.WriteLine(listbox.Items[i].ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (System.IO.StreamReader read = new System.IO.StreamReader("C:/Saverepos/Сохранение.txt"))
            {
                foreach (string str in read.ReadToEnd().Split(new Char[] { '\n' }))
                {
                    listbox.Items.Add(str);
                }







            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.listbox.Items.RemoveAt(this.listbox.SelectedIndex);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.listbox.Items.RemoveAt(this.listbox.SelectedIndex);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {





        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {





        }

        private void button_Click_5(object sender, RoutedEventArgs e)
        {
            {
               






            }     
            
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameBox.Text.Length < 4)
            {
                textBlock2.Foreground = Brushes.Red;
                textBlock2.Text = "Fail";
            }
            if (NameBox.Text.Length > 4)
            {
                textBlock2.Foreground = Brushes.Green;
                textBlock2.Text = "Acces";
            }
        }

        private void BallBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void DateBox_TextChanged(object sender, TextChangedEventArgs e)

        {
            string Name = NameBox.Text;
            string Group = GroupBox.Text;
            string Date = BallBox.Text;
            string Ball = BallBox.Text;

            if (DateBox.Text.Length == 2)
            {
                DateBox.Text += '.';
                DateBox.CaretIndex = 3;
                textBlock4.Foreground = Brushes.Red;
                textBlock4.Text = ("Fail");
            }
            if (DateBox.Text.Length == 10)
            {

                textBlock4.Foreground = Brushes.Green;
                textBlock4.Text = ("Acces");
            }
            else if (NameBox.Text.Length == 3)

            {
                DateBox.Text += '.';
                DateBox.CaretIndex = 4;
                textBlock4.Foreground = Brushes.Red;
                textBlock4.Text = ("Fail");
            }
            else if (DateBox.Text.Length == 5)
            {
                DateBox.Text += '.';
                DateBox.CaretIndex = 6;
                textBlock4.Foreground = Brushes.Red;
                textBlock4.Text = ("Fail");
            }
            if (DateBox.Text.Length > 10)
            {

                textBlock4.Foreground = Brushes.Red;
                textBlock4.Text = ("Fail");

            }
        }

        private void BallBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (BallBox.Text.Length == 1)
            {
                BallBox.Text += '.';
                BallBox.CaretIndex = 2;
                textBlock5.Foreground = Brushes.Red;
                textBlock5.Text = ("Fail");

            }
            if (BallBox.Text.Length >= 3)
            {
                textBlock5.Foreground = Brushes.Green;
                textBlock5.Text = ("Acces");

            }
        }

        private void GroupBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (GroupBox.Text.Length > 1)
            {

                textBlock3.Foreground = Brushes.Green;
                textBlock3.Text = ("Acces");

            }
            if (NameBox.Text.Length > 3)
            {

                textBlock3.Foreground = Brushes.Green;
                textBlock3.Text = ("Acces");

            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            
                    



        }
    }
}