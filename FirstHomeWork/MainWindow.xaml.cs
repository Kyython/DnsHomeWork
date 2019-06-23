using System;
using System.Net;
using System.Windows;

namespace FirstHomeWork
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            if (userText.Text == string.Empty)
            {
                MessageBox.Show("Заполните текстовое поле!");
                return;
            }

            try
            {
                var ipHostEntry = Dns.GetHostEntry(userText.Text);

                ipAddressList.Items.Clear();

                foreach (var item in ipHostEntry.AddressList)
                {
                    ipAddressList.Items.Add(item);
                }

                hostNameText.Text = ipHostEntry.HostName;
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Error - {exception.Message}");
            }
        }
    }
}
