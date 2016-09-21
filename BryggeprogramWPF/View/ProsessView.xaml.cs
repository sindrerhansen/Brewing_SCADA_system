using System.Windows;
using System.Windows.Forms;

namespace BryggeprogramWPF
{
    /// <summary>
    /// Interaction logic for ProsessWindow.xaml
    /// </summary>
    public partial class ProsessWindow : Window
    {
        public ProsessWindow()
        {
            InitializeComponent();

         
            if (Screen.AllScreens.Length > 1)
            {             
                Screen s2 = Screen.AllScreens[1];            
                this.Show();
                this.Left = s2.Bounds.Left;
                this.Top = s2.Bounds.Top;
                this.WindowState = WindowState.Maximized;
            }
        }
    }
}
