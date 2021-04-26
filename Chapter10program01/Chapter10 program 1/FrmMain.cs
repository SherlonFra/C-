using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10_program_1
{
    public partial class FrmMain : Form
    {
        const int CARDSPERLINE = 13;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            int j;
            int cardIndex;
            int deckSize;
            int passes;
            string buff;
            string temp;
            clsCardDeck myDeck = new clsCardDeck();
            passes = myDeck.ShuffleDeck();
            lblPassCounter.Text = "It took " + passes.ToString() +
            " passes to shuffle the deck";
            deckSize = myDeck.DeckSize;
            for (cardIndex = 1; cardIndex < deckSize + 1;)
            {
                buff = "";
                for (j = 0; j < CARDSPERLINE; j++) // Show 13 cards per line
                {
                    temp = myDeck.getOneCard(cardIndex);
                    if (temp.Length == 0)
                    {
                        MessageBox.Show("Error reading deck.", "Processing Error");
                        return;
                    }
                    buff += temp + " ";
                    cardIndex++;
                }
                lstDeck.Items.Add(buff);
            }
            lstDeck.Items.Add(" "); // Add an empty line
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDeck.Items.Clear();
        }
    }
    
    
}
