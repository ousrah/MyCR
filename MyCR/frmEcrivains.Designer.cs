
namespace MyCR
{
    partial class frmEcrivains
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEcrivains));
            System.Windows.Forms.Label nUMECRLabel;
            System.Windows.Forms.Label pRENOMECRLabel;
            System.Windows.Forms.Label nOMECRLabel;
            System.Windows.Forms.Label pAYSECRLabel;
            System.Windows.Forms.Label lANGUECRLabel;
            this.librairieDataSet = new MyCR.librairieDataSet();
            this.eCRIVAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCRIVAINTableAdapter = new MyCR.librairieDataSetTableAdapters.ECRIVAINTableAdapter();
            this.tableAdapterManager = new MyCR.librairieDataSetTableAdapters.TableAdapterManager();
            this.eCRIVAINBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eCRIVAINBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eCRIVAINListBox = new System.Windows.Forms.ListBox();
            this.nUMECRTextBox = new System.Windows.Forms.TextBox();
            this.pRENOMECRTextBox = new System.Windows.Forms.TextBox();
            this.nOMECRTextBox = new System.Windows.Forms.TextBox();
            this.pAYSECRTextBox = new System.Windows.Forms.TextBox();
            this.lANGUECRTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nUMECRLabel = new System.Windows.Forms.Label();
            pRENOMECRLabel = new System.Windows.Forms.Label();
            nOMECRLabel = new System.Windows.Forms.Label();
            pAYSECRLabel = new System.Windows.Forms.Label();
            lANGUECRLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librairieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCRIVAINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCRIVAINBindingNavigator)).BeginInit();
            this.eCRIVAINBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // librairieDataSet
            // 
            this.librairieDataSet.DataSetName = "librairieDataSet";
            this.librairieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eCRIVAINBindingSource
            // 
            this.eCRIVAINBindingSource.DataMember = "ECRIVAIN";
            this.eCRIVAINBindingSource.DataSource = this.librairieDataSet;
            // 
            // eCRIVAINTableAdapter
            // 
            this.eCRIVAINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATALOGUETableAdapter = null;
            this.tableAdapterManager.CLASSIFICATIONTableAdapter = null;
            this.tableAdapterManager.DEPOTTableAdapter = null;
            this.tableAdapterManager.ECRIRETableAdapter = null;
            this.tableAdapterManager.ECRIVAINTableAdapter = this.eCRIVAINTableAdapter;
            this.tableAdapterManager.EDITEURTableAdapter = null;
            this.tableAdapterManager.OUVRAGETableAdapter = null;
            this.tableAdapterManager.STOCKERTableAdapter = null;
            this.tableAdapterManager.TARIFERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyCR.librairieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eCRIVAINBindingNavigator
            // 
            this.eCRIVAINBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eCRIVAINBindingNavigator.BindingSource = this.eCRIVAINBindingSource;
            this.eCRIVAINBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eCRIVAINBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eCRIVAINBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eCRIVAINBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eCRIVAINBindingNavigatorSaveItem});
            this.eCRIVAINBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eCRIVAINBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eCRIVAINBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eCRIVAINBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eCRIVAINBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eCRIVAINBindingNavigator.Name = "eCRIVAINBindingNavigator";
            this.eCRIVAINBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eCRIVAINBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.eCRIVAINBindingNavigator.TabIndex = 0;
            this.eCRIVAINBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // eCRIVAINBindingNavigatorSaveItem
            // 
            this.eCRIVAINBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eCRIVAINBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eCRIVAINBindingNavigatorSaveItem.Image")));
            this.eCRIVAINBindingNavigatorSaveItem.Name = "eCRIVAINBindingNavigatorSaveItem";
            this.eCRIVAINBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.eCRIVAINBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.eCRIVAINBindingNavigatorSaveItem.Click += new System.EventHandler(this.eCRIVAINBindingNavigatorSaveItem_Click);
            // 
            // eCRIVAINListBox
            // 
            this.eCRIVAINListBox.DataSource = this.eCRIVAINBindingSource;
            this.eCRIVAINListBox.DisplayMember = "PRENOMECR";
            this.eCRIVAINListBox.FormattingEnabled = true;
            this.eCRIVAINListBox.ItemHeight = 16;
            this.eCRIVAINListBox.Location = new System.Drawing.Point(51, 89);
            this.eCRIVAINListBox.Name = "eCRIVAINListBox";
            this.eCRIVAINListBox.Size = new System.Drawing.Size(300, 212);
            this.eCRIVAINListBox.TabIndex = 1;
            this.eCRIVAINListBox.ValueMember = "NUMECR";
            // 
            // nUMECRLabel
            // 
            nUMECRLabel.AutoSize = true;
            nUMECRLabel.Location = new System.Drawing.Point(463, 105);
            nUMECRLabel.Name = "nUMECRLabel";
            nUMECRLabel.Size = new System.Drawing.Size(71, 17);
            nUMECRLabel.TabIndex = 2;
            nUMECRLabel.Text = "NUMECR:";
            // 
            // nUMECRTextBox
            // 
            this.nUMECRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eCRIVAINBindingSource, "NUMECR", true));
            this.nUMECRTextBox.Location = new System.Drawing.Point(569, 102);
            this.nUMECRTextBox.Name = "nUMECRTextBox";
            this.nUMECRTextBox.Size = new System.Drawing.Size(100, 22);
            this.nUMECRTextBox.TabIndex = 3;
            // 
            // pRENOMECRLabel
            // 
            pRENOMECRLabel.AutoSize = true;
            pRENOMECRLabel.Location = new System.Drawing.Point(463, 133);
            pRENOMECRLabel.Name = "pRENOMECRLabel";
            pRENOMECRLabel.Size = new System.Drawing.Size(100, 17);
            pRENOMECRLabel.TabIndex = 4;
            pRENOMECRLabel.Text = "PRENOMECR:";
            // 
            // pRENOMECRTextBox
            // 
            this.pRENOMECRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eCRIVAINBindingSource, "PRENOMECR", true));
            this.pRENOMECRTextBox.Location = new System.Drawing.Point(569, 130);
            this.pRENOMECRTextBox.Name = "pRENOMECRTextBox";
            this.pRENOMECRTextBox.Size = new System.Drawing.Size(100, 22);
            this.pRENOMECRTextBox.TabIndex = 5;
            // 
            // nOMECRLabel
            // 
            nOMECRLabel.AutoSize = true;
            nOMECRLabel.Location = new System.Drawing.Point(463, 161);
            nOMECRLabel.Name = "nOMECRLabel";
            nOMECRLabel.Size = new System.Drawing.Size(72, 17);
            nOMECRLabel.TabIndex = 6;
            nOMECRLabel.Text = "NOMECR:";
            // 
            // nOMECRTextBox
            // 
            this.nOMECRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eCRIVAINBindingSource, "NOMECR", true));
            this.nOMECRTextBox.Location = new System.Drawing.Point(569, 158);
            this.nOMECRTextBox.Name = "nOMECRTextBox";
            this.nOMECRTextBox.Size = new System.Drawing.Size(100, 22);
            this.nOMECRTextBox.TabIndex = 7;
            // 
            // pAYSECRLabel
            // 
            pAYSECRLabel.AutoSize = true;
            pAYSECRLabel.Location = new System.Drawing.Point(463, 189);
            pAYSECRLabel.Name = "pAYSECRLabel";
            pAYSECRLabel.Size = new System.Drawing.Size(76, 17);
            pAYSECRLabel.TabIndex = 8;
            pAYSECRLabel.Text = "PAYSECR:";
            // 
            // pAYSECRTextBox
            // 
            this.pAYSECRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eCRIVAINBindingSource, "PAYSECR", true));
            this.pAYSECRTextBox.Location = new System.Drawing.Point(569, 186);
            this.pAYSECRTextBox.Name = "pAYSECRTextBox";
            this.pAYSECRTextBox.Size = new System.Drawing.Size(100, 22);
            this.pAYSECRTextBox.TabIndex = 9;
            // 
            // lANGUECRLabel
            // 
            lANGUECRLabel.AutoSize = true;
            lANGUECRLabel.Location = new System.Drawing.Point(463, 217);
            lANGUECRLabel.Name = "lANGUECRLabel";
            lANGUECRLabel.Size = new System.Drawing.Size(88, 17);
            lANGUECRLabel.TabIndex = 10;
            lANGUECRLabel.Text = "LANGUECR:";
            // 
            // lANGUECRTextBox
            // 
            this.lANGUECRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eCRIVAINBindingSource, "LANGUECR", true));
            this.lANGUECRTextBox.Location = new System.Drawing.Point(569, 214);
            this.lANGUECRTextBox.Name = "lANGUECRTextBox";
            this.lANGUECRTextBox.Size = new System.Drawing.Size(100, 22);
            this.lANGUECRTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "imprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEcrivains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(nUMECRLabel);
            this.Controls.Add(this.nUMECRTextBox);
            this.Controls.Add(pRENOMECRLabel);
            this.Controls.Add(this.pRENOMECRTextBox);
            this.Controls.Add(nOMECRLabel);
            this.Controls.Add(this.nOMECRTextBox);
            this.Controls.Add(pAYSECRLabel);
            this.Controls.Add(this.pAYSECRTextBox);
            this.Controls.Add(lANGUECRLabel);
            this.Controls.Add(this.lANGUECRTextBox);
            this.Controls.Add(this.eCRIVAINListBox);
            this.Controls.Add(this.eCRIVAINBindingNavigator);
            this.Name = "frmEcrivains";
            this.Text = "frmEcrivains";
            this.Load += new System.EventHandler(this.frmEcrivains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librairieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCRIVAINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCRIVAINBindingNavigator)).EndInit();
            this.eCRIVAINBindingNavigator.ResumeLayout(false);
            this.eCRIVAINBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private librairieDataSet librairieDataSet;
        private System.Windows.Forms.BindingSource eCRIVAINBindingSource;
        private librairieDataSetTableAdapters.ECRIVAINTableAdapter eCRIVAINTableAdapter;
        private librairieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eCRIVAINBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eCRIVAINBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox eCRIVAINListBox;
        private System.Windows.Forms.TextBox nUMECRTextBox;
        private System.Windows.Forms.TextBox pRENOMECRTextBox;
        private System.Windows.Forms.TextBox nOMECRTextBox;
        private System.Windows.Forms.TextBox pAYSECRTextBox;
        private System.Windows.Forms.TextBox lANGUECRTextBox;
        private System.Windows.Forms.Button button1;
    }
}