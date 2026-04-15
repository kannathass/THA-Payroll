Public Class ClsFormulaExpression

    Public Class Eval
        ' simulate basic evaluation of arithmetic expression 

        Public Sub New()
        End Sub

        Public Shared Function VerifyAllowed(ByVal e As String) As Boolean
            Dim allowed As String = "0123456789+-*/().,"
            For i As Integer = 0 To e.Length - 1
                If allowed.IndexOf("" + e(i)) = -1 Then
                    Return False
                End If
            Next
            Return True
        End Function

        Public Shared Function Evaluate(ByVal e As String) As String
            If e.Length = 0 Then
                Return "String length is zero"
            End If
            If Not VerifyAllowed(e) Then
                Return "The string contains not allowed characters"
            End If
            If e(0) = "-"c Then
                e = "0" + e
            End If
            Dim res As String = ""
            Try
                res = Calculate(e).ToString()
            Catch
                Return "The call caused an exception"
            End Try
            Return res
        End Function

        Public Shared Function Calculate(ByVal e As String) As Double
            'e = e.Replace(".", ",")
            If e.IndexOf("(") <> -1 Then
                Dim a As Integer = e.LastIndexOf("(")
                Dim b As Integer = e.IndexOf(")", a)
                Dim middle As Double = Calculate(e.Substring(a + 1, b - a - 1))
                Return Calculate(e.Substring(0, a) + middle.ToString() + e.Substring(b + 1))
            End If
            Dim result As Double = 0
            Dim plus As String() = e.Split("+"c)
            If plus.Length > 1 Then
                ' there were some + 
                result = Calculate(plus(0))
                For i As Integer = 1 To plus.Length - 1
                    result += Calculate(plus(i))
                Next

                Return result
            Else
                ' no + 
                Dim minus As String() = plus(0).Split("-"c)
                If minus.Length > 1 Then
                    ' there were some - 
                    result = Calculate(minus(0))
                    For i As Integer = 1 To minus.Length - 1
                        result -= Calculate(minus(i))
                    Next

                    Return result
                Else
                    ' no - 
                    Dim mult As String() = minus(0).Split("*"c)
                    If mult.Length > 1 Then
                        ' there were some * 
                        result = Calculate(mult(0))
                        For i As Integer = 1 To mult.Length - 1
                            result *= Calculate(mult(i))
                        Next

                        Return result
                    Else
                        ' no * 
                        Dim div As String() = mult(0).Split("/"c)
                        If div.Length > 1 Then
                            ' there were some / 
                            result = Calculate(div(0))
                            For i As Integer = 1 To div.Length - 1
                                result /= Calculate(div(i))
                            Next

                            Return result
                        Else
                            ' no / 
                            Return Double.Parse(e)
                        End If
                    End If
                End If
            End If
        End Function
    End Class

End Class
