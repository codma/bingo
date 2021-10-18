
namespace bingo
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btNewBoard = new System.Windows.Forms.Button();
            this.btOpenCell = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb15 = new System.Windows.Forms.TextBox();
            this.tb14 = new System.Windows.Forms.TextBox();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb16 = new System.Windows.Forms.TextBox();
            this.tbBrandNameCheck = new System.Windows.Forms.TextBox();
            this.lbCheck = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBingoLine = new System.Windows.Forms.TextBox();
            this.EventLog = new System.Windows.Forms.ListBox();
            this.btTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSetTotalPlay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalBrands = new System.Windows.Forms.TextBox();
            this.btnFileSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(242, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "브랜드 빙고게임";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNewBoard
            // 
            this.btNewBoard.Location = new System.Drawing.Point(494, 112);
            this.btNewBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNewBoard.Name = "btNewBoard";
            this.btNewBoard.Size = new System.Drawing.Size(150, 18);
            this.btNewBoard.TabIndex = 1;
            this.btNewBoard.Text = "빙고판 받기";
            this.btNewBoard.UseVisualStyleBackColor = true;
            this.btNewBoard.Click += new System.EventHandler(this.btNewBoard_Click);
            // 
            // btOpenCell
            // 
            this.btOpenCell.Location = new System.Drawing.Point(274, 312);
            this.btOpenCell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOpenCell.Name = "btOpenCell";
            this.btOpenCell.Size = new System.Drawing.Size(106, 18);
            this.btOpenCell.TabIndex = 3;
            this.btOpenCell.Text = "빙고 열기";
            this.btOpenCell.UseVisualStyleBackColor = true;
            this.btOpenCell.Click += new System.EventHandler(this.btOpenCell_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(55, 155);
            this.tb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(114, 21);
            this.tb1.TabIndex = 4;
            this.tb1.Tag = "1";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(174, 155);
            this.tb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(114, 21);
            this.tb2.TabIndex = 5;
            this.tb2.Tag = "2";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(293, 155);
            this.tb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(114, 21);
            this.tb3.TabIndex = 6;
            this.tb3.Tag = "3";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(412, 155);
            this.tb4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(114, 21);
            this.tb4.TabIndex = 7;
            this.tb4.Tag = "4";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(57, 180);
            this.tb5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(114, 21);
            this.tb5.TabIndex = 8;
            this.tb5.Tag = "5";
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(176, 205);
            this.tb10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(114, 21);
            this.tb10.TabIndex = 13;
            this.tb10.Tag = "10";
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(57, 205);
            this.tb9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(114, 21);
            this.tb9.TabIndex = 12;
            this.tb9.Tag = "9";
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(412, 180);
            this.tb8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(114, 21);
            this.tb8.TabIndex = 11;
            this.tb8.Tag = "8";
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(293, 180);
            this.tb7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(114, 21);
            this.tb7.TabIndex = 10;
            this.tb7.Tag = "7";
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(175, 179);
            this.tb6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(114, 21);
            this.tb6.TabIndex = 9;
            this.tb6.Tag = "6";
            // 
            // tb15
            // 
            this.tb15.Location = new System.Drawing.Point(295, 230);
            this.tb15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(114, 21);
            this.tb15.TabIndex = 18;
            this.tb15.Tag = "15";
            // 
            // tb14
            // 
            this.tb14.Location = new System.Drawing.Point(176, 230);
            this.tb14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb14.Name = "tb14";
            this.tb14.Size = new System.Drawing.Size(114, 21);
            this.tb14.TabIndex = 17;
            this.tb14.Tag = "14";
            // 
            // tb13
            // 
            this.tb13.Location = new System.Drawing.Point(57, 230);
            this.tb13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(114, 21);
            this.tb13.TabIndex = 16;
            this.tb13.Tag = "13";
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(412, 205);
            this.tb12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(114, 21);
            this.tb12.TabIndex = 15;
            this.tb12.Tag = "12";
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(293, 205);
            this.tb11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(114, 21);
            this.tb11.TabIndex = 14;
            this.tb11.Tag = "11";
            // 
            // tb16
            // 
            this.tb16.Location = new System.Drawing.Point(414, 230);
            this.tb16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb16.Name = "tb16";
            this.tb16.Size = new System.Drawing.Size(114, 21);
            this.tb16.TabIndex = 19;
            this.tb16.Tag = "16";
            // 
            // tbBrandNameCheck
            // 
            this.tbBrandNameCheck.Location = new System.Drawing.Point(539, 294);
            this.tbBrandNameCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBrandNameCheck.Name = "tbBrandNameCheck";
            this.tbBrandNameCheck.Size = new System.Drawing.Size(106, 21);
            this.tbBrandNameCheck.TabIndex = 29;
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(423, 296);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(69, 12);
            this.lbCheck.TabIndex = 30;
            this.lbCheck.Text = "브랜드 확인";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(52, 314);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(97, 12);
            this.lbCount.TabIndex = 31;
            this.lbCount.Text = "남은 빙고 이용권";
            // 
            // tbTicket
            // 
            this.tbTicket.Location = new System.Drawing.Point(174, 312);
            this.tbTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTicket.Name = "tbTicket";
            this.tbTicket.Size = new System.Drawing.Size(88, 21);
            this.tbTicket.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "완성된 빙고줄!";
            // 
            // tbBingoLine
            // 
            this.tbBingoLine.Location = new System.Drawing.Point(539, 331);
            this.tbBingoLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBingoLine.Name = "tbBingoLine";
            this.tbBingoLine.Size = new System.Drawing.Size(106, 21);
            this.tbBingoLine.TabIndex = 34;
            // 
            // EventLog
            // 
            this.EventLog.FormattingEnabled = true;
            this.EventLog.ItemHeight = 12;
            this.EventLog.Location = new System.Drawing.Point(54, 384);
            this.EventLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventLog.Name = "EventLog";
            this.EventLog.Size = new System.Drawing.Size(591, 136);
            this.EventLog.TabIndex = 35;
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(494, 89);
            this.btTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(150, 18);
            this.btTest.TabIndex = 36;
            this.btTest.Text = "100회 테스트";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "빙고 이용권 부여";
            // 
            // tbSetTotalPlay
            // 
            this.tbSetTotalPlay.Location = new System.Drawing.Point(192, 90);
            this.tbSetTotalPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSetTotalPlay.Name = "tbSetTotalPlay";
            this.tbSetTotalPlay.Size = new System.Drawing.Size(88, 21);
            this.tbSetTotalPlay.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 18);
            this.button1.TabIndex = 39;
            this.button1.Text = "Clipboard(log)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogReset
            // 
            this.btnLogReset.Location = new System.Drawing.Point(578, 524);
            this.btnLogReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogReset.Name = "btnLogReset";
            this.btnLogReset.Size = new System.Drawing.Size(66, 18);
            this.btnLogReset.TabIndex = 40;
            this.btnLogReset.Text = "log reset";
            this.btnLogReset.UseVisualStyleBackColor = true;
            this.btnLogReset.Click += new System.EventHandler(this.btnLogReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "브랜드 갯수 설정";
            // 
            // tbTotalBrands
            // 
            this.tbTotalBrands.Location = new System.Drawing.Point(192, 58);
            this.tbTotalBrands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalBrands.Name = "tbTotalBrands";
            this.tbTotalBrands.Size = new System.Drawing.Size(88, 21);
            this.tbTotalBrands.TabIndex = 42;
            // 
            // btnFileSave
            // 
            this.btnFileSave.Location = new System.Drawing.Point(366, 524);
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(75, 23);
            this.btnFileSave.TabIndex = 43;
            this.btnFileSave.Text = "파일 저장";
            this.btnFileSave.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 570);
            this.Controls.Add(this.btnFileSave);
            this.Controls.Add(this.tbTotalBrands);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSetTotalPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.EventLog);
            this.Controls.Add(this.tbBingoLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.tbBrandNameCheck);
            this.Controls.Add(this.tb16);
            this.Controls.Add(this.tb15);
            this.Controls.Add(this.tb14);
            this.Controls.Add(this.tb13);
            this.Controls.Add(this.tb12);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb9);
            this.Controls.Add(this.tb8);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btOpenCell);
            this.Controls.Add(this.btNewBoard);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Brand Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNewBoard;
        private System.Windows.Forms.Button btOpenCell;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb15;
        private System.Windows.Forms.TextBox tb14;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb16;
        private System.Windows.Forms.TextBox tbBrandNameCheck;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBingoLine;
        private System.Windows.Forms.ListBox EventLog;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSetTotalPlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotalBrands;
        private System.Windows.Forms.Button btnFileSave;
    }
}

