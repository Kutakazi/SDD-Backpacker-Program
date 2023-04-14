<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.btnChina = New System.Windows.Forms.Button()
        Me.btnRussia = New System.Windows.Forms.Button()
        Me.btnFinland = New System.Windows.Forms.Button()
        Me.btnAustralia = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbBar = New System.Windows.Forms.PictureBox()
        Me.pbBottomBar = New System.Windows.Forms.PictureBox()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBottomBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tt
        '
        Me.tt.AutomaticDelay = 250
        '
        'lbl1
        '
        resources.ApplyResources(Me.lbl1, "lbl1")
        Me.lbl1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl1.Name = "lbl1"
        '
        'pbMain
        '
        Me.pbMain.BackgroundImage = Global.BBP.My.Resources.Resources.world
        resources.ApplyResources(Me.pbMain, "pbMain")
        Me.pbMain.Name = "pbMain"
        Me.pbMain.TabStop = False
        '
        'btnChina
        '
        Me.btnChina.BackgroundImage = Global.BBP.My.Resources.Resources.China
        resources.ApplyResources(Me.btnChina, "btnChina")
        Me.btnChina.FlatAppearance.BorderSize = 3
        Me.btnChina.Name = "btnChina"
        Me.tt.SetToolTip(Me.btnChina, resources.GetString("btnChina.ToolTip"))
        Me.btnChina.UseVisualStyleBackColor = True
        '
        'btnRussia
        '
        Me.btnRussia.BackgroundImage = Global.BBP.My.Resources.Resources.Russia
        resources.ApplyResources(Me.btnRussia, "btnRussia")
        Me.btnRussia.FlatAppearance.BorderSize = 3
        Me.btnRussia.Name = "btnRussia"
        Me.tt.SetToolTip(Me.btnRussia, resources.GetString("btnRussia.ToolTip"))
        Me.btnRussia.UseVisualStyleBackColor = True
        '
        'btnFinland
        '
        Me.btnFinland.BackgroundImage = Global.BBP.My.Resources.Resources.Finland
        resources.ApplyResources(Me.btnFinland, "btnFinland")
        Me.btnFinland.FlatAppearance.BorderSize = 3
        Me.btnFinland.Name = "btnFinland"
        Me.tt.SetToolTip(Me.btnFinland, resources.GetString("btnFinland.ToolTip"))
        Me.btnFinland.UseVisualStyleBackColor = True
        '
        'btnAustralia
        '
        Me.btnAustralia.BackgroundImage = Global.BBP.My.Resources.Resources.Aus
        resources.ApplyResources(Me.btnAustralia, "btnAustralia")
        Me.btnAustralia.FlatAppearance.BorderSize = 3
        Me.btnAustralia.Name = "btnAustralia"
        Me.tt.SetToolTip(Me.btnAustralia, resources.GetString("btnAustralia.ToolTip"))
        Me.btnAustralia.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnReturn.BackgroundImage = Global.BBP.My.Resources.Resources.Back_Grey__2_
        resources.ApplyResources(Me.btnReturn, "btnReturn")
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnReturn.Name = "btnReturn"
        Me.tt.SetToolTip(Me.btnReturn, resources.GetString("btnReturn.ToolTip"))
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnInfo.BackgroundImage = Global.BBP.My.Resources.Resources.Info
        resources.ApplyResources(Me.btnInfo, "btnInfo")
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnInfo.Name = "btnInfo"
        Me.tt.SetToolTip(Me.btnInfo, resources.GetString("btnInfo.ToolTip"))
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMinimize.BackgroundImage = Global.BBP.My.Resources.Resources.Minimize
        resources.ApplyResources(Me.btnMinimize, "btnMinimize")
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnMinimize.Name = "btnMinimize"
        Me.tt.SetToolTip(Me.btnMinimize, resources.GetString("btnMinimize.ToolTip"))
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.BackgroundImage = Global.BBP.My.Resources.Resources.Close
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnExit.Name = "btnExit"
        Me.tt.SetToolTip(Me.btnExit, resources.GetString("btnExit.ToolTip"))
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pbBar
        '
        Me.pbBar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.pbBar, "pbBar")
        Me.pbBar.Name = "pbBar"
        Me.pbBar.TabStop = False
        '
        'pbBottomBar
        '
        Me.pbBottomBar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbBottomBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.pbBottomBar, "pbBottomBar")
        Me.pbBottomBar.Name = "pbBottomBar"
        Me.pbBottomBar.TabStop = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ControlBox = False
        Me.Controls.Add(Me.pbMain)
        Me.Controls.Add(Me.btnChina)
        Me.Controls.Add(Me.btnRussia)
        Me.Controls.Add(Me.btnFinland)
        Me.Controls.Add(Me.btnAustralia)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbBar)
        Me.Controls.Add(Me.pbBottomBar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBottomBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents tt As ToolTip
    Friend WithEvents pbBar As PictureBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnAustralia As Button
    Friend WithEvents pbBottomBar As PictureBox
    Friend WithEvents btnFinland As Button
    Friend WithEvents btnRussia As Button
    Friend WithEvents btnChina As Button
    Friend WithEvents pbMain As PictureBox
End Class
