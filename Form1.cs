using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo
{
    public partial class btCopyLog : Form
    {

        public btCopyLog()
        {
            InitializeComponent();

            //btNewBoard.Click += btNewBoard_Click;
            //btOpenCell.Click += btOpenCell_Click;
            //btTest.Click += btTest_Click;

        }

        int setTotalBrands = 25;

        private static Random rng = new Random();
        List<string> brandNames = new List<string> {
                "구찌" ,"에르메스","고야드","프라다","생로랑","버버리","코스","나이키","메종키츠네"
                ,"스톤아일랜드","홀리넘버세븐","라메레이","프롬웨얼","바이바이섭","리이","노이어","브르아시스","헤이","아르테미데"
                ,"빕","앤트레디션","드롱기","피암","SK2","바이레도" };
        //"라메르","에스티로더","조말론","지방시","아미","폴로랄프로렌","아크네스튜디오","비비안웨스트우드","톰브라운","띠어리","산드로","마쥬","아페쎄","딥티크"
        //   ,"메종마르지엘라","디올","몽클레어","보테가베네타","발렌시아가","펜디","르메르","마르니","코치","마이클코어스"
        //   ,"티파니앤코","페라가모","셀린느","막스마라","알렉산더맥퀸","발렌티노","몽블랑","이자벨마랑","골든구스","미우미우"
        //   ,"토리버치","무스너클","끌로에","오프화이트","로에베","겐조","로저비비에","질샌더","토즈","멀버리"
        //   ,"톰포드","가니","지미추","꼼데가르송","마크제이콥스","쟈딕앤볼테르","폴스미스","스튜어트와이츠먼","닐바렛","아르켓"
        private void btNewBoard_Click(object sender, EventArgs e)
        {


            //80개의 브랜드목록을 랜덤으로 빙고판에 부여함
            
           


            //brandNames.Sort((a, b) => new Random().NextDouble() >= 0.5 ? 1 : -1);

            //int pickBrand;
            //string randomBrand;
            List<string> UserBrands = new List<string>();
            //var shuffledcards = brandNames.OrderBy(a => Guid.NewGuid()).ToList();

            var shuffledcards = brandNames.OrderBy(a => rng.Next()).ToList();
            //for ( int i = 0; i < brandNames.Count; i++)
            //{
            //    pickBrand = randIndex.Next(0, 24);

            //    randomBrand = brandNames[pickBrand];
            //    //if (UserBrands.Count == 0)
            //    //{
            //    //    UserBrands.Add(randomBrand);

            //    //    continue;
            //    //}
            //    if (UserBrands.Contains(randomBrand))
            //    {
            //        i--;
            //        continue;
            //    }
            //    UserBrands.Add(randomBrand);

            //}

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
            tb17.Text = shuffledcards[16];
            tb18.Text = shuffledcards[17];
            tb19.Text = shuffledcards[18];
            tb20.Text = shuffledcards[19];
            tb21.Text = shuffledcards[20];
            tb22.Text = shuffledcards[21];
            tb23.Text = shuffledcards[22];
            tb24.Text = shuffledcards[23];
            tb25.Text = shuffledcards[24];

            colorReset();


            tbTicket.Text = tbSetTotalPlay.Text;
            tbBrandNameCheck.Text = "";
            tbBingoLine.Text = "";

        }
        private void btOpenCell_Click(object sender, EventArgs e)
        {
            
            
            //int pickBrand;
            //string randomBrand;
            List<string> UserBrands = new List<string>();


            var shuffledcards = brandNames.OrderBy(a => rng.Next()).ToList();
            UserBrands = shuffledcards;
            // List<string> UsedBrands = new List<string>();
            int ticketCount = int.Parse(tbSetTotalPlay.Text);


            //받은 브랜드 보드판에 체크하기
            for (int j = 0; j < int.Parse(tbSetTotalPlay.Text); j++)
            {
                tbBrandNameCheck.Text = UserBrands[j];
                ticketCount--;
                tbTicket.Text = ticketCount.ToString();
                // 만약에 확인한 브랜드가 테이블에 있다면, 해당 칸의 색을 바꿈

                if (tb1.Text == tbBrandNameCheck.Text)
                {
                    tb1.BackColor = Color.Red;
                    continue;
                }
                if (tb2.Text == tbBrandNameCheck.Text)
                {
                    tb2.BackColor = Color.Red;
                    continue;
                }
                if (tb3.Text == tbBrandNameCheck.Text)
                {
                    tb3.BackColor = Color.Red;
                    continue;
                }
                if (tb4.Text == tbBrandNameCheck.Text)
                {
                    tb4.BackColor = Color.Red;
                    continue;
                }
                if (tb5.Text == tbBrandNameCheck.Text)
                {
                    tb5.BackColor = Color.Red;
                    continue;
                }
                if (tb6.Text == tbBrandNameCheck.Text)
                {
                    tb6.BackColor = Color.Red;
                    continue;
                }
                if (tb7.Text == tbBrandNameCheck.Text)
                {
                    tb7.BackColor = Color.Red;
                    continue;
                }
                if (tb8.Text == tbBrandNameCheck.Text)
                {
                    tb8.BackColor = Color.Red;
                    continue;
                }
                if (tb9.Text == tbBrandNameCheck.Text)
                {
                    tb9.BackColor = Color.Red;
                    continue;
                }
                if (tb10.Text == tbBrandNameCheck.Text)
                {
                    tb10.BackColor = Color.Red;
                    continue;
                }
                if (tb11.Text == tbBrandNameCheck.Text)
                {
                    tb11.BackColor = Color.Red;
                    continue;
                }
                if (tb12.Text == tbBrandNameCheck.Text)
                {
                    tb12.BackColor = Color.Red;
                    continue;
                }
                if (tb13.Text == tbBrandNameCheck.Text)
                {
                    tb13.BackColor = Color.Red;
                    continue;
                }
                if (tb14.Text == tbBrandNameCheck.Text)
                {
                    tb14.BackColor = Color.Red;
                    continue;
                }
                if (tb15.Text == tbBrandNameCheck.Text)
                {
                    tb15.BackColor = Color.Red;
                    continue;
                }
                if (tb16.Text == tbBrandNameCheck.Text)
                {
                    tb16.BackColor = Color.Red;
                    continue;
                }
                if (tb17.Text == tbBrandNameCheck.Text)
                {
                    tb17.BackColor = Color.Red;
                    continue;
                }
                if (tb18.Text == tbBrandNameCheck.Text)
                {
                    tb18.BackColor = Color.Red;
                    continue;
                }
                if (tb19.Text == tbBrandNameCheck.Text)
                {
                    tb19.BackColor = Color.Red;
                    continue;
                }
                if (tb20.Text == tbBrandNameCheck.Text)
                {
                    tb20.BackColor = Color.Red;
                    continue;
                }
                if (tb21.Text == tbBrandNameCheck.Text)
                {
                    tb21.BackColor = Color.Red;
                    continue;
                }
                if (tb22.Text == tbBrandNameCheck.Text)
                {
                    tb22.BackColor = Color.Red;
                    continue;
                }
                if (tb23.Text == tbBrandNameCheck.Text)
                {
                    tb23.BackColor = Color.Red;
                    continue;
                }
                if (tb24.Text == tbBrandNameCheck.Text)
                {
                    tb24.BackColor = Color.Red;
                    continue;
                }
                if (tb25.Text == tbBrandNameCheck.Text)
                {
                    tb25.BackColor = Color.Red;
                    continue;
                }

                // 로직추가필요: 한번 체크한 브랜드 이름은 UserBrands에서 제외함 (btNewBoard클릭 전까지)

                //UsedBrands.Add(UserBrands[j]);
            }

            int Bingo = 0;
            //가로빙고완성
            if (tb1.BackColor == Color.Red && tb2.BackColor == Color.Red && tb3.BackColor == Color.Red && tb4.BackColor == Color.Red && tb5.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb6.BackColor == Color.Red && tb7.BackColor == Color.Red && tb8.BackColor == Color.Red && tb9.BackColor == Color.Red && tb10.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb11.BackColor == Color.Red && tb12.BackColor == Color.Red && tb13.BackColor == Color.Red && tb14.BackColor == Color.Red && tb15.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb16.BackColor == Color.Red && tb17.BackColor == Color.Red && tb18.BackColor == Color.Red && tb19.BackColor == Color.Red && tb20.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb21.BackColor == Color.Red && tb22.BackColor == Color.Red && tb23.BackColor == Color.Red && tb24.BackColor == Color.Red && tb25.BackColor == Color.Red)
            {
                Bingo++;
            }
            //세로빙고완성
            if (tb1.BackColor == Color.Red && tb6.BackColor == Color.Red && tb11.BackColor == Color.Red && tb16.BackColor == Color.Red && tb21.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb2.BackColor == Color.Red && tb7.BackColor == Color.Red && tb12.BackColor == Color.Red && tb17.BackColor == Color.Red && tb22.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb3.BackColor == Color.Red && tb8.BackColor == Color.Red && tb13.BackColor == Color.Red && tb18.BackColor == Color.Red && tb23.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb4.BackColor == Color.Red && tb9.BackColor == Color.Red && tb14.BackColor == Color.Red && tb19.BackColor == Color.Red && tb24.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb5.BackColor == Color.Red && tb10.BackColor == Color.Red && tb15.BackColor == Color.Red && tb20.BackColor == Color.Red && tb25.BackColor == Color.Red)
            {
                Bingo++;
            }
            //대각선빙고완성
            if (tb1.BackColor == Color.Red && tb7.BackColor == Color.Red && tb13.BackColor == Color.Red && tb19.BackColor == Color.Red && tb25.BackColor == Color.Red)
            {
                Bingo++;
            }
            if (tb5.BackColor == Color.Red && tb9.BackColor == Color.Red && tb13.BackColor == Color.Red && tb17.BackColor == Color.Red && tb21.BackColor == Color.Red)
            {
                Bingo++;
            }

            tbBingoLine.Text = Bingo.ToString();
            turn++;
            EventLog.Items.Add(turn + "회차/브랜드(" + setTotalBrands + "개) 중" + tbSetTotalPlay.Text + "번 시도 시 완성된 빙고줄 :" + Bingo.ToString());
        }
        private void colorReset()
        {
            tb1.BackColor = Color.White;
            tb2.BackColor = Color.White;
            tb3.BackColor = Color.White;
            tb4.BackColor = Color.White;
            tb5.BackColor = Color.White;
            tb6.BackColor = Color.White;
            tb7.BackColor = Color.White;
            tb8.BackColor = Color.White;
            tb9.BackColor = Color.White;
            tb10.BackColor = Color.White;
            tb11.BackColor = Color.White;
            tb12.BackColor = Color.White;
            tb13.BackColor = Color.White;
            tb14.BackColor = Color.White;
            tb15.BackColor = Color.White;
            tb16.BackColor = Color.White;
            tb17.BackColor = Color.White;
            tb18.BackColor = Color.White;
            tb19.BackColor = Color.White;
            tb20.BackColor = Color.White;
            tb21.BackColor = Color.White;
            tb22.BackColor = Color.White;
            tb23.BackColor = Color.White;
            tb24.BackColor = Color.White;
            tb25.BackColor = Color.White;
        }
        int turn = 0;


        private void btTest_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 500; i++)
            {

                btNewBoard_Click(null, null);
                Thread.Sleep(15);
                btOpenCell_Click(null, null);


            }
        }


        //로그 카피
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in EventLog.Items)
            {
                sb.Append(item.ToString() + "\n");
            }

            Clipboard.SetText(sb.ToString());
        }
    }
}
