<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Coop
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
        Me.PbxDoor = New System.Windows.Forms.PictureBox
        Me.pbxFarmer = New System.Windows.Forms.PictureBox
        CType(Me.PbxDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbxDoor
        '
        Me.PbxDoor.BackColor = System.Drawing.Color.Black
        Me.PbxDoor.Location = New System.Drawing.Point(104, 211)
        Me.PbxDoor.Name = "PbxDoor"
        Me.PbxDoor.Size = New System.Drawing.Size(33, 15)
        Me.PbxDoor.TabIndex = 4
        Me.PbxDoor.TabStop = False
        '
        'pbxFarmer
        '
        Me.pbxFarmer.Image = Global.Ranching_Game.My.Resources.Resources.farmer
        Me.pbxFarmer.Location = New System.Drawing.Point(117, 175)
        Me.pbxFarmer.Name = "pbxFarmer"
        Me.pbxFarmer.Size = New System.Drawing.Size(20, 30)
        Me.pbxFarmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxFarmer.TabIndex = 5
        Me.pbxFarmer.TabStop = False
        '
        'Coop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ranching_Game.My.Resources.Resources.coop
        Me.ClientSize = New System.Drawing.Size(240, 225)
        Me.Controls.Add(Me.pbxFarmer)
        Me.Controls.Add(Me.PbxDoor)
        Me.Name = "Coop"
        Me.Text = "Coop"
        CType(Me.PbxDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PbxDoor As System.Windows.Forms.PictureBox
    Friend WithEvents pbxFarmer As System.Windows.Forms.PictureBox
End Class
