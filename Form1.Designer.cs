namespace PlayingCards
{
    partial class Desk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desk));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.loadCards = new System.Windows.Forms.ToolStripButton();
            this.stackCards = new System.Windows.Forms.ToolStripButton();
            this.deckCards = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCards,
            this.stackCards,
            this.deckCards});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // loadCards
            // 
            this.loadCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadCards.Image = ((System.Drawing.Image)(resources.GetObject("loadCards.Image")));
            this.loadCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadCards.Name = "loadCards";
            this.loadCards.Size = new System.Drawing.Size(70, 22);
            this.loadCards.Text = "Load Cards";
            this.loadCards.Click += new System.EventHandler(this.loadCards_Click);
            // 
            // stackCards
            // 
            this.stackCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stackCards.Image = ((System.Drawing.Image)(resources.GetObject("stackCards.Image")));
            this.stackCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stackCards.Name = "stackCards";
            this.stackCards.Size = new System.Drawing.Size(39, 22);
            this.stackCards.Text = "Stack";
            this.stackCards.Click += new System.EventHandler(this.stackCards_Click);
            // 
            // deckCards
            // 
            this.deckCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deckCards.Image = ((System.Drawing.Image)(resources.GetObject("deckCards.Image")));
            this.deckCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deckCards.Name = "deckCards";
            this.deckCards.Size = new System.Drawing.Size(37, 22);
            this.deckCards.Text = "Deck";
            this.deckCards.Click += new System.EventHandler(this.deckCards_Click);
            // 
            // Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Desk";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton loadCards;
        private System.Windows.Forms.ToolStripButton stackCards;
        private System.Windows.Forms.ToolStripButton deckCards;
    }
}

