﻿using System;
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

        public Desk()
        {
            InitializeComponent();
            InitializeDesk();
        }

        private void InitializeDesk()
        {
            this.BackColor = Color.Green;
        }

        private void loadCards_Click(object sender, EventArgs e)
        {
            PictureBox filePictureBox = null;

            folderPath = @"C:\A ROBERT FOTOGRAFE\Playing cards\Playing Cards\playing_card_images\face";
            fileNames = Directory.GetFiles(folderPath);

            //Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            foreach(var fileName in fileNames)
            {
                filePictureBox = new PictureBox()
                {
                    Height = 100,
                    Width = 70,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Left = 100,
                    Top = 100,
                    Image = Image.FromFile(fileName)
                };
                this.Controls.Add(filePictureBox);
            }
        }
    }
}
