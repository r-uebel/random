namespace Derp_Assistant_2018
{
    partial class derpassistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(derpassistant));
            this.wordlabel = new System.Windows.Forms.Label();
            this.wordtypelabel = new System.Windows.Forms.Label();
            this.solutionlabel = new System.Windows.Forms.Label();
            this.yesbutton = new System.Windows.Forms.Button();
            this.nobutton = new System.Windows.Forms.Button();
            this.showsolutionbutton = new System.Windows.Forms.Button();
            this.pointsinfolabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textdateiÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwierigkeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nextbutton = new System.Windows.Forms.Button();
            this.roundcounterlabel = new System.Windows.Forms.Label();
            this.pointslabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordlabel
            // 
            this.wordlabel.AutoSize = true;
            this.wordlabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.wordlabel.Location = new System.Drawing.Point(12, 30);
            this.wordlabel.MaximumSize = new System.Drawing.Size(200, 50);
            this.wordlabel.MinimumSize = new System.Drawing.Size(100, 50);
            this.wordlabel.Name = "wordlabel";
            this.wordlabel.Size = new System.Drawing.Size(100, 50);
            this.wordlabel.TabIndex = 0;
            this.wordlabel.Text = "Wort";
            this.wordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordtypelabel
            // 
            this.wordtypelabel.AutoSize = true;
            this.wordtypelabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wordtypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordtypelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.wordtypelabel.Location = new System.Drawing.Point(12, 106);
            this.wordtypelabel.MaximumSize = new System.Drawing.Size(200, 50);
            this.wordtypelabel.MinimumSize = new System.Drawing.Size(100, 50);
            this.wordtypelabel.Name = "wordtypelabel";
            this.wordtypelabel.Size = new System.Drawing.Size(100, 50);
            this.wordtypelabel.TabIndex = 1;
            this.wordtypelabel.Text = "Wortart";
            this.wordtypelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solutionlabel
            // 
            this.solutionlabel.AutoSize = true;
            this.solutionlabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.solutionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.solutionlabel.Location = new System.Drawing.Point(165, 30);
            this.solutionlabel.MaximumSize = new System.Drawing.Size(500, 200);
            this.solutionlabel.MinimumSize = new System.Drawing.Size(500, 200);
            this.solutionlabel.Name = "solutionlabel";
            this.solutionlabel.Size = new System.Drawing.Size(500, 200);
            this.solutionlabel.TabIndex = 2;
            this.solutionlabel.Text = "Lösung";
            this.solutionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.yesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbutton.Location = new System.Drawing.Point(15, 275);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(75, 57);
            this.yesbutton.TabIndex = 3;
            this.yesbutton.Text = "Ich lag richtig";
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Visible = false;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            // 
            // nobutton
            // 
            this.nobutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobutton.Location = new System.Drawing.Point(96, 275);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(75, 57);
            this.nobutton.TabIndex = 4;
            this.nobutton.Text = "Ich lag falsch";
            this.nobutton.UseVisualStyleBackColor = false;
            this.nobutton.Visible = false;
            this.nobutton.Click += new System.EventHandler(this.nobutton_Click);
            // 
            // showsolutionbutton
            // 
            this.showsolutionbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.showsolutionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showsolutionbutton.Location = new System.Drawing.Point(196, 275);
            this.showsolutionbutton.Name = "showsolutionbutton";
            this.showsolutionbutton.Size = new System.Drawing.Size(151, 57);
            this.showsolutionbutton.TabIndex = 5;
            this.showsolutionbutton.Text = "Lösung anzeigen";
            this.showsolutionbutton.UseVisualStyleBackColor = false;
            this.showsolutionbutton.Visible = false;
            this.showsolutionbutton.Click += new System.EventHandler(this.showsolutionbutton_Click);
            // 
            // pointsinfolabel
            // 
            this.pointsinfolabel.AutoSize = true;
            this.pointsinfolabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pointsinfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsinfolabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pointsinfolabel.Location = new System.Drawing.Point(460, 278);
            this.pointsinfolabel.MinimumSize = new System.Drawing.Size(80, 50);
            this.pointsinfolabel.Name = "pointsinfolabel";
            this.pointsinfolabel.Size = new System.Drawing.Size(86, 50);
            this.pointsinfolabel.TabIndex = 6;
            this.pointsinfolabel.Text = "Punkte: ";
            this.pointsinfolabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textdateiÄndernToolStripMenuItem,
            this.schwierigkeitToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // textdateiÄndernToolStripMenuItem
            // 
            this.textdateiÄndernToolStripMenuItem.Name = "textdateiÄndernToolStripMenuItem";
            this.textdateiÄndernToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.textdateiÄndernToolStripMenuItem.Text = "Textdatei ändern";
            this.textdateiÄndernToolStripMenuItem.Click += new System.EventHandler(this.changefileMenuItem_click);
            // 
            // schwierigkeitToolStripMenuItem
            // 
            this.schwierigkeitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leichtToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.schwerToolStripMenuItem});
            this.schwierigkeitToolStripMenuItem.Name = "schwierigkeitToolStripMenuItem";
            this.schwierigkeitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.schwierigkeitToolStripMenuItem.Text = "Schwierigkeit";
            // 
            // leichtToolStripMenuItem
            // 
            this.leichtToolStripMenuItem.Name = "leichtToolStripMenuItem";
            this.leichtToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.leichtToolStripMenuItem.Text = "Leicht";
            this.leichtToolStripMenuItem.Click += new System.EventHandler(this.leichtToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // schwerToolStripMenuItem
            // 
            this.schwerToolStripMenuItem.Name = "schwerToolStripMenuItem";
            this.schwerToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.schwerToolStripMenuItem.Text = "Schwer";
            this.schwerToolStripMenuItem.Click += new System.EventHandler(this.schwerToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "woop";
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(372, 275);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(82, 57);
            this.nextbutton.TabIndex = 8;
            this.nextbutton.Text = "Nächstes";
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // roundcounterlabel
            // 
            this.roundcounterlabel.AutoSize = true;
            this.roundcounterlabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundcounterlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.roundcounterlabel.Location = new System.Drawing.Point(12, 210);
            this.roundcounterlabel.MinimumSize = new System.Drawing.Size(100, 20);
            this.roundcounterlabel.Name = "roundcounterlabel";
            this.roundcounterlabel.Size = new System.Drawing.Size(100, 20);
            this.roundcounterlabel.TabIndex = 9;
            this.roundcounterlabel.Text = "Runde: 1";
            // 
            // pointslabel
            // 
            this.pointslabel.AutoSize = true;
            this.pointslabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pointslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointslabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pointslabel.Location = new System.Drawing.Point(552, 278);
            this.pointslabel.MinimumSize = new System.Drawing.Size(10, 50);
            this.pointslabel.Name = "pointslabel";
            this.pointslabel.Size = new System.Drawing.Size(10, 50);
            this.pointslabel.TabIndex = 10;
            this.pointslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // derpassistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(715, 348);
            this.Controls.Add(this.pointslabel);
            this.Controls.Add(this.roundcounterlabel);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.pointsinfolabel);
            this.Controls.Add(this.showsolutionbutton);
            this.Controls.Add(this.nobutton);
            this.Controls.Add(this.yesbutton);
            this.Controls.Add(this.solutionlabel);
            this.Controls.Add(this.wordtypelabel);
            this.Controls.Add(this.wordlabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "derpassistant";
            this.Text = "Derp Assistant 2018";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordlabel;
        private System.Windows.Forms.Label wordtypelabel;
        private System.Windows.Forms.Label solutionlabel;
        private System.Windows.Forms.Button nobutton;
        private System.Windows.Forms.Button showsolutionbutton;
        private System.Windows.Forms.Label pointsinfolabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textdateiÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Label roundcounterlabel;
        private System.Windows.Forms.Label pointslabel;
        private System.Windows.Forms.ToolStripMenuItem schwierigkeitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwerToolStripMenuItem;
        private System.Windows.Forms.Button yesbutton;
    }
}

