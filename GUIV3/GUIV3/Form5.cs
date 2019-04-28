using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUIV3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 600);

            this.historyTextBox.Text = "    In 189 when Emperor Ling of the Eastern Han dynasty died, a young emperor - Emperor Shao " +
                "was put on the throne. Resenting the manipulation of eunuchs, two generals Yuan Shao and He Jin plotted to murder them. " +
                "During the chaos caused by the fighting between the eunuchs and generals, Dong Zhuo, a treacherous court official of the " +
                "Eastern Han drove his army into Luoyang. With full political power in his hand, Dong Zhuo dethroned Emperor Shao and put " +
                "Emperor Xi'an on the throne. All Dong's deeds aroused strong protest from the courtiers and many local officials. As the " +
                "political situation became acute, a large-scale civil war finally broke out." + Environment.NewLine + Environment.NewLine +
                "   After Dong Zhuo invaded Luoyang, Cao Cao fled to Chenliu (currently southeast of Kaifeng in Henan Province) and began to " +
                "assemble military forces to revolt. In 193, Dong was killed in a mutiny but the melee remained. This period of unrest " +
                "continued until 196, Balkanized areas were formed among which the most two powerful ones were those of Yuan Shao and Cao Cao." + Environment.NewLine + Environment.NewLine +
                "   In 196, Cao Cao held Emperor Xi'an under duress and took this advantage to strengthen his military power. In 201, with comparatively " +
                "weaker strength, Cao Cao defeated Yuan  Shao in the Battle of Guandu after which he gradually unified the northern area of China. In 209, " +
                "Cao Cao drove his troops to the southern area and captured Jingzhou. But when he wanted to expand his power further to the south, he was " +
                "defeated by the allied forces of Liu Bei and Sun Quan in the Battle of Red Cliff (the Battle of Chibi) and thus he withdrew his army back " +
                "to the central plains of China." + Environment.NewLine + Environment.NewLine + "For More information follow this link: https://www.travelchinaguide.com/intro/history/three_kingdoms/" + Environment.NewLine;
            ;


        }


        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            Form3 moreInfo = new Form3();
            this.Hide();
            moreInfo.ShowDialog();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void historyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
