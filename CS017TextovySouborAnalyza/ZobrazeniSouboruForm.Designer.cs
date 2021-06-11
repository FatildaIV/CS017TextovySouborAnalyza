namespace CS016TextovySouborCteni
{
    partial class zobrazeniSouboruForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.souborObsahTextBox = new System.Windows.Forms.TextBox();
            this.souborNacteniButton = new System.Windows.Forms.Button();
            this.souborNactenPostupneiButton = new System.Windows.Forms.Button();
            this.nacitaniZastavitButton = new System.Windows.Forms.Button();
            this.statistikaLabel = new System.Windows.Forms.Label();
            this.pocetSlovLabel = new System.Windows.Forms.Label();
            this.cetnostSlovListBox = new System.Windows.Forms.ListBox();
            this.cetnostSlovLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // souborObsahTextBox
            // 
            this.souborObsahTextBox.Location = new System.Drawing.Point(12, 12);
            this.souborObsahTextBox.Multiline = true;
            this.souborObsahTextBox.Name = "souborObsahTextBox";
            this.souborObsahTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.souborObsahTextBox.Size = new System.Drawing.Size(568, 435);
            this.souborObsahTextBox.TabIndex = 0;
            // 
            // souborNacteniButton
            // 
            this.souborNacteniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.souborNacteniButton.Location = new System.Drawing.Point(357, 453);
            this.souborNacteniButton.Name = "souborNacteniButton";
            this.souborNacteniButton.Size = new System.Drawing.Size(223, 39);
            this.souborNacteniButton.TabIndex = 1;
            this.souborNacteniButton.Text = "Načíst soubor najednou";
            this.souborNacteniButton.UseVisualStyleBackColor = true;
            this.souborNacteniButton.Click += new System.EventHandler(this.souborNacteniButton_Click);
            // 
            // souborNactenPostupneiButton
            // 
            this.souborNactenPostupneiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.souborNactenPostupneiButton.Location = new System.Drawing.Point(586, 453);
            this.souborNactenPostupneiButton.Name = "souborNactenPostupneiButton";
            this.souborNactenPostupneiButton.Size = new System.Drawing.Size(227, 39);
            this.souborNactenPostupneiButton.TabIndex = 2;
            this.souborNactenPostupneiButton.Text = "Načíst soubor postupně";
            this.souborNactenPostupneiButton.UseVisualStyleBackColor = true;
            this.souborNactenPostupneiButton.Click += new System.EventHandler(this.souborNactenPostupneiButton_Click);
            // 
            // nacitaniZastavitButton
            // 
            this.nacitaniZastavitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nacitaniZastavitButton.Location = new System.Drawing.Point(12, 453);
            this.nacitaniZastavitButton.Name = "nacitaniZastavitButton";
            this.nacitaniZastavitButton.Size = new System.Drawing.Size(177, 39);
            this.nacitaniZastavitButton.TabIndex = 3;
            this.nacitaniZastavitButton.Text = "Zastavit načítání";
            this.nacitaniZastavitButton.UseVisualStyleBackColor = true;
            this.nacitaniZastavitButton.Click += new System.EventHandler(this.nacitaniZastavitButton_Click);
            // 
            // statistikaLabel
            // 
            this.statistikaLabel.AutoSize = true;
            this.statistikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistikaLabel.Location = new System.Drawing.Point(587, 13);
            this.statistikaLabel.Name = "statistikaLabel";
            this.statistikaLabel.Size = new System.Drawing.Size(134, 31);
            this.statistikaLabel.TabIndex = 4;
            this.statistikaLabel.Text = "Statistika:";
            // 
            // pocetSlovLabel
            // 
            this.pocetSlovLabel.AutoSize = true;
            this.pocetSlovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetSlovLabel.Location = new System.Drawing.Point(593, 48);
            this.pocetSlovLabel.Name = "pocetSlovLabel";
            this.pocetSlovLabel.Size = new System.Drawing.Size(116, 24);
            this.pocetSlovLabel.TabIndex = 5;
            this.pocetSlovLabel.Text = "Počet slov: ?";
            // 
            // cetnostSlovListBox
            // 
            this.cetnostSlovListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cetnostSlovListBox.FormattingEnabled = true;
            this.cetnostSlovListBox.ItemHeight = 16;
            this.cetnostSlovListBox.Location = new System.Drawing.Point(597, 120);
            this.cetnostSlovListBox.Name = "cetnostSlovListBox";
            this.cetnostSlovListBox.Size = new System.Drawing.Size(216, 180);
            this.cetnostSlovListBox.TabIndex = 6;
            // 
            // cetnostSlovLabel
            // 
            this.cetnostSlovLabel.AutoSize = true;
            this.cetnostSlovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cetnostSlovLabel.Location = new System.Drawing.Point(594, 104);
            this.cetnostSlovLabel.Name = "cetnostSlovLabel";
            this.cetnostSlovLabel.Size = new System.Drawing.Size(68, 13);
            this.cetnostSlovLabel.TabIndex = 7;
            this.cetnostSlovLabel.Text = "Četnost slov:";
            // 
            // zobrazeniSouboruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 504);
            this.Controls.Add(this.cetnostSlovLabel);
            this.Controls.Add(this.cetnostSlovListBox);
            this.Controls.Add(this.pocetSlovLabel);
            this.Controls.Add(this.statistikaLabel);
            this.Controls.Add(this.nacitaniZastavitButton);
            this.Controls.Add(this.souborNactenPostupneiButton);
            this.Controls.Add(this.souborNacteniButton);
            this.Controls.Add(this.souborObsahTextBox);
            this.Name = "zobrazeniSouboruForm";
            this.Text = "CS017 - Textový soubor analýza - Jakub Sirový";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox souborObsahTextBox;
        private System.Windows.Forms.Button souborNacteniButton;
        private System.Windows.Forms.Button souborNactenPostupneiButton;
        private System.Windows.Forms.Button nacitaniZastavitButton;
        private System.Windows.Forms.Label statistikaLabel;
        private System.Windows.Forms.Label pocetSlovLabel;
        private System.Windows.Forms.ListBox cetnostSlovListBox;
        private System.Windows.Forms.Label cetnostSlovLabel;
    }
}

