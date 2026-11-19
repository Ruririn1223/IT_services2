namespace IT_services2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuReferences = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSystems = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContracts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReportsPlaceholder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReferences,
            this.menuOperations,
            this.menuReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuReferences
            // 
            this.menuReferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOrganizations,
            this.menuItemEmployees,
            this.menuItemSystems});
            this.menuReferences.Name = "menuReferences";
            this.menuReferences.Size = new System.Drawing.Size(91, 20);
            this.menuReferences.Text = "Справочники";
            // 
            // menuOperations
            // 
            this.menuOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemContracts});
            this.menuOperations.Name = "menuOperations";
            this.menuOperations.Size = new System.Drawing.Size(83, 20);
            this.menuOperations.Text = "Операции";
            // 
            // menuReports
            // 
            this.menuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReportsPlaceholder});
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(74, 20);
            this.menuReports.Text = "Отчеты";
            // 
            // menuItemOrganizations
            // 
            this.menuItemOrganizations.Name = "menuItemOrganizations";
            this.menuItemOrganizations.Size = new System.Drawing.Size(180, 22);
            this.menuItemOrganizations.Text = "Организации";
            this.menuItemOrganizations.Click += new System.EventHandler(this.MenuItemOrganizations_Click);
            // 
            // menuItemEmployees
            // 
            this.menuItemEmployees.Name = "menuItemEmployees";
            this.menuItemEmployees.Size = new System.Drawing.Size(180, 22);
            this.menuItemEmployees.Text = "Сотрудники";
            this.menuItemEmployees.Click += new System.EventHandler(this.MenuItemEmployees_Click);
            // 
            // menuItemSystems
            // 
            this.menuItemSystems.Name = "menuItemSystems";
            this.menuItemSystems.Size = new System.Drawing.Size(180, 22);
            this.menuItemSystems.Text = "Системы";
            this.menuItemSystems.Click += new System.EventHandler(this.MenuItemSystems_Click);
            // 
            // menuItemContracts
            // 
            this.menuItemContracts.Name = "menuItemContracts";
            this.menuItemContracts.Size = new System.Drawing.Size(180, 22);
            this.menuItemContracts.Text = "Договоры";
            this.menuItemContracts.Click += new System.EventHandler(this.MenuItemContracts_Click);
            // 
            // menuItemReportsPlaceholder
            // 
            this.menuItemReportsPlaceholder.Name = "menuItemReportsPlaceholder";
            this.menuItemReportsPlaceholder.Size = new System.Drawing.Size(180, 22);
            this.menuItemReportsPlaceholder.Text = "(пока пусто)";
            this.menuItemReportsPlaceholder.Click += new System.EventHandler(this.MenuItemReports_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT-услуги — Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuReferences;
        private System.Windows.Forms.ToolStripMenuItem menuOperations;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuItemOrganizations;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmployees;
        private System.Windows.Forms.ToolStripMenuItem menuItemSystems;
        private System.Windows.Forms.ToolStripMenuItem menuItemContracts;
        private System.Windows.Forms.ToolStripMenuItem menuItemReportsPlaceholder;
    }
}