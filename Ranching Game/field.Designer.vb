<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Field
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
        Me.pbxHouse = New System.Windows.Forms.PictureBox
        Me.pbxBarn = New System.Windows.Forms.PictureBox
        Me.PbxCoop = New System.Windows.Forms.PictureBox
        Me.lblmoney = New System.Windows.Forms.Label
        Me.pbxFarmer = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.pbxHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBarn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCoop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxHouse
        '
        Me.pbxHouse.BackColor = System.Drawing.SystemColors.ControlText
        Me.pbxHouse.Location = New System.Drawing.Point(31, 12)
        Me.pbxHouse.Name = "pbxHouse"
        Me.pbxHouse.Size = New System.Drawing.Size(189, 75)
        Me.pbxHouse.TabIndex = 1
        Me.pbxHouse.TabStop = False
        '
        'pbxBarn
        '
        Me.pbxBarn.BackColor = System.Drawing.Color.SaddleBrown
        Me.pbxBarn.Location = New System.Drawing.Point(610, 12)
        Me.pbxBarn.Name = "pbxBarn"
        Me.pbxBarn.Size = New System.Drawing.Size(90, 111)
        Me.pbxBarn.TabIndex = 2
        Me.pbxBarn.TabStop = False
        '
        'PbxCoop
        '
        Me.PbxCoop.BackColor = System.Drawing.Color.Yellow
        Me.PbxCoop.Location = New System.Drawing.Point(471, 12)
        Me.PbxCoop.Name = "PbxCoop"
        Me.PbxCoop.Size = New System.Drawing.Size(90, 111)
        Me.PbxCoop.TabIndex = 3
        Me.PbxCoop.TabStop = False
        '
        'lblmoney
        '
        Me.lblmoney.AutoSize = True
        Me.lblmoney.Location = New System.Drawing.Point(162, 45)
        Me.lblmoney.Name = "lblmoney"
        Me.lblmoney.Size = New System.Drawing.Size(39, 13)
        Me.lblmoney.TabIndex = 4
        Me.lblmoney.Text = "Label1"
        '
        'pbxFarmer
        '
        Me.pbxFarmer.BackColor = System.Drawing.Color.Transparent
        Me.pbxFarmer.Image = Global.Ranching_Game.My.Resources.Resources.Farmer_S2
        Me.pbxFarmer.Location = New System.Drawing.Point(285, 285)
        Me.pbxFarmer.Name = "pbxFarmer"
        Me.pbxFarmer.Size = New System.Drawing.Size(34, 67)
        Me.pbxFarmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxFarmer.TabIndex = 5
        Me.pbxFarmer.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "House"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(495, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Coop"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(637, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Barn"
        '
        'Field
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ranching_Game.My.Resources.Resources.Grass
        Me.ClientSize = New System.Drawing.Size(712, 610)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblmoney)
        Me.Controls.Add(Me.PbxCoop)
        Me.Controls.Add(Me.pbxBarn)
        Me.Controls.Add(Me.pbxHouse)
        Me.Controls.Add(Me.pbxFarmer)
        Me.Name = "Field"
        Me.Text = "Field"
        CType(Me.pbxHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBarn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCoop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxHouse As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBarn As System.Windows.Forms.PictureBox
    Friend WithEvents PbxCoop As System.Windows.Forms.PictureBox
    Friend WithEvents lblmoney As System.Windows.Forms.Label
    Friend WithEvents pbxFarmer As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
