namespace PokerBotTestForm
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
            this.btnScreenCapture = new System.Windows.Forms.Button();
            this.btnHandCardCapture = new System.Windows.Forms.Button();
            this.btnCommunityCardCapture = new System.Windows.Forms.Button();
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.btnHandCards = new System.Windows.Forms.Button();
            this.btnCommCards = new System.Windows.Forms.Button();
            this.btnUIClick = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.Location = new System.Drawing.Point(13, 12);
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.Size = new System.Drawing.Size(111, 21);
            this.btnScreenCapture.TabIndex = 0;
            this.btnScreenCapture.Text = "Poker Screen capture";
            this.btnScreenCapture.UseVisualStyleBackColor = true;
            this.btnScreenCapture.Click += new System.EventHandler(this.btnScreenCapture_Click);
            // 
            // btnHandCardCapture
            // 
            this.btnHandCardCapture.Location = new System.Drawing.Point(143, 12);
            this.btnHandCardCapture.Name = "btnHandCardCapture";
            this.btnHandCardCapture.Size = new System.Drawing.Size(108, 21);
            this.btnHandCardCapture.TabIndex = 1;
            this.btnHandCardCapture.Text = "Hand Card Image";
            this.btnHandCardCapture.UseVisualStyleBackColor = true;
            this.btnHandCardCapture.Click += new System.EventHandler(this.btnHandCardCapture_Click);
            // 
            // btnCommunityCardCapture
            // 
            this.btnCommunityCardCapture.Location = new System.Drawing.Point(257, 12);
            this.btnCommunityCardCapture.Name = "btnCommunityCardCapture";
            this.btnCommunityCardCapture.Size = new System.Drawing.Size(95, 21);
            this.btnCommunityCardCapture.TabIndex = 2;
            this.btnCommunityCardCapture.Text = "Community Card Image";
            this.btnCommunityCardCapture.UseVisualStyleBackColor = true;
            this.btnCommunityCardCapture.Click += new System.EventHandler(this.btnCommunityCardCapture_Click);
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.Location = new System.Drawing.Point(13, 69);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(847, 366);
            this.pictureBoxScreen.TabIndex = 3;
            this.pictureBoxScreen.TabStop = false;
            // 
            // btnHandCards
            // 
            this.btnHandCards.Location = new System.Drawing.Point(358, 12);
            this.btnHandCards.Name = "btnHandCards";
            this.btnHandCards.Size = new System.Drawing.Size(75, 21);
            this.btnHandCards.TabIndex = 4;
            this.btnHandCards.Text = "Hand Cards";
            this.btnHandCards.UseVisualStyleBackColor = true;
            this.btnHandCards.Click += new System.EventHandler(this.btnHandCards_Click);
            // 
            // btnCommCards
            // 
            this.btnCommCards.Location = new System.Drawing.Point(439, 12);
            this.btnCommCards.Name = "btnCommCards";
            this.btnCommCards.Size = new System.Drawing.Size(84, 21);
            this.btnCommCards.TabIndex = 5;
            this.btnCommCards.Text = "Community Cards";
            this.btnCommCards.UseVisualStyleBackColor = true;
            this.btnCommCards.Click += new System.EventHandler(this.btnCommCards_Click);
            // 
            // btnUIClick
            // 
            this.btnUIClick.Location = new System.Drawing.Point(529, 12);
            this.btnUIClick.Name = "btnUIClick";
            this.btnUIClick.Size = new System.Drawing.Size(84, 21);
            this.btnUIClick.TabIndex = 6;
            this.btnUIClick.Text = "flod";
            this.btnUIClick.UseVisualStyleBackColor = true;
            this.btnUIClick.Click += new System.EventHandler(this.btnUIClick_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "call";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 21);
            this.button2.TabIndex = 8;
            this.button2.Text = "raise";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(709, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 21);
            this.button3.TabIndex = 9;
            this.button3.Text = "todo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 446);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCommCards);
            this.Controls.Add(this.btnHandCards);
            this.Controls.Add(this.pictureBoxScreen);
            this.Controls.Add(this.btnCommunityCardCapture);
            this.Controls.Add(this.btnHandCardCapture);
            this.Controls.Add(this.btnScreenCapture);
            this.Controls.Add(this.btnUIClick);
            this.Name = "Form1";
            this.Text = "PokerStars Bot Test Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScreenCapture;
        private System.Windows.Forms.Button btnHandCardCapture;
        private System.Windows.Forms.Button btnCommunityCardCapture;
        private System.Windows.Forms.PictureBox pictureBoxScreen;
        private System.Windows.Forms.Button btnHandCards;
        private System.Windows.Forms.Button btnCommCards;
        private System.Windows.Forms.Button btnUIClick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

