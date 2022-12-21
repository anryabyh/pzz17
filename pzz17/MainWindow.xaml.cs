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
using System.Windows.Threading;

namespace pzz17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void progressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlock1.Text = progressBar.Value.ToString();

        }
        private async Task Timer_Tick()
        {
            await Task.Delay(500);
            progressBar.Value++;
            if (progressBar.Value == 100)
                timer.Stop();

        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            await Timer_Tick();
        }
    }
}
/*В синхронном приложении все работает одновременно, в асинхронном нет возможности,
 * пока используется одна функциональность - использовать другую, все последовательно */