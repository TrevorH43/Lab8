using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class WordForm : Form
    {
        // Dictionary for the word index
        private SortedDictionary<string, List<int>> wordIndex = new SortedDictionary<string, List<int>>();
        public WordForm()
        {
            InitializeComponent();
        }

        private void wordIndexButton_Click(object sender, EventArgs e)
        {
            BuildDictionary();
            WriteIndexFile();
        }
        private void BuildDictionary()
        {
            int lineNumber = 1;

            string infileName = "";  // Input file name

            // Get the user's selected file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                infileName = openFileDialog1.FileName;
                using (StreamReader sr = File.OpenText(infileName))
                {
                    string line;

                    // Read the input file
                    while ((line = sr.ReadLine()) != null)
                    {
                        // tokenize the line.
                        string[] tokens = line.Split();

                        // Remove any punctuation characters.
                        RemovePunctuation(tokens);

                        // Add these words to the dictionary
                        AddWords(tokens, lineNumber);

                        // Increment the line number.
                        lineNumber++;
                    }
                }
            }
        }
        private void RemovePunctuation(string[] strarray)
        {
            // Iterate over the array of tokens.
            for (int i = 0; i < strarray.Length; i++)
            {
                // Is the last character in the current element a puctuation character?
                if (char.IsPunctuation(strarray[i][strarray[i].Length - 1]))
                {
                    // If so, then remove that character.
                    strarray[i] = strarray[i].Remove(strarray[i].Length - 1);
                }
            }
        }
        private void AddWords(string[] tokens, int lineNumber)
        {
            foreach (string word in tokens)
            {
                // If the word is already in the dictionary, add this word's
                // line number to its list.
                if (wordIndex.ContainsKey(word))
                {
                    // If the word occurs more than once on the line, only add the line number once
                    if (!wordIndex[word].Contains(lineNumber))
                        wordIndex[word].Add(lineNumber);
                }
                else
                {
                    // Create a new list for this word's line numbers
                    List<int> lineNums = new List<int>();

                    // Add this line number to the list.
                    lineNums.Add(lineNumber);

                    // Add the word and the list to the dictionary.
                    wordIndex[word] = lineNums;
                }
            }
        }
        private void WriteIndexFile()
        {
            string outputString;

            try
            {
                // Create the index file.
                using (StreamWriter outfile = File.CreateText("c:\\tmp\\index.txt"))
                {
                    // Write the dictionary contents to the file.
                    foreach (var element in wordIndex)
                    {
                        // Add the word to the output string.
                        outputString = element.Key + ": ";

                        // Add the line numbers to the output string.
                        foreach (int lineNum in element.Value)
                        {
                            outputString += lineNum.ToString() + " ";
                        }

                        // Write the output string to the file.
                        outfile.WriteLine(outputString);
                    }
                }

                // Message the user.
                MessageBox.Show("Index written to the file index.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
