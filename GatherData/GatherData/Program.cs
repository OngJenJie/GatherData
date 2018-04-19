using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatherData
{
    class Program
    {
        static void Main(string[] args)
        {

            // 匯入資料
            string[] name = { "葉俊廷", "張澤瑜", "王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "世新陳柏霖", "世新許子安", "世新方若帆" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] stuid = { "A106082026", "A106082016", "A106082062", "A106082054", "A104082006", "A106082029", "A106082046", "A106082030", "A106082022", "A106082034", "A103082022", "A106082020", "A106082011", "A106082024", "A105082201", "106082010", "A106082028", "a106082056", "a106082043", "A106082006", "A106082051", "A106082032", "a106082058", "A106082035", "a106082017", "A104082036", "A106082009", "a106082007", "A106082052", "A106082008", "A106082063", "A106082038", "A106082025", "A106082057", "A106082013", "A106082027", "A106082048", "a106082036", "A106082059", "a106082045", "A106082012", "A106082037", "A106082021", "A106082031", "A106082061", "A106082042", "A106082023", "A106082040", "A106082001", "a106082002", "A106082014", "A106082041", "A106082049", "A106082015", "A106082044", "A106082047", "A106082018", "A106082005", "A106082050", "a106082055", "A106082039", "A104082013", "A106082029", "", "A104040024", "A106082047", "A106082048", "a106082007" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            List<string> nname = new List<string>();

            // 宣告男女比例的變數
            int boyall_count = 0;
            int girlall_count = 0;

            // 宣告血型的變數
            int BloodO = 0;
            int BloodA = 0;
            int BloodB = 0;
            int BloodAB = 0;
            int other = 0;
            int none = 0;

            // 男女平均身高的變數
            int boycount = 0;
            int boysum = 0;
            int girlcount = 0;
            int girlsum = 0;

            // 宣告最高最低的變數
            int heightest = 0;
            string heightname = "";
            int Lowest = 199;
            string Lowname = "";

            int zodiacO_count = 0;

            for (int i = 0; i < height.Length; i++)
            {

                // 計算全部的男生
                if (gender[i] == "男")
                {
                    boyall_count++;
                }

                // 計算全部的女生
                if (gender[i] == "女")
                {
                    girlall_count++;
                }

                // 計算O血型的人數
                if (blood[i] == "O")
                {
                    BloodO++;
                }

                // 計算A血型的人數
                if (blood[i] == "A")
                {
                    BloodA++;
                }

                // 計算B血型的人數
                if (blood[i] == "B")
                {
                    BloodB++;
                }

                // 計算AB血型的人數
                if (blood[i] == "AB")
                {
                    BloodAB++;
                }

                // 計算其她血型的人數
                if (blood[i] == "其他")
                {
                    other++;
                }

                // 計算沒有填寫血型的人數
                if (blood[i] == "")
                {
                    none++;
                }

                // 過濾資料
                if (height[i] > 100 && height[i] < 200)
                {

                    // 計算男生總身高還有人數
                    if (gender[i] == "男")
                    {
                        boysum = boysum + height[i];
                        boycount++;
                    }

                    // 計算女生總身高還有人數
                    if (gender[i] == "女")
                    {
                        girlsum = girlsum + height[i];
                        girlcount++;
                    }

                    // 找出最高的人是誰還有多高
                    if (height[i] > heightest)
                    {
                        heightest = height[i];
                        heightname = name[i];
                    }

                    // 找出最矮的人是誰還有多高
                    if (height[i] < Lowest)
                    {
                        Lowest = height[i];
                        Lowname = name[i];
                    }
                }

                // 找尋同時是天蝎座 又是 O血型的人
                if (zodiac[i] == "天蠍" && blood[i] == "O")
                {
                    zodiacO_count++;
                    nname.Add(name[i]);

                }
            }

            // 計算男女百分比
            double boypercent = ((double)boyall_count / (double)name.Length) * 100;
            double girlpercent = ((double)girlall_count / (double)name.Length) * 100;

            // 計算血型百分比
            double BloodOpercent = ((double)BloodO / (double)blood.Length) * 100;
            double BloodApercent = ((double)BloodA / (double)blood.Length) * 100;
            double BloodBpercent = ((double)BloodB / (double)blood.Length) * 100;
            double BloodABpercent = ((double)BloodAB / (double)blood.Length) * 100;
            double otherpercent = ((double)other / (double)blood.Length) * 100;
            double nonepercent = ((double)none / (double)blood.Length) * 100;

            // 計算男女平均身高
            double boyaverageh = ((double)boysum / (double)boycount);
            double girlaverageh = ((double)girlsum / (double)girlcount);
            double pplsum = boycount + girlcount;
            double allaverageh = ((double)boysum + (double)girlsum) / pplsum;


            // 輸出結果
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  輸煤遊戲一甲資料卡:                   ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine("║           男生人數為: {0} 總共佔了: {1:0} %                ║", boyall_count, boypercent);
            Console.WriteLine("║           女生人數為: {0} 總共佔了: {1:0} %                ║", girlall_count, girlpercent);
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine("║          填寫O血型人數為: {0} 佔了: {1:0} %                ║", BloodO, BloodOpercent);
            Console.WriteLine("║          填寫A血型人數為: {0} 佔了: {1:0} %                ║", BloodA, BloodApercent);
            Console.WriteLine("║          填寫B血型人數為: {0} 佔了: {1:0} %                 ║", BloodB, BloodBpercent);
            Console.WriteLine("║          填寫AB血型人數為: {0} 佔了: {1:0} %                 ║", BloodAB, BloodABpercent);
            Console.WriteLine("║          填寫其他血型人數為: {0} 佔了: {1:0} %               ║", other, otherpercent);
            Console.WriteLine("║          沒有填寫血型人數為: {0} 佔了: {1:0}%                ║", none, nonepercent);
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine("║     有填寫正常身高的男生人數為: {0} 平均身高為: {1:0}     ║", boycount, boyaverageh);
            Console.WriteLine("║     有填寫正常身高的女生人數為: {0} 平均身高為: {1:0}     ║", girlcount, girlaverageh);
            Console.WriteLine("║     有填寫正常身高的男女人數為: {0} 平均身高為: {1:0}     ║", pplsum, allaverageh);
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine("║           同時是天蝎座又是O血型的人數為: {0}             ║", zodiacO_count);
            Console.WriteLine("║           他們的名字是:                                ║");
            for (int i = 0; i < nname.Count; i++)
            {
                Console.WriteLine("║            {0}. {1}                                   ║",i ,nname[i]);
            }
           Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine("║             班上最高是 {0} 他就是: {1}                ║", heightest, heightname);
            Console.WriteLine("║            班上最矮是 {0} 他就是: {1}               ║", Lowest, Lowname);
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");

            // 畫面暫停
            Console.ReadKey();

        }
    }
    }

