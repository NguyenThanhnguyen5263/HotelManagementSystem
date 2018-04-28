namespace GUI.UserControls
{
    partial class UcQuanlyloaiphong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcQuanlyloaiphong));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaphong = new System.Windows.Forms.NumericUpDown();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenloai = new System.Windows.Forms.TextBox();
            this.gcDataLoaiphong = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiphong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaloaiphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenloaiphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cldongiatheogio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clDongiatheongay = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataLoaiphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.txtTenloai);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.txtMaphong);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.txtTenphong);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1157, 224);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin Loại Phòng";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(673, 158);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 43);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(265, 158);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 43);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMaphong.Location = new System.Drawing.Point(214, 52);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(186, 32);
            this.txtMaphong.TabIndex = 3;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTenphong.Location = new System.Drawing.Point(214, 104);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(186, 32);
            this.txtTenphong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(477, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn giá theo giờ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(406, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(477, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá theo giờ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(833, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "VND";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(641, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 32);
            this.textBox1.TabIndex = 1;
            // 
            // txtTenloai
            // 
            this.txtTenloai.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTenloai.Location = new System.Drawing.Point(641, 52);
            this.txtTenloai.Name = "txtTenloai";
            this.txtTenloai.Size = new System.Drawing.Size(186, 32);
            this.txtTenloai.TabIndex = 5;
            // 
            // gcDataLoaiphong
            // 
            this.gcDataLoaiphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDataLoaiphong.Location = new System.Drawing.Point(0, 224);
            this.gcDataLoaiphong.MainView = this.gvLoaiphong;
            this.gcDataLoaiphong.Name = "gcDataLoaiphong";
            this.gcDataLoaiphong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.gcDataLoaiphong.Size = new System.Drawing.Size(1157, 648);
            this.gcDataLoaiphong.TabIndex = 2;
            this.gcDataLoaiphong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiphong});
            // 
            // gvLoaiphong
            // 
            this.gvLoaiphong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaloaiphong,
            this.clTenloaiphong,
            this.cldongiatheogio,
            this.clDongiatheongay,
            this.clXoa});
            this.gvLoaiphong.GridControl = this.gcDataLoaiphong;
            this.gvLoaiphong.Name = "gvLoaiphong";
            // 
            // clMaloaiphong
            // 
            this.clMaloaiphong.Caption = "Mã Loại Phòng";
            this.clMaloaiphong.Name = "clMaloaiphong";
            this.clMaloaiphong.Visible = true;
            this.clMaloaiphong.VisibleIndex = 0;
            this.clMaloaiphong.Width = 227;
            // 
            // clTenloaiphong
            // 
            this.clTenloaiphong.Caption = "Tên Loại Phòng";
            this.clTenloaiphong.Name = "clTenloaiphong";
            this.clTenloaiphong.Visible = true;
            this.clTenloaiphong.VisibleIndex = 1;
            this.clTenloaiphong.Width = 249;
            // 
            // cldongiatheogio
            // 
            this.cldongiatheogio.Caption = "Đơn giá theo giờ";
            this.cldongiatheogio.Name = "cldongiatheogio";
            this.cldongiatheogio.Visible = true;
            this.cldongiatheogio.VisibleIndex = 2;
            this.cldongiatheogio.Width = 222;
            // 
            // clXoa
            // 
            this.clXoa.Caption = "Xóa";
            this.clXoa.ColumnEdit = this.btnXoa;
            this.clXoa.Name = "clXoa";
            this.clXoa.Visible = true;
            this.clXoa.VisibleIndex = 4;
            this.clXoa.Width = 146;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // clDongiatheongay
            // 
            this.clDongiatheongay.Caption = "Đơn Giá Theo Ngày";
            this.clDongiatheongay.Name = "clDongiatheongay";
            this.clDongiatheongay.Visible = true;
            this.clDongiatheongay.VisibleIndex = 3;
            this.clDongiatheongay.Width = 293;
            // 
            // UcQuanlyloaiphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDataLoaiphong);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcQuanlyloaiphong";
            this.Size = new System.Drawing.Size(1157, 872);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataLoaiphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtTenloai;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.NumericUpDown txtMaphong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDataLoaiphong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiphong;
        private DevExpress.XtraGrid.Columns.GridColumn clMaloaiphong;
        private DevExpress.XtraGrid.Columns.GridColumn clTenloaiphong;
        private DevExpress.XtraGrid.Columns.GridColumn cldongiatheogio;
        private DevExpress.XtraGrid.Columns.GridColumn clDongiatheongay;
        private DevExpress.XtraGrid.Columns.GridColumn clXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
    }
}
