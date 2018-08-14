Public Class House
    Dim dayofweek(7) As String
    Dim months(4) As String
    Dim MonthDate As Integer = 1
    Dim J As Integer = 1
    Dim I As Integer = 1


    Private Sub House_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dayofweek(1) = "Sunday"
        dayofweek(2) = "Monday"
        dayofweek(3) = "Tuesday"
        dayofweek(4) = "Wednesday"
        dayofweek(5) = "Thursday"
        dayofweek(6) = "Friday"
        dayofweek(7) = "Saturday"

        months(1) = "Spring"
        months(2) = "Summer"
        months(3) = "Fall"
        months(4) = "Winter"

    End Sub

    Private Sub House_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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
                If pbxFarmer.Left <= PbxBed.Right And pbxFarmer.Top >= PbxBed.Top And pbxFarmer.Bottom <= PbxBed.Bottom Then
                    PlayerSleep()
                End If

                If pbxFarmer.Left >= PbxCalender.Left And pbxFarmer.Top >= PbxCalender.Bottom And pbxFarmer.Right <= PbxCalender.Right Then
                    Calender()
                End If

        End Select

        If pbxFarmer.Bottom >= PbxDoor.Top Then
            Me.Hide()
            Field.Show()
        End If
    End Sub

    Sub PlayerSleep()
        If I >= 7 Then I = 0
        If MonthDate >= 30 Then
            MonthDate = 1
            months(J) += 1
        End If
        MonthDate += 1
        I += 1
        Call Barn.resetcows()
        MsgBox("You rest for the night.")


    End Sub

    Sub Calender()
        MsgBox("Today is " & dayofweek(I) & " the " & MonthDate & " of " & months(J))
    End Sub

End Class