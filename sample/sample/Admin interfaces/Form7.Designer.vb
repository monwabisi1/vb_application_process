<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.dgvdisplay = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.piclogoff = New System.Windows.Forms.PictureBox()
        Me.picreject = New System.Windows.Forms.PictureBox()
        Me.picreport = New System.Windows.Forms.PictureBox()
        Me.picapprove = New System.Windows.Forms.PictureBox()
        Me.cboshortlisted = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblname = New System.Windows.Forms.Label()
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picreject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picapprove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdisplay
        '
        Me.dgvdisplay.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdisplay.Location = New System.Drawing.Point(189, 134)
        Me.dgvdisplay.Name = "dgvdisplay"
        Me.dgvdisplay.Size = New System.Drawing.Size(1019, 438)
        Me.dgvdisplay.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Identity Number"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.backarrow
        Me.PictureBox1.Location = New System.Drawing.Point(14, 558)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'piclogoff
        '
        Me.piclogoff.BackColor = System.Drawing.Color.Transparent
        Me.piclogoff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piclogoff.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.piclogoff.Location = New System.Drawing.Point(1006, 578)
        Me.piclogoff.Name = "piclogoff"
        Me.piclogoff.Size = New System.Drawing.Size(133, 125)
        Me.piclogoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.piclogoff.TabIndex = 26
        Me.piclogoff.TabStop = False
        '
        'picreject
        '
        Me.picreject.BackColor = System.Drawing.Color.Transparent
        Me.picreject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picreject.Image = Global.WindowsApplication1.My.Resources.Resources.reject1
        Me.picreject.Location = New System.Drawing.Point(486, 578)
        Me.picreject.Name = "picreject"
        Me.picreject.Size = New System.Drawing.Size(133, 125)
        Me.picreject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picreject.TabIndex = 25
        Me.picreject.TabStop = False
        '
        'picreport
        '
        Me.picreport.BackColor = System.Drawing.Color.Transparent
        Me.picreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picreport.Image = Global.WindowsApplication1.My.Resources.Resources.rep
        Me.picreport.Location = New System.Drawing.Point(835, 578)
        Me.picreport.Name = "picreport"
        Me.picreport.Size = New System.Drawing.Size(133, 125)
        Me.picreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picreport.TabIndex = 27
        Me.picreport.TabStop = False
        '
        'picapprove
        '
        Me.picapprove.BackColor = System.Drawing.Color.Transparent
        Me.picapprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picapprove.Image = Global.WindowsApplication1.My.Resources.Resources.approved2
        Me.picapprove.Location = New System.Drawing.Point(651, 578)
        Me.picapprove.Name = "picapprove"
        Me.picapprove.Size = New System.Drawing.Size(133, 125)
        Me.picapprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picapprove.TabIndex = 25
        Me.picapprove.TabStop = False
        '
        'cboshortlisted
        '
        Me.cboshortlisted.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboshortlisted.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboshortlisted.FormattingEnabled = True
        Me.cboshortlisted.Location = New System.Drawing.Point(189, 81)
        Me.cboshortlisted.Name = "cboshortlisted"
        Me.cboshortlisted.Size = New System.Drawing.Size(206, 21)
        Me.cboshortlisted.Sorted = True
        Me.cboshortlisted.TabIndex = 28
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.refresh2
        Me.PictureBox3.Location = New System.Drawing.Point(189, 597)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 106)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblname.Location = New System.Drawing.Point(507, 33)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(399, 45)
        Me.lblname.TabIndex = 30
        Me.lblname.Text = "Shortlisted Applicants Menu"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(1265, 704)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.cboshortlisted)
        Me.Controls.Add(Me.picreport)
        Me.Controls.Add(Me.piclogoff)
        Me.Controls.Add(Me.picapprove)
        Me.Controls.Add(Me.picreject)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdisplay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form7"
        Me.Text = "Shortlisted Applicants"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picreject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picapprove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdisplay As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents piclogoff As PictureBox
    Friend WithEvents picreject As PictureBox
    Friend WithEvents picreport As PictureBox
    Friend WithEvents picapprove As PictureBox
    Friend WithEvents cboshortlisted As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblname As Label
End Class
