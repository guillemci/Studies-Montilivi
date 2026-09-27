using System;
using System.Windows;
using la_Lliga_Premier.domini;

namespace la_Lliga_Premier
{
    public partial class MainWindow : Window
    {
        private ServeiLliga _serveiLliga;
        private ControlClassificacio _vistaClassificacio;
        private ControlEquips _vistaEquips;

        public MainWindow()
        {
            InitializeComponent();

            _serveiLliga = new ServeiLliga();

            _vistaClassificacio = new ControlClassificacio();
            _vistaEquips = new ControlEquips();

            try
            {
                _serveiLliga.CarregarDades();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carregar les dades de la lliga: {ex.Message}",
                                "Error de Càrrega", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClassificacio_Click(object sender, RoutedEventArgs e)
        {
            var dades = _serveiLliga.GenerarClassificacio();
            _vistaClassificacio.ActualitzarDades(dades);

            RegioPrincipal.Content = _vistaClassificacio;
            TxtStatus.Text = "Mostrant la classificació calculada de la Premier League.";
        }

        private void BtnEquips_Click(object sender, RoutedEventArgs e)
        {
            _vistaEquips.ActualitzarDades(_serveiLliga.Equips);

            RegioPrincipal.Content = _vistaEquips;
            TxtStatus.Text = "Mostrant el llistat d'equips participants inscrits.";
        }

        private void Sortir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}