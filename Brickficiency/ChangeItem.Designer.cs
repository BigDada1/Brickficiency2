﻿namespace Brickficiency
{
    partial class ChangeItem
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
            this.typePick = new System.Windows.Forms.ComboBox();
            this.catList = new System.Windows.Forms.ListBox();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.colourGrid = new System.Windows.Forms.DataGridView();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colourGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // typePick
            // 
            this.typePick.DropDownHeight = 170;
            this.typePick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typePick.FormattingEnabled = true;
            this.typePick.IntegralHeight = false;
            this.typePick.Location = new System.Drawing.Point(12, 12);
            this.typePick.Name = "typePick";
            this.typePick.Size = new System.Drawing.Size(170, 28);
            this.typePick.Sorted = true;
            this.typePick.TabIndex = 0;
            this.typePick.SelectedValueChanged += new System.EventHandler(this.typePick_SelectedValueChanged);
            // 
            // catList
            // 
            this.catList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catList.FormattingEnabled = true;
            this.catList.ItemHeight = 16;
            this.catList.Location = new System.Drawing.Point(12, 46);
            this.catList.Name = "catList";
            this.catList.Size = new System.Drawing.Size(170, 356);
            this.catList.Sorted = true;
            this.catList.TabIndex = 1;
            this.catList.SelectedValueChanged += new System.EventHandler(this.catList_SelectedValueChanged);
            this.catList.MouseEnter += new System.EventHandler(this.catList_MouseEnter);
            // 
            // filterBox
            // 
            this.filterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.Location = new System.Drawing.Point(242, 13);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(468, 26);
            this.filterBox.TabIndex = 2;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(820, 427);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(739, 427);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // colourGrid
            // 
            this.colourGrid.AllowUserToAddRows = false;
            this.colourGrid.AllowUserToDeleteRows = false;
            this.colourGrid.AllowUserToResizeColumns = false;
            this.colourGrid.AllowUserToResizeRows = false;
            this.colourGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.colourGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.colourGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colour,
            this.ColourName});
            this.colourGrid.Location = new System.Drawing.Point(716, 13);
            this.colourGrid.MultiSelect = false;
            this.colourGrid.Name = "colourGrid";
            this.colourGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colourGrid.RowHeadersVisible = false;
            this.colourGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.colourGrid.Size = new System.Drawing.Size(178, 401);
            this.colourGrid.StandardTab = true;
            this.colourGrid.TabIndex = 4;
            this.colourGrid.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.colourGrid_CellStateChanged);
            this.colourGrid.MouseEnter += new System.EventHandler(this.colourGrid_MouseEnter);
            // 
            // Colour
            // 
            this.Colour.Frozen = true;
            this.Colour.HeaderText = "Colour";
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            this.Colour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Colour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colour.Width = 45;
            // 
            // ColourName
            // 
            this.ColourName.Frozen = true;
            this.ColourName.HeaderText = "Name";
            this.ColourName.Name = "ColourName";
            this.ColourName.ReadOnly = true;
            this.ColourName.Width = 300;
            // 
            // itemList
            // 
            this.itemList.FullRowSelect = true;
            this.itemList.HideSelection = false;
            this.itemList.Location = new System.Drawing.Point(188, 46);
            this.itemList.MultiSelect = false;
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(522, 368);
            this.itemList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.itemList.TabIndex = 3;
            this.itemList.UseCompatibleStateImageBehavior = false;
            this.itemList.View = System.Windows.Forms.View.Details;
            this.itemList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.itemList_ColumnClick);
            this.itemList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.itemList_DrawColumnHeader);
            this.itemList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.itemList_DrawItem);
            this.itemList.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.itemList_DrawSubItem);
            this.itemList.DoubleClick += new System.EventHandler(this.okButton_Click);
            this.itemList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemList_KeyPress);
            this.itemList.MouseLeave += new System.EventHandler(this.itemList_MouseLeave);
            this.itemList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.itemList_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter:";
            // 
            // ChangeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(906, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.colourGrid);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.catList);
            this.Controls.Add(this.typePick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChangeItem";
            this.Text = "Change Item";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeItem_FormClosing);
            this.Load += new System.EventHandler(this.ChangeItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colourGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typePick;
        private System.Windows.Forms.ListBox catList;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView colourGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColourName;
        private System.Windows.Forms.ListView itemList;
        private System.Windows.Forms.Label label1;
    }
}