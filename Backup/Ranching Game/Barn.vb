Public Class Barn
 

    Private Sub Barn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim move As Char
        move = e.KeyChar


        Select Case move
            Case "w"
                pbxFarmer.Top -= 5
                character.MeMoveN(pbxFarmer)
            Case "s"
                pbxFarmer.Top += 5
                character.MeMoveS(pbxFarmer)
                If pbxFarmer.Left <= PbxDoor.Right And pbxFarmer.Top >= PbxDoor.Top And pbxFarmer.Bottom <= PbxDoor.Bottom Then
                    Me.Hide()
                    Field.Show()
                End If
            Case "d"
                pbxFarmer.Left += 5
                character.MeMoveE(pbxFarmer)
            Case "a"
                pbxFarmer.Left -= 5
                character.MeMoveW(pbxFarmer)
            Case " "
                For i As Integer = 1 To cowHerd.Length - 1
                    If pbxFarmer.Left >= PbxHerd(i).Left - 5 And pbxFarmer.Right <= PbxHerd(i).Right + 5 And pbxFarmer.Top <= PbxHerd(i).Bottom And cowHerd(i)._Milked = False And PbxHerd(i).Visible = True Then
                        cowHerd(i)._Milked = True
                        character.Mymoney += 10
                        If cowHerd(i)._CowName = "" Then
                            cowHerd(i)._CowName = InputBox("What would you like to name it?")
                        End If
                        MsgBox("You milked " & cowHerd(i)._CowName)
                    End If
                Next
        End Select
    End Sub

    Sub resetcows()
        cow1._Milked = False
        cow2._Milked = False
        cow3._Milked = False
        cow4._Milked = False
    End Sub
End Class