using System;
using System.IO;
using System.Windows.Forms;


namespace KoganL3_test2
{
    public partial class Form1 : Form
    {
        public HashTable HT = new HashTable(200);
        public Form1()
        {
            InitializeComponent();
        }

        public class HashTable
        {
            readonly string[,] Table;     //таблица идентификаторов
            int IdCount;                  //сколько идентификаторов в таблице                   
            float LoadFactor;             //фактор загруженности таблицы
            int CollisionsCount;          //счётчик коллизий
            int MethodResolveColission;   //метод разрешения коллизий

            int LastID = 0;               //последний свободный индекс (для списков)

            public HashTable(int size)
            {
                Table = new string[size, size];  //создать таблицу заданного размера
                MethodResolveColission = 1;     //по умолчанию простое рехеширование
            }

            public void ClearTable()
            {
                Array.Clear(Table, 0, Table.Length);
                LastID = 0;
                IdCount = 0;
                LoadFactor = 0;
                CollisionsCount = 0;
            }

            public void CalcLoadFactor()
            {
                LoadFactor = (float)IdCount / (float)Table.Length; //вычислить коэффициент загруженности таблицы
            }

            public float GetLoadFactor()
            {
                return LoadFactor;  //Получить фактор загруженности
            }

            public int GetColissionsCount()
            {
                return CollisionsCount; //Получить кол-во коллизий
            }

            public int GetIdCount()
            {
                return IdCount; //получить кол-во элементов в таблице
            }

            public void ChangeMethodCollision_1() //метод открытой адрессации (простое рехеширование)
            {
                MethodResolveColission = 1;
            }
            public void ChangeMethodCollision_2() //метод псевдослучайных чисел
            {
                MethodResolveColission = 2;
            }
            public void ChangeMethodCollision_3() //метод произведения
            {
                MethodResolveColission = 3;
            }
            public void ChangeMethodCollision_4() //метод цепочек
            {
                MethodResolveColission = 4;
            }
            public void ChangeMethodCollision_5() //простой список
            {
                MethodResolveColission = 5;
            }
            public void ChangeMethodCollision_6() //упорядоченный список
            {
                MethodResolveColission = 6;
            }

            public static int HashFunction(string key) //ХЭШ ФУНКЦИЯ
            {
                int value = 0;
                int size = key.Length;
                int[] valuesArr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    valuesArr[i] = (int)key[i];
                    value += (int)key[i];
                }
                value = (int)(((value * 10) / size));
                if (value >= 1000)
                {
                    value = value - 1000;
                }
                else
                {
                    value = value / 10;
                }

                return value;
            }

            public void PrintTable(TextBox tbx)
            {
                tbx.Clear();
                for (int i = 0; i < (Table.Length / 200); i++)
                {
                    if (Table[0, i] != null)
                    {
                        tbx.Text += Table[0, i] + "[0," + i.ToString() + "]";

                        if (Table[1, i] != null) //Если метод цепочек
                        {
                            tbx.Text += ", ";
                            for (int j = 1; j < (Table.Length / 200); j++)
                            {
                                tbx.Text += Table[j, i] + "[" + j.ToString() + "," + i.ToString() + "]";
                                if ((j < (Table.Length / 200)) && (Table[j + 1, i] != null))
                                {
                                    tbx.Text += ", ";
                                }
                                else
                                {
                                    tbx.Text += ";";
                                    tbx.Text += "\r\n";
                                    break;
                                }
                            }
                        }
                        else
                        {
                            tbx.Text += "\r\n";
                        }
                    }
                }
            }

            public void sortArray() //упорядочить список по алфавиту
            {
                string[] tempArr = new string[LastID + 1];

                for (int i = 0; i <= LastID; i++)
                {
                    tempArr[i] = Table[0, i];
                }
                Array.Sort(tempArr);

                for (int i = 0; i <= LastID; i++)
                {
                    Table[0, i] = tempArr[i];
                }
            }

            public void AddID(string id)
            {
                if (MethodResolveColission == 5) //метод простого списка
                {
                L_ADD1: if (Table[0, LastID] == null)
                    {
                        Table[0, LastID] = id;
                        IdCount++;
                        CalcLoadFactor();
                    }
                    else
                    {
                        LastID++;
                        goto L_ADD1;
                    }
                }
                else
                if (MethodResolveColission == 6) //метод упорядоченного списка
                {
                L_ADD2: if (Table[0, LastID] == null)
                    {
                        Table[0, LastID] = id;
                        IdCount++;
                        CalcLoadFactor();
                    }
                    else
                    {
                        LastID++;
                        goto L_ADD2;
                    }
                    sortArray();
                }
                else
                {

                    int value = HashFunction(id);
                    if (Table[0, value] == null)
                    {
                        Table[0, value] = id;
                        IdCount++;
                        CalcLoadFactor();
                    }
                    else
                    {
                        CollisionsCount++;

                        if (MethodResolveColission == 1)
                        {
                            CollisionNOT_MethodSimpleRehache(value, id); //метод простого рехеширования
                        }
                        if (MethodResolveColission == 2)
                        {
                            CollisionNOT_RandomMethod(value, id); //метод псевдослучайных чисел
                        }
                        if (MethodResolveColission == 3)
                        {
                            CollisionNOT_ProizvedenieMethod(value, id); //метод произведения
                        }
                        if (MethodResolveColission == 4)
                        {
                            CollisionNOT_ChainMethod(value, id); //метод цепочек
                        }
                    }
                }
            }

