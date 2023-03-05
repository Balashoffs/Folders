using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Folders
{
    public partial class Form1 : Form
    {
        private String rootFolderValue;
        private static readonly String rootFolderName = "root.txt";
        private GeneratedFoldersStore _generatedFoldersStore;
        private readonly Regex  regexWithNumbersAndComa = new Regex("^[\\d,]+$");
        private readonly Regex  regexWithNumbersAndSpace = new Regex("^[\\d\\s]+$");
        private readonly Regex  regexOnlyWithNumbers = new Regex("^[\\d]+$");
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(rootFolderName)){
                String[] fileLines = File.ReadAllLines(rootFolderName);
                rootFolderValue = fileLines[0];
                panelWithControls.Visible = true;
                labelSelectedRootFolder.Text = rootFolderValue;
                
            }
            else
            {
                callSelectFolderDialog();
            }
        }

        private void callSelectFolderDialog()
        {
            if (this.folderBrowserDialogSelectRootFolder.ShowDialog() == DialogResult.OK)
            {
                rootFolderValue = folderBrowserDialogSelectRootFolder.SelectedPath;
                File.Delete(rootFolderName);
                File.WriteAllText(rootFolderName, rootFolderValue);
                panelWithControls.Visible = true;
                labelSelectedRootFolder.Text = rootFolderValue;
                
            }
        }

        private void buttonFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            callSelectFolderDialog();
        }

        private void buttonGeneratingFolders_Click(object sender, EventArgs e)
        {
            if ( panelWithControls.ContainsFocus )
            {
                if(textBoxTomNunbers.Text.Length == 0)
                {
                    var result = MessageBox.Show("Введите номера томов через запятые!!!");
                    if (result == DialogResult.OK)
                    {
                        textBoxTomNunbers.Focus();
                    }
                }
                else
                {
                    _generatedFoldersStore.Generate();
                    _generatedFoldersStore = null;
                    textBoxDeloNumber.Clear();
                    textBoxTomNunbers.Clear();
                }
            }
        }

        private void textBoxDeloNumber_Leave(object sender, EventArgs e)
        {
            if (panelWithControls.ContainsFocus)
            {
                if (textBoxDeloNumber.Text.Length > 0)
                {
                    if (regexWithNumbersAndSpace.IsMatch(textBoxDeloNumber.Text))
                    {
                        _generatedFoldersStore = new GeneratedFoldersStore(rootFolderValue, textBoxDeloNumber.Text);

                    }
                    else
                    {
                        var result = MessageBox.Show("В имени дела должны быть только ЦЫФРЫ и ПРОБЕЛЫ");
                        if (result == DialogResult.OK)
                        {
                            textBoxDeloNumber.Clear();
                            textBoxDeloNumber.Focus();
                        }
                    }
                    
                }
                else
                {
                    var result = MessageBox.Show("Вы забыли ввести номер дела");
                    if (result == DialogResult.OK)
                    {
                        textBoxDeloNumber.Focus();
                    }
                }
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBoxDeloNumber.Focus();
        }


        private void textBoxTomNunbers_Leave(object sender, EventArgs e)
        {
            if (panelWithControls.ContainsFocus)
            {
                if (textBoxTomNunbers.Text.Length > 0)
                {
                    if (regexWithNumbersAndComa.IsMatch(textBoxTomNunbers.Text))    
                    {

                        String deloNumbersText = textBoxTomNunbers.Text;
                        List<int> indexes = deloNumbersText.Split(',').Select(s => int.Parse(s)).ToList();
                        _generatedFoldersStore.tomeIndexes.AddRange(indexes);
                    }else if (regexOnlyWithNumbers.IsMatch(textBoxTomNunbers.Text))
                    {
                        int index = int.Parse(textBoxDeloNumber.Text);
                        _generatedFoldersStore.tomeIndexes.Add(index);
                    }
                    else
                    {
                        var result = MessageBox.Show("Индексы томов могут содержать только ЗАПЯТЫЕ и ЦИФРЫ!!!. Введитe номера томов через запятые!!!");
                        if (result == DialogResult.OK)
                        {
                            textBoxTomNunbers.Clear();  
                            textBoxTomNunbers.Focus();
                        }
                    }


                }
                else
                {
                    var result = MessageBox.Show("Введите номера томов через запятые!!!");
                    if (result == DialogResult.OK)
                    {
                        textBoxTomNunbers.Focus();
                    }
                }
            }

        }

        private void textBoxDeloNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (regexWithNumbersAndSpace.IsMatch(textBoxDeloNumber.Text))
                {
                    _generatedFoldersStore = new GeneratedFoldersStore(rootFolderValue, textBoxDeloNumber.Text.Trim());
                    textBoxTomNunbers.Focus();

                }
                else
                {
                    var result = MessageBox.Show("В имени дела должны быть только ЦЫФРЫ и ПРОБЕЛЫ");
                    if (result == DialogResult.OK)
                    {
                        textBoxDeloNumber.Clear();
                        textBoxDeloNumber.Focus();
                    }
                }
                
            }
        }

        private void textBoxTomNunbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (textBoxTomNunbers.Text.Length > 0)
                {
                    if (regexWithNumbersAndComa.IsMatch(textBoxTomNunbers.Text))
                    {

                        String deloNumbersText = textBoxTomNunbers.Text.Trim();
                        List<String> indexesS = deloNumbersText.Split(',').ToList();
                        List<int> indexes = indexesS.Where(w => w.Length > 0).Select(s => int.Parse(s)).ToList();
                        _generatedFoldersStore.tomeIndexes.AddRange(indexes);
                        buttonGeneratingFolders.PerformClick();
                    }
                    else if (regexOnlyWithNumbers.IsMatch(textBoxTomNunbers.Text))
                    {
                        int index = int.Parse(textBoxDeloNumber.Text.Trim());
                        _generatedFoldersStore.tomeIndexes.Add(index);
                        buttonGeneratingFolders.PerformClick();
                    }
                    else
                    {
                        var result = MessageBox.Show("Индексы томов могут содержать только ЗАПЯТЫЕ и ЦИФРЫ!!!. Введитe номера томов через запятые!!!");
                        if (result == DialogResult.OK)
                        {
                            textBoxTomNunbers.Clear();
                            textBoxTomNunbers.Focus();
                        }
                    }


                }
                else
                {
                    var result = MessageBox.Show("Введите номера томов через запятые!!!");
                    if (result == DialogResult.OK)
                    {
                        textBoxTomNunbers.Focus();
                    }
                }
            }
        }

        private void buttonCalculatorAllDel_Click(object sender, EventArgs e)
        {
            TotalFoldersCalculator tfc = new TotalFoldersCalculator(rootFolderValue);
            if (tfc.isFilesTodays())
            {
                TotalFoldersCalculator calculated = tfc.calculate();
                labelTotalDels.Text = calculated.allDelos.ToString();
                labelTotalTomov.Text = calculated.allTomes.ToString();
                labelTotalPages.Text = calculated.allPages.ToString();
            }
            else
            {
                var result = MessageBox.Show("За сегодня файлов на найдено");
                if (result == DialogResult.OK)
                {
                    textBoxTomNunbers.Focus();
                }
            }

        }
    }

    class GeneratedFoldersStore
    {
        private String deloName;
        private String rootName;
        private String localDate;
        private const String tomeIndexTemplate = "Том_{0}скан";


        public GeneratedFoldersStore(string rootName, string deloName)
        {
            this.deloName = deloName;
            this.rootName = rootName;
            this.localDate = DateTime.Now.Date.ToString("dd.MM.yyyy");
        }


        public readonly List<int> tomeIndexes = new List<int>();

        internal void Generate()
        {
         
            List<String> folders = tomeIndexes.Select(i =>
              {
                  String tomeName = String.Format(tomeIndexTemplate, i);
                  return $"{rootName}\\{localDate}\\{deloName}\\{tomeName}";
              }).ToList();

            
            for (int i = 0; i < folders.Count; i++)
            {
                try
                {
                    Directory.CreateDirectory(folders[i]);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            MessageBox.Show("Нужные папки были созданы");
        }
    }

    class TotalFoldersCalculator
    {
        private String rootName;
        private String localDate;

        public int allDelos;
        public int allTomes;
        public int allPages;

        String[] deloFolders;
        String[] tomesFolders;
        String[] pdfs;

        public TotalFoldersCalculator(string rootName)
        {
            this.rootName = rootName;
            this.localDate = DateTime.Now.Date.ToString("dd.MM.yyyy");
        }

        internal bool isFilesTodays() {
            try
            {
                String todayFolder = Path.Combine(rootName, localDate);
                deloFolders = Directory.GetDirectories(todayFolder, "*", SearchOption.TopDirectoryOnly);
                tomesFolders = deloFolders.Select(s => Directory.GetDirectories(s, "*", SearchOption.TopDirectoryOnly)).SelectMany(s => s).ToArray();
                pdfs = tomesFolders.Select(s => Directory.GetFiles(s, "*.pdf")).SelectMany(s => s).ToArray();
                return pdfs.Length > 0;
            }catch(Exception ex) { return false; }
        }


        internal TotalFoldersCalculator calculate()
        {
            int totalPages = pdfs.Select(s =>
            {
                using (StreamReader sr = new StreamReader(File.OpenRead(s)))
                {
                    Regex regex = new Regex(@"/Type\s*/Page[^s]");
                    MatchCollection matches = regex.Matches(sr.ReadToEnd());

                    return matches.Count;
                }
            }).Sum();

            allDelos = deloFolders.Length;
            allTomes = tomesFolders.Length;
            allPages = totalPages;

            return this;

        }
    }
}
