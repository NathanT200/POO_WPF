using System.Windows;

namespace IntroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _isOn = false;
        public MainWindow()
        {
            InitializeComponent();

            tbIntro.Text = "Salut le monde!";
            tbIntro.FontSize = 120;






            // Ensuite ajouter un bouton pour changer le texte (de type toggle)
        }

        private void OnClic(object sender, RoutedEventArgs e)
        {


            _isOn = !_isOn;

            tbIntro.Text = _isOn ? "ON" : "OFF";

            //if (_isOn)
            //{
            //    tbIntro.Text = "ON";
            //}
            //else //if (!_isOn)
            //{
            //    tbIntro.Text = "OFF";
            //}


            //string texte = _isOn ? "ON" : "OFF";
            //bool resultat = Predicate ? "option 1 si c'est vrai" : "si c'est faux"


        }
    }
}