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
            student[0] = "���";
            student[1] = "�ͤ��";
            student[2] = "�����";
            student[3] = "⪤��";
            student[4] = "�鹤��";
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
                string[] Fruits = { "�ѡ���", "�����¹", "��ᵧ���", "�ѡ൧", "��ҡ����" };
                string myFruit = "";

                foreach (string str in Fruits)
                {
                    myFruit += str + ", ";
                }
                if (myFruit.EndsWith(", "))
                {
                    myFruit = myFruit.Substring(0, myFruit.Length - 2);
                }

                MessageBox.Show(myFruit, "�����ͧ�ѹ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; //�Ӣ����������������
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
            int sum = 0;//�����Ѥ�������

            foreach (var str in data)
            {
                int x = 0; // ��С�ȵ��������Ѻ�纤�ҵ���Ţ
                if (int.TryParse(str, out x))
                {
                    sum += x; // �ǡ��ҵ���Ţ����㹼����
                    result += x.ToString() + Environment.NewLine;
                }
            }

            result += "�����: " + sum.ToString();
            label1.Text = result; //�ʧ����
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "�����";
            student[0, 1] = "�ҡ��";
            student[1, 0] = "���";
            student[1, 1] = "�شøҹ�";
            student[2, 0] = "����";
            student[2, 1] = "˹ͧ�������";

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

            MessageBox.Show(ResultData, "�ʴ�������� Array 2 �Ե�");
        }
    }
        }

