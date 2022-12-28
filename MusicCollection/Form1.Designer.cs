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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(98, 27);
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
            this.genreLabel.Location = new System.Drawing.Point(98, 95);
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
            this.yearOfReleaseLabel.Location = new System.Drawing.Point(31, 123);
            this.yearOfReleaseLabel.Name = "yearOfReleaseLabel";
            this.yearOfReleaseLabel.Size = new System.Drawing.Size(117, 19);
            this.yearOfReleaseLabel.TabIndex = 0;
            this.yearOfReleaseLabel.Text = "Year of Release:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 26);
            this.textBox4.TabIndex = 4;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(77, 155);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(71, 19);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 27);
            this.comboBox1.TabIndex = 5;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(77, 202);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(95, 31);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "&New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(200, 202);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(95, 31);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "&Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(326, 202);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 31);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 31);
            this.button4.TabIndex = 6;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(512, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(448, 202);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 31);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 26);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
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
        private TextBox textBox4;
        private Label categoryLabel;
        private ComboBox comboBox1;
        private Button newButton;
        private Button insertButton;
        private Button deleteButton;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private Button updateButton;
        private TextBox textBox1;
    }
}