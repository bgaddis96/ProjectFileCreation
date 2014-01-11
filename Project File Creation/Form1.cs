using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_File_Creation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                checkedListBox1.SetItemChecked(0, true);
                checkedListBox1.SetItemChecked(7, true);
                lakeCombobox.Text = "Cedar Creek Lake";
            
        }

        private void dockButton_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i <= 7; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                    if (i == 1 || i == 5)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }

            }
        }

        private void wallButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 6 || i == 5 || i == 3 || i == 2 || i == 8 || i == 1)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                else
                    checkedListBox1.SetItemChecked(i, true);
             
            }
        }

        private void dockwallButton_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (i == 8 || i == 5 || i == 1)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                    else
                    checkedListBox1.SetItemChecked(i, true);
                }

            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string projtest = Convert.ToString(comboBoxProject.Text);
            if (firstTextbox.TextLength == 0 || lastTextbox.TextLength == 0 || projtest.Length == 0) //This test to make sure the user has input a name
            {
                MessageBox.Show("Please enter the customer first name, last name, and project type.", "Name Error");
            }

            else
            {

                //defines the names for the folders and initials for files
                string f = Convert.ToString(firstTextbox.Text);
                string l = Convert.ToString(lastTextbox.Text);
                char fi = char.ToUpper(f[0]);
                char li = char.ToUpper(l[0]);
                string FI = Convert.ToString(fi);
                string LI = Convert.ToString(li);
                string firstName = FI + f.Remove(0, 1);
                string lastName = LI + l.Remove(0, 1);
                string addressid = addressTextbox.Text;
                string pType = Convert.ToString(comboBoxProject.Text);
                char p = char.ToUpper(pType[0]);
                string PI = Convert.ToString(p);
                string projectType = PI + pType.Remove(0, 1);
                string adprojectPath;


                if (addressid.Length==0) //Test if the address field is empty
                {
                    adprojectPath = FI + LI + " " + projectType + " Files";
                }
                else
                {
                    adprojectPath = FI + LI + " " + addressid + " " + projectType + " Files";
                }
                

                string lakeselection = Convert.ToString(lakeCombobox.Text);


                string user = Environment.UserName;

                    string path = System.IO.Path.Combine(@"C:\Users\", user, @"Dropbox\Projects\", lastName + ", " + firstName);
                    string targetpath = System.IO.Path.Combine(@"c:\Users\" + user + @"\Dropbox\Projects\" + l + ", " + f + @"\" + adprojectPath);


                if (System.IO.Directory.Exists(targetpath))
                {
                    MessageBox.Show("A project with this name already exists. Please rename the project. If you would like to add the files to the folder click the add button.");
                }

                else
                {
                    System.IO.Directory.CreateDirectory(path);
                    System.IO.Directory.CreateDirectory(path + @"\" + adprojectPath);
                    string sourcepath = System.IO.Path.Combine(@"c:\Users\" + user + @"\Dropbox\Forms");


                    if (checkedListBox1.GetItemChecked(0))
                    {
                        string appfile = "Bidding Sheet.xls";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(1))
                    {
                        string appfile = "Change Request Form.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(2))
                    {
                        if (Convert.ToString(lakeCombobox.Text) == "Cedar Creek Lake")
                        {
                        string appfile = "Cedar Creek Lake Dock Application for Improvement Permit.pdf";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Richland Chambers")
                        {
                            string appfile = "Richland Chambers Dock Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Lake Palestine")
                        {
                            string appfile = "Lake Palestine Dock Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }  


                    }

                 
                    if (checkedListBox1.GetItemChecked(3))
                    {
                        string appfile = "Dock Specifications.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(4))
                    {
                        string appfile = "App Insurance.pdf";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(5))
                    {
                        string appfile = "Letter of Authorization.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(6))
                    {
                        string appfile = "App Parks Insurance.pdf";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(7))
                    {
                        string appfile = "Proposal.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                    if (checkedListBox1.GetItemChecked(8))
                    {
                        string appfile = "Quote.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                    if (checkedListBox1.GetItemChecked(9))
                    {
                        string appfile = "Wall Specifications.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                    if (checkedListBox1.GetItemChecked(10))
                    {
                        if (Convert.ToString(lakeCombobox.Text) == "Cedar Creek Lake")
                        {
                            string appfile = "Cedar Creek Lake Wall Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Richland Chambers")
                        {
                            string appfile = "Richland Chambers Wall Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Lake Palestine")
                        {
                            string appfile = "Lake Palestine Wall Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }  


                    }
                    


                    System.Diagnostics.Process.Start(path + @"\" + adprojectPath);
                    if (Convert.ToString(lakeCombobox.Text) == "Richland Chambers")
                    {

                        string targetURL = "https://propaccess.trueautomation.com/clientdb/?cid=91";
                        System.Diagnostics.Process.Start(targetURL);


                    }
                    else
                    {
                        string targetURL = "http://www.isouthwestdata.com/client/webSearchName.aspx?dbkey=hendersoncad&stype=name&sdata=" + lastName;
                        System.Diagnostics.Process.Start(targetURL);
                    }
                    Close();
                }
            }
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutBox = new AboutBox();
            AboutBox.ShowDialog();
        }
        private void quoteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
			{
			 checkedListBox1.SetItemChecked(i,false);
			}
            checkedListBox1.SetItemChecked(8, true);
        }

        private void dredgeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 4 || i == 7 || i == 10)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                    checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string projtest = Convert.ToString(comboBoxProject.Text);
            if (firstTextbox.TextLength == 0 || lastTextbox.TextLength == 0 || projtest.Length == 0) //This test to make sure the user has input a name
            {
                MessageBox.Show("Please enter the customer's first name, last name, and project type.", "Name Error");
            }

            else
            {
                //defines the names for the folders and initials for files
                string f = Convert.ToString(firstTextbox.Text);
                string l = Convert.ToString(lastTextbox.Text);
                char fi = char.ToUpper(f[0]);
                char li = char.ToUpper(l[0]);
                string FI = Convert.ToString(fi);
                string LI = Convert.ToString(li);
                string firstName = FI + f.Remove(0, 1);
                string lastName = LI + l.Remove(0, 1);
                string pType = Convert.ToString(comboBoxProject.Text);
                char p = char.ToUpper(pType[0]);
                string PI = Convert.ToString(p);
                string projectType = PI + pType.Remove(0, 1);
                string addressid = addressTextbox.Text;
                string adprojectPath;


                if (addressid.Length == 0) //Test if the address field is empty
                {
                    adprojectPath = FI + LI + " " + projectType + " Files";
                }
                else
                {
                    adprojectPath = FI + LI + " " + addressid + " " + projectType + " Files";
                }

                string user = Environment.UserName;
                string path = System.IO.Path.Combine(@"C:\Users\", user, @"Dropbox\Projects\", lastName + ", " + firstName);
                string targetpath = System.IO.Path.Combine(@"c:\Users\" + user + @"\Dropbox\Projects\" + l + ", " + f + @"\" + adprojectPath);

                //Tests if the directory exists and gives message
                if (System.IO.Directory.Exists(targetpath) == false)
                {
                    DialogResult result = MessageBox.Show("This customer does not exist please select the Create File button or check your names.");
                }

                //Tests if the directory exists and then either runs the add or stops the add
                if (System.IO.Directory.Exists(targetpath))
                {
                   
                   //I eventually want the message bos to show the documents that the user has
                   //slected in an array
                    //foreach (object itemChecked in checkedListBox1.CheckedItems)
                    //{
                    //    string eachItem = itemChecked.ToString();
                    //    string allItems = eachItem + itemChecked.ToString();
                       
                    //}

                    DialogResult result = MessageBox.Show("Are you sure you want to add your selected documents to " + firstName + " " + lastName + "'s " + projectType + " project? THIS WILL OVERWRITE ANY EXISTING FILES SO BE SURE YOU HAVE THE CORRECT ONES SELECTED!", "Add Documents", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        goto ADDTHEM;
                    }
                    
                    if (result == DialogResult.No)
                    {
                        goto DONTADDTHEM;
                    }

                ADDTHEM:
                    System.IO.Directory.CreateDirectory(path);
                    System.IO.Directory.CreateDirectory(path + @"\" + adprojectPath);
                    string sourcepath = System.IO.Path.Combine(@"c:\Users\" + user + @"\Dropbox\Forms");


                    if (checkedListBox1.GetItemChecked(0))
                    {
                        string appfile = "Bidding Sheet.xls";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(1))
                    {
                        string appfile = "Change Request Form.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(2))
                    {
                        if (Convert.ToString(lakeCombobox.Text) == "Cedar Creek Lake")
                        {
                            string appfile = "Cedar Creek Lake Dock Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Richland Chambers")
                        {
                            string appfile = "Richland Chambers Dock Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Lake Palestine")
                        {
                            string appfile = "Lake Palestine Dock Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }  


                    }
                                        
                    if (checkedListBox1.GetItemChecked(3))
                    {
                        string appfile = "Dock Specifications.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(4))
                    {
                        string appfile = "App Insurance.pdf";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(5))
                    {
                        string appfile = "Letter of Authorization.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }

                    if (checkedListBox1.GetItemChecked(6))
                    {
                        string appfile = "App Parks Insurance.pdf";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                                       
                    if (checkedListBox1.GetItemChecked(7))
                    {
                        string appfile = "Proposal.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                    if (checkedListBox1.GetItemChecked(8))
                    {
                        string appfile = "Quote.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                    if (checkedListBox1.GetItemChecked(9))
                    {
                        string appfile = "Wall Specifications.docx";

                        string destappfile = FI + LI + " " + appfile;
                        string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                        string destFile = System.IO.Path.Combine(targetpath, destappfile);

                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                    if (checkedListBox1.GetItemChecked(10))
                    {
                        if (Convert.ToString(lakeCombobox.Text) == "Cedar Creek Lake")
                        {
                            string appfile = "Cedar Creek Lake Wall Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Richland Chambers")
                        {
                            string appfile = "Richland Chambers Wall Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }

                        if (Convert.ToString(lakeCombobox.Text) == "Lake Palestine")
                        {
                            string appfile = "Lake Palestine Wall Application for Improvement Permit.pdf";

                            string destappfile = FI + LI + " " + appfile;
                            string sourceFile = System.IO.Path.Combine(sourcepath, appfile);
                            string destFile = System.IO.Path.Combine(targetpath, destappfile);

                            System.IO.File.Copy(sourceFile, destFile, true);

                        }  


                    }



                    System.Diagnostics.Process.Start(path + @"\" + adprojectPath);

                    Close();
                DONTADDTHEM: ;
                }
            }
        }

        private void editDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string edituser = Environment.UserName;
            System.Diagnostics.Process.Start(@"c:\Users\" + edituser + @"\Dropbox\Forms");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 1)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                    checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lakeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}