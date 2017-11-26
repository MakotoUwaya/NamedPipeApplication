using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MainApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListView_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            var listView = sender as ListView;
            if (listView == null || listView.Items == null || listView.Items.Count < 1)
            {
                return;
            }

            listView.Items.MoveCurrentToFirst();
            listView.ScrollIntoView(listView.Items.CurrentItem);
        }
    }
}
