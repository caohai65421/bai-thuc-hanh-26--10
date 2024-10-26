using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai_thuc_hanh_tim_kiem
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> studentScores = new Dictionary<string, string>()
        {
            { "SV001", "Toán: 8, Lý: 7, Hóa: 9" },
            { "SV002", "Toán: 6, Lý: 8, Hóa: 7" },
            { "SV003", "Toán: 9, Lý: 9, Hóa: 10" }
        };
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadStudentData();
        }
        private void InitializeDataGridView()
        {
            datastudents.ColumnCount = 2;
            datastudents.Columns[0].Name = "Mã Sinh Viên";
            datastudents.Columns[1].Name = "Điểm";
            datastudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadStudentData()
        {
            foreach (var student in studentScores)
            {
                datastudents.Rows.Add(student.Key, student.Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ TextBox
            string studentID = textID.Text.Trim();

            // Kiểm tra nếu mã sinh viên tồn tại trong danh sách
            if (studentScores.ContainsKey(studentID))
            {
                // Hiển thị thông tin điểm
                information.Text = $"Điểm của sinh viên {studentID}: {studentScores[studentID]}";
            }
            else
            {
                // Thông báo nếu không tìm thấy mã sinh viên
                information.Text = "Không tìm thấy mã sinh viên này.";
            }
        }
    }
}
