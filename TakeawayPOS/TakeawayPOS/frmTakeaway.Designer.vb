<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTakeaway
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRpt = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtDeliveryFee = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtLocName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbOrderType = New System.Windows.Forms.ComboBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flpCategories = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grdOrderDetails = New System.Windows.Forms.DataGridView()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grdOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRpt)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnInfo)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 56)
        Me.Panel1.TabIndex = 0
        '
        'btnRpt
        '
        Me.btnRpt.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRpt.Font = New System.Drawing.Font("Cairo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRpt.Location = New System.Drawing.Point(387, 11)
        Me.btnRpt.Name = "btnRpt"
        Me.btnRpt.Size = New System.Drawing.Size(100, 38)
        Me.btnRpt.TabIndex = 4
        Me.btnRpt.Text = "آخر فاتورة"
        Me.btnRpt.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExit.Font = New System.Drawing.Font("Cairo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(271, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "خروج"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnInfo.Font = New System.Drawing.Font("Cairo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(503, 11)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(100, 38)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "عرض التفاصل"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNew.Font = New System.Drawing.Font("Cairo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(619, 11)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(100, 38)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "إضافة جديد"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSave.Font = New System.Drawing.Font("Cairo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(735, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 38)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(851, 154)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.76!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.24!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel9, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(851, 154)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(281, 148)
        Me.Panel7.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823529!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.17647!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtNotes, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(281, 148)
        Me.TableLayoutPanel3.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ملاحظات"
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(22, 21)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(190, 115)
        Me.txtNotes.TabIndex = 20
        Me.txtNotes.Text = ""
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtStaffName)
        Me.Panel8.Controls.Add(Me.txtDeliveryFee)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.lblOrderTotal)
        Me.Panel8.Controls.Add(Me.txtOrderTotal)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.cmbPayment)
        Me.Panel8.Controls.Add(Me.lblPayment)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(290, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(276, 148)
        Me.Panel8.TabIndex = 1
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(33, 14)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(136, 20)
        Me.txtStaffName.TabIndex = 21
        '
        'txtDeliveryFee
        '
        Me.txtDeliveryFee.Location = New System.Drawing.Point(33, 114)
        Me.txtDeliveryFee.Name = "txtDeliveryFee"
        Me.txtDeliveryFee.Size = New System.Drawing.Size(136, 20)
        Me.txtDeliveryFee.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "التوصيل"
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.Location = New System.Drawing.Point(220, 49)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(45, 13)
        Me.lblOrderTotal.TabIndex = 10
        Me.lblOrderTotal.Text = "الاجمالي"
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Location = New System.Drawing.Point(33, 47)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.Size = New System.Drawing.Size(136, 20)
        Me.txtOrderTotal.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "اسم الكاشير"
        '
        'cmbPayment
        '
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Location = New System.Drawing.Point(33, 79)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(136, 21)
        Me.cmbPayment.TabIndex = 15
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(205, 83)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(60, 13)
        Me.lblPayment.TabIndex = 14
        Me.lblPayment.Text = "طريقة الدفع"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtLocName)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.cmbOrderType)
        Me.Panel9.Controls.Add(Me.txtOrderID)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.label1)
        Me.Panel9.Controls.Add(Me.cmbCustomerName)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(572, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(276, 148)
        Me.Panel9.TabIndex = 2
        '
        'txtLocName
        '
        Me.txtLocName.Location = New System.Drawing.Point(27, 116)
        Me.txtLocName.Name = "txtLocName"
        Me.txtLocName.Size = New System.Drawing.Size(136, 20)
        Me.txtLocName.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "المنطقة"
        '
        'cmbOrderType
        '
        Me.cmbOrderType.FormattingEnabled = True
        Me.cmbOrderType.Location = New System.Drawing.Point(27, 84)
        Me.cmbOrderType.Name = "cmbOrderType"
        Me.cmbOrderType.Size = New System.Drawing.Size(136, 21)
        Me.cmbOrderType.TabIndex = 16
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(27, 13)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(136, 20)
        Me.txtOrderID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "نوع الأوردر"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(205, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "رقم الأوردر"
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(27, 46)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(136, 21)
        Me.cmbCustomerName.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "اسم العميل"
        '
        'flpCategories
        '
        Me.flpCategories.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpCategories.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flpCategories.Location = New System.Drawing.Point(0, 0)
        Me.flpCategories.Name = "flpCategories"
        Me.flpCategories.Size = New System.Drawing.Size(851, 51)
        Me.flpCategories.TabIndex = 2
        '
        'flpItems
        '
        Me.flpItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpItems.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flpItems.Location = New System.Drawing.Point(0, 51)
        Me.flpItems.Name = "flpItems"
        Me.flpItems.Size = New System.Drawing.Size(851, 81)
        Me.flpItems.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.flpItems)
        Me.Panel3.Controls.Add(Me.flpCategories)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 210)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(851, 132)
        Me.Panel3.TabIndex = 4
        '
        'grdOrderDetails
        '
        Me.grdOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOrderDetails.Location = New System.Drawing.Point(0, 0)
        Me.grdOrderDetails.Name = "grdOrderDetails"
        Me.grdOrderDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grdOrderDetails.Size = New System.Drawing.Size(771, 221)
        Me.grdOrderDetails.TabIndex = 4
        '
        'btnIncrease
        '
        Me.btnIncrease.Font = New System.Drawing.Font("Cairo", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrease.Location = New System.Drawing.Point(9, 24)
        Me.btnIncrease.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(51, 54)
        Me.btnIncrease.TabIndex = 5
        Me.btnIncrease.Text = "+"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'btnDecrease
        '
        Me.btnDecrease.Font = New System.Drawing.Font("Cairo", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnDecrease.Location = New System.Drawing.Point(9, 93)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(51, 54)
        Me.btnDecrease.TabIndex = 6
        Me.btnDecrease.Text = "-"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 342)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(851, 227)
        Me.Panel4.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.717949!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.28205!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(851, 227)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.grdOrderDetails)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(77, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(771, 221)
        Me.Panel5.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnIncrease)
        Me.Panel6.Controls.Add(Me.btnDelete)
        Me.Panel6.Controls.Add(Me.btnDecrease)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(68, 221)
        Me.Panel6.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(7, 161)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(53, 50)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmTakeaway
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(851, 569)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTakeaway"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Takeaway"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.grdOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents txtOrderTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderTotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents flpCategories As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpItems As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmbOrderType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents grdOrderDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnDecrease As System.Windows.Forms.Button
    Friend WithEvents btnIncrease As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryFee As System.Windows.Forms.TextBox
    Friend WithEvents btnRpt As System.Windows.Forms.Button
    Friend WithEvents txtLocName As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
End Class
