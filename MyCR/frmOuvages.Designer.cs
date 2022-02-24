
namespace MyCR
{
    partial class frmOuvages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOuvages));
            System.Windows.Forms.Label nUMOUVRLabel;
            System.Windows.Forms.Label nOMOUVRLabel;
            System.Windows.Forms.Label aNNEEPARULabel;
            System.Windows.Forms.Label nUMRUBLabel;
            System.Windows.Forms.Label nOMEDLabel;
            this.librairieDataSet = new MyCR.librairieDataSet();
            this.oUVRAGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oUVRAGETableAdapter = new MyCR.librairieDataSetTableAdapters.OUVRAGETableAdapter();
            this.tableAdapterManager = new MyCR.librairieDataSetTableAdapters.TableAdapterManager();
            this.oUVRAGEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oUVRAGEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oUVRAGEListBox = new System.Windows.Forms.ListBox();
            this.nUMOUVRTextBox = new System.Windows.Forms.TextBox();
            this.nOMOUVRTextBox = new System.Windows.Forms.TextBox();
            this.aNNEEPARUTextBox = new System.Windows.Forms.TextBox();
            this.nUMRUBTextBox = new System.Windows.Forms.TextBox();
            this.nOMEDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nUMOUVRLabel = new System.Windows.Forms.Label();
            nOMOUVRLabel = new System.Windows.Forms.Label();
            aNNEEPARULabel = new System.Windows.Forms.Label();
            nUMRUBLabel = new System.Windows.Forms.Label();
            nOMEDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librairieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUVRAGEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUVRAGEBindingNavigator)).BeginInit();
            this.oUVRAGEBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // librairieDataSet
            // 
            this.librairieDataSet.DataSetName = "librairieDataSet";
            this.librairieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oUVRAGEBindingSource
            // 
            this.oUVRAGEBindingSource.DataMember = "OUVRAGE";
            this.oUVRAGEBindingSource.DataSource = this.librairieDataSet;
            // 
            // oUVRAGETableAdapter
            // 
            this.oUVRAGETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATALOGUETableAdapter = null;
            this.tableAdapterManager.CLASSIFICATIONTableAdapter = null;
            this.tableAdapterManager.DEPOTTableAdapter = null;
            this.tableAdapterManager.ECRIRETableAdapter = null;
            this.tableAdapterManager.ECRIVAINTableAdapter = null;
            this.tableAdapterManager.EDITEURTableAdapter = null;
            this.tableAdapterManager.OUVRAGETableAdapter = this.oUVRAGETableAdapter;
            this.tableAdapterManager.STOCKERTableAdapter = null;
            this.tableAdapterManager.TARIFERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyCR.librairieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oUVRAGEBindingNavigator
            // 
            this.oUVRAGEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oUVRAGEBindingNavigator.BindingSource = this.oUVRAGEBindingSource;
            this.oUVRAGEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oUVRAGEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oUVRAGEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oUVRAGEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oUVRAGEBindingNavigatorSaveItem});
            this.oUVRAGEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oUVRAGEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oUVRAGEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oUVRAGEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oUVRAGEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oUVRAGEBindingNavigator.Name = "oUVRAGEBindingNavigator";
            this.oUVRAGEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oUVRAGEBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.oUVRAGEBindingNavigator.TabIndex = 0;
            this.oUVRAGEBindingNavigator.Text = "bindingNavigator1";
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
            // oUVRAGEBindingNavigatorSaveItem
            // 
            this.oUVRAGEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oUVRAGEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oUVRAGEBindingNavigatorSaveItem.Image")));
            this.oUVRAGEBindingNavigatorSaveItem.Name = "oUVRAGEBindingNavigatorSaveItem";
            this.oUVRAGEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.oUVRAGEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.oUVRAGEBindingNavigatorSaveItem.Click += new System.EventHandler(this.oUVRAGEBindingNavigatorSaveItem_Click);
            // 
            // oUVRAGEListBox
            // 
            this.oUVRAGEListBox.DataSource = this.oUVRAGEBindingSource;
            this.oUVRAGEListBox.DisplayMember = "NOMOUVR";
            this.oUVRAGEListBox.FormattingEnabled = true;
            this.oUVRAGEListBox.ItemHeight = 16;
            this.oUVRAGEListBox.Location = new System.Drawing.Point(12, 68);
            this.oUVRAGEListBox.Name = "oUVRAGEListBox";
            this.oUVRAGEListBox.Size = new System.Drawing.Size(300, 292);
            this.oUVRAGEListBox.TabIndex = 1;
            this.oUVRAGEListBox.ValueMember = "NUMOUVR";
            // 
            // nUMOUVRLabel
            // 
            nUMOUVRLabel.AutoSize = true;
            nUMOUVRLabel.Location = new System.Drawing.Point(432, 119);
            nUMOUVRLabel.Name = "nUMOUVRLabel";
            nUMOUVRLabel.Size = new System.Drawing.Size(83, 17);
            nUMOUVRLabel.TabIndex = 2;
            nUMOUVRLabel.Text = "NUMOUVR:";
            // 
            // nUMOUVRTextBox
            // 
            this.nUMOUVRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oUVRAGEBindingSource, "NUMOUVR", true));
            this.nUMOUVRTextBox.Location = new System.Drawing.Point(535, 116);
            this.nUMOUVRTextBox.Name = "nUMOUVRTextBox";
            this.nUMOUVRTextBox.Size = new System.Drawing.Size(100, 22);
            this.nUMOUVRTextBox.TabIndex = 3;
            // 
            // nOMOUVRLabel
            // 
            nOMOUVRLabel.AutoSize = true;
            nOMOUVRLabel.Location = new System.Drawing.Point(432, 147);
            nOMOUVRLabel.Name = "nOMOUVRLabel";
            nOMOUVRLabel.Size = new System.Drawing.Size(84, 17);
            nOMOUVRLabel.TabIndex = 4;
            nOMOUVRLabel.Text = "NOMOUVR:";
            // 
            // nOMOUVRTextBox
            // 
            this.nOMOUVRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oUVRAGEBindingSource, "NOMOUVR", true));
            this.nOMOUVRTextBox.Location = new System.Drawing.Point(535, 144);
            this.nOMOUVRTextBox.Name = "nOMOUVRTextBox";
            this.nOMOUVRTextBox.Size = new System.Drawing.Size(100, 22);
            this.nOMOUVRTextBox.TabIndex = 5;
            // 
            // aNNEEPARULabel
            // 
            aNNEEPARULabel.AutoSize = true;
            aNNEEPARULabel.Location = new System.Drawing.Point(432, 175);
            aNNEEPARULabel.Name = "aNNEEPARULabel";
            aNNEEPARULabel.Size = new System.Drawing.Size(97, 17);
            aNNEEPARULabel.TabIndex = 6;
            aNNEEPARULabel.Text = "ANNEEPARU:";
            // 
            // aNNEEPARUTextBox
            // 
            this.aNNEEPARUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oUVRAGEBindingSource, "ANNEEPARU", true));
            this.aNNEEPARUTextBox.Location = new System.Drawing.Point(535, 172);
            this.aNNEEPARUTextBox.Name = "aNNEEPARUTextBox";
            this.aNNEEPARUTextBox.Size = new System.Drawing.Size(100, 22);
            this.aNNEEPARUTextBox.TabIndex = 7;
            // 
            // nUMRUBLabel
            // 
            nUMRUBLabel.AutoSize = true;
            nUMRUBLabel.Location = new System.Drawing.Point(432, 203);
            nUMRUBLabel.Name = "nUMRUBLabel";
            nUMRUBLabel.Size = new System.Drawing.Size(72, 17);
            nUMRUBLabel.TabIndex = 8;
            nUMRUBLabel.Text = "NUMRUB:";
            // 
            // nUMRUBTextBox
            // 
            this.nUMRUBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oUVRAGEBindingSource, "NUMRUB", true));
            this.nUMRUBTextBox.Location = new System.Drawing.Point(535, 200);
            this.nUMRUBTextBox.Name = "nUMRUBTextBox";
            this.nUMRUBTextBox.Size = new System.Drawing.Size(100, 22);
            this.nUMRUBTextBox.TabIndex = 9;
            // 
            // nOMEDLabel
            // 
            nOMEDLabel.AutoSize = true;
            nOMEDLabel.Location = new System.Drawing.Point(432, 231);
            nOMEDLabel.Name = "nOMEDLabel";
            nOMEDLabel.Size = new System.Drawing.Size(63, 17);
            nOMEDLabel.TabIndex = 10;
            nOMEDLabel.Text = "NOMED:";
            // 
            // nOMEDTextBox
            // 
            this.nOMEDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oUVRAGEBindingSource, "NOMED", true));
            this.nOMEDTextBox.Location = new System.Drawing.Point(535, 228);
            this.nOMEDTextBox.Name = "nOMEDTextBox";
            this.nOMEDTextBox.Size = new System.Drawing.Size(100, 22);
            this.nOMEDTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "imprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOuvages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(nUMOUVRLabel);
            this.Controls.Add(this.nUMOUVRTextBox);
            this.Controls.Add(nOMOUVRLabel);
            this.Controls.Add(this.nOMOUVRTextBox);
            this.Controls.Add(aNNEEPARULabel);
            this.Controls.Add(this.aNNEEPARUTextBox);
            this.Controls.Add(nUMRUBLabel);
            this.Controls.Add(this.nUMRUBTextBox);
            this.Controls.Add(nOMEDLabel);
            this.Controls.Add(this.nOMEDTextBox);
            this.Controls.Add(this.oUVRAGEListBox);
            this.Controls.Add(this.oUVRAGEBindingNavigator);
            this.Name = "frmOuvages";
            this.Text = "frmOuvages";
            this.Load += new System.EventHandler(this.frmOuvages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librairieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUVRAGEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUVRAGEBindingNavigator)).EndInit();
            this.oUVRAGEBindingNavigator.ResumeLayout(false);
            this.oUVRAGEBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private librairieDataSet librairieDataSet;
        private System.Windows.Forms.BindingSource oUVRAGEBindingSource;
        private librairieDataSetTableAdapters.OUVRAGETableAdapter oUVRAGETableAdapter;
        private librairieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oUVRAGEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oUVRAGEBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox oUVRAGEListBox;
        private System.Windows.Forms.TextBox nUMOUVRTextBox;
        private System.Windows.Forms.TextBox nOMOUVRTextBox;
        private System.Windows.Forms.TextBox aNNEEPARUTextBox;
        private System.Windows.Forms.TextBox nUMRUBTextBox;
        private System.Windows.Forms.TextBox nOMEDTextBox;
        private System.Windows.Forms.Button button1;
    }
}