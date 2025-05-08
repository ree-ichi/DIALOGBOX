<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        BtnCek = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 0
        Label1.Text = "Masukkan Angka"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(253, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(248, 27)
        TextBox1.TabIndex = 1
        ' 
        ' BtnCek
        ' 
        BtnCek.Location = New Point(65, 129)
        BtnCek.Name = "BtnCek"
        BtnCek.Size = New Size(151, 46)
        BtnCek.TabIndex = 2
        BtnCek.Text = "CEK"
        BtnCek.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(350, 129)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(151, 46)
        BtnKeluar.TabIndex = 3
        BtnKeluar.Text = "KELUAR"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnCek)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnCek As Button
    Friend WithEvents BtnKeluar As Button

End Class
