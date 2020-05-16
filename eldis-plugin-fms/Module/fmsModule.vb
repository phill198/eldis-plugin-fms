Imports MySql.Data.MySqlClient

Module fmsModule
    Dim stringConn As String
    Dim stringCmd As String
    Dim myConn As MySqlConnection
    Dim myCmd As MySqlCommand
    Dim myReader As MySqlDataReader
    Dim READER As MySqlDataReader
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public Veh As String
    Function SetStatus(ByVal status As Int64, ByVal statustext As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = (“server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        MysqlConn.Open()
        Dim Query As String
        Query = "UPDATE sis_vehicles SET status = '" & status & "', text = '" & statustext & "'  WHERE name = '" & Veh & "'"
        fmsgeber.fms_label.ForeColor = Color.White
        My.Computer.Audio.Play(My.Resources.fms_geber_click, AudioPlayMode.Background)
        COMMAND = New MySqlCommand(Query, MysqlConn)

        READER = COMMAND.ExecuteReader
        READER.Close()
        MysqlConn.Close()
    End Function

    Function CurrentVehInit(ByVal currentVeh As String)
        Veh = currentVeh
    End Function

    Function StatusLocked(ByVal status As Int64, ByVal reason As String)
        MsgBox("Status " & status & " wurde gesperrt. Grund: " & reason, MsgBoxStyle.Information)
    End Function
End Module
