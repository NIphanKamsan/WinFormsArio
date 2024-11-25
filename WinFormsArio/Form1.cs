namespace WinFormsArio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "คิม";
            student[1] = "โอคิม";
            student[2] = "คิมต์";
            student[3] = "โชคิม";
            student[4] = "ต้นคิม";
            string test = "";
            int n = student.Length;
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                string[] Fruits = { "บักส้ม", "ทุเรียน", "มะแตงโม้", "บักเตง", "หมากเม่า" };
                string myFruit = "";

                foreach (string str in Fruits)
                {
                    myFruit += str + ", ";
                }
                if (myFruit.EndsWith(", "))
                {
                    myFruit = myFruit.Substring(0, myFruit.Length - 2);
                }

                MessageBox.Show(myFruit, "ผลไม้ของฉัน");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; //นำข้อมูลไใส่ในอาเรย์
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }
            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0;//เพิมบกัคิมเข้ามา

            foreach (var str in data)
            {
                int x = 0; // ประกาศตัวแปรสำหรับเก็บค่าตัวเลข
                if (int.TryParse(str, out x))
                {
                    sum += x; // บวกค่าตัวเลขเข้าไปในผลรวม
                    result += x.ToString() + Environment.NewLine;
                }
            }

            result += "ผลรวม: " + sum.ToString();
            label1.Text = result; //แดสงลาเบล
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "ไออุ่น";
            student[0, 1] = "กาก้า";
            student[1, 0] = "ต้า";
            student[1, 1] = "อุดรธานี";
            student[2, 0] = "เอ็ม";
            student[2, 1] = "หนองบัวลำภู";

            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j] + " ";
                }
                ResultData += Environment.NewLine;
            }

            MessageBox.Show(ResultData, "แสดงข้อมูลใน Array 2 มิติ");
        }
    }
        }

