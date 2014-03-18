using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfacePractice
{
    public partial class Form1 : Form
    {
        private ObjectDatabase<Person> personDb = new ObjectDatabase<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbFirstName.Select();
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            tbUserName.Text = tbFirstName.Text + "." + tbLastName.Text;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string[] tbFields = new string[] 
            {
                tbFirstName.Text,
                tbLastName.Text,
                tbUserName.Text,
                mtbPassword.Text
            };

            personDb.Add(new Person(tbFields));

            clbUsers.Items.Clear();

            for (int i = 0; i < personDb.Count(); i++)
            {
                clbUsers.Items.Add(personDb.Query(i).Name);
            }            
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbUserName.Text = "";
            mtbPassword.Text = "";
            mtbConfirmPassword.Text = "";
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            int index = clbUsers.SelectedIndex;
            Person person = personDb.Query(index);

            lbDetails.Items.AddRange(person.ToStringArray());
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            int index = clbUsers.SelectedIndex;
            personDb.Delete(index);
            clbUsers.Items.RemoveAt(index);
            clbUsers.Refresh();
        } 

        class Person
        {
            string firstName, lastName, userName, password;

            public string Name
            {
                get 
                {
                    return firstName + "" + lastName;
                }
            }

            public Person(string[] tbFields)
            {
                this.firstName = tbFields[0];
                this.lastName = tbFields[1];
                this.userName = tbFields[2];
                this.password = tbFields[3];
            }

            public string[] ToStringArray()
            {
                return new string[] 
                {
                    "First Name: " + firstName,
                    "Last Name: " + lastName,
                    "Username: " + userName,
                    "Password: " + password
                }; 
            }
        }    
    }    
}
