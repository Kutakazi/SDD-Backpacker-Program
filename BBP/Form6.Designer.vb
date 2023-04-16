<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pbBar = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConvertLeft = New System.Windows.Forms.Label()
        Me.lblConvertRight = New System.Windows.Forms.Label()
        Me.cbleft = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.tbLeft = New System.Windows.Forms.TextBox()
        Me.lblAmountLeft = New System.Windows.Forms.Label()
        Me.lblAmountRight = New System.Windows.Forms.Label()
        Me.tbRight = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblExchangeLeft = New System.Windows.Forms.Label()
        Me.lblExchangeRight = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.cbRight = New System.Windows.Forms.ComboBox()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.BackgroundImage = Global.BBP.My.Resources.Resources.Close
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExit.Location = New System.Drawing.Point(982, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 70)
        Me.btnExit.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMinimize.BackgroundImage = Global.BBP.My.Resources.Resources.Minimize
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMinimize.Location = New System.Drawing.Point(906, 10)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(70, 70)
        Me.btnMinimize.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnInfo.BackgroundImage = Global.BBP.My.Resources.Resources.Info
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInfo.Location = New System.Drawing.Point(88, 10)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(70, 70)
        Me.btnInfo.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnInfo, "Infomation")
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnReturn.BackgroundImage = Global.BBP.My.Resources.Resources.Back
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReturn.Location = New System.Drawing.Point(12, 10)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(70, 70)
        Me.btnReturn.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Return")
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl1.Location = New System.Drawing.Point(340, 20)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(384, 50)
        Me.lbl1.TabIndex = 26
        Me.lbl1.Text = "Backpacker Program"
        '
        'pbBar
        '
        Me.pbBar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbBar.Location = New System.Drawing.Point(0, 0)
        Me.pbBar.Name = "pbBar"
        Me.pbBar.Size = New System.Drawing.Size(1064, 90)
        Me.pbBar.TabIndex = 21
        Me.pbBar.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 111)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1064, 45)
        Me.lblTitle.TabIndex = 27
        Me.lblTitle.Text = "Currency Converter"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(544, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 45)
        Me.Label1.TabIndex = 28
        '
        'lblConvertLeft
        '
        Me.lblConvertLeft.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertLeft.Location = New System.Drawing.Point(116, 188)
        Me.lblConvertLeft.Name = "lblConvertLeft"
        Me.lblConvertLeft.Size = New System.Drawing.Size(300, 37)
        Me.lblConvertLeft.TabIndex = 31
        Me.lblConvertLeft.Text = "Convert From"
        Me.lblConvertLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConvertRight
        '
        Me.lblConvertRight.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertRight.Location = New System.Drawing.Point(648, 188)
        Me.lblConvertRight.Name = "lblConvertRight"
        Me.lblConvertRight.Size = New System.Drawing.Size(300, 37)
        Me.lblConvertRight.TabIndex = 32
        Me.lblConvertRight.Text = "Convert To"
        Me.lblConvertRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbleft
        '
        Me.cbleft.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbleft.FormattingEnabled = True
        Me.cbleft.Items.AddRange(New Object() {"USD (United States Dollar)"})
        Me.cbleft.Location = New System.Drawing.Point(116, 240)
        Me.cbleft.Name = "cbleft"
        Me.cbleft.Size = New System.Drawing.Size(300, 38)
        Me.cbleft.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1064, 45)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Exchange Rate"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.Location = New System.Drawing.Point(448, 245)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(169, 29)
        Me.cb1.TabIndex = 46
        Me.cb1.Text = "Flip Conversion"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'tbLeft
        '
        Me.tbLeft.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLeft.Location = New System.Drawing.Point(76, 359)
        Me.tbLeft.Name = "tbLeft"
        Me.tbLeft.Size = New System.Drawing.Size(380, 35)
        Me.tbLeft.TabIndex = 47
        Me.tbLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAmountLeft
        '
        Me.lblAmountLeft.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountLeft.Location = New System.Drawing.Point(76, 297)
        Me.lblAmountLeft.Name = "lblAmountLeft"
        Me.lblAmountLeft.Size = New System.Drawing.Size(380, 37)
        Me.lblAmountLeft.TabIndex = 49
        Me.lblAmountLeft.Text = "Amount (Currency)"
        Me.lblAmountLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmountRight
        '
        Me.lblAmountRight.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountRight.Location = New System.Drawing.Point(608, 297)
        Me.lblAmountRight.Name = "lblAmountRight"
        Me.lblAmountRight.Size = New System.Drawing.Size(380, 37)
        Me.lblAmountRight.TabIndex = 50
        Me.lblAmountRight.Text = "Amount (Currency)"
        Me.lblAmountRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbRight
        '
        Me.tbRight.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRight.Location = New System.Drawing.Point(608, 359)
        Me.tbRight.Name = "tbRight"
        Me.tbRight.ReadOnly = True
        Me.tbRight.Size = New System.Drawing.Size(380, 35)
        Me.tbRight.TabIndex = 51
        Me.tbRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(475, 425)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 40)
        Me.btnUpdate.TabIndex = 52
        Me.btnUpdate.Text = "Convert"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblExchangeLeft
        '
        Me.lblExchangeLeft.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExchangeLeft.Location = New System.Drawing.Point(12, 557)
        Me.lblExchangeLeft.Name = "lblExchangeLeft"
        Me.lblExchangeLeft.Size = New System.Drawing.Size(404, 64)
        Me.lblExchangeLeft.TabIndex = 53
        Me.lblExchangeLeft.Text = "1 Australian Dollar"
        Me.lblExchangeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExchangeRight
        '
        Me.lblExchangeRight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExchangeRight.Location = New System.Drawing.Point(646, 557)
        Me.lblExchangeRight.Name = "lblExchangeRight"
        Me.lblExchangeRight.Size = New System.Drawing.Size(406, 64)
        Me.lblExchangeRight.TabIndex = 54
        Me.lblExchangeRight.Text = "1 Australian Dollar"
        Me.lblExchangeRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 573)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Equals"
        '
        'lblUpdate
        '
        Me.lblUpdate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.Location = New System.Drawing.Point(0, 633)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(1064, 30)
        Me.lblUpdate.TabIndex = 56
        Me.lblUpdate.Text = "Last Updated:"
        Me.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbRight
        '
        Me.cbRight.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRight.FormattingEnabled = True
        Me.cbRight.Items.AddRange(New Object() {"AUD (Australian Dollar)", "BGN (Bulgarian Lev)", "BRL (Brazilian Real)", "CAD (Canadian Dollar)", "CHF (Swiss Franc)", "CNY (Renminbi)", "CZK (Czech Koruna)", "DKK (Danish Krone)", "EUR (Euro)", "GBP (British Pound Sterling)", "HKD (Hong Kong Dollar)", "HRK (Croatian Kuna)", "HUF (Hungarian Forint)", "IDR (Indonesian Rupiah)", "ILS (Israeli Shekel)", "INR (Indian Rupee)", "ISK (Icelandic Króna)", "JPY (Japanese Yen)", "KRW (South Korean won)", "MXN (Mexican Peso)", "MYR (Malaysian Ringgit)", "NOK (Norwegian Krone)", "NZD (New Zealand Dollar)", "PHP (Philippine Peso)", "PLN (Polish Zloty)", "RON (Romanian Leu)", "RUB (Russian Ruble)", "SEK (Swedish Krona)", "SGD (Singapore Dollar)", "THB (Thai Baht)", "USD (United States Dollar)", "ZAR (South African Rand)"})
        Me.cbRight.Location = New System.Drawing.Point(648, 240)
        Me.cbRight.Name = "cbRight"
        Me.cbRight.Size = New System.Drawing.Size(300, 38)
        Me.cbRight.TabIndex = 57
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbRight)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblExchangeRight)
        Me.Controls.Add(Me.lblExchangeLeft)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.tbRight)
        Me.Controls.Add(Me.lblAmountRight)
        Me.Controls.Add(Me.lblAmountLeft)
        Me.Controls.Add(Me.tbLeft)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbleft)
        Me.Controls.Add(Me.lblConvertRight)
        Me.Controls.Add(Me.lblConvertLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pbBar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "Form6"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Currency Converter"
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents pbBar As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConvertLeft As Label
    Friend WithEvents lblConvertRight As Label
    Friend WithEvents cbleft As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents tbLeft As TextBox
    Friend WithEvents lblAmountLeft As Label
    Friend WithEvents lblAmountRight As Label
    Friend WithEvents tbRight As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblExchangeLeft As Label
    Friend WithEvents lblExchangeRight As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUpdate As Label
    Friend WithEvents tmr As Timer
    Friend WithEvents cbRight As ComboBox
End Class
