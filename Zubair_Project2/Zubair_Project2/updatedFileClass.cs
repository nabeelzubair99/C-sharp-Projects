using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zubair_Project2
{
    class updatedFileClass
    {// everything that we do in form 3 gets reflected into this class. it updates add and deletes the 
        //files from current file class and adds it to the updated one. 
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;  // Reference variable of type SW
        private int recordWrittenCount;
        
        // Constructor with file path input
        // Create instance of StreamWriter class (type) and store reference
        public updatedFileClass
            (string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                                "Input File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end updatedFileClass Constructor

        



        // Write a record to the updated file
        public void putNextRecord
            (string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IO error in file write. Terminate program.",
                                "File Write Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // end Try
            recordWrittenCount += 1;
        } // end puNextRecord



        // Get value of number of records written
        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        } // end getRecordsWritten



        // Close the output (updated) file
        public void closeFile()
        {
            
            updatedFileSW.Flush();
            updatedFileSW.Close();
        } // end closeFile



        // Rewind the output file
        public void rewindFile()
        {
            recordWrittenCount = 0;
            closeFile();
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile

    }
}

