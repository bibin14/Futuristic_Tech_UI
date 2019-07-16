using System;
using System.Windows;

namespace FuturisticTechUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /// Setting User Info
            this.LoggedInUser = Environment.UserName;
            this.Designation = DateTime.Now.Date.ToLongDateString();
            //this.txtTime.Text = DateTime.Now.ToLongTimeString(); 
        }

        # region Window Events

        /// <summary>
        /// Window Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e) => this.Close();

        /// <summary>
        /// Window Minimize Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        #endregion

        #region Properties
        
        /// <summary>
        /// Set Logged-In User
        /// </summary>
        public string LoggedInUser {
            get {
                return this.txtUser.Text;
            }
            set {
                this.txtUser.Text = value; 
            }
        }

        public string Designation
        {
            get
            {
                return this.txtDesignation.Text;
            }
            set
            {
                this.txtDesignation.Text = value;
            }
        }       

        #endregion
    }
}
