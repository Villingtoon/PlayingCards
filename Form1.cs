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

namespace PlayingCards
{
    public partial class Desk : Form
    {
        private string folderPath = null;
        private string[] fileNames = null;
        private Random rand = new Random();
        private List<PictureBox> cards = new List<PictureBox>();

        public Desk()
        {
            InitializeComponent();
            InitializeDesk();
        }

        private void InitializeDesk()
        {
            this.BackColor = Color.Green;
        }

        private string SelectFolder()
        {
            var selectFolderDialog = new FolderBrowserDialog();
            DialogResult result = selectFolderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFolderDialog.SelectedPath))
            {
                return selectFolderDialog.SelectedPath;
            }
            return null;
        }

        private void loadCards_Click(object sender, EventArgs e)
        {
            PictureBox filePictureBox = null;

            folderPath = SelectFolder();
            if(folderPath == null)
            {
                return;
            }

            fileNames = Directory.GetFiles(folderPath);
            //Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            foreach(var fileName in fileNames)
            {
                filePictureBox = new PictureBox()
                {
                    Height = 100,
                    Width = 70,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Left = rand.Next(0, 730),
                    Top = rand.Next(0, 360),
                    Image = Image.FromFile(fileName)
                };
                filePictureBox.Click += Card_Click;
                this.Controls.Add(filePictureBox);
                cards.Add(filePictureBox);
            }
        }

        private void stackCards_Click(object sender, EventArgs e)
        {
            int x = 100, y = 100;
            foreach(var card in cards)
            {
                card.Location = new Point(x, y);
                x ++;
                y ++;
            }
        }

        private void deckCards_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 7; y++)
                {
                    cards[counter].Location = new Point(x * 80, y * 110);
                    counter++;
                }
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            var card = (PictureBox)sender;
            card.Location = new Point(30, 30);
            card.BringToFront();
        }
    }
}
