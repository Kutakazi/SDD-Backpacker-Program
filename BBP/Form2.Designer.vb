<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions1 = New System.Windows.Forms.Label()
        Me.lblInstructions2 = New System.Windows.Forms.Label()
        Me.lblInstructions3 = New System.Windows.Forms.Label()
        Me.lblInstructions4 = New System.Windows.Forms.Label()
        Me.lblInstructions5 = New System.Windows.Forms.Label()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.COPY = New System.Windows.Forms.Label()
        Me.llblGithub = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pbBar = New System.Windows.Forms.PictureBox()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold)
        Me.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl1.Location = New System.Drawing.Point(239, 20)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(228, 50)
        Me.lbl1.TabIndex = 10
        Me.lbl1.Text = "How To Use"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 93)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(255, 45)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "(Form Number)"
        '
        'lblInstructions1
        '
        Me.lblInstructions1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions1.Location = New System.Drawing.Point(15, 148)
        Me.lblInstructions1.Name = "lblInstructions1"
        Me.lblInstructions1.Size = New System.Drawing.Size(677, 95)
        Me.lblInstructions1.TabIndex = 13
        Me.lblInstructions1.Text = "(Instructions 1)"
        '
        'lblInstructions2
        '
        Me.lblInstructions2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions2.Location = New System.Drawing.Point(15, 189)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(677, 82)
        Me.lblInstructions2.TabIndex = 14
        Me.lblInstructions2.Text = "(Instructions 2)"
        '
        'lblInstructions3
        '
        Me.lblInstructions3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions3.Location = New System.Drawing.Point(15, 230)
        Me.lblInstructions3.Name = "lblInstructions3"
        Me.lblInstructions3.Size = New System.Drawing.Size(677, 73)
        Me.lblInstructions3.TabIndex = 15
        Me.lblInstructions3.Text = "(Instructions 3)"
        '
        'lblInstructions4
        '
        Me.lblInstructions4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions4.Location = New System.Drawing.Point(15, 271)
        Me.lblInstructions4.Name = "lblInstructions4"
        Me.lblInstructions4.Size = New System.Drawing.Size(677, 78)
        Me.lblInstructions4.TabIndex = 16
        Me.lblInstructions4.Text = "(Instructions 4)"
        '
        'lblInstructions5
        '
        Me.lblInstructions5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions5.Location = New System.Drawing.Point(15, 312)
        Me.lblInstructions5.Name = "lblInstructions5"
        Me.lblInstructions5.Size = New System.Drawing.Size(677, 67)
        Me.lblInstructions5.TabIndex = 17
        Me.lblInstructions5.Text = "(Instructions 5)"
        '
        'lblNotice
        '
        Me.lblNotice.AutoSize = True
        Me.lblNotice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.Location = New System.Drawing.Point(46, 407)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(619, 21)
        Me.lblNotice.TabIndex = 18
        Me.lblNotice.Text = "THIS PROGRAM IS FOR THE ORIGINAL RECIPIENT/S AND NOT FOR DISTRIBUTION"
        '
        'COPY
        '
        Me.COPY.Location = New System.Drawing.Point(11, 438)
        Me.COPY.Name = "COPY"
        Me.COPY.Size = New System.Drawing.Size(683, 241)
        Me.COPY.TabIndex = 20
        Me.COPY.Text = resources.GetString("COPY.Text")
        '
        'llblGithub
        '
        Me.llblGithub.AutoSize = True
        Me.llblGithub.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGithub.Location = New System.Drawing.Point(300, 376)
        Me.llblGithub.Name = "llblGithub"
        Me.llblGithub.Size = New System.Drawing.Size(105, 21)
        Me.llblGithub.TabIndex = 19
        Me.llblGithub.TabStop = True
        Me.llblGithub.Text = "Source Code"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
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
        Me.btnInfo.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btnInfo, "Infomation")
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMinimize.BackgroundImage = Global.BBP.My.Resources.Resources.Minimize
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMinimize.Location = New System.Drawing.Point(546, 10)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(70, 70)
        Me.btnMinimize.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.BackgroundImage = Global.BBP.My.Resources.Resources.Close
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExit.Location = New System.Drawing.Point(622, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 70)
        Me.btnExit.TabIndex = 8
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
        Me.btnReturn.TabIndex = 7
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
        Me.pbBar.Size = New System.Drawing.Size(705, 90)
        Me.pbBar.TabIndex = 2
        Me.pbBar.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInstructions5)
        Me.Controls.Add(Me.lblInstructions4)
        Me.Controls.Add(Me.COPY)
        Me.Controls.Add(Me.llblGithub)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.lblInstructions3)
        Me.Controls.Add(Me.lblInstructions2)
        Me.Controls.Add(Me.lblInstructions1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pbBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(720, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 720)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Information"
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbBar As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions1 As Label
    Friend WithEvents lblInstructions2 As Label
    Friend WithEvents lblInstructions3 As Label
    Friend WithEvents lblInstructions4 As Label
    Friend WithEvents lblInstructions5 As Label
    Friend WithEvents lblNotice As Label
    Friend WithEvents COPY As Label
    Friend WithEvents llblGithub As LinkLabel
    Friend WithEvents ToolTip1 As ToolTip
End Class
