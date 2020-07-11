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
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.btnGetMileage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(108, 36)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(193, 20)
        Me.txtDistance.TabIndex = 0
        Me.txtDistance.Text = "100"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(108, 85)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(193, 20)
        Me.txtGallons.TabIndex = 1
        Me.txtGallons.Text = "10"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(36, 39)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(49, 13)
        Me.lblDistance.TabIndex = 2
        Me.lblDistance.Text = "Distance"
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Location = New System.Drawing.Point(36, 88)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(42, 13)
        Me.lblGallons.TabIndex = 3
        Me.lblGallons.Text = "Gallons"
        '
        'btnGetMileage
        '
        Me.btnGetMileage.Location = New System.Drawing.Point(158, 132)
        Me.btnGetMileage.Name = "btnGetMileage"
        Me.btnGetMileage.Size = New System.Drawing.Size(75, 23)
        Me.btnGetMileage.TabIndex = 4
        Me.btnGetMileage.Text = "Get Mileage"
        Me.btnGetMileage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 224)
        Me.Controls.Add(Me.btnGetMileage)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtDistance)
        Me.Name = "Form1"
        Me.Text = "VB Mileage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDistance As TextBox
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents lblDistance As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents btnGetMileage As Button
End Class
