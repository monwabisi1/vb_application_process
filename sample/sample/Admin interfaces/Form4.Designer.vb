<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim CarouselEllipsePath1 As Telerik.WinControls.UI.CarouselEllipsePath = New Telerik.WinControls.UI.CarouselEllipsePath()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.RadCarousel1 = New Telerik.WinControls.UI.RadCarousel()
        Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement6 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement7 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement4 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement8 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement9 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement10 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.DonutShape1 = New Telerik.WinControls.Tests.DonutShape()
        CType(Me.RadCarousel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCarousel1
        '
        Me.RadCarousel1.BackColor = System.Drawing.Color.Transparent
        CarouselEllipsePath1.Center = New Telerik.WinControls.UI.Point3D(50.0R, 50.0R, 0R)
        CarouselEllipsePath1.FinalAngle = -100.0R
        CarouselEllipsePath1.InitialAngle = -90.0R
        CarouselEllipsePath1.U = New Telerik.WinControls.UI.Point3D(-20.0R, -17.0R, -50.0R)
        CarouselEllipsePath1.V = New Telerik.WinControls.UI.Point3D(30.0R, -25.0R, -60.0R)
        CarouselEllipsePath1.ZScale = 500.0R
        Me.RadCarousel1.CarouselPath = CarouselEllipsePath1
        Me.RadCarousel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadCarousel1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement1, Me.RadButtonElement2, Me.RadButtonElement5, Me.RadButtonElement6, Me.RadButtonElement7, Me.RadButtonElement3, Me.RadButtonElement4, Me.RadButtonElement8, Me.RadButtonElement9, Me.RadButtonElement10})
        Me.RadCarousel1.Location = New System.Drawing.Point(158, 63)
        Me.RadCarousel1.MinFadeOpacity = 0.55R
        Me.RadCarousel1.Name = "RadCarousel1"
        '
        '
        '
        Me.RadCarousel1.RootElement.Shape = Nothing
        Me.RadCarousel1.SelectedIndex = 0
        Me.RadCarousel1.Size = New System.Drawing.Size(1114, 612)
        Me.RadCarousel1.TabIndex = 0
        Me.RadCarousel1.Text = "RadCarousel1"
        '
        'RadButtonElement1
        '
        Me.RadButtonElement1.Image = Global.WindowsApplication1.My.Resources.Resources.logoff2
        Me.RadButtonElement1.Name = "RadButtonElement1"
        Me.RadButtonElement1.ShowBorder = False
        Me.RadButtonElement1.Text = ""
        '
        'RadButtonElement2
        '
        Me.RadButtonElement2.Image = Global.WindowsApplication1.My.Resources.Resources.approved
        Me.RadButtonElement2.Name = "RadButtonElement2"
        Me.RadButtonElement2.Text = ""
        '
        'RadButtonElement5
        '
        Me.RadButtonElement5.Image = Global.WindowsApplication1.My.Resources.Resources.all2
        Me.RadButtonElement5.Name = "RadButtonElement5"
        Me.RadButtonElement5.Text = ""
        '
        'RadButtonElement6
        '
        Me.RadButtonElement6.Image = Global.WindowsApplication1.My.Resources.Resources.shortlisted1
        Me.RadButtonElement6.Name = "RadButtonElement6"
        Me.RadButtonElement6.Text = ""
        '
        'RadButtonElement7
        '
        Me.RadButtonElement7.Image = Global.WindowsApplication1.My.Resources.Resources.rejected1
        Me.RadButtonElement7.Name = "RadButtonElement7"
        Me.RadButtonElement7.Text = ""
        '
        'RadButtonElement3
        '
        Me.RadButtonElement3.Image = Global.WindowsApplication1.My.Resources.Resources.interview1
        Me.RadButtonElement3.Name = "RadButtonElement3"
        Me.RadButtonElement3.Text = ""
        '
        'RadButtonElement4
        '
        Me.RadButtonElement4.Image = Global.WindowsApplication1.My.Resources.Resources.filter_data1
        Me.RadButtonElement4.Name = "RadButtonElement4"
        Me.RadButtonElement4.Text = ""
        '
        'RadButtonElement8
        '
        Me.RadButtonElement8.Image = Global.WindowsApplication1.My.Resources.Resources.aaaa1
        Me.RadButtonElement8.Name = "RadButtonElement8"
        Me.RadButtonElement8.Text = ""
        '
        'RadButtonElement9
        '
        Me.RadButtonElement9.Image = Global.WindowsApplication1.My.Resources.Resources.employees
        Me.RadButtonElement9.Name = "RadButtonElement9"
        Me.RadButtonElement9.Text = ""
        '
        'RadButtonElement10
        '
        Me.RadButtonElement10.Image = Global.WindowsApplication1.My.Resources.Resources.applicants
        Me.RadButtonElement10.Name = "RadButtonElement10"
        Me.RadButtonElement10.Text = ""
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(1325, 675)
        Me.Controls.Add(Me.RadCarousel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadCarousel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadCarousel1 As Telerik.WinControls.UI.RadCarousel
    Friend WithEvents RadButtonElement5 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement2 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement6 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement7 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement3 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement4 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement8 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents DonutShape1 As Telerik.WinControls.Tests.DonutShape
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents RadButtonElement9 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement10 As Telerik.WinControls.UI.RadButtonElement
End Class
