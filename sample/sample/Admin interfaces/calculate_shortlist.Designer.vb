<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculate_shortlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calculate_shortlist))
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtqualification = New System.Windows.Forms.TextBox()
        Me.txtrace = New System.Windows.Forms.TextBox()
        Me.txtcover = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.txtcoverpoints = New System.Windows.Forms.TextBox()
        Me.txtgenderpoints = New System.Windows.Forms.TextBox()
        Me.txtracepoints = New System.Windows.Forms.TextBox()
        Me.txtqualificationpoints = New System.Windows.Forms.TextBox()
        Me.txtshortlistpoints = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.piclogoff = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picCalculate = New System.Windows.Forms.PictureBox()
        Me.picsave = New System.Windows.Forms.PictureBox()
        CType(Me.piclogoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCalculate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblname.Location = New System.Drawing.Point(335, 62)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(614, 45)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Calculate the shortlist points of the applicant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(392, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Qualification"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(392, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Race"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(392, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(392, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cover Letter"
        '
        'txtqualification
        '
        Me.txtqualification.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtqualification.Location = New System.Drawing.Point(479, 205)
        Me.txtqualification.Name = "txtqualification"
        Me.txtqualification.Size = New System.Drawing.Size(172, 20)
        Me.txtqualification.TabIndex = 5
        '
        'txtrace
        '
        Me.txtrace.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtrace.Location = New System.Drawing.Point(479, 278)
        Me.txtrace.Name = "txtrace"
        Me.txtrace.Size = New System.Drawing.Size(172, 20)
        Me.txtrace.TabIndex = 6
        '
        'txtcover
        '
        Me.txtcover.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtcover.Location = New System.Drawing.Point(479, 418)
        Me.txtcover.Name = "txtcover"
        Me.txtcover.ReadOnly = True
        Me.txtcover.Size = New System.Drawing.Size(172, 20)
        Me.txtcover.TabIndex = 7
        Me.txtcover.Text = "Successfully Uploaded"
        '
        'txtgender
        '
        Me.txtgender.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtgender.Location = New System.Drawing.Point(479, 341)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(172, 20)
        Me.txtgender.TabIndex = 8
        '
        'txtcoverpoints
        '
        Me.txtcoverpoints.Location = New System.Drawing.Point(765, 414)
        Me.txtcoverpoints.Name = "txtcoverpoints"
        Me.txtcoverpoints.Size = New System.Drawing.Size(94, 20)
        Me.txtcoverpoints.TabIndex = 9
        '
        'txtgenderpoints
        '
        Me.txtgenderpoints.Location = New System.Drawing.Point(765, 326)
        Me.txtgenderpoints.Name = "txtgenderpoints"
        Me.txtgenderpoints.Size = New System.Drawing.Size(94, 20)
        Me.txtgenderpoints.TabIndex = 10
        '
        'txtracepoints
        '
        Me.txtracepoints.Location = New System.Drawing.Point(765, 271)
        Me.txtracepoints.Name = "txtracepoints"
        Me.txtracepoints.Size = New System.Drawing.Size(94, 20)
        Me.txtracepoints.TabIndex = 11
        '
        'txtqualificationpoints
        '
        Me.txtqualificationpoints.Location = New System.Drawing.Point(765, 208)
        Me.txtqualificationpoints.Name = "txtqualificationpoints"
        Me.txtqualificationpoints.Size = New System.Drawing.Size(94, 20)
        Me.txtqualificationpoints.TabIndex = 12
        '
        'txtshortlistpoints
        '
        Me.txtshortlistpoints.Location = New System.Drawing.Point(954, 492)
        Me.txtshortlistpoints.Name = "txtshortlistpoints"
        Me.txtshortlistpoints.Size = New System.Drawing.Size(100, 20)
        Me.txtshortlistpoints.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(784, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Shortlist points"
        '
        'piclogoff
        '
        Me.piclogoff.BackColor = System.Drawing.Color.Transparent
        Me.piclogoff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piclogoff.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.piclogoff.Location = New System.Drawing.Point(1025, 584)
        Me.piclogoff.Name = "piclogoff"
        Me.piclogoff.Size = New System.Drawing.Size(133, 125)
        Me.piclogoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.piclogoff.TabIndex = 26
        Me.piclogoff.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.backarrow
        Me.PictureBox2.Location = New System.Drawing.Point(91, 517)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(124, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'picCalculate
        '
        Me.picCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCalculate.Image = Global.WindowsApplication1.My.Resources.Resources.cal
        Me.picCalculate.Location = New System.Drawing.Point(706, 584)
        Me.picCalculate.Name = "picCalculate"
        Me.picCalculate.Size = New System.Drawing.Size(128, 125)
        Me.picCalculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCalculate.TabIndex = 24
        Me.picCalculate.TabStop = False
        '
        'picsave
        '
        Me.picsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picsave.Image = Global.WindowsApplication1.My.Resources.Resources._4
        Me.picsave.Location = New System.Drawing.Point(873, 584)
        Me.picsave.Name = "picsave"
        Me.picsave.Size = New System.Drawing.Size(128, 125)
        Me.picsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picsave.TabIndex = 24
        Me.picsave.TabStop = False
        '
        'calculate_shortlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(1296, 750)
        Me.Controls.Add(Me.piclogoff)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picCalculate)
        Me.Controls.Add(Me.picsave)
        Me.Controls.Add(Me.txtshortlistpoints)
        Me.Controls.Add(Me.txtqualificationpoints)
        Me.Controls.Add(Me.txtracepoints)
        Me.Controls.Add(Me.txtgenderpoints)
        Me.Controls.Add(Me.txtcoverpoints)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.txtcover)
        Me.Controls.Add(Me.txtrace)
        Me.Controls.Add(Me.txtqualification)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "calculate_shortlist"
        Me.Text = "calculate_shortlist"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.piclogoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCalculate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtqualification As TextBox
    Friend WithEvents txtrace As TextBox
    Friend WithEvents txtcover As TextBox
    Friend WithEvents txtgender As TextBox
    Friend WithEvents txtcoverpoints As TextBox
    Friend WithEvents txtgenderpoints As TextBox
    Friend WithEvents txtracepoints As TextBox
    Friend WithEvents txtqualificationpoints As TextBox
    Friend WithEvents txtshortlistpoints As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents picsave As PictureBox
    Friend WithEvents picCalculate As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents piclogoff As PictureBox
End Class
