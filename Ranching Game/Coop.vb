Public Class Coop

    Private Sub Coop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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
        End Select

        If pbxFarmer.Bottom >= PbxDoor.Top And pbxFarmer.Left >= PbxDoor.Left And pbxFarmer.Right <= PbxDoor.Right Then
            Me.Hide()
            Field.Show()
        End If
    End Sub
End Class