
namespace TicTacToe
{
    partial class Form2
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(1, 5);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(202, 24);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Player One Name:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb2.Location = new System.Drawing.Point(1, 48);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(202, 24);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Player Two Name:";
            // 
            // p1
            // 
            this.p1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p1.Location = new System.Drawing.Point(209, 2);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(215, 32);
            this.p1.TabIndex = 2;
            this.p1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p1_KeyPress);
            // 
            // p2
            // 
            this.p2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p2.Location = new System.Drawing.Point(209, 45);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(215, 32);
            this.p2.TabIndex = 3;
            this.p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2_KeyPress);
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(324, 94);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(87, 23);
            this.btPlay.TabIndex = 4;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 133);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(449, 172);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Button btPlay;
    }
}