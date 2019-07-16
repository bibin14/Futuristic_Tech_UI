using System.Windows.Controls;

namespace Futuristic_Tech_UI
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

        public string Header { get; set; }

        public string Production { get; set; }

        public string ProductionDifference { get; set; }
    }
}
