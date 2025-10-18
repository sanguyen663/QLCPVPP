using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace QLCP_VPP
{
     public partial class Trang_chu : Form
     {
          string chuoikn = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
          SqlCommand thuchien;
          SqlConnection ketnoi;
          SqlDataReader docdulieu;
          string sql;
          int i = 0;
          string mapn;
          string madt;
          string macp;
          string MaNV;

          public Trang_chu()
          {
               InitializeComponent();
               pn_Trangchu.Dock = DockStyle.Fill;
               button2.Font = new Font(button2.Font.FontFamily, 11);
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'qLCP_VPPDataSet4.BANBAODAM' table. You can move, or remove it, as needed.
               this.bANBAODAMTableAdapter.Fill(this.qLCP_VPPDataSet4.BANBAODAM);
               // TODO: This line of code loads data into the 'qLCP_VPPDataSet3.LOAIVPP' table. You can move, or remove it, as needed.
               this.lOAIVPPTableAdapter.Fill(this.qLCP_VPPDataSet3.LOAIVPP);
               // TODO: This line of code loads data into the 'qLCP_VPPDataSet2.NHACUNGCAP' table. You can move, or remove it, as needed.
               this.nHACUNGCAPTableAdapter.Fill(this.qLCP_VPPDataSet2.NHACUNGCAP);
               // TODO: This line of code loads data into the 'qLCP_VPPDataSet1.DONVI' table. You can move, or remove it, as needed.
               this.dONVITableAdapter.Fill(this.qLCP_VPPDataSet1.DONVI);
               // TODO: This line of code loads data into the 'qLCP_VPPDataSet.VANPHONGPHAM' table. You can move, or remove it, as needed.
               this.vANPHONGPHAMTableAdapter.Fill(this.qLCP_VPPDataSet.VANPHONGPHAM);
               ketnoi = new SqlConnection(chuoikn);
               Hienthi();
          }
          public void Hienthi()
          {
            lst_dsVPP.Items.Clear();
            ketnoi = new SqlConnection(chuoikn);
            ketnoi.Open();
            sql = "select VPP.MA_VPP, VPP.TEN_VPP, NCC.TEN_NCC, LVPP.TENLOAI_VPP, VPP.SOLUONG, VPP.MA_LOAI_VPP, NCC.MA_NCC, VPP.SOLUONGLOI " +
                  "from VANPHONGPHAM vpp, NHACUNGCAP NCC, LOAIVPP LVPP " +
                  "WHERE VPP.MA_LOAI_VPP = LVPP.MA_LOAI_VPP AND VPP.MA_NCC = NCC.MA_NCC";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                lst_dsVPP.Items.Add(docdulieu[0].ToString());
                lst_dsVPP.Items[i].SubItems.Add(docdulieu[1].ToString());
                lst_dsVPP.Items[i].SubItems.Add(docdulieu[2].ToString());
                lst_dsVPP.Items[i].SubItems.Add(docdulieu[3].ToString());
                lst_dsVPP.Items[i].SubItems.Add(docdulieu[4].ToString());
                lst_dsVPP.Items[i].SubItems.Add(docdulieu[5].ToString());
                lst_dsVPP.Items[i].SubItems.Add(docdulieu[6].ToString());
                string soLuongLoi = docdulieu.IsDBNull(7) ? "0" : docdulieu[7].ToString();
                lst_dsVPP.Items[i].SubItems.Add(soLuongLoi);
                i++;
            }
            ketnoi.Close();
        }
          private void exit_form_Click(object sender, EventArgs e)
          {

          }

          private void btn_QLDM_MouseLeave(object sender, EventArgs e)
          {
               btn_QLDM.BackColor = Color.RoyalBlue;
          }

          private void btn_QLDM_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLDM.BackColor = Color.Red;
          }

          private void btn_QLN_MouseLeave(object sender, EventArgs e)
          {
               btn_QLN.BackColor = Color.RoyalBlue;
          }

          private void btn_QLN_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLN.BackColor = Color.Red;
          }

          private void btn_QLCP_MouseLeave(object sender, EventArgs e)
          {
               btn_QLCP.BackColor = Color.RoyalBlue;
          }

          private void btn_QLCP_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLCP.BackColor = Color.Red;
          }

          private void btn_QLDT_MouseLeave(object sender, EventArgs e)
          {
               btn_QLDT.BackColor = Color.RoyalBlue;
          }

          private void btn_QLDT_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLDT.BackColor = Color.Red;
          }

          private void btn_exit_MouseLeave(object sender, EventArgs e)
          {
               btn_exit.BackColor = Color.RoyalBlue;
          }

          private void btn_exit_MouseMove(object sender, MouseEventArgs e)
          {
               btn_exit.BackColor = Color.Red;
          }

          private void btn_QLDM_Click(object sender, EventArgs e)
          {
               pn_Danhmuc.Visible = true;
               Hienthi();
               pn_QL_nhap.Visible = false;
               pn_Trangchu.Visible = false;
               pn_Capphat.Visible = false;
               pn_Doitra.Visible = false;
               pn_Danhmuc.Dock = DockStyle.Fill;
               btn_QLDM.BackColor = Color.Red;
               btn_QLCP.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLN.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDT.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDM.Font = new Font(btn_QLCP.Font.FontFamily, 11);
               button2.Font = new Font(button2.Font.FontFamily, 8);

          }

          private void btn_QLN_Click(object sender, EventArgs e)
          {
               btn_QLN.BackColor = Color.Red;
               pn_Danhmuc.Visible = false;
               pn_Trangchu.Visible = false;
               pn_QL_nhap.Visible = true;
               pn_QL_nhap.Dock = DockStyle.Fill;
               pn_Capphat.Visible = false;
               pn_Doitra.Visible = false;
               btn_QLCP.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLN.Font = new Font(btn_QLCP.Font.FontFamily, 11);
               btn_QLDT.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDM.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               button2.Font = new Font(button2.Font.FontFamily, 8);

          }

          private void btn_QLCP_Click(object sender, EventArgs e)
          {
               pn_Trangchu.Visible = false;
               pn_Danhmuc.Visible = false;
               pn_QL_nhap.Visible = false;
               pn_Capphat.Visible = true;
               pn_Doitra.Visible = false;
               pn_Capphat.Dock = DockStyle.Fill;
               btn_QLCP.BackColor = Color.Red;
               btn_QLCP.Font = new Font(btn_QLCP.Font.FontFamily, 11);
               btn_QLN.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDT.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDM.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               button2.Font = new Font(button2.Font.FontFamily, 8);

          }

          private void btn_QLDT_Click(object sender, EventArgs e)
          {
               pn_Trangchu.Visible = false;
               pn_Danhmuc.Visible = false;
               pn_QL_nhap.Visible = false;
               pn_Capphat.Visible = false;
               pn_Doitra.Visible = true;
               pn_Doitra.Dock = DockStyle.Fill;
               btn_QLDT.Font = new Font(btn_QLDT.Font.FontFamily, 11);
               btn_QLCP.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLN.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDM.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               button2.Font = new Font(button2.Font.FontFamily, 8);

          }

          private void btn_exit_Click(object sender, EventArgs e)
          {
               this.Dispose();
          }

          private void btn_QLDM_MouseClick(object sender, MouseEventArgs e)
          {
               btn_QLDM.BackColor = Color.Red;
          }



          private void btn_DM_Sua_Click(object sender, EventArgs e)
          {
               gr_sua.Visible = true;

          }


          private void btn_Huy_sua_Click(object sender, EventArgs e)
          {
               gr_sua.Visible = false;
          }

          private void button2_Click(object sender, EventArgs e)
          {
               pn_Danhmuc.Visible = false;
               pn_QL_nhap.Visible = false;
               pn_Trangchu.Visible = true;
               pn_Trangchu.Dock = DockStyle.Fill;
               button2.Font = new Font(button2.Font.FontFamily, 11);
               btn_QLCP.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLN.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDT.Font = new Font(btn_QLCP.Font.FontFamily, 8);
               btn_QLDM.Font = new Font(btn_QLCP.Font.FontFamily, 8);
          }


          private void cb_Nhap_maNCC_SelectedValueChanged(object sender, EventArgs e)
          {
               sql = "SELECT * FROM NHACUNGCAP WHERE MA_NCC='" + cb_Nhap_maNCC.Text + "'";
               ketnoi = new SqlConnection(chuoikn);
               ketnoi.Open();
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader(CommandBehavior.CloseConnection);
               if (docdulieu.HasRows)
               {
                    while (docdulieu.Read())
                    {
                         txt_Nhap_sdtNCC.Text = docdulieu[3].ToString();
                         txt_Nhap_tenNCC.Text = docdulieu[1].ToString();
                         txt_Nhap_dcNCC.Text = docdulieu[2].ToString();
                    }

               }

               ketnoi.Close();
          }

         

          private void cb_Cap_maDonvi_SelectedValueChanged(object sender, EventArgs e)
          {
               sql = "SELECT * FROM DONVI WHERE MA_DONVI='" + cb_Cap_maDonvi.Text + "'";
               ketnoi = new SqlConnection(chuoikn);
               ketnoi.Open();
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader(CommandBehavior.CloseConnection);
               if (docdulieu.HasRows)
               {
                    while (docdulieu.Read())
                    {
                         txt_Cap_sdtDonvi.Text = docdulieu[3].ToString();
                         txt_Cap_soLuongHV.Text = docdulieu[2].ToString();
                         txt_Cap_tenDV.Text = docdulieu[1].ToString();
                    }

               }

               ketnoi.Close();
          }

      

          private void txtTimkiem_MouseClick(object sender, MouseEventArgs e)
          {
               txtTimkiem.Text = "";
          }

  
          private void lst_dsVPP_Click(object sender, EventArgs e)
          {
            if (lst_dsVPP.SelectedItems.Count > 0)
            {
                txt_DM_Ma.Text = lst_dsVPP.SelectedItems[0].SubItems[0].Text;
                txt_DM_ten.Text = lst_dsVPP.SelectedItems[0].SubItems[1].Text;
                txt_DM_tenNCC.Text = lst_dsVPP.SelectedItems[0].SubItems[2].Text;
                txt_DM_LoaiVPP.Text = lst_dsVPP.SelectedItems[0].SubItems[3].Text;
                txt_DM_Soluong.Text = lst_dsVPP.SelectedItems[0].SubItems[4].Text;
                txt_Dm_soluongloi.Text = lst_dsVPP.SelectedItems[0].SubItems[7].Text;
                txt_sua_MaVPP.Text = lst_dsVPP.SelectedItems[0].SubItems[0].Text;
                txt_sua_TenVPP.Text = lst_dsVPP.SelectedItems[0].SubItems[1].Text;
                txt_sua_SLVPP.Text = lst_dsVPP.SelectedItems[0].SubItems[4].Text;
                txt_sua_maloaiVPP.Text = lst_dsVPP.SelectedItems[0].SubItems[5].Text;
                txt_sua_MaNCC.Text = lst_dsVPP.SelectedItems[0].SubItems[6].Text;
            }
        }

          private void btn_DM_xoa_Click(object sender, EventArgs e)
          {
               try
               {
                    ketnoi.Open();
               }
               catch (Exception exp)
               {
                    MessageBox.Show(exp.ToString());
               }
               finally
               {
                    DialogResult a = MessageBox.Show("Bạn muốn xóa phòng này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                         sql = "delete from VANPHONGPHAM where(MA_VPP = '" + txt_DM_Ma.Text + "')";
                         thuchien = new SqlCommand(sql, ketnoi);
                         thuchien.ExecuteNonQuery();
                         DialogResult b = MessageBox.Show("Xóa thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                         if (b == DialogResult.OK)
                         {
                              ketnoi.Close();
                         }
                    }
                    if (a == DialogResult.No)
                    {
                         ketnoi.Close();
                    }
               }
          }

          private void btn_capnhat_sua_Click(object sender, EventArgs e)
          {
               ketnoi.Open();
               try
               {

                    sql = "update VANPHONGPHAM set TEN_VPP=N'" + txt_sua_TenVPP.Text + "' where MA_VPP ='" + txt_DM_Ma.Text + "'" +
                          "update VANPHONGPHAM set SOLUONG ='" + int.Parse(txt_sua_SLVPP.Text) + "' where MA_VPP ='" + txt_DM_Ma.Text + "'" +
                          "update VANPHONGPHAM set MA_NCC =N'" + txt_sua_MaNCC.Text + "' where MA_VPP ='" + txt_DM_Ma.Text + "'" +
                          "update VANPHONGPHAM set MA_LOAI_VPP ='" + txt_sua_maloaiVPP.Text + "' where MA_VPP ='" + txt_DM_Ma.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
               }
               catch (Exception ex)
               {
                    //MessageBox.Show(ex.ToString());

               }
               finally
               {
                    DialogResult d = MessageBox.Show("Sửa thông tin thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (d == DialogResult.OK) gr_sua.Visible = false; Hienthi();
               }
               ketnoi.Close();
          }

          private void btn_DM_tim_Click(object sender, EventArgs e)
          {
               if (txtTimkiem.Text == null)
               {
                    MessageBox.Show("Lỗi tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else
               {
                    sql = "select VPP.MA_VPP,VPP.TEN_VPP,NCC.TEN_NCC,LVPP.TENLOAI_VPP,VPP.SOLUONG,LVPP.MA_LOAI_VPP,NCC.MA_NCC,VPP.SOLUONGLOI from VANPHONGPHAM vpp, NHACUNGCAP NCC,LOAIVPP LVPP " +
                         " WHERE VPP.MA_LOAI_VPP = LVPP.MA_LOAI_VPP AND VPP.MA_NCC = NCC.MA_NCC and Vpp.TEN_VPP like N'%" + txtTimkiem.Text + "%'";
                    lst_dsVPP.Items.Clear();
                    ketnoi.Open();
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                    while (docdulieu.Read())
                    {
                         lst_dsVPP.Items.Add(docdulieu[0].ToString());
                         lst_dsVPP.Items[i].SubItems.Add(docdulieu[1].ToString());
                         lst_dsVPP.Items[i].SubItems.Add(docdulieu[2].ToString());
                         lst_dsVPP.Items[i].SubItems.Add(docdulieu[3].ToString());
                         lst_dsVPP.Items[i].SubItems.Add(docdulieu[4].ToString());
                         lst_dsVPP.Items[i].SubItems.Add(docdulieu[5].ToString());
                         lst_dsVPP.Items[i].SubItems.Add(docdulieu[6].ToString());
                         string soLuongLoi = docdulieu.IsDBNull(7) ? "0" : docdulieu[7].ToString();
                         lst_dsVPP.Items[i].SubItems.Add(soLuongLoi);

                    i++;
                    }
                    ketnoi.Close();
               }
          }

          private void btn_Nhap_nhap_Click(object sender, EventArgs e)
          {
               ketnoi.Open();
               try
               {
                    thuchien = new SqlCommand("select count(*) from Phieunhap_vpp", ketnoi);
                    var n = (int)thuchien.ExecuteScalar();
                    n += 1;
                    if (n < 10)
                    {
                         mapn = "PN0" + n.ToString();
                    }
                    else
                    {
                         if (n >= 10 && n < 100)
                         {
                              mapn = "PN" + n.ToString();
                         }
                         else mapn = "PN" + n.ToString();
                    }
                    sql = "exec NHAP_VPP '" + mapn + "',N'Phiếu nhập','" + cb_Nhap_maVPP.Text + "','"+MaNV+"','" + cb_Nhap_maNCC.Text + "'," + int.Parse(txt_Nhap_soluog.Text) + ",'" + Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
               }
               catch (Exception ex) 
               {
                    //MessageBox.Show(ex.ToString());

               }
               finally
               {
                    DialogResult d = MessageBox.Show("Nhập "+txt_Nhap_tenVPP.Text+" với số lượng "+txt_Nhap_soluog.Text+" từ nhà cung cấp "+txt_Nhap_tenNCC.Text+" thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (d == DialogResult.OK)
                    {
                         txt_Nhap_soluog.Text = "";
                         txt_Nhap_tenloaiVPP.Text = "";
                         txt_Nhap_tenNCC.Text = "";
                         txt_Nhap_tenVPP.Text = "";
                         txt_Nhap_dcNCC.Text = "";
                         txt_Nhap_sdtNCC.Text = "";
                    }
               }
               ketnoi.Close();

          }

          private void cb_Nhap_maVPP_SelectedValueChanged(object sender, EventArgs e)
          {
               sql = "SELECT VPP.MA_VPP,NCC.MA_NCC,LVPP.MA_LOAI_VPP,TEN_VPP,TENLOAI_VPP, TEN_NCC,SDT,DIACHI " +
                    " FROM VANPHONGPHAM VPP, NHACUNGCAP NCC, LOAIVPP LVPP " +
                    " WHERE VPP.MA_LOAI_VPP = LVPP.MA_LOAI_VPP AND VPP.MA_NCC = NCC.MA_NCC AND VPP.MA_VPP='" + cb_Nhap_maVPP.Text + "'";
               //sql = "Select * from vanphongpham where MA_VPP='" + cb_Nhap_maVPP.Text + "'";
               ketnoi = new SqlConnection(chuoikn);
               ketnoi.Open();
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader(CommandBehavior.CloseConnection);
               if (docdulieu.HasRows)
               {
                    while (docdulieu.Read())
                    {
                         cb_Nhap_maLoaiVPP.Text = docdulieu[2].ToString();
                         txt_Nhap_tenVPP.Text = docdulieu[3].ToString();
                         txt_Nhap_tenloaiVPP.Text = docdulieu[4].ToString();
                    }
               }
               ketnoi.Close();
          }
          
          private void btn_Nhap_lsNhap_Click(object sender, EventArgs e)
          {
               lst_Nhap_dsnhap.Items.Clear();
               //Xem_LS_nhap()/*/*;*/*/
               txt_Nhap_soluog.Text = "";
               txt_Nhap_tenloaiVPP.Text = "";
               txt_Nhap_tenNCC.Text = "";
               txt_Nhap_tenVPP.Text = "";
               txt_Nhap_dcNCC.Text = "";
               txt_Nhap_sdtNCC.Text = "";
               sql = "EXEC LICH_SU_NHAP";
               ketnoi = new SqlConnection(chuoikn);
               ketnoi.Open();
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader();
               i = 0;
               while (docdulieu.Read())
               {

                    string ng_nhap = Convert.ToDateTime(docdulieu[6].ToString()).ToString("dd/MM/yyyy");

                    lst_Nhap_dsnhap.Items.Add(docdulieu[0].ToString());
                    lst_Nhap_dsnhap.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lst_Nhap_dsnhap.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lst_Nhap_dsnhap.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lst_Nhap_dsnhap.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lst_Nhap_dsnhap.Items[i].SubItems.Add(docdulieu[5].ToString());
                    lst_Nhap_dsnhap.Items[i].SubItems.Add(ng_nhap);
                    lst_Nhap_dsnhap.Items[i].SubItems.Add(docdulieu[7].ToString());

                    i++;
               }
               ketnoi.Close();
          }

          private void btn_Doitra_Click(object sender, EventArgs e)
          {
            // 1. Kiểm tra dữ liệu đầu vào
            if (cb_Doitra_maDV.SelectedIndex == -1 || cb_Doitra_maVPP.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_Doitra_soluong.Text))
            {
                MessageBox.Show("Vui lòng chọn Đơn vị, Vật tư và nhập Số lượng đổi trả.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txt_Doitra_soluong.Text, out int soLuongDoiTra) || soLuongDoiTra <= 0)
            {
                MessageBox.Show("Số lượng đổi trả phải là một số nguyên lớn hơn 0.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (ketnoi = new SqlConnection(chuoikn))
                {
                    ketnoi.Open();

                    // 2. Tự động tạo mã phiếu đổi trả mới
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM PHIEUDOITRA", ketnoi);
                    int n = (int)countCmd.ExecuteScalar() + 1;
                    madt = "DT" + n.ToString("D3"); // Định dạng mã: DT001, DT002...

                    // 3. Gọi Stored Procedure 'DOITRA' một cách an toàn
                    thuchien = new SqlCommand("DOITRA", ketnoi);
                    thuchien.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số (Parameters)
                    thuchien.Parameters.AddWithValue("@MA_PHIEU", madt);
                    thuchien.Parameters.AddWithValue("@TEN_PHIEU", "Phiếu đổi trả ngày " + DateTime.Now.ToString("dd/MM/yyyy"));
                    thuchien.Parameters.AddWithValue("@MA_VPP", cb_Doitra_maVPP.Text);

                    // SỬA LỖI: Cung cấp giá trị cho tham số @MANV
                    thuchien.Parameters.AddWithValue("@MANV", this.MaNV); // Lấy mã NV đã được lưu khi đăng nhập

                    thuchien.Parameters.AddWithValue("@MA_DONVI", cb_Doitra_maDV.Text);
                    thuchien.Parameters.AddWithValue("@SOLUONG", soLuongDoiTra);
                    thuchien.Parameters.AddWithValue("@NGAY_DOITRA", DateTime.Now);
                    thuchien.Parameters.AddWithValue("@MA_NCC", txt_Doitra_maNCC.Text);

                    thuchien.ExecuteNonQuery();

                    MessageBox.Show($"Đổi trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Xóa ô nhập liệu và cập nhật lại danh sách VPP
                    txt_Doitra_soluong.Text = "";
                    Hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thực hiện đổi trả: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

          private void cb_Doitra_maVPP_SelectedValueChanged(object sender, EventArgs e)
          {
               sql = "SELECT VPP.MA_VPP,VPP.TEN_VPP,NCC.TEN_NCC,ncc.MA_NCC " +
                    " FROM VANPHONGPHAM VPP, NHACUNGCAP NCC " +
                    " WHERE VPP.MA_NCC = NCC.MA_NCC and VPP.MA_VPP='"+cb_Doitra_maVPP.Text+"'";
               ketnoi = new SqlConnection(chuoikn);
               ketnoi.Open();
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader(CommandBehavior.CloseConnection);
               if (docdulieu.HasRows)
               {
                    while (docdulieu.Read())
                    {
                         txt_doitra_tenNCC.Text = docdulieu[2].ToString();
                         txt_Doitra_maNCC.Text = docdulieu[3].ToString();
                         txt_Doitra_TenVPP.Text = docdulieu[1].ToString();
                    }
               }
               ketnoi.Close();
          }

          private void btn_Doitra_capnhat_Click(object sender, EventArgs e)
          {
            lst_LS_doitra.Items.Clear();
            try
            {
                using (SqlConnection ketnoi = new SqlConnection(chuoikn))
                {
                    ketnoi.Open();
                    // Gọi Stored Procedure để lấy lịch sử
                    SqlCommand thuchien = new SqlCommand("LICH_SU_DOITRA", ketnoi);
                    thuchien.CommandType = CommandType.StoredProcedure;
                    SqlDataReader docdulieu = thuchien.ExecuteReader();

                    while (docdulieu.Read())
                    {
                        // Lấy dữ liệu bằng tên cột để đảm bảo chính xác
                        string maPhieu = docdulieu["MA_PHIEU"].ToString();
                        string tenPhieu = docdulieu["TEN_PHIEU"].ToString();
                        string tenNV = docdulieu["TENNV"].ToString();
                        string tenDV = docdulieu["TEN_DONVI"].ToString();
                        string tenNCC = docdulieu["TEN_NCC"].ToString();
                        string tenVPP = docdulieu["TEN_VPP"].ToString();
                        string ngayDoiTra = Convert.ToDateTime(docdulieu["NGAY_DOITRA"]).ToString("dd/MM/yyyy");

                        // Thêm vào danh sách ListView
                        ListViewItem item = new ListViewItem(maPhieu);
                        item.SubItems.Add(tenPhieu);
                        item.SubItems.Add(tenNV);
                        item.SubItems.Add(tenDV);
                        item.SubItems.Add(tenNCC);
                        item.SubItems.Add(tenVPP);
                        item.SubItems.Add(ngayDoiTra);
                        lst_LS_doitra.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lịch sử đổi trả: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

          private void btn_CapPhat_Click(object sender, EventArgs e)
          {
            // 1. Kiểm tra dữ liệu đầu vào
            if (cb_Cap_maDonvi.SelectedIndex == -1 || cb_maVPP.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_Cap_soluong.Text))
            {
                MessageBox.Show("Vui lòng chọn Đơn vị, Vật tư và nhập Số lượng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txt_Cap_soluong.Text, out int soLuongCap) || soLuongCap <= 0)
            {
                MessageBox.Show("Số lượng cấp phát phải là một số nguyên lớn hơn 0.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (ketnoi = new SqlConnection(chuoikn))
                {
                    ketnoi.Open();

                    // 2. Tự động tạo mã phiếu cấp phát mới
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM PHIEUCAPPHAT_VPP", ketnoi);
                    int n = (int)countCmd.ExecuteScalar() + 1;
                    macp = "CP" + n.ToString("D3"); // Định dạng mã: CP001, CP002...

                    // 3. Gọi Stored Procedure 'CAPPHAT' một cách an toàn
                    thuchien = new SqlCommand("CAPPHAT", ketnoi);
                    thuchien.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số (Parameters)
                    thuchien.Parameters.AddWithValue("@MA_PH_CP", macp);
                    thuchien.Parameters.AddWithValue("@TEN_PH_CP", "Phiếu cấp phát ngày " + DateTime.Now.ToString("dd/MM/yyyy"));
                    thuchien.Parameters.AddWithValue("@MA_VPP", cb_maVPP.Text);

                    // SỬA LỖI: Cung cấp giá trị cho tham số @MANV
                    thuchien.Parameters.AddWithValue("@MANV", this.MaNV); // Lấy mã NV đã được lưu khi đăng nhập

                    thuchien.Parameters.AddWithValue("@MA_DONVI", cb_Cap_maDonvi.Text);
                    thuchien.Parameters.AddWithValue("@SOLUONG", soLuongCap);
                    thuchien.Parameters.AddWithValue("@NGAY_CP", DateTime.Now);

                    thuchien.ExecuteNonQuery();

                    MessageBox.Show($"Cấp phát thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Xóa ô nhập liệu và cập nhật lại danh sách VPP
                    txt_Cap_soluong.Text = "";
                    Hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cấp phát: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

          private void cb_maVPP_SelectedValueChanged(object sender, EventArgs e)
          {
               sql = "select * from vanphongpham where MA_VPP='"+cb_maVPP.Text+"'";
               ketnoi = new SqlConnection(chuoikn);
               ketnoi.Open();
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader(CommandBehavior.CloseConnection);
               if (docdulieu.HasRows)
               {
                    while (docdulieu.Read())
                    {
                         txt_CP_tenVPP.Text = docdulieu[1].ToString();
                    }
               }
               ketnoi.Close();
          }

          private void Capnhat_Click(object sender, EventArgs e)
          {
            lst_LS_capphat.Items.Clear();
            try
            {
                using (SqlConnection ketnoi = new SqlConnection(chuoikn))
                {
                    ketnoi.Open();
                    // Gọi Stored Procedure để lấy lịch sử cấp phát
                    SqlCommand thuchien = new SqlCommand("LICH_SU_CAPPHAT", ketnoi);
                    thuchien.CommandType = CommandType.StoredProcedure;
                    SqlDataReader docdulieu = thuchien.ExecuteReader();

                    while (docdulieu.Read())
                    {
                        // Lấy dữ liệu bằng tên cột để đảm bảo chính xác
                        string maPhieu = docdulieu["MA_PH_CP"].ToString();
                        string tenPhieu = docdulieu["TEN_PH_CP"].ToString();
                        string tenNV = docdulieu["TENNV"].ToString();
                        string tenDV = docdulieu["TEN_DONVI"].ToString();
                        string tenVPP = docdulieu["TEN_VPP"].ToString();
                        string soLuong = docdulieu["SOLUONG"].ToString();
                        string ngayCap = Convert.ToDateTime(docdulieu["NGAY_CP"]).ToString("dd/MM/yyyy");

                        // Thêm vào danh sách ListView
                        ListViewItem item = new ListViewItem(maPhieu);
                        item.SubItems.Add(tenPhieu);
                        item.SubItems.Add(tenNV);
                        item.SubItems.Add(tenDV);
                        item.SubItems.Add(tenVPP);
                        item.SubItems.Add(soLuong);
                        item.SubItems.Add(ngayCap);
                        lst_LS_capphat.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lịch sử cấp phát: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

          private void lb_tenNV_Click(object sender, EventArgs e)
          {

          }

          private void label33_Click(object sender, EventArgs e)
          {

          }

          private void button2_MouseLeave(object sender, EventArgs e)
          {
               button2.BackColor = Color.RoyalBlue;
          }

          private void button2_MouseMove(object sender, MouseEventArgs e)
          {
               button2.BackColor = Color.Red;
          }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}