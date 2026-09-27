using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Controls;
using la_Lliga_Premier.domini;

namespace la_Lliga_Premier
{
    public partial class ControlClassificacio : UserControl
    {
        public ControlClassificacio()
        {
            InitializeComponent();
        }

        public void ActualitzarDades(List<EquipClassificacio> dades)
        {
            GridClassificacio.ItemsSource = dades;
        }
    }
}