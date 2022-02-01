<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comfirm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldeparturedate = New System.Windows.Forms.Label()
        Me.lbldeparturetime = New System.Windows.Forms.Label()
        Me.lblseatno = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblroute = New System.Windows.Forms.Label()
        Me.btncomfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please comfirm your purchase details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Departure Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departure Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Seat No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price(RM):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Route:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Terms & conditions for ticket bus holder"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(254, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(363, 65)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'lbldeparturedate
        '
        Me.lbldeparturedate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldeparturedate.Location = New System.Drawing.Point(228, 85)
        Me.lbldeparturedate.Name = "lbldeparturedate"
        Me.lbldeparturedate.Size = New System.Drawing.Size(90, 23)
        Me.lbldeparturedate.TabIndex = 8
        '
        'lbldeparturetime
        '
        Me.lbldeparturetime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldeparturetime.Location = New System.Drawing.Point(228, 115)
        Me.lbldeparturetime.Name = "lbldeparturetime"
        Me.lbldeparturetime.Size = New System.Drawing.Size(90, 23)
        Me.lbldeparturetime.TabIndex = 9
        '
        'lblseatno
        '
        Me.lblseatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblseatno.Location = New System.Drawing.Point(228, 145)
        Me.lblseatno.Name = "lblseatno"
        Me.lblseatno.Size = New System.Drawing.Size(90, 23)
        Me.lblseatno.TabIndex = 10
        '
        'lblprice
        '
        Me.lblprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblprice.Location = New System.Drawing.Point(228, 180)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(90, 23)
        Me.lblprice.TabIndex = 11
        '
        'lblroute
        '
        Me.lblroute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblroute.Location = New System.Drawing.Point(228, 215)
        Me.lblroute.Name = "lblroute"
        Me.lblroute.Size = New System.Drawing.Size(138, 23)
        Me.lblroute.TabIndex = 12
        '
        'btncomfirm
        '
        Me.btncomfirm.Location = New System.Drawing.Point(377, 390)
        Me.btncomfirm.Name = "btncomfirm"
        Me.btncomfirm.Size = New System.Drawing.Size(75, 23)
        Me.btncomfirm.TabIndex = 13
        Me.btncomfirm.Text = "COMFIRM"
        Me.btncomfirm.UseVisualStyleBackColor = True
        '
        'comfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(788, 479)
        Me.Controls.Add(Me.btncomfirm)
        Me.Controls.Add(Me.lblroute)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblseatno)
        Me.Controls.Add(Me.lbldeparturetime)
        Me.Controls.Add(Me.lbldeparturedate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "comfirm"
        Me.Text = "comfirm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbldeparturedate As System.Windows.Forms.Label
    Friend WithEvents lbldeparturetime As System.Windows.Forms.Label
    Friend WithEvents lblseatno As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblroute As System.Windows.Forms.Label
    Friend WithEvents btncomfirm As System.Windows.Forms.Button
End Class
