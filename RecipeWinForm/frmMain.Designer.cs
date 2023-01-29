namespace RecipeWinForm
{
    partial class frmMain
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gNumber = new System.Windows.Forms.DataGridView();
            this.gRecipeList = new System.Windows.Forms.DataGridView();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeList)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.gNumber, 0, 0);
            this.tblMain.Controls.Add(this.gRecipeList, 1, 0);
            this.tblMain.Controls.Add(this.btnNewRecipe, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // gNumber
            // 
            this.gNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gNumber.Location = new System.Drawing.Point(3, 3);
            this.gNumber.Name = "gNumber";
            this.gNumber.ReadOnly = true;
            this.gNumber.RowTemplate.Height = 25;
            this.gNumber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gNumber.Size = new System.Drawing.Size(394, 219);
            this.gNumber.TabIndex = 0;
            // 
            // gRecipeList
            // 
            this.gRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeList.Location = new System.Drawing.Point(403, 3);
            this.gRecipeList.Name = "gRecipeList";
            this.gRecipeList.ReadOnly = true;
            this.gRecipeList.RowTemplate.Height = 25;
            this.gRecipeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gRecipeList.Size = new System.Drawing.Size(394, 219);
            this.gRecipeList.TabIndex = 1;
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.AutoSize = true;
            this.btnNewRecipe.Location = new System.Drawing.Point(3, 228);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(94, 25);
            this.btnNewRecipe.TabIndex = 2;
            this.btnNewRecipe.Text = "NewRecipe";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gNumber;
        private DataGridView gRecipeList;
        private Button btnNewRecipe;
    }
}