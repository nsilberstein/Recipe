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

namespace RecipeWinForm
{
    public partial class frmRecipeDetail : Form
    {
        BizRecipe recobj = new BizRecipe();
        public frmRecipeDetail()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSaveUpdate.Click += BtnSaveUpdate_Click;
        }

       

        private void Save()
        {
            try
            {
                recobj.Save();
            }
            catch(CPUException ex)
            {
                MessageBox.Show(ex.FriendlyMessage, this.Text, MessageBoxButtons.OK);
            }
            this.Close();
          
        }
        private void Delete()
        {
            try
            {
                recobj.Delete();
            }
            catch(CPUException ex)
            {
                MessageBox.Show(ex.FriendlyMessage, this.Text, MessageBoxButtons.OK);
            }
           
            this.Close();
        }
        //FW BindGrid has no references the grids are therefore not formatted nicely.
        private void BindForm()
        {
            this.FormatGrid(gIngredient, "RecipeId");
            this.FormatGrid(gStep, "RecipeId");
        }

        public void ShowForm(int id)
        {
            recobj = BizRecipe.Get(id);
            //recobj = new BizRecipe();
            lstCuisineType.DataSource = DataService.GetCuisineTypeList(true);
            lstCuisineType.ValueMember = "CuisineTypeId";
            lstCuisineType.DisplayMember = "CuisineName";
            lstCuisineType.DataBindings.Add("SelectedValue", recobj, "CuisineTypeId");

            lstUserName.DataSource = DataService.GetUserNameList(true);
            lstUserName.ValueMember = "UserId";
            lstUserName.DisplayMember = "UserName";
            lstUserName.DataBindings.Add("SelectedValue", recobj, "CreatedByUserId");

            txtRecipe.DataBindings.Add("Text", recobj, "RecipeName");
            txtCalories.DataBindings.Add("Text", recobj, "NumCaloriesPerServing");
            lblIngredientText.DataBindings.Add("Text", recobj, "NumofIngredients");
            lblStepText.DataBindings.Add("Text", recobj, "NumofSteps");
            lblDateCreatedText.DataBindings.Add("Text", recobj, "DateCreated");
            lblDatePublishedText.DataBindings.Add("Text", recobj, "DatePublished");
            lblDateArchivedText.DataBindings.Add("Text", recobj, "DateArchived");
            lblRecipeStatusText.DataBindings.Add("Text", recobj, "RecipeStatus");
            gIngredient.DataSource = DataService.GetIngredientList(id);
            gStep.DataSource = DataService.GetStepsList(id);
           
            this.Show();
            
           
        }
        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.RowHeadersWidth = 25;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AllowUserToAddRows = false;
            if (PrimaryKeyFieldName != "")
            {
                gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }
        }



        private void BtnDelete_Click(object? sender, EventArgs e)
        {

            this.Delete();

        }
        private void BtnSaveUpdate_Click(object? sender, EventArgs e)
        {
            this.Save();
           
        }

    }

}