            public void CollisionNOT_MethodSimpleRehache(int value, string id)
            {
                for (int i = value + 1; i < Table.Length; i++)
                {
                    if (Table[0, i] == null)
                    {
                        Table[0, i] = id;
                        IdCount++;
                        CalcLoadFactor();
                        break;
                    }
                }
            }

            public void CollisionNOT_RandomMethod(int value, string id)
            {
                Random rnd = new Random();
            SUDA: int randValue = rnd.Next(-10, 10);
                if ((value + randValue >= 0) && (value + randValue <= (Table.Length / 200)))
                {
                    if (Table[0, value + randValue] == null)
                    {
                        value = value + randValue;
                        Table[0, value] = id;
                        IdCount++;
                        CalcLoadFactor();
                    }
                    else
                    {
                        value = value + randValue;
                        goto SUDA;
                    }
                }
                else
                {
                    goto SUDA;
                }
            }

            public void CollisionNOT_ProizvedenieMethod(int value, string id)
            {
                int PValue = 2;
            SUDA2: int tempValue = (value * value) % PValue;

                if ((tempValue >= 0) && (tempValue <= (Table.Length / 200)))
                {
                    if (Table[0, tempValue] == null)
                    {
                        value = tempValue;
                        Table[0, value] = id;
                        IdCount++;
                        CalcLoadFactor();
                    }
                    else
                    {
                        PValue++;
                        goto SUDA2;
                    }
                }
                else
                {
                    PValue++;
                    goto SUDA2;
                }
            }

            public void CollisionNOT_ChainMethod(int value, string id)
            {
                int j = 1;
            SUDA3: if (Table[j, value] == null)
                {
                    Table[j, value] = id;
                    IdCount++;
                    CalcLoadFactor();
                }
                else
                {
                    j++;
                    goto SUDA3;
                }
            }

            public void SearchID(string id)
            {
                if ((MethodResolveColission == 5) || (MethodResolveColission == 6))
                {
                    bool ok = false;
                    for (int i = 0; i < (Table.Length / 200); i++)
                    {
                        if (id == Table[0, i])
                        {
                            MessageBox.Show("Идентификатор '" + id + "' найден в таблице под номером " + i);
                            ok = true;
                            break;
                        }
                    }
                    if (ok == false)
                    {
                        MessageBox.Show("Данный идентификатор в таблице не найден");
                    }
                }
                else
                if (MethodResolveColission == 6)
                {

                }
                else
                {

                    int value = HashFunction(id);
                    string PredictResult = Table[0, value];

                    if (id == PredictResult)
                    {
                        MessageBox.Show("Идентификатор '" + id + "' найден в таблице под номером " + value);
                    }
                    else
                    {
                        if (MethodResolveColission != 4)
                        {
                            for (int i = value; i < (Table.Length / 200); i++)
                            {
                                if (Table[0, i] == id)
                                {
                                    MessageBox.Show("Идентификатор '" + id + "' найден в таблице под номером " + i);
                                    break;
                                }
                            }
                        }

                        else
                        {
                            for (int j = 1; j < (Table.Length / 200); j++)
                            {
                                if (Table[j, value] != null)
                                {
                                    if (id == Table[j, value])
                                    {
                                        MessageBox.Show("Идентификатор '" + id + "' найден в таблице под номером " + "[" + j.ToString() + "," + value.ToString() + "]");
                                        break;
                                    }
                                }
                                if ((j < (Table.Length / 200)) && (Table[j + 1, value] != null))
                                {

                                }
                                else
                                {
                                    MessageBox.Show("Данный идентификатор в таблице не найден");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void InfoUpdate()
        {
            label_LoadFactor.Text = (HT.GetLoadFactor() * 100).ToString() + " %";
            label_Colissions.Text = HT.GetColissionsCount().ToString();
            label_IdCount.Text = HT.GetIdCount().ToString();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            HT.AddID(tbxADD.Text);

            HT.PrintTable(tbxTABLE);

            InfoUpdate();
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            HT.SearchID(tbxSEARCH.Text);
        }

        private void rb_1_CheckedChanged(object sender, EventArgs e)
        {
            HT.ChangeMethodCollision_1();
        }

        private void rb_2_CheckedChanged(object sender, EventArgs e)
        {
            HT.ChangeMethodCollision_2();
        }

        private void rb_3_CheckedChanged(object sender, EventArgs e)
        {
            HT.ChangeMethodCollision_3();
        }

        private void rb_4_CheckedChanged(object sender, EventArgs e)
        {
            HT.ChangeMethodCollision_4();
        }

        private void rb_5_CheckedChanged(object sender, EventArgs e)
        {
            HT.ChangeMethodCollision_5();
        }

        private void rb_6_CheckedChanged(object sender, EventArgs e)
        {
            HT.ChangeMethodCollision_6();
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            HT.ClearTable();
            tbxTABLE.Clear();


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
                            HT.AddID(line);

                            HT.PrintTable(tbxTABLE);

                            InfoUpdate();

                            label_FileName.Text = "Файл: " + name;
                        }
                    }
                }
            }
        }
    }
}
