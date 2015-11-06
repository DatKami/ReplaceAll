using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceAll
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      error.Text = "";
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void sourceButton_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
          source.Text = openFileDialog1.FileName;
          error.Text = "";
      }
    }

    private void convertButton_Click_1(object sender, EventArgs e)
    {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        convert.Text = folderBrowserDialog1.SelectedPath;
        error.Text = "";
      }
    }

    private void goButton_Click(object sender, EventArgs e)
    {

      string conv = convert.Text;
      string sorc = source.Text;
      error.Text = ""; //zero it out

      if (!Directory.Exists(conv))
      {
        error.Text = error.Text +  "Convert folder is invalid. ";
      }
      if (!File.Exists(sorc))
      {
        error.Text = error.Text +  "File doesn't exist. ";
      }
      else if (Directory.Exists(conv) && Path.GetDirectoryName(sorc) == conv)
      {
        error.Text = error.Text + "Source file should not be in the convert folder. ";
      }
      else //good to go!
      {
        var confirmResult = MessageBox.Show("Make backups.\n"
                                             +"All items in this folder will be replaced."
                                             +"\nAre you sure you want to do this?",
                                     "Confirm Replace",
                                     MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
          if (convert.Text.EndsWith(Path.DirectorySeparatorChar.ToString()))
          {
            conv = convert.Text.Remove(convert.Text.Length - 1);
          }

          error.Text = "";
          string[] files = Directory.GetFiles(conv, "*.*", SearchOption.TopDirectoryOnly);
          int numFiles = files.Count();
          List<string> filenames = new List<string>();
          for (int i = 0; i < numFiles; ++i)
            filenames.Add(Path.GetFileName(files[i]));

          status.Text = "Working...";
          for (int j = 0; j < numFiles; ++j)
          {
            File.Copy(sorc, conv + Path.DirectorySeparatorChar + filenames[j], true);
          }
          status.Text = "Finished!";
        }
      }
    }
  }
}
