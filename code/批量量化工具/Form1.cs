using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace 批量量化工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }



        private void convertToArray(Bitmap bitmap, int num)
        {
            int width = bitmap.Width;
            int high = bitmap.Height;
            string newString = "";
            int pixel = 0;
            Byte ch = 0;
            List<Byte> byteList = new List<byte>();

            if (threshold.Text == null)
            {
                MessageBox.Show("请先选择图片", "!");
                return;
            }

            for (int page = 0; page < 8; page++)
            {
                for (int i = 0; i < 128; i++)
                {
                    for (int j = page * 8; j < page * 8 + 8; j++)
                    {
                        Color color = bitmap.GetPixel(i, j);

                        if (reverse.Checked)
                        {
                            if ((color.R + color.G + color.B) < Convert.ToInt32(threshold.Text))
                            {
                                pixel = 0;
                            }
                            else
                            {
                                pixel = 1;
                            }
                        }
                        else
                        {
                            if ((color.R + color.G + color.B) > Convert.ToInt32(threshold.Text))
                            {
                                pixel = 0;
                            }
                            else
                            {
                                pixel = 1;
                            }

                        }
                        if (j % 8 == 0)
                        {

                            newString += "0x"+ch.ToString("X2") + ",";
                            ch = 0;
                        }
                        if (pixel == 1)
                        {
                            ch |= (Byte)(1 << (j % 8));
                        }
                    }
                }
              
            }

            data.Text += newString;
            newString = Convert.ToString(num);
            data.Text += "//\npicture" + newString + "\n";
          

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public int flag = 0;
        public bool exit = false;
        public  void CallToChildThread()
        {
            //MessageBox.Show("test");
            status.Text = "test" + Convert.ToString(flag);
 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            MessageBox.Show("test");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filenames = openFileDialog.FileNames;
                for (int i = 0; i < filenames.Length; i++)
                {
                    pictureBox1.Image = Image.FromFile(filenames[i]);
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    // status.Text = "正在处理第"+Convert.ToString(i+1)+"个  共"+ Convert.ToString(filenames.Length)+"个";
                    convertToArray(bitmap, i + 1);
                
                }
                // status.Text = "finished!";
            }

            MessageBox.Show("test");
            exit = true;
        
            ///////////////////////////////////////


        }

        public void CallToChildThread2()
        {
            int i = 0;
            status.Text = "已建立" + Convert.ToString(flag);
            while (exit == false)
            {
                status.Text = "已建立" + Convert.ToString(flag);
                if (flag == 0)
                {
                    if (flag == 1)
                    {
                        status.Text = "正在处理第" + Convert.ToString(++i) + "个 ";
                    }
                }
            }
        }

        private void select_Click(object sender, EventArgs e)
        {

            ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childThread = new Thread(childref);
            childThread.Start();

            ThreadStart childref2 = new ThreadStart(CallToChildThread2);
            Thread childThread2 = new Thread(childref2);
            childThread2.Start();


           if(reverse.Checked)
            {
                childThread.Abort();
                childThread2.Abort();

            }
            childThread.Join();
            //childThread2.Join();


            //childThread.Abort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void threshold_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            data.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
