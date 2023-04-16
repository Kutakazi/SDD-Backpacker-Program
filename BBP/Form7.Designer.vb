<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pbBar = New System.Windows.Forms.PictureBox()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
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
        Me.btnMinimize.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.BackgroundImage = Global.BBP.My.Resources.Resources.Close
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExit.Location = New System.Drawing.Point(982, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 47)
        Me.btnExit.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit")
        Me.btnExit.UseVisualStyleBackColor = False
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
        Me.btnReturn.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Return")
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnInfo.BackgroundImage = Global.BBP.My.Resources.Resources.Info_Grey
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnInfo.Enabled = False
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInfo.Location = New System.Drawing.Point(88, 10)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(70, 70)
        Me.btnInfo.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnInfo, "Infomation")
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'pbMain
        '
        Me.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMain.Location = New System.Drawing.Point(0, 90)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(1064, 591)
        Me.pbMain.TabIndex = 0
        Me.pbMain.TabStop = False
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
        Me.lbl1.TabIndex = 14
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
        Me.pbBar.TabIndex = 11
        Me.pbBar.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pbBar)
        Me.Controls.Add(Me.pbMain)
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "Form7"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Map of Country"
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pbMain As PictureBox
    Friend WithEvents btnMinimize As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents pbBar As PictureBox
    Friend WithEvents btnInfo As Button
End Class
