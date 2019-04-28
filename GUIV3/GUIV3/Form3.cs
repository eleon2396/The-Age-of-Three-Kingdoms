using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeKingdomsTake2;
using System.Diagnostics;
using System.IO;

namespace GUIV3
{
    public partial class Form3 : Form
    {
 
 
        private static String DIR = Directory.GetCurrentDirectory();
        List<Card> hand;
        private ImageList allcards;
        Dictionary<string, string> dictionary;

        public Form3()
        {
            InitializeComponent();
            this.allcards = new ImageList();
            dictionary = new Dictionary<string, string>();
            this.Size = new System.Drawing.Size(1100, 600);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private List<Card> PopulateDeck()
        {
            // create the list of cards that will be returned
            List<Card> freshDeck = new List<Card>();

            // create random instance to decide on values of cards
            Random rnd = new Random();

            // create delimiters
            char[] delimiters = { '_', '.' };

            // instance that will hold information on all files in a directory
            DirectoryInfo info = new DirectoryInfo(DIR + "//Warriors");

            // get all files with the .jpg extension
            FileInfo[] Files = info.GetFiles("*.jpg");

            // loop through each file
            foreach (FileInfo file in Files)
            {
                // get the name of the file
                String imageFileName = file.Name;
                String[] imgName = imageFileName.Split(delimiters);

                // check what tag the image has
                if (string.Compare(imgName[0], "H") == 0)
                {
                    // make the card and add it to the deck
                    Card c = new Card(imgName[1], " ", rnd.Next(100, 301), rnd.Next(100, 201), 0, DIR + "//Warriors//" + imageFileName);
                    freshDeck.Add(c);
                }
                else if (string.Compare(imgName[0], "A") == 0)
                {
                    Card c = new Card(imgName[1], " ", rnd.Next(200, 401), rnd.Next(150, 201), 0, DIR + "//Warriors//" + imageFileName);
                    //c.SetType("Assassin");
                    freshDeck.Add(c);
                }
                else if (string.Compare(imgName[0], "R") == 0)
                {
                    //Card c = new Card(imgName[1], " ", rnd.Next(50, 101), rnd.Next(200, 301), 0, DIR + "//Warriors//" + imageFileName);
                    //c.SetType("Horse");
                    //freshDeck.Add(c);
                }
                else if (string.Compare(imgName[0], "T") == 0)
                {
                    //Card c = new Card(imgName[1], " ", 0, 0, 0, DIR + "//Warriors//" + imageFileName);
                    //c.SetType("Trap");
                    //freshDeck.Add(c);
                }
                else if (string.Compare(imgName[0], "W") == 0)
                {
                    //Card c = new Card(imgName[1], " ", rnd.Next(150, 201), rnd.Next(50, 101), 0, DIR + "//Warriors//" + imageFileName);
                    //c.SetType("Weapon");
                    //freshDeck.Add(c);
                }
            }

            return freshDeck;
        }

    
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            hand = PopulateDeck();
            this.allcards.ImageSize = new Size(112, 112);
            foreach (Card card in this.hand)
            {
                allcards.Images.Add(card.GetName(), card.getImage());
                this.listView1.Items.Add(card.GetName(), this.allcards.Images.IndexOfKey(card.GetName()));

            }
            this.listView1.LargeImageList = this.allcards;

            dictionary.Add("WhiteTiger", "Yan Baihu, also known as White Tiger of Yan, " +
                "was a bandit leader of possibly Shanyue origins. When Sun Ce came to Wu " +
                "Commandery in 195, Yan Baihu gave refuge to the displaced Xu Gong and " +
                "threatened the flank of Sun Ce's army. However Sun Ce paid him no attention and the two avoided any altercations." +
                "\n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("ZhangYan", "Zhang Yan, originally Chu Yan, was the leader of a bandit group in the Taihang Mountains in 184. At some point he joined another bandit, Oxhorn Zhang, but Zhang was fatally wounded and died soon afterwards. His last act was to transfer his men over to Chu Yan, who took the name of Zhang to honor his patron.\n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");
            //dictionary.Add("", "");

            dictionary.Add("HanSui", "Han Sui was born to an influential family in Jincheng Commandery. His father held appointment at the capital and in 178, Han Sui followed in his father's footsteps by becoming a Reporting Officer at Luoyang. During his stay at the capital, he became friends with Cao Cao, and was instrumental in urging General-in-Chief He Jin to eliminate the eunuchs. However He Jin was reluctant and after some time Han Sui returned to his homeland in the west, where he became Assistant Officer of Liang Province. failure to take Chang'an, Han Sui killed Beigong Boyu and seized command himself with Wang Guo as a figurehead. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");
            dictionary.Add("MaTeng", "Ma Teng's family claimed descent from the famed general Ma Yuan, but his father was quite poor while his mother was of Qiang origin. Ma Teng grew to be quite tall at eight chi in height (185cm). He made a living cutting firewood before joining the militia against the Liang Province rebellion. Ma Teng rose to major under Inspector Geng Bi until Geng Bi was killed by mutineers in 187. Ma Teng then joined the mutineers, styling himself a general under the command of Wang Guo. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("MaChao", "Ma Teng lost the exchange, losing his wife and some children, and was forced to retreat to Youfufeng Commandery. He threw in his lot with Cao Cao in 202, sending his son Ma Chao to fight Yuan Shao's officer Guo Yuan in Hedong Commandery, and in 205 he himself campaigned against Sun Quan's officer Zhang Cheng. In 208 Ma Teng was enfeoffed but kept hostage in Ye while his son Ma Chao succeeded him in Liang Province. In 211 Ma Chao and Han Sui became hostile to Cao Cao. Ma Teng was killed the next year \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("SongJian", "Song Jian led an uprising in Liang Province in 184. After 185 he returned to his home county of Fuhan and declared himself King of the Sources of the River Who Will Pacify Han. In the winter of 214 Cao Cao's general Xiahou Yuan attacked Fuhan and killed Song Jian and his officers. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("HuangAng", "Huang Ang was the clan leader of Jiuquan Commandery until he was killed in 210 by the vigilante Yang Feng. His relative Huang Hua succeeded him and joined forces with Zhang Jin to oppose Cao Wei in 220. When Zhang Jin was killed Huang Hua surrendered \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("DongZhuo", "As a youth, Dong Zhuo was reputed to possess immense strength and to carry two bows at each side. In 165 he became a major under Zhang Huan. For his service in defeating Qiang rebels, Dong Zhuo was promoted through the imperial ranks until he became Administrator of Hedong Commandery in the early 180s.Dong Zhuo disguised his army as fishermen to escape the enemy forces. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("GongsunDu", "Gongsun Du was appointed Administrator of Liaodong Commandery by Dong Zhuo in 189 on the recommendation of Xu Rong. As a result of his lowly origins, Du harbored an intense hatred for the elite landowning class. Once he became administrator, Du carried out his vendetta against the wealthy by publicly flogging to death the Magistrate of Xiangping and extirpating the gentry. Du dominated the northeast and expanded into the territory of Goguryeo and the Wuhuan. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("GongsunZan", "Gongsun Zan was born to a family of high officials and received education from Lu Zhi and Liu Kuan, in the process becoming friends with Liu Bei. He took office as a local officer in Liaoxi Commandery, where the administrator was so impressed with his appearance and booming voice that he gave his daughter to him in marriage. Later on, Zan became assistant magistrate of a county in Liaodong Commandery and made a name for himself fighting the Wuhuan and Xianbei. He was particularly known for leading a unit of mounted archers who only rode white horses. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("GuoSi", "also known as Guo Duo, was a military general serving under the warlord Dong Zhuo during the late Eastern Han dynasty of China.[2] He assisted Dong Zhuo in his many campaigns and served as a subordinate of Dong Zhuo's son-in-law, Niu Fu, after Dong Zhuo relocated the imperial capital to Chang'an. He later became one of the de facto regents of Emperor Xian, wherein they occupied the capital and held the emperor and imperial officials hostage. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("HanFu", "Han Fu was appointed Governor of Ji Province in 189. While he nominally participated in the Campaign against Dong Zhuo, he stayed at the city of Ye. After the coalition broke up, he became hostile to Yuan Shao in 191 and denied him supplies. Using his family connections, Yuan Shao intimidated Han Fu into handing over his position to him. After doing so, Han Fu's family was constantly harassed until they fled to Zhang Miao. He eventually killed himself. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("KongRong", "Kong Rong became Chancellor of Beihai Commandery in 190. In 193 he was attacked by the bandit leader Guan Hai and sent his subordinate Taishi Ci to seek aid from Liu Bei. Liu Bei sent a relief force and scattered the bandit army. In 196 Yuan Shao's son Yuan Tan captured Beihai Commandery and Kong Rong was forced to flee to Cao Cao, who made him Court Architect. In 208 Kong Rong was killed for ridiculing Cao Cao in a self-righteous manner. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LiJue", "courtesy name Zhiran, was a military general serving under the autocratic warlord Dong Zhuo during the late Eastern Han dynasty of China. He later succeeded Dong Zhuo as the leader of the Liang Province faction after Dong Zhuo was murdered in a coup d'état, and was able to take over the Han imperial capital Chang'an, keeping Emperor Xian as a hostage. Despite being adept in military affairs, he was inept at politics, quarrelling with his fellow generals and making the bad decision to let Emperor Xian escape, greatly decreasing his power and precipitating his downfall. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LiuBiao", "Liu Biao became Inspector of Jing Province in 190, but Yuan Shu was already in control of Nanyang Commandery, so he went further south and set up in Xiangyang. He was attacked by Sun Jian in 191, but Sun Jian died almost immediately after in a skirmish. In the late 190s a rebellion by Zhang Xiu disrupted Liu Biao's territory until Zhang Xiu died in 200. He gave refuge to Liu Bei, who urged him to attack Cao Cao in 207, but Liu Biao declined. In 208 Liu Biao was invaded by Cao Cao in the north and Sun Quan in the south. Liu Biao died that autumn and his son Liu Zong surrendered to Cao Cao. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LiuYan", "Liu Yan was a descendant of Liu Yu, the fifth son of Emperor Jing of Han. Seeking to distance himself from the turmoil at the capital, Liu Yan sought and received appointment as Governor of Yi Province in 188. He set his headquarters at Mianzhu in Guanghan Commandery. Soon after he raised troops in the name of Dong Zhuo and appointed the sect leaders Zhang Lu and Zhang Xiu as officers. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LiuYao", "In the 190s Liu Yao established himself in Danyang Commandery while his officer Zhu Hao held Yuzhang Commandery. In 195 Sun Ce defeated Liu Yao's forces and forced him to flee to Yuzhang Commandery, where Zhai Rong had previously seized power. He eliminated Zhai Rong but otherwise played no role in external affairs until 198 when he died. His family entered the court of Sun Ce and were treated well. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LiuYu", "Liu Yu was sent to You Province in 188 and arrived in 189. As Governor, he persuaded the Wuhuan chieftain Qiuliju to surrender and murdered the rebel Zhang Chun. Yuan Shao suggested that he be made regent instead of Dong Zhou or even take the throne for himself, but Liu Yu declined. Under Liu Yu's governorship, You Province prospered as a result of policies encouraging silk production, market trading, and production of salt an diron. The province prosperity and low grain prices attracted many southern refugees. In 191 Liu Yu allied with Yuan Shao, and Gongsun Zan with Yuan Shu. In 193 Liu Yu attempted to oust Gongsun Zan, who had built a fortified camp within the walls of his capital in Guangyang Commandery, but failed. Gongsun Zan counterattacked, driving him from the city. Liu Yu was captured a few days later and executed. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LiuZhang", "Zhang Lu took Hanzhong Commandery for himself and eliminated Zhang Xiu. Liu Zhang put down an insurrection caused by an agent of the Chang'an regime, Hu Mao. In 200 Zhang Lu openly defied Liu Zhang, who in retaliation killed Zhang Lu's mother, who had been staying at his court as hostage. Zhang Lu invaded Liu Zhang's territory, occupying northern Ba Commandery. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LuBu", "Lü Bu was skilled in horse archery, possessing strength surpassing others, and was called the Flying General... Lü Bu also had with him a good horse named Red Hare capable of galloping so fast it could jump over city moats... There was a popular saying at the time, Lü Bu[who stands out] among men, the Red Hare[which stands out] among horses \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("LuKang", "Lu Kang became Administrator of Lujiang Commandery in 188. He was attacked by Sun Ce in 193 and surrendered after a two-year siege, in 195. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("ShiXie", "Sheng Xian was a close friend of Kong Rong and Administrator of Wu Commandery. He left office in 193 took refuge with his former officer Gao Dai. It's not clear under what circumstances he left. One account suggests he became ill, another that Xu Gong took over by force. Sheng Xian was eventually killed by Sun Quan, who viewed him as a threat to his own authority. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");

            dictionary.Add("TaoQian", "Tao Qian became Inspector of Xu Province in after 185. He dealt with the Yellow Turbans and restored order to the region, making the province prosperous and a refuge for displaced peoples. In 191 Tao Qian sent 3,000 men to support Zhu Jun against Dong Zhuo. In 193 he entered a loose alliance with Yuan Shu and Gongsun Zan, but that winter Tao Qian's soldiers killed Cao Song, Cao Cao's father. In retaliation Cao Cao brought the full force of his army down on him, ravaging Pengcheng and Xiapi commanderies. Tao Qian fled to Donghai Commandery in 194 and received the aid of Tian Kai and Liu Bei, but died from illness soon afterwards. \n\n\n\n                                                        https://en.wikipedia.org/wiki/Military_history_of_the_Three_Kingdoms#Han_Sui");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0) // this code works plz don't touch it, our make-shift try catch
            {
                return;
            }
            String itemSelected = listView1.SelectedItems[0].Text.ToString();
            foreach (var item in dictionary)
            {
                if (item.Key == itemSelected)
                {
                    textBox1.Text = item.Value;
                }
            }


            // textBox1.Text = itemSelected.ToString();
            textBox1.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
