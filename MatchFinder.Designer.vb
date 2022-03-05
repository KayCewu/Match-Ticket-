<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusinessClass
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
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._2020TicketDataSet = New Practical6._2020TicketDataSet()
        Me.dgdInformation = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMatchID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOwnerID = New System.Windows.Forms.TextBox()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.btnFindTicket = New System.Windows.Forms.Button()
        Me.btnUpdateTicket = New System.Windows.Forms.Button()
        Me.MatchTableAdapter = New Practical6._2020TicketDataSetTableAdapters.MatchTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._2020TicketDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_2020TicketDataSet
        '
        Me._2020TicketDataSet.DataSetName = "_2020TicketDataSet"
        Me._2020TicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgdInformation
        '
        Me.dgdInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdInformation.Location = New System.Drawing.Point(43, 123)
        Me.dgdInformation.Name = "dgdInformation"
        Me.dgdInformation.Size = New System.Drawing.Size(548, 179)
        Me.dgdInformation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select the match ID:"
        '
        'cmbMatchID
        '
        Me.cmbMatchID.FormattingEnabled = True
        Me.cmbMatchID.Location = New System.Drawing.Point(186, 33)
        Me.cmbMatchID.Name = "cmbMatchID"
        Me.cmbMatchID.Size = New System.Drawing.Size(121, 21)
        Me.cmbMatchID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Owner ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Owner Name:"
        '
        'txtOwnerID
        '
        Me.txtOwnerID.Location = New System.Drawing.Point(510, 31)
        Me.txtOwnerID.Name = "txtOwnerID"
        Me.txtOwnerID.Size = New System.Drawing.Size(100, 20)
        Me.txtOwnerID.TabIndex = 5
        '
        'txtOwnerName
        '
        Me.txtOwnerName.Location = New System.Drawing.Point(510, 81)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(100, 20)
        Me.txtOwnerName.TabIndex = 6
        '
        'btnFindTicket
        '
        Me.btnFindTicket.Location = New System.Drawing.Point(43, 320)
        Me.btnFindTicket.Name = "btnFindTicket"
        Me.btnFindTicket.Size = New System.Drawing.Size(102, 30)
        Me.btnFindTicket.TabIndex = 7
        Me.btnFindTicket.Text = "FIND TICKET"
        Me.btnFindTicket.UseVisualStyleBackColor = True
        '
        'btnUpdateTicket
        '
        Me.btnUpdateTicket.Location = New System.Drawing.Point(479, 320)
        Me.btnUpdateTicket.Name = "btnUpdateTicket"
        Me.btnUpdateTicket.Size = New System.Drawing.Size(112, 30)
        Me.btnUpdateTicket.TabIndex = 8
        Me.btnUpdateTicket.Text = "UPDATE TICKET"
        Me.btnUpdateTicket.UseVisualStyleBackColor = True
        '
        'MatchTableAdapter
        '
        Me.MatchTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(266, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BusinessClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 355)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdateTicket)
        Me.Controls.Add(Me.btnFindTicket)
        Me.Controls.Add(Me.txtOwnerName)
        Me.Controls.Add(Me.txtOwnerID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMatchID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdInformation)
        Me.Name = "BusinessClass"
        Me.Text = "Ticket Finder"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._2020TicketDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents _2020TicketDataSet As Practical6._2020TicketDataSet
    Friend WithEvents dgdInformation As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMatchID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOwnerID As System.Windows.Forms.TextBox
    Friend WithEvents txtOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents btnFindTicket As System.Windows.Forms.Button
    Friend WithEvents btnUpdateTicket As System.Windows.Forms.Button
    Friend WithEvents MatchTableAdapter As Practical6._2020TicketDataSetTableAdapters.MatchTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
