using System.Windows.Controls;

namespace FuturisticTechUI
{
    /// <summary>
    /// Interaction logic for ucHDRTile.xaml
    /// </summary>
    public partial class ucHDRTile : UserControl
    {
        public ucHDRTile()
        {
            InitializeComponent();
        }

        public string _Header { get; set; }

        public string _Production { get; set; }

        public string _ProductionDifference { get; set; }
    }
}
