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
using GestionnaireDeCourse.data;
using GestionnaireDeCourse.Model;

namespace GestionnaireDeCourse
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            using (var db = new Context())
            {
                var query = from b in db.Chauffeurs
                    select b;
                foreach (Chauffeur chauffeur in query)
                {
                    Label1.Content = chauffeur.Nom;
                }
            }
        }
    }
}
