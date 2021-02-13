using System.Windows.Forms;

namespace HideousWorks.Fracter.View.Forms
{
    public partial class TestForm : Form
    {
        public object Displayed
        {
            get { return propertyGrid1.SelectedObject; } 
            set { propertyGrid1.SelectedObject = value; }
        }
        public TestForm()
        {
            InitializeComponent();
        }
    }
}
