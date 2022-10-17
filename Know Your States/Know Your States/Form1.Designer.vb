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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(369, 55)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(282, 232)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(21, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 151)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quiz Me"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Azure
        Me.Button2.Location = New System.Drawing.Point(49, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Give me a Capital"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Azure
        Me.Button1.Location = New System.Drawing.Point(49, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Give me a State"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(21, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 151)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Look-Up"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(19, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 36)
        Me.TextBox1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkRed
        Me.Button3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.Azure
        Me.Button3.Location = New System.Drawing.Point(19, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(276, 38)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Find State or Capital"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button5.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.Azure
        Me.Button5.Location = New System.Drawing.Point(369, 311)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(282, 38)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Display All States"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.Know_Your_States.My.Resources.Resources.depositphotos_3280440_stock_photo_american_flag
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(677, 367)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Know Your States"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
End Class
