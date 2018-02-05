namespace DFS_Exercise
{
    partial class StatusConnections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusConnections));
            this.connectionList = new System.Windows.Forms.DataGridView();
            this.connectionTimer = new System.Windows.Forms.Timer(this.components);
            this.ipList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.connectionList)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionList
            // 
            this.connectionList.AllowUserToAddRows = false;
            this.connectionList.AllowUserToDeleteRows = false;
            this.connectionList.AllowUserToResizeColumns = false;
            this.connectionList.AllowUserToResizeRows = false;
            this.connectionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.connectionList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.connectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipList,
            this.hostnameList,
            this.statusList});
            this.connectionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.connectionList.Location = new System.Drawing.Point(0, 0);
            this.connectionList.Name = "connectionList";
            this.connectionList.ReadOnly = true;
            this.connectionList.RowHeadersVisible = false;
            this.connectionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.connectionList.Size = new System.Drawing.Size(284, 161);
            this.connectionList.TabIndex = 0;
            // 
            // connectionTimer
            // 
            this.connectionTimer.Tick += new System.EventHandler(this.connectionTimer_Tick);
            // 
            // ipList
            // 
            this.ipList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ipList.HeaderText = "IP Address";
            this.ipList.Name = "ipList";
            this.ipList.ReadOnly = true;
            this.ipList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ipList.Width = 83;
            // 
            // hostnameList
            // 
            this.hostnameList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hostnameList.HeaderText = "Hostname";
            this.hostnameList.Name = "hostnameList";
            this.hostnameList.ReadOnly = true;
            this.hostnameList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hostnameList.Width = 80;
            // 
            // statusList
            // 
            this.statusList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusList.HeaderText = "Status";
            this.statusList.Name = "statusList";
            this.statusList.ReadOnly = true;
            this.statusList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.statusList.Width = 62;
            // 
            // StatusConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.connectionList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatusConnections";
            this.Text = "List of Employee Statuses";
            ((System.ComponentModel.ISupportInitialize)(this.connectionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView connectionList;
        private System.Windows.Forms.Timer connectionTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipList;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameList;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusList;
    }
}