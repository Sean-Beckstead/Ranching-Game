Public Class Field


    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim move As Char
        Static Dim FrameW As Integer = 0
        FrameW += 1
        move = e.KeyChar

        Select Case move
            Case "w"
                If pbxFarmer.Top <= 0 Then pbxFarmer.Top += 5
                pbxFarmer.Top -= 5
                character.MeMoveN(pbxFarmer)
            Case "s"
                If pbxFarmer.Bottom + 30 >= Me.Height Then pbxFarmer.Top -= 5
                pbxFarmer.Top += 5
                character.MeMoveS(pbxFarmer)
            Case "d"
                If pbxFarmer.Right + 15 >= Me.Width Then pbxFarmer.Left -= 5
                pbxFarmer.Left += 5
                character.MeMoveE(pbxFarmer)
            Case "a"
                pbxFarmer.Left -= 5
                character.MeMoveW(pbxFarmer)
        End Select

        If pbxFarmer.Top <= pbxHouse.Bottom And pbxFarmer.Right <= pbxHouse.Right And pbxFarmer.Left >= pbxHouse.Left Then
            Me.Hide()
            House.Show()
        End If

        If pbxFarmer.Right <= pbxBarn.Right And pbxFarmer.Top <= pbxBarn.Bottom And pbxFarmer.Left >= pbxBarn.Left Then
            Me.Hide()
            Barn.Show()
        End If

        If pbxFarmer.Left >= PbxCoop.Left And pbxFarmer.Top <= PbxCoop.Bottom And pbxFarmer.Right <= PbxCoop.Right Then
            Me.Hide()
            Coop.Show()
        End If

        If pbxFarmer.Left <= 0 Then
            Me.Hide()
            Town.Show()
            Town.pbxFarmer.Top = pbxFarmer.Top
            Town.pbxFarmer.Left = Town.Width - (pbxFarmer.Width + 1)
        End If

        lblmoney.Text = character.Mymoney
    End Sub
End Class
