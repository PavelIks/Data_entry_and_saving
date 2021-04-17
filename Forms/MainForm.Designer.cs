using System.Windows.Forms;

namespace SaveTXTFileDate.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Text = "MainForm";
            //
            //лэйблы
            //
            FirstNamelabel = new Label();
            FirstNamelabel.Text = "First name: ";
            FirstNamelabel.Size = new System.Drawing.Size(100, 20);
            FirstNamelabel.Location = new System.Drawing.Point(10,10);

            LastNamelabel = new Label();
            LastNamelabel.Text = "Last name: ";
            LastNamelabel.Size = new System.Drawing.Size(100, 20);
            LastNamelabel.Location = new System.Drawing.Point(10, 30);

            MiddletNamelabel = new Label();
            MiddletNamelabel.Text = "Middle name: ";
            MiddletNamelabel.Size = new System.Drawing.Size(100, 20);
            MiddletNamelabel.Location = new System.Drawing.Point(10, 50);

            Agelabel = new Label();
            Agelabel.Text = "Age: ";
            Agelabel.Size = new System.Drawing.Size(100, 20);
            Agelabel.Location = new System.Drawing.Point(10, 70);

            //
            //текст боксы
            //
            FirstNameBox = new TextBox();
            FirstNameBox.Size = new System.Drawing.Size(100, 20);
            FirstNameBox.Location = new System.Drawing.Point(180, 10);
            FirstNameBox.Multiline = false;

            MiddleNameBox = new TextBox();
            MiddleNameBox.Size = new System.Drawing.Size(100, 20);
            MiddleNameBox.Location = new System.Drawing.Point(180, 30);
            MiddleNameBox.Multiline = false;

            LastNameBox = new TextBox();
            LastNameBox.Size = new System.Drawing.Size(100, 20);
            LastNameBox.Location = new System.Drawing.Point(180, 50);
            LastNameBox.Multiline = false;

            AgeBox = new TextBox();
            AgeBox.Size = new System.Drawing.Size(100, 20);
            AgeBox.Location = new System.Drawing.Point(180, 70);
            AgeBox.Multiline = false;

            //
            // кнопка
            //
            SaveButton = new Button();
            SaveButton.Size = new System.Drawing.Size(100, 30);
            SaveButton.Text = "Save";
            SaveButton.Location = new System.Drawing.Point(100, 120);
            SaveButton.Click += GetSave; 

            
            //
            //лэйблы
            //
            this.Controls.Add(FirstNamelabel);
            this.Controls.Add(LastNamelabel);
            this.Controls.Add(MiddletNamelabel);
            this.Controls.Add(Agelabel);
            //
            //текст боксы
            //
            this.Controls.Add(FirstNameBox);
            this.Controls.Add(MiddleNameBox);
            this.Controls.Add(LastNameBox);
            this.Controls.Add(AgeBox);
            //
            // кнопка
            //
            this.Controls.Add(SaveButton);
        }



        private Label FirstNamelabel;
        private Label LastNamelabel;
        private Label MiddletNamelabel;
        private Label Agelabel;

        private TextBox FirstNameBox;
        private TextBox MiddleNameBox;
        private TextBox LastNameBox;
        private TextBox AgeBox;

        private Button SaveButton;
        #endregion
    }
}