using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ListeDeNoms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int tbcompteur = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnEdtNomKeyDown(object sender, KeyEventArgs e) // KEY !!!
        {
            // Comment on ajoute un évènement en xaml?

            //OnBtnAddNameClick()
            if (e.Key == Key.Enter)
            {
                AddName(edtName.Text);
            }

        }

        void OnBtnAddNameClick(object sender, EventArgs e)
        {
            AddName(edtName.Text);
        }

        // Avoir un message box qui montre le nom
        void AddName(string name)
        {
            var tbNom = new TextBlock();
            tbNom.Margin = new Thickness(375, tbcompteur * 15, 0, 0); // +15 // 2eme // l,t,r,b \\
            gridNoms.Children.Add(tbNom);
            tbNom.Text = name;
            tbcompteur++;

            if (tbcompteur >= 10)
            {
                OnBtnAddName.IsEnabled = false;
                MessageBox.Show("Vous avez assez ajouter de nom !!");


            }
            edtName.Clear();


        }
    }
}