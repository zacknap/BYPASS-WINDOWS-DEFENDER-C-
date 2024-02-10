using System.Net;
using System.Security.Policy;

namespace BYPASS_C_;

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
    public TextBox URL = new TextBox();
    public TextBox filename = new TextBox();
    public Button download = new Button();
    public void install(string url,string FileName) {
        WebClient niker = new WebClient();
        niker.DownloadFile(url,FileName);
    }
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(860, 450);
        this.Text = "CLICK BYPASSER - MADE BY ZACK - BYPASS WINDOWS DEFENDER";
        this.BackColor = Color.FromArgb(29,29,29);
        URL.Size = new Size(860,35);
        URL.BorderStyle = BorderStyle.None;
        URL.BackColor = Color.FromArgb(45,45,45);
        URL.ForeColor = Color.White;
        URL.Location = new Point(0,100);
        URL.Multiline = true;
        filename.Size = new Size(150,25);
        filename.BorderStyle = BorderStyle.None;
        filename.BackColor = Color.FromArgb(45,45,45);
        filename.ForeColor = Color.White;
        filename.Location = new Point(350,50);
        filename.Multiline = true;
        download.BackColor = Color.FromArgb(60,60,60);
        download.Location = new Point(350,150);
        download.ForeColor = Color.White;
        download.Text = "Download";
        download.Size = new Size(150,50);
        download.FlatStyle = FlatStyle.Flat;
        download.FlatAppearance.BorderSize = 0;
        download.Click += (sender,args) => {
            install(URL.Text,filename.Text);
        };
        this.Controls.Add(URL);
        this.Controls.Add(download);
        this.Controls.Add(filename);
    }

    #endregion
}
