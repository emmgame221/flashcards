using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        private List<Deck> decks;

        public MainForm()
        {
            InitializeComponent();
            decksComboBox.DataSource = decks;
            decksComboBox.DisplayMember = "Name";
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            PromptSave();
            Application.Exit();
        }

        private void PromptSave()
        {
            throw new NotImplementedException();
        }
    }
}
