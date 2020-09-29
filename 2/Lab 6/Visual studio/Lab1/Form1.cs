using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using System.Threading;

namespace Lab1
{
    public partial class Form1 : Form
    {
        //кнопки
        public class SpecialButton
        {
            public byte status = 0;
            public int step = 0;
            public Button btn = null;
        };

        public tCategories myCategories = new tCategories();

        public SpecialButton[] allbutton = new SpecialButton[5];
        //вибрана панель
        public int Select = 0;
        public int PanelStep = 0;

        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        //зміна кольору кнопок
        void ChangeButton(int num)
        {
            SpecialButton temp = allbutton[num];

            int newvalue;
            if (temp.status == 1)
                newvalue = 255;
            else newvalue = 0;

            int A_value = temp.btn.BackColor.A + (newvalue - temp.btn.BackColor.A) / (30 - temp.step);
            temp.step++;
            if (temp.step >= 30 || temp.step <= 0)
            {
                temp.status = 0;
            }

            temp.btn.BackColor = Color.FromArgb(A_value, temp.btn.BackColor.R, temp.btn.BackColor.G, temp.btn.BackColor.B);
            temp.btn.FlatAppearance.MouseOverBackColor = temp.btn.BackColor;
            temp.btn.FlatAppearance.MouseDownBackColor = temp.btn.BackColor;
        }
        //змінюємо панель
        void ChangeMainPanel()
        {
            if (PanelStep < 1)
            {
                int fposition = -1 * Select * 1366 + 80;
                int newposition = panel_title.Left + (fposition - panel_title.Left) / (1 - PanelStep);
                PanelStep++;
                panel_title.Left = newposition;
                panel_categories.Left = newposition + 1366;
                panel_products.Left = newposition + 2732;
                panel_result.Left = newposition + 4098;
                panel_exit.Left = newposition + 5464;
            }
        }
        //виключити. Процесор не витягує
        void ChangeParalaxPanel()
        {/*
            if (PanelStep < 10)
            {
                int fposition = -1 * Select * 175;
                int newposition = panel_paralax.Left + (fposition - panel_paralax.Left) / (10 - PanelStep);
                panel_paralax.Left = newposition;
            }*/
        }
        //цикл
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
                if (allbutton[i].status != 0)
                    ChangeButton(i);
            ChangeMainPanel();
            ChangeParalaxPanel();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //старт
        private void Form1_Load(object sender, EventArgs e)
        {
            allbutton[0] = new SpecialButton();
            allbutton[1] = new SpecialButton();
            allbutton[2] = new SpecialButton();
            allbutton[3] = new SpecialButton();
            allbutton[4] = new SpecialButton();

            allbutton[0].btn = Button_title;
            allbutton[1].btn = Button_categories;
            allbutton[2].btn = Button_products;
            allbutton[3].btn = Button_result;
            allbutton[4].btn = Button_exit;

            myCategories.Real = listBoxCategories;
            myCategories.RealPr = listBox_Categories_p;
            myCategories.RealRes = listBoxResult;
            myCategories.RealProduct = listBoxProducts;
            myCategories.SetDefault();
        }

        //кнопки
        private void Button_title_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 0;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void Button_categories_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 1;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void Button_products_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 2;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void Button_result_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 3;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Next1_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 1;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Next2_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 2;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            if (TextBoxCategories.Text != "" && myCategories.Search(TextBoxCategories.Text) == -1)
                myCategories.Add(TextBoxCategories.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCategories.AddDefault();
        }



