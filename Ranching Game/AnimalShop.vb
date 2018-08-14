Public Class AnimalShop
    Dim countCows As Integer = 0

    Private Sub AnimalShop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CreateCows()

        PbxHerd(1) = Barn.pbxanimal1
        PbxHerd(2) = Barn.pbxanimal2
        PbxHerd(3) = Barn.pbxanimal3
        PbxHerd(4) = Barn.pbxanimal4
        PbxHerd(5) = Barn.pbxanimal5
        PbxHerd(6) = Barn.pbxanimal6
        PbxHerd(7) = Barn.pbxanimal7
        PbxHerd(8) = Barn.pbxanimal8

        Label1.Text = character.Mymoney
    End Sub

    Private Sub btnCow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCow.Click
        Static Dim I As Integer = 1
        Do While I < 8
            If PbxHerd(I).Visible = False Then
                If character.Mymoney >= 100 Then
                    character.Mymoney -= 100
                    MsgBox("You bought a cow.")
                    If I <= 4 Then PbxHerd(I).Image = My.Resources.Cow_N
                    If I >= 5 Then PbxHerd(I).Image = My.Resources.Cow_S
                    Me.Hide()
                    Label1.Text = character.Mymoney
                    PbxHerd(I).Visible = True
                    I += 1
                    If I >= cowHerd.Length Then I = 1
                Else
                    MsgBox("Your Broke.")
                    I += 1
                    If I >= cowHerd.Length - 1 Then I = 1
                    Exit Sub
                End If
            Else
                MsgBox("You have no room.")
                I += 1
                If I >= cowHerd.Length - 1 Then I = 1
                Exit Sub
            End If
        Loop
        If I >= 8 Then MsgBox("out of room")



    End Sub
End Class