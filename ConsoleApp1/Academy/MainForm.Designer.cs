namespace Academy
{
    partial class MainForm
    {
        // <summary>
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.statusStripStudents = new System.Windows.Forms.StatusStrip();
            this.tslStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.lblGroupDirection = new System.Windows.Forms.Label();
            this.cbGroupsDirection = new System.Windows.Forms.ComboBox();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.statusStripGroups = new System.Windows.Forms.StatusStrip();
            this.tslGroupsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripTeachers = new System.Windows.Forms.StatusStrip();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tslTeachersCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.statusStripStudents.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.statusStripGroups.SuspendLayout();
            this.statusStripTeachers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(951, 427);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.dataGridStudents);
            this.tabPageStudents.Controls.Add(this.statusStripStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(943, 401);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(0, 36);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.Size = new System.Drawing.Size(943, 337);
            this.dataGridStudents.TabIndex = 1;
            // 
            // statusStripStudents
            // 
            this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStudentsCount});
            this.statusStripStudents.Location = new System.Drawing.Point(3, 376);
            this.statusStripStudents.Name = "statusStripStudents";
            this.statusStripStudents.Size = new System.Drawing.Size(937, 22);
            this.statusStripStudents.TabIndex = 0;
            this.statusStripStudents.Text = "statusStripStudents";
            // 
            // tslStudentsCount
            // 
            this.tslStudentsCount.Name = "tslStudentsCount";
            this.tslStudentsCount.Size = new System.Drawing.Size(129, 17);
            this.tslStudentsCount.Text = "Количество студентов";
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.lblGroupDirection);
            this.tabPageGroups.Controls.Add(this.cbGroupsDirection);
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Controls.Add(this.statusStripGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(943, 401);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // lblGroupDirection
            // 
            this.lblGroupDirection.AutoSize = true;
            this.lblGroupDirection.Location = new System.Drawing.Point(216, 13);
            this.lblGroupDirection.Name = "lblGroupDirection";
            this.lblGroupDirection.Size = new System.Drawing.Size(127, 13);
            this.lblGroupDirection.TabIndex = 3;
            this.lblGroupDirection.Text = "Направление обучения:";
            // 
            // cbGroupsDirection
            // 
            this.cbGroupsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupsDirection.FormattingEnabled = true;
            this.cbGroupsDirection.Location = new System.Drawing.Point(349, 10);
            this.cbGroupsDirection.Name = "cbGroupsDirection";
            this.cbGroupsDirection.Size = new System.Drawing.Size(214, 21);
            this.cbGroupsDirection.TabIndex = 2;
            this.cbGroupsDirection.SelectedIndexChanged += new System.EventHandler(this.cbGroupsDirection_SelectedIndexChanged);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(-4, 38);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.Size = new System.Drawing.Size(944, 335);
            this.dataGridViewGroups.TabIndex = 1;
            // 
            // statusStripGroups
            // 
            this.statusStripGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslGroupsCount});
            this.statusStripGroups.Location = new System.Drawing.Point(3, 376);
            this.statusStripGroups.Name = "statusStripGroups";
            this.statusStripGroups.Size = new System.Drawing.Size(937, 22);
            this.statusStripGroups.TabIndex = 0;
            this.statusStripGroups.Text = "statusStripGroups";
            // 
            // tslGroupsCount
            // 
            this.tslGroupsCount.Name = "tslGroupsCount";
            this.tslGroupsCount.Size = new System.Drawing.Size(107, 17);
            this.tslGroupsCount.Text = "Количество групп";
            // 
            // statusStripTeachers
            // 
            this.statusStripTeachers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTeachersCount});
            this.statusStripTeachers.Location = new System.Drawing.Point(0, 405);
            this.statusStripTeachers.Name = "statusStripTeachers";
            this.statusStripTeachers.Size = new System.Drawing.Size(951, 22);
            this.statusStripTeachers.TabIndex = 1;
            this.statusStripTeachers.Text = "statusStripTeachers";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 401);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Techers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 347);
            this.dataGridView1.TabIndex = 2;
            // 
            // tslTeachersCount
            // 
            this.tslTeachersCount.Name = "tslTeachersCount";
            this.tslTeachersCount.Size = new System.Drawing.Size(166, 17);
            this.tslTeachersCount.Text = "Количество Преподавателей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 427);
            this.Controls.Add(this.statusStripTeachers);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Academy";
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.statusStripStudents.ResumeLayout(false);
            this.statusStripStudents.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.statusStripGroups.ResumeLayout(false);
            this.statusStripGroups.PerformLayout();
            this.statusStripTeachers.ResumeLayout(false);
            this.statusStripTeachers.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.StatusStrip statusStripStudents;
        private System.Windows.Forms.ToolStripStatusLabel tslStudentsCount;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.StatusStrip statusStripGroups;
        private System.Windows.Forms.ToolStripStatusLabel tslGroupsCount;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Label lblGroupDirection;
        private System.Windows.Forms.ComboBox cbGroupsDirection;
        private System.Windows.Forms.StatusStrip statusStripTeachers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel tslTeachersCount;
    }
}

