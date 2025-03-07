using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class MainForm: Form
    {
        List<string> toDoList;
        string selectedItem = null;
        string userName = Environment.UserName;
        public MainForm()
        {
            InitializeComponent();
            addButton.Enabled = false;
            deleteButton.Enabled = false;
            toDoList = new List<string>();
            this.Text = userName + "'s To-Do List";
        }

        private void SaveList(string path, ListBox box)
        {
            string[] lines = new string[box.Items.Count];

            for (int i = 0; i < box.Items.Count; i++)
            {
                lines[i] = box.Items[i].ToString();
            }
            File.WriteAllLines(path, lines);
        }

        private void LoadList(string path, ListBox box)
        {
            FileStream fs = File.OpenRead(path);
            StreamReader reader = new StreamReader(fs);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                //trim whitespace
                box.Items.Add(line.Trim());
            }
        }

        private void listEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(listEntryBox.Text))
            {
                addButton.Enabled = true;
                if (!toDoList.Contains(listEntryBox.Text.Trim()))
                {
                    deleteButton.Enabled = false;
                }
                else
                {
                    deleteButton.Enabled = true;
                }
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(listEntryBox.Text))
            {
                string date = DateTime.Today.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();
                toDoList.Add(listEntryBox.Text.Trim());
                toDoListBox.Items.Add(listEntryBox.Text.Trim() + " - " + date + " - " + time);
                listEntryBox.Clear();
            }
            else
            {
                return;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedItem))
            {
                toDoList.Remove(selectedItem);
                toDoListBox.Items.Remove(selectedItem);
            }
        }

        private void toDoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toDoList.Count <= 0)
            {
                return;
            }
            else
            {
                if (toDoListBox.SelectedItem != null)
                {
                    selectedItem = toDoListBox.SelectedItem.ToString();
                }
                else
                {
                    deleteButton.Enabled = false;
                    return;
                }
            }
            if (!String.IsNullOrEmpty(selectedItem))
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select a list",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                LoadList(path, toDoListBox);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Save",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                if (String.IsNullOrEmpty(path))
                {
                    path = userName + "'s TO-DO List";
                }
                SaveList(path, toDoListBox);
            }
        }
    }
}
