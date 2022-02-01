<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_menu
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
        Me.btnloadtblePassenger = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnloadtbleTicket = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnloadtblePassenger
        '
        Me.btnloadtblePassenger.Location = New System.Drawing.Point(22, 91)
        Me.btnloadtblePassenger.Name = "btnloadtblePassenger"
        Me.btnloadtblePassenger.Size = New System.Drawing.Size(159, 23)
        Me.btnloadtblePassenger.TabIndex = 0
        Me.btnloadtblePassenger.Text = "LOAD TABLE"
        Me.btnloadtblePassenger.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(217, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 350)
        Me.DataGridView1.TabIndex = 1
        '
        'btnloadtbleTicket
        '
        Me.btnloadtbleTicket.Location = New System.Drawing.Point(22, 140)
        Me.btnloadtbleTicket.Name = "btnloadtbleTicket"
        Me.btnloadtbleTicket.Size = New System.Drawing.Size(159, 23)
        Me.btnloadtbleTicket.TabIndex = 2
        Me.btnloadtbleTicket.Text = "LOAD TABLE TICKET"
        Me.btnloadtbleTicket.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'admin_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project.My.Resources.Resources._70029844_modern_wallpapers
        Me.ClientSize = New System.Drawing.Size(788, 479)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnloadtbleTicket)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnloadtblePassenger)
        Me.Name = "admin_menu"
        Me.Text = "admin_menu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnloadtblePassenger As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnloadtbleTicket As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
