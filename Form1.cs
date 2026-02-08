using System.Collections;
//Elizabeth Cooper/30444645
//Assesment 1, Task 2/3.
//program for inputting whole numbers representing file sizes in MB
//Displays Largest file size, total number of files, total memory used, and average file size
//uses ArrayList to store and display file sizes

namespace Assesment1c_
{
    public partial class Form1 : Form
    {
        ArrayList filesArray = new ArrayList();
        int FileSizes = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //Submit button, adds file size to arraylist and calls other methods to display results
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            int MB = int.Parse(FileSizetxt.Text);
            filesArray.Add(MB);
           

            string output = "MB Sizes: ";
            foreach (int i in filesArray)
            {
                output = output + " " + i;
            }
            FileSizeslbl.Text = output;

            Largestfile();
            Filecount();
            TotalMemory();
            AverageFiles();
        }
        //Method to find largest file size, 
        private void Largestfile()
        {
            int largest = int.Parse(filesArray[0].ToString());
            foreach (int i in filesArray)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            LargestFilelbl.Text = "Largest File In MB: " + largest;
        }
        //Method to count number of files
        private void Filecount()
        {
            int count = 0;
            foreach (int i in filesArray)
            {
                count++;
            }
            FileCountlbl.Text = "File Count = " + count;
        }
        //Method to calculate total memory used
        private void TotalMemory()
        {
            int total = 0;
            foreach (int i in filesArray)
            {
                total += i;
            }
            TotalMemorylbl.Text = "Total Memory Used In MB Is: " + total;
        }
        //Method to calculate average file size
        private void AverageFiles()
        {
            int total = 0;
            foreach(int i in filesArray)
            {
                total = total + i;
            }
            int average = total/filesArray.Count; //calculate average, .Count gets number of items in arraylist
            Averagelbl.Text = " Average of all file sizes: " + average;
        }
    }
}

