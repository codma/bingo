
namespace bingo
{
    partial class Form1
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
            this.tb20 = new System.Windows.Forms.TextBox();
            this.tb19 = new System.Windows.Forms.TextBox();
            this.tb18 = new System.Windows.Forms.TextBox();
            this.tb17 = new System.Windows.Forms.TextBox();
            this.tb16 = new System.Windows.Forms.TextBox();
            this.tb25 = new System.Windows.Forms.TextBox();
            this.tb24 = new System.Windows.Forms.TextBox();
            this.tb23 = new System.Windows.Forms.TextBox();
            this.tb22 = new System.Windows.Forms.TextBox();
            this.tb21 = new System.Windows.Forms.TextBox();
            this.tbBrandNameCheck = new System.Windows.Forms.TextBox();
            this.lbCheck = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBingoLine = new System.Windows.Forms.TextBox();
            this.EventLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(277, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "브랜드 빙고게임";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNewBoard
            // 
            this.btNewBoard.Location = new System.Drawing.Point(479, 289);
            this.btNewBoard.Name = "btNewBoard";
            this.btNewBoard.Size = new System.Drawing.Size(172, 23);
            this.btNewBoard.TabIndex = 1;
            this.btNewBoard.Text = "빙고판 받기";
            this.btNewBoard.UseVisualStyleBackColor = true;
            this.btNewBoard.Click += new System.EventHandler(this.btNewBoard_Click);
            // 
            // btOpenCell
            // 
            this.btOpenCell.Location = new System.Drawing.Point(479, 318);
            this.btOpenCell.Name = "btOpenCell";
            this.btOpenCell.Size = new System.Drawing.Size(121, 23);
            this.btOpenCell.TabIndex = 3;
            this.btOpenCell.Text = "빙고 열기";
            this.btOpenCell.UseVisualStyleBackColor = true;
            this.btOpenCell.Click += new System.EventHandler(this.btOpenCell_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(63, 128);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(130, 25);
            this.tb1.TabIndex = 4;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(199, 128);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(130, 25);
            this.tb2.TabIndex = 5;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(335, 128);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(130, 25);
            this.tb3.TabIndex = 6;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(471, 128);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(130, 25);
            this.tb4.TabIndex = 7;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(607, 128);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(130, 25);
            this.tb5.TabIndex = 8;
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(607, 159);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(130, 25);
            this.tb10.TabIndex = 13;
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(471, 159);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(130, 25);
            this.tb9.TabIndex = 12;
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(335, 159);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(130, 25);
            this.tb8.TabIndex = 11;
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(199, 159);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(130, 25);
            this.tb7.TabIndex = 10;
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(64, 158);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(130, 25);
            this.tb6.TabIndex = 9;
            // 
            // tb15
            // 
            this.tb15.Location = new System.Drawing.Point(607, 190);
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(130, 25);
            this.tb15.TabIndex = 18;
            // 
            // tb14
            // 
            this.tb14.Location = new System.Drawing.Point(471, 190);
            this.tb14.Name = "tb14";
            this.tb14.Size = new System.Drawing.Size(130, 25);
            this.tb14.TabIndex = 17;
            // 
            // tb13
            // 
            this.tb13.Location = new System.Drawing.Point(335, 190);
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(130, 25);
            this.tb13.TabIndex = 16;
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(199, 190);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(130, 25);
            this.tb12.TabIndex = 15;
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(63, 190);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(130, 25);
            this.tb11.TabIndex = 14;
            // 
            // tb20
            // 
            this.tb20.Location = new System.Drawing.Point(607, 221);
            this.tb20.Name = "tb20";
            this.tb20.Size = new System.Drawing.Size(130, 25);
            this.tb20.TabIndex = 23;
            // 
            // tb19
            // 
            this.tb19.Location = new System.Drawing.Point(471, 221);
            this.tb19.Name = "tb19";
            this.tb19.Size = new System.Drawing.Size(130, 25);
            this.tb19.TabIndex = 22;
            // 
            // tb18
            // 
            this.tb18.Location = new System.Drawing.Point(335, 221);
            this.tb18.Name = "tb18";
            this.tb18.Size = new System.Drawing.Size(130, 25);
            this.tb18.TabIndex = 21;
            // 
            // tb17
            // 
            this.tb17.Location = new System.Drawing.Point(199, 221);
            this.tb17.Name = "tb17";
            this.tb17.Size = new System.Drawing.Size(130, 25);
            this.tb17.TabIndex = 20;
            // 
            // tb16
            // 
            this.tb16.Location = new System.Drawing.Point(63, 221);
            this.tb16.Name = "tb16";
            this.tb16.Size = new System.Drawing.Size(130, 25);
            this.tb16.TabIndex = 19;
            // 
            // tb25
            // 
            this.tb25.Location = new System.Drawing.Point(607, 252);
            this.tb25.Name = "tb25";
            this.tb25.Size = new System.Drawing.Size(130, 25);
            this.tb25.TabIndex = 28;
            // 
            // tb24
            // 
            this.tb24.Location = new System.Drawing.Point(471, 252);
            this.tb24.Name = "tb24";
            this.tb24.Size = new System.Drawing.Size(130, 25);
            this.tb24.TabIndex = 27;
            // 
            // tb23
            // 
            this.tb23.Location = new System.Drawing.Point(335, 252);
            this.tb23.Name = "tb23";
            this.tb23.Size = new System.Drawing.Size(130, 25);
            this.tb23.TabIndex = 26;
            // 
            // tb22
            // 
            this.tb22.Location = new System.Drawing.Point(199, 252);
            this.tb22.Name = "tb22";
            this.tb22.Size = new System.Drawing.Size(130, 25);
            this.tb22.TabIndex = 25;
            // 
            // tb21
            // 
            this.tb21.Location = new System.Drawing.Point(63, 252);
            this.tb21.Name = "tb21";
            this.tb21.Size = new System.Drawing.Size(130, 25);
            this.tb21.TabIndex = 24;
            // 
            // tbBrandNameCheck
            // 
            this.tbBrandNameCheck.Location = new System.Drawing.Point(414, 374);
            this.tbBrandNameCheck.Name = "tbBrandNameCheck";
            this.tbBrandNameCheck.Size = new System.Drawing.Size(121, 25);
            this.tbBrandNameCheck.TabIndex = 29;
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(281, 377);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(87, 15);
            this.lbCheck.TabIndex = 30;
            this.lbCheck.Text = "브랜드 확인";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(196, 318);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(122, 15);
            this.lbCount.TabIndex = 31;
            this.lbCount.Text = "빙고 열기 이용권";
            // 
            // tbTicket
            // 
            this.tbTicket.Location = new System.Drawing.Point(336, 315);
            this.tbTicket.Name = "tbTicket";
            this.tbTicket.Size = new System.Drawing.Size(100, 25);
            this.tbTicket.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "완성된 빙고줄!";
            // 
            // tbBingoLine
            // 
            this.tbBingoLine.Location = new System.Drawing.Point(414, 421);
            this.tbBingoLine.Name = "tbBingoLine";
            this.tbBingoLine.Size = new System.Drawing.Size(121, 25);
            this.tbBingoLine.TabIndex = 34;
            // 
            // EventLog
            // 
            this.EventLog.FormattingEnabled = true;
            this.EventLog.ItemHeight = 15;
            this.EventLog.Location = new System.Drawing.Point(43, 488);
            this.EventLog.Name = "EventLog";
            this.EventLog.Size = new System.Drawing.Size(736, 169);
            this.EventLog.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 677);
            this.Controls.Add(this.EventLog);
            this.Controls.Add(this.tbBingoLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.tbBrandNameCheck);
            this.Controls.Add(this.tb25);
            this.Controls.Add(this.tb24);
            this.Controls.Add(this.tb23);
            this.Controls.Add(this.tb22);
            this.Controls.Add(this.tb21);
            this.Controls.Add(this.tb20);
            this.Controls.Add(this.tb19);
            this.Controls.Add(this.tb18);
            this.Controls.Add(this.tb17);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb19;
        private System.Windows.Forms.TextBox tb18;
        private System.Windows.Forms.TextBox tb17;
        private System.Windows.Forms.TextBox tb16;
        private System.Windows.Forms.TextBox tb25;
        private System.Windows.Forms.TextBox tb24;
        private System.Windows.Forms.TextBox tb23;
        private System.Windows.Forms.TextBox tb22;
        private System.Windows.Forms.TextBox tb21;
        private System.Windows.Forms.TextBox tbBrandNameCheck;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBingoLine;
        private System.Windows.Forms.ListBox EventLog;
    }
}

