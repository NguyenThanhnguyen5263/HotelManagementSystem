namespace GUI
{
    partial class frmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaocao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThongtinkhachsan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanlyhoadon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanlydichvu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanlynhanvien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanlyloaiphong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanlyphong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDatphong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.picNhanvien = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btnBaocao);
            this.panel1.Controls.Add(this.btnThongtinkhachsan);
            this.panel1.Controls.Add(this.btnQuanlyhoadon);
            this.panel1.Controls.Add(this.btnQuanlydichvu);
            this.panel1.Controls.Add(this.btnQuanlynhanvien);
            this.panel1.Controls.Add(this.btnQuanlyloaiphong);
            this.panel1.Controls.Add(this.btnQuanlyphong);
            this.panel1.Controls.Add(this.btnDatphong);
            this.panel1.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 872);
            this.panel1.TabIndex = 0;
            // 
            // btnBaocao
            // 
            this.btnBaocao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnBaocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBaocao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaocao.BorderRadius = 0;
            this.btnBaocao.ButtonText = "Báo cáo thống kê";
            this.btnBaocao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnBaocao, BunifuAnimatorNS.DecorationType.None);
            this.btnBaocao.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaocao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaocao.Iconimage = global::GUI.Properties.Resources.SEO_icon;
            this.btnBaocao.Iconimage_right = null;
            this.btnBaocao.Iconimage_right_Selected = null;
            this.btnBaocao.Iconimage_Selected = null;
            this.btnBaocao.IconMarginLeft = 0;
            this.btnBaocao.IconMarginRight = 0;
            this.btnBaocao.IconRightVisible = true;
            this.btnBaocao.IconRightZoom = 0D;
            this.btnBaocao.IconVisible = true;
            this.btnBaocao.IconZoom = 90D;
            this.btnBaocao.IsTab = false;
            this.btnBaocao.Location = new System.Drawing.Point(4, 572);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBaocao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBaocao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaocao.selected = false;
            this.btnBaocao.Size = new System.Drawing.Size(335, 62);
            this.btnBaocao.TabIndex = 1;
            this.btnBaocao.Text = "Báo cáo thống kê";
            this.btnBaocao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBaocao.Textcolor = System.Drawing.Color.White;
            this.btnBaocao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnThongtinkhachsan
            // 
            this.btnThongtinkhachsan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnThongtinkhachsan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThongtinkhachsan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongtinkhachsan.BorderRadius = 0;
            this.btnThongtinkhachsan.ButtonText = "About";
            this.btnThongtinkhachsan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnThongtinkhachsan, BunifuAnimatorNS.DecorationType.None);
            this.btnThongtinkhachsan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongtinkhachsan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongtinkhachsan.Iconimage = global::GUI.Properties.Resources.Button_Info_icon;
            this.btnThongtinkhachsan.Iconimage_right = null;
            this.btnThongtinkhachsan.Iconimage_right_Selected = null;
            this.btnThongtinkhachsan.Iconimage_Selected = null;
            this.btnThongtinkhachsan.IconMarginLeft = 0;
            this.btnThongtinkhachsan.IconMarginRight = 0;
            this.btnThongtinkhachsan.IconRightVisible = true;
            this.btnThongtinkhachsan.IconRightZoom = 0D;
            this.btnThongtinkhachsan.IconVisible = true;
            this.btnThongtinkhachsan.IconZoom = 90D;
            this.btnThongtinkhachsan.IsTab = false;
            this.btnThongtinkhachsan.Location = new System.Drawing.Point(4, 642);
            this.btnThongtinkhachsan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongtinkhachsan.Name = "btnThongtinkhachsan";
            this.btnThongtinkhachsan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThongtinkhachsan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThongtinkhachsan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongtinkhachsan.selected = false;
            this.btnThongtinkhachsan.Size = new System.Drawing.Size(335, 62);
            this.btnThongtinkhachsan.TabIndex = 1;
            this.btnThongtinkhachsan.Text = "About";
            this.btnThongtinkhachsan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongtinkhachsan.Textcolor = System.Drawing.Color.White;
            this.btnThongtinkhachsan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnQuanlyhoadon
            // 
            this.btnQuanlyhoadon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnQuanlyhoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlyhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanlyhoadon.BorderRadius = 0;
            this.btnQuanlyhoadon.ButtonText = "Thanh toán";
            this.btnQuanlyhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanlyhoadon, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanlyhoadon.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanlyhoadon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanlyhoadon.Iconimage = global::GUI.Properties.Resources.Objects_Dollar_bill_icon;
            this.btnQuanlyhoadon.Iconimage_right = null;
            this.btnQuanlyhoadon.Iconimage_right_Selected = null;
            this.btnQuanlyhoadon.Iconimage_Selected = null;
            this.btnQuanlyhoadon.IconMarginLeft = 0;
            this.btnQuanlyhoadon.IconMarginRight = 0;
            this.btnQuanlyhoadon.IconRightVisible = true;
            this.btnQuanlyhoadon.IconRightZoom = 0D;
            this.btnQuanlyhoadon.IconVisible = true;
            this.btnQuanlyhoadon.IconZoom = 90D;
            this.btnQuanlyhoadon.IsTab = false;
            this.btnQuanlyhoadon.Location = new System.Drawing.Point(4, 502);
            this.btnQuanlyhoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanlyhoadon.Name = "btnQuanlyhoadon";
            this.btnQuanlyhoadon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlyhoadon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuanlyhoadon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanlyhoadon.selected = false;
            this.btnQuanlyhoadon.Size = new System.Drawing.Size(335, 62);
            this.btnQuanlyhoadon.TabIndex = 1;
            this.btnQuanlyhoadon.Text = "Thanh toán";
            this.btnQuanlyhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanlyhoadon.Textcolor = System.Drawing.Color.White;
            this.btnQuanlyhoadon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnQuanlydichvu
            // 
            this.btnQuanlydichvu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnQuanlydichvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlydichvu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanlydichvu.BorderRadius = 0;
            this.btnQuanlydichvu.ButtonText = "Quản lý dịch vụ";
            this.btnQuanlydichvu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanlydichvu, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanlydichvu.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanlydichvu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanlydichvu.Iconimage = global::GUI.Properties.Resources.customer_service_icon;
            this.btnQuanlydichvu.Iconimage_right = null;
            this.btnQuanlydichvu.Iconimage_right_Selected = null;
            this.btnQuanlydichvu.Iconimage_Selected = null;
            this.btnQuanlydichvu.IconMarginLeft = 0;
            this.btnQuanlydichvu.IconMarginRight = 0;
            this.btnQuanlydichvu.IconRightVisible = true;
            this.btnQuanlydichvu.IconRightZoom = 0D;
            this.btnQuanlydichvu.IconVisible = true;
            this.btnQuanlydichvu.IconZoom = 90D;
            this.btnQuanlydichvu.IsTab = false;
            this.btnQuanlydichvu.Location = new System.Drawing.Point(4, 432);
            this.btnQuanlydichvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanlydichvu.Name = "btnQuanlydichvu";
            this.btnQuanlydichvu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlydichvu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuanlydichvu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanlydichvu.selected = false;
            this.btnQuanlydichvu.Size = new System.Drawing.Size(335, 62);
            this.btnQuanlydichvu.TabIndex = 1;
            this.btnQuanlydichvu.Text = "Quản lý dịch vụ";
            this.btnQuanlydichvu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanlydichvu.Textcolor = System.Drawing.Color.White;
            this.btnQuanlydichvu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnQuanlynhanvien
            // 
            this.btnQuanlynhanvien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnQuanlynhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlynhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanlynhanvien.BorderRadius = 0;
            this.btnQuanlynhanvien.ButtonText = "Quản lý nhân viên";
            this.btnQuanlynhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanlynhanvien, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanlynhanvien.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanlynhanvien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanlynhanvien.Iconimage = global::GUI.Properties.Resources.Preppy_icon;
            this.btnQuanlynhanvien.Iconimage_right = null;
            this.btnQuanlynhanvien.Iconimage_right_Selected = null;
            this.btnQuanlynhanvien.Iconimage_Selected = null;
            this.btnQuanlynhanvien.IconMarginLeft = 0;
            this.btnQuanlynhanvien.IconMarginRight = 0;
            this.btnQuanlynhanvien.IconRightVisible = true;
            this.btnQuanlynhanvien.IconRightZoom = 0D;
            this.btnQuanlynhanvien.IconVisible = true;
            this.btnQuanlynhanvien.IconZoom = 90D;
            this.btnQuanlynhanvien.IsTab = false;
            this.btnQuanlynhanvien.Location = new System.Drawing.Point(4, 362);
            this.btnQuanlynhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanlynhanvien.Name = "btnQuanlynhanvien";
            this.btnQuanlynhanvien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlynhanvien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuanlynhanvien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanlynhanvien.selected = false;
            this.btnQuanlynhanvien.Size = new System.Drawing.Size(335, 62);
            this.btnQuanlynhanvien.TabIndex = 1;
            this.btnQuanlynhanvien.Text = "Quản lý nhân viên";
            this.btnQuanlynhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanlynhanvien.Textcolor = System.Drawing.Color.White;
            this.btnQuanlynhanvien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnQuanlyloaiphong
            // 
            this.btnQuanlyloaiphong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnQuanlyloaiphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlyloaiphong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanlyloaiphong.BorderRadius = 0;
            this.btnQuanlyloaiphong.ButtonText = "Quản lý loại phòng";
            this.btnQuanlyloaiphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanlyloaiphong, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanlyloaiphong.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanlyloaiphong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanlyloaiphong.Iconimage = global::GUI.Properties.Resources.hotel_finder_icon;
            this.btnQuanlyloaiphong.Iconimage_right = null;
            this.btnQuanlyloaiphong.Iconimage_right_Selected = null;
            this.btnQuanlyloaiphong.Iconimage_Selected = null;
            this.btnQuanlyloaiphong.IconMarginLeft = 0;
            this.btnQuanlyloaiphong.IconMarginRight = 0;
            this.btnQuanlyloaiphong.IconRightVisible = true;
            this.btnQuanlyloaiphong.IconRightZoom = 0D;
            this.btnQuanlyloaiphong.IconVisible = true;
            this.btnQuanlyloaiphong.IconZoom = 90D;
            this.btnQuanlyloaiphong.IsTab = false;
            this.btnQuanlyloaiphong.Location = new System.Drawing.Point(4, 292);
            this.btnQuanlyloaiphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanlyloaiphong.Name = "btnQuanlyloaiphong";
            this.btnQuanlyloaiphong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlyloaiphong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuanlyloaiphong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanlyloaiphong.selected = false;
            this.btnQuanlyloaiphong.Size = new System.Drawing.Size(335, 62);
            this.btnQuanlyloaiphong.TabIndex = 1;
            this.btnQuanlyloaiphong.Text = "Quản lý loại phòng";
            this.btnQuanlyloaiphong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanlyloaiphong.Textcolor = System.Drawing.Color.White;
            this.btnQuanlyloaiphong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnQuanlyphong
            // 
            this.btnQuanlyphong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnQuanlyphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlyphong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanlyphong.BorderRadius = 0;
            this.btnQuanlyphong.ButtonText = "Quản lý phòng";
            this.btnQuanlyphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanlyphong, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanlyphong.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanlyphong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanlyphong.Iconimage = global::GUI.Properties.Resources.icon_hotel_1;
            this.btnQuanlyphong.Iconimage_right = null;
            this.btnQuanlyphong.Iconimage_right_Selected = null;
            this.btnQuanlyphong.Iconimage_Selected = null;
            this.btnQuanlyphong.IconMarginLeft = 0;
            this.btnQuanlyphong.IconMarginRight = 0;
            this.btnQuanlyphong.IconRightVisible = true;
            this.btnQuanlyphong.IconRightZoom = 0D;
            this.btnQuanlyphong.IconVisible = true;
            this.btnQuanlyphong.IconZoom = 90D;
            this.btnQuanlyphong.IsTab = false;
            this.btnQuanlyphong.Location = new System.Drawing.Point(4, 222);
            this.btnQuanlyphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanlyphong.Name = "btnQuanlyphong";
            this.btnQuanlyphong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuanlyphong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuanlyphong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanlyphong.selected = false;
            this.btnQuanlyphong.Size = new System.Drawing.Size(335, 62);
            this.btnQuanlyphong.TabIndex = 1;
            this.btnQuanlyphong.Text = "Quản lý phòng";
            this.btnQuanlyphong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanlyphong.Textcolor = System.Drawing.Color.White;
            this.btnQuanlyphong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlyphong.Click += new System.EventHandler(this.btnQuanlyphong_Click);
            // 
            // btnDatphong
            // 
            this.btnDatphong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnDatphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDatphong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatphong.BorderRadius = 0;
            this.btnDatphong.ButtonText = "Quản lý đặt phòng";
            this.btnDatphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDatphong, BunifuAnimatorNS.DecorationType.None);
            this.btnDatphong.DisabledColor = System.Drawing.Color.Gray;
            this.btnDatphong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDatphong.Iconimage = global::GUI.Properties.Resources.icon_calender;
            this.btnDatphong.Iconimage_right = null;
            this.btnDatphong.Iconimage_right_Selected = null;
            this.btnDatphong.Iconimage_Selected = null;
            this.btnDatphong.IconMarginLeft = 0;
            this.btnDatphong.IconMarginRight = 0;
            this.btnDatphong.IconRightVisible = true;
            this.btnDatphong.IconRightZoom = 0D;
            this.btnDatphong.IconVisible = true;
            this.btnDatphong.IconZoom = 90D;
            this.btnDatphong.IsTab = false;
            this.btnDatphong.Location = new System.Drawing.Point(4, 152);
            this.btnDatphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatphong.Name = "btnDatphong";
            this.btnDatphong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDatphong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDatphong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatphong.selected = false;
            this.btnDatphong.Size = new System.Drawing.Size(335, 62);
            this.btnDatphong.TabIndex = 1;
            this.btnDatphong.Text = "Quản lý đặt phòng";
            this.btnDatphong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDatphong.Textcolor = System.Drawing.Color.White;
            this.btnDatphong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatphong.Click += new System.EventHandler(this.btnDatphong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.lblChucvu);
            this.panel2.Controls.Add(this.lblHoten);
            this.panel2.Controls.Add(this.picNhanvien);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 135);
            this.panel2.TabIndex = 0;
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblChucvu, BunifuAnimatorNS.DecorationType.None);
            this.lblChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.ForeColor = System.Drawing.Color.White;
            this.lblChucvu.Location = new System.Drawing.Point(126, 61);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(110, 26);
            this.lblChucvu.TabIndex = 1;
            this.lblChucvu.Text = "Nhân viên";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblHoten, BunifuAnimatorNS.DecorationType.None);
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.White;
            this.lblHoten.Location = new System.Drawing.Point(114, 22);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(234, 26);
            this.lblHoten.TabIndex = 1;
            this.lblHoten.Text = "Nguyễn Thanh Nguyên";
            // 
            // picNhanvien
            // 
            this.picNhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.picNhanvien, BunifuAnimatorNS.DecorationType.None);
            this.picNhanvien.Location = new System.Drawing.Point(12, 12);
            this.picNhanvien.Name = "picNhanvien";
            this.picNhanvien.Size = new System.Drawing.Size(82, 75);
            this.picNhanvien.TabIndex = 0;
            this.picNhanvien.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 500;
            // 
            // contextMenuStrip1
            // 
            this.bunifuTransition1.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(351, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1157, 872);
            this.panel3.TabIndex = 1;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 872);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChinh";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.PictureBox picNhanvien;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDatphong;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanlynhanvien;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanlydichvu;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongtinkhachsan;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanlyhoadon;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaocao;
        private UserControls.UcQuanlyphong ucQuanlyphong1;
        private UserControls.UcQuanlynhanvien ucQuanlynhanvien1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanlyphong;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanlyloaiphong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
    }
}