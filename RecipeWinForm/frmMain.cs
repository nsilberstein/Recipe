using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeBizObjects;
using CPUFramework;
using System.Data.SqlClient;

namespace RecipeWinForm
{
    public partial class frmMain : Form
    {
        string connstring = "";
        public frmMain()
        {
            InitializeComponent();
            BindForm();
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            btnNewRecipe.Click += BtnNewRecipe_Click;

        }

       

        private void BindForm()
        {
            connstring = DataUtility.SetConnectionString("nsilberstein.database.windows.net,1433", "RecipeDB", "nsilbersteinadmin", "CPU123!@#");
            gNumber.DataSource = DataService.GetNumberList();
            gRecipeList.DataSource = DataService.GetRecipeList();
            
            this.FormatGrid(gRecipeList, "RecipeId");
        }


        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.RowHeadersWidth = 25;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AllowUserToAddRows = false;
            if(PrimaryKeyFieldName != "")
            {
                gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }
        }

        private void CreateNewRecipe()
        {
            frmRecipeDetail f = new frmRecipeDetail();
            f.ShowForm(0);
        }
        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gRecipeList.Rows[e.RowIndex].Cells["RecipeId"].Value;
            frmRecipeDetail f = new frmRecipeDetail();
            f.ShowForm(id);

        }
        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            CreateNewRecipe();
        }


    }
}


