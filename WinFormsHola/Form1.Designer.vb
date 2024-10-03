<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        tbNombre = New TextBox()
        tbApellido = New TextBox()
        tbDia = New TextBox()
        tbMes = New TextBox()
        tbAño = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(363, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(350, 70)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(100, 23)
        tbNombre.TabIndex = 1
        ' 
        ' tbApellido
        ' 
        tbApellido.Location = New Point(350, 127)
        tbApellido.Name = "tbApellido"
        tbApellido.Size = New Size(100, 23)
        tbApellido.TabIndex = 2
        ' 
        ' tbDia
        ' 
        tbDia.Location = New Point(281, 189)
        tbDia.Name = "tbDia"
        tbDia.Size = New Size(47, 23)
        tbDia.TabIndex = 3
        ' 
        ' tbMes
        ' 
        tbMes.Location = New Point(376, 189)
        tbMes.Name = "tbMes"
        tbMes.Size = New Size(47, 23)
        tbMes.TabIndex = 4
        ' 
        ' tbAño
        ' 
        tbAño.Location = New Point(466, 189)
        tbAño.Name = "tbAño"
        tbAño.Size = New Size(47, 23)
        tbAño.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(350, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(350, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 7
        Label2.Text = "Apellidos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(281, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 15)
        Label3.TabIndex = 8
        Label3.Text = "Día"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(377, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 9
        Label4.Text = "Mes"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(466, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 10
        Label5.Text = "Año"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbAño)
        Controls.Add(tbMes)
        Controls.Add(tbDia)
        Controls.Add(tbApellido)
        Controls.Add(tbNombre)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbDia As TextBox
    Friend WithEvents tbMes As TextBox
    Friend WithEvents tbAño As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
