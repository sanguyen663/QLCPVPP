using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCP_VPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiển thị form đăng nhập
            Dangnhap loginForm = new Dangnhap();
            loginForm.ShowDialog();

            // Chỉ khi đăng nhập thành công (DialogResult là OK) thì mới mở trang chủ
            if (loginForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new Trang_chu());
            }
        }
    }
}