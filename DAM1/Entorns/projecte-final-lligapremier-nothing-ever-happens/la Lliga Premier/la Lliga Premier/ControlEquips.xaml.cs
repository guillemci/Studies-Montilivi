using System.Collections.Generic;
using System.Windows.Controls;
using la_Lliga_Premier.domini;

namespace la_Lliga_Premier
{
    public partial class ControlEquips : UserControl
    {
        public ControlEquips()
        {
            InitializeComponent();
        }

        public void ActualitzarDades(List<Equip> equips)
        {
            LlistaEquips.ItemsSource = equips;
        }
    }
}