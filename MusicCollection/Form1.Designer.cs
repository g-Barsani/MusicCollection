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
            this.albumLabel.Location = new System.Drawing.Point(96, 27);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(52, 19);
            this.albumLabel.TabIndex = 0;
            this.albumLabel.Text = "Album:";
            // 
            // albumBox
            // 
            this.albumBox.Location = new System.Drawing.Point(150, 24);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(282, 26);
            this.albumBox.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(98, 59);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(54, 19);
            this.artistLabel.TabIndex = 0;
            this.artistLabel.Text = "Artist:";
            // 
            // artistBox
            // 
            this.artistBox.Location = new System.Drawing.Point(150, 56);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(282, 26);
            this.artistBox.TabIndex = 2;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(98, 91);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(53, 19);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "Genre:";
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(150, 88);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(166, 26);
            this.genreBox.TabIndex = 3;
            // 
            // yearOfReleaseLabel
            // 
            this.yearOfReleaseLabel.AutoSize = true;
            this.yearOfReleaseLabel.Location = new System.Drawing.Point(34, 123);
            this.yearOfReleaseLabel.Name = "yearOfReleaseLabel";
            this.yearOfReleaseLabel.Size = new System.Drawing.Size(117, 19);
            this.yearOfReleaseLabel.TabIndex = 0;
            this.yearOfReleaseLabel.Text = "Year of Release:";
            // 
            // yearOfReleaseBox
            // 
            this.yearOfReleaseBox.Location = new System.Drawing.Point(150, 120);
            this.yearOfReleaseBox.Name = "yearOfReleaseBox";
            this.yearOfReleaseBox.Size = new System.Drawing.Size(166, 26);
            this.yearOfReleaseBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(73, 160);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(71, 19);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "CD",
            "Lp"});
            this.categoryBox.Location = new System.Drawing.Point(150, 152);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(131, 27);
            this.categoryBox.TabIndex = 5;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(129, 204);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(95, 31);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "&New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(252, 204);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(95, 31);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "&Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(378, 204);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 31);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(31, 419);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(95, 31);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 250);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(280, 425);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(59, 19);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(500, 204);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 31);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.Color.Silver;
            this.searchBox.Location = new System.Drawing.Point(357, 422);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(142, 26);
            this.searchBox.TabIndex = 11;
            this.searchBox.Text = "Enter an ID...";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 462);
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
            this.Name = "Form1";
            this.Text = "Form1";
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