Imports System.Math

Public Class clsValidation

#Region "Declaration"

#End Region

#Region "Function"

    Public Function FunRoundValue(ByVal getValue As Double) As Double
        Try
            Return Math.Round(getValue, 2)
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        End Try
    End Function
    Public Function FunRoundValueofDecimal(ByVal getValue As Double) As Double
        Try
            Return Math.Round(getValue)
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        End Try
    End Function

    Public Function FunAllowNumeric(ByVal KeyAscii As Integer) As Boolean
        Try
            Dim IsNumber As Boolean = True
            Select Case KeyAscii
                Case Asc("A") To Asc("z"), 32 To 36, 41 To 45, 47, 58 To 64, 124 To 258 ' invalid charecters
                    ' MsgBox("Enter Only Numbers.")
                    KeyAscii = 0
                    IsNumber = False
            End Select
            Return IsNumber
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        End Try
    End Function

#End Region

End Class
