using System.Windows;
using System.Windows.Controls;

namespace ChiffreSecret
{
    public partial class MainWindow : Window
    {
        int NumberOfAttempts;
        int NumberToFind;
        Random Random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            PrepareButtons();
            // Va voir le menu!
        }

        void OnMenuNewGameClick(object sender, EventArgs e)
        {


        }


        private void PrepareButtons()
        {
            // Ici tu vas préparer tes boutons.


            //btnNom.Width = Double.NaN;

            for (int i = 1; i <= 20; i++)
            {
                var btnNom = new Button();
                btnNom.Margin = new Thickness(0, i * 50, 0, 0); // +15 // 2eme // l,t,r,b \\
                GridButtons.Children.Add(btnNom);
                btnNom.Width = 50;
                btnNom.Name = "btn" + i;
                btnNom.Content = i;
            } // marche pas 
        }
    }
}