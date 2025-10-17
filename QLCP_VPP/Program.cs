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

            // Sửa ở đây: Mở form Đăng nhập trước
            Dangnhap loginForm = new Dangnhap();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập thành công (DialogResult.OK), thì mới mở form chính
                Application.Run(new Trang_chu());
            }
            else
            {
                // Nếu không, thoát ứng dụng
                Application.Exit();
            }
        }
    }
}