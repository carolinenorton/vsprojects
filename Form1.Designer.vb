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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSalad = New System.Windows.Forms.Button()
        Me.btnSweets = New System.Windows.Forms.Button()
        Me.btnChicken = New System.Windows.Forms.Button()
        Me.btnBurger = New System.Windows.Forms.Button()
        Me.lbSalad = New System.Windows.Forms.ListBox()
        Me.lbBurger = New System.Windows.Forms.ListBox()
        Me.lbChicken = New System.Windows.Forms.ListBox()
        Me.lbSweets = New System.Windows.Forms.ListBox()
        Me.lbsweetprice = New System.Windows.Forms.ListBox()
        Me.lbburgerprice = New System.Windows.Forms.ListBox()
        Me.lbchickenprice = New System.Windows.Forms.ListBox()
        Me.lbsaladprice = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(748, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 57)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Finish"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(725, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnSalad
        '
        Me.btnSalad.Location = New System.Drawing.Point(30, 37)
        Me.btnSalad.Name = "btnSalad"
        Me.btnSalad.Size = New System.Drawing.Size(68, 61)
        Me.btnSalad.TabIndex = 2
        Me.btnSalad.Text = "Salad"
        Me.btnSalad.UseVisualStyleBackColor = True
        '
        'btnSweets
        '
        Me.btnSweets.Location = New System.Drawing.Point(30, 258)
        Me.btnSweets.Name = "btnSweets"
        Me.btnSweets.Size = New System.Drawing.Size(68, 61)
        Me.btnSweets.TabIndex = 4
        Me.btnSweets.Text = "Sweets"
        Me.btnSweets.UseVisualStyleBackColor = True
        '
        'btnChicken
        '
        Me.btnChicken.Location = New System.Drawing.Point(30, 180)
        Me.btnChicken.Name = "btnChicken"
        Me.btnChicken.Size = New System.Drawing.Size(68, 61)
        Me.btnChicken.TabIndex = 5
        Me.btnChicken.Text = "Chicken"
        Me.btnChicken.UseVisualStyleBackColor = True
        '
        'btnBurger
        '
        Me.btnBurger.Location = New System.Drawing.Point(30, 113)
        Me.btnBurger.Name = "btnBurger"
        Me.btnBurger.Size = New System.Drawing.Size(68, 61)
        Me.btnBurger.TabIndex = 6
        Me.btnBurger.Text = "Burger"
        Me.btnBurger.UseVisualStyleBackColor = True
        '
        'lbSalad
        '
        Me.lbSalad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSalad.FormattingEnabled = True
        Me.lbSalad.ItemHeight = 25
        Me.lbSalad.Items.AddRange(New Object() {"Egg", "Ham", "Roast Chicken", "Prawn"})
        Me.lbSalad.Location = New System.Drawing.Point(197, 43)
        Me.lbSalad.Name = "lbSalad"
        Me.lbSalad.Size = New System.Drawing.Size(512, 254)
        Me.lbSalad.TabIndex = 7
        '
        'lbBurger
        '
        Me.lbBurger.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBurger.FormattingEnabled = True
        Me.lbBurger.ItemHeight = 25
        Me.lbBurger.Items.AddRange(New Object() {"Hamburger", "Cheeseburger", "Steak burger", "Bean Burger"})
        Me.lbBurger.Location = New System.Drawing.Point(188, 35)
        Me.lbBurger.Name = "lbBurger"
        Me.lbBurger.Size = New System.Drawing.Size(520, 254)
        Me.lbBurger.TabIndex = 8
        '
        'lbChicken
        '
        Me.lbChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChicken.FormattingEnabled = True
        Me.lbChicken.ItemHeight = 25
        Me.lbChicken.Items.AddRange(New Object() {"Roast Chicken", "Chicken burger", "Chicken Salad", "Chicken drumsticks"})
        Me.lbChicken.Location = New System.Drawing.Point(186, 35)
        Me.lbChicken.Name = "lbChicken"
        Me.lbChicken.Size = New System.Drawing.Size(522, 254)
        Me.lbChicken.TabIndex = 9
        '
        'lbSweets
        '
        Me.lbSweets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSweets.FormattingEnabled = True
        Me.lbSweets.ItemHeight = 25
        Me.lbSweets.Items.AddRange(New Object() {"Ice cream", "Fruit Salad", "Strawberry Mousse", "Raspberry Pavlova"})
        Me.lbSweets.Location = New System.Drawing.Point(174, 34)
        Me.lbSweets.Name = "lbSweets"
        Me.lbSweets.Size = New System.Drawing.Size(534, 254)
        Me.lbSweets.TabIndex = 10
        '
        'lbsweetprice
        '
        Me.lbsweetprice.FormattingEnabled = True
        Me.lbsweetprice.Items.AddRange(New Object() {"1.00", "2.50", "3.00", "3.50"})
        Me.lbsweetprice.Location = New System.Drawing.Point(735, 54)
        Me.lbsweetprice.Name = "lbsweetprice"
        Me.lbsweetprice.Size = New System.Drawing.Size(144, 186)
        Me.lbsweetprice.TabIndex = 11
        Me.lbsweetprice.Visible = False
        '
        'lbburgerprice
        '
        Me.lbburgerprice.FormattingEnabled = True
        Me.lbburgerprice.Items.AddRange(New Object() {"1.00", "2.50", "3.00", "3.50"})
        Me.lbburgerprice.Location = New System.Drawing.Point(735, 55)
        Me.lbburgerprice.Name = "lbburgerprice"
        Me.lbburgerprice.Size = New System.Drawing.Size(144, 186)
        Me.lbburgerprice.TabIndex = 12
        Me.lbburgerprice.Visible = False
        '
        'lbchickenprice
        '
        Me.lbchickenprice.FormattingEnabled = True
        Me.lbchickenprice.Items.AddRange(New Object() {"1.00", "2.50", "3.00", "3.50"})
        Me.lbchickenprice.Location = New System.Drawing.Point(736, 55)
        Me.lbchickenprice.Name = "lbchickenprice"
        Me.lbchickenprice.Size = New System.Drawing.Size(144, 186)
        Me.lbchickenprice.TabIndex = 13
        Me.lbchickenprice.Visible = False
        '
        'lbsaladprice
        '
        Me.lbsaladprice.FormattingEnabled = True
        Me.lbsaladprice.Items.AddRange(New Object() {"1.00", "2.50", "3.00", "3.50"})
        Me.lbsaladprice.Location = New System.Drawing.Point(735, 54)
        Me.lbsaladprice.Name = "lbsaladprice"
        Me.lbsaladprice.Size = New System.Drawing.Size(144, 186)
        Me.lbsaladprice.TabIndex = 14
        Me.lbsaladprice.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 329)
        Me.Controls.Add(Me.lbsaladprice)
        Me.Controls.Add(Me.lbchickenprice)
        Me.Controls.Add(Me.lbburgerprice)
        Me.Controls.Add(Me.lbsweetprice)
        Me.Controls.Add(Me.lbSweets)
        Me.Controls.Add(Me.lbChicken)
        Me.Controls.Add(Me.lbBurger)
        Me.Controls.Add(Me.lbSalad)
        Me.Controls.Add(Me.btnBurger)
        Me.Controls.Add(Me.btnChicken)
        Me.Controls.Add(Me.btnSweets)
        Me.Controls.Add(Me.btnSalad)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSalad As Button
    Friend WithEvents btnSweets As Button
    Friend WithEvents btnChicken As Button
    Friend WithEvents btnBurger As Button
    Friend WithEvents lbSalad As ListBox
    Friend WithEvents lbBurger As ListBox
    Friend WithEvents lbChicken As ListBox
    Friend WithEvents lbSweets As ListBox
    Friend WithEvents lbsweetprice As ListBox
    Friend WithEvents lbburgerprice As ListBox
    Friend WithEvents lbchickenprice As ListBox
    Friend WithEvents lbsaladprice As ListBox
End Class
