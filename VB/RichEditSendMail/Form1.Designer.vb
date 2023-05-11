Namespace RichEditSendMail

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEdit = New DevExpress.XtraRichEdit.RichEditControl()
            Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
            Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
            Me.edtSubject = New DevExpress.XtraEditors.TextEdit()
            Me.lblTo = New DevExpress.XtraEditors.LabelControl()
            Me.edtTo = New DevExpress.XtraEditors.TextEdit()
            Me.lblSmtp = New DevExpress.XtraEditors.LabelControl()
            Me.edtSmtp = New DevExpress.XtraEditors.TextEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtSmtp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'richEdit
            '
            Me.richEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEdit.Location = New System.Drawing.Point(0, 0)
            Me.richEdit.Margin = New System.Windows.Forms.Padding(4)
            Me.richEdit.Name = "richEdit"
            Me.richEdit.Size = New System.Drawing.Size(988, 463)
            Me.richEdit.TabIndex = 4
            '
            'btnSend
            '
            Me.btnSend.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnSend.Location = New System.Drawing.Point(861, 2)
            Me.btnSend.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.btnSend.Name = "btnSend"
            Me.btnSend.Size = New System.Drawing.Size(125, 91)
            Me.btnSend.TabIndex = 3
            Me.btnSend.Text = "Send Mail"
            '
            'lblSubject
            '
            Me.lblSubject.Location = New System.Drawing.Point(11, 20)
            Me.lblSubject.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.lblSubject.Name = "lblSubject"
            Me.lblSubject.Size = New System.Drawing.Size(48, 16)
            Me.lblSubject.TabIndex = 2
            Me.lblSubject.Text = "Subject:"
            '
            'edtSubject
            '
            Me.edtSubject.EditValue = "Hey, look at this!"
            Me.edtSubject.Location = New System.Drawing.Point(69, 17)
            Me.edtSubject.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.edtSubject.Name = "edtSubject"
            Me.edtSubject.Size = New System.Drawing.Size(330, 22)
            Me.edtSubject.TabIndex = 0
            '
            'lblTo
            '
            Me.lblTo.Location = New System.Drawing.Point(11, 60)
            Me.lblTo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.lblTo.Name = "lblTo"
            Me.lblTo.Size = New System.Drawing.Size(20, 16)
            Me.lblTo.TabIndex = 2
            Me.lblTo.Text = "To:"
            '
            'edtTo
            '
            Me.edtTo.Location = New System.Drawing.Point(69, 57)
            Me.edtTo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.edtTo.Name = "edtTo"
            Me.edtTo.Size = New System.Drawing.Size(330, 22)
            Me.edtTo.TabIndex = 1
            '
            'lblSmtp
            '
            Me.lblSmtp.Location = New System.Drawing.Point(409, 20)
            Me.lblSmtp.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.lblSmtp.Name = "lblSmtp"
            Me.lblSmtp.Size = New System.Drawing.Size(66, 16)
            Me.lblSmtp.TabIndex = 2
            Me.lblSmtp.Text = "MailServer:"
            '
            'edtSmtp
            '
            Me.edtSmtp.Location = New System.Drawing.Point(485, 17)
            Me.edtSmtp.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.edtSmtp.Name = "edtSmtp"
            Me.edtSmtp.Size = New System.Drawing.Size(330, 22)
            Me.edtSmtp.TabIndex = 2
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.btnSend)
            Me.panelControl1.Controls.Add(Me.edtTo)
            Me.panelControl1.Controls.Add(Me.lblSubject)
            Me.panelControl1.Controls.Add(Me.lblTo)
            Me.panelControl1.Controls.Add(Me.edtSubject)
            Me.panelControl1.Controls.Add(Me.edtSmtp)
            Me.panelControl1.Controls.Add(Me.lblSmtp)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 463)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(988, 95)
            Me.panelControl1.TabIndex = 4
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(988, 558)
            Me.Controls.Add(Me.richEdit)
            Me.Controls.Add(Me.panelControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtSmtp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private richEdit As DevExpress.XtraRichEdit.RichEditControl

        '#End Region
        Private btnSend As DevExpress.XtraEditors.SimpleButton

        Private lblSubject As DevExpress.XtraEditors.LabelControl

        Private edtSubject As DevExpress.XtraEditors.TextEdit

        Private lblTo As DevExpress.XtraEditors.LabelControl

        Private edtTo As DevExpress.XtraEditors.TextEdit

        Private lblSmtp As DevExpress.XtraEditors.LabelControl

        Private edtSmtp As DevExpress.XtraEditors.TextEdit

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
