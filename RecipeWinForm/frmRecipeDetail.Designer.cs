namespace RecipeWinForm
{
    partial class frmRecipeDetail
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblNumCalories = new System.Windows.Forms.Label();
            this.lblNumIngredient = new System.Windows.Forms.Label();
            this.lblNumStep = new System.Windows.Forms.Label();
            this.gIngredient = new System.Windows.Forms.DataGridView();
            this.gStep = new System.Windows.Forms.DataGridView();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.lblDateCreatedText = new System.Windows.Forms.Label();
            this.lblDatePublishedText = new System.Windows.Forms.Label();
            this.lblDateArchivedText = new System.Windows.Forms.Label();
            this.lblRecipeStatusText = new System.Windows.Forms.Label();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lblIngredientText = new System.Windows.Forms.Label();
            this.lblStepText = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gStep)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 10;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblNumCalories, 1, 0);
            this.tblMain.Controls.Add(this.lblNumIngredient, 2, 0);
            this.tblMain.Controls.Add(this.lblNumStep, 3, 0);
            this.tblMain.Controls.Add(this.gIngredient, 0, 2);
            this.tblMain.Controls.Add(this.gStep, 2, 2);
            this.tblMain.Controls.Add(this.tblButtons, 3, 3);
            this.tblMain.Controls.Add(this.btnSaveUpdate, 1, 3);
            this.tblMain.Controls.Add(this.btnDelete, 2, 3);
            this.tblMain.Controls.Add(this.txtRecipe, 0, 1);
            this.tblMain.Controls.Add(this.txtCalories, 1, 1);
            this.tblMain.Controls.Add(this.lblUserName, 4, 0);
            this.tblMain.Controls.Add(this.label1, 5, 0);
            this.tblMain.Controls.Add(this.lblDateCreated, 6, 0);
            this.tblMain.Controls.Add(this.lblDatePublished, 7, 0);
            this.tblMain.Controls.Add(this.lblDateArchived, 8, 0);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 9, 0);
            this.tblMain.Controls.Add(this.lstCuisineType, 5, 1);
            this.tblMain.Controls.Add(this.lblDateCreatedText, 6, 1);
            this.tblMain.Controls.Add(this.lblDatePublishedText, 7, 1);
            this.tblMain.Controls.Add(this.lblDateArchivedText, 8, 1);
            this.tblMain.Controls.Add(this.lblRecipeStatusText, 9, 1);
            this.tblMain.Controls.Add(this.lstUserName, 4, 1);
            this.tblMain.Controls.Add(this.lblIngredientText, 2, 1);
            this.tblMain.Controls.Add(this.lblStepText, 3, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(74, 105);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumCalories
            // 
            this.lblNumCalories.AutoSize = true;
            this.lblNumCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumCalories.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumCalories.Location = new System.Drawing.Point(83, 0);
            this.lblNumCalories.Name = "lblNumCalories";
            this.lblNumCalories.Size = new System.Drawing.Size(74, 105);
            this.lblNumCalories.TabIndex = 1;
            this.lblNumCalories.Text = "Number of Calories";
            this.lblNumCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumIngredient
            // 
            this.lblNumIngredient.AutoSize = true;
            this.lblNumIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumIngredient.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumIngredient.Location = new System.Drawing.Point(163, 0);
            this.lblNumIngredient.Name = "lblNumIngredient";
            this.lblNumIngredient.Size = new System.Drawing.Size(74, 105);
            this.lblNumIngredient.TabIndex = 2;
            this.lblNumIngredient.Text = "Number of Ingredients";
            this.lblNumIngredient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumStep
            // 
            this.lblNumStep.AutoSize = true;
            this.lblNumStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumStep.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumStep.Location = new System.Drawing.Point(243, 0);
            this.lblNumStep.Name = "lblNumStep";
            this.lblNumStep.Size = new System.Drawing.Size(74, 105);
            this.lblNumStep.TabIndex = 3;
            this.lblNumStep.Text = "Number of Steps";
            this.lblNumStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gIngredient
            // 
            this.gIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.gIngredient, 5);
            this.gIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIngredient.Location = new System.Drawing.Point(3, 178);
            this.gIngredient.Name = "gIngredient";
            this.gIngredient.RowTemplate.Height = 25;
            this.gIngredient.Size = new System.Drawing.Size(394, 169);
            this.gIngredient.TabIndex = 8;
            // 
            // gStep
            // 
            this.gStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.gStep, 5);
            this.gStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gStep.Location = new System.Drawing.Point(403, 178);
            this.gStep.Name = "gStep";
            this.gStep.RowTemplate.Height = 25;
            this.gStep.Size = new System.Drawing.Size(394, 169);
            this.gStep.TabIndex = 9;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.AutoSize = true;
            this.tblButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 3);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButtons.Location = new System.Drawing.Point(457, 353);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(20, 0);
            this.tblButtons.TabIndex = 14;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.AutoSize = true;
            this.btnSaveUpdate.Location = new System.Drawing.Point(83, 353);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(74, 25);
            this.btnSaveUpdate.TabIndex = 16;
            this.btnSaveUpdate.Text = "Save Update";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(163, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 25);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipe.Location = new System.Drawing.Point(3, 108);
            this.txtRecipe.Multiline = true;
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(74, 64);
            this.txtRecipe.TabIndex = 18;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(83, 108);
            this.txtCalories.Multiline = true;
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(74, 64);
            this.txtCalories.TabIndex = 19;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(323, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 105);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(403, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 105);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cuisine Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreated.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateCreated.Location = new System.Drawing.Point(483, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(74, 105);
            this.lblDateCreated.TabIndex = 24;
            this.lblDateCreated.Text = "Date Created";
            this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublished.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatePublished.Location = new System.Drawing.Point(563, 0);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(74, 105);
            this.lblDatePublished.TabIndex = 25;
            this.lblDatePublished.Text = "Date Published";
            this.lblDatePublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.AutoSize = true;
            this.lblDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchived.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateArchived.Location = new System.Drawing.Point(643, 0);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(74, 105);
            this.lblDateArchived.TabIndex = 26;
            this.lblDateArchived.Text = "Date Archived";
            this.lblDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeStatus.Location = new System.Drawing.Point(723, 0);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(74, 105);
            this.lblRecipeStatus.TabIndex = 27;
            this.lblRecipeStatus.Text = "Recipe Status";
            this.lblRecipeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(403, 108);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(74, 23);
            this.lstCuisineType.TabIndex = 28;
            // 
            // lblDateCreatedText
            // 
            this.lblDateCreatedText.AutoSize = true;
            this.lblDateCreatedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreatedText.Location = new System.Drawing.Point(483, 105);
            this.lblDateCreatedText.Name = "lblDateCreatedText";
            this.lblDateCreatedText.Size = new System.Drawing.Size(74, 70);
            this.lblDateCreatedText.TabIndex = 29;
            // 
            // lblDatePublishedText
            // 
            this.lblDatePublishedText.AutoSize = true;
            this.lblDatePublishedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublishedText.Location = new System.Drawing.Point(563, 105);
            this.lblDatePublishedText.Name = "lblDatePublishedText";
            this.lblDatePublishedText.Size = new System.Drawing.Size(74, 70);
            this.lblDatePublishedText.TabIndex = 30;
            // 
            // lblDateArchivedText
            // 
            this.lblDateArchivedText.AutoSize = true;
            this.lblDateArchivedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchivedText.Location = new System.Drawing.Point(643, 105);
            this.lblDateArchivedText.Name = "lblDateArchivedText";
            this.lblDateArchivedText.Size = new System.Drawing.Size(74, 70);
            this.lblDateArchivedText.TabIndex = 31;
            // 
            // lblRecipeStatusText
            // 
            this.lblRecipeStatusText.AutoSize = true;
            this.lblRecipeStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatusText.Location = new System.Drawing.Point(723, 105);
            this.lblRecipeStatusText.Name = "lblRecipeStatusText";
            this.lblRecipeStatusText.Size = new System.Drawing.Size(74, 70);
            this.lblRecipeStatusText.TabIndex = 32;
            // 
            // lstUserName
            // 
            this.lstUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(323, 108);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(74, 23);
            this.lstUserName.TabIndex = 33;
            // 
            // lblIngredientText
            // 
            this.lblIngredientText.AutoSize = true;
            this.lblIngredientText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredientText.Location = new System.Drawing.Point(163, 105);
            this.lblIngredientText.Name = "lblIngredientText";
            this.lblIngredientText.Size = new System.Drawing.Size(74, 70);
            this.lblIngredientText.TabIndex = 34;
            // 
            // lblStepText
            // 
            this.lblStepText.AutoSize = true;
            this.lblStepText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStepText.Location = new System.Drawing.Point(243, 105);
            this.lblStepText.Name = "lblStepText";
            this.lblStepText.Size = new System.Drawing.Size(74, 70);
            this.lblStepText.TabIndex = 35;
            // 
            // frmRecipeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipeDetail";
            this.Text = "Recipe Detail";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblNumCalories;
        private Label lblNumIngredient;
        private Label lblNumStep;
        private DataGridView gIngredient;
        private DataGridView gStep;
        private TableLayoutPanel tblButtons;
        private Button btnSaveUpdate;
        private Button btnDelete;
        private TextBox txtRecipe;
        private TextBox txtCalories;
        private Label lblUserName;
        private Label label1;
        private Label lblDateCreated;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblRecipeStatus;
        private ComboBox lstCuisineType;
        private Label lblDateCreatedText;
        private Label lblDatePublishedText;
        private Label lblDateArchivedText;
        private Label lblRecipeStatusText;
        private ComboBox lstUserName;
        private Label lblIngredientText;
        private Label lblStepText;
    }
}