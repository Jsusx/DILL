namespace DILL
{
    partial class EditProcess
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
            this.cbProcessList = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProcessList
            // 
            this.cbProcessList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProcessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcessList.FormattingEnabled = true;
            this.cbProcessList.Location = new System.Drawing.Point(46, 27);
            this.cbProcessList.Name = "cbProcessList";
            this.cbProcessList.Size = new System.Drawing.Size(209, 21);
            this.cbProcessList.TabIndex = 0;
            this.cbProcessList.TextChanged += new System.EventHandler(this.cbProcessList_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(276, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 21);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseMove);
            // 
            // EditProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 72);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbProcessList);
            this.Name = "EditProcess";
            this.Text = "Edit Process";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProcessList;
        private System.Windows.Forms.Button btnAdd;
    }
}