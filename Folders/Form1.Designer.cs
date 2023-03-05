namespace Folders
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialogSelectRootFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxDeloNumber = new System.Windows.Forms.TextBox();
            this.DeloNumber = new System.Windows.Forms.Label();
            this.TomNumbers = new System.Windows.Forms.Label();
            this.textBoxTomNunbers = new System.Windows.Forms.TextBox();
            this.buttonGeneratingFolders = new System.Windows.Forms.Button();
            this.panelWithControls = new System.Windows.Forms.Panel();
            this.panelCalculator = new System.Windows.Forms.Panel();
            this.labelTotalPages = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalTomov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalDels = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCalculator = new System.Windows.Forms.Label();
            this.buttonCalculatorAllDel = new System.Windows.Forms.Button();
            this.buttonFolderBrowserDialog = new System.Windows.Forms.Button();
            this.labelSelectedRootFolder = new System.Windows.Forms.Label();
            this.labelRootFolderValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWithControls.SuspendLayout();
            this.panelCalculator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDeloNumber
            // 
            this.textBoxDeloNumber.Location = new System.Drawing.Point(15, 37);
            this.textBoxDeloNumber.Name = "textBoxDeloNumber";
            this.textBoxDeloNumber.Size = new System.Drawing.Size(332, 20);
            this.textBoxDeloNumber.TabIndex = 0;
            this.textBoxDeloNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeloNumber_KeyPress);
            this.textBoxDeloNumber.Leave += new System.EventHandler(this.textBoxDeloNumber_Leave);
            // 
            // DeloNumber
            // 
            this.DeloNumber.AutoSize = true;
            this.DeloNumber.Location = new System.Drawing.Point(12, 11);
            this.DeloNumber.Name = "DeloNumber";
            this.DeloNumber.Size = new System.Drawing.Size(226, 13);
            this.DeloNumber.TabIndex = 1;
            this.DeloNumber.Text = "Введите номер дела";
            // 
            // TomNumbers
            // 
            this.TomNumbers.AutoSize = true;
            this.TomNumbers.Location = new System.Drawing.Point(12, 73);
            this.TomNumbers.Name = "TomNumbers";
            this.TomNumbers.Size = new System.Drawing.Size(200, 13);
            this.TomNumbers.TabIndex = 2;
            this.TomNumbers.Text = "введите номера томов через запятую";
            // 
            // textBoxTomNunbers
            // 
            this.textBoxTomNunbers.Location = new System.Drawing.Point(15, 103);
            this.textBoxTomNunbers.Name = "textBoxTomNunbers";
            this.textBoxTomNunbers.Size = new System.Drawing.Size(332, 20);
            this.textBoxTomNunbers.TabIndex = 3;
            this.textBoxTomNunbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTomNunbers_KeyPress);
            this.textBoxTomNunbers.Leave += new System.EventHandler(this.textBoxTomNunbers_Leave);
            // 
            // buttonGeneratingFolders
            // 
            this.buttonGeneratingFolders.Location = new System.Drawing.Point(15, 139);
            this.buttonGeneratingFolders.Name = "buttonGeneratingFolders";
            this.buttonGeneratingFolders.Size = new System.Drawing.Size(332, 30);
            this.buttonGeneratingFolders.TabIndex = 4;
            this.buttonGeneratingFolders.Text = "Создать папки";
            this.buttonGeneratingFolders.UseVisualStyleBackColor = true;
            this.buttonGeneratingFolders.Click += new System.EventHandler(this.buttonGeneratingFolders_Click);
            // 
            // panelWithControls
            // 
            this.panelWithControls.Controls.Add(this.DeloNumber);
            this.panelWithControls.Controls.Add(this.textBoxTomNunbers);
            this.panelWithControls.Controls.Add(this.buttonGeneratingFolders);
            this.panelWithControls.Controls.Add(this.textBoxDeloNumber);
            this.panelWithControls.Controls.Add(this.TomNumbers);
            this.panelWithControls.Location = new System.Drawing.Point(12, 12);
            this.panelWithControls.Name = "panelWithControls";
            this.panelWithControls.Size = new System.Drawing.Size(362, 178);
            this.panelWithControls.TabIndex = 5;
            this.panelWithControls.Visible = false;
            // 
            // panelCalculator
            // 
            this.panelCalculator.Controls.Add(this.labelCalculator);
            this.panelCalculator.Controls.Add(this.buttonCalculatorAllDel);
            this.panelCalculator.Controls.Add(this.labelTotalPages);
            this.panelCalculator.Controls.Add(this.label3);
            this.panelCalculator.Controls.Add(this.labelTotalTomov);
            this.panelCalculator.Controls.Add(this.label1);
            this.panelCalculator.Controls.Add(this.labelTotalDels);
            this.panelCalculator.Controls.Add(this.label2);
            this.panelCalculator.Location = new System.Drawing.Point(12, 196);
            this.panelCalculator.Name = "panelCalculator";
            this.panelCalculator.Size = new System.Drawing.Size(362, 93);
            this.panelCalculator.TabIndex = 8;
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.AutoSize = true;
            this.labelTotalPages.Location = new System.Drawing.Point(237, 58);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPages.TabIndex = 12;
            this.labelTotalPages.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "всего страниц";
            // 
            // labelTotalTomov
            // 
            this.labelTotalTomov.AutoSize = true;
            this.labelTotalTomov.Location = new System.Drawing.Point(237, 45);
            this.labelTotalTomov.Name = "labelTotalTomov";
            this.labelTotalTomov.Size = new System.Drawing.Size(13, 13);
            this.labelTotalTomov.TabIndex = 11;
            this.labelTotalTomov.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "всего дел";
            // 
            // labelTotalDels
            // 
            this.labelTotalDels.AutoSize = true;
            this.labelTotalDels.Location = new System.Drawing.Point(237, 32);
            this.labelTotalDels.Name = "labelTotalDels";
            this.labelTotalDels.Size = new System.Drawing.Size(13, 13);
            this.labelTotalDels.TabIndex = 10;
            this.labelTotalDels.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "всего томов";
            // 
            // labelCalculator
            // 
            this.labelCalculator.AutoSize = true;
            this.labelCalculator.Location = new System.Drawing.Point(9, 9);
            this.labelCalculator.Name = "labelCalculator";
            this.labelCalculator.Size = new System.Drawing.Size(328, 13);
            this.labelCalculator.TabIndex = 6;
            this.labelCalculator.Text = "Подсчиать общее количества дел, томов и страниц за сегодня";
            // 
            // buttonCalculatorAllDel
            // 
            this.buttonCalculatorAllDel.Location = new System.Drawing.Point(9, 27);
            this.buttonCalculatorAllDel.Name = "buttonCalculatorAllDel";
            this.buttonCalculatorAllDel.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculatorAllDel.TabIndex = 5;
            this.buttonCalculatorAllDel.Text = "Подсчитать";
            this.buttonCalculatorAllDel.UseVisualStyleBackColor = true;
            this.buttonCalculatorAllDel.Click += new System.EventHandler(this.buttonCalculatorAllDel_Click);
            // 
            // buttonFolderBrowserDialog
            // 
            this.buttonFolderBrowserDialog.Location = new System.Drawing.Point(3, 33);
            this.buttonFolderBrowserDialog.Name = "buttonFolderBrowserDialog";
            this.buttonFolderBrowserDialog.Size = new System.Drawing.Size(121, 23);
            this.buttonFolderBrowserDialog.TabIndex = 5;
            this.buttonFolderBrowserDialog.Text = "Изменить";
            this.buttonFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.buttonFolderBrowserDialog.Click += new System.EventHandler(this.buttonFolderBrowserDialog_Click);
            // 
            // labelSelectedRootFolder
            // 
            this.labelSelectedRootFolder.AutoSize = true;
            this.labelSelectedRootFolder.Location = new System.Drawing.Point(12, 0);
            this.labelSelectedRootFolder.Name = "labelSelectedRootFolder";
            this.labelSelectedRootFolder.Size = new System.Drawing.Size(191, 13);
            this.labelSelectedRootFolder.TabIndex = 6;
            this.labelSelectedRootFolder.Text = "Выберите папку с вашими сканами ";
            // 
            // labelRootFolderValue
            // 
            this.labelRootFolderValue.AutoSize = true;
            this.labelRootFolderValue.Location = new System.Drawing.Point(145, 38);
            this.labelRootFolderValue.Name = "labelRootFolderValue";
            this.labelRootFolderValue.Size = new System.Drawing.Size(141, 13);
            this.labelRootFolderValue.TabIndex = 7;
            this.labelRootFolderValue.Text = "Имя вашей рабочей папки";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFolderBrowserDialog);
            this.panel1.Controls.Add(this.labelRootFolderValue);
            this.panel1.Controls.Add(this.labelSelectedRootFolder);
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 66);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 369);
            this.Controls.Add(this.panelCalculator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWithControls);
            this.Name = "Form1";
            this.Text = "Генератор папок v.1.0";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelWithControls.ResumeLayout(false);
            this.panelWithControls.PerformLayout();
            this.panelCalculator.ResumeLayout(false);
            this.panelCalculator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSelectRootFolder;
        private System.Windows.Forms.TextBox textBoxDeloNumber;
        private System.Windows.Forms.Label DeloNumber;
        private System.Windows.Forms.Label TomNumbers;
        private System.Windows.Forms.TextBox textBoxTomNunbers;
        private System.Windows.Forms.Button buttonGeneratingFolders;
        private System.Windows.Forms.Panel panelWithControls;
        private System.Windows.Forms.Button buttonFolderBrowserDialog;
        private System.Windows.Forms.Label labelSelectedRootFolder;
        private System.Windows.Forms.Label labelRootFolderValue;
        private System.Windows.Forms.Panel panelCalculator;
        private System.Windows.Forms.Label labelTotalPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalTomov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalDels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCalculator;
        private System.Windows.Forms.Button buttonCalculatorAllDel;
        private System.Windows.Forms.Panel panel1;
    }
}

