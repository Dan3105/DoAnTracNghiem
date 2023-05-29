using DevExpress.Diagram.Core.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace QLThiTracNghiem
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        /*private string conn = "Data Source=DESKTOP-5Q314UD\\SERVER1;Initial Catalog=DB_THI_TN;Persist Security Info=True;User ID=sa;Password=kc";*/
        #region component UI
        private static Panel panelQuestionContainerRef;
        private static Panel flowQuestionMarkRef;
        #endregion


        #region Component Thi
        public struct CauTrucThi
        {
            public string MaLOP;
            public string TenMH;
            public int SoCauThi;
            public string MaMH;
            public string TrinhDo;
            public int TgianThi;
            public int lanThi;
            public DateTime ngayThi;
        }
        

        public class Questions : Label
        {
            public string idBode { get; private set; }
            public string dapAn { get; private set; }
            private string selection;
            private void SetSelection(string select)
            {
                selection = select;
                btnDirect.BackColor = Color.LightYellow;
                btnDirect.Focus();
            }
            public string GetSelectAnswer()
            {
                return selection;
            }
            //
            GroupBox aQue;
            RichTextBox content;
            RadioButton radiA;
            RadioButton radiB;
            RadioButton radiC;
            RadioButton radiD;

            Button btnDirect;
            private void MoveIntoQuestion()
            {
                Control targetQuestion = aQue;
                panelQuestionContainerRef.ScrollControlIntoView(targetQuestion);
            }
            private void DrawSheet()
            {
                aQue = new GroupBox();
                aQue.Text = "Cau hoi ";
                //aQue.Dock = DockStyle.Top;
                aQue.Size = new Size(panelQuestionContainerRef.Width, 250);
                aQue.Margin = new Padding(15);
                panelQuestionContainerRef.Controls.Add(aQue);

                radiA = new RadioButton();
                aQue.Controls.Add(radiA);
                radiA.Dock = DockStyle.Top;
                radiA.CheckedChanged += (object senders, EventArgs args) => SetSelection("A");
                
                radiB = new RadioButton();
                aQue.Controls.Add(radiB);
                radiB.Dock = DockStyle.Top;              
                radiB.CheckedChanged += (object senders, EventArgs args) => SetSelection("B");

                radiC = new RadioButton();
                aQue.Controls.Add(radiC);
                radiC.Dock = DockStyle.Top;
                radiC.CheckedChanged += (object senders, EventArgs args) => SetSelection("C");

                radiD = new RadioButton();
                aQue.Controls.Add(radiD);
                radiD.Dock = DockStyle.Top;
                radiD.CheckedChanged += (object senders, EventArgs args) => SetSelection("D");

                content = new RichTextBox();
                content.Dock = DockStyle.Top;
                content.Size = new Size(10, 50);
                content.BorderStyle = BorderStyle.FixedSingle;
                content.ReadOnly = true;
                content.ScrollBars = RichTextBoxScrollBars.Vertical;
                aQue.Controls.Add(content);

                btnDirect = new Button();
                flowQuestionMarkRef.Controls.Add(btnDirect);
                btnDirect.Size = new Size(50, 50);
                btnDirect.Click += (object senders, EventArgs args) => MoveIntoQuestion();
            }

            public Questions(int Stt, DataRow dataRow) : base()
            {
                DrawSheet();
                aQue.Text = $"Câu hỏi {Stt}";
                content.Text = dataRow["NOIDUNG"].ToString();
                radiA.Text = dataRow["A"].ToString();
                radiB.Text = dataRow["B"].ToString();
                radiC.Text = dataRow["C"].ToString();
                radiD.Text = dataRow["D"].ToString();
                idBode = dataRow["CAUHOI"].ToString();
                dapAn = dataRow["DAP_AN"].ToString();
                btnDirect.Text = Stt.ToString();
                
                selection = null;
            }
        }
        #endregion
        List<Questions> questionsList;
        CauTrucThi ctt;
        public FormThi()
        {
            InitializeComponent();
            panelQuestionContainerRef = panelQuestionContainer;
            flowQuestionMarkRef = flowQuestionMark;

        }

        public void SetFormThi(CauTrucThi ctt)
        {
            this.ctt = ctt;
        }

        private void FormThi_Load(object sender, EventArgs e)
        {

            string sql = $"Execute SP_Lay_Cau_Thi {ctt.MaMH}, {ctt.SoCauThi}, {ctt.TrinhDo}";
            try {
                questionsList = new List<Questions>();
                DataTable table = Program.ExecSqlQuery(sql, Program.connstr);
                for(int i = 0; i < table.Rows.Count  ; i++)
                {
                    questionsList.Add(new Questions(i+1, table.Rows[i]));
                }
                this.lbTENMH.Text = ctt.TenMH;
                this.lbNGAYTHI.Text = ctt.ngayThi.ToString("dd/mm/yyyy HH:mm:ss");
                SetTgianThi();
                TimerThi.Start();
            }
            catch(Exception ex)
            {
                if(MessageBox.Show($"Hệ thống hiện gặp vấn đề không thể thi được.\nLý do:{ex.Message} {ex.StackTrace}", "" , MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Console.WriteLine(ex.StackTrace);
                    this.Close();
                }
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void SetTgianThi()
        {
            TimerThi.Interval = 1000;
            int totalSeconds = ctt.TgianThi * 60;
            TimerThi.Tick += (object sender, EventArgs e) => TimerTick(ref totalSeconds);    
        }

        void TimerTick(ref int secondsLeft)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(secondsLeft);
            string formattedTime = timeSpan.ToString(@"hh\:mm\:ss");
            lbTimer.Text = formattedTime;


            if (secondsLeft == 0)
            {
                ChamThi();
                return;
            }

            secondsLeft -= 1;
        }

        private void ChamThi()
        {
            TimerThi.Stop();
            //Add Data
            double mark = TinhDiem();
            UpdateTableBangDiem(mark);
            MessageBox.Show($"Thí sinh: {Program.fullname}\nTổng số điểm: {mark}\n", "Kết quả", MessageBoxButtons.OK);
        }

        double TinhDiem()
        {
            int rightAnswer = 0;
            foreach(var question in questionsList)
            {
                if(question.GetSelectAnswer() != null && question.GetSelectAnswer().ToString() == question.dapAn)
                {
                    rightAnswer += 1;
                }
            }
            return Math.Round((rightAnswer + 0.0f) / questionsList.Count, 2);
        }

       
        private void UpdateTableBangDiem(double mark)
        {
            if(Program.groupLoginType == Simple.GroupLoginType.Sinhvien)
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("CAUHOI", typeof(int));
                    dt.Columns.Add("LUACHON", typeof(string));
                    dt.Columns.Add("STT", typeof(int));

                    for(int i = 0; i < questionsList.Count; i++)
                    {
                        dt.Rows.Add(questionsList[i].idBode, questionsList[i].GetSelectAnswer(), i + 1);
                    }

                    SqlParameter param = new SqlParameter();
                    param.SqlDbType = SqlDbType.Structured;
                    param.TypeName = "dbo.TYPE_DETHI";
                    param.ParameterName = "@BaiThi";
                    param.Value = dt;

                   
                    SqlConnection _conn = new SqlConnection(Program.connstr);

                    _conn.Open();

                    SqlCommand sqlCommand = new SqlCommand("SP_Cham_Thi", _conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@MaSV", Program.username);
                    sqlCommand.Parameters.AddWithValue("@MaMH", ctt.MaMH);
                    sqlCommand.Parameters.AddWithValue("@Diem", mark);
                    sqlCommand.Parameters.AddWithValue("@LanThi", ctt.lanThi);
                    sqlCommand.Parameters.AddWithValue("@NgayThi", ctt.ngayThi);
                    sqlCommand.Parameters.Add(param);

                    sqlCommand.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    if (MessageBox.Show($"Hệ thống hiện gặp vấn đề không ghi nhận được kết quả.\nLý do:{ex.Message} {ex.StackTrace}", "", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Console.WriteLine(ex.StackTrace);
                        this.Close();
                    }
                }
                

                return;
            }
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc muốn nộp bài", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ChamThi();
            }
        }
    }
}