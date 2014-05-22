﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StartKoinoxristaProject
{
    public partial class comboBoxInsideDataGridView : Form
    {
        public comboBoxInsideDataGridView()
        {
            InitializeComponent();
        }

        private void comboBoxInsideDataGridView_Load(object sender, EventArgs e)
        {
            SetUpDataGridView1();
        }

        private void SetUpDataGridView1()
        {
            // Virtual mode is turned on so that the 
            // unbound DataGridViewCheckBoxColumn will 
            // keep its state when the bound columns are 
            // sorted.       
            // DataGridView1.VirtualMode = true;
            DataGridView1.AutoSize = true;
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = Populate("SELECT * FROM dapanes");
            /*DataGridView1.TopLeftHeaderCell.Value = "Dapanes";
            DataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;*/

            // The below autogenerated column is removed so  
            // a DataGridViewComboboxColumn could be used instead.
            /*DataGridView1.Columns.Remove(ColumnName.costCategory.ToString());
            DataGridView1.Columns.Remove(ColumnName.costDescription.ToString());
            DataGridView1.Columns.Remove(ColumnName.Cost.ToString());*/

            // AddLinkColumn();
            AddComboBoxColumns();
            // AddButtonColumn();
            // AddOutOfOfficeColumn();
        }

        private void AddComboBoxColumns()
        {
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = CreateComboBoxColumn();
            SetAlternateChoicesUsingDataSource(comboboxColumn);
            //comboboxColumn.HeaderText = "costCategory (via DataSource property)";
            DataGridView1.Columns.Insert(0, comboboxColumn);

            /*comboboxColumn = CreateComboBoxColumn();
            SetAlternateChoicesUsingItems(comboboxColumn);
            comboboxColumn.HeaderText = "TitleOfCourtesy (via Items property)";
            // Tack this example column onto the end.
            DataGridView1.Columns.Add(comboboxColumn);*/
        }

        private DataGridViewComboBoxColumn CreateComboBoxColumn()
        {
            DataGridViewComboBoxColumn column =
                new DataGridViewComboBoxColumn();
            column.DataPropertyName = ColumnName.costCategory.ToString();
                column.HeaderText = ColumnName.costCategory.ToString();
                /*column.DropDownWidth = 160;
                column.Width = 90;
                column.MaxDropDownItems = 3;
                column.FlatStyle = FlatStyle.Flat;*/
            return column;
        }

        private void SetAlternateChoicesUsingDataSource(DataGridViewComboBoxColumn comboboxColumn)
        {
            {
                comboboxColumn.DataSource = RetrieveAlternativeTitles();
                comboboxColumn.ValueMember = ColumnName.costCategory.ToString();
                comboboxColumn.DisplayMember = ColumnName.costCategory.ToString();
            }
        }

        private DataTable RetrieveAlternativeTitles()
        {
            return Populate("SELECT distinct costCategory FROM dapanes");
        }

        // Using an enum provides some abstraction between column index 
        // and column name along with compile time checking, and gives 
        // a handy place to store the column names. 
        enum ColumnName
        {
            costCategory,
            costDescription,
            Cost
        };

        string connectionString =
        @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";

        private DataTable Populate(string sqlCommand)
        {
            SqlConnection northwindConnection = new SqlConnection(connectionString);
            northwindConnection.Open();

            SqlCommand command = new SqlCommand(sqlCommand, northwindConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
    }
}
