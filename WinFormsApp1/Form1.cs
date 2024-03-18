namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();
        int theNumber, numberOfTries;

        public Form1()
        {
            InitializeComponent();

            // game code below
            // disable the guess button unless user will click on New Game button
            buttonGuess.Enabled = false;
        }

        private void buttonToEnglish_Click(object sender, EventArgs e)
        {
            /*String word = textBoxPigLatin.Text;
            String firstChar = word.Substring(word.Length - 3, 1);
            String otherChars = word.Substring(0, word.Length - 3);
            String newWord = firstChar + otherChars;
            textBoxEnglish.Text = newWord;*/
            String[] words = textBoxPigLatin.Text.Split(" ");
            textBoxEnglish.Text = "";
            foreach (String word in words)
            {
                if (word.Length > 1)
                {
                    String firstChar = word.Substring(word.Length - 3, 1);
                    String otherChars = word.Substring(0, word.Length - 3);
                    textBoxEnglish.Text += firstChar + otherChars + " ";
                }
            }
        }

        private void buttonToPigLatin_Click(object sender, EventArgs e)
        {
            /*String firstChar = textBoxEnglish.Text.Substring(0, 1);
            String otherChars = textBoxEnglish.Text.Substring(1);
            String newWord = otherChars + firstChar + "ay";
            textBoxPigLatin.Text = newWord;*/
            String[] words = textBoxEnglish.Text.Split();
            foreach (String word in words)
            {
                if (word.Length > 1)
                {
                    String firstChar = word.Substring(0, 1);
                    String otherChars = word.Substring(1);
                    textBoxPigLatin.Text += otherChars + firstChar + "ay ";
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            buttonGuess.Enabled = true;
            theNumber = randomNumber.Next(1, 5);
            labelCheat.Text = theNumber.ToString();
            numberOfTries = 3;
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            
            int numberGuess = Convert.ToInt16(textBoxNumber.Text);
            String message = "";
            if (numberGuess > theNumber)
            {
                message = "Your number is higher";
                numberOfTries--;
            }
            else if (numberGuess < theNumber)
            {
                message = "Your number is lower";
                numberOfTries--;
            }
            else
            {
                message = "You guess it!";
            }
            if (numberOfTries < 0)
            {
                message = "Game Over!";
                buttonGuess.Enabled = false;
            }
            else {
                
            }
            MessageBox.Show(message);
        }
    }
}