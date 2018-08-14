Public Class Town

    Private Sub Town_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim move As Char
        move = e.KeyChar

        Select Case move
            Case "w"
                pbxFarmer.Top -= 5
                character.MeMoveN(pbxFarmer)
            Case "s"
                pbxFarmer.Top += 5
                character.MeMoveS(pbxFarmer)
            Case "d"
                pbxFarmer.Left += 5
                character.MeMoveE(pbxFarmer)
            Case "a"
                pbxFarmer.Left -= 5
                character.MeMoveW(pbxFarmer)
            Case " "
                If pbxFarmer.Left >= pbxMarket.Left And pbxFarmer.Right <= pbxMarket.Right And pbxFarmer.Top <= pbxMarket.Bottom Then
                    AnimalShop.Show()
                End If
        End Select

        If pbxFarmer.Top <= 0 Then pbxFarmer.Top += 5
        If pbxFarmer.Left <= 0 Then pbxFarmer.Left += 5
        If pbxFarmer.Bottom >= Me.Height Then pbxFarmer.Top -= 5

        If pbxFarmer.Right >= Me.Width Then
            Me.Hide()
            Field.Show()
            Field.pbxFarmer.Top = pbxFarmer.Top
            Field.pbxFarmer.Left = 1
        End If

        LblMoney.Text = character.Mymoney
    End Sub

    Private Sub Town_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pbxFarmer.Top = Field.pbxFarmer.Top

    End Sub

End Class