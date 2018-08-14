<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Town
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
        Me.pbxMarket = New System.Windows.Forms.PictureBox
        Me.LblMoney = New System.Windows.Forms.Label
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMarket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxFarmer
        '
        Me.pbxFarmer.Image = Global.Ranching_Game.My.Resources.Resources.farmer
        Me.pbxFarmer.Location = New System.Drawing.Point(588, 213)
        Me.pbxFarmer.Name = "pbxFarmer"
        Me.pbxFarmer.Size = New System.Drawing.Size(33, 60)
        Me.pbxFarmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxFarmer.TabIndex = 1
        Me.pbxFarmer.TabStop = False
        '
        'pbxMarket
        '
        Me.pbxMarket.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbxMarket.Location = New System.Drawing.Point(180, 12)
        Me.pbxMarket.Name = "pbxMarket"
        Me.pbxMarket.Size = New System.Drawing.Size(99, 55)
        Me.pbxMarket.TabIndex = 2
        Me.pbxMarket.TabStop = False
        '
        'LblMoney
        '
        Me.LblMoney.AutoSize = True
        Me.LblMoney.Location = New System.Drawing.Point(535, 471)
        Me.LblMoney.Name = "LblMoney"
        Me.LblMoney.Size = New System.Drawing.Size(39, 13)
        Me.LblMoney.TabIndex = 3
        Me.LblMoney.Text = "Label1"
        '
        'Town
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 518)
        Me.Controls.Add(Me.LblMoney)
        Me.Controls.Add(Me.pbxMarket)
        Me.Controls.Add(Me.pbxFarmer)
        Me.Name = "Town"
        Me.Text = "Town"
        CType(Me.pbxFarmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMarket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxFarmer As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMarket As System.Windows.Forms.PictureBox
    Friend WithEvents LblMoney As System.Windows.Forms.Label
End Class
