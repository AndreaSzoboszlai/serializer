using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializer
{
    public partial class personsForm : MetroFramework.Forms.MetroForm
    {
        int serialNum = 0;
        Person person;
        Serializer serializer;
        public personsForm()
        {
            InitializeComponent();
            serializer = new Serializer();
            getLastData();
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text) && !string.IsNullOrWhiteSpace(addressBox.Text) && !string.IsNullOrWhiteSpace(phoneBox.Text))
            {
                serialNum += 1;
                person = new Person(nameBox.Text, addressBox.Text, phoneBox.Text, serialNum);
                person.Serialize();
                MessageBox.Show("Person saved.");
            }
            else if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Name field is not filled out");
            }
            else if (string.IsNullOrWhiteSpace(addressBox.Text))
            {
                MessageBox.Show("Address field is not filled out");
            }
            else if (string.IsNullOrWhiteSpace(phoneBox.Text))
            {
                MessageBox.Show("Phone field is not filled out");
            }

        }
        
        private void getLastData()
        {
            try
            {
                person = serializer.DeSerialize();
                serialNum = person.serialNum;
                nameBox.Text = person.name;
                addressBox.Text = person.address;
                phoneBox.Text = person.phoneNumber;
            }
            catch
            {
                MessageBox.Show("There wan't any person serialized yet.");
            }
        }

        private void RefreshForm()
        {
            try
            {
                person = serializer.DeSerialize(serialNum);
                nameBox.Text = person.name;
                addressBox.Text = person.address;
                phoneBox.Text = person.phoneNumber;
            }
            catch
            {
                MessageBox.Show("There wan't any person serialized yet.");
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            serialNum = serialNum + 1;
            RefreshForm();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            serialNum = serialNum - 1;
            RefreshForm();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            serialNum = 1;
            RefreshForm();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            getLastData();
        }
    }
}
