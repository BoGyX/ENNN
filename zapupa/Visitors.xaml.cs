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
   
    public partial class Visitors : Page
    {
        private IL_PATIOEntities entities = new IL_PATIOEntities();
        public Visitors()
        {
            InitializeComponent();
            ClientDateGrid.ItemsSource = entities.VISITOR.ToList();
        }
    }
}
