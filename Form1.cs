using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
   
            btNewBoard.Click += btNewBoard_Click;
            btOpenCell.Click += btOpenCell_Click;

            
        }



        private TextBox CreateTextbox(string name, string text)
        {
            TextBox tb = new TextBox();
            tb.Name = name;
            tb.Text = text;

            return tb;
        }

        private void btNewBoard_Click(object sender, EventArgs e)
        {


           

            //80개의 브랜드목록을 랜덤으로 빙고판에 부여함
            string[] brandNames = new string[] {
                "구찌" ,"에르메스","고야드","프라다","생로랑","버버리","코스","나이키","메종키츠네"
                ,"스톤아일랜드","홀리넘버세븐","라메레이","프롬웨얼","바이바이섭","리이","노이어","브르아시스","헤이","아르테미데"
                ,"빕","앤드레디션","드롱기","피암","SK2","바이레도","라메르","에스티로더","조말론","지방시"
                ,"아미","폴로랄프로렌","아크네스튜디오","비비안웨스트우드","톰브라운","띠어리","산드로","마쥬","아페쎄","딥티크"
                ,"메종마르지엘라","디올","몽클레어","보테가베네타","발렌시아가","펜디","르메르","마르니","코치","마이클코어스"
                ,"티파니앤코","페라가모","셀린느","막스마라","알렉산더맥퀸","발렌티노","몽블랑","이자벨마랑","골든구스","미우미우"
                ,"토리버치","무스너클","끌로에","오프화이트","로에베","겐조","로저비비에","질샌더","토즈","멀버리"
                ,"톰포드","가니","지미추","꼼데가르송","마크제이콥스","쟈딕앤볼테르","폴스미스","스튜어트와이츠먼","닐바렛","아르켓"};

            Random randIndex = new Random();
            int pickBrand;
            string randomBrand;
            List<string> UserBrands = new List<string>();

            for (int i = 0; i < 25; i++)
            {
                pickBrand = randIndex.Next(0, 79);
                randomBrand = brandNames[pickBrand];
                if (UserBrands.Count == 0)
                {
                    UserBrands.Add(randomBrand);
                    continue;
                }
                if (UserBrands.Contains(randomBrand))
                {
                    i--;
                    continue;
                }
                UserBrands.Add(randomBrand);
            }

            tb1.Text = UserBrands[0];
            tb2.Text = UserBrands[1];
            tb3.Text = UserBrands[2];
            tb4.Text = UserBrands[3];
            tb5.Text = UserBrands[4];
            tb6.Text = UserBrands[5];
            tb7.Text = UserBrands[6];
            tb8.Text = UserBrands[7];
            tb9.Text = UserBrands[8];
            tb10.Text = UserBrands[9];
            tb11.Text = UserBrands[10];
            tb12.Text = UserBrands[11];
            tb13.Text = UserBrands[12];
            tb14.Text = UserBrands[13];
            tb15.Text = UserBrands[14];
            tb16.Text = UserBrands[15];
            tb17.Text = UserBrands[16];
            tb18.Text = UserBrands[17];
            tb19.Text = UserBrands[18];
            tb20.Text = UserBrands[19];
            tb21.Text = UserBrands[20];
            tb22.Text = UserBrands[21];
            tb23.Text = UserBrands[22];
            tb24.Text = UserBrands[23];
            tb25.Text = UserBrands[24];

            tbTicket.Text = "30";
            tbBrandNameCheck.Text = "";
        }

        private void btOpenCell_Click(object sender, EventArgs e)
        {
            string[] brandNames = new string[] {
                "구찌" ,"에르메스","고야드","프라다","생로랑","버버리","코스","나이키","메종키츠네"
                ,"스톤아일랜드","홀리넘버세븐","라메레이","프롬웨얼","바이바이섭","리이","노이어","브르아시스","헤이","아르테미데"
                ,"빕","앤드레디션","드롱기","피암","SK2","바이레도","라메르","에스티로더","조말론","지방시"
                ,"아미","폴로랄프로렌","아크네스튜디오","비비안웨스트우드","톰브라운","띠어리","산드로","마쥬","아페쎄","딥티크"
                ,"메종마르지엘라","디올","몽클레어","보테가베네타","발렌시아가","펜디","르메르","마르니","코치","마이클코어스"
                ,"티파니앤코","페라가모","셀린느","막스마라","알렉산더맥퀸","발렌티노","몽블랑","이자벨마랑","골든구스","미우미우"
                ,"토리버치","무스너클","끌로에","오프화이트","로에베","겐조","로저비비에","질샌더","토즈","멀버리"
                ,"톰포드","가니","지미추","꼼데가르송","마크제이콥스","쟈딕앤볼테르","폴스미스","스튜어트와이츠먼","닐바렛","아르켓"};

            Random randIndex = new Random();
            int pickBrand;
            string randomBrand;
            List<string> UserBrands = new List<string>();

            
            //실제로는 출석한 수만큼 횟도전 가능하며, 임시로 30번이라고 가정함
            for (int i = 0; i < 30; i++)
            {
                pickBrand = randIndex.Next(0, 79);
                randomBrand = brandNames[pickBrand];
                if (UserBrands.Count == 0)
                {
                    UserBrands.Add(randomBrand);
                    continue;
                }
                if (UserBrands.Contains(randomBrand))
                {
                    i--;
                    continue;
                }
                UserBrands.Add(randomBrand);
            }

            List<string> UsedBrands = new List<string>();
            int ticketCount = 30;
            for (int j = 0; j < 30; j++)
            {
                tbBrandNameCheck.Text = UserBrands[j];
                ticketCount--;
                tbTicket.Text = ticketCount.ToString();
                // 만약에 확인한 브랜드가 테이블에 있다면, 해당 칸의 색을 바꿈
                if (UsedBrands.Contains(UserBrands[j]))
                {
                    j--;
                    continue;
                }
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
                
              
                UsedBrands.Add(UserBrands[j]);
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
        }
    }
}
