namespace SysScanner
{
    partial class Scanner
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlDomain = new System.Windows.Forms.Panel();
            this.txtDomainPassword = new System.Windows.Forms.TextBox();
            this.txtDomainUsername = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlWorkgroup = new System.Windows.Forms.Panel();
            this.txtWrkPassword = new System.Windows.Forms.TextBox();
            this.txtWrkUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDomain = new System.Windows.Forms.CheckBox();
            this.chkWorkgroup = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.machineHardwareInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardwareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardwareValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pnlDomain.SuspendLayout();
            this.pnlWorkgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineHardwareInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pnlDomain);
            this.groupBox1.Controls.Add(this.pnlWorkgroup);
            this.groupBox1.Controls.Add(this.chkDomain);
            this.groupBox1.Controls.Add(this.chkWorkgroup);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Scan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlDomain
            // 
            this.pnlDomain.Controls.Add(this.txtDomainPassword);
            this.pnlDomain.Controls.Add(this.txtDomainUsername);
            this.pnlDomain.Controls.Add(this.txtDomain);
            this.pnlDomain.Controls.Add(this.label5);
            this.pnlDomain.Controls.Add(this.label4);
            this.pnlDomain.Controls.Add(this.label3);
            this.pnlDomain.Enabled = false;
            this.pnlDomain.Location = new System.Drawing.Point(369, 43);
            this.pnlDomain.Name = "pnlDomain";
            this.pnlDomain.Size = new System.Drawing.Size(279, 100);
            this.pnlDomain.TabIndex = 3;
            // 
            // txtDomainPassword
            // 
            this.txtDomainPassword.Location = new System.Drawing.Point(99, 68);
            this.txtDomainPassword.Name = "txtDomainPassword";
            this.txtDomainPassword.Size = new System.Drawing.Size(177, 20);
            this.txtDomainPassword.TabIndex = 5;
            this.txtDomainPassword.UseSystemPasswordChar = true;
            // 
            // txtDomainUsername
            // 
            this.txtDomainUsername.Location = new System.Drawing.Point(99, 39);
            this.txtDomainUsername.Name = "txtDomainUsername";
            this.txtDomainUsername.Size = new System.Drawing.Size(177, 20);
            this.txtDomainUsername.TabIndex = 4;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(99, 12);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(177, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Domain";
            // 
            // pnlWorkgroup
            // 
            this.pnlWorkgroup.Controls.Add(this.txtWrkPassword);
            this.pnlWorkgroup.Controls.Add(this.txtWrkUsername);
            this.pnlWorkgroup.Controls.Add(this.label2);
            this.pnlWorkgroup.Controls.Add(this.label1);
            this.pnlWorkgroup.Location = new System.Drawing.Point(7, 43);
            this.pnlWorkgroup.Name = "pnlWorkgroup";
            this.pnlWorkgroup.Size = new System.Drawing.Size(279, 100);
            this.pnlWorkgroup.TabIndex = 2;
            // 
            // txtWrkPassword
            // 
            this.txtWrkPassword.Location = new System.Drawing.Point(99, 46);
            this.txtWrkPassword.Name = "txtWrkPassword";
            this.txtWrkPassword.Size = new System.Drawing.Size(177, 20);
            this.txtWrkPassword.TabIndex = 3;
            this.txtWrkPassword.UseSystemPasswordChar = true;
            // 
            // txtWrkUsername
            // 
            this.txtWrkUsername.Location = new System.Drawing.Point(99, 15);
            this.txtWrkUsername.Name = "txtWrkUsername";
            this.txtWrkUsername.Size = new System.Drawing.Size(177, 20);
            this.txtWrkUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // chkDomain
            // 
            this.chkDomain.AutoSize = true;
            this.chkDomain.Location = new System.Drawing.Point(369, 20);
            this.chkDomain.Name = "chkDomain";
            this.chkDomain.Size = new System.Drawing.Size(62, 17);
            this.chkDomain.TabIndex = 1;
            this.chkDomain.Text = "Domain";
            this.chkDomain.UseVisualStyleBackColor = true;
            this.chkDomain.CheckedChanged += new System.EventHandler(this.chkDomain_CheckedChanged);
            // 
            // chkWorkgroup
            // 
            this.chkWorkgroup.AutoSize = true;
            this.chkWorkgroup.Checked = true;
            this.chkWorkgroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWorkgroup.Location = new System.Drawing.Point(7, 20);
            this.chkWorkgroup.Name = "chkWorkgroup";
            this.chkWorkgroup.Size = new System.Drawing.Size(79, 17);
            this.chkWorkgroup.TabIndex = 0;
            this.chkWorkgroup.Text = "Workgroup";
            this.chkWorkgroup.UseVisualStyleBackColor = true;
            this.chkWorkgroup.CheckedChanged += new System.EventHandler(this.chkWorkgroup_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.hardwareNameDataGridViewTextBoxColumn,
            this.hardwareValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.machineHardwareInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 354);
            this.dataGridView1.TabIndex = 1;
            // 
            // machineHardwareInfoBindingSource
            // 
            this.machineHardwareInfoBindingSource.DataSource = typeof(SysScanner.MachineHardwareInfo);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn1.HeaderText = "MachineName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // hardwareNameDataGridViewTextBoxColumn
            // 
            this.hardwareNameDataGridViewTextBoxColumn.DataPropertyName = "HardwareName";
            this.hardwareNameDataGridViewTextBoxColumn.HeaderText = "HardwareName";
            this.hardwareNameDataGridViewTextBoxColumn.Name = "hardwareNameDataGridViewTextBoxColumn";
            // 
            // hardwareValueDataGridViewTextBoxColumn
            // 
            this.hardwareValueDataGridViewTextBoxColumn.DataPropertyName = "HardwareValue";
            this.hardwareValueDataGridViewTextBoxColumn.HeaderText = "HardwareValue";
            this.hardwareValueDataGridViewTextBoxColumn.Name = "hardwareValueDataGridViewTextBoxColumn";
            this.hardwareValueDataGridViewTextBoxColumn.Width = 600;
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDomain.ResumeLayout(false);
            this.pnlDomain.PerformLayout();
            this.pnlWorkgroup.ResumeLayout(false);
            this.pnlWorkgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineHardwareInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlWorkgroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDomain;
        private System.Windows.Forms.CheckBox chkWorkgroup;
        private System.Windows.Forms.TextBox txtDomainPassword;
        private System.Windows.Forms.TextBox txtDomainUsername;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtWrkPassword;
        private System.Windows.Forms.TextBox txtWrkUsername;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource machineHardwareInfoBindingSource;
    }
}