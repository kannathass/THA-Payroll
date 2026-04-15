
Public Class ClassFilter
    Public Value As Object
    Public Description As String

    Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
        Value = NewValue
        Description = NewDescription
    End Sub

    Public Overrides Function ToString() As String
        Return Description
    End Function
    Public ReadOnly Property getDesc() As String
        Get
            Return Description
        End Get
    End Property

    Public ReadOnly Property getId() As Object
        Get
            Return Value
        End Get
    End Property

End Class