        private void TextBoxCategories_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex >= 0 && listBoxCategories.SelectedIndex < myCategories.count)
                TextBoxCategories.Text = myCategories.catg[listBoxCategories.SelectedIndex].name;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            myCategories.Delete(listBoxCategories.SelectedIndex);
        }

        private void Next3_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 3;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void listBox_Categories_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCategories.selected = listBox_Categories_p.SelectedIndex;
            myCategories.select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_pro.Text != "" && myCategories.ProSearch(textBox_pro.Text) == -1)
                myCategories.ProAdd(textBox_pro.Text);
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        { textBox_pro.Text = myCategories.catg[myCategories.selected].pro[listBoxProducts.SelectedIndex].name;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                string res = "";
                for (int j = 0; j <= 8; j++)
                    res += Encoding.ASCII.GetString(new byte[] { (byte)rand.Next(48, 122) });
                myCategories.ProAdd(res);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCategories.ProDelete(listBoxProducts.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //графіка
        Graphics gs;
        //рисуємо вершини
        public void GetAllNode(int height_y, int left, BPlusTree.BTreeNode<String> now, int last_x, int last_y)
        {
            BPlusTree.BTreeNodeElement<String> temp = now.FirstElement;
            SolidBrush mySolidBrush = new SolidBrush(Color.FromArgb(226,64,83));
            Pen myPen = new Pen(Color.FromArgb(38, 50, 56));
            SolidBrush br2 = new SolidBrush(Color.FromArgb(55, 71, 79));
            Console.WriteLine("#+ "+ height_y + " new _ go nahui      ");

            int count_cnt = now.Count;
            int cnt = 0;
            int zero_x = (int)(left * pictureBoxRes.Width / Math.Pow((int)numericUpDown_p.Value, height_y) + pictureBoxRes.Width / Math.Pow((int)numericUpDown_p.Value, height_y) / 2);

            if(now.Count != 0 && last_y != 0 && zero_x < pictureBoxRes.Width)
            gs.DrawLine(myPen, last_x, last_y + 20, zero_x + (count_cnt / 2) * 37, height_y * 100 + 40);
            gs.DrawRectangle(myPen, zero_x - 10, height_y * 100 + 40, count_cnt * 37, 35);
            gs.FillRectangle(br2, zero_x - 10, height_y * 100 + 40, count_cnt * 37, 35);
            while (temp != null)
            {
                Console.WriteLine("ok lets go " + temp.value);
                int pos_x = (int)(left * pictureBoxRes.Width / Math.Pow((int)numericUpDown_p.Value,height_y) + pictureBoxRes.Width / Math.Pow((int)numericUpDown_p.Value, height_y)/2);
                gs.DrawString(temp.value, panel_result.Font, mySolidBrush, pos_x + cnt*37, height_y*100 + 55);
                temp = temp.Next;
                cnt++;
            }

            BPlusTree.BTreeNodeElementInterstice<String> sw = now.FirstInterstice;
            int count = 0;
            while (sw != null)
            {
                GetAllNode(height_y + 1, count + left * (int)numericUpDown_p.Value, sw.NodePointer, zero_x + (count_cnt / 2) * 40, height_y * 100 + 55);
                sw = sw.Next;
                count++;
            }
        }

        //таблиця результатів
        public void DrawTable()
        {
            Bitmap bitmap = new Bitmap(pictureBoxRes.Width, pictureBoxRes.Height);
            gs = Graphics.FromImage(bitmap);
            gs.Clear(Color.FromArgb(200,200,200));
            SolidBrush mySolidBrush = new SolidBrush(Color.Red);
            var tp = new BPlusTree.BTree<String>((int)numericUpDown_p.Value);
            for (int i = 0; i < myCategories.catg[listBoxResult.SelectedIndex].count; i++)
                tp.Insert(myCategories.catg[listBoxResult.SelectedIndex].pro[i].id.ToString());
            Console.WriteLine(tp.ToString());
            GetAllNode(0,0,tp.root,0,0);

            pictureBoxRes.Image = bitmap;
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        DrawTable();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedIndex >= 0 && listBoxResult.SelectedIndex < myCategories.count)
                DrawTable();
        }

        private void Next4_Click(object sender, EventArgs e)
        {
            allbutton[Select].status = 2;
            allbutton[Select].step = 0;
            Select = 4;
            PanelStep = 0;
            allbutton[Select].status = 1;
            allbutton[Select].step = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_pro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
