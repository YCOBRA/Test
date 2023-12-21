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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtsaving = New TextBox()
        txtmonths = New TextBox()
        txtrate = New TextBox()
        btnCompute = New Button()
        lbloutput = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 0
        Label1.Text = "Savings"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(110, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 1
        Label2.Text = "No of months"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(110, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 20)
        Label3.TabIndex = 2
        Label3.Text = "Annual interest rate"
        ' 
        ' txtsaving
        ' 
        txtsaving.Location = New Point(532, 41)
        txtsaving.Name = "txtsaving"
        txtsaving.Size = New Size(125, 27)
        txtsaving.TabIndex = 3
        ' 
        ' txtmonths
        ' 
        txtmonths.Location = New Point(532, 82)
        txtmonths.Name = "txtmonths"
        txtmonths.Size = New Size(125, 27)
        txtmonths.TabIndex = 4
        ' 
        ' txtrate
        ' 
        txtrate.Location = New Point(532, 114)
        txtrate.Name = "txtrate"
        txtrate.Size = New Size(125, 27)
        txtrate.TabIndex = 5
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(285, 166)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(94, 29)
        btnCompute.TabIndex = 6
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' lbloutput
        ' 
        lbloutput.AutoSize = True
        lbloutput.Location = New Point(241, 211)
        lbloutput.Name = "lbloutput"
        lbloutput.Size = New Size(53, 20)
        lbloutput.TabIndex = 7
        lbloutput.Text = "Label4"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbloutput)
        Controls.Add(btnCompute)
        Controls.Add(txtrate)
        Controls.Add(txtmonths)
        Controls.Add(txtsaving)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsaving As TextBox
    Friend WithEvents txtmonths As TextBox
    Friend WithEvents txtrate As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents lbloutput As Label
End Class
