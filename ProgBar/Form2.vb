Public Class frmPrg
    Public player As Form
    Public remMs As Integer
    Public title As String
    Public style As Integer
    Public endact As Integer
    Public endpar As String
    Dim Mnogotochie As String
    Public counter As Integer
    Public stage As Integer
    Private Declare Function ShellExecute _
                            Lib "shell32.dll" _
                            Alias "ShellExecuteA" ( _
                            ByVal hwnd As Long, _
                            ByVal lpOperation As String, _
                            ByVal lpFile As String, _
                            ByVal lpParameters As String, _
                            ByVal lpDirectory As String, _
                            ByVal nShowCmd As Long) _
                            As Long

    Sub prepareForProgressing()
        If title <> "developers" And title <> "DEVELOPERS" And title <> "Developers" Then
            Me.Text = title
            Mnogotochie = ""
           
        Else
            remMs = 183000
            Mnogotochie = " "
            counter = 0
            player = New Form
            player.Width = Screen.PrimaryScreen.WorkingArea.Width
            player.Height = Screen.PrimaryScreen.WorkingArea.Height
            player.WindowState = FormWindowState.Maximized
            player.ControlBox = False
            player.Text = "Ballmer"
            Dim winplay As New WebBrowser
            If Not My.Computer.FileSystem.FileExists("C:\tmp.wmv") Then
                FileOpen(1, "C:\tmp.wmv", OpenMode.Binary)
                FilePut(1, My.Resources.ballmer)
                FileClose(1)
            End If
            FileOpen(1, "C:\tmp.html", OpenMode.Output)
            WriteLine(1, My.Resources.html)
            FileClose(1)
            winplay.Parent = player
            winplay.Width = player.Width
            winplay.Height = player.Height
            winplay.Top = 0 - 40
            winplay.Left = 0
            winplay.Navigate(New Uri("file://C:\tmp.html"))
            player.Show()
            player.Width = player.Width - 20
            player.Height = player.Width - 40
            End If
            ProgressBar1.Style = style
            ProgressBar1.Maximum = 100
            Timer1.Interval = remMs / 100
            Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        Else
            Timer1.Enabled = False
            Select Case endact
                Case -1
                    End
                Case 0
                    MsgBox(endpar, MsgBoxStyle.OkOnly, title)
                    End
                Case 1
                    Shell(endpar, AppWinStyle.NormalFocus)
                    End
                Case 2
                    ' Shell("explorer " + endpar)
                    Dim ass As New WebBrowser
                    ass.Navigate(New Uri("about:blank"))
                    ass.Document.Window.Open(New Uri(endpar), "displayWindow", "width=800,height=600,location=yes", False)
                    End
                Case 3
                    Shell("Cmd /c " + Chr(34) + endpar + Chr(34), AppWinStyle.Hide)
                    End
                Case 4
                    Form1.ParseProcess(endpar)
                    Form1.BeginProcessingFromParsed()
                    'other process
            End Select

        End If
        If title <> "developers" And title <> "DEVELOPERS" And title <> "Developers" Then
            Select Case Mnogotochie
                Case ""
                    Mnogotochie = "."
                Case "."
                    Mnogotochie = ".."
                Case ".."
                    Mnogotochie = "..."
                Case "..."
                    Mnogotochie = ""
            End Select
            Me.Text = title + Mnogotochie
        Else
            endact = 0
            endpar = "Ballmer = LOL :)"
            Select Case Mnogotochie
                Case " "
                    Mnogotochie = "Developers"
                Case "Developers"
                    Mnogotochie = "Developers, Developers"
                Case "Developers, Developers"
                    Mnogotochie = "Developers, Developers, Developers"
                Case "Developers, Developers, Developers"
                    Mnogotochie = "Developers, Developers, Developers, Developers"
                Case "Developers, Developers, Developers, Developers"
                    Mnogotochie = " "
            End Select
            Me.Text = Mnogotochie
        End If
    End Sub

End Class