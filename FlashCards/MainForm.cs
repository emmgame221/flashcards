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
        public const int FRONT = 0;
        public const int BACK = 1;
        
        private const string filename = @"decks.bin";
        private List<Deck> decks;
        private Deck currentDeck;
        private FlashCard currentCard;
        private int cardSide = FRONT;

        public MainForm()
        {
            InitializeComponent();
            LoadDecks();
            decksComboBox.DataSource = decks;
            decksComboBox.DisplayMember = "Name";
            currentDeck = decks[0];
            if (currentDeck != null)
            {
                currentCard = currentDeck.FirstCard;
                cardTextBox.Text = currentDeck.FirstCard.Front;
            }
            else
            {
                cardTextBox.Text = "Create a new deck and some new cards!";
            }
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            if(PromptSave())
                Application.Exit();
        }

        private bool PromptSave()
        {
            DialogResult result = MessageBox.Show("Save", "Save all decks?",
                MessageBoxButtons.YesNoCancel);
            //If yes or no we want to exit the program.
            //On cancel we don't.
            switch (result) {
                case DialogResult.Yes:
                    SaveDecks();
                    return true;
                case DialogResult.No:
                    return true;
                case DialogResult.Cancel:
                    return false;
                default://This shouldn't be possible
                    return false;
            }
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

        private void flipButton_Click(object sender, EventArgs e)
        {
            if (currentDeck == null)
            {
                return; //There is no card to flip
            }
            switch (cardSide)
            {
                case FRONT:
                    cardTextBox.Text = currentCard.Back;
                    break;
                case BACK:
                    cardTextBox.Text = currentCard.Front;
                    break;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentDeck == null)
            {
                return; //No deck, no card to go to next
            }
            currentCard = currentDeck.CycleCard();
            cardTextBox.Text = currentCard.Front;
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            PromptSave();
        }
    }
}
