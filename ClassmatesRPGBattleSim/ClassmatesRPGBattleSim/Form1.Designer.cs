namespace ClassmatesRPGBattleSim
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHealth1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHealth2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.cboCharacterType1 = new System.Windows.Forms.ComboBox();
            this.cboCharacterType2 = new System.Windows.Forms.ComboBox();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.lstBattleLog = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Character type:";
            // 
            // lblHealth1
            // 
            this.lblHealth1.AutoSize = true;
            this.lblHealth1.Location = new System.Drawing.Point(241, 75);
            this.lblHealth1.Name = "lblHealth1";
            this.lblHealth1.Size = new System.Drawing.Size(40, 20);
            this.lblHealth1.TabIndex = 3;
            this.lblHealth1.Text = "- HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Character type:";
            // 
            // lblHealth2
            // 
            this.lblHealth2.AutoSize = true;
            this.lblHealth2.Location = new System.Drawing.Point(960, 78);
            this.lblHealth2.Name = "lblHealth2";
            this.lblHealth2.Size = new System.Drawing.Size(40, 20);
            this.lblHealth2.TabIndex = 7;
            this.lblHealth2.Text = "- HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Battle Log";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(533, 205);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(34, 25);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "\" \"";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(135, 72);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 26);
            this.txtName1.TabIndex = 10;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(854, 72);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 26);
            this.txtName2.TabIndex = 11;
            // 
            // cboCharacterType1
            // 
            this.cboCharacterType1.FormattingEnabled = true;
            this.cboCharacterType1.Location = new System.Drawing.Point(135, 116);
            this.cboCharacterType1.Name = "cboCharacterType1";
            this.cboCharacterType1.Size = new System.Drawing.Size(156, 28);
            this.cboCharacterType1.TabIndex = 12;
            // 
            // cboCharacterType2
            // 
            this.cboCharacterType2.FormattingEnabled = true;
            this.cboCharacterType2.Location = new System.Drawing.Point(850, 113);
            this.cboCharacterType2.Name = "cboCharacterType2";
            this.cboCharacterType2.Size = new System.Drawing.Size(171, 28);
            this.cboCharacterType2.TabIndex = 13;
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnStartBattle.Location = new System.Drawing.Point(438, 75);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(143, 36);
            this.btnStartBattle.TabIndex = 14;
            this.btnStartBattle.Text = "Start Battle!";
            this.btnStartBattle.UseVisualStyleBackColor = false;
            this.btnStartBattle.Click += new System.EventHandler(this.btnStartBattle_Click);
            // 
            // lstBattleLog
            // 
            this.lstBattleLog.FormattingEnabled = true;
            this.lstBattleLog.ItemHeight = 20;
            this.lstBattleLog.Location = new System.Drawing.Point(277, 286);
            this.lstBattleLog.Name = "lstBattleLog";
            this.lstBattleLog.Size = new System.Drawing.Size(589, 284);
            this.lstBattleLog.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Winner:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1232, 625);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstBattleLog);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.cboCharacterType2);
            this.Controls.Add(this.cboCharacterType1);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHealth2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHealth1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHealth1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHealth2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.ComboBox cboCharacterType1;
        private System.Windows.Forms.ComboBox cboCharacterType2;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.ListBox lstBattleLog;
        private System.Windows.Forms.Label label8;
    }
}