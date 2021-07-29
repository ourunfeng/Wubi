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
using System.Xml;//创建文本
namespace WindowsFormsApp8 {

    public partial class Form1 : Form {
        private string _nowPath;
        private string _newPath;
        int allToal = 0;
        string[] Arr_统计数组 = new string[1] { "0" };
        string txt判断;
        int total;
        string str_一级简码数组 = "我人有的和主产不为这工要在地一上是中国同民了发以经";
        string str_二级简码数组 = "几多霜雪下帝城四处几砂亿地阴三旬六载不平事五度思家小儿孙所爱不为贡录物钱财从来少入心当学太公耿直际务扫内肛切耻因主就朱膛赤肌肋哪管绿胸贩辽参最恨蛤蝗毁籽料呆骨罗妆定居民开坟必现官中册关们定隐城北军没让尖刀阵前出会放阿姨马后巡久怕瞎妇妨儿习屡认苛虎迷子沁烽烟炽烛且止伙粘绵浊澡要避林悄然过客睡天找空宛洋烟闰年寻垢圾枯杨休估细官台铁锭岂归村玫珠细玉央妻采凤朵名曲注阳春并达及第参汉陛或涨冯沁变良屯秒表查顾级档列法叶对具纪纲审于无他处扔珍画与张李氏纪磁婚降职隐行遇睦友载革引驼率吕宾东芝电笔可盯紧南宁介末必渐闻丰收明显打好药曙旭晃眼到眩晕虽说啊吧哟换牙只听嘛呀噗忱心肯向困社顷奶粉也取粗纱作景灯凡欠商煤则记册极反姑舅早分成断瓣失籽季难负胡面钉餐节如冰陈旧睡衣全检析化外秘方半嫌灵二忆姆妈扩昆曲七呼寺训报你亲得赠仙玉愉芳燕权洒胶水眯瞳睛敢服肥脂炒卤菜曾量汪泊防水灾普拓灰粉离右站乐导高才驻左厅同类机械限百个近代实业允共产给旨劝约答楷贞批条示义加力办秀芭晚间争灿色匠物晨时夺天工皮包能偿张承相棕服渐累刘史充吉它暗甩弛大志杰迪孤刀崭怪龙肖男进攻呈煌炮功夫支持占主凶淡观杂戏知遥理长提铁胃吸江虹怀搂牟角历针炙保守信伯庆遥朋车棍轩轴双边轨经线纺纱肆米综抽拉扣押折手式喧吵啼叫员脸肿科长决心罚懈卫楞尼用术克秋蝇帮弱格强斩娄怪肝胆闪光九区红部队炎艰匀步慢卢灶宽峭结构轻邓字之安昌顺矣宙寂宵妥果甸兴比较对联这么邮仍" +
            "由协本另样称各诉原委计划订互立此基世交增几多霜雪下帝城四处几砂亿地阴三旬六载不平事五度思家小儿孙所爱不为贡录物钱财从来少入心当学太公耿直际务扫内肛切耻因主就朱膛赤肌肋哪管绿胸贩辽参最恨蛤蝗毁籽料呆骨罗妆定居民开坟必现官中册关们定隐城北军没让尖刀阵前出会放阿姨马后巡久怕瞎妇妨儿习屡认苛虎迷子沁烽烟炽烛且止伙粘绵浊澡要避林悄然过客睡天找空宛洋烟闰年寻垢圾枯杨休估细官台铁锭岂归村玫珠细玉央妻采凤朵名曲注阳春并达及第参汉陛或涨冯沁变良屯秒表查顾级档列法叶对具纪纲审于无他处扔珍画与张李氏纪磁婚降职隐行遇睦友载革引驼率吕宾东芝电笔可盯紧南宁介末必渐闻丰收明显打好药曙旭晃眼到眩晕虽说啊吧哟换牙只听嘛呀噗忱心肯向困社顷奶粉也取粗纱作景灯凡欠商煤则记册极反姑舅早分成断瓣失籽季难负胡面钉餐节如冰陈旧睡衣全检析化外秘方半嫌灵二忆姆妈扩昆曲七呼寺训报你亲得赠仙玉愉芳燕权洒胶水眯瞳睛敢服肥脂炒卤菜曾量汪泊防水灾普拓灰粉离右站乐导高才驻左厅同类机械限百个近代实业允共产给旨劝约答楷贞批条示义加力办秀芭晚间争灿色匠物晨时夺天工皮包能偿张承相棕服渐累刘史充吉它暗甩弛大志杰迪孤刀崭怪龙肖男进攻呈煌炮功夫支持占主凶淡观杂戏知遥理长提铁胃吸江虹怀搂牟角历针炙保守信伯庆遥朋车棍轩轴双边轨经线纺纱肆米综抽拉扣押折手式喧吵啼叫员脸肿科长决心罚懈卫楞尼用术克秋蝇帮弱格强斩娄怪肝胆闪光九区红部队炎艰匀步慢卢灶宽峭结构轻邓字之安昌顺矣宙寂宵妥果甸兴比较对联这么邮仍由协本另样称各诉原委计划订互立此基世交增";
        public Form1() {
            

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            _nowPath = System.Environment.CurrentDirectory;
            _newPath = Path.Combine(_nowPath + "\\record.txt");

            if (File.Exists(_newPath) == false) {
                FileStream fs = File.Create(_newPath);
                fs.Close();
            } else {
                allToal = Convert.ToInt32(File.ReadAllText(_newPath));
                label3.Text = allToal.ToString();
            }

                
        }
        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if (textBox2.Text != null) {
                if (textBox2.Text == textBox1.Text) {
                    ran_随机汉字();
                    total += 1;
                    allToal += 1;
                    label2_统计.Text = total.ToString();
                    label3.Text = allToal.ToString();
                    label2_验证.Text = "";
                } else {
                    textBox2.Text = "";
                    label2_验证.Text = "输入错误！";
                }

            }

        }

