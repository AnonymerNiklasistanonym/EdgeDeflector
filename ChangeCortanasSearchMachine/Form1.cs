using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Change_Search_Machine
{
    public partial class Form1 : Form
    {
        // The folder for the roaming current user 
        private string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private string foldername = "EdgeDeflector";
        private string filename = "ChangeUrl.txt";

        // Combine the base folder with your specific folder....
        private string specificFolder;
        private string change_url_file_path;

        private bool google_was_checked = false;
        private bool custom_was_checked = false;
        private bool duckduckgo_was_checked = false;

        private string DUCK_DUCK_GO_STRING = "duckduckgo.com/?q=";
        private string GOOGLE_START_STRING = "www.google.";
        private string GOOGLE_END_STRING = "/search?q=";

        private bool wait = false;

        private string content_text_file = null;

        enum Selection : int { BING = 0, GOOGLE = 1, CUSTOM = 2, DUCKDUCKGO = 3 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set the path to the file with the URL
            specificFolder = Path.Combine(folder, foldername);
            change_url_file_path = Path.Combine(specificFolder, filename);


            content_text_file = Read_URL_File();

            Format_GUI();

        }

        private void Format_GUI()
        {
            wait = true;

            int current_selection = Get_Current_Selection();

            if (current_selection == (int)Selection.BING)
            {
                RadioButtonCustom.Checked = false;
                RadioButtonGoogle.Checked = false;
                RadioButtonDuckDuckGo.Checked = false;
                TextBoxGoogle.Text = "com";
            }
            else if (current_selection == (int)Selection.GOOGLE)
            {
                RadioButtonCustom.Checked = false;
                RadioButtonGoogle.Checked = true;
                RadioButtonDuckDuckGo.Checked = false;

                string country_code = content_text_file.Replace(GOOGLE_START_STRING, "");
                country_code = country_code.Replace(GOOGLE_END_STRING, "");

                TextBoxGoogle.Text = country_code;
            }
            else if (current_selection == (int)Selection.DUCKDUCKGO)
            {
                RadioButtonCustom.Checked = false;
                RadioButtonGoogle.Checked = true;
                RadioButtonDuckDuckGo.Checked = true;
            }
            else
            {
                RadioButtonCustom.Checked = true;
                RadioButtonGoogle.Checked = false;
                RadioButtonDuckDuckGo.Checked = false;
                TextBoxGoogle.Text = "com";
            }

            TextBoxCustom.Text = content_text_file;

            wait = false;
        }

        private int Get_Current_Selection()
        {
            if (content_text_file == null)
            {
                return (int)Selection.BING;
            }
            else if (content_text_file.StartsWith(GOOGLE_START_STRING) && content_text_file.EndsWith(GOOGLE_END_STRING))
            {
                return (int)Selection.GOOGLE;
            }
            else if (content_text_file.Equals(DUCK_DUCK_GO_STRING))
            {
                return (int)Selection.DUCKDUCKGO;
            }
            else
            {
                return (int)Selection.CUSTOM;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            // Current File isn't BING
            if (Get_Current_Selection() != (int)Selection.BING)
            {
                Delete_url_file();

                RadioButtonCustom.Checked = false;
                RadioButtonGoogle.Checked = false;
            }

        }

        private void Delete_url_file()
        {
            if (File.Exists(change_url_file_path))
            {
                File.Delete(change_url_file_path);
            }

            content_text_file = null;

            MessageBox.Show("Rest to default search machine Bing was succsessful!");
        }

        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {

            if (RadioButtonCustom.Checked == true && !wait)
            {

                if (!custom_was_checked)
                {
                    Use_Custom();

                }
                else if (custom_was_checked)
                {
                    custom_was_checked = false;
                }
                else
                {
                    Format_GUI();
                }
            }


        }

        private void RadioButtonGoogle_CheckedChanged(object sender, EventArgs e)
        {

            if (RadioButtonGoogle.Checked == true && !wait)
            {

                if (!google_was_checked)
                {
                    Use_Google();
                }
                else if (google_was_checked)
                {
                    google_was_checked = false;
                }
                else
                {
                    Format_GUI();
                }

            }

        }

        private void Use_Google()
        {
            if (TextBoxGoogle.Text == "")
            {
                TextBoxGoogle.Text = "com";
            }

            New_Search_Machine("www.google." + TextBoxGoogle.Text + "/search?q=");

            RadioButtonCustom.Checked = false;
            RadioButtonDuckDuckGo.Checked = false;
        }

        private void Use_Custom()
        {
            if (TextBoxCustom.Text == "")
            {
                MessageBox.Show("You need to type in a search machine URL!");

                Format_GUI();

            }
            else
            {
                if (TextBoxCustom.Text.StartsWith("http://"))
                {
                    TextBoxCustom.Text = TextBoxCustom.Text.Replace("http://", "");
                }
                if (TextBoxCustom.Text.StartsWith("https://"))
                {
                    TextBoxCustom.Text = TextBoxCustom.Text.Replace("https://", "");
                }

                New_Search_Machine(TextBoxCustom.Text);

                Format_GUI();
            }
        }

        private void New_Search_Machine(string search_machine_url)
        {
            if (File.Exists(change_url_file_path))
            {
                File.Delete(change_url_file_path);
            }

            if (content_text_file == null || !content_text_file.Equals(search_machine_url))
            {
                // Check if folder exists and if not, create it
                if (!Directory.Exists(specificFolder))
                {
                    Directory.CreateDirectory(specificFolder);
                }

                using (FileStream fs = File.Create(change_url_file_path))
                {
                    content_text_file = search_machine_url;
                    TextBoxCustom.Text = content_text_file;

                    Byte[] info = new UTF8Encoding(true).GetBytes(content_text_file);
                    fs.Write(info, 0, info.Length);
                }

                MessageBox.Show($"The new search machine has the URL: {content_text_file}");
            }
        }

        private string Read_URL_File()
        {
            if (File.Exists(change_url_file_path))
            {
                return System.IO.File.ReadAllText(change_url_file_path);
            }
            else
            {
                return null;
            }
        }


        private void TextBoxGoogle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (RadioButtonCustom.Checked == true)
                {
                    custom_was_checked = true;
                }
                else if (RadioButtonDuckDuckGo.Checked == true)
                {
                    duckduckgo_was_checked = true;
                }

                RadioButtonGoogle.Checked = false;
                RadioButtonGoogle.Checked = true;
                RadioButtonDuckDuckGo.Checked = false;
            }

        }

        private void TextBoxCustom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (RadioButtonGoogle.Checked == true)
                {
                    google_was_checked = true;
                }
                else if (RadioButtonDuckDuckGo.Checked == true)
                {
                    duckduckgo_was_checked = true;
                }

                RadioButtonCustom.Checked = false;
                RadioButtonCustom.Checked = true;
                RadioButtonDuckDuckGo.Checked = false;
            }
        }

        private void RadioButtonDuckDuckGo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonDuckDuckGo.Checked == true && !wait)
            {

                if (!duckduckgo_was_checked)
                {
                    Use_DuckDuckGo();
                }
                else if (duckduckgo_was_checked)
                {
                    duckduckgo_was_checked = false;
                }
                else
                {
                    Format_GUI();
                }

            }
        }

        private void Use_DuckDuckGo()
        {
            New_Search_Machine(DUCK_DUCK_GO_STRING);

            RadioButtonCustom.Checked = false;
            RadioButtonGoogle.Checked = false;
        }
    }

}
