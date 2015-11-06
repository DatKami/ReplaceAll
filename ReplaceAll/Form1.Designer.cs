namespace ReplaceAll
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
      this.label1 = new System.Windows.Forms.Label();
      this.source = new System.Windows.Forms.TextBox();
      this.sourceButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.convert = new System.Windows.Forms.TextBox();
      this.convertButton = new System.Windows.Forms.Button();
      this.goButton = new System.Windows.Forms.Button();
      this.status = new System.Windows.Forms.Label();
      this.error = new System.Windows.Forms.Label();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Source File:";
      // 
      // source
      // 
      this.source.Location = new System.Drawing.Point(103, 6);
      this.source.Name = "source";
      this.source.Size = new System.Drawing.Size(263, 20);
      this.source.TabIndex = 1;
      // 
      // sourceButton
      // 
      this.sourceButton.Location = new System.Drawing.Point(372, 6);
      this.sourceButton.Name = "sourceButton";
      this.sourceButton.Size = new System.Drawing.Size(75, 23);
      this.sourceButton.TabIndex = 2;
      this.sourceButton.Text = "Select";
      this.sourceButton.UseVisualStyleBackColor = true;
      this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Folder to Convert:";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // convert
      // 
      this.convert.Location = new System.Drawing.Point(103, 37);
      this.convert.Name = "convert";
      this.convert.Size = new System.Drawing.Size(263, 20);
      this.convert.TabIndex = 4;
      // 
      // convertButton
      // 
      this.convertButton.Location = new System.Drawing.Point(372, 35);
      this.convertButton.Name = "convertButton";
      this.convertButton.Size = new System.Drawing.Size(75, 23);
      this.convertButton.TabIndex = 5;
      this.convertButton.Text = "Select";
      this.convertButton.UseVisualStyleBackColor = true;
      this.convertButton.Click += new System.EventHandler(this.convertButton_Click_1);
      // 
      // goButton
      // 
      this.goButton.Location = new System.Drawing.Point(372, 64);
      this.goButton.Name = "goButton";
      this.goButton.Size = new System.Drawing.Size(75, 23);
      this.goButton.TabIndex = 6;
      this.goButton.Text = "Replace";
      this.goButton.UseVisualStyleBackColor = true;
      this.goButton.Click += new System.EventHandler(this.goButton_Click);
      // 
      // status
      // 
      this.status.AutoSize = true;
      this.status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.status.Location = new System.Drawing.Point(261, 69);
      this.status.Name = "status";
      this.status.Size = new System.Drawing.Size(105, 13);
      this.status.TabIndex = 7;
      this.status.Text = "When you\'re ready...";
      this.status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // error
      // 
      this.error.AutoSize = true;
      this.error.ForeColor = System.Drawing.Color.Red;
      this.error.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.error.Location = new System.Drawing.Point(12, 69);
      this.error.Name = "error";
      this.error.Size = new System.Drawing.Size(24, 13);
      this.error.TabIndex = 8;
      this.error.Text = "sad";
      this.error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // folderBrowserDialog1
      // 
      this.folderBrowserDialog1.ShowNewFolderButton = false;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 95);
      this.Controls.Add(this.error);
      this.Controls.Add(this.status);
      this.Controls.Add(this.goButton);
      this.Controls.Add(this.convertButton);
      this.Controls.Add(this.convert);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.sourceButton);
      this.Controls.Add(this.source);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "ReplaceAll";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox source;
    private System.Windows.Forms.Button sourceButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox convert;
    private System.Windows.Forms.Button convertButton;
    private System.Windows.Forms.Button goButton;
    private System.Windows.Forms.Label status;
    private System.Windows.Forms.Label error;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}

