using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_3___Section_1
{
    // Author: Michele Gay
    // Created Date: 05/05/2020
    // Purpose: Allows the user to select a group of countries from a list box
    //          by letter. This group can then be exported to a fixed-width 
    //          (.txt) or comma-delimited (.csv) file. 

    public partial class startupForm : Form
    {
        public startupForm()
        {
            InitializeComponent();
        }

        List<string> locationList = new List<string>();
        List<string> searchList = new List<string>();

        private void exportDelimButton_Click(object sender, EventArgs e)
        {
            const String EXPORTED_FILE_NAME = "\\" + "P3S1 Comma Delimited Export.csv";
            int curLocationInteger = 0;

            try
            {
                // Create a file and get a StreamWriter object. 
                StreamWriter selectedLocationsFile;

                selectedLocationsFile = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + EXPORTED_FILE_NAME);

                // Write message to file if no countries are in the listbox. 
                if (locationListBox.Items.Count == 0)
                {
                    selectedLocationsFile.Write("RECORD CRITERIA HAS 0 MATCHES");
                }
                // Write the location(s) from the listbox to the file. Add quotation marks and commas between each item. 
                else
                {
                    while (curLocationInteger < locationListBox.Items.Count)
                    {
                        if (curLocationInteger <= (locationListBox.Items.Count - 2))
                        {
                            selectedLocationsFile.Write("\"" + locationListBox.Items[curLocationInteger].ToString() + "\",");
                            curLocationInteger = curLocationInteger + 1;
                        }
                        else if (curLocationInteger == (locationListBox.Items.Count - 1))
                        {
                            selectedLocationsFile.Write("\"" + locationListBox.Items[curLocationInteger].ToString() + "\"");
                            curLocationInteger = curLocationInteger + 1;
                        }

                    }
                }

                // Close the file and confirm the process has completed.
                selectedLocationsFile.Close();
                MessageBox.Show("Location(s) file exported.  Click \"OK\" to continue.");
            }
            catch (Exception GenericException)
            {
                MessageBox.Show(GenericException.Message);
                return;
            }
        }

        private void exportFixedWidthButton_Click(object sender, EventArgs e)
        {
            const String EXPORTED_FILE_NAME = "\\" + "P3S1 Fixed Width Export.txt";
            const int TOTAL_SPACE_AVAILABLE = 15;
            int curLocationInteger = 0;

            try
            {
                // Create a file and get a StreamWriter object. 
                StreamWriter selectedLocationsFile;
                selectedLocationsFile = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + EXPORTED_FILE_NAME);

                if (locationListBox.Items.Count == 0)
                {
                    selectedLocationsFile.Write("THE CRITERIA HAS NO MATCHES");
                }
                else
                {
                    while (curLocationInteger < locationListBox.Items.Count)
                    {
                        string country = locationListBox.Items[curLocationInteger].ToString();
                        int countryLength = country.Length;
                        int numSpaces = TOTAL_SPACE_AVAILABLE - country.Length;
                        selectedLocationsFile.WriteLine(locationListBox.Items[curLocationInteger].ToString() + String.Empty.PadRight(numSpaces, ' '));
                        curLocationInteger = curLocationInteger + 1;
                    }
                }
                
                // Close the file and confirm the process has completed.
                selectedLocationsFile.Close();
                MessageBox.Show("Location(s) file exported.  Click \"OK\" to continue.");
            }
            catch (Exception GenericException)
            {
                MessageBox.Show(GenericException.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Confirm the form exit by prompting the user first.
            if (MessageBox.Show("Are you sure you want to exit?",
                "Confirm exit...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void startupForm_Load(object sender, EventArgs e)
        {
            letterComboBox.SelectedIndex = 2;

            try
            {
                string locationNameString;
                StreamReader p3S1InputDataFile;
                int cycleCount = 0;

                //Open the file and get a StreamReader object.
                p3S1InputDataFile = File.OpenText("P3S1 Data File For Import.txt");

                //Read the input file's contents until end of stream.
                while (!p3S1InputDataFile.EndOfStream)
                {
                    locationNameString = p3S1InputDataFile.ReadLine();
                    cycleCount++;

                    // Exclude first two entries.
                    if (cycleCount >= 3)
                    {
                        //Declares new line as a delimiter. 
                        char[] delimiter = new char[] { '\n' };

                        //Declares an array countries
                        var countries = locationNameString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

                        foreach (object country in countries)
                        {
                            locationListBox.Items.Add(country.ToString());
                            searchList.Add(country.ToString());
                        }
                    }
                }

                // Close the file and confirm the process has completed.
                p3S1InputDataFile.Close();  
            }
            catch (Exception genericException)
            {
                MessageBox.Show(genericException.Message);
                return;
            }
        }

        private void letterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationList.Clear();
            string selLetter = letterComboBox.SelectedItem.ToString();

            for (int i = 0; i < searchList.Count; i++)
            {
                //If a country starts with the selected letter, add to the locationList.
                string curElement = searchList.ElementAt(i).ToString();
                char firstLetter = curElement[0];
                string firstLet = firstLetter.ToString();
                if (firstLet == selLetter)
                {
                    locationList.Add(searchList.ElementAt(i).ToString());

                }
            }

            locationListBox.Items.Clear();
            
            //Display items from locationList in the list box. 
            foreach (string str in locationList)
            {
                locationListBox.Items.Add(str);
            }
        }
    }
}
