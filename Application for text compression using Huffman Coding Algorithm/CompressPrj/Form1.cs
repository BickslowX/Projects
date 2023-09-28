using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressPrj
{
    struct Tree
    {
        private string Letters;
        private string Code;
        private int Friq;
        public Tree(string letters, string code, int friq)
        {
            Letters = letters;
            Code = code;
            Friq = friq;
        }
        public string GetLetters => Letters;
        public string GetCode => Code;
        public int GetFriq => Friq;
        public void SetLetters(string let) { Letters = let; }
        public void SetCode(string c) { Code = c; }
        public void SetFriq(int n) { Friq = n; }
    }
    public partial class Form1 : Form
    {
        // Глобальні змінні програми
        string InputText = ""; // вхідний текст (зчитується з файлу)
        Dictionary<char, string> Dict; // Словник з символами та їх двійковими кодами
        Dictionary<string, int> StartFreq = new Dictionary<string, int>(); //словник з буквами і частотою їх входження
        Tree[] Hcode; //словник з буквами і їхнім кодом за Хафманом
        List<Tree> WorkWithTree;//список через який будуєтся дерево і робота з ним
        string HafmanCode; //кодування текста за словником з кодами
        public Form1()
        {
            InitializeComponent();
            DecodeDataBtn.Enabled = false;
        }
        
        /* Метод, який викликається, коли користувач натискає 
         * кнопку з назвою "Завантажити файл з даними"
         */
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            DecodeDataBtn.Enabled = false;
            DictionaryField.Text = "";
            CodeByDictionaryField.Text = "";
            DecodeTextField.Text = "";

            CompressCoeffLabel.Text = "";
            try
            {
                InputText = LoadDataFunc();
                InputTextField.Text = InputText;                

                string BinInputText = BinInputTextFunc();
                BinInputTextField.Text = BinInputText;
            }
            catch
            {
                MessageBox.Show("Файл не обрано / дані не завантажено!");
            }
        }
        /*
         * Метод, який викликається у методі при натисканні на кнопку 
         * з надписом "Завантажити дані з файлу".
         * Метод використовується для роботи діалоговим вікном
         * (не передбачає зміни)
         */
        private string LoadDataFunc()
        {
            FileDialog.Filter = "txt files (*.txt)|*.txt";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = FileDialog.FileName;
                StreamReader sr = new StreamReader(filePath);
                string InText = sr.ReadToEnd();
                sr.Close();

                return InText;
            }
            return "";
        }

        /*
         * Метод для переведення вхідного тексту в
         * бінарний код за кодовою системою UTF-16 / Unicode / Windows / ASCII
         * (потрібно реалізувати логіку)
         */
        private string BinInputTextFunc()
        {
            string s = "";
            BitArray btr = new BitArray(Encoding.ASCII.GetBytes(InputText));
            for (int index = 0; index < btr.Count; index++)
            {
                s += (btr[index] ? "1" : "0");
            }
            return s;          
        }

       
        private void FreqGen()//Генерування словаря частот
        {
            for (int i = 0; i < InputText.Length; i++)
            {
                string Lat = InputText[i].ToString();
                int count = 0;
                StartFreq.TryGetValue(Lat, out count);
                StartFreq[Lat] = count + 1;
            }
            foreach(KeyValuePair<string,int> l in StartFreq)
            {
                FreqBox.Text += string.Format(" {0} => {1}\n", l.Key,l.Value);
            }
        }
       
        /* 
         * Метод для формування словника з символами та їх кодами за алгоритмом Хаффмана 
         * (потрібно реалізувати логіку)
         */
        private Dictionary<char, string> CreateDictionaryFunc()
        {
            Dict = new Dictionary<char, string>();
            Hcode = new Tree[StartFreq.Count];
            int StartCounter = 0;
            foreach(KeyValuePair<string, int> l in StartFreq)
            {
                Hcode[StartCounter] = new Tree(l.Key, "", 0);//записи усіх букв до списку-словаря
                StartCounter++;
            }
            WorkWithTree = new List<Tree>();
            foreach (KeyValuePair<string, int> l in StartFreq)
            {
                WorkWithTree.Add( new Tree(l.Key, "", l.Value));//запис початкових значень у дерево
            }
            void Sort()//функція для сортування дерева
            {
                for (int i = 0; i < WorkWithTree.Count; i++)
                {
                    for (int j = i; j < WorkWithTree.Count; j++)
                    {
                        if(WorkWithTree[i].GetFriq< WorkWithTree[j].GetFriq)
                        {
                            Tree temp = WorkWithTree[i];
                            WorkWithTree[i] = WorkWithTree[j];
                            WorkWithTree[j] = temp;
                        }
                    }
                }
            }
            while(WorkWithTree.Count!=1)
            {
                Sort();
                string temp0 = WorkWithTree[WorkWithTree.Count - 1].GetLetters;
                for (int i =0;i<temp0.Length;i++)
                {
                    for(int j=0;j<Hcode.Length;j++)
                    {
                       if (temp0[i] == Hcode[j].GetLetters[0])
                       {
                           Hcode[j].SetCode("0" + Hcode[j].GetCode);
                       }
                    }
                }
                string temp1 = WorkWithTree[WorkWithTree.Count - 2].GetLetters;
                for (int i = 0; i < temp1.Length; i++)
                {
                    for (int j = 0; j < Hcode.Length; j++)
                    {
                        if (temp1[i] == Hcode[j].GetLetters[0])
                        {
                            Hcode[j].SetCode("1" + Hcode[j].GetCode);
                        }
                    }
                }
                string tempLet = WorkWithTree[WorkWithTree.Count - 2].GetLetters;
                int tempFr = WorkWithTree[WorkWithTree.Count - 2].GetFriq;
                WorkWithTree[WorkWithTree.Count-2] = new Tree(tempLet+ WorkWithTree[WorkWithTree.Count - 1].GetLetters,"",tempFr+ WorkWithTree[WorkWithTree.Count - 1].GetFriq);
                //(дві строчки знизу не працюють, чому саме я так і не зрозумів)
                //WorkWithTree[WorkWithTree.Count - 2].SetLetters(temp0 + temp1);
                //WorkWithTree[WorkWithTree.Count - 2].SetFriq(WorkWithTree[WorkWithTree.Count - 2].GetFriq + WorkWithTree[WorkWithTree.Count - 1].GetFriq);
                WorkWithTree.RemoveAt(WorkWithTree.Count - 1);
            }
            for(int i=0;i<Hcode.Length;i++)
            {
                Dict[Hcode[i].GetLetters[0]] = Hcode[i].GetCode;
            }
            foreach (KeyValuePair<char, string> l in Dict)
            {
                DictionaryField.Text += string.Format(" {0} = {1}\n", l.Key, l.Value);
            }
            return Dict;
        }


        /* 
         * Метод, який викликається, коли користувач натискає кнопку
         * з надписом "Закодувати дані"
         * (потрібно реалізувати логіку)
         */
        private void CodeDataBtn_Click(object sender, EventArgs e)
        {
            DictionaryField.Clear();
            FreqBox.Clear();
            FreqBox.Clear();
            label15.Text = "";
            label14.Text = "";
            label12.Text = "";
            label11.Text = "";
            string coding = InputTextField.Text;
            label15.Text += "(" + InputTextField.Text.Length + ")";
            BinInputTextField.Text = BinInputTextFunc();
            // виклик методу для формування словника, за яким відбудеться кодування
            FreqGen();
            Dictionary<char, string> Dict = CreateDictionaryFunc();
            HafmanCode = coding;
            foreach (KeyValuePair<char, string> l in Dict)
            {
                string tempstr = "";
                tempstr += l.Key;
                HafmanCode = HafmanCode.Replace(tempstr, l.Value);
            }
            CodeByDictionaryField.Text = HafmanCode;
            // визначення коефіцієнта стиснення
            CompressCoeffLabel.Text = Math.Round(1.0*BinInputTextField.Text.Length/CodeByDictionaryField.Text.Length,3).ToString();
            label11.Text += "("+CodeByDictionaryField.Text.Length+")";
            label12.Text += "("+BinInputTextField.Text.Length+")";
            DecodeDataBtn.Enabled = true;
        }
        /* 
         * Метод, який викликається, коли користувач натискає кнопку з надписом "Розкодувати дані"
         * (потрібно реалізувати логіку)
         */
        private void DecodeDataBtn_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            int DecodInd = 0;
            string decoding = "";
            string TempD = "";
            bool fl = false;
            while(DecodInd!=HafmanCode.Length)
            {
                TempD += HafmanCode[DecodInd];
                foreach (KeyValuePair<char, string> l in Dict)
                {
                    if(TempD==l.Value)
                    {
                        decoding += l.Key;
                        fl = true;
                    }
                }
                if(fl==false)
                {
                    DecodInd++;
                }
                if(fl==true)
                {
                    TempD = "";
                    DecodInd++;
                    fl = false;
                }
            }
            DecodeTextField.Text = decoding;
            label13.Text += "(" + DecodeTextField.Text.Length + ")";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
