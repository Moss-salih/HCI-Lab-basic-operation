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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnAdd = New Button()
        BtnSub = New Button()
        btnDiv = New Button()
        btnMult = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        txtAnswer = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(568, 135)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 65)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnSub
        ' 
        BtnSub.Location = New Point(568, 204)
        BtnSub.Name = "BtnSub"
        BtnSub.Size = New Size(112, 65)
        BtnSub.TabIndex = 1
        BtnSub.Text = "Sub"
        BtnSub.UseVisualStyleBackColor = True
        ' 
        ' btnDiv
        ' 
        btnDiv.Location = New Point(568, 277)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(112, 65)
        btnDiv.TabIndex = 2
        btnDiv.Text = "Div"
        btnDiv.UseVisualStyleBackColor = True
        ' 
        ' btnMult
        ' 
        btnMult.Location = New Point(568, 345)
        btnMult.Name = "btnMult"
        btnMult.Size = New Size(112, 65)
        btnMult.TabIndex = 3
        btnMult.Text = "Mult"
        btnMult.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Text", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(284, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 53)
        Label1.TabIndex = 4
        Label1.Text = "Calculator "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(128, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 5
        Label2.Text = "Number1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(128, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 6
        Label3.Text = "Number2"
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(128, 151)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(320, 31)
        txtNumber1.TabIndex = 7
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(128, 258)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(320, 31)
        txtNumber2.TabIndex = 8
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(128, 360)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(320, 31)
        txtAnswer.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(128, 332)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 25)
        Label4.TabIndex = 9
        Label4.Text = "Answer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtAnswer)
        Controls.Add(Label4)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnMult)
        Controls.Add(btnDiv)
        Controls.Add(BtnSub)
        Controls.Add(btnAdd)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "HCI Lab Operations "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents BtnSub As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label4 As Label
End Class
