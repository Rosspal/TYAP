using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoganL4_test1
{
    public partial class Form1 : Form
    {
        int TVn = 0;

        public TreeNode treeNode = new TreeNode();

        public Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Dictionary<string, string> IDlist = new Dictionary<string, string>();
        public struct LeksemItem
        {
            public string name;
            public string type;
            public string value;
            public int index;
        }
        public List<LeksemItem> LT = new List<LeksemItem>();

        public LeksemItem[,] SyntTable = new LeksemItem[1000,1000];

        public Form1()
        {
            InitializeComponent();
            createDictionary();
        }

        public void createDictionary()
        {
            dictionary.Add("begin", "Ключевое слово"); dictionary.Add("Begin", "Ключевое слово");
            dictionary.Add("end", "Ключевое слово"); dictionary.Add("End", "Ключевое слово");
            dictionary.Add("for", "Ключевое слово"); dictionary.Add("For", "Ключевое слово");            
            dictionary.Add("to", "Ключевое слово"); dictionary.Add("To", "Ключевое слово");
            dictionary.Add("do", "Ключевое слово"); dictionary.Add("Do", "Ключевое слово");
            dictionary.Add("while", "Ключевое слово"); dictionary.Add("While", "Ключевое слово");
            dictionary.Add(":=", "Знак присваивания");
            dictionary.Add("*", "Знак арифметической операции");
            dictionary.Add("+", "Знак арифметической операции");
            dictionary.Add("-", "Знак арифметической операции");
            dictionary.Add("<", "Знаки сравнения");
            dictionary.Add("<=", "Знаки сравнения");
            dictionary.Add(">", "Знаки сравнения");
            dictionary.Add(">=", "Знаки сравнения");
            dictionary.Add("=", "Знаки сравнения");
            dictionary.Add(";", "Точка с запятой");
            dictionary.Add("(", "Круглая скобка");
            dictionary.Add(")", "Круглая скобка");
        }

        public void ScanCode(TextBox tbx)
        {
            LT.Clear();
            char[] delimiterChars = { ' ', };
            bool PrisvaivanieBezProbela = true;

            foreach (string line in tbx.Lines)
            {
                string[] words = line.Split(delimiterChars);
                foreach (string word in words)
                {
                    PrisvaivanieBezProbela = false;

                    if (word != "")
                    {                        
                        if (word.Contains(":=")&&(word[0]!=':'))
                        {
                            int PT = 0;
                            PrisvaivanieBezProbela = true;
                            string TW = "";

                            TW = word.Replace(":=", " ");
                            string[] TWs = TW.Split(' ');

                            foreach (string TW1 in TWs)
                            {
                                LeksemItem LI1 = new LeksemItem();
                                LI1.name = TW1;                                
                                LT.Add(LI1);                                
                                
                                PT++;
                                if(PT==1)
                                {
                                    LeksemItem LI2 = new LeksemItem();
                                    LI2.name = ":=";
                                    LT.Add(LI2);
                                }
                            }
                        }
                        if (PrisvaivanieBezProbela == false)
                        {
                            //bool TochkaSzapyatoi = false;
                            string tempWord = "";
                            if (word.Contains(";"))
                            {
                                //TochkaSzapyatoi = true;
                                tempWord = word.Replace(";", "");
                                LeksemItem LI1 = new LeksemItem();
                                LI1.name = tempWord;
                                LT.Add(LI1);

                                LeksemItem LI2 = new LeksemItem();
                                LI2.name = ";";
                                LT.Add(LI2);
                            }
                            else
                            {
                                LeksemItem LI = new LeksemItem();
                                LI.name = word;
                                LT.Add(LI);
                            }
                        }
                    }
                }
            }
            setTypeAndValue();
            printTable(dataGridView1);
        }

        public void setTypeAndValue()
        {
            int keywords = 0;
            int identificator = 0;
            Regex regex = new Regex("[0-9]");
            Regex regex_ABC = new Regex("[A-Z]");
            Regex regex_abc = new Regex("[a-z]");
            //bool ID_manyTimes = false;

            for (int i = 0; i < LT.Count; i++)
            {
                //ID_manyTimes = false;
                if (dictionary.ContainsKey(LT[i].name))
                {
                    LeksemItem LI = new LeksemItem();
                    LI.name = LT[i].name;
                    LI.type = dictionary[LT[i].name];

                    if(LI.type=="Ключевое слово")
                    {
                        keywords++;
                        LI.value = "X" + keywords;
                    }
                    else
                    if(LI.type == "Знак присваивания")
                    {
                        LI.value = "";
                    }
                    LT[i] = LI;
                }
                else
                if (LT[i].name.Contains("."))
                {
                    LeksemItem LI = new LeksemItem();
                    LI.name = LT[i].name;
                    LI.type = "Вещественная константа";
                    LI.value = LI.name;
                    LT[i] = LI;
                }
                else
                
                if (regex.IsMatch(LT[i].name[0].ToString()))
                {
                    if (regex_ABC.IsMatch(LT[i].name) || regex_abc.IsMatch(LT[i].name))
                    {
                        LeksemItem LI = new LeksemItem();
                        LI.name = LT[i].name;
                        LI.type = "Шестнадцатеричная константа";
                        LI.value = LI.name;
                        LT[i] = LI;
                    }
                    else
                    {
                        LeksemItem LI = new LeksemItem();
                        LI.name = LT[i].name;
                        LI.type = "Целочисленная константа";
                        LI.value = LI.name;
                        LT[i] = LI;
                    }
                }
                else
                {
                    LeksemItem LI = new LeksemItem();
                    LI.name = LT[i].name;
                    LI.type = "Идентификатор";

                    if (!IDlist.ContainsKey(LT[i].name))
                    {
                        identificator++;
                        LI.value = LI.name + ":" + identificator;
                        LT[i] = LI;
                        IDlist.Add(LI.name, LI.value);
                    }
                    else
                    {
                        LI.value = IDlist[LI.name];
                        LI.type = "Идентификатор";
                        LT[i] = LI;
                    }
                }
            }
        }

        public void printTable(DataGridView DGV)
        {
            DGV.Rows.Clear();

            DGV.Rows.Add(LT.Count);

            for(int i = 0; i < LT.Count; i++)
            {
                DGV[0, i].Value = LT[i].name;
                DGV[1, i].Value = LT[i].type;
                DGV[2, i].Value = LT[i].value;
            }
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            tbx_Code.Clear();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string name = Path.GetFileName(openFileDialog.FileName);
                    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            tbx_Code.Text += line + "\r\n";

                            label_FileName.Text = "Файл: " + name;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            ScanCode(tbx_Code);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TVn++;

            if (TVn == 0)
            {
                treeView1.Location = new Point(806, 123);
                treeView2.Visible = false;
                treeView3.Visible = false;
                treeView4.Visible = false;
                treeView5.Visible = false;
            }
            else
            if (TVn == 1)
            {
                treeView1.Visible = false;
                treeView3.Visible = false;
                treeView4.Visible = false;
                treeView5.Visible = false;
                treeView2.Visible = true;
                treeView2.Location = new Point(806, 123);
                treeView2.Size = new Size(411, 428);
                treeView2.ExpandAll();
            }
            else
            if (TVn == 2)
            {
                treeView1.Visible = false;
                treeView2.Visible = false;
                treeView4.Visible = false;
                treeView5.Visible = false;
                treeView3.Visible = true;
                treeView3.Location = new Point(806, 123);
                treeView3.Size = new Size(411, 428);
                treeView3.ExpandAll();
            }
            else
            if (TVn == 3)
            {
                treeView1.Visible = false;
                treeView2.Visible = false;
                treeView3.Visible = false;
                treeView5.Visible = false;
                treeView4.Visible = true;
                treeView4.Location = new Point(806, 123);
                treeView4.Size = new Size(411, 428);
                treeView4.ExpandAll();
            }
            else
            if (TVn == 4)
            {
                treeView1.Visible = false;
                treeView2.Visible = false;
                treeView3.Visible = false;
                treeView4.Visible = false;
                treeView5.Visible = true;
                treeView5.Location = new Point(806, 123);
                treeView5.Size = new Size(411, 428);
                treeView5.ExpandAll();
            }




            //treeView1.Nodes.Clear();

            //List<LeksemItem> BuffLeksems = new List<LeksemItem>();
            //string buffName;

            //TreeNode WhileNode = new TreeNode("Конструкция: while");
            //TreeNode WhileNode_if = new TreeNode("Сравнение: ");
            //WhileNode.Nodes.Add(WhileNode_if);
            ////WhileNode.Nodes.Add("Условие: ");
            //WhileNode.Nodes.Add("Конструкция: do begin...end");

            //TreeNode AssignmentNode = new TreeNode("Присваивание");
            //AssignmentNode.Nodes.Add("Переменная: ");

            //TreeNode PlusNode = new TreeNode("Сложение");
            //PlusNode.Nodes.Add("...");
            //PlusNode.Nodes.Add("...");

            //foreach (LeksemItem LI in LT)
            //{
            //    buffName = LI.name;

            //    switch(buffName)
            //    {
            //        case ("while"):
            //            for(int i=0; i<LT.Count; i++)
            //            {
            //                if(LT[i].type=="Знаки сравнения")
            //                {
            //                    WhileNode.Nodes[0].Text += LT[i].name;
            //                    WhileNode_if.Nodes.Add(LT[i - 1].type + " " + LT[i - 1].name);
            //                    WhileNode_if.Nodes.Add(LT[i + 1].type + " " + LT[i + 1].name);
            //                    break;
            //                }
            //            }
            //            treeView1.Nodes.Add(WhileNode);
            //            break;                                               
            //    }
            //    break;
            //}

            //List<LeksemItem> KeyLeksems


            //bool WHL_p1 = false;
            //foreach (LeksemItem LI in LT)
            //{
            //    string fullname = LI.type + ": " + LI.name;

            //    if(WHL_p1==true)
            //    {
            //        switch (LI.type)
            //        {
            //            case "Идентификатор":
            //                //K
            //                break;
            //        }
            //    }

            //    switch (fullname)
            //    {
            //        case "Ключевое слово: while":
            //            treeNode.Nodes.Add("Конструкция: while");
            //            //TreeNode KeyWord_While = new TreeNode("Конструкция: while");
            //            WHL_p1 = true;
            //            break;
            //            //KeyWord_While.Nodes.Add(new TreeNode("Сравнение"));
            //            //KeyWord_While.Nodes.Add(new TreeNode("Конструкция: do begin...end"));
            //    }
            //}



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Location = new Point(806, 123);
            treeView1.Size = new Size(411, 428);
            treeView2.Visible = false;
            treeView3.Visible = false;
            treeView4.Visible = false;
            treeView5.Visible = false;
        }
    }
}
