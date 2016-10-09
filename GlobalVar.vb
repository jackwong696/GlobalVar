Public Class GlobalVar

    Dim _varList As List(Of Object)

    Sub New()
        _varList = New List(Of Object)
    End Sub

    Public Property VarList() As List(Of Object)
        Get
            Return _varList
        End Get
        Set(ByVal value As List(Of Object))
            _varList = value
        End Set
    End Property

End Class
