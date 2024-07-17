namespace UnturnedShopPlugin
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            this.hostLabel = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsListView = new System.Windows.Forms.ListView();
            this.addFromSearchButton = new System.Windows.Forms.Button();
            this.addIdLabel = new System.Windows.Forms.Label();
            this.addIdTextBox = new System.Windows.Forms.TextBox();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addCostLabel = new System.Windows.Forms.Label();
            this.addCostTextBox = new System.Windows.Forms.TextBox();
            this.addBuybackLabel = new System.Windows.Forms.Label();
            this.addBuybackTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(12, 15);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(70, 13);
            this.hostLabel.TabIndex = 0;
            this.hostLabel.Text = "MySQL Host:";

            this.hostTextBox.Location = new System.Drawing.Point(100, 12);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(150, 20);
            this.hostTextBox.TabIndex = 1;
            this.hostTextBox.Text = "ds";

            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 41);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(70, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "MySQL User:";

            this.userTextBox.Location = new System.Drawing.Point(100, 38);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(150, 20);
            this.userTextBox.TabIndex = 3;

            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(94, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "MySQL Password:";

            this.passwordTextBox.Location = new System.Drawing.Point(100, 64);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 5;

            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(12, 93);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(94, 13);
            this.databaseLabel.TabIndex = 6;
            this.databaseLabel.Text = "MySQL Database:";

            this.databaseTextBox.Location = new System.Drawing.Point(100, 90);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(150, 20);
            this.databaseTextBox.TabIndex = 7;

            this.connectButton.Location = new System.Drawing.Point(100, 116);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(150, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);

            this.tabControl.Location = new System.Drawing.Point(12, 145);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(360, 200);
            this.tabControl.TabIndex = 9;

            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 355);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(100, 13);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "ID veya İsim ile Ara:";

            this.searchTextBox.Location = new System.Drawing.Point(100, 352);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 20);
            this.searchTextBox.TabIndex = 11;

            this.searchButton.Location = new System.Drawing.Point(256, 350);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Ara";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);

            this.searchResultsListView.HideSelection = false;
            this.searchResultsListView.Location = new System.Drawing.Point(12, 378);
            this.searchResultsListView.Name = "searchResultsListView";
            this.searchResultsListView.Size = new System.Drawing.Size(360, 100);
            this.searchResultsListView.TabIndex = 13;
            this.searchResultsListView.UseCompatibleStateImageBehavior = false;

            this.addFromSearchButton.Location = new System.Drawing.Point(12, 484);
            this.addFromSearchButton.Name = "addFromSearchButton";
            this.addFromSearchButton.Size = new System.Drawing.Size(360, 23);
            this.addFromSearchButton.TabIndex = 14;
            this.addFromSearchButton.Text = "Seçili Veriyi Ekle";
            this.addFromSearchButton.UseVisualStyleBackColor = true;
            this.addFromSearchButton.Click += new System.EventHandler(this.AddSelectedButton_Click);

            this.addIdLabel.AutoSize = true;
            this.addIdLabel.Location = new System.Drawing.Point(12, 520);
            this.addIdLabel.Name = "addIdLabel";
            this.addIdLabel.Size = new System.Drawing.Size(21, 13);
            this.addIdLabel.TabIndex = 15;
            this.addIdLabel.Text = "ID:";

            this.addIdTextBox.Location = new System.Drawing.Point(100, 517);
            this.addIdTextBox.Name = "addIdTextBox";
            this.addIdTextBox.Size = new System.Drawing.Size(150, 20);
            this.addIdTextBox.TabIndex = 16;

            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(12, 546);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(28, 13);
            this.addNameLabel.TabIndex = 17;
            this.addNameLabel.Text = "İsim:";

            this.addNameTextBox.Location = new System.Drawing.Point(100, 543);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.addNameTextBox.TabIndex = 18;

            this.addCostLabel.AutoSize = true;
            this.addCostLabel.Location = new System.Drawing.Point(12, 572);
            this.addCostLabel.Name = "addCostLabel";
            this.addCostLabel.Size = new System.Drawing.Size(31, 13);
            this.addCostLabel.TabIndex = 19;
            this.addCostLabel.Text = "Cost:";

            this.addCostTextBox.Location = new System.Drawing.Point(100, 569);
            this.addCostTextBox.Name = "addCostTextBox";
            this.addCostTextBox.Size = new System.Drawing.Size(150, 20);
            this.addCostTextBox.TabIndex = 20;

            this.addBuybackLabel.AutoSize = true;
            this.addBuybackLabel.Location = new System.Drawing.Point(12, 598);
            this.addBuybackLabel.Name = "addBuybackLabel";
            this.addBuybackLabel.Size = new System.Drawing.Size(148, 13);
            this.addBuybackLabel.TabIndex = 21;
            this.addBuybackLabel.Text = "Buyback (sadece itemler için):";

            this.addBuybackTextBox.Location = new System.Drawing.Point(100, 595);
            this.addBuybackTextBox.Name = "addBuybackTextBox";
            this.addBuybackTextBox.Size = new System.Drawing.Size(150, 20);
            this.addBuybackTextBox.TabIndex = 22;

            this.addButton.Location = new System.Drawing.Point(256, 563);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);

            this.deleteButton.Location = new System.Drawing.Point(12, 624);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(360, 23);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);

            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addBuybackTextBox);
            this.Controls.Add(this.addBuybackLabel);
            this.Controls.Add(this.addCostTextBox);
            this.Controls.Add(this.addCostLabel);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.addIdTextBox);
            this.Controls.Add(this.addIdLabel);
            this.Controls.Add(this.addFromSearchButton);
            this.Controls.Add(this.searchResultsListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.hostLabel);
            this.Name = "MainForm";
            this.Text = "Unturned Shop Plugin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox databaseTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView searchResultsListView;
        private System.Windows.Forms.Button addFromSearchButton;
        private System.Windows.Forms.Label addIdLabel;
        private System.Windows.Forms.TextBox addIdTextBox;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label addCostLabel;
        private System.Windows.Forms.TextBox addCostTextBox;
        private System.Windows.Forms.Label addBuybackLabel;
        private System.Windows.Forms.TextBox addBuybackTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
