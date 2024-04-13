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

namespace zapupa
{
    /// <summary>
    /// Логика взаимодействия для Waiter.xaml
    /// </summary>
    public partial class Waiter : Page
    {
        private IL_PATIOEntities entities = new IL_PATIOEntities();
        public Waiter()
        {
            InitializeComponent();
            ClientDateGrid.ItemsSource = entities.WAITER.ToList();
        }
    }
}
