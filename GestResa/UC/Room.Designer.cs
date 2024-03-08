namespace GestResa.UC
{
    partial class Room
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbNumber = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.libMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(4, 4);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(40, 42);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.Text = "0";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resMenu,
            this.libMenu});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(301, 124);
            // 
            // resMenu
            // 
            this.resMenu.Name = "resMenu";
            this.resMenu.Size = new System.Drawing.Size(300, 38);
            this.resMenu.Text = "Réserver";
            this.resMenu.Click += new System.EventHandler(this.resMenu_Click);
            // 
            // libMenu
            // 
            this.libMenu.Name = "libMenu";
            this.libMenu.Size = new System.Drawing.Size(300, 38);
            this.libMenu.Text = "Libérer";
            this.libMenu.Click += new System.EventHandler(this.libMenu_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.lbNumber);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(423, 143);
            this.Load += new System.EventHandler(this.Room_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem resMenu;
        private System.Windows.Forms.ToolStripMenuItem libMenu;
    }
}
