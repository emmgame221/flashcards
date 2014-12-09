using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        private const string filename = Directory.GetCurrentDirectory() + @"\decks.bin";
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

        private void SaveDecks()
        {
            Stream saveStream = File.Create(filename);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(saveStream, decks);
            saveStream.Close();
        }

        private void LoadDecks()
        {
            if (File.Exists(filename))
            {
                Stream loadStream = File.OpenRead(filename);
                BinaryFormatter deserializer = new BinaryFormatter();
                decks = (List<Deck>)deserializer.Deserialize(loadStream);
            }
            else
            {
                decks = new List<Deck>();
            }
        }
    }
}