        private void A_Key(object sender, PreviewKeyDownEventArgs e) {

        }



        private void Key_按键管理down(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Q:
                    button7.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.W:
                    button8.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.E:
                    button9.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.R:
                    button11.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.T:
                    button12.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.Y:
                    button10.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.U:
                    button13.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.I:
                    button14.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.O:
                    button15.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.P:
                    button16.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.A:
                    button17.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.S:
                    button18.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.D:
                    button19.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.F:
                    button20.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.G:
                    button21.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.H:
                    button22.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.J:
                    button23.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.K:
                    button24.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.L:
                    button25.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.X:
                    button1.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.C:
                    button2.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.V:
                    button3.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.B:
                    button4.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.N:
                    button5.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.M:
                    button6.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
            }
        }

        private void Key_按键管理up(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Q:
                    button7.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.W:
                    button8.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.E:
                    button9.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.R:
                    button11.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.T:
                    button12.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.Y:
                    button10.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.U:
                    button13.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.I:
                    button14.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.O:
                    button15.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.P:
                    button16.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.A:
                    button17.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.S:
                    button18.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.D:
                    button19.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.F:
                    button20.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.G:
                    button21.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.H:
                    button22.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.J:
                    button23.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.K:
                    button24.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.L:
                    button25.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.X:
                    button1.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.C:
                    button2.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.V:
                    button3.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.B:
                    button4.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.N:
                    button5.BackColor = System.Drawing.Color.Beige;
                    break;
                case Keys.M:
                    button6.BackColor = System.Drawing.Color.Beige;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        private int Random_随机数(int r, int len) {
            //随机数生成
            Random ran = new Random();
            int r_结果 = ran.Next(r, len);
            return r_结果;
        }

        private void BB_确定_Click(object sender, EventArgs e) {
            ran_随机汉字();
        }
        private void ran_随机汉字() {
            int i;
            switch (comboBox1.SelectedIndex) {
                case 0:
                    i = Random_随机数(0, str_一级简码数组.Length);
                    textBox1.Text = str_一级简码数组[i].ToString();
                    break;
                case 1:
                    i = Random_随机数(0, 11);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 2:
                    i = Random_随机数(11, 21);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 3:
                    i = Random_随机数(21, 31);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 4:
                    i = Random_随机数(31, 41);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 5:
                    i = Random_随机数(41, 51);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 6:
                    i = Random_随机数(51, 61);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 7:
                    i = Random_随机数(61, 71);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;

                case 8:
                    i = Random_随机数(71, 81);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 9:
                    i = Random_随机数(81, 91);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 10:
                    i = Random_随机数(91, 101);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 11:
                    i = Random_随机数(101, 111);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 12:
                    i = Random_随机数(111, 121);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 13:
                    i = Random_随机数(121, 131);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 14:
                    i = Random_随机数(131, 141);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 15:
                    i = Random_随机数(141, 151);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 16:
                    i = Random_随机数(151, 161);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 17:
                    i = Random_随机数(161, 171);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 18:
                    i = Random_随机数(171, 181);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 19:
                    i = Random_随机数(181, 191);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 20:
                    i = Random_随机数(191, 201);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 21:
                    i = Random_随机数(201, 211);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 22:
                    i = Random_随机数(211, 221);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 23:
                    i = Random_随机数(221, 241);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 24:
                    i = Random_随机数(241, 261);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 25:
                    i = Random_随机数(261, 281);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 26:
                    i = Random_随机数(281, 301);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 27:
                    i = Random_随机数(301, 321);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 28:
                    i = Random_随机数(321, 341);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 29:
                    i = Random_随机数(341, 361);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 30:
                    i = Random_随机数(361, 381);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 31:
                    i = Random_随机数(381, 401);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 32:
                    i = Random_随机数(401, 421);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 33:
                    i = Random_随机数(421, 441);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 34:
                    i = Random_随机数(441, 461);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 35:
                    i = Random_随机数(461, 481);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 36:
                    i = Random_随机数(481, 501);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 37:
                    i = Random_随机数(511, 531);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 38:
                    i = Random_随机数(541, 561);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 39:
                    i = Random_随机数(571, 591);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
                case 40:
                    i = Random_随机数(591, str_二级简码数组.Length);
                    textBox1.Text = str_二级简码数组[i].ToString();
                    break;
            }

            textBox2.Text = "";



        }

        private void label2_统计_Click(object sender, EventArgs e) {
        }



        private void button26_Click(object sender, EventArgs e) {
            MessageBox.Show("作者：岭南鄙士\n立项时间：2021年2月3日\n基本框架完成时间：2021年2月4日凌晨\n信息写成时间：2021年2月4日3:26\n联系邮箱：2412395774@qq.com");
        }

        private void 输入框按下(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Q:
                    button7.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.W:
                    button8.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.E:
                    button9.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.R:
                    button11.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.T:
                    button12.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.Y:
                    button10.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.U:
                    button13.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.I:
                    button14.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.O:
                    button15.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.P:
                    button16.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.A:
                    button17.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.S:
                    button18.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.D:
                    button19.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.F:
                    button20.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.G:
                    button21.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.H:
                    button22.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.J:
                    button23.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.K:
                    button24.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.L:
                    button25.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.X:
                    button1.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.C:
                    button2.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.V:
                    button3.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.B:
                    button4.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.N:
                    button5.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
                case Keys.M:
                    button6.BackColor = System.Drawing.Color.FromArgb(209, 255, 64);
                    break;
            }
        }

        private void button27_Click(object sender, EventArgs e) {
            Form2 aaa = new Form2();
            aaa.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            File.WriteAllText(_newPath,allToal.ToString());
           
        }
    }
}
