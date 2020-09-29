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

        public class SpecialButton
        {
            public byte status = 0;
            public int step = 0;
            public Button btn = null;
        };

        public tCategories myCategories = new tCategories();

        public SpecialButton[] allbutton = new SpecialButton[5];
        //
        public int Select = 0;
        public int PanelStep = 0;

        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        void ChangeButton(int num)
        {
            SpecialButton temp = allbutton[num];

            int newvalue;
            if (temp.status == 1)
                newvalue = 255;
            else newvalue = 0;

            int A_value = temp.btn.BackColor.A + (newvalue - temp.btn.BackColor.A) / (30 - temp.step);
            temp.step++;
            if (temp.step>=30 || temp.step <= 0)
            {
                temp.status = 0;
            }
            
            temp.btn.BackColor = Color.FromArgb(A_value, temp.btn.BackColor.R, temp.btn.BackColor.G, temp.btn.BackColor.B);
            temp.btn.FlatAppearance.MouseOverBackColor = temp.btn.BackColor;
            temp.btn.FlatAppearance.MouseDownBackColor = temp.btn.BackColor;
        }

        void ChangeMainPanel()
        {
            if (PanelStep < 10)
            {
                int fposition = -1 * Select * 800 + 80;
                int newposition = panel_title.Left + (fposition - panel_title.Left) / (10 - PanelStep);
                PanelStep++;
                panel_title.Left = newposition;
                panel_categories.Left = newposition + 800;
                panel_products.Left = newposition + 1600;
                panel_result.Left = newposition + 2400;
                panel_exit.Left = newposition + 3200;
            }
        }

        void ChangeParalaxPanel()
        {
            if (PanelStep < 10)
            {
                int fposition = -1 * Select * 100;
                int newposition = panel_paralax.Left + (fposition - panel_paralax.Left) / (10 - PanelStep);
                panel_paralax.Left = newposition;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i <= 4; i++ )
                if(allbutton[i].status!=0)
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
            if(TextBoxCategories.Text!="" && myCategories.Search(TextBoxCategories.Text) == -1)
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
            if(listBoxCategories.SelectedIndex >= 0 && listBoxCategories.SelectedIndex < myCategories.count)
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
        {textBox_pro.Text = myCategories.catg[myCategories.selected].pro[listBoxProducts.SelectedIndex].name;
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

        public void DrawTable()
        {            
            Algorithm algo = new Algorithm();
            algo.Real = TableAbsolute;
            algo.mn_a = (int)numericUpDown_a.Value;
            algo.mn_b = (int)numericUpDown_b.Value;
            if (checkBox_x.CheckState == CheckState.Checked)
                algo.mn_m = myCategories.catg[listBoxResult.SelectedIndex].count;
            else
                algo.mn_m = (int)numericUpDown_m.Value;
            algo.mn_p = (int)numericUpDown_p.Value;


            algo.enterdata = new int[1000];
            algo.mn_n = myCategories.catg[listBoxResult.SelectedIndex].count;
            for (int i = 0; i < myCategories.catg[listBoxResult.SelectedIndex].count; i++)
                algo.enterdata[i] = myCategories.catg[listBoxResult.SelectedIndex].pro[i].id;

            algo.Result();
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
    }
}
