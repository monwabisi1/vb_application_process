<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formaccept
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formaccept))
        Me.dgvdisplay = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.piclogoff = New System.Windows.Forms.PictureBox()
        Me.picreport = New System.Windows.Forms.PictureBox()
        Me.cboAproved = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblname = New System.Windows.Forms.Label()
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvdisplay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(95, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
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
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'piclogoff
        '
        Me.piclogoff.BackColor = System.Drawing.Color.Transparent
        Me.piclogoff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piclogoff.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.piclogoff.Location = New System.Drawing.Point(977, 588)
        Me.piclogoff.Name = "piclogoff"
        Me.piclogoff.Size = New System.Drawing.Size(133, 125)
        Me.piclogoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.piclogoff.TabIndex = 29
        Me.piclogoff.TabStop = False
        '
        'picreport
        '
        Me.picreport.BackColor = System.Drawing.Color.Transparent
        Me.picreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picreport.Image = Global.WindowsApplication1.My.Resources.Resources.rep
        Me.picreport.Location = New System.Drawing.Point(807, 588)
        Me.picreport.Name = "picreport"
        Me.picreport.Size = New System.Drawing.Size(133, 125)
        Me.picreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picreport.TabIndex = 28
        Me.picreport.TabStop = False
        '
        'cboAproved
        '
        Me.cboAproved.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAproved.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAproved.FormattingEnabled = True
        Me.cboAproved.Location = New System.Drawing.Point(189, 89)
        Me.cboAproved.Name = "cboAproved"
        Me.cboAproved.Size = New System.Drawing.Size(229, 21)
        Me.cboAproved.Sorted = True
        Me.cboAproved.TabIndex = 30
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.refresh2
        Me.PictureBox3.Location = New System.Drawing.Point(189, 607)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 106)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblname.Location = New System.Drawing.Point(548, 31)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(383, 45)
        Me.lblname.TabIndex = 32
        Me.lblname.Text = "Approved Applicants Menu"
        '
        'Formaccept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(1311, 733)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.cboAproved)
        Me.Controls.Add(Me.piclogoff)
        Me.Controls.Add(Me.picreport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdisplay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formaccept"
        Me.Text = "Approved Interns"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdisplay As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents piclogoff As PictureBox
    Friend WithEvents picreport As PictureBox
    Friend WithEvents cboAproved As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblname As Label
End Class
