namespace NFC2
{
    partial class F_GestaoUsuarios
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
            this.nudNivel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnSalvarAlter = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNivel
            // 
            this.nudNivel.Location = new System.Drawing.Point(153, 200);
            this.nudNivel.Name = "nudNivel";
            this.nudNivel.Size = new System.Drawing.Size(129, 20);
            this.nudNivel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nível";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(17, 199);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(130, 20);
            this.tbStatus.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Status";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(17, 85);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(265, 20);
            this.tbNome.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(152, 142);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(130, 20);
            this.tbSenha.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Senha";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(16, 142);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(130, 20);
            this.tbUsername.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(17, 36);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(130, 20);
            this.tbID.TabIndex = 21;
            this.tbID.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(17, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnExcluirUsuario);
            this.panel1.Controls.Add(this.btnSalvarAlter);
            this.panel1.Controls.Add(this.btnNovoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 35);
            this.panel1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(288, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(287, 184);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(12, 3);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(85, 23);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "Novo usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSalvarAlter
            // 
            this.btnSalvarAlter.Location = new System.Drawing.Point(103, 3);
            this.btnSalvarAlter.Name = "btnSalvarAlter";
            this.btnSalvarAlter.Size = new System.Drawing.Size(97, 23);
            this.btnSalvarAlter.TabIndex = 1;
            this.btnSalvarAlter.Text = "Salvar alterações";
            this.btnSalvarAlter.UseVisualStyleBackColor = true;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(206, 3);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(97, 23);
            this.btnExcluirUsuario.TabIndex = 2;
            this.btnExcluirUsuario.Text = "Excluir usuário";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(478, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(97, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // F_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 268);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.nudNivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de usuários";
            this.Load += new System.EventHandler(this.F_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnSalvarAlter;
        private System.Windows.Forms.Button btnNovoUsuario;
    }
}