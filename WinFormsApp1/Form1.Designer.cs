namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.buttonToEnglish = new System.Windows.Forms.Button();
            this.textBoxPigLatin = new System.Windows.Forms.TextBox();
            this.buttonToPigLatin = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelGame = new System.Windows.Forms.Label();
            this.labelCheat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(56, 49);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(164, 23);
            this.textBoxEnglish.TabIndex = 0;
            // 
            // buttonToEnglish
            // 
            this.buttonToEnglish.Location = new System.Drawing.Point(226, 49);
            this.buttonToEnglish.Name = "buttonToEnglish";
            this.buttonToEnglish.Size = new System.Drawing.Size(111, 23);
            this.buttonToEnglish.TabIndex = 1;
            this.buttonToEnglish.Text = "<-- To English";
            this.buttonToEnglish.UseVisualStyleBackColor = true;
            this.buttonToEnglish.Click += new System.EventHandler(this.buttonToEnglish_Click);
            // 
            // textBoxPigLatin
            // 
            this.textBoxPigLatin.Location = new System.Drawing.Point(459, 49);
            this.textBoxPigLatin.Name = "textBoxPigLatin";
            this.textBoxPigLatin.Size = new System.Drawing.Size(164, 23);
            this.textBoxPigLatin.TabIndex = 2;
            // 
            // buttonToPigLatin
            // 
            this.buttonToPigLatin.Location = new System.Drawing.Point(357, 49);
            this.buttonToPigLatin.Name = "buttonToPigLatin";
            this.buttonToPigLatin.Size = new System.Drawing.Size(96, 23);
            this.buttonToPigLatin.TabIndex = 3;
            this.buttonToPigLatin.Text = "To PigLatin -->";
            this.buttonToPigLatin.UseVisualStyleBackColor = true;
            this.buttonToPigLatin.Click += new System.EventHandler(this.buttonToPigLatin_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(56, 111);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(56, 148);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumber.TabIndex = 5;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(56, 186);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(75, 23);
            this.buttonGuess.TabIndex = 7;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Location = new System.Drawing.Point(162, 151);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(79, 15);
            this.labelGame.TabIndex = 8;
            this.labelGame.Text = "Game Status: ";
            // 
            // labelCheat
            // 
            this.labelCheat.AutoSize = true;
            this.labelCheat.Location = new System.Drawing.Point(299, 151);
            this.labelCheat.Name = "labelCheat";
            this.labelCheat.Size = new System.Drawing.Size(63, 15);
            this.labelCheat.TabIndex = 9;
            this.labelCheat.Text = "labelCheat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 245);
            this.Controls.Add(this.labelCheat);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonToPigLatin);
            this.Controls.Add(this.textBoxPigLatin);
            this.Controls.Add(this.buttonToEnglish);
            this.Controls.Add(this.textBoxEnglish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxEnglish;
        private Button buttonToEnglish;
        private TextBox textBoxPigLatin;
        private Button buttonToPigLatin;
        private Button buttonNewGame;
        private TextBox textBoxNumber;
        private Button buttonGuess;
        private Label labelGame;
        private Label labelCheat;
    }
}