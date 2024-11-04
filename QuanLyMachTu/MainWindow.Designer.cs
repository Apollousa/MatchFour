﻿    namespace QuanLyMachTu
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            panel_Menu = new Panel();
            iconButton_ThongTin = new FontAwesome.Sharp.IconButton();
            iconButton_CaiDat = new FontAwesome.Sharp.IconButton();
            iconButton_TaiChinh = new FontAwesome.Sharp.IconButton();
            iconButton_HoaDon = new FontAwesome.Sharp.IconButton();
            iconButton_PhongKham = new FontAwesome.Sharp.IconButton();
            iconButton_BenhNhan = new FontAwesome.Sharp.IconButton();
            iconButton_LichHen = new FontAwesome.Sharp.IconButton();
            iconButton_TomTat = new FontAwesome.Sharp.IconButton();
            panel_Logo = new Panel();
            label_Clock = new Label();
            icon_Home = new FontAwesome.Sharp.IconPictureBox();
            panel_TitleBar = new Panel();
            label_TitleChildForm = new Label();
            panel_ChildForm = new Panel();
            timer_Clock = new System.Windows.Forms.Timer(components);
            customGrpBox_LichHen = new CustomGrpBox();
            customGrpBox_TaiChinh = new CustomGrpBox();
            panel_Menu.SuspendLayout();
            panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_Home).BeginInit();
            panel_TitleBar.SuspendLayout();
            panel_ChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Menu
            // 
            resources.ApplyResources(panel_Menu, "panel_Menu");
            panel_Menu.BackColor = Color.WhiteSmoke;
            panel_Menu.BorderStyle = BorderStyle.FixedSingle;
            panel_Menu.Controls.Add(iconButton_ThongTin);
            panel_Menu.Controls.Add(iconButton_CaiDat);
            panel_Menu.Controls.Add(iconButton_TaiChinh);
            panel_Menu.Controls.Add(iconButton_HoaDon);
            panel_Menu.Controls.Add(iconButton_PhongKham);
            panel_Menu.Controls.Add(iconButton_BenhNhan);
            panel_Menu.Controls.Add(iconButton_LichHen);
            panel_Menu.Controls.Add(iconButton_TomTat);
            panel_Menu.Controls.Add(panel_Logo);
            panel_Menu.Name = "panel_Menu";
            // 
            // iconButton_ThongTin
            // 
            iconButton_ThongTin.BackColor = Color.White;
            resources.ApplyResources(iconButton_ThongTin, "iconButton_ThongTin");
            iconButton_ThongTin.FlatAppearance.BorderColor = Color.Silver;
            iconButton_ThongTin.FlatAppearance.BorderSize = 0;
            iconButton_ThongTin.ForeColor = Color.Black;
            iconButton_ThongTin.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconButton_ThongTin.IconColor = Color.Black;
            iconButton_ThongTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_ThongTin.IconSize = 50;
            iconButton_ThongTin.Name = "iconButton_ThongTin";
            iconButton_ThongTin.UseVisualStyleBackColor = false;
            iconButton_ThongTin.Click += iconButton_ThongTin_Click;
            // 
            // iconButton_CaiDat
            // 
            iconButton_CaiDat.BackColor = Color.White;
            resources.ApplyResources(iconButton_CaiDat, "iconButton_CaiDat");
            iconButton_CaiDat.FlatAppearance.BorderColor = Color.Silver;
            iconButton_CaiDat.FlatAppearance.BorderSize = 0;
            iconButton_CaiDat.ForeColor = Color.Black;
            iconButton_CaiDat.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconButton_CaiDat.IconColor = Color.Black;
            iconButton_CaiDat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_CaiDat.IconSize = 50;
            iconButton_CaiDat.Name = "iconButton_CaiDat";
            iconButton_CaiDat.UseVisualStyleBackColor = false;
            iconButton_CaiDat.Click += iconButton_CaiDat_Click;
            // 
            // iconButton_TaiChinh
            // 
            iconButton_TaiChinh.BackColor = Color.White;
            resources.ApplyResources(iconButton_TaiChinh, "iconButton_TaiChinh");
            iconButton_TaiChinh.FlatAppearance.BorderColor = Color.Silver;
            iconButton_TaiChinh.FlatAppearance.BorderSize = 0;
            iconButton_TaiChinh.ForeColor = Color.Black;
            iconButton_TaiChinh.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            iconButton_TaiChinh.IconColor = Color.Black;
            iconButton_TaiChinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_TaiChinh.IconSize = 50;
            iconButton_TaiChinh.Name = "iconButton_TaiChinh";
            iconButton_TaiChinh.UseVisualStyleBackColor = false;
            iconButton_TaiChinh.Click += iconButton_TaiChinh_Click;
            // 
            // iconButton_HoaDon
            // 
            iconButton_HoaDon.BackColor = Color.White;
            resources.ApplyResources(iconButton_HoaDon, "iconButton_HoaDon");
            iconButton_HoaDon.FlatAppearance.BorderColor = Color.Silver;
            iconButton_HoaDon.FlatAppearance.BorderSize = 0;
            iconButton_HoaDon.ForeColor = Color.Black;
            iconButton_HoaDon.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconButton_HoaDon.IconColor = Color.Black;
            iconButton_HoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_HoaDon.IconSize = 50;
            iconButton_HoaDon.Name = "iconButton_HoaDon";
            iconButton_HoaDon.UseVisualStyleBackColor = false;
            iconButton_HoaDon.Click += iconButton_HoaDon_Click;
            // 
            // iconButton_PhongKham
            // 
            iconButton_PhongKham.BackColor = Color.White;
            resources.ApplyResources(iconButton_PhongKham, "iconButton_PhongKham");
            iconButton_PhongKham.FlatAppearance.BorderColor = Color.Silver;
            iconButton_PhongKham.FlatAppearance.BorderSize = 0;
            iconButton_PhongKham.ForeColor = Color.Black;
            iconButton_PhongKham.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            iconButton_PhongKham.IconColor = Color.Black;
            iconButton_PhongKham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_PhongKham.IconSize = 50;
            iconButton_PhongKham.Name = "iconButton_PhongKham";
            iconButton_PhongKham.UseVisualStyleBackColor = false;
            iconButton_PhongKham.Click += iconButton_PhongKham_Click;
            // 
            // iconButton_BenhNhan
            // 
            iconButton_BenhNhan.BackColor = Color.White;
            resources.ApplyResources(iconButton_BenhNhan, "iconButton_BenhNhan");
            iconButton_BenhNhan.FlatAppearance.BorderColor = Color.Silver;
            iconButton_BenhNhan.FlatAppearance.BorderSize = 0;
            iconButton_BenhNhan.ForeColor = Color.Black;
            iconButton_BenhNhan.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            iconButton_BenhNhan.IconColor = Color.Black;
            iconButton_BenhNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_BenhNhan.IconSize = 50;
            iconButton_BenhNhan.Name = "iconButton_BenhNhan";
            iconButton_BenhNhan.UseVisualStyleBackColor = false;
            iconButton_BenhNhan.Click += iconButton_BenhNhan_Click;
            // 
            // iconButton_LichHen
            // 
            iconButton_LichHen.BackColor = Color.White;
            resources.ApplyResources(iconButton_LichHen, "iconButton_LichHen");
            iconButton_LichHen.FlatAppearance.BorderColor = Color.Silver;
            iconButton_LichHen.FlatAppearance.BorderSize = 0;
            iconButton_LichHen.ForeColor = Color.Black;
            iconButton_LichHen.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            iconButton_LichHen.IconColor = Color.Black;
            iconButton_LichHen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_LichHen.IconSize = 50;
            iconButton_LichHen.Name = "iconButton_LichHen";
            iconButton_LichHen.UseVisualStyleBackColor = false;
            iconButton_LichHen.Click += iconButton_LichHen_Click;
            // 
            // iconButton_TomTat
            // 
            iconButton_TomTat.BackColor = Color.White;
            resources.ApplyResources(iconButton_TomTat, "iconButton_TomTat");
            iconButton_TomTat.FlatAppearance.BorderColor = Color.Silver;
            iconButton_TomTat.FlatAppearance.BorderSize = 0;
            iconButton_TomTat.ForeColor = Color.Black;
            iconButton_TomTat.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            iconButton_TomTat.IconColor = Color.Black;
            iconButton_TomTat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_TomTat.IconSize = 50;
            iconButton_TomTat.Name = "iconButton_TomTat";
            iconButton_TomTat.UseVisualStyleBackColor = false;
            iconButton_TomTat.Click += iconButton_TomTat_Click;
            // 
            // panel_Logo
            // 
            panel_Logo.BackColor = Color.WhiteSmoke;
            panel_Logo.Controls.Add(label_Clock);
            panel_Logo.Controls.Add(icon_Home);
            resources.ApplyResources(panel_Logo, "panel_Logo");
            panel_Logo.Name = "panel_Logo";
            panel_Logo.Click += icon_Home_Click;
            // 
            // label_Clock
            // 
            resources.ApplyResources(label_Clock, "label_Clock");
            label_Clock.Name = "label_Clock";
            label_Clock.Click += icon_Home_Click;
            // 
            // icon_Home
            // 
            icon_Home.BackColor = Color.Transparent;
            icon_Home.ForeColor = SystemColors.ControlText;
            icon_Home.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            icon_Home.IconColor = SystemColors.ControlText;
            icon_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_Home.IconSize = 120;
            resources.ApplyResources(icon_Home, "icon_Home");
            icon_Home.Name = "icon_Home";
            icon_Home.TabStop = false;
            icon_Home.Click += icon_Home_Click;
            // 
            // panel_TitleBar
            // 
            panel_TitleBar.BackColor = Color.Gainsboro;
            panel_TitleBar.Controls.Add(label_TitleChildForm);
            resources.ApplyResources(panel_TitleBar, "panel_TitleBar");
            panel_TitleBar.Name = "panel_TitleBar";
            // 
            // label_TitleChildForm
            // 
            resources.ApplyResources(label_TitleChildForm, "label_TitleChildForm");
            label_TitleChildForm.Name = "label_TitleChildForm";
            // 
            // panel_ChildForm
            // 
            panel_ChildForm.BackColor = Color.White;
            panel_ChildForm.Controls.Add(customGrpBox_TaiChinh);
            panel_ChildForm.Controls.Add(customGrpBox_LichHen);
            resources.ApplyResources(panel_ChildForm, "panel_ChildForm");
            panel_ChildForm.Name = "panel_ChildForm";
            // 
            // timer_Clock
            // 
            timer_Clock.Enabled = true;
            timer_Clock.Interval = 1000;
            timer_Clock.Tick += timer_Clock_Tick;
            // 
            // customGrpBox_LichHen
            // 
            resources.ApplyResources(customGrpBox_LichHen, "customGrpBox_LichHen");
            customGrpBox_LichHen.Name = "customGrpBox_LichHen";
            customGrpBox_LichHen.TabStop = false;
            // 
            // customGrpBox_TaiChinh
            // 
            resources.ApplyResources(customGrpBox_TaiChinh, "customGrpBox_TaiChinh");
            customGrpBox_TaiChinh.Name = "customGrpBox_TaiChinh";
            customGrpBox_TaiChinh.TabStop = false;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel_ChildForm);
            Controls.Add(panel_TitleBar);
            Controls.Add(panel_Menu);
            Name = "MainWindow";
            panel_Menu.ResumeLayout(false);
            panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_Home).EndInit();
            panel_TitleBar.ResumeLayout(false);
            panel_ChildForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Menu;
        private FontAwesome.Sharp.IconButton iconButton_TomTat;
        private Panel panel_Logo;
        private FontAwesome.Sharp.IconButton iconButton_CaiDat;
        private FontAwesome.Sharp.IconButton iconButton_TaiChinh;
        private FontAwesome.Sharp.IconButton iconButton_LichHen;
        private FontAwesome.Sharp.IconButton iconButton_BenhNhan;
        private FontAwesome.Sharp.IconPictureBox icon_Home;
        private Panel panel_TitleBar;
        private Label label_TitleChildForm;
        private Panel panel_ChildForm;
        private FontAwesome.Sharp.IconButton iconButton_PhongKham;
        private FontAwesome.Sharp.IconButton iconButton_ThongTin;
        private Label label_Clock;
        private System.Windows.Forms.Timer timer_Clock;
        private FontAwesome.Sharp.IconButton iconButton_HoaDon;
        private CustomGrpBox customGrpBox_TaiChinh;
        private CustomGrpBox customGrpBox_LichHen;
    }
}
