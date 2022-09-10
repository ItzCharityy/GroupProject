<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disease_Managment_System
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grdMyGrid = New UJGrid.UJGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPopulation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEcoDev = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 39)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Upcasting"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 39)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "DawnCast"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grdMyGrid
        '
        Me.grdMyGrid.FixedCols = 1
        Me.grdMyGrid.FixedRows = 1
        Me.grdMyGrid.Location = New System.Drawing.Point(127, 192)
        Me.grdMyGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMyGrid.Name = "grdMyGrid"
        Me.grdMyGrid.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdMyGrid.Size = New System.Drawing.Size(666, 204)
        Me.grdMyGrid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Felix Titling", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Country Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Felix Titling", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(475, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(318, 34)
        Me.txtName.TabIndex = 3
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Felix Titling", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Population"
        '
        'txtPopulation
        '
        Me.txtPopulation.Font = New System.Drawing.Font("Felix Titling", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPopulation.Location = New System.Drawing.Point(475, 77)
        Me.txtPopulation.Name = "txtPopulation"
        Me.txtPopulation.ReadOnly = True
        Me.txtPopulation.Size = New System.Drawing.Size(318, 34)
        Me.txtPopulation.TabIndex = 3
        Me.txtPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Felix Titling", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Economic Development"
        '
        'txtEcoDev
        '
        Me.txtEcoDev.Font = New System.Drawing.Font("Felix Titling", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEcoDev.Location = New System.Drawing.Point(475, 138)
        Me.txtEcoDev.Name = "txtEcoDev"
        Me.txtEcoDev.ReadOnly = True
        Me.txtEcoDev.Size = New System.Drawing.Size(318, 34)
        Me.txtEcoDev.TabIndex = 3
        Me.txtEcoDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Disease_Managment_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(810, 409)
        Me.Controls.Add(Me.txtEcoDev)
        Me.Controls.Add(Me.txtPopulation)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdMyGrid)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Disease_Managment_System"
        Me.Text = "Disease Managment System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents grdMyGrid As UJGrid.UJGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPopulation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEcoDev As TextBox
End Class
