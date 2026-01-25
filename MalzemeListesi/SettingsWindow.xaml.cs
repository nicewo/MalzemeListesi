using Microsoft.Win32;
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
using Microsoft.Win32;
using System.Windows;

namespace MalzemeListesi
{
    /// <summary>
    /// SettingsWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void ImportPdf_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "PDF Dosyası (*.pdf)|*.pdf",
                Title = "Malzeme PDF'i Seç"
            };

            if (dlg.ShowDialog() == true)
            {
                string pdfPath = dlg.FileName;

                // ŞİMDİLİK BURADA DURUYORUZ
                MessageBox.Show(
                    $"PDF seçildi:\n{pdfPath}\n\nBir sonraki adımda burayı işleyeceğiz.",
                    "Bilgi",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );
            }
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                ToggleMaximize();
            else
                DragMove();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            ToggleMaximize();
        }

        private void ToggleMaximize()
        {
            WindowState = WindowState == WindowState.Maximized
                ? WindowState.Normal
                : WindowState.Maximized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = Brushes.Red;
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = Brushes.Transparent;
        }
        private void Resize_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = Brushes.Gray;
        }

        private void Resize_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = Brushes.Transparent;
        }
    }
}
