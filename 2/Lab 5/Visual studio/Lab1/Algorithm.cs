using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Algorithm
    {
        public const int max_count = 10000;

        public int intmax = 1; //max number of colums
        public Random rand = new Random();
        public int[] enterdata = new int[max_count];

        public DataGridView Real;

        public int mn_a = 10;
        public int mn_b = 11;
        public int mn_m = 22;
        public int mn_p = 10007;
        public int mn_n = -1;



        public int Hash(int k, int a, int b, int p, int m)
        {
            return ((a * k + b) % p) % m;
        }

        public class templevel //struct of temp keys
        {
            public int count = 0;
            public  int[] data = new int[max_count]; //array
        }
        public class secondlevel  //secondary hash table
        {
            public  int[] data = new int[max_count]; //array
            public  int a = 0;
            public  int b = 0;
            public  int m = 1;
        };

        secondlevel[] GetSecond(templevel[] keys, int m, int p)
        {
            secondlevel[] res = new secondlevel[m];
            for (int i = 0; i < m; i++)
            {
                res[i] = new secondlevel();
                for (int w = 0; w < m; w++)
                    res[i].data[w] = -1;
            };

            for (int i = 0; i < m; i++)
            {
                if (keys[i].count > 1)
                {
                    int mj = keys[i].count * keys[i].count;
                    res[i].m = mj;

                    if (mj > intmax)
                        intmax = mj;

                    bool nocollisions = false; //if a collision has been found then restart
                    int n = 0; //index
                    int hashj; //hash of 2 level

                    do
                    {
   
                        if (nocollisions)
                        {
                            hashj = Hash(keys[i].data[n], res[i].a, res[i].b, p, res[i].m);
                            Console.WriteLine(res[i].data[hashj]);
                            if (res[i].data[hashj] == -1) //checking collision
                            {
                                res[i].data[hashj] = keys[i].data[n];
                                n++;
                            }
                            else
                                nocollisions = false;
                        }
                        if (nocollisions == false) //restart
                        {
                            n = 0;
                            res[i].data = new int[mj];
                            for (int w = 0; w < mj; w++)
                                res[i].data[w] = -1;
                            res[i].a = rand.Next(p) + 1;
                            res[i].b = rand.Next(p) + 1;
                            nocollisions = true;
                        };
                    } while (nocollisions && n < keys[i].count);

                };
                //if element only one than ... 
                if (keys[i].count == 1)
                {
                    res[i].data = new int[1];
                    res[i].data[0] = keys[i].data[0];
                }
            };
            return res;
        }


        templevel[] SortKeys(int[] nowkey, int n, int a, int b, int p, int m)
        {
            templevel[] res = new templevel[m];
            for (int i = 0; i < m; i++)
            {
                res[i] = new templevel();
            };

                int hashnow;
            //count of keys in the line
            int[] max = new int[m];
            for (int i = 0; i < m; i++)
                max[i] = 0;
            for (int i = 0; i < n; i++)
                max[Hash(nowkey[i], a, b, p, m)]++;
            //sorting
            for (int i = 0; i < n; i++)
            {
                hashnow = Hash(nowkey[i], a, b, p, m);
                if (res[hashnow].count == 0)
                    res[hashnow].data = new int[max[hashnow]];
                res[hashnow].data[res[hashnow].count] = nowkey[i];
                res[hashnow].count++;
            };
            return res;
        }

        public void Result()
        {
            Console.WriteLine("Start all");
            templevel[] tempkeys = SortKeys(enterdata, mn_n, mn_a, mn_b, mn_p, mn_m);
            secondlevel[] firstlevel = GetSecond(tempkeys, mn_m, mn_p);


            //table

            Real.Columns.Clear();
            Real.Rows.Clear();

            Real.Columns.Add("first_hash", "#");
            Real.Columns.Add("M", "m");
            Real.Columns.Add("A", "a");
            Real.Columns.Add("B", "b");

            for(int i = 0; i<= intmax; i++)
                Real.Columns.Add(i.ToString(),"#"+ i.ToString());

            DataGridViewCell onehash;
            DataGridViewCell one_a;
            DataGridViewCell one_b;
            DataGridViewCell one_m;
            DataGridViewCell[] temp;
            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i< mn_m; i++)
            {
                onehash = new DataGridViewTextBoxCell();
                onehash.Style.BackColor = System.Drawing.Color.Gray;
                one_a = new DataGridViewTextBoxCell();               
                one_b = new DataGridViewTextBoxCell();             
                one_m = new DataGridViewTextBoxCell();               
                temp = new DataGridViewTextBoxCell[intmax];
                row = new DataGridViewRow();

                onehash.Value = (i + 1).ToString();

                if (firstlevel[i].data.Length >= 0 && firstlevel[i].data.Length <= intmax)
                {
                    one_a.Style.BackColor = System.Drawing.Color.Orange;
                    one_b.Style.BackColor = System.Drawing.Color.Orange;
                    one_m.Style.BackColor = System.Drawing.Color.Orange;

                    one_a.Value = firstlevel[i].a;
                    one_b.Value = firstlevel[i].b;
                    one_m.Value = firstlevel[i].m;
                }
                else
                {
                    one_a.Value = "-";
                    one_b.Value = "-";
                    one_m.Value = "-";
                }



                row.Cells.AddRange(onehash, one_a, one_b, one_m);


                for (int j = 0; j < intmax; j++)
                {
                    temp[j] = new DataGridViewTextBoxCell();
                    if (j < max_count && firstlevel[i].data.Length > j && firstlevel[i].data[j] > 0)
                    {
                        temp[j].Value = firstlevel[i].data[j].ToString();
                        temp[j].Style.BackColor = System.Drawing.Color.Green;
                    }
                    else
                        temp[j].Value = "";
                    row.Cells.AddRange(temp[j]);
                }

                Real.Rows.Add(row);
            }
        }

    }
}
