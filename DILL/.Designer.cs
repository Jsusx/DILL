namespace DILL
{
    partial class DILL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbProcesos = new System.Windows.Forms.ComboBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.LabelProcessIcon = new System.Windows.Forms.Label();
            this.LabelDill1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDLL = new System.Windows.Forms.TextBox();
            this.LabelSelectDLL = new System.Windows.Forms.Label();
            this.LabelSelectProcess = new System.Windows.Forms.Label();
            this.btnSelectDLL = new System.Windows.Forms.Button();
            this.checkEDP = new System.Windows.Forms.CheckBox();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProcesos
            // 
            this.cbProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProcesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcesos.FormattingEnabled = true;
            this.cbProcesos.Location = new System.Drawing.Point(165, 159);
            this.cbProcesos.Name = "cbProcesos";
            this.cbProcesos.Size = new System.Drawing.Size(319, 21);
            this.cbProcesos.TabIndex = 0;
            this.cbProcesos.TextChanged += new System.EventHandler(this.cbProcesos_TextChanged);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Location = new System.Drawing.Point(141, 241);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(156, 40);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Load Process";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            this.btnRecargar.MouseLeave += new System.EventHandler(this.btnRecargar_MouseLeave);
            this.btnRecargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRecargar_MouseMove);
            // 
            // LabelProcessIcon
            // 
            this.LabelProcessIcon.Location = new System.Drawing.Point(12, 241);
            this.LabelProcessIcon.Name = "LabelProcessIcon";
            this.LabelProcessIcon.Size = new System.Drawing.Size(48, 40);
            this.LabelProcessIcon.TabIndex = 2;
            // 
            // LabelDill1
            // 
            this.LabelDill1.Location = new System.Drawing.Point(-7, -2);
            this.LabelDill1.Name = "LabelDill1";
            this.LabelDill1.Size = new System.Drawing.Size(598, 48);
            this.LabelDill1.TabIndex = 3;
            this.LabelDill1.Text = "D I L L";
            this.LabelDill1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(436, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 34);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Add Process";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave_1);
            this.btnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEdit_MouseMove_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(330, 241);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(154, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Inject";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAceptar_MouseMove);
            // 
            // txtDLL
            // 
            this.txtDLL.Location = new System.Drawing.Point(165, 105);
            this.txtDLL.Name = "txtDLL";
            this.txtDLL.Size = new System.Drawing.Size(288, 20);
            this.txtDLL.TabIndex = 6;
            // 
            // LabelSelectDLL
            // 
            this.LabelSelectDLL.Location = new System.Drawing.Point(35, 95);
            this.LabelSelectDLL.Name = "LabelSelectDLL";
            this.LabelSelectDLL.Size = new System.Drawing.Size(124, 39);
            this.LabelSelectDLL.TabIndex = 7;
            this.LabelSelectDLL.Text = "Select DLL:";
            this.LabelSelectDLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSelectProcess
            // 
            this.LabelSelectProcess.Location = new System.Drawing.Point(35, 149);
            this.LabelSelectProcess.Name = "LabelSelectProcess";
            this.LabelSelectProcess.Size = new System.Drawing.Size(124, 39);
            this.LabelSelectProcess.TabIndex = 8;
            this.LabelSelectProcess.Text = "Select Process:";
            this.LabelSelectProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectDLL
            // 
            this.btnSelectDLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDLL.Location = new System.Drawing.Point(452, 133);
            this.btnSelectDLL.Name = "btnSelectDLL";
            this.btnSelectDLL.Size = new System.Drawing.Size(32, 20);
            this.btnSelectDLL.TabIndex = 9;
            this.btnSelectDLL.Text = "...";
            this.btnSelectDLL.UseVisualStyleBackColor = true;
            this.btnSelectDLL.Click += new System.EventHandler(this.btnSelectDLL_Click);
            // 
            // checkEDP
            // 
            this.checkEDP.Location = new System.Drawing.Point(459, 105);
            this.checkEDP.Name = "checkEDP";
            this.checkEDP.Size = new System.Drawing.Size(25, 20);
            this.checkEDP.TabIndex = 10;
            this.checkEDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEDP.UseVisualStyleBackColor = true;
            this.checkEDP.CheckedChanged += new System.EventHandler(this.checkEDP_CheckedChanged);
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFavorites});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(181, 48);
            // 
            // cmsFavorites
            // 
            this.cmsFavorites.Name = "cmsFavorites";
            this.cmsFavorites.Size = new System.Drawing.Size(180, 22);
            this.cmsFavorites.Text = "Favorites";
            this.cmsFavorites.Click += new System.EventHandler(this.favoritesToolStripMenuItem_Click);
            // 
            // DILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 293);
            this.ContextMenuStrip = this.cmsOptions;
            this.Controls.Add(this.checkEDP);
            this.Controls.Add(this.btnSelectDLL);
            this.Controls.Add(this.LabelSelectProcess);
            this.Controls.Add(this.LabelSelectDLL);
            this.Controls.Add(this.txtDLL);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.LabelDill1);
            this.Controls.Add(this.LabelProcessIcon);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.cbProcesos);
            this.Name = "DILL";
            this.Text = "DILL";
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProcesos;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label LabelProcessIcon;
        private System.Windows.Forms.Label LabelDill1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDLL;
        private System.Windows.Forms.Label LabelSelectDLL;
        private System.Windows.Forms.Label LabelSelectProcess;
        private System.Windows.Forms.Button btnSelectDLL;
        private System.Windows.Forms.CheckBox checkEDP;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem cmsFavorites;
    }
}

