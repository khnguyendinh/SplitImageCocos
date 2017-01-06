using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace MultiSprite
{
    public partial class Form1 : Form
    {
        //đường dẫn file 
        String input, output;
        Image image;
        int Count_PNG;
        Itemsssss[] items ;
        //string bb;
        int[] tdX, tdY;
        int[] wh, hg;
        int[] offsetX, offsetY;
        bool[] rotated;
        /// <summary>
        ///tên từng cái ảnh trước khi cắt
        /// 
        /// </summary>
        string[] name_img;
        string folder_outPut;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            DialogResult result = open1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = open1.FileName;
                try
                {
                    string text = open1.FileName;
                    txtInput.Text = open1.FileName;
                    image = Image.FromFile(text);
                    pictureBox1.Image = image;
                }
                catch (IOException)
                {
                }
            }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutPut.Text = fbd.SelectedPath;
            }

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            int rows = 2;//No of Rows as per Desire
            int columns = 2;//No of columns as per Desire
            Image[] imgarray1 = new Image[Count_PNG];//Create Image Array of Size Rows X Colums
            Image img = image;//Get Image from anywhere, From File Or Using Dialogbox used previously

            int height = img.Height;
            int width = img.Width;//Get image Height & Width of Input Image
            //int one_img_h = height / rows;
            //int one_img_w = width / columns;//You need Rows x Columns, So get 1/rows Height, 1/columns width of original Image
            int one_img_h = 200;
            int one_img_w = 200;//You need Rows x Columns, So get 1/rows Height, 1/columns width of original Image
            for (int j = 0; j < Count_PNG; j++)
            {
                //Console.WriteLine("w = " + wh[j] + " h = " + hg[j]);
                if (rotated[j])
                {
                    imgarray1[j] = new Bitmap(hg[j], wh[j]);//generating new bitmap
                    Graphics graphics = Graphics.FromImage(imgarray1[j]);
                    graphics.DrawImage(img, new Rectangle(0, 0, hg[j], wh[j]), new Rectangle(tdX[j] + offsetX[j], tdY[j] + offsetY[j], hg[j], wh[j]), GraphicsUnit.Pixel);//Generating Splitted Pieces of Image
                    graphics.Dispose();
                }
                else
                {
                    imgarray1[j] = new Bitmap(wh[j], hg[j]);//generating new bitmap
                    Graphics graphics = Graphics.FromImage(imgarray1[j]);
                    graphics.DrawImage(img, new Rectangle(0, 0, wh[j], hg[j]), new Rectangle(tdX[j]+offsetX[j], tdY[j] + offsetY[j], wh[j], hg[j]), GraphicsUnit.Pixel);//Generating Splitted Pieces of Image
                    graphics.Dispose();
                }
                
            }
            //Image Is spitted You can use it by getting image from **imgarray[Rows, Columns]**
            //Or You can Save it by using Following Code

            String destinationFolderName="";
            if (txtOutPut.Text != "")
            {
                 destinationFolderName = txtOutPut.Text;//Define a saving path
            }else{
                //Console.WriteLine("folder1 " + txtInput.Text);
                //Console.WriteLine("folder2 " + folder_outPut);
                destinationFolderName = folder_outPut+"/"+"in";
                if (!Directory.Exists(destinationFolderName))
                Directory.CreateDirectory(destinationFolderName);
                txtOutPut.Text = destinationFolderName;
            }
            //FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            for (int j = 0; j < Count_PNG; j++)
            {
                //Console.WriteLine("save " + destinationFolderName + "/" + name_img[j]);
                imgarray1[j].Save(@"" + destinationFolderName + "/" + name_img[j] );//Save every image in Array [row][column] on local Path
            }
        }

        private void btnInputAtlas_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            DialogResult result = open1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = open1.FileName;
                try
                {
                    string text = open1.FileName;
                    txtInputAtlas.Text = open1.FileName;
                    string[] lines = System.IO.File.ReadAllLines(txtInputAtlas.Text);
                    input = System.IO.Path.GetDirectoryName(open1.FileName);
                    Count_PNG = (lines.Length - 16) / 13;
                    items = new Itemsssss[Count_PNG];
                    tdX = new int[Count_PNG];
                    tdY = new int[Count_PNG];
                    wh = new int[Count_PNG];
                    hg = new int[Count_PNG];
                    offsetX = new int[Count_PNG];
                    offsetY = new int[Count_PNG];
                    rotated = new bool[Count_PNG];
                    name_img = new string[Count_PNG];
                    folder_outPut = Path.GetDirectoryName(open1.FileName); ;
                    Console.WriteLine("path " + folder_outPut);
                    txtInput.Text = txtInputAtlas.Text.Replace("txt","png");
                    image = Image.FromFile(txtInput.Text);
                    pictureBox1.Image = image;
                    for (int i = 6; i < lines.Length-16; i += 13)
                    {
                        int index = (i - 6) / 13;
                        name_img[index] = getNameImg(RemoveWhiteSpace(lines[i]));
                        tdX[index] = Int32.Parse(getToadoX(lines[i + 3],0));
                        tdY[index] = Int32.Parse(getToadoX(lines[i + 3],1));
                        wh[index] = Int32.Parse(getToadoX(lines[i + 3], 2));
                        hg[index] = Int32.Parse(getToadoX(lines[i + 3], 3));
                        offsetX[index] = Int32.Parse(getToadoX(lines[i + 5], 0));
                        offsetY[index] = Int32.Parse(getToadoX(lines[i + 5], 1));
                        rotated[index] = getRotated(lines[i + 7]);
                        //Console.WriteLine("t " + lines[i + 3]);

                        Console.WriteLine("tdx = "+ tdX[index]+" tdy = "+ tdY[index]+
                            "wh = " + wh[index] + " hg = " + hg[index]);

                    }
                }
                catch (IOException)
                {
                }
            }
        }

        private bool getRotated(string str)
        {
            str.Trim();
            //string[] word = str.Split(' ');
            //return ((str.Trim()).Split(' '))[0].Trim(',');
            string nameFile = str.Replace("<", "").Replace("/>", "");
            return Boolean.Parse(nameFile);
        }

        /// <summary>
        /// đếm số file ảnh png có trong out
        /// </summary>
        public void CountFileImage()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    MessageBox.Show("have " + Count_PNG + " PNG  in atlas"); 

        }
        public string getToadoX(string str,int index)
        {
            //Match match = Regex.Match(str, @"(\d+)");
            List<long> numbers = Numbers(str);
            // if (numbers.Count <= (index-1))
            //{
                Console.WriteLine("getToadoX " + numbers[index]);
                  return numbers[index]+"";

            //}
            //else {
            //    Console.WriteLine("errror");
            //    return "0";
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string getToadoY(string str)
        {
            Match match = Regex.Match(str, @"(\d+)");
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else return "0";
        }
             
         public string getNameImg(string str)
        {
            str.Trim();
            //string[] word = str.Split(' ');
            //return ((str.Trim()).Split(' '))[0].Trim(',');
            string nameFile = str.Replace("<key>", "").Replace("</key>", "");
            return nameFile;

        }

         private void button1_Click_1(object sender, EventArgs e)
         {
             if (!txtOutPut.Equals(""))
             {
                 txtOutPut.Text = "";
             }
         }

        public static string RemoveWhiteSpace(string self)
        {
            return new string(self.Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }
        public static List<long> Numbers(string str)
        {
            var nums = new List<long>();
            var start = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (start < 0 && Char.IsDigit(str[i]))
                {
                    start = i;
                }
                else if (start >= 0 && !Char.IsDigit(str[i]))
                {
                    nums.Add(long.Parse(str.Substring(start, i - start)));
                    start = -1;
                }
            }
            if (start >= 0)
                nums.Add(long.Parse(str.Substring(start, str.Length - start)));
            return nums;
        }
    }
}
