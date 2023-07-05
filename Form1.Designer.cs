
namespace WhoWantsToBeAMillionare
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.btn5050 = new System.Windows.Forms.Button();
            this.zalHelp = new System.Windows.Forms.Button();
            this.friendCall = new System.Windows.Forms.Button();
            this.twoChances = new System.Windows.Forms.Button();
            this.changeQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Location = new System.Drawing.Point(52, 404);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(276, 53);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Location = new System.Drawing.Point(52, 480);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(276, 53);
            this.btnAnswerB.TabIndex = 3;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Location = new System.Drawing.Point(385, 404);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(276, 53);
            this.btnAnswerC.TabIndex = 4;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Location = new System.Drawing.Point(385, 480);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(276, 53);
            this.btnAnswerD.TabIndex = 5;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 189);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(694, 138);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "label1";
            // 
            // lstLevel
            // 
            this.lstLevel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lstLevel.Font = new System.Drawing.Font("Segoe Script", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 30;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "   800 000",
            "   400 000",
            "   200 000",
            "   100 000",
            "     50 000",
            "     25 000",
            "     15 000",
            "     10 000",
            "       5 000",
            "       3 000",
            "       2 000",
            "       1 000",
            "          500"});
            this.lstLevel.Location = new System.Drawing.Point(753, 12);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstLevel.Size = new System.Drawing.Size(131, 454);
            this.lstLevel.TabIndex = 7;
            // 
            // btn5050
            // 
            this.btn5050.Location = new System.Drawing.Point(52, 330);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(91, 56);
            this.btn5050.TabIndex = 8;
            this.btn5050.Text = "50/50";
            this.btn5050.UseVisualStyleBackColor = true;
            this.btn5050.Click += new System.EventHandler(this.bntFiftyFifty_Click);
            // 
            // zalHelp
            // 
            this.zalHelp.Location = new System.Drawing.Point(176, 330);
            this.zalHelp.Name = "zalHelp";
            this.zalHelp.Size = new System.Drawing.Size(91, 56);
            this.zalHelp.TabIndex = 9;
            this.zalHelp.Text = "Помощь зала";
            this.zalHelp.UseVisualStyleBackColor = true;
            this.zalHelp.Click += new System.EventHandler(this.zalHelp_Click);
            // 
            // friendCall
            // 
            this.friendCall.Location = new System.Drawing.Point(314, 330);
            this.friendCall.Name = "friendCall";
            this.friendCall.Size = new System.Drawing.Size(91, 56);
            this.friendCall.TabIndex = 10;
            this.friendCall.Text = "Звонок другу";
            this.friendCall.UseVisualStyleBackColor = true;
            this.friendCall.Click += new System.EventHandler(this.friendCall_Click);
            // 
            // twoChances
            // 
            this.twoChances.Location = new System.Drawing.Point(443, 330);
            this.twoChances.Name = "twoChances";
            this.twoChances.Size = new System.Drawing.Size(91, 56);
            this.twoChances.TabIndex = 11;
            this.twoChances.Text = "Право на ошибку";
            this.twoChances.UseVisualStyleBackColor = true;
            this.twoChances.Click += new System.EventHandler(this.twoChances_Click);
            // 
            // changeQ
            // 
            this.changeQ.Location = new System.Drawing.Point(570, 330);
            this.changeQ.Name = "changeQ";
            this.changeQ.Size = new System.Drawing.Size(91, 56);
            this.changeQ.TabIndex = 12;
            this.changeQ.Text = "Замена вопроса";
            this.changeQ.UseVisualStyleBackColor = true;
            this.changeQ.Click += new System.EventHandler(this.changeQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 562);
            this.Controls.Add(this.changeQ);
            this.Controls.Add(this.twoChances);
            this.Controls.Add(this.friendCall);
            this.Controls.Add(this.zalHelp);
            this.Controls.Add(this.btn5050);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Button btn5050;
        private System.Windows.Forms.Button zalHelp;
        private System.Windows.Forms.Button twoChances;
        private System.Windows.Forms.Button changeQ;
        public System.Windows.Forms.Button friendCall;
    }
}

