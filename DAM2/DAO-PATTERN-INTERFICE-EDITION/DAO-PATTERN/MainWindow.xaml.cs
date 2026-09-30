using DAO_PATTERN.DAO;
using DAO_PATTERN.Enums;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace DAO_PATTERN
{
    //menu fet amb ajuda de IA tinc WPF molt descuidat o hi ha coses que no se fer
    public partial class MainWindow : Window
    {
        IDAO? dao;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tabsExercicis.IsEnabled = false;
            cmbDAO.SelectedIndex = 0;
        }

        private void BtnConnexio_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog
            {
                Title = "Selecciona el fitxer de connexió",
                Filter = "Tots els fitxers (*.*)|*.*"
            };

            if (f.ShowDialog() == true)
                txtConnexio.Text = f.FileName;
        }

        private void BtnConnectar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //ComboBoxItem item = (ComboBoxItem)cmbDAO.SelectedItem;
                if (cmbDAO.SelectedItem is not ComboBoxItem item)
                {
                    MessageBox.Show("Selecciona un DAOService.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtConnexio.Text))
                {
                    MessageBox.Show("Selecciona el fitxer de connexió.");
                    return;
                }

                EnumDTOImplementacio tipus = Enum.Parse<EnumDTOImplementacio>(item.Tag.ToString());
                dao = IDAOFactory.GetDAOService(tipus, txtConnexio.Text);
                tabsExercicis.IsEnabled = true;
                MessageBox.Show("Connexió preparada.");
            }
            catch (Exception ex)
            {
                tabsExercicis.IsEnabled = false;
                dao = null;
                ShowError(ex);
            }
        }

        private void BtnInput6a_Click(object sender, RoutedEventArgs e) => SelectInput(txtInput6a);
        private void BtnInput6b_Click(object sender, RoutedEventArgs e) => SelectInput(txtInput6b);

        private void BtnOutput1_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog
            {
                Filter = "Fitxers CSV (*.csv)|*.csv|Tots els fitxers (*.*)|*.*",
                DefaultExt = ".csv",
                AddExtension = true
            };

            if (f.ShowDialog() == true)
                txtOutput1.Text = f.FileName;
        }

        private void BtnOutput5_Click(object sender, RoutedEventArgs e) => SelectOutput(txtOutput5);
        private void BtnOutput6_Click(object sender, RoutedEventArgs e) => SelectOutput(txtOutput6);

        private static void SelectInput(System.Windows.Controls.TextBox target)
        {
            OpenFileDialog f = new OpenFileDialog
            {
                Filter = "Fitxers CSV (*.csv)|*.csv|Tots els fitxers (*.*)|*.*"
            };

            if (f.ShowDialog() == true)
                target.Text = f.FileName;
        }

        private static void SelectOutput(System.Windows.Controls.TextBox target)
        {
            SaveFileDialog f = new SaveFileDialog
            {
                Filter = "Fitxers CSV (*.csv)|*.csv|Tots els fitxers (*.*)|*.*",
                DefaultExt = ".csv",
                AddExtension = true
            };

            if (f.ShowDialog() == true)
                target.Text = f.FileName;
        }

        private static string OutputBaseName(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return path;

            return Path.Combine(
                Path.GetDirectoryName(path) ?? "",
                Path.GetFileNameWithoutExtension(path));
        }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnExercici1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dao == null)
                {
                    MessageBox.Show("Primer has de connectar un DAOService.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGenre.Text) || string.IsNullOrWhiteSpace(txtOutput1.Text))
                {
                    MessageBox.Show("Especifica el gènere i el fitxer de sortida.");
                    return;
                }

                int resultat = dao.SelectByGenre(
                    txtGenre.Text,
                    txtOutput1.Text
                );

                txtResult1.Text =
                    "S'han trobat: " + resultat + "\n\n" +
                    File.ReadAllText(txtOutput1.Text);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void BtnExercici2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dao == null)
                {
                    MessageBox.Show("Primer has de connectar un DAOService.");
                    return;
                }
                int index = int.Parse(txtIndex2.Text);
                var resultat = dao.SelectByIndex(index);
                txtResult2.Text = resultat is null
                    ? "No s'ha trobat cap títol."
                    : resultat.ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void BtnExercici3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dao == null)
                {
                    MessageBox.Show("Primer has de connectar un DAOService.");
                    return;
                }
                var resultat = dao.SelectById(txtId3.Text);
                txtResult3.Text = resultat is null
                    ? "No s'ha trobat cap títol."
                    : resultat.ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void BtnExercici4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dao == null)
                {
                    MessageBox.Show("Primer has de connectar un DAOService.");
                    return;
                }
                int index = int.Parse(txtIndex4.Text);
                int length = int.Parse(txtLength4.Text);
                var resultat = dao.ReadTitles(index, length);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Títols retornats: {resultat.Length}");
                sb.AppendLine();
                foreach (var title in resultat)
                    sb.AppendLine(title.ToString());

                txtResult4.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void BtnExercici5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dao == null)
                {
                    MessageBox.Show("Primer has de connectar un DAOService.");
                    return;
                }
                int index = int.Parse(txtIndex5.Text);
                int length = int.Parse(txtLength5.Text);
                string output = OutputBaseName(txtOutput5.Text);

                var titles = dao.ReadTitles(index, length);
                dao.PreMerge(titles, output);

                string outputFile = output + ".csv";
                txtResult5.Text =
                    $"Fet. Títols processats: {titles.Length}\n" +
                    $"Sortida: {outputFile}";
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void BtnExercici6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dao == null)
                {
                    MessageBox.Show("Primer has de connectar un DAOService.");
                    return;
                }
                string output = OutputBaseName(txtOutput6.Text);
                int resultat = dao.Merge(
                    txtInput6a.Text,
                    txtInput6b.Text,
                    output
                );

                txtResult6.Text =
                    $"Registres processats: {resultat}\n" +
                    $"Sortida: {output}.csv";
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
    }
}
