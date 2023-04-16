<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.llblGoogleMaps = New System.Windows.Forms.LinkLabel()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pbBar = New System.Windows.Forms.PictureBox()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lbl1.TabIndex = 20
        Me.lbl1.Text = "Backpacker Program"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 96)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1064, 45)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "(Landmark)"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCountry
        '
        Me.lblCountry.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(12, 614)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(399, 40)
        Me.lblCountry.TabIndex = 26
        Me.lblCountry.Text = "(Country) Landmarks"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llblGoogleMaps
        '
        Me.llblGoogleMaps.AutoSize = True
        Me.llblGoogleMaps.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGoogleMaps.Location = New System.Drawing.Point(683, 618)
        Me.llblGoogleMaps.Name = "llblGoogleMaps"
        Me.llblGoogleMaps.Size = New System.Drawing.Size(359, 30)
        Me.llblGoogleMaps.TabIndex = 27
        Me.llblGoogleMaps.TabStop = True
        Me.llblGoogleMaps.Text = "Link To Landmark On Google Maps"
        '
        'tmr1
        '
        Me.tmr1.Enabled = True
        Me.tmr1.Interval = 7500
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPrev.BackgroundImage = Global.BBP.My.Resources.Resources.Left
        Me.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrev.Location = New System.Drawing.Point(417, 601)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(70, 70)
        Me.btnPrev.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.btnPrev, "Previous")
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNext.BackgroundImage = Global.BBP.My.Resources.Resources.Right
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(577, 601)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(70, 70)
        Me.btnNext.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnNext, "Next")
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnControl
        '
        Me.btnControl.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnControl.BackgroundImage = Global.BBP.My.Resources.Resources.Pause
        Me.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnControl.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnControl.Location = New System.Drawing.Point(497, 601)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(70, 70)
        Me.btnControl.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnControl, "Control")
        Me.btnControl.UseVisualStyleBackColor = False
        '
        'pbMain
        '
        Me.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMain.Location = New System.Drawing.Point(0, 153)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(1064, 438)
        Me.pbMain.TabIndex = 21
        Me.pbMain.TabStop = False
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
        Me.btnExit.TabIndex = 19
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
        Me.btnMinimize.TabIndex = 18
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
        Me.btnInfo.TabIndex = 17
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
        Me.btnReturn.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Return")
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'pbBar
        '
        Me.pbBar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbBar.Location = New System.Drawing.Point(0, 0)
        Me.pbBar.Name = "pbBar"
        Me.pbBar.Size = New System.Drawing.Size(1064, 90)
        Me.pbBar.TabIndex = 15
        Me.pbBar.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.llblGoogleMaps)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbMain)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pbBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Landmarks"
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents pbBar As PictureBox
    Friend WithEvents pbMain As PictureBox
    Friend WithEvents btnControl As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents llblGoogleMaps As LinkLabel
    Friend WithEvents tmr1 As Timer
End Class
