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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lsttaille = New ComboBox()
        rdprop1 = New RadioButton()
        rdprop2 = New RadioButton()
        rdprop3 = New RadioButton()
        chk1 = New CheckBox()
        chk2 = New CheckBox()
        chk3 = New CheckBox()
        CheckBox4 = New CheckBox()
        btnafficher = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lsttaille
        ' 
        lsttaille.FormattingEnabled = True
        lsttaille.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        lsttaille.Location = New Point(314, 28)
        lsttaille.Name = "lsttaille"
        lsttaille.Size = New Size(121, 23)
        lsttaille.TabIndex = 1
        ' 
        ' rdprop1
        ' 
        rdprop1.AutoSize = True
        rdprop1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdprop1.Location = New Point(274, 122)
        rdprop1.Name = "rdprop1"
        rdprop1.Size = New Size(83, 19)
        rdprop1.TabIndex = 2
        rdprop1.TabStop = True
        rdprop1.Text = "Croute fine"
        rdprop1.UseVisualStyleBackColor = True
        ' 
        ' rdprop2
        ' 
        rdprop2.AutoSize = True
        rdprop2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdprop2.Location = New Point(274, 161)
        rdprop2.Name = "rdprop2"
        rdprop2.Size = New Size(112, 19)
        rdprop2.TabIndex = 3
        rdprop2.TabStop = True
        rdprop2.Text = "Croute Classique"
        rdprop2.UseVisualStyleBackColor = True
        ' 
        ' rdprop3
        ' 
        rdprop3.AutoSize = True
        rdprop3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdprop3.Location = New Point(274, 204)
        rdprop3.Name = "rdprop3"
        rdprop3.Size = New Size(101, 19)
        rdprop3.TabIndex = 4
        rdprop3.TabStop = True
        rdprop3.Text = "Croute épaisse"
        rdprop3.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chk1.Location = New Point(379, 317)
        chk1.Name = "chk1"
        chk1.Size = New Size(100, 19)
        chk1.TabIndex = 7
        chk1.Text = "Champignons"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chk2.Location = New Point(288, 317)
        chk2.Name = "chk2"
        chk2.Size = New Size(58, 19)
        chk2.TabIndex = 8
        chk2.Text = "Olives"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chk3.Location = New Point(513, 317)
        chk3.Name = "chk3"
        chk3.Size = New Size(73, 19)
        chk3.TabIndex = 9
        chk3.Text = "Poivrons"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox4.Location = New Point(618, 317)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(158, 19)
        CheckBox4.TabIndex = 10
        CheckBox4.Text = "Fromage supplémentaire"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' btnafficher
        ' 
        btnafficher.AccessibleName = "btnafficher"
        btnafficher.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnafficher.Location = New Point(645, 418)
        btnafficher.Name = "btnafficher"
        btnafficher.Size = New Size(131, 75)
        btnafficher.TabIndex = 11
        btnafficher.Text = "Afficher"
        btnafficher.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(70, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 17)
        Label1.TabIndex = 12
        Label1.Text = "Selectionner la taille de pizza"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Linen
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 17)
        Label2.TabIndex = 13
        Label2.Text = "Choisir le type de croute"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Linen
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 269)
        Label3.Name = "Label3"
        Label3.Size = New Size(253, 21)
        Label3.TabIndex = 14
        Label3.Text = "les ingrédients supplémentaires"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(969, 590)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnafficher)
        Controls.Add(CheckBox4)
        Controls.Add(chk3)
        Controls.Add(chk2)
        Controls.Add(chk1)
        Controls.Add(rdprop3)
        Controls.Add(rdprop2)
        Controls.Add(rdprop1)
        Controls.Add(lsttaille)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lsttaille As ComboBox
    Friend WithEvents rdprop1 As RadioButton
    Friend WithEvents rdprop2 As RadioButton
    Friend WithEvents rdprop3 As RadioButton
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents btnafficher As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
