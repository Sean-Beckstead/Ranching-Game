Public Class player
    Private money As Integer
    Private bag(9) As String

    Private years As String

    Property _years() As String
        Get
            Return years
        End Get
        Set(ByVal value As String)
            years = value
        End Set
    End Property

    Property Mymoney() As Integer
        Get
            Return money
        End Get
        Set(ByVal value As Integer)
            money = value
        End Set
    End Property

    Public Sub MeMoveW(ByVal I As PictureBox)
        Static Dim FrameW As Integer = 0
        FrameW += 1

        Select Case FrameW
            Case 1 : I.Image = My.Resources.farmer_W0
            Case 2 : I.Image = My.Resources.farmer_W1
            Case 3 : I.Image = My.Resources.farmer_W2
            Case 4 : I.Image = My.Resources.farmer_W3
            Case 5 : I.Image = My.Resources.farmer_W4
            Case 6 : I.Image = My.Resources.farmer_W5
            Case 7 : I.Image = My.Resources.farmer_W6
            Case 8 : I.Image = My.Resources.farmer_W7
                FrameW = 0
        End Select
    End Sub

    Public Sub MeMoveN(ByVal I As PictureBox)
        Static Dim FrameN As Integer = 1
        FrameN += 1

        Select Case FrameN
            Case 1 : I.Image = My.Resources.Farmer_N0
            Case 2 : I.Image = My.Resources.Farmer_N1
            Case 3 : I.Image = My.Resources.Farmer_N2
            Case 4 : I.Image = My.Resources.Farmer_N3
            Case 5 : I.Image = My.Resources.Farmer_N4
            Case 6 : I.Image = My.Resources.Farmer_N5
            Case 7 : I.Image = My.Resources.Farmer_N6
            Case 8 : I.Image = My.Resources.Farmer_N7
                FrameN = 0
        End Select
    End Sub

    Public Sub MeMoveE(ByVal I As PictureBox)
        Static Dim FrameE As Integer = 1
        FrameE += 1

        Select Case FrameE
            Case 1 : I.Image = My.Resources.Farmer_E0
            Case 2 : I.Image = My.Resources.Farmer_E1
            Case 3 : I.Image = My.Resources.Farmer_E2
            Case 4 : I.Image = My.Resources.Farmer_E3
            Case 5 : I.Image = My.Resources.Farmer_E4
            Case 6 : I.Image = My.Resources.Farmer_E5
            Case 7 : I.Image = My.Resources.Farmer_E6
            Case 8 : I.Image = My.Resources.Farmer_E7
                FrameE = 0
        End Select
    End Sub

    Public Sub MeMoveS(ByVal I As PictureBox)
        Static Dim FrameS As Integer = 1
        FrameS += 1

        Select Case FrameS
            Case 1 : I.Image = My.Resources.Farmer_S0
            Case 2 : I.Image = My.Resources.Farmer_S1
            Case 3 : I.Image = My.Resources.Farmer_S2
            Case 4 : I.Image = My.Resources.Farmer_S3
            Case 5 : I.Image = My.Resources.Farmer_S4
            Case 6 : I.Image = My.Resources.Farmer_S5
            Case 7 : I.Image = My.Resources.Farmer_S6
            Case 8 : I.Image = My.Resources.Farmer_S7
                FrameS = 0
        End Select
    End Sub

    Sub New()
        money = 1000
    End Sub
End Class
