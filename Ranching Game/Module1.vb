Module Module1
    'All the cows
    Public cowHerd(8) As Cow


    Public Sub CreateCows()
        For i As Integer = 0 To cowHerd.Length - 1
            cowHerd(i) = New Cow(False)

        Next
    End Sub

    Public cow1 As New Cow(False)
    Public cow2 As New Cow(False)
    Public cow3 As New Cow(False)
    Public cow4 As New Cow(False)
    Public cow5 As New Cow(False)
    Public cow6 As New Cow(False)
    Public cow7 As New Cow(False)
    Public cow8 As New Cow(False)

    'pictureboxes that display the cows
    Public PbxHerd(8) As PictureBox

    'The player
    Public character As New player

End Module
