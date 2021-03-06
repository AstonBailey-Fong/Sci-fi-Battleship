
namespace Sci_fi_Battleship
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPlayerS = new System.Windows.Forms.Label();
            this.txtEnemyS = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.EnemyAttack = new System.Windows.Forms.Label();
            this.EnemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerS
            // 
            this.txtPlayerS.AutoSize = true;
            this.txtPlayerS.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayerS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerS.ForeColor = System.Drawing.Color.White;
            this.txtPlayerS.Location = new System.Drawing.Point(690, 207);
            this.txtPlayerS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtPlayerS.Name = "txtPlayerS";
            this.txtPlayerS.Size = new System.Drawing.Size(91, 63);
            this.txtPlayerS.TabIndex = 0;
            this.txtPlayerS.Text = "00";
            this.txtPlayerS.Click += new System.EventHandler(this.txtPlayerS_Click);
            // 
            // txtEnemyS
            // 
            this.txtEnemyS.AutoSize = true;
            this.txtEnemyS.BackColor = System.Drawing.Color.Transparent;
            this.txtEnemyS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnemyS.ForeColor = System.Drawing.Color.White;
            this.txtEnemyS.Location = new System.Drawing.Point(1780, 207);
            this.txtEnemyS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtEnemyS.Name = "txtEnemyS";
            this.txtEnemyS.Size = new System.Drawing.Size(91, 63);
            this.txtEnemyS.TabIndex = 1;
            this.txtEnemyS.Text = "00";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoSize = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.ForeColor = System.Drawing.Color.White;
            this.txtHelp.Location = new System.Drawing.Point(160, 1023);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(740, 39);
            this.txtHelp.TabIndex = 2;
            this.txtHelp.Text = "1. Click on 3 different locations above to start";
            this.txtHelp.Click += new System.EventHandler(this.txtHelp_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(594, 35);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(242, 89);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.AttackButtonEvent);
            // 
            // w1
            // 
            this.w1.BackColor = System.Drawing.Color.White;
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w1.Location = new System.Drawing.Point(194, 422);
            this.w1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(180, 141);
            this.w1.TabIndex = 5;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = false;
            this.w1.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // w4
            // 
            this.w4.BackColor = System.Drawing.Color.White;
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w4.Location = new System.Drawing.Point(748, 422);
            this.w4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(180, 141);
            this.w4.TabIndex = 6;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = false;
            this.w4.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // w3
            // 
            this.w3.BackColor = System.Drawing.Color.White;
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w3.Location = new System.Drawing.Point(564, 422);
            this.w3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(180, 141);
            this.w3.TabIndex = 7;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = false;
            this.w3.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // w2
            // 
            this.w2.BackColor = System.Drawing.Color.White;
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w2.Location = new System.Drawing.Point(380, 422);
            this.w2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(180, 141);
            this.w2.TabIndex = 8;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = false;
            this.w2.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.White;
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(380, 572);
            this.x2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(180, 141);
            this.x2.TabIndex = 12;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.White;
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x3.Location = new System.Drawing.Point(564, 572);
            this.x3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(180, 141);
            this.x3.TabIndex = 11;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.Color.White;
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x4.Location = new System.Drawing.Point(748, 572);
            this.x4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(180, 141);
            this.x4.TabIndex = 10;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = false;
            this.x4.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.White;
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.Location = new System.Drawing.Point(194, 572);
            this.x1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(180, 141);
            this.x1.TabIndex = 9;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.Color.White;
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2.Location = new System.Drawing.Point(380, 719);
            this.y2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(180, 141);
            this.y2.TabIndex = 16;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = false;
            this.y2.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.Color.White;
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y3.Location = new System.Drawing.Point(564, 719);
            this.y3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(180, 141);
            this.y3.TabIndex = 15;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = false;
            this.y3.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // y4
            // 
            this.y4.BackColor = System.Drawing.Color.White;
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y4.Location = new System.Drawing.Point(748, 719);
            this.y4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(180, 141);
            this.y4.TabIndex = 14;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = false;
            this.y4.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.Color.White;
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1.Location = new System.Drawing.Point(194, 719);
            this.y1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(180, 141);
            this.y1.TabIndex = 13;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.Color.White;
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z2.Location = new System.Drawing.Point(380, 866);
            this.z2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(180, 141);
            this.z2.TabIndex = 20;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.Color.White;
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z3.Location = new System.Drawing.Point(564, 866);
            this.z3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(180, 141);
            this.z3.TabIndex = 19;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = false;
            this.z3.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // z4
            // 
            this.z4.BackColor = System.Drawing.Color.White;
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z4.Location = new System.Drawing.Point(748, 866);
            this.z4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(180, 141);
            this.z4.TabIndex = 18;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = false;
            this.z4.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.Color.White;
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z1.Location = new System.Drawing.Point(194, 866);
            this.z1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(180, 141);
            this.z1.TabIndex = 17;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.PlayerPositonEvent);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.White;
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(1192, 424);
            this.a1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(180, 141);
            this.a1.TabIndex = 5;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.White;
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a4.Location = new System.Drawing.Point(1746, 424);
            this.a4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(180, 141);
            this.a4.TabIndex = 6;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = false;
            this.a4.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.White;
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(1562, 424);
            this.a3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(180, 141);
            this.a3.TabIndex = 7;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.White;
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(1378, 424);
            this.a2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(180, 141);
            this.a2.TabIndex = 8;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(1192, 574);
            this.b1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(180, 141);
            this.b1.TabIndex = 9;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(1746, 574);
            this.b4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(180, 141);
            this.b4.TabIndex = 10;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(1562, 574);
            this.b3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(180, 141);
            this.b3.TabIndex = 11;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(1378, 574);
            this.b2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(180, 141);
            this.b2.TabIndex = 12;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.White;
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(1192, 721);
            this.c1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(180, 141);
            this.c1.TabIndex = 13;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.Color.White;
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(1746, 721);
            this.c4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(180, 141);
            this.c4.TabIndex = 14;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = false;
            this.c4.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.White;
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(1562, 721);
            this.c3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(180, 141);
            this.c3.TabIndex = 15;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = false;
            this.c3.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.White;
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(1378, 721);
            this.c2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(180, 141);
            this.c2.TabIndex = 16;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = false;
            this.c2.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.White;
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Location = new System.Drawing.Point(1192, 868);
            this.d1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(180, 141);
            this.d1.TabIndex = 17;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = false;
            this.d1.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.White;
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4.Location = new System.Drawing.Point(1746, 868);
            this.d4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(180, 141);
            this.d4.TabIndex = 18;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = false;
            this.d4.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.White;
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3.Location = new System.Drawing.Point(1562, 868);
            this.d3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(180, 141);
            this.d3.TabIndex = 19;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = false;
            this.d3.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.White;
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Location = new System.Drawing.Point(1378, 868);
            this.d2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(180, 141);
            this.d2.TabIndex = 20;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = false;
            this.d2.Click += new System.EventHandler(this.AttackSelectionEvent);
            // 
            // EnemyAttack
            // 
            this.EnemyAttack.AutoSize = true;
            this.EnemyAttack.BackColor = System.Drawing.Color.Transparent;
            this.EnemyAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyAttack.ForeColor = System.Drawing.Color.White;
            this.EnemyAttack.Location = new System.Drawing.Point(1734, 62);
            this.EnemyAttack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EnemyAttack.Name = "EnemyAttack";
            this.EnemyAttack.Size = new System.Drawing.Size(112, 63);
            this.EnemyAttack.TabIndex = 1;
            this.EnemyAttack.Text = "W1";
            // 
            // EnemyPlayTimer
            // 
            this.EnemyPlayTimer.Interval = 1000;
            this.EnemyPlayTimer.Tick += new System.EventHandler(this.EnemyPlayTimerEvent);
            // 
            // EnemyLocation
            // 
            this.EnemyLocation.AutoSize = true;
            this.EnemyLocation.BackColor = System.Drawing.Color.Transparent;
            this.EnemyLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLocation.ForeColor = System.Drawing.Color.White;
            this.EnemyLocation.Location = new System.Drawing.Point(369, 61);
            this.EnemyLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EnemyLocation.Name = "EnemyLocation";
            this.EnemyLocation.Size = new System.Drawing.Size(172, 63);
            this.EnemyLocation.TabIndex = 21;
            this.EnemyLocation.Text = "Blank";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sci_fi_Battleship.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2124, 1120);
            this.Controls.Add(this.EnemyLocation);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.EnemyAttack);
            this.Controls.Add(this.txtEnemyS);
            this.Controls.Add(this.txtPlayerS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Sci-Fi Battleship V1.03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayerS;
        private System.Windows.Forms.Label txtEnemyS;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Label EnemyAttack;
        private System.Windows.Forms.Timer EnemyPlayTimer;
        private System.Windows.Forms.Label EnemyLocation;
    }
}

