﻿
namespace ServiTec.Wind
{
    partial class ProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            this.listadeProductosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listadeProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadeProductosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listadeProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingNavigator)).BeginInit();
            this.listadeProductosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listadeProductosBindingNavigator
            // 
            this.listadeProductosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
<<<<<<< HEAD
=======
            this.listadeProductosBindingNavigator.BackColor = System.Drawing.Color.Aqua;
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.listadeProductosBindingNavigator.BindingSource = this.listadeProductosBindingSource;
            this.listadeProductosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeProductosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listadeProductosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listadeProductosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listadeProductosBindingNavigatorSaveItem});
            this.listadeProductosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeProductosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeProductosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeProductosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeProductosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeProductosBindingNavigator.Name = "listadeProductosBindingNavigator";
            this.listadeProductosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
<<<<<<< HEAD
            this.listadeProductosBindingNavigator.Size = new System.Drawing.Size(800, 27);
=======
            this.listadeProductosBindingNavigator.Size = new System.Drawing.Size(600, 27);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.listadeProductosBindingNavigator.TabIndex = 0;
            this.listadeProductosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
<<<<<<< HEAD
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
=======
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // listadeProductosBindingSource
            // 
            this.listadeProductosBindingSource.DataSource = typeof(ServiTec.Database.Models.Producto);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
<<<<<<< HEAD
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
=======
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
<<<<<<< HEAD
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
=======
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
<<<<<<< HEAD
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
=======
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
<<<<<<< HEAD
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
=======
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
<<<<<<< HEAD
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
=======
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
<<<<<<< HEAD
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
=======
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
<<<<<<< HEAD
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
=======
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listadeProductosBindingNavigatorSaveItem
            // 
            this.listadeProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeProductosBindingNavigatorSaveItem.Enabled = false;
            this.listadeProductosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeProductosBindingNavigatorSaveItem.Image")));
            this.listadeProductosBindingNavigatorSaveItem.Name = "listadeProductosBindingNavigatorSaveItem";
<<<<<<< HEAD
            this.listadeProductosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
=======
            this.listadeProductosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.listadeProductosBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // listadeProductosDataGridView
            // 
            this.listadeProductosDataGridView.AutoGenerateColumns = false;
<<<<<<< HEAD
=======
            this.listadeProductosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.listadeProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.listadeProductosDataGridView.DataSource = this.listadeProductosBindingSource;
<<<<<<< HEAD
            this.listadeProductosDataGridView.Location = new System.Drawing.Point(63, 71);
            this.listadeProductosDataGridView.Name = "listadeProductosDataGridView";
            this.listadeProductosDataGridView.RowHeadersWidth = 51;
            this.listadeProductosDataGridView.RowTemplate.Height = 24;
            this.listadeProductosDataGridView.Size = new System.Drawing.Size(678, 339);
=======
            this.listadeProductosDataGridView.Location = new System.Drawing.Point(0, 29);
            this.listadeProductosDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listadeProductosDataGridView.Name = "listadeProductosDataGridView";
            this.listadeProductosDataGridView.RowHeadersWidth = 51;
            this.listadeProductosDataGridView.RowTemplate.Height = 24;
            this.listadeProductosDataGridView.Size = new System.Drawing.Size(600, 337);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.listadeProductosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // ProductosForm
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listadeProductosDataGridView);
            this.Controls.Add(this.listadeProductosBindingNavigator);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listadeProductosDataGridView);
            this.Controls.Add(this.listadeProductosBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            this.Name = "ProductosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosForm";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingNavigator)).EndInit();
            this.listadeProductosBindingNavigator.ResumeLayout(false);
            this.listadeProductosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeProductosBindingSource;
        private System.Windows.Forms.BindingNavigator listadeProductosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listadeProductosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listadeProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}