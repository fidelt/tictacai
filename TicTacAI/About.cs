using System.Windows.Forms;

namespace TicTacAI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            abt_author.Text = "Genes Fidel Tamondong";
            abt_license.Text = "GNU GPLv2";
            abt_version.Text = "0.5";
        }
    }
}
