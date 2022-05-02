namespace KendoTournaments
{
    partial class CreateTournament
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.dataGridViewPlayersAdded = new System.Windows.Forms.DataGridView();
            this.addedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayersAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(343, 41);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(343, 115);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playersId,
            this.playersName,
            this.playersLastname});
            this.dataGridViewPlayers.Location = new System.Drawing.Point(35, 41);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPlayers.TabIndex = 4;
            // 
            // dataGridViewPlayersAdded
            // 
            this.dataGridViewPlayersAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayersAdded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addedId,
            this.addedName,
            this.addedLastname});
            this.dataGridViewPlayersAdded.Location = new System.Drawing.Point(494, 41);
            this.dataGridViewPlayersAdded.Name = "dataGridViewPlayersAdded";
            this.dataGridViewPlayersAdded.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPlayersAdded.TabIndex = 5;
            // 
            // addedId
            // 
            this.addedId.HeaderText = "Id";
            this.addedId.Name = "addedId";
            // 
            // addedName
            // 
            this.addedName.HeaderText = "Name";
            this.addedName.Name = "addedName";
            // 
            // addedLastname
            // 
            this.addedLastname.HeaderText = "Lastname";
            this.addedLastname.Name = "addedLastname";
            // 
            // playersId
            // 
            this.playersId.HeaderText = "Id";
            this.playersId.Name = "playersId";
            // 
            // playersName
            // 
            this.playersName.HeaderText = "Name";
            this.playersName.Name = "playersName";
            // 
            // playersLastname
            // 
            this.playersLastname.HeaderText = "Lastname";
            this.playersLastname.Name = "playersLastname";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(KendoTournaments.Player);
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPlayersAdded);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.Load += new System.EventHandler(this.CreateTournament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayersAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPlayersAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersLastname;
    }
}