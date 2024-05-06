using System;
using System.Drawing.Imaging;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            folderPathToolStripMenuItem.Text = @savePath;
        }
        bool[] enabledImages = { false, false, false, false, false };
        string savePath = "C:\\";
        private void openNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to start a new file?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                textBox1.Text = "";
                richTextBox1.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                imageInteraction();
            }
            if (res == DialogResult.Cancel)
            {
                //Pop up for cancelled
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageInteraction();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string jsonString = "";
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Saves";
            fileOpen.Filter = "Json Files (*.json)| *.json";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                jsonString = File.ReadAllText(fileOpen.FileName);
                File.ReadAllText(fileOpen.FileName);
            }
            fileOpen.Dispose();


            JsonDocument jsonDocument = JsonDocument.Parse(jsonString);

            JsonElement root = jsonDocument.RootElement;
            for (int i = 0; i <= 4; i++)
            {
                enabledImages[i] = false;
            }
            pictureBox2.Enabled = false; pictureBox3.Enabled=false;pictureBox4.Enabled=false;pictureBox5.Enabled = false;
            if (root.GetProperty("Image_1").GetString() != null)
            {
                pictureBox1.Image = Image.FromFile(root.GetProperty("Image_1").GetString());
                pictureBox2.Enabled = true;
            }
            else pictureBox1.Image = null;
            if (root.GetProperty("Image_2").GetString() != null)
            {
                pictureBox2.Image = Image.FromFile(root.GetProperty("Image_2").GetString());
                pictureBox3.Enabled = true;
                enabledImages[0] = true;
            }
            else pictureBox2.Image = null;
            if (root.GetProperty("Image_3").GetString() != null)
            { 
                pictureBox3.Image = Image.FromFile(root.GetProperty("Image_3").GetString());
                pictureBox4.Enabled = true;
                enabledImages[1]=true;
            }
            else pictureBox3.Image = null;
            if (root.GetProperty("Image_4").GetString() != null)
            {
                pictureBox5.Enabled = true;
                pictureBox4.Image = Image.FromFile(root.GetProperty("Image_4").GetString());
                enabledImages[2]=true;
            }               
            else pictureBox4.Image = null;
            if (root.GetProperty("Image_5").GetString() != null)
            {
                pictureBox5.Image = Image.FromFile(root.GetProperty("Image_5").GetString());
                enabledImages[3] = true;
            }               
            else pictureBox5.Image = null;
            textBox1.Text = root.GetProperty("Name").GetString();
            richTextBox1.Text = root.GetProperty("Text").GetString();
            imageInteraction();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void addImage(PictureBox pictureBox, bool imageBool)
        {
            if (imageBool && pictureBox.Image != null && pictureBox.Image != pictureBox6.Image)
            {
                DialogResult dr = MessageBox.Show("Do you want to open the image?", "Open Image", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        using (ImageForm customMessageBox = new ImageForm(pictureBox.Image))
                        {
                            customMessageBox.ShowDialog();
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            if (pictureBox.Image != null && pictureBox.Image != pictureBox6.Image)
            {
                using (DialogWindow dialog = new DialogWindow())
                {
                    DialogResult result = dialog.ShowDialog();

                    // Check the result
                    switch (result)
                    {
                        case DialogResult.Yes:
                            DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (res == DialogResult.OK)
                            {
                                MessageBox.Show("Image Deleted:");
                                pictureBox.Image = null;
                            }
                            break;
                        case DialogResult.No:
                            using (ImageForm customMessageBox = new ImageForm(pictureBox.Image))
                            {
                                customMessageBox.ShowDialog();
                            }
                            break;
                        case DialogResult.Cancel:
                            break;
                        default:
                            MessageBox.Show("Dialog closed without making a selection");
                            break;
                    }



                }
            }
            else
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "Open Image file";
                fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    Image imageP = Image.FromFile(fileOpen.FileName);
                    pictureBox.Image = imageP;
                }
                fileOpen.Dispose();

            }
            imageInteraction();
        }
        void imageInteraction()
        {
            for (int i = 0; i == 0; i++)
            {
                if (pictureBox1.Image == null || pictureBox1.Image == pictureBox6.Image)
                {
                    pictureBox1.Image = pictureBox6.Image;
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = false;
                    pictureBox2.Image = null;
                    enabledImages[0] = false;
                    break;
                }
                if (pictureBox2.Image == null || pictureBox2.Image == pictureBox6.Image)
                {
                    pictureBox2.Enabled = true;
                    pictureBox1.Enabled = true;
                    pictureBox2.Image = pictureBox6.Image;
                    pictureBox3.Enabled = false;
                    pictureBox3.Image = null;
                    enabledImages[0] = false;
                    enabledImages[1] = false;
                    break;
                }
                if (pictureBox3.Image == null || pictureBox3.Image == pictureBox6.Image)
                {
                    pictureBox3.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Image = pictureBox6.Image;
                    pictureBox4.Enabled = false;
                    pictureBox4.Image = null;
                    enabledImages[0] = true;
                    enabledImages[1] = false;

                    break;
                }
                if (pictureBox4.Image == null || pictureBox4.Image == pictureBox6.Image)
                {
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox4.Image = pictureBox6.Image;
                    pictureBox5.Enabled = false;
                    pictureBox5.Image = null;
                    enabledImages[1] = true;
                    enabledImages[2] = false;

                    break;
                }
                if (pictureBox5.Image == null || pictureBox5.Image == pictureBox6.Image)
                {
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox5.Image = pictureBox6.Image;
                    enabledImages[2] = true;
                    enabledImages[3] = false;
                    break;
                }
                enabledImages[3] = true;
                pictureBox4.Enabled = false;
            }
        }
        //void boolList()
        //{
        //    richTextBox1.Text = string.Empty;
        //    for (int i = 0; i <= 4; i++)
        //    {
        //        richTextBox1.Text = richTextBox1.Text + enabledImages[i].ToString();
        //    }
        //}
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addImage(pictureBox1, enabledImages[0]);
            //boolList();
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addImage(pictureBox2, enabledImages[1]); //boolList();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            addImage(pictureBox3, enabledImages[2]); //boolList();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            addImage(pictureBox4, enabledImages[3]); 
               // boolList();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            addImage(pictureBox5, enabledImages[4]); //boolList();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Give the file a name!"); }
            else
            {
                TextWriter tw = new StreamWriter(savePath + textBox1.Text + ".txt");
                // write a line of text to the file
                tw.WriteLine(richTextBox1.Text);
                // close the stream
                tw.Close();
                List<Image> imagesA = new List<Image>();
                int n = 0;
                if (pictureBox1.Image != null && pictureBox1.Image != pictureBox6.Image) { imagesA.Add(pictureBox1.Image); n++; }
                if (pictureBox2.Image != null && pictureBox2.Image != pictureBox6.Image) { imagesA.Add(pictureBox2.Image); n++; }
                if (pictureBox3.Image != null && pictureBox3.Image != pictureBox6.Image) { imagesA.Add(pictureBox3.Image); n++; }
                if (pictureBox4.Image != null && pictureBox4.Image != pictureBox6.Image) { imagesA.Add(pictureBox4.Image); n++; }
                if (pictureBox5.Image != null && pictureBox5.Image != pictureBox6.Image) { imagesA.Add(pictureBox5.Image); n++; }
                string[] imageJson = { null, null, null, null, null };
                for (int i = 1; i <= n; i++)
                {
                    Image imageCopy = imagesA[i - 1];
                    imageCopy.Save((@savePath + textBox1.Text + "_Image" + i + ".jpg"), ImageFormat.Jpeg);
                    imageJson[i - 1] = (savePath + textBox1.Text + "_Image" + i + ".jpg");
                }
                var jsonObject = new
                {
                    Name = textBox1.Text,
                    Text = (richTextBox1.Text),
                    Image_1 = imageJson[0],
                    Image_2 = imageJson[1],
                    Image_3 = imageJson[2],
                    Image_4 = imageJson[3],
                    Image_5 = imageJson[4],
                };
                string jsonString = JsonSerializer.Serialize(jsonObject);

                // Save the JSON string to a file
                File.WriteAllText(savePath + textBox1.Text + ".json", jsonString);
                MessageBox.Show("Files Saved.");
            }
        }

        private void chooseSavePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileOpen = new FolderBrowserDialog();


            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                savePath = fileOpen.SelectedPath;
                folderPathToolStripMenuItem.Text = @savePath;
                savePath = savePath.Replace("\\", "\\\\");
                savePath = savePath + "\\";
                MessageBox.Show("Location changed");

            }
            fileOpen.Dispose();
        }

        private void folderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }

}