<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblReligion = New System.Windows.Forms.Label()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.lblPopulation = New System.Windows.Forms.Label()
        Me.lblGeneralInfo = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnTranslator = New System.Windows.Forms.Button()
        Me.btnLandmarks = New System.Windows.Forms.Button()
        Me.btnConverter = New System.Windows.Forms.Button()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblFlag = New System.Windows.Forms.Label()
        Me.pbMap = New System.Windows.Forms.PictureBox()
        Me.pbFlag = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pbBar = New System.Windows.Forms.PictureBox()
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlag, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "Backpacker Program"
        '
        'lblCapital
        '
        Me.lblCapital.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapital.Location = New System.Drawing.Point(16, 391)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(777, 25)
        Me.lblCapital.TabIndex = 17
        Me.lblCapital.Text = "Capital City:"
        '
        'lblReligion
        '
        Me.lblReligion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReligion.Location = New System.Drawing.Point(16, 424)
        Me.lblReligion.Name = "lblReligion"
        Me.lblReligion.Size = New System.Drawing.Size(777, 25)
        Me.lblReligion.TabIndex = 16
        Me.lblReligion.Text = "Major Religion:"
        '
        'lblCurrency
        '
        Me.lblCurrency.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrency.Location = New System.Drawing.Point(16, 358)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(777, 25)
        Me.lblCurrency.TabIndex = 15
        Me.lblCurrency.Text = "Currency:"
        '
        'lblPopulation
        '
        Me.lblPopulation.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPopulation.Location = New System.Drawing.Point(16, 325)
        Me.lblPopulation.Name = "lblPopulation"
        Me.lblPopulation.Size = New System.Drawing.Size(777, 25)
        Me.lblPopulation.TabIndex = 14
        Me.lblPopulation.Text = "Population:"
        '
        'lblGeneralInfo
        '
        Me.lblGeneralInfo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralInfo.Location = New System.Drawing.Point(16, 140)
        Me.lblGeneralInfo.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.lblGeneralInfo.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.lblGeneralInfo.Name = "lblGeneralInfo"
        Me.lblGeneralInfo.Size = New System.Drawing.Size(1080, 720)
        Me.lblGeneralInfo.TabIndex = 13
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 90)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(162, 50)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Country"
        '
        'btnTranslator
        '
        Me.btnTranslator.AutoSize = True
        Me.btnTranslator.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnTranslator.FlatAppearance.BorderSize = 3
        Me.btnTranslator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTranslator.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTranslator.Location = New System.Drawing.Point(150, 475)
        Me.btnTranslator.Name = "btnTranslator"
        Me.btnTranslator.Size = New System.Drawing.Size(178, 46)
        Me.btnTranslator.TabIndex = 20
        Me.btnTranslator.Text = "Translator"
        Me.ToolTip1.SetToolTip(Me.btnTranslator, "Translator")
        Me.btnTranslator.UseVisualStyleBackColor = False
        '
        'btnLandmarks
        '
        Me.btnLandmarks.AutoSize = True
        Me.btnLandmarks.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLandmarks.FlatAppearance.BorderSize = 3
        Me.btnLandmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLandmarks.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLandmarks.Location = New System.Drawing.Point(150, 541)
        Me.btnLandmarks.Name = "btnLandmarks"
        Me.btnLandmarks.Size = New System.Drawing.Size(178, 46)
        Me.btnLandmarks.TabIndex = 22
        Me.btnLandmarks.Text = "Landmarks"
        Me.ToolTip1.SetToolTip(Me.btnLandmarks, "Landmarks")
        Me.btnLandmarks.UseVisualStyleBackColor = False
        '
        'btnConverter
        '
        Me.btnConverter.AutoSize = True
        Me.btnConverter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnConverter.FlatAppearance.BorderSize = 3
        Me.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConverter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConverter.Location = New System.Drawing.Point(150, 608)
        Me.btnConverter.Name = "btnConverter"
        Me.btnConverter.Size = New System.Drawing.Size(178, 46)
        Me.btnConverter.TabIndex = 23
        Me.btnConverter.Text = "Converters"
        Me.ToolTip1.SetToolTip(Me.btnConverter, "Converters")
        Me.btnConverter.UseVisualStyleBackColor = False
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMap.Location = New System.Drawing.Point(642, 317)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(234, 30)
        Me.lblMap.TabIndex = 25
        Me.lblMap.Text = "Map (Click To Expand)"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
        '
        'lblFlag
        '
        Me.lblFlag.AutoSize = True
        Me.lblFlag.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlag.Location = New System.Drawing.Point(892, 106)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(54, 30)
        Me.lblFlag.TabIndex = 26
        Me.lblFlag.Text = "Flag"
        '
        'pbMap
        '
        Me.pbMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbMap.Location = New System.Drawing.Point(479, 353)
        Me.pbMap.Name = "pbMap"
        Me.pbMap.Size = New System.Drawing.Size(560, 315)
        Me.pbMap.TabIndex = 21
        Me.pbMap.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbMap, "Map")
        '
        'pbFlag
        '
        Me.pbFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFlag.Location = New System.Drawing.Point(799, 147)
        Me.pbFlag.Name = "pbFlag"
        Me.pbFlag.Size = New System.Drawing.Size(240, 160)
        Me.pbFlag.TabIndex = 12
        Me.pbFlag.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbFlag, "Flag")
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
        Me.btnInfo.TabIndex = 10
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
        Me.btnMinimize.Location = New System.Drawing.Point(906, 10)
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
        Me.btnExit.Location = New System.Drawing.Point(982, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 70)
        Me.btnExit.TabIndex = 7
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
        Me.btnReturn.TabIndex = 6
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
        Me.pbBar.TabIndex = 2
        Me.pbBar.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFlag)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.btnConverter)
        Me.Controls.Add(Me.btnLandmarks)
        Me.Controls.Add(Me.pbMap)
        Me.Controls.Add(Me.btnTranslator)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.lblReligion)
        Me.Controls.Add(Me.lblCurrency)
        Me.Controls.Add(Me.lblPopulation)
        Me.Controls.Add(Me.lblGeneralInfo)
        Me.Controls.Add(Me.pbFlag)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pbBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Country"
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbBar As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCapital As Label
    Friend WithEvents lblReligion As Label
    Friend WithEvents lblCurrency As Label
    Friend WithEvents lblPopulation As Label
    Friend WithEvents lblGeneralInfo As Label
    Friend WithEvents pbFlag As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnTranslator As Button
    Friend WithEvents pbMap As PictureBox
    Friend WithEvents btnLandmarks As Button
    Friend WithEvents btnConverter As Button
    Friend WithEvents lblMap As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblFlag As Label
End Class
