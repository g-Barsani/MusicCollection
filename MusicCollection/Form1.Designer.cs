namespace MusicCollection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.albumLabel = new System.Windows.Forms.Label();
            this.albumBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.yearOfReleaseLabel = new System.Windows.Forms.Label();
            this.yearOfReleaseBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.newButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.albumLabel.Location = new System.Drawing.Point(156, 28);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(60, 30);
            this.albumLabel.TabIndex = 0;
            this.albumLabel.Text = "Album:";
            // 
            // albumBox
            // 
            this.albumBox.BackColor = System.Drawing.SystemColors.Info;
            this.albumBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.albumBox.Location = new System.Drawing.Point(222, 25);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(414, 39);
            this.albumBox.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.artistLabel.Location = new System.Drawing.Point(156, 71);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(56, 30);
            this.artistLabel.TabIndex = 0;
            this.artistLabel.Text = "Artist:";
            // 
            // artistBox
            // 
            this.artistBox.BackColor = System.Drawing.SystemColors.Info;
            this.artistBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.artistBox.Location = new System.Drawing.Point(222, 68);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(337, 39);
            this.artistBox.TabIndex = 2;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreLabel.Location = new System.Drawing.Point(149, 114);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(63, 30);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "Genre:";
            // 
            // genreBox
            // 
            this.genreBox.BackColor = System.Drawing.SystemColors.Info;
            this.genreBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreBox.Location = new System.Drawing.Point(222, 111);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(240, 39);
            this.genreBox.TabIndex = 3;
            // 
            // yearOfReleaseLabel
            // 
            this.yearOfReleaseLabel.AutoSize = true;
            this.yearOfReleaseLabel.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearOfReleaseLabel.Location = new System.Drawing.Point(71, 156);
            this.yearOfReleaseLabel.Name = "yearOfReleaseLabel";
            this.yearOfReleaseLabel.Size = new System.Drawing.Size(141, 30);
            this.yearOfReleaseLabel.TabIndex = 0;
            this.yearOfReleaseLabel.Text = "Year of Release:";
            // 
            // yearOfReleaseBox
            // 
            this.yearOfReleaseBox.BackColor = System.Drawing.SystemColors.Info;
            this.yearOfReleaseBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearOfReleaseBox.Location = new System.Drawing.Point(222, 153);
            this.yearOfReleaseBox.Name = "yearOfReleaseBox";
            this.yearOfReleaseBox.Size = new System.Drawing.Size(166, 39);
            this.yearOfReleaseBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(123, 199);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(89, 30);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.SystemColors.Info;
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "CD",
            "Lp"});
            this.categoryBox.Location = new System.Drawing.Point(222, 196);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(131, 40);
            this.categoryBox.TabIndex = 5;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.newButton.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton.Location = new System.Drawing.Point(131, 254);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(95, 40);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "&New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Khaki;
            this.insertButton.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(254, 254);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(95, 40);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "&Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(380, 254);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showButton.Location = new System.Drawing.Point(32, 474);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(95, 36);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "&Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 313);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(281, 480);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(69, 30);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search:";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.updateButton.Font = new System.Drawing.Font("Mr Accordion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(502, 254);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 40);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Info;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBox.Location = new System.Drawing.Point(358, 477);
            this.searchBox.Name = "searchBox";
            this.searchBox.ShortcutsEnabled = false;
            this.searchBox.Size = new System.Drawing.Size(142, 39);
            this.searchBox.TabIndex = 11;
            this.searchBox.Text = "Enter an ID...";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(763, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.yearOfReleaseBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.yearOfReleaseLabel);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.albumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Collection by Gabriel B.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label albumLabel;
        private TextBox albumBox;
        private Label artistLabel;
        private TextBox artistBox;
        private Label genreLabel;
        private TextBox genreBox;
        private Label yearOfReleaseLabel;
        private TextBox yearOfReleaseBox;
        private Label categoryLabel;
        private ComboBox categoryBox;
        private Button newButton;
        private Button insertButton;
        private Button deleteButton;
        private Button showButton;
        private DataGridView dataGridView1;
        private Label searchLabel;
        private Button updateButton;
        private TextBox searchBox;
    }
}