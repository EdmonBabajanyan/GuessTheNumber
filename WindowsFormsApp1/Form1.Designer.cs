
namespace WindowsFormsApp1
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
            this.btnAnswer = new System.Windows.Forms.Button();
            this.playerNum = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblTurnsCount = new System.Windows.Forms.Label();
            this.lblcomNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.playerNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(12, 624);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(107, 45);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.Text = "Ստուգել";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // playerNum
            // 
            this.playerNum.Location = new System.Drawing.Point(12, 598);
            this.playerNum.Name = "playerNum";
            this.playerNum.Size = new System.Drawing.Size(107, 20);
            this.playerNum.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI Emoji", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer.Location = new System.Drawing.Point(6, 62);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(200, 31);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Գուշակեք թիվը...";
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblTurnsCount
            // 
            this.lblTurnsCount.AutoSize = true;
            this.lblTurnsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnsCount.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnsCount.ForeColor = System.Drawing.Color.Black;
            this.lblTurnsCount.Location = new System.Drawing.Point(0, 0);
            this.lblTurnsCount.Name = "lblTurnsCount";
            this.lblTurnsCount.Size = new System.Drawing.Size(374, 58);
            this.lblTurnsCount.TabIndex = 3;
            this.lblTurnsCount.Text = "Քայլերի քանակ: ";
            this.lblTurnsCount.Click += new System.EventHandler(this.lblTurnsCount_Click);
            // 
            // lblcomNum
            // 
            this.lblcomNum.AutoSize = true;
            this.lblcomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcomNum.Location = new System.Drawing.Point(1047, 646);
            this.lblcomNum.Name = "lblcomNum";
            this.lblcomNum.Size = new System.Drawing.Size(212, 26);
            this.lblcomNum.TabIndex = 4;
            this.lblcomNum.Text = "Համակարգչի թիվը`";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTurnsCount);
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 119);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1308190;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcomNum);
            this.Controls.Add(this.playerNum);
            this.Controls.Add(this.btnAnswer);
            this.Name = "Form1";
            this.Text = "Guess The Number";
            ((System.ComponentModel.ISupportInitialize)(this.playerNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.NumericUpDown playerNum;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblTurnsCount;
        private System.Windows.Forms.Label lblcomNum;
        private System.Windows.Forms.Panel panel1;
    }
}

