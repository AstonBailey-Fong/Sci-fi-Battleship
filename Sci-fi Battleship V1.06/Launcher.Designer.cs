
namespace Sci_fi_Battleship
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.PlayerFaction = new System.Windows.Forms.ComboBox();
            this.EnemyFaction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadGameSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(668, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sci-Fi Battleship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player Faction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1524, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enemy Faction";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Disable Special Abilities",
            "Disable Sound Effects",
            "Disable Music"});
            this.checkedListBox1.Location = new System.Drawing.Point(807, 220);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(355, 105);
            this.checkedListBox1.TabIndex = 6;
            // 
            // PlayerFaction
            // 
            this.PlayerFaction.FormattingEnabled = true;
            this.PlayerFaction.Items.AddRange(new object[] {
            "United Federation of Planets (ST)",
            "Klingon Empire (ST)",
            "Romulan Star Empire (ST)",
            "Borg Collective (ST)",
            "Rebel Alliance (SW)",
            "Galactic Empire (SW)",
            "Twelve Colonies of Kobol (BSG)",
            "Cylon Empire (BSG)"});
            this.PlayerFaction.Location = new System.Drawing.Point(249, 220);
            this.PlayerFaction.Name = "PlayerFaction";
            this.PlayerFaction.Size = new System.Drawing.Size(410, 39);
            this.PlayerFaction.TabIndex = 7;
            // 
            // EnemyFaction
            // 
            this.EnemyFaction.FormattingEnabled = true;
            this.EnemyFaction.Items.AddRange(new object[] {
            "United Federation of Planets (ST)",
            "Klingon Empire (ST)",
            "Romulan Star Empire (ST)",
            "Borg Collective (ST)",
            "Rebel Alliance (SW)",
            "Galactic Empire (SW)",
            "Twelve Colonies of Kobol (BSG)",
            "Cylon Empire (BSG)"});
            this.EnemyFaction.Location = new System.Drawing.Point(1530, 220);
            this.EnemyFaction.Name = "EnemyFaction";
            this.EnemyFaction.Size = new System.Drawing.Size(410, 39);
            this.EnemyFaction.TabIndex = 8;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sci_fi_Battleship.Properties.Resources.imperial_overconfidence_by_dariustrent_degtqcb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1978, 725);
            this.Controls.Add(this.EnemyFaction);
            this.Controls.Add(this.PlayerFaction);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.Text = "Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox PlayerFaction;
        private System.Windows.Forms.ComboBox EnemyFaction;
    }
}