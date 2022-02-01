<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buy
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
        Me.nosiri1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTo = New System.Windows.Forms.ComboBox()
        Me.cbFrom = New System.Windows.Forms.ComboBox()
        Me.CbDate = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nosiri1
        '
        Me.nosiri1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nosiri1.Location = New System.Drawing.Point(889, 502)
        Me.nosiri1.Name = "nosiri1"
        Me.nosiri1.Size = New System.Drawing.Size(10, 10)
        Me.nosiri1.TabIndex = 15
        Me.nosiri1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.Location = New System.Drawing.Point(12, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "How To Buy a Ticket?"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.DimGray
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(230, 341)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(104, 46)
        Me.btnsearch.TabIndex = 12
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "From:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(68, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Departure Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Id_Ticket:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name Passenger : "
        '
        'cbTo
        '
        Me.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTo.FormattingEnabled = True
        Me.cbTo.Items.AddRange(New Object() {"TBS", "LARKIN", "IPOH", "KUANTAN"})
        Me.cbTo.Location = New System.Drawing.Point(230, 212)
        Me.cbTo.Name = "cbTo"
        Me.cbTo.Size = New System.Drawing.Size(174, 21)
        Me.cbTo.TabIndex = 5
        '
        'cbFrom
        '
        Me.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrom.FormattingEnabled = True
        Me.cbFrom.Items.AddRange(New Object() {"TBS", "LARKIN", "IPOH", "KUANTAN"})
        Me.cbFrom.Location = New System.Drawing.Point(230, 150)
        Me.cbFrom.Name = "cbFrom"
        Me.cbFrom.Size = New System.Drawing.Size(174, 21)
        Me.cbFrom.TabIndex = 3
        '
        'CbDate
        '
        Me.CbDate.CustomFormat = "yyyy-MM-dd"
        Me.CbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbDate.Location = New System.Drawing.Point(230, 268)
        Me.CbDate.Name = "CbDate"
        Me.CbDate.Size = New System.Drawing.Size(174, 20)
        Me.CbDate.TabIndex = 9
        Me.CbDate.Value = New Date(2017, 12, 17, 0, 0, 0, 0)
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(210, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 23)
        Me.txtName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(630, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 23)
        Me.Label6.TabIndex = 7
        '
        'Buy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project.My.Resources.Resources.mercedes_benz_bus_2016_wallpaper_1920x10801
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 479)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.nosiri1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.CbDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Buy"
        Me.Text = "Buy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nosiri1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTo As System.Windows.Forms.ComboBox
    Friend WithEvents cbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents CbDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
