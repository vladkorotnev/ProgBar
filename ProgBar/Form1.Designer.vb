<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.title = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.min = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.sec = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.endchk = New System.Windows.Forms.CheckBox
        Me.endact = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OpenFilePar = New System.Windows.Forms.TextBox
        Me.browsebtn = New System.Windows.Forms.Button
        Me.msgpar = New System.Windows.Forms.TextBox
        Me.cmdpar = New System.Windows.Forms.TextBox
        Me.url = New System.Windows.Forms.TextBox
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog
        Me.StyleBox = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'title
        '
        Me.title.Location = New System.Drawing.Point(49, 28)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(353, 20)
        Me.title.TabIndex = 1
        Me.title.Text = "Formatting C:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Time:"
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(56, 65)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(28, 20)
        Me.min.TabIndex = 3
        Me.min.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "min."
        '
        'sec
        '
        Me.sec.Location = New System.Drawing.Point(124, 65)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(25, 20)
        Me.sec.TabIndex = 5
        Me.sec.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "sec."
        '
        'endchk
        '
        Me.endchk.AutoSize = True
        Me.endchk.Location = New System.Drawing.Point(15, 118)
        Me.endchk.Name = "endchk"
        Me.endchk.Size = New System.Drawing.Size(80, 17)
        Me.endchk.TabIndex = 7
        Me.endchk.Text = "End action:"
        Me.endchk.UseVisualStyleBackColor = True
        '
        'endact
        '
        Me.endact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.endact.Items.AddRange(New Object() {"Show Message", "Command line", "Open web page", "Open file", "Open other process"})
        Me.endact.Location = New System.Drawing.Point(102, 118)
        Me.endact.Name = "endact"
        Me.endact.Size = New System.Drawing.Size(299, 21)
        Me.endact.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OpenFilePar)
        Me.GroupBox1.Controls.Add(Me.browsebtn)
        Me.GroupBox1.Controls.Add(Me.msgpar)
        Me.GroupBox1.Controls.Add(Me.cmdpar)
        Me.GroupBox1.Controls.Add(Me.url)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 59)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action parameters"
        '
        'OpenFilePar
        '
        Me.OpenFilePar.Location = New System.Drawing.Point(7, 19)
        Me.OpenFilePar.Name = "OpenFilePar"
        Me.OpenFilePar.Size = New System.Drawing.Size(353, 20)
        Me.OpenFilePar.TabIndex = 2
        Me.OpenFilePar.Text = "File"
        '
        'browsebtn
        '
        Me.browsebtn.Location = New System.Drawing.Point(356, 19)
        Me.browsebtn.Name = "browsebtn"
        Me.browsebtn.Size = New System.Drawing.Size(26, 21)
        Me.browsebtn.TabIndex = 3
        Me.browsebtn.Text = "..."
        Me.browsebtn.UseVisualStyleBackColor = True
        '
        'msgpar
        '
        Me.msgpar.Location = New System.Drawing.Point(7, 19)
        Me.msgpar.Name = "msgpar"
        Me.msgpar.Size = New System.Drawing.Size(376, 20)
        Me.msgpar.TabIndex = 1
        Me.msgpar.Text = "Message"
        Me.msgpar.Visible = False
        '
        'cmdpar
        '
        Me.cmdpar.Location = New System.Drawing.Point(7, 20)
        Me.cmdpar.Name = "cmdpar"
        Me.cmdpar.Size = New System.Drawing.Size(376, 20)
        Me.cmdpar.TabIndex = 0
        Me.cmdpar.Text = "Command"
        Me.cmdpar.Visible = False
        '
        'url
        '
        Me.url.Location = New System.Drawing.Point(7, 19)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(375, 20)
        Me.url.TabIndex = 4
        Me.url.Text = "URL"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "File"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(414, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripButton1.Text = "Save"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripButton2.Text = "Open"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripButton3.Text = "Start"
        '
        'StyleBox
        '
        Me.StyleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StyleBox.FormattingEnabled = True
        Me.StyleBox.Items.AddRange(New Object() {"Blocks", "Continuous", "Marquee"})
        Me.StyleBox.Location = New System.Drawing.Point(16, 91)
        Me.StyleBox.Name = "StyleBox"
        Me.StyleBox.Size = New System.Drawing.Size(386, 21)
        Me.StyleBox.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 205)
        Me.Controls.Add(Me.StyleBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.endact)
        Me.Controls.Add(Me.endchk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(422, 239)
        Me.MinimumSize = New System.Drawing.Size(422, 239)
        Me.Name = "Form1"
        Me.Text = "ProgressBar!!!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents endchk As System.Windows.Forms.CheckBox
    Friend WithEvents endact As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFilePar As System.Windows.Forms.TextBox
    Friend WithEvents browsebtn As System.Windows.Forms.Button
    Friend WithEvents msgpar As System.Windows.Forms.TextBox
    Friend WithEvents cmdpar As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents url As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StyleBox As System.Windows.Forms.ComboBox

End Class
