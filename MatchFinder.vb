Public Class BusinessClass
    Dim con As New OleDb.OleDbConnection
    Dim sql As String
    Public Function GetConnection() As String
        Dim StrConn As String = "true"
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kamva Cewu\Documents\2020Ticket.accdb"
        Catch ex As Exception
            StrConn = ex.Message.ToString
        End Try
        Return StrConn
    End Function
    Public Function GetAllTicketInfo() As DataSet
        Dim dsAllTicketInfo As New DataSet
        Dim daAllTicketInfo As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Ticket"
        daAllTicketInfo = New OleDb.OleDbDataAdapter(sql, con)
        daAllTicketInfo.Fill(dsAllTicketInfo, "dtAllTicketInfo")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsAllTicketInfo
    End Function
    Public Function GetAllMatchesById(ByVal IDMatch As String) As DataSet
        Dim dsAllMatchById As New DataSet
        Dim daAllMatchById As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT Ticket.MatchID, SeatCategory.SeatCategory, Ticket.OwnerName, SeatCategory.Price FROM Ticket INNER JOIN SeatCategory ON Ticket.SeatCategoryID=SeatCategory.SeatCategoryID WHERE Ticket.MatchID='" + IDMatch + "'"
        daAllMatchById = New OleDb.OleDbDataAdapter(sql, con)
        daAllMatchById.Fill(dsAllMatchById, "dtAllMatchByID")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsAllMatchById
    End Function
    Public Function UpdateOwnerInfo(ByVal UserName As String, ByVal IDOwner As String) As String
        'Dim dsUpdateOwnerInfo As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = ""
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            sql = "UPDATE Ticket SET Ticket.OwnerName='" + UserName + "'WHERE(Ticket.OwnerID='" + IDOwner + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString
        End Try
        Return result
    End Function
    Public Function GetMatchID() As DataSet
        Dim dsGetMatchID As New DataSet
        Dim daGetMatchID As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT MatchID FROM Matchh"
        daGetMatchID = New OleDb.OleDbDataAdapter(sql, con)
        daGetMatchID.Fill(dsGetMatchID, "dtAllMatchID")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsGetMatchID
    End Function


    Private Sub BusinessClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BClass As New BusinessClass
        Dim dsPLoadAllTicket As New DataSet
        Dim result As String
        result = BClass.GetConnection
        If result = "true" Then
            dsPLoadAllTicket = BClass.GetAllTicketInfo
            If dsPLoadAllTicket.Tables("dtAllTicketInfo").Rows.Count = 0 Then
                MsgBox("Error! No data values in database")
            Else
                dgdInformation.DataSource = dsPLoadAllTicket.Tables("dtAllTicketInfo")
            End If
        Else
            MsgBox("Error! Could not establish connection")
        End If
        'Loading matchID into ComboBox
        Dim dsPLoadMatchID As New DataSet
        Dim i As Integer
        dsPLoadMatchID = BClass.GetMatchID
        If dsPLoadMatchID.Tables("dtAllMatchID").Rows.Count = 0 Then
            MsgBox("No value found in database")
        Else
            For i = 0 To dsPLoadMatchID.Tables("dtAllMatchID").Rows.Count - 1
                cmbMatchID.Items.Add(dsPLoadMatchID.Tables("dtAllMatchID").Rows(i).Item("MatchId"))
            Next
        End If
    End Sub

    Private Sub btnFindTicket_Click(sender As Object, e As EventArgs) Handles btnFindTicket.Click
        Dim BClass As New BusinessClass
        Dim dsFindTicket As New DataSet
        Dim result As String
        result = BClass.GetConnection
        If result = "true" Then
            dsFindTicket = BClass.GetAllMatchesById(cmbMatchID.SelectedItem)
            If dsFindTicket.Tables("dtAllMatchByID").Rows.Count = 0 Then
                MsgBox("No values found in database")
            Else
                dgdInformation.DataSource = dsFindTicket.Tables("dtAllMatchByID")
            End If
        Else
            MsgBox("Could not establish connection to database")
        End If
    End Sub

    Private Sub btnUpdateTicket_Click(sender As Object, e As EventArgs) Handles btnUpdateTicket.Click
        Dim Bclass As New BusinessClass
        Dim dsUpdate As New DataSet
        Dim result As String
        result = Bclass.GetConnection
        If result = "true" Then
            Dim Opp As String
            Opp = Bclass.UpdateOwnerInfo(txtOwnerName.Text, txtOwnerID.Text)
            If Opp = "true" Then
                MsgBox("Details updated successfully")
            Else
                MsgBox("Error!! Details could not be updated")
            End If
        Else
            MsgBox("Connection failed")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class
