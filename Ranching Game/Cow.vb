Public Class Cow
    Private Milked As Boolean
    Private CowName As String
    Private CowPic As Image


    Sub New(ByVal I As Boolean)
        Milked = I
        CowName = ""
    End Sub

    Property _CowName() As String
        Get
            Return CowName
        End Get
        Set(ByVal value As String)
            CowName = value
        End Set
    End Property

    Property _Milked() As Boolean
        Get
            Return Milked
        End Get
        Set(ByVal value As Boolean)
            Milked = value
        End Set
    End Property
End Class
