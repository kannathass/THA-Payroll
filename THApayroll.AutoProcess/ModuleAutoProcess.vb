Module ModuleAutoProcess
    Sub Main()
        Dim clsGeneral As New clsGeneral
        clsGeneral.WriteToFile("Run Completed")
        clsGeneral.GetBiometricAttendanceAndUpdate()
        'clsGeneral.FunProcessBiometricAttendance()
        'clsGeneral.SendEmail()
        clsGeneral.WriteToFile("Run Completed")
    End Sub

End Module
