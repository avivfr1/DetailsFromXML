using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DetailsFromXML
{
    public partial class Form1 : Form
    {
        static DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            LoadToDataTable();
            LoadTable(false);
        }

        public void LoadToDataTable()
        {
            table.Columns.Add("Kod", typeof(String));
            table.Columns.Add("NameOfProduct", typeof(String));
            table.Columns.Add("BarKod", typeof(String));
        }

        public void LoadTable(bool withFilter)
        {
            using (XmlReader reader = XmlReader.Create(Directory.GetCurrentDirectory() + @"\xml_ex.xml"))
            {
                if (!withFilter)
                {
                    while (reader.Read())
                    {
                        if (reader.Name.Equals("row"))
                        {
                            string Kod = reader.GetAttribute("Kod");
                            string Nm = reader.GetAttribute("Nm");
                            string BarKod = reader.GetAttribute("BarKod");
                            table.Rows.Add(Kod, Nm, BarKod);
                        }
                    }

                    dataGridViewTable.DataSource = table;
                }

                else
                {
                    if (!textBoxKod.Text.Equals("") && !textBoxName.Text.Equals(""))
                    {
                        table.DefaultView.RowFilter = "NameOfProduct Like '%" + textBoxName.Text + "%' AND " +
"Kod = '" + textBoxKod.Text + "'";
                    }

                    else if (textBoxKod.Text.Equals(""))
                    {
                        table.DefaultView.RowFilter = "NameOfProduct Like '%" + textBoxName.Text + "%'";
                        
                    }

                    else
                    {
                        table.DefaultView.RowFilter = "Kod = '" + textBoxKod.Text + "'";
                    }
                }
            }
        }

        private void dataGridViewTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewTable.Sort(dataGridViewTable.Columns[e.ColumnIndex], ListSortDirection.Descending);

            foreach (DataGridViewColumn column in dataGridViewTable.Columns)
            {
                if (column.Index != e.ColumnIndex)
                {
                    dataGridViewTable.Columns[column.Index].DefaultCellStyle.ForeColor = Color.Black;
                }

                else
                {
                    dataGridViewTable.Columns[column.Index].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
            
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (textBoxKod.Text.Equals("") && textBoxName.Text.Equals(""))
            {
                MessageBox.Show("You need to enter at least one parameter for filtering!", "ERROR");
            }

            else
            {
                LoadTable(true);
            }
        }
    }
}
