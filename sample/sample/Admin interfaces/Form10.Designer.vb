<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form10))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picreport = New System.Windows.Forms.PictureBox()
        Me.picshortlist = New System.Windows.Forms.PictureBox()
        Me.picreject = New System.Windows.Forms.PictureBox()
        Me.dgvdisplay = New System.Windows.Forms.DataGridView()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.cbolocation = New System.Windows.Forms.ComboBox()
        Me.cborace = New System.Windows.Forms.ComboBox()
        Me.cbofield = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picshortlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picreject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.backarrow
        Me.PictureBox1.Location = New System.Drawing.Point(14, 558)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'picreport
        '
        Me.picreport.BackColor = System.Drawing.Color.Transparent
        Me.picreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picreport.Image = Global.WindowsApplication1.My.Resources.Resources.rep
        Me.picreport.Location = New System.Drawing.Point(830, 591)
        Me.picreport.Name = "picreport"
        Me.picreport.Size = New System.Drawing.Size(133, 125)
        Me.picreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picreport.TabIndex = 14
        Me.picreport.TabStop = False
        '
        'picshortlist
        '
        Me.picshortlist.BackColor = System.Drawing.Color.Transparent
        Me.picshortlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picshortlist.Image = Global.WindowsApplication1.My.Resources.Resources._short
        Me.picshortlist.Location = New System.Drawing.Point(656, 591)
        Me.picshortlist.Name = "picshortlist"
        Me.picshortlist.Size = New System.Drawing.Size(133, 125)
        Me.picshortlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picshortlist.TabIndex = 15
        Me.picshortlist.TabStop = False
        '
        'picreject
        '
        Me.picreject.BackColor = System.Drawing.Color.Transparent
        Me.picreject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picreject.Image = Global.WindowsApplication1.My.Resources.Resources.reject1
        Me.picreject.Location = New System.Drawing.Point(491, 591)
        Me.picreject.Name = "picreject"
        Me.picreject.Size = New System.Drawing.Size(133, 125)
        Me.picreject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picreject.TabIndex = 16
        Me.picreject.TabStop = False
        '
        'dgvdisplay
        '
        Me.dgvdisplay.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdisplay.Location = New System.Drawing.Point(189, 147)
        Me.dgvdisplay.Name = "dgvdisplay"
        Me.dgvdisplay.Size = New System.Drawing.Size(1019, 438)
        Me.dgvdisplay.TabIndex = 17
        '
        'cbogender
        '
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Location = New System.Drawing.Point(192, 23)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(194, 21)
        Me.cbogender.Sorted = True
        Me.cbogender.TabIndex = 18
        '
        'cbolocation
        '
        Me.cbolocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbolocation.FormattingEnabled = True
        Me.cbolocation.Location = New System.Drawing.Point(580, 28)
        Me.cbolocation.Name = "cbolocation"
        Me.cbolocation.Size = New System.Drawing.Size(194, 21)
        Me.cbolocation.Sorted = True
        Me.cbolocation.TabIndex = 18
        '
        'cborace
        '
        Me.cborace.FormattingEnabled = True
        Me.cborace.Location = New System.Drawing.Point(192, 79)
        Me.cborace.Name = "cborace"
        Me.cborace.Size = New System.Drawing.Size(194, 21)
        Me.cborace.Sorted = True
        Me.cborace.TabIndex = 18
        '
        'cbofield
        '
        Me.cbofield.FormattingEnabled = True
        Me.cbofield.Location = New System.Drawing.Point(580, 82)
        Me.cbofield.Name = "cbofield"
        Me.cbofield.Size = New System.Drawing.Size(194, 21)
        Me.cbofield.Sorted = True
        Me.cbofield.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbofield)
        Me.GroupBox1.Controls.Add(Me.cborace)
        Me.GroupBox1.Controls.Add(Me.cbolocation)
        Me.GroupBox1.Controls.Add(Me.cbogender)
        Me.GroupBox1.Location = New System.Drawing.Point(189, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 138)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtering options"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.filter2
        Me.PictureBox2.Location = New System.Drawing.Point(880, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 119)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Field of Study"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Race"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Gender"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.PictureBox5.Location = New System.Drawing.Point(1004, 591)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(133, 125)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'txtid
        '
        Me.txtid.AutoCompleteCustomSource.AddRange(New String() {"7311156221087"})
        Me.txtid.Location = New System.Drawing.Point(248, 512)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(190, 20)
        Me.txtid.TabIndex = 23
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.refresh2
        Me.PictureBox3.Location = New System.Drawing.Point(167, 591)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 106)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(1309, 750)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvdisplay)
        Me.Controls.Add(Me.picreject)
        Me.Controls.Add(Me.picshortlist)
        Me.Controls.Add(Me.picreport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form10"
        Me.Text = "Filter applicants"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picshortlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picreject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picreport As PictureBox
    Friend WithEvents picshortlist As PictureBox
    Friend WithEvents picreject As PictureBox
    Friend WithEvents dgvdisplay As DataGridView
    Friend WithEvents cbogender As ComboBox
    Friend WithEvents cbolocation As ComboBox
    Friend WithEvents cborace As ComboBox
    Friend WithEvents cbofield As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
