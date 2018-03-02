using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Ransom_Letter
{
    public partial class Form1 : Form
    {
        //making a random genartor to set the random size font and style attributes
        private Random randomSize = new Random();

        //making a string to hold the text in the textbox
        private string text;

        //the styles and fonts inculding the size of the individual letters are set here
        private int[] fontSize      = new int[]    {14, 16, 18 , 19, 20, 22, 24, 26}; //8
        private string[] fontType   = new string[] { "MS Gothic" , "Comic Sans MS", "Impact", "Gabriola", "MV Bali",
                                                     "Segoe Script", "Liberation Mono", "PMingLiU-ExtB", "Times New Roman",
                                                     "Palatino Linotype", "Courier New", "Source Code Pro"};
        private string[] fontStyle  = new string[] { "Italic", "Bold", "Cursive" };

        //the colors of the letters are set by this array
        private Color[] FontColors  = new Color[]  { Color.Red, Color.Green, Color.Blue, Color.Orange,  Color.Brown,
                                                    Color.Cyan, Color.Purple, Color.BurlyWood, Color.HotPink };

        public Form1()
        {
            InitializeComponent();
        }

        //this button opens the screen to load a rtf into the textbox
        private void btnImport_Click(object sender, EventArgs e)
        {
            var BrowseForText = new OpenFileDialog();

            //this makes the browsing happening an sets the text to the TextBox
            DialogResult result =  BrowseForText.ShowDialog();
            if (result == DialogResult.OK)
            {
                int size = -1;

                string file = BrowseForText.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    size = text.Length;
                    RansomLetterBox.Text = text;
                }
                catch (IOException)
                {
                }
            }
        }
       
        //with this button the program sets the individual letters from the text in differnt formats and calls the Draw Method
        private void btnRansomIt_Click(object sender, EventArgs e)
        {
            //if there is something typed convert that text.
            if(RansomLetterBox.Text != null)
            {
                text = RansomLetterBox.Text;
            }
            //checking if there is text and if not show message
            if (text == null)
            {
                MessageBox.Show("Geen text gevonden." + Environment.NewLine +
                                "typ er een en sla deze op" + Environment.NewLine + "of laad een .rtf bestand");

            }

            // if there is text run program
            else
            {
                // the loop looking for characters and then convert them to random fonts, styles, and sizes
                DrawRansom();  
            }

}


        //the actual part of the program that transforms the letters and put them into a string on screen
        private void DrawRansom()
        {
            //clearing the text from the Textbox
            RansomLetterBox.Text = null;

            //the loop making the text go random
            for (int i = 0; i < text.Length; i++)
            {
                //char that holds the text
                char kar = text[i];

                //this part randomizes the font
                int next = randomSize.Next(0, 12);
                string font = fontType[next];

                //this part randomizes the size
                int nextSize = randomSize.Next(0, 8);
                int fontGreat = fontSize[nextSize];

                //this part randomizes the style through the if statements
                int nextStyle = randomSize.Next(0, 3);
                string fontStylish = fontStyle[nextStyle];

                //the if statements changing the style and font and the size
                if (fontStyle[nextStyle] == fontStyle[0])
                {
                    //converting style size and font here
                    RansomLetterBox.SelectionFont = new Font(font, fontGreat, FontStyle.Italic);
                    //converting the color here
                    RansomLetterBox.SelectionColor = FontColors[randomSize.Next(0,FontColors.Length)];
                }
                else if (fontStyle[nextStyle] == fontStyle[1])
                {
                    //converting style size and font here
                    RansomLetterBox.SelectionFont = new Font(font, fontGreat, FontStyle.Bold);
                    //converting the color here
                    RansomLetterBox.SelectionColor = FontColors[randomSize.Next(0, FontColors.Length)];
                }
                else if (fontStyle[nextStyle] == fontStyle[2])
                {
                    //converting style size and font here
                    RansomLetterBox.SelectionFont = new Font(font, fontGreat, FontStyle.Underline);
                    //converting the color here
                    RansomLetterBox.SelectionColor = FontColors[randomSize.Next(0, FontColors.Length)];
                }
                //putting the chars out to the screen one by one
                RansomLetterBox.AppendText(kar.ToString());
            }
        }

        //the Screen that puts out the lines that are altered 
        private void RansomLetterBox_TextChanged(object sender, EventArgs e)
        {

        }

        //this button shows a screen where the file can be saved (in any folder you like)
        //it facilitates the possibility to save
        private void btnSave_Click(object sender, EventArgs e)
        {
            //creating a variable for the SaveFileDialog and setting the format of the text file
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".rtf";
            save.Filter = "RTF Files | *.rtf";
            try
            {
                //checks if the text is present. If not it goes to the exception
                if(save.ShowDialog() == DialogResult.OK && save.FileName.Length > 0)
                {
                    RansomLetterBox.SaveFile(save.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Geef me text om op te slaan!");
            }
        }
    }
}
