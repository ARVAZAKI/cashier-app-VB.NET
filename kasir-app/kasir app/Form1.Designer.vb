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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxfruittea = New System.Windows.Forms.CheckBox()
        Me.boxfloridina = New System.Windows.Forms.CheckBox()
        Me.boxmilktea = New System.Windows.Forms.CheckBox()
        Me.boxesteh = New System.Windows.Forms.CheckBox()
        Me.txtfruittea = New System.Windows.Forms.TextBox()
        Me.txtfloridina = New System.Windows.Forms.TextBox()
        Me.txtmilktea = New System.Windows.Forms.TextBox()
        Me.txtesteh = New System.Windows.Forms.TextBox()
        Me.boxesjeruk = New System.Windows.Forms.CheckBox()
        Me.txtesjeruk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxindomie = New System.Windows.Forms.CheckBox()
        Me.boxmieayam = New System.Windows.Forms.CheckBox()
        Me.boxbakso = New System.Windows.Forms.CheckBox()
        Me.boxchickenwings = New System.Windows.Forms.CheckBox()
        Me.txtindomie = New System.Windows.Forms.TextBox()
        Me.txtbakso = New System.Windows.Forms.TextBox()
        Me.txtmieayam = New System.Windows.Forms.TextBox()
        Me.txtchickenwings = New System.Windows.Forms.TextBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtjumlahuang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(277, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APLIKASI KASIR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'boxfruittea
        '
        Me.boxfruittea.AutoSize = True
        Me.boxfruittea.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxfruittea.Location = New System.Drawing.Point(12, 162)
        Me.boxfruittea.Name = "boxfruittea"
        Me.boxfruittea.Size = New System.Drawing.Size(227, 32)
        Me.boxfruittea.TabIndex = 1
        Me.boxfruittea.Text = "Fruit tea : Rp 3000,-"
        Me.boxfruittea.UseVisualStyleBackColor = True
        '
        'boxfloridina
        '
        Me.boxfloridina.AutoSize = True
        Me.boxfloridina.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxfloridina.Location = New System.Drawing.Point(12, 200)
        Me.boxfloridina.Name = "boxfloridina"
        Me.boxfloridina.Size = New System.Drawing.Size(231, 32)
        Me.boxfloridina.TabIndex = 2
        Me.boxfloridina.Text = "Floridina : Rp 3000,-"
        Me.boxfloridina.UseVisualStyleBackColor = True
        '
        'boxmilktea
        '
        Me.boxmilktea.AutoSize = True
        Me.boxmilktea.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxmilktea.Location = New System.Drawing.Point(12, 238)
        Me.boxmilktea.Name = "boxmilktea"
        Me.boxmilktea.Size = New System.Drawing.Size(227, 32)
        Me.boxmilktea.TabIndex = 3
        Me.boxmilktea.Text = "Milk Tea : Rp 4000,-"
        Me.boxmilktea.UseVisualStyleBackColor = True
        '
        'boxesteh
        '
        Me.boxesteh.AutoSize = True
        Me.boxesteh.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxesteh.Location = New System.Drawing.Point(12, 276)
        Me.boxesteh.Name = "boxesteh"
        Me.boxesteh.Size = New System.Drawing.Size(203, 32)
        Me.boxesteh.TabIndex = 4
        Me.boxesteh.Text = "Es teh : Rp 3000,-"
        Me.boxesteh.UseVisualStyleBackColor = True
        '
        'txtfruittea
        '
        Me.txtfruittea.Location = New System.Drawing.Point(249, 164)
        Me.txtfruittea.Name = "txtfruittea"
        Me.txtfruittea.Size = New System.Drawing.Size(43, 31)
        Me.txtfruittea.TabIndex = 5
        '
        'txtfloridina
        '
        Me.txtfloridina.Location = New System.Drawing.Point(249, 201)
        Me.txtfloridina.Name = "txtfloridina"
        Me.txtfloridina.Size = New System.Drawing.Size(43, 31)
        Me.txtfloridina.TabIndex = 6
        '
        'txtmilktea
        '
        Me.txtmilktea.Location = New System.Drawing.Point(249, 238)
        Me.txtmilktea.Name = "txtmilktea"
        Me.txtmilktea.Size = New System.Drawing.Size(43, 31)
        Me.txtmilktea.TabIndex = 7
        '
        'txtesteh
        '
        Me.txtesteh.Location = New System.Drawing.Point(249, 276)
        Me.txtesteh.Name = "txtesteh"
        Me.txtesteh.Size = New System.Drawing.Size(43, 31)
        Me.txtesteh.TabIndex = 8
        '
        'boxesjeruk
        '
        Me.boxesjeruk.AutoSize = True
        Me.boxesjeruk.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxesjeruk.Location = New System.Drawing.Point(12, 314)
        Me.boxesjeruk.Name = "boxesjeruk"
        Me.boxesjeruk.Size = New System.Drawing.Size(219, 32)
        Me.boxesjeruk.TabIndex = 9
        Me.boxesjeruk.Text = "Es jeruk : Rp 5000,-"
        Me.boxesjeruk.UseVisualStyleBackColor = True
        '
        'txtesjeruk
        '
        Me.txtesjeruk.Location = New System.Drawing.Point(249, 314)
        Me.txtesjeruk.Name = "txtesjeruk"
        Me.txtesjeruk.Size = New System.Drawing.Size(43, 31)
        Me.txtesjeruk.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(53, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DAFTAR MINUMAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(497, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "DAFTAR MAKANAN"
        '
        'boxindomie
        '
        Me.boxindomie.AutoSize = True
        Me.boxindomie.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxindomie.Location = New System.Drawing.Point(437, 162)
        Me.boxindomie.Name = "boxindomie"
        Me.boxindomie.Size = New System.Drawing.Size(223, 32)
        Me.boxindomie.TabIndex = 13
        Me.boxindomie.Text = "Indomie : Rp 5000,-"
        Me.boxindomie.UseVisualStyleBackColor = True
        '
        'boxmieayam
        '
        Me.boxmieayam.AutoSize = True
        Me.boxmieayam.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxmieayam.Location = New System.Drawing.Point(437, 200)
        Me.boxmieayam.Name = "boxmieayam"
        Me.boxmieayam.Size = New System.Drawing.Size(239, 32)
        Me.boxmieayam.TabIndex = 14
        Me.boxmieayam.Text = "Mie ayam : Rp 4000,-"
        Me.boxmieayam.UseVisualStyleBackColor = True
        '
        'boxbakso
        '
        Me.boxbakso.AutoSize = True
        Me.boxbakso.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxbakso.Location = New System.Drawing.Point(437, 238)
        Me.boxbakso.Name = "boxbakso"
        Me.boxbakso.Size = New System.Drawing.Size(204, 32)
        Me.boxbakso.TabIndex = 15
        Me.boxbakso.Text = "Bakso : Rp 5000,-"
        Me.boxbakso.UseVisualStyleBackColor = True
        '
        'boxchickenwings
        '
        Me.boxchickenwings.AutoSize = True
        Me.boxchickenwings.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.boxchickenwings.Location = New System.Drawing.Point(437, 275)
        Me.boxchickenwings.Name = "boxchickenwings"
        Me.boxchickenwings.Size = New System.Drawing.Size(298, 32)
        Me.boxchickenwings.TabIndex = 16
        Me.boxchickenwings.Text = "Chicken wings : Rp 10.000,-"
        Me.boxchickenwings.UseVisualStyleBackColor = True
        '
        'txtindomie
        '
        Me.txtindomie.Location = New System.Drawing.Point(745, 162)
        Me.txtindomie.Name = "txtindomie"
        Me.txtindomie.Size = New System.Drawing.Size(43, 31)
        Me.txtindomie.TabIndex = 18
        '
        'txtbakso
        '
        Me.txtbakso.Location = New System.Drawing.Point(745, 239)
        Me.txtbakso.Name = "txtbakso"
        Me.txtbakso.Size = New System.Drawing.Size(43, 31)
        Me.txtbakso.TabIndex = 19
        '
        'txtmieayam
        '
        Me.txtmieayam.Location = New System.Drawing.Point(745, 201)
        Me.txtmieayam.Name = "txtmieayam"
        Me.txtmieayam.Size = New System.Drawing.Size(43, 31)
        Me.txtmieayam.TabIndex = 20
        '
        'txtchickenwings
        '
        Me.txtchickenwings.Location = New System.Drawing.Point(745, 277)
        Me.txtchickenwings.Name = "txtchickenwings"
        Me.txtchickenwings.Size = New System.Drawing.Size(43, 31)
        Me.txtchickenwings.TabIndex = 21
        '
        'btnhitung
        '
        Me.btnhitung.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnhitung.Location = New System.Drawing.Point(601, 343)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(187, 62)
        Me.btnhitung.TabIndex = 22
        Me.btnhitung.Text = "HITUNG"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btncancel.Location = New System.Drawing.Point(601, 550)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(187, 62)
        Me.btncancel.TabIndex = 23
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(16, 511)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 28)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "jumlah uang : "
        '
        'txtjumlahuang
        '
        Me.txtjumlahuang.Location = New System.Drawing.Point(183, 511)
        Me.txtjumlahuang.Name = "txtjumlahuang"
        Me.txtjumlahuang.Size = New System.Drawing.Size(215, 31)
        Me.txtjumlahuang.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(12, 564)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 28)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "uang kembali :"
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(183, 561)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(215, 31)
        Me.txtkembalian.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(16, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 28)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "TOTAL : "
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(183, 465)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(215, 31)
        Me.txttotal.TabIndex = 29
        '
        'btnbayar
        '
        Me.btnbayar.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnbayar.Location = New System.Drawing.Point(601, 411)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(187, 62)
        Me.btnbayar.TabIndex = 30
        Me.btnbayar.Text = "BAYAR"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnclear.Location = New System.Drawing.Point(601, 482)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(187, 62)
        Me.btnclear.TabIndex = 31
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 624)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnbayar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtjumlahuang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txtchickenwings)
        Me.Controls.Add(Me.txtmieayam)
        Me.Controls.Add(Me.txtbakso)
        Me.Controls.Add(Me.txtindomie)
        Me.Controls.Add(Me.boxchickenwings)
        Me.Controls.Add(Me.boxbakso)
        Me.Controls.Add(Me.boxmieayam)
        Me.Controls.Add(Me.boxindomie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtesjeruk)
        Me.Controls.Add(Me.boxesjeruk)
        Me.Controls.Add(Me.txtesteh)
        Me.Controls.Add(Me.txtmilktea)
        Me.Controls.Add(Me.txtfloridina)
        Me.Controls.Add(Me.txtfruittea)
        Me.Controls.Add(Me.boxesteh)
        Me.Controls.Add(Me.boxmilktea)
        Me.Controls.Add(Me.boxfloridina)
        Me.Controls.Add(Me.boxfruittea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents boxfruittea As CheckBox
    Friend WithEvents boxfloridina As CheckBox
    Friend WithEvents boxmilktea As CheckBox
    Friend WithEvents boxesteh As CheckBox
    Friend WithEvents txtfruittea As TextBox
    Friend WithEvents txtfloridina As TextBox
    Friend WithEvents txtmilktea As TextBox
    Friend WithEvents txtesteh As TextBox
    Friend WithEvents boxesjeruk As CheckBox
    Friend WithEvents txtesjeruk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents boxindomie As CheckBox
    Friend WithEvents boxmieayam As CheckBox
    Friend WithEvents boxbakso As CheckBox
    Friend WithEvents boxchickenwings As CheckBox
    Friend WithEvents txtindomie As TextBox
    Friend WithEvents txtbakso As TextBox
    Friend WithEvents txtmieayam As TextBox
    Friend WithEvents txtchickenwings As TextBox
    Friend WithEvents btnhitung As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtjumlahuang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnbayar As Button
    Friend WithEvents btnclear As Button
End Class
