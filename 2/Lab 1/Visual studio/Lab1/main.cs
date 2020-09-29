using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{   
    public class Product
    {
        public string name;
        public int id = 0;
    }

    public class market
    {
        public string name;
        public int count = 0;
        public Product[] pro = new Product[1000];
    }

    public class tCategories
    {
        public int count = 0;
        public market[] catg = new market[100];
        
        public ListBox Real;
        public ListBox RealPr;
        public ListBox RealRes;
        public ListBox RealProduct;

        public string[] defaultname = new string[100];
        
        public int countemp = 6;
        public int selected = -1;



        public int Search(string now)
        {
            int res = -1;
            for (int i = 0; i < count; i++)
                if (catg[i].name == now)
                    res = i;
            return res;
        }
        public void Add(string now)
        {
            if (count < 100)
            {
                catg[count] = new market();
                for (int i = 0; i < 1000; i++)
                    catg[count].pro[i] = new Product();

                catg[count].name = now;
                Real.Items.Add(now);
                RealPr.Items.Add(now);
                RealRes.Items.Add(now);
                Real.SelectedIndex = count;
                int visibleItems = Real.ClientSize.Height / Real.ItemHeight;
                Real.TopIndex = Math.Max(Real.Items.Count - visibleItems, 0);
                count++;
            };
        }
        public void SetDefault()
        {
            defaultname[0] = "Напої";
            defaultname[1] = "Хлібобулочні, кондитерські вироби";
            defaultname[2] = "Риба та морепродукти";
            defaultname[3] = "Молочні продукти";
            defaultname[4] = "Овочі, фрукти, ягоди, гриби";
            defaultname[5] = "М'ясо та м'ясна продукція";
            defaultname[6] = "Заморожені напівфабрикати";
        }
        public void AddDefault()
        {
            for(int i = 0; i <= countemp; i++)
            {
                if (Search(defaultname[i]) == -1)
                    Add(defaultname[i]);
            }
        }
        public void Delete(int num)
        {
            catg[count] = new market();
            if (num >= 0 && num < count)
            {
                for (int i = num; i < count; i++)
                    catg[i] = catg[i + 1];
                count--;
                Real.Items.Clear();
                RealPr.Items.Clear();
                RealRes.Items.Clear();
                for (int i = 0; i < count; i++)
                {
                    Real.Items.Add(catg[i].name);
                    RealPr.Items.Add(catg[i].name);
                    RealRes.Items.Add(catg[i].name);
                }
            }
        }



        public int ProSearch(string now)
        {
            int res = -1;
            for (int i = 0; i < catg[selected].count; i++)
                if (catg[selected].pro[i].name == now)
                    res = i;
            return res;
        }

        private int GiveId(int index)
        {
            int res = -1;
            bool t = true;
            Random rand = new Random();
            while(t)
            {
                t = false;
                res = 1000 + rand.Next(0, 8999);
                for (int i = 0; i <= catg[index].count; i++)
                    if (catg[index].pro[i].id == res)
                        t = true;
            };
            return res;
        }

        public void ProAdd(string now)
        {
            if (selected >=0 && selected < count && catg[selected].count < 1000)
            {
                catg[selected].pro[catg[selected].count].name = now;
                catg[selected].pro[catg[selected].count].id = GiveId(selected);

                RealProduct.Items.Add("id" + catg[selected].pro[catg[selected].count].id.ToString() + "   " + catg[selected].pro[catg[selected].count].name);

                RealProduct.SelectedIndex = catg[selected].count;
                int visibleItems = RealProduct.ClientSize.Height / RealProduct.ItemHeight;
                RealProduct.TopIndex = Math.Max(RealProduct.Items.Count - visibleItems, 0);
                catg[selected].count++;
            }
        }
        public void select()
        {
            RealProduct.Items.Clear();
            for(int i = 0; i< catg[selected].count; i++)
                RealProduct.Items.Add("id" + catg[selected].pro[i].id.ToString() + "   " + catg[selected].pro[i].name);
        }
        public void ProDelete(int num)
        {
            if (selected >= 0 && selected < count)
            {
                catg[selected].pro[catg[selected].count] = new Product();
                if (num >= 0 && num < catg[selected].count)
                {
                    for (int i = num; i < catg[selected].count; i++)
                        catg[selected].pro[i] = catg[selected].pro[i + 1];
                    catg[selected].count--;
                    RealProduct.Items.Clear();

                    for (int i = 0; i < catg[selected].count; i++)
                    {
                        RealProduct.Items.Add("id" + catg[selected].pro[i].id.ToString() + "   " + catg[selected].pro[i].name);
                    };
                }
            }
        }




    }


    class main
    {
    }

}
