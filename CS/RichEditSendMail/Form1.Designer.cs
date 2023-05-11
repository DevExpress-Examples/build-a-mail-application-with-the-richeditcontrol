namespace RichEditSendMail {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.richEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.edtSubject = new DevExpress.XtraEditors.TextEdit();
            this.lblTo = new DevExpress.XtraEditors.LabelControl();
            this.edtTo = new DevExpress.XtraEditors.TextEdit();
            this.lblSmtp = new DevExpress.XtraEditors.LabelControl();
            this.edtSmtp = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.edtSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSmtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEdit
            // 
            this.richEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEdit.Location = new System.Drawing.Point(0, 0);
            this.richEdit.Margin = new System.Windows.Forms.Padding(4);
            this.richEdit.Name = "richEdit";
            this.richEdit.Size = new System.Drawing.Size(988, 463);
            this.richEdit.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(861, 2);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 91);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send Mail";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(11, 20);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(48, 16);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject:";
            // 
            // edtSubject
            // 
            this.edtSubject.EditValue = "Hey, look at this!";
            this.edtSubject.Location = new System.Drawing.Point(69, 17);
            this.edtSubject.Margin = new System.Windows.Forms.Padding(5);
            this.edtSubject.Name = "edtSubject";
            this.edtSubject.Size = new System.Drawing.Size(330, 22);
            this.edtSubject.TabIndex = 0;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(11, 60);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 16);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            // 
            // edtTo
            // 
            this.edtTo.Location = new System.Drawing.Point(69, 57);
            this.edtTo.Margin = new System.Windows.Forms.Padding(5);
            this.edtTo.Name = "edtTo";
            this.edtTo.Size = new System.Drawing.Size(330, 22);
            this.edtTo.TabIndex = 1;
            // 
            // lblSmtp
            // 
            this.lblSmtp.Location = new System.Drawing.Point(423, 20);
            this.lblSmtp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSmtp.Name = "lblSmtp";
            this.lblSmtp.Size = new System.Drawing.Size(66, 16);
            this.lblSmtp.TabIndex = 2;
            this.lblSmtp.Text = "MailServer:";
            // 
            // edtSmtp
            // 
            this.edtSmtp.Location = new System.Drawing.Point(499, 17);
            this.edtSmtp.Margin = new System.Windows.Forms.Padding(5);
            this.edtSmtp.Name = "edtSmtp";
            this.edtSmtp.Size = new System.Drawing.Size(330, 22);
            this.edtSmtp.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSend);
            this.panelControl1.Controls.Add(this.edtTo);
            this.panelControl1.Controls.Add(this.lblSubject);
            this.panelControl1.Controls.Add(this.lblTo);
            this.panelControl1.Controls.Add(this.edtSubject);
            this.panelControl1.Controls.Add(this.edtSmtp);
            this.panelControl1.Controls.Add(this.lblSmtp);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 463);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(988, 95);
            this.panelControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 558);
            this.Controls.Add(this.richEdit);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edtSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSmtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        DevExpress.XtraRichEdit.RichEditControl richEdit;
        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.TextEdit edtSubject;
        private DevExpress.XtraEditors.LabelControl lblTo;
        private DevExpress.XtraEditors.TextEdit edtTo;
        private DevExpress.XtraEditors.LabelControl lblSmtp;
        private DevExpress.XtraEditors.TextEdit edtSmtp;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}

