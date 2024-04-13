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
    /// Логика взаимодействия для JapaneseMenu.xaml
    /// </summary>
    public partial class JapaneseMenu : Page
    {
        private IL_PATIOEntities entities = new IL_PATIOEntities();
        public JapaneseMenu()
        {
            InitializeComponent();
            ClientDateGrid.ItemsSource = entities.JAPANESE_MENU_PATIO.ToList();
        }
    }
}
