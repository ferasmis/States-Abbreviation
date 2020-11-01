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
        Me.lableState = New System.Windows.Forms.Label()
        Me.btnVirginia = New System.Windows.Forms.Button()
        Me.btnNorthCarolina = New System.Windows.Forms.Button()
        Me.btnWashington = New System.Windows.Forms.Button()
        Me.btnGeorgia = New System.Windows.Forms.Button()
        Me.btnAlabama = New System.Windows.Forms.Button()
        Me.btnFlorida = New System.Windows.Forms.Button()
        Me.picStates = New System.Windows.Forms.PictureBox()
        Me.lblAbbreviation = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picStates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lableState
        '
        Me.lableState.Location = New System.Drawing.Point(4, 35)
        Me.lableState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableState.Name = "lableState"
        Me.lableState.Size = New System.Drawing.Size(151, 34)
        Me.lableState.TabIndex = 0
        Me.lableState.Text = "State Abbreviation :"
        '
        'btnVirginia
        '
        Me.btnVirginia.Location = New System.Drawing.Point(36, 82)
        Me.btnVirginia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVirginia.Name = "btnVirginia"
        Me.btnVirginia.Size = New System.Drawing.Size(119, 33)
        Me.btnVirginia.TabIndex = 1
        Me.btnVirginia.Text = "Virginia"
        Me.btnVirginia.UseVisualStyleBackColor = True
        '
        'btnNorthCarolina
        '
        Me.btnNorthCarolina.Location = New System.Drawing.Point(36, 124)
        Me.btnNorthCarolina.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNorthCarolina.Name = "btnNorthCarolina"
        Me.btnNorthCarolina.Size = New System.Drawing.Size(119, 33)
        Me.btnNorthCarolina.TabIndex = 2
        Me.btnNorthCarolina.Text = "North Carolina"
        Me.btnNorthCarolina.UseVisualStyleBackColor = True
        '
        'btnWashington
        '
        Me.btnWashington.Location = New System.Drawing.Point(36, 165)
        Me.btnWashington.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWashington.Name = "btnWashington"
        Me.btnWashington.Size = New System.Drawing.Size(119, 33)
        Me.btnWashington.TabIndex = 3
        Me.btnWashington.Text = "Washington"
        Me.btnWashington.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Location = New System.Drawing.Point(36, 206)
        Me.btnGeorgia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(119, 33)
        Me.btnGeorgia.TabIndex = 4
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Location = New System.Drawing.Point(36, 247)
        Me.btnAlabama.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(119, 33)
        Me.btnAlabama.TabIndex = 5
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnFlorida
        '
        Me.btnFlorida.Location = New System.Drawing.Point(36, 289)
        Me.btnFlorida.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFlorida.Name = "btnFlorida"
        Me.btnFlorida.Size = New System.Drawing.Size(119, 33)
        Me.btnFlorida.TabIndex = 6
        Me.btnFlorida.Text = "Florida"
        Me.btnFlorida.UseVisualStyleBackColor = True
        '
        'picStates
        '
        Me.picStates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStates.Image = Global.States_Abbreviation.My.Resources.Resources.States
        Me.picStates.Location = New System.Drawing.Point(253, 35)
        Me.picStates.Name = "picStates"
        Me.picStates.Size = New System.Drawing.Size(423, 295)
        Me.picStates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStates.TabIndex = 7
        Me.picStates.TabStop = False
        '
        'lblAbbreviation
        '
        Me.lblAbbreviation.Location = New System.Drawing.Point(151, 35)
        Me.lblAbbreviation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbbreviation.Name = "lblAbbreviation"
        Me.lblAbbreviation.Size = New System.Drawing.Size(85, 34)
        Me.lblAbbreviation.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 398)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAbbreviation)
        Me.Controls.Add(Me.picStates)
        Me.Controls.Add(Me.btnFlorida)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnWashington)
        Me.Controls.Add(Me.btnNorthCarolina)
        Me.Controls.Add(Me.btnVirginia)
        Me.Controls.Add(Me.lableState)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "States Abbreviation"
        CType(Me.picStates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lableState As Label
    Friend WithEvents btnVirginia As Button
    Friend WithEvents btnNorthCarolina As Button
    Friend WithEvents btnWashington As Button
    Friend WithEvents btnGeorgia As Button
    Friend WithEvents btnAlabama As Button
    Friend WithEvents btnFlorida As Button
    Friend WithEvents picStates As PictureBox
    Friend WithEvents lblAbbreviation As Label
    Friend WithEvents Button1 As Button
End Class
