Imports System.Data.SqlClient
Imports System.Data

Module Yarn_BundleConversion
    Dim datacon As New ConnectSql
    Dim datads As New DataSet
    Dim datatab As New DataTable
    Dim dataAdap As New SqlDataAdapter
    Dim YarnName As String
    Dim YarnValue As Double
    Dim YarnHank As Double
    Dim YarnKnots As Int32
    Dim YarnWeight As Double
    Dim YarnRun As Double

    Public Function Get_YarnDetails(ByVal YarnCName As String) As DataSet
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd.Connection = datacon.con
        datacon.cmd = New SqlCommand("select * from Yarn_Details where Yarn_CName='" & YarnCName & "'", datacon.con)
        dataAdap.SelectCommand = datacon.cmd
        dataAdap.Fill(datads, "Yarn_Details")
        Return datads
    End Function

    Public Function Calculate_Weight(ByVal YarnBundleWeight As Double, ByVal YarnKnots As Int32, ByVal OrigQuantity As Double)
        Dim TempYarnBundle As Int32
        Dim TempBundleWeight As Double
        Dim TempKnots As Int32
        Dim TempKnotWeight As Double
        Dim Result As Double
        TempYarnBundle = Math.Floor(OrigQuantity)
        TempBundleWeight = TempYarnBundle * YarnBundleWeight
        TempKnots = (OrigQuantity - TempYarnBundle) * 100
        TempKnotWeight = (YarnBundleWeight / YarnKnots) * TempKnots
        Result = TempBundleWeight + TempKnotWeight
        Return Result
    End Function
    Public Function Convert_Bundle(ByVal YarnKnots As Int32, ByVal OrigQuantity As Double)
        Dim TempBundle As Int32
        Dim TempKnots As Int32
        Dim TempKnotsBal As Int32
        Dim KnotsBal As Double
        Dim BundleBal As Integer
        Dim Result As Double
        TempBundle = Math.Floor(OrigQuantity)
        TempKnots = (OrigQuantity - TempBundle) * 100
        TempKnotsBal = Math.Floor(TempKnots / YarnKnots)
        BundleBal = TempBundle + TempKnotsBal
        KnotsBal = (TempKnots Mod YarnKnots) / 100
        Result = BundleBal + KnotsBal
        Return Result
    End Function
End Module
