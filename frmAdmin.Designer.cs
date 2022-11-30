
namespace FinalExam_PlanesSystem
{
    partial class frmAdmin
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
            this.mns = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePrice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewTicketUnbook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassForStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeStaffInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewInforStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mns.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns
            // 
            this.mns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiFunction});
            this.mns.Location = new System.Drawing.Point(0, 0);
            this.mns.Name = "mns";
            this.mns.Size = new System.Drawing.Size(800, 24);
            this.mns.TabIndex = 1;
            this.mns.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInfor,
            this.tsmiChangePass,
            this.tsmiLogout});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(69, 20);
            this.tsmiSystem.Text = "Hệ thống";
            // 
            // tsmiInfor
            // 
            this.tsmiInfor.Name = "tsmiInfor";
            this.tsmiInfor.Size = new System.Drawing.Size(150, 22);
            this.tsmiInfor.Text = "Xem thông tin";
            // 
            // tsmiChangePass
            // 
            this.tsmiChangePass.Name = "tsmiChangePass";
            this.tsmiChangePass.Size = new System.Drawing.Size(150, 22);
            this.tsmiChangePass.Text = "Đổi mật khẩu";
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(150, 22);
            this.tsmiLogout.Text = "Đăng xuất";
            // 
            // tsmiFunction
            // 
            this.tsmiFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageTicket,
            this.tsmiManageStaff});
            this.tsmiFunction.Name = "tsmiFunction";
            this.tsmiFunction.Size = new System.Drawing.Size(77, 20);
            this.tsmiFunction.Text = "Chức năng";
            // 
            // tsmiManageTicket
            // 
            this.tsmiManageTicket.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiAddTicket,
            this.tsmiRemoveTicket,
            this.tsmiUpdatePrice,
            this.tsmiViewTicketUnbook,
            this.tsmiViewReceipt});
            this.tsmiManageTicket.Name = "tsmiManageTicket";
            this.tsmiManageTicket.Size = new System.Drawing.Size(170, 22);
            this.tsmiManageTicket.Text = "Quản lý vé";
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(230, 22);
            this.tsmiSearch.Text = "Tìm kiếm";
            // 
            // tsmiAddTicket
            // 
            this.tsmiAddTicket.Name = "tsmiAddTicket";
            this.tsmiAddTicket.Size = new System.Drawing.Size(230, 22);
            this.tsmiAddTicket.Text = "Thêm vé";
            // 
            // tsmiRemoveTicket
            // 
            this.tsmiRemoveTicket.Name = "tsmiRemoveTicket";
            this.tsmiRemoveTicket.Size = new System.Drawing.Size(230, 22);
            this.tsmiRemoveTicket.Text = "Xóa vé";
            // 
            // tsmiUpdatePrice
            // 
            this.tsmiUpdatePrice.Name = "tsmiUpdatePrice";
            this.tsmiUpdatePrice.Size = new System.Drawing.Size(230, 22);
            this.tsmiUpdatePrice.Text = "Thay đổi giá vé";
            // 
            // tsmiViewTicketUnbook
            // 
            this.tsmiViewTicketUnbook.Name = "tsmiViewTicketUnbook";
            this.tsmiViewTicketUnbook.Size = new System.Drawing.Size(230, 22);
            this.tsmiViewTicketUnbook.Text = "Xem những vé chưa được đặt";
            // 
            // tsmiViewReceipt
            // 
            this.tsmiViewReceipt.Name = "tsmiViewReceipt";
            this.tsmiViewReceipt.Size = new System.Drawing.Size(230, 22);
            this.tsmiViewReceipt.Text = "Xem hóa đơn";
            // 
            // tsmiManageStaff
            // 
            this.tsmiManageStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStaff,
            this.tsmiRemoveStaff,
            this.tsmiChangePassForStaff,
            this.tsmiChangeStaffInfor,
            this.tsmiViewInforStaff});
            this.tsmiManageStaff.Name = "tsmiManageStaff";
            this.tsmiManageStaff.Size = new System.Drawing.Size(170, 22);
            this.tsmiManageStaff.Text = "Quản lý nhân viên";
            // 
            // tsmiAddStaff
            // 
            this.tsmiAddStaff.Name = "tsmiAddStaff";
            this.tsmiAddStaff.Size = new System.Drawing.Size(250, 22);
            this.tsmiAddStaff.Text = "Thêm nhân viên";
            // 
            // tsmiRemoveStaff
            // 
            this.tsmiRemoveStaff.Name = "tsmiRemoveStaff";
            this.tsmiRemoveStaff.Size = new System.Drawing.Size(250, 22);
            this.tsmiRemoveStaff.Text = "Xóa nhân viên";
            // 
            // tsmiChangePassForStaff
            // 
            this.tsmiChangePassForStaff.Name = "tsmiChangePassForStaff";
            this.tsmiChangePassForStaff.Size = new System.Drawing.Size(250, 22);
            this.tsmiChangePassForStaff.Text = "Thay đổi mật khẩu cho nhân viên";
            // 
            // tsmiChangeStaffInfor
            // 
            this.tsmiChangeStaffInfor.Name = "tsmiChangeStaffInfor";
            this.tsmiChangeStaffInfor.Size = new System.Drawing.Size(250, 22);
            this.tsmiChangeStaffInfor.Text = "Thay đổi thông tin cho nhân viên";
            // 
            // tsmiViewInforStaff
            // 
            this.tsmiViewInforStaff.Name = "tsmiViewInforStaff";
            this.tsmiViewInforStaff.Size = new System.Drawing.Size(250, 22);
            this.tsmiViewInforStaff.Text = "Xem thông tin của nhân viên";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mns);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mns;
            this.Name = "frmAdmin";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.mns.ResumeLayout(false);
            this.mns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFunction;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfor;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePass;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePrice;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewTicketUnbook;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewReceipt;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassForStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeStaffInfor;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewInforStaff;
    }
}
