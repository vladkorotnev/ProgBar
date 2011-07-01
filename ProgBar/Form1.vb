Public Class Form1
    Public ParsedTitle As String
    Public ParsedMinutes As Integer
    Public ParsedSeconds As Integer
    Public ParsedEndaction As Boolean
    Public ParsedEndType As Integer
    Public ParsedEndparam As String
    Public ParsedStyle As Integer

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SaveFile.Filter = "Process|*.prc" 'Open file filter
        SaveFile.FileName = ""
        SaveFile.ShowDialog() ' open file
        If SaveFile.FileName <> "" Then
            FileOpen(1, SaveFile.FileName, OpenMode.Output) 'Open in program
            WriteLine(1, title.Text) 'Line 1 - title
            WriteLine(1, CInt(min.Text)) 'Line2 - minutes
            WriteLine(1, CInt(sec.Text)) 'Line3 - seconds
            WriteLine(1, CInt(endchk.Checked)) 'line4 - Is endaction on?
            If endchk.Checked = True Then
                WriteLine(1, CInt(endact.SelectedIndex())) 'Line5 - End action
                Select Case endact.SelectedIndex
                    Case 0
                        WriteLine(1, msgpar.Text) 'Line 6 - Message
                    Case 1
                        WriteLine(1, cmdpar.Text) 'Line 6 - command
                    Case 2
                        WriteLine(1, url.Text) 'Line 6 - Url
                    Case 3
                        WriteLine(1, OpenFilePar.Text) 'Line 6 - file
                    Case 4
                        WriteLine(1, OpenFilePar.Text) 'line6 - Process to parse
                End Select
            End If
            WriteLine(1, StyleBox.SelectedIndex) 'line 7 - style
            FileClose(1)
        End If
    End Sub



    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        OpenFile.Filter = "Process|*.prc"
        OpenFile.FileName = ""
        OpenFile.ShowDialog()
        If OpenFile.FileName <> "" Then
            ParseProcess(OpenFile.FileName)
            title.Text = ParsedTitle
            min.Text = ParsedMinutes
            sec.Text = ParsedSeconds
            endchk.Checked = ParsedEndaction
            If ParsedEndaction = True Then
                endact.SelectedIndex = ParsedEndType
                Select Case endact.SelectedIndex
                    Case 0
                        msgpar.Text = ParsedEndparam
                    Case 1
                        cmdpar.Text = ParsedEndparam
                    Case 2
                        url.Text = ParsedEndparam
                    Case 3
                        OpenFilePar.Text = ParsedEndparam
                    Case 4
                        OpenFilePar.Text = ParsedEndparam
                End Select
            End If
            StyleBox.SelectedIndex = ParsedStyle
        End If
    End Sub

    Public Sub ParseProcess(ByVal Filename As String)
        FileOpen(1, Filename, OpenMode.Input)
        ParsedTitle = LineInput(1)
        ParsedTitle = Replace(ParsedTitle, Chr(34), "", 1, -1)

        ParsedMinutes = CInt(LineInput(1))
        ParsedSeconds = CInt(LineInput(1))
        ParsedEndaction = CBool(LineInput(1))
        If ParsedEndaction = True Then
            ParsedEndType = CInt(LineInput(1))
            ParsedEndparam = LineInput(1)
            ParsedEndparam = Replace(ParsedEndparam, Chr(34), "", 1, -1)
        End If
        ParsedStyle = CInt(LineInput(1))
        FileClose(1)
    End Sub

    Public Sub BeginProcessing()
        Me.Hide()
        frmPrg.style = StyleBox.SelectedIndex
        frmPrg.remMs = CInt(CInt(CInt(min.Text) * 60 + CInt(sec.Text)) * 1000)
        If endchk.Checked Then
            frmPrg.endact = endact.SelectedIndex
        Else
            frmPrg.endact = -1
        End If
        frmPrg.title = title.Text

        If endchk.Checked = True Then
            Select Case endact.SelectedIndex
                Case 0
                    frmPrg.endpar = msgpar.Text
                Case 1
                    frmPrg.endpar = cmdpar.Text
                Case 2
                    frmPrg.endpar = url.Text
                Case 3
                    frmPrg.endpar = OpenFilePar.Text
                Case 4
                    frmPrg.endpar = OpenFilePar.Text
            End Select
        End If
        frmPrg.prepareForProgressing()
        frmPrg.Show()
        frmPrg.ShowInTaskbar = False
    End Sub

    Public Sub BeginProcessingFromParsed()
        Me.Hide()
        frmPrg.Close()
        frmPrg.style = ParsedStyle
        frmPrg.remMs = CInt(CInt(CInt(ParsedMinutes) * 60 + CInt(ParsedSeconds)) * 1000)

        If ParsedEndaction = True Then
            frmPrg.endact = ParsedEndType
            frmPrg.endpar = ParsedEndparam
        Else
            frmPrg.endact = -1
        End If
        frmPrg.title = ParsedTitle

        frmPrg.prepareForProgressing()
        frmPrg.Show()
        frmPrg.ShowInTaskbar = False
    End Sub

    Private Sub browsebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browsebtn.Click
        OpenFile.FileName = ""
        OpenFile.Filter = "Any file|*.*"
        OpenFile.ShowDialog()
        If OpenFile.FileName <> "" Then
            OpenFilePar.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StyleBox.SelectedIndex = 0
        endact.SelectedIndex = 0
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        BeginProcessing()
    End Sub


    Private Sub endact_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endact.SelectedIndexChanged
        Select Case endact.SelectedIndex
            Case 0
                msgpar.Visible = True
                cmdpar.Visible = False
                url.Visible = False
                OpenFilePar.Visible = False
                browsebtn.Visible = False
            Case 1
                msgpar.Visible = False
                cmdpar.Visible = True
                url.Visible = False
                OpenFilePar.Visible = False
                browsebtn.Visible = False
            Case 2
                msgpar.Visible = False
                cmdpar.Visible = False
                url.Visible = True
                OpenFilePar.Visible = False
                browsebtn.Visible = False
            Case 3
                msgpar.Visible = False
                cmdpar.Visible = False
                url.Visible = False
                OpenFilePar.Visible = True
                browsebtn.Visible = True
            Case 4
                msgpar.Visible = False
                cmdpar.Visible = False
                url.Visible = False
                OpenFilePar.Visible = True
                browsebtn.Visible = True
        End Select
    End Sub
End Class
