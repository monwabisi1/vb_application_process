<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboscrum = New System.Windows.Forms.ComboBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtshortlist = New System.Windows.Forms.TextBox()
        Me.txtpercent = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtinterviewer = New System.Windows.Forms.TextBox()
        Me.txtintervieweeid = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbofit = New System.Windows.Forms.ComboBox()
        Me.cbointerview = New System.Windows.Forms.ComboBox()
        Me.cbopresentation = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picclear = New System.Windows.Forms.PictureBox()
        Me.piccalculate = New System.Windows.Forms.PictureBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.picsave = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccalculate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.backarrow
        Me.PictureBox1.Location = New System.Drawing.Point(14, 558)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cboscrum
        '
        Me.cboscrum.FormattingEnabled = True
        Me.cboscrum.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboscrum.Location = New System.Drawing.Point(154, 14)
        Me.cboscrum.Name = "cboscrum"
        Me.cboscrum.Size = New System.Drawing.Size(101, 21)
        Me.cboscrum.TabIndex = 14
        '
        'txtsurname
        '
        Me.txtsurname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtsurname.Location = New System.Drawing.Point(924, 109)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.ReadOnly = True
        Me.txtsurname.Size = New System.Drawing.Size(202, 20)
        Me.txtsurname.TabIndex = 15
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtname.Location = New System.Drawing.Point(577, 106)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(202, 20)
        Me.txtname.TabIndex = 15
        '
        'txtshortlist
        '
        Me.txtshortlist.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtshortlist.Location = New System.Drawing.Point(190, 22)
        Me.txtshortlist.Name = "txtshortlist"
        Me.txtshortlist.ReadOnly = True
        Me.txtshortlist.Size = New System.Drawing.Size(202, 20)
        Me.txtshortlist.TabIndex = 15
        '
        'txtpercent
        '
        Me.txtpercent.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtpercent.Location = New System.Drawing.Point(190, 125)
        Me.txtpercent.Name = "txtpercent"
        Me.txtpercent.ReadOnly = True
        Me.txtpercent.Size = New System.Drawing.Size(202, 20)
        Me.txtpercent.TabIndex = 15
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txttotal.Location = New System.Drawing.Point(190, 75)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(202, 20)
        Me.txttotal.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtinterviewer)
        Me.GroupBox1.Controls.Add(Me.txtintervieweeid)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtsurname)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1171, 396)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'txtinterviewer
        '
        Me.txtinterviewer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtinterviewer.Location = New System.Drawing.Point(225, 43)
        Me.txtinterviewer.Name = "txtinterviewer"
        Me.txtinterviewer.ReadOnly = True
        Me.txtinterviewer.Size = New System.Drawing.Size(202, 20)
        Me.txtinterviewer.TabIndex = 22
        '
        'txtintervieweeid
        '
        Me.txtintervieweeid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtintervieweeid.Location = New System.Drawing.Point(225, 99)
        Me.txtintervieweeid.Name = "txtintervieweeid"
        Me.txtintervieweeid.ReadOnly = True
        Me.txtintervieweeid.Size = New System.Drawing.Size(202, 20)
        Me.txtintervieweeid.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtpercent)
        Me.GroupBox3.Controls.Add(Me.txttotal)
        Me.GroupBox3.Controls.Add(Me.txtshortlist)
        Me.GroupBox3.Location = New System.Drawing.Point(513, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(408, 187)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Score Board"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(65, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Total Score"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Percentage score"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Shortlist Total Score"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbofit)
        Me.GroupBox2.Controls.Add(Me.cbointerview)
        Me.GroupBox2.Controls.Add(Me.cbopresentation)
        Me.GroupBox2.Controls.Add(Me.cboscrum)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(139, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 187)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Points Allocation"
        '
        'cbofit
        '
        Me.cbofit.FormattingEnabled = True
        Me.cbofit.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbofit.Location = New System.Drawing.Point(154, 150)
        Me.cbofit.Name = "cbofit"
        Me.cbofit.Size = New System.Drawing.Size(101, 21)
        Me.cbofit.TabIndex = 14
        '
        'cbointerview
        '
        Me.cbointerview.FormattingEnabled = True
        Me.cbointerview.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbointerview.Location = New System.Drawing.Point(154, 106)
        Me.cbointerview.Name = "cbointerview"
        Me.cbointerview.Size = New System.Drawing.Size(101, 21)
        Me.cbointerview.TabIndex = 14
        '
        'cbopresentation
        '
        Me.cbopresentation.FormattingEnabled = True
        Me.cbopresentation.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbopresentation.Location = New System.Drawing.Point(154, 63)
        Me.cbopresentation.Name = "cbopresentation"
        Me.cbopresentation.Size = New System.Drawing.Size(101, 21)
        Me.cbopresentation.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fit Points"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Interview Points"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Presentation Points"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Scrum Points"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(804, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Interviewee Surname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Interviewee Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Interviewee Id:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Interviewer:"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.PictureBox5.Location = New System.Drawing.Point(974, 558)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(133, 125)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'picclear
        '
        Me.picclear.BackColor = System.Drawing.Color.Transparent
        Me.picclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picclear.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.picclear.Location = New System.Drawing.Point(820, 558)
        Me.picclear.Name = "picclear"
        Me.picclear.Size = New System.Drawing.Size(133, 125)
        Me.picclear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picclear.TabIndex = 21
        Me.picclear.TabStop = False
        '
        'piccalculate
        '
        Me.piccalculate.BackColor = System.Drawing.Color.Transparent
        Me.piccalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piccalculate.Image = Global.WindowsApplication1.My.Resources.Resources.cal
        Me.piccalculate.Location = New System.Drawing.Point(506, 558)
        Me.piccalculate.Name = "piccalculate"
        Me.piccalculate.Size = New System.Drawing.Size(128, 125)
        Me.piccalculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccalculate.TabIndex = 21
        Me.piccalculate.TabStop = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblname.Location = New System.Drawing.Point(335, 37)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(0, 45)
        Me.lblname.TabIndex = 22
        '
        'picsave
        '
        Me.picsave.Image = Global.WindowsApplication1.My.Resources.Resources._4
        Me.picsave.Location = New System.Drawing.Point(664, 558)
        Me.picsave.Name = "picsave"
        Me.picsave.Size = New System.Drawing.Size(128, 125)
        Me.picsave.TabIndex = 23
        Me.picsave.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.picsave)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.piccalculate)
        Me.Controls.Add(Me.picclear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Interview applicants"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccalculate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboscrum As ComboBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtshortlist As TextBox
    Friend WithEvents txtpercent As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents picclear As PictureBox
    Friend WithEvents piccalculate As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbofit As ComboBox
    Friend WithEvents cbointerview As ComboBox
    Friend WithEvents cbopresentation As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtintervieweeid As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents txtinterviewer As TextBox
    Friend WithEvents picsave As PictureBox
End Class
