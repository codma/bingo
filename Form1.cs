using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo
{
    public partial class mainForm : Form
    {
        #region 변수 선언
        List<TextBox> tbs;
        int totalPlay;
        int setTotalBrands;
        int turn;
        List<string> brandNames;
        List<string> shuffleBrandNames;
        #endregion

        public mainForm()
        {
            InitializeComponent();
            Init();
            InitControls();
            InitEvents();
            //btNewBoard.Click += btNewBoard_Click;
            //btOpenCell.Click += btOpenCell_Click;
            //btTest.Click += btTest_Click;

        }

        #region 초기화
        public void Init()
        {
            tbs = new List<TextBox>() { tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9, tb10, tb11, tb12, tb13, tb14, tb15, tb16 };
            brandNames = new List<string> {
                "구찌" ,"에르메스","고야드","프라다","생로랑","버버리","코스","나이키","메종키츠네"
                ,"스톤아일랜드","홀리넘버세븐","라메레이","프롬웨얼","바이바이섭","리이","노이어"
                ,"브르아시스","헤이","아르테미데"
                ,"빕","앤트레디션","드롱기","피암","SK2","바이레도"
                ,"라메르","에스티로더","조말론","지방시","아미","폴로랄프로렌","아크네스튜디오","비비안웨스트우드","톰브라운","띠어리","산드로","마쥬","아페쎄","딥티크"
                 ,"메종마르지엘라","디올","몽클레어","보테가베네타","발렌시아가","펜디","르메르","마르니","코치","마이클코어스"
                 ,"티파니앤코","페라가모","셀린느","막스마라","알렉산더맥퀸","발렌티노","몽블랑","이자벨마랑","골든구스","미우미우"
                 ,"토리버치","무스너클","끌로에","오프화이트","로에베","겐조","로저비비에","질샌더","토즈","멀버리"
                 ,"톰포드","가니","지미추","꼼데가르송","마크제이콥스","쟈딕앤볼테르","폴스미스","스튜어트와이츠먼","닐바렛","아르켓" };
            setTotalBrands = 0;
            turn = 0;
        }

        public void InitControls()
        {
            try
            {
                totalPlay = int.Parse(tbSetTotalPlay.Text);
            }
            catch (FormatException)
            {
                totalPlay = 0;
            }
        }

        public void InitEvents()
        {
            btnFileSave.Click += BtnFileSave_Click;
        }

        #endregion

        #region Events
        private void btNewBoard_Click(object sender, EventArgs e)
        {
            NewBoardSet();
        }

        private void btOpenCell_Click(object sender, EventArgs e)
        {
            OpenCellPlay();
        }

        private void btTest_Click(object sender, EventArgs e)
        {
          ///  for (int ownPlayCount = 5; ownPlayCount < 16; ownPlayCount++)
            {
                totalPlay = 15;
                for (int i = 0; i < 1000; i++)
                {
                    NewBoardSet(false);
                    Thread.Sleep(15);
                    OpenCellPlay(false);
                }
            }
        }

        /// <summary>
        /// 로그 카피 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in EventLog.Items)
            {
                sb.Append(item.ToString() + "\n");
            }

            Clipboard.SetText(sb.ToString());
        }

        /// <summary>
        /// 로그 리셋 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogReset_Click(object sender, EventArgs e)
        {
            EventLog.Items.Clear();
            turn = 0;
        }

        /// <summary>
        /// 로그 파일 저장 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in EventLog.Items)
            {
                sb.Append(item.ToString() + "\n");
            }

            string savePath = @"C:\bingo\bingo.txt";

            // 폴더 접근
            DirectoryInfo di = new DirectoryInfo(@"C:\bingo");
            // 폴더 없으면
            if(!di.Exists)
            {
                // 생성
                di.Create();
            }
            System.IO.File.WriteAllText(savePath, sb.ToString(), Encoding.Default);
        }

        #endregion

        #region 함수
        private void NewBoardSet(bool flag = true)
        {
            if (flag)
            {
                totalPlay = int.Parse(tbSetTotalPlay.Text);
            }

            setTotalBrands = int.Parse(tbTotalBrands.Text);
            List<string> UserBrands = new List<string>();

            // var shuffledcards = brandNames.OrderBy(a => rng.Next()).ToList();

            var shuffledcards = brandNames.OrderBy(a => Guid.NewGuid()).ToList();

            shuffleBrandNames = shuffledcards.GetRange(0, setTotalBrands);

            tb1.Text = shuffledcards[0];
            tb2.Text = shuffledcards[1];
            tb3.Text = shuffledcards[2];
            tb4.Text = shuffledcards[3];
            tb5.Text = shuffledcards[4];
            tb6.Text = shuffledcards[5];
            tb7.Text = shuffledcards[6];
            tb8.Text = shuffledcards[7];
            tb9.Text = shuffledcards[8];
            tb10.Text = shuffledcards[9];
            tb11.Text = shuffledcards[10];
            tb12.Text = shuffledcards[11];
            tb13.Text = shuffledcards[12];
            tb14.Text = shuffledcards[13];
            tb15.Text = shuffledcards[14];
            tb16.Text = shuffledcards[15];

            colorReset();

            tbTicket.Text = totalPlay.ToString();
            tbBrandNameCheck.Text = "";
            tbBingoLine.Text = "";
        }

        private void OpenCellPlay(bool flag = true)
        {
            if (flag)
            {
                totalPlay = int.Parse(tbSetTotalPlay.Text);
            }

            var shuffledcards = shuffleBrandNames.OrderBy(a => Guid.NewGuid()).ToList();
            int ticketCount = totalPlay;
            // 

            //받은 브랜드 보드판에 체크하기
            for (int j = 0; j < totalPlay; j++)
            {
                tbBrandNameCheck.Text = shuffledcards[j];
                ticketCount--;
                tbTicket.Text = ticketCount.ToString();

                // 만약에 확인한 브랜드가 테이블에 있다면, 해당 칸의 색을 바꿈
                CheckTbText(tb1, shuffledcards[j]);
                CheckTbText(tb2, shuffledcards[j]);
                CheckTbText(tb3, shuffledcards[j]);
                CheckTbText(tb4, shuffledcards[j]);
                CheckTbText(tb5, shuffledcards[j]);
                CheckTbText(tb6, shuffledcards[j]);
                CheckTbText(tb7, shuffledcards[j]);
                CheckTbText(tb8, shuffledcards[j]);
                CheckTbText(tb9, shuffledcards[j]);
                CheckTbText(tb10, shuffledcards[j]);
                CheckTbText(tb11, shuffledcards[j]);
                CheckTbText(tb12, shuffledcards[j]);
                CheckTbText(tb13, shuffledcards[j]);
                CheckTbText(tb14, shuffledcards[j]);
                CheckTbText(tb15, shuffledcards[j]);
                CheckTbText(tb16, shuffledcards[j]);
            }

            int Bingo = 0;
            //가로빙고완성
            Bingo += CheckBingo(tb1, tb2, tb3, tb4);
            Bingo += CheckBingo(tb5, tb6, tb7, tb8);
            Bingo += CheckBingo(tb9, tb10, tb11, tb12);
            Bingo += CheckBingo(tb13, tb14, tb15, tb16);

            //세로빙고완성
            Bingo += CheckBingo(tb1, tb5, tb9, tb13);
            Bingo += CheckBingo(tb2, tb6, tb10, tb14);
            Bingo += CheckBingo(tb3, tb7, tb11, tb15);
            Bingo += CheckBingo(tb4, tb8, tb12, tb16);

            //대각선빙고완성
            Bingo += CheckBingo(tb1, tb6, tb11, tb16);
            Bingo += CheckBingo(tb13, tb10, tb7, tb4);

            #region 레거시 코드
            //if (tb1.BackColor == Color.Red && tb2.BackColor == Color.Red && tb3.BackColor == Color.Red && tb4.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}
            //if (tb5.BackColor == Color.Red && tb6.BackColor == Color.Red && tb7.BackColor == Color.Red && tb8.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}
            //if (tb9.BackColor == Color.Red && tb10.BackColor == Color.Red && tb11.BackColor == Color.Red && tb12.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}
            //if (tb13.BackColor == Color.Red && tb14.BackColor == Color.Red && tb15.BackColor == Color.Red && tb16.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}

            //세로빙고완성
            //if (tb1.BackColor == Color.Red && tb5.BackColor == Color.Red && tb9.BackColor == Color.Red && tb13.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}

            //if (tb2.BackColor == Color.Red && tb6.BackColor == Color.Red && tb10.BackColor == Color.Red && tb14.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}
            //if (tb3.BackColor == Color.Red && tb7.BackColor == Color.Red && tb11.BackColor == Color.Red && tb15.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}
            //if (tb4.BackColor == Color.Red && tb8.BackColor == Color.Red && tb12.BackColor == Color.Red && tb16.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}

            //대각선빙고완성
            //if (tb1.BackColor == Color.Red && tb6.BackColor == Color.Red && tb11.BackColor == Color.Red && tb16.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}
            //if (tb4.BackColor == Color.Red && tb7.BackColor == Color.Red && tb10.BackColor == Color.Red && tb13.BackColor == Color.Red)
            //{
            //    Bingo++;
            //}
            #endregion

            tbBingoLine.Text = Bingo.ToString();
            turn++;
            EventLog.Items.Add(turn + "회차/브랜드(" + setTotalBrands + "개) 중" + totalPlay + "번 시도 시 완성된 빙고줄 :" + Bingo.ToString());
        }

        public int CheckBingo(params TextBox[] tbs)
        {
            int result = 0;
            int CheckCount = 0;
            for (int i = 0; i < tbs.Length; i++)
            {
                if (tbs[i].BackColor == Color.Red)
                {
                    CheckCount++;
                }
            }

            if (CheckCount == tbs.Length)
            {
                result++;
            }

            return result;
        }

        public bool CheckTbText(TextBox commonTextBox, string compareText)
        {
            bool result = false;

            if (commonTextBox.Text.Equals(compareText))
            {
                commonTextBox.BackColor = Color.Red;
                result = true;
            }

            return result;
        }

        private void colorReset()
        {
            foreach (var item in tbs)
            {
                item.BackColor = Color.White;
            }

            //tb1.BackColor = Color.White;
            //tb2.BackColor = Color.White;
            //tb3.BackColor = Color.White;
            //tb4.BackColor = Color.White;
            //tb5.BackColor = Color.White;
            //tb6.BackColor = Color.White;
            //tb7.BackColor = Color.White;
            //tb8.BackColor = Color.White;
            //tb9.BackColor = Color.White;
            //tb10.BackColor = Color.White;
            //tb11.BackColor = Color.White;
            //tb12.BackColor = Color.White;
            //tb13.BackColor = Color.White;
            //tb14.BackColor = Color.White;
            //tb15.BackColor = Color.White;
            //tb16.BackColor = Color.White;
        }
        #endregion
    }
}
