
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    //продукт
    public class Product
    {
        public string name;
        public int id = 0;
    }
    //набір продуктів
    public class market
    {
        public string name;
        public int count = 0;
        public Product[] pro = new Product[10000];
    }

    public class tCategories
    {
        public int count = 0;
        public market[] catg = new market[100];
        //компоненти на формі
        public ListBox Real;
        public ListBox RealPr;
        public ListBox RealRes;
        public ListBox RealProduct;

        public string[] defaultname = new string[100];
        //змінні
        public int countemp = 6;
        public int selected = -1;

        public const int max_count = 10000;
        //пошук значення на всій множині
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
                for (int i = 0; i < max_count; i++)
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

        //стандартні ітеми
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
        //стандарт
        public void AddDefault()
        {
            for(int i = 0; i <= countemp; i++)
            {
                if (Search(defaultname[i]) == -1)
                    Add(defaultname[i]);
            }
        }

        //видвлення
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


        //пошук
        public int ProSearch(string now)
        {
            int res = -1;
            for (int i = 0; i < catg[selected].count; i++)
                if (catg[selected].pro[i].name == now)
                    res = i;
            return res;
        }
        //отримання випадкового ід
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
        //додавання
        public void ProAdd(string now)
        {
            if (selected >=0 && selected < count && catg[selected].count < max_count)
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
        //вибір елементу
        public void select()
        {
            RealProduct.Items.Clear();
            for(int i = 0; i< catg[selected].count; i++)
                RealProduct.Items.Add("id" + catg[selected].pro[i].id.ToString() + "   " + catg[selected].pro[i].name);
        }
        //видалення
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
