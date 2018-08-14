<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class House
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
        Me.pbxFarmer = New System.Windows.Forms.PictureBox
        Me.PbxDoor = New System.Windows.Forms.PictureBox
        Me.PbxBed = New System.Windows.Forms.PictureBox
        Me.PbxCalender = New System.Windows.Forms.PictureBox
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxBed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCalender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxFarmer
        '
        Me.pbxFarmer.BackColor = System.Drawing.Color.Transparent
        Me.pbxFarmer.Image = Global.Ranching_Game.My.Resources.Resources.farmer
        Me.pbxFarmer.Location = New System.Drawing.Point(121, 113)
        Me.pbxFarmer.Name = "pbxFarmer"
        Me.pbxFarmer.Size = New System.Drawing.Size(33, 60)
        Me.pbxFarmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxFarmer.TabIndex = 1
        Me.pbxFarmer.TabStop = False
        '
        'PbxDoor
        '
        Me.PbxDoor.BackColor = System.Drawing.Color.Black
        Me.PbxDoor.Location = New System.Drawing.Point(94, 247)
        Me.PbxDoor.Name = "PbxDoor"
        Me.PbxDoor.Size = New System.Drawing.Size(83, 22)
        Me.PbxDoor.TabIndex = 2
        Me.PbxDoor.TabStop = False
        '
        'PbxBed
        '
        Me.PbxBed.BackColor = System.Drawing.Color.White
        Me.PbxBed.Location = New System.Drawing.Point(12, 12)
        Me.PbxBed.Name = "PbxBed"
        Me.PbxBed.Size = New System.Drawing.Size(65, 113)
        Me.PbxBed.TabIndex = 3
        Me.PbxBed.TabStop = False
        '
        'PbxCalender
        '
        Me.PbxCalender.BackColor = System.Drawing.Color.Red
        Me.PbxCalender.Location = New System.Drawing.Point(196, 2)
        Me.PbxCalender.Name = "PbxCalender"
        Me.PbxCalender.Size = New System.Drawing.Size(84, 27)
        Me.PbxCalender.TabIndex = 4
        Me.PbxCalender.TabStop = False
        '
        'House
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Ranching_Game.My.Resources.Resources.Floor
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.PbxCalender)
        Me.Controls.Add(Me.PbxBed)
        Me.Controls.Add(Me.PbxDoor)
        Me.Controls.Add(Me.pbxFarmer)
        Me.Name = "House"
        Me.Text = "House"
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxBed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCalender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxFarmer As System.Windows.Forms.PictureBox
    Friend WithEvents PbxDoor As System.Windows.Forms.PictureBox
    Friend WithEvents PbxBed As System.Windows.Forms.PictureBox
    Friend WithEvents PbxCalender As System.Windows.Forms.PictureBox
End Class
