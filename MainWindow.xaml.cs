using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HangmanProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        
    public partial class MainWindow : Window
    {
        string guessWord;
        string[] words; 
        Random r = new Random(1);
        public MainWindow()
        {
            InitializeComponent();


            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("words.txt");
                words = new string[10];
                int counter = 0;
                while (!sr.EndOfStream)
                {
                    words[counter] = sr.ReadLine();
                    // MessageBox.Show(words[counter]);
                    //Console.WriteLine(words[counter] + " " + words[counter].Length.ToString());
                    counter++;
                    
                    // MessageBox.Show(r.Next(10).ToString());

                    


                }
                sr.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            guessWord = words[r.Next(10)];
            Console.WriteLine(guessWord);
            string buildWord = "";
            for (int i=0; i < guessWord.Length; i++)
            {
                buildWord += "_ ";
            }
            Console.WriteLine(buildWord);
            string guessedLetter = "d";

            for (int i =0; i < guessWord.Length; i++)
            {
                if(guessedLetter == guessWord[i].ToString())
                {
                    buildWord += guessedLetter + " ";
                }

                MessageBox.Show(guessWord[i].ToString());

            }





        }

        
    }
}
