<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warehouse_dependencies
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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Warehouse_ID = New DataGridViewTextBoxColumn()
        Orders_from = New DataGridViewTextBoxColumn()
        Lead_time_mean = New DataGridViewTextBoxColumn()
        Lead_time_std_dev = New DataGridViewTextBoxColumn()
        Reorder_cost = New DataGridViewTextBoxColumn()
        btn_dependencies_inputs = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(163, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(509, 22)
        Label1.TabIndex = 0
        Label1.Text = "Please Enter The Relationships Between Warehouses."
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Warehouse_ID, Orders_from, Lead_time_mean, Lead_time_std_dev, Reorder_cost})
        DataGridView1.Location = New Point(126, 140)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(546, 238)
        DataGridView1.TabIndex = 1
        ' 
        ' Warehouse_ID
        ' 
        Warehouse_ID.HeaderText = "Warehouse_ID"
        Warehouse_ID.Name = "Warehouse_ID"
        ' 
        ' Orders_from
        ' 
        Orders_from.HeaderText = "Warehouse To Order From "
        Orders_from.Name = "Orders_from"
        ' 
        ' Lead_time_mean
        ' 
        Lead_time_mean.HeaderText = "Lead Time Mean"
        Lead_time_mean.Name = "Lead_time_mean"
        ' 
        ' Lead_time_std_dev
        ' 
        Lead_time_std_dev.HeaderText = "Lead Time Std Dev"
        Lead_time_std_dev.Name = "Lead_time_std_dev"
        ' 
        ' Reorder_cost
        ' 
        Reorder_cost.HeaderText = "Reorder Cost"
        Reorder_cost.Name = "Reorder_cost"
        ' 
        ' btn_dependencies_inputs
        ' 
        btn_dependencies_inputs.Location = New Point(12, 392)
        btn_dependencies_inputs.Name = "btn_dependencies_inputs"
        btn_dependencies_inputs.Size = New Size(93, 23)
        btn_dependencies_inputs.TabIndex = 2
        btn_dependencies_inputs.Text = "Submit Inputs"
        btn_dependencies_inputs.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(200, 100)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(192, 72)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(192, 72)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(192, 72)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Warehouse_dependencies
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Controls.Add(btn_dependencies_inputs)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Warehouse_dependencies"
        Text = "Warehouse_dependencies"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Warehouse_ID As DataGridViewTextBoxColumn
    Friend WithEvents Orders_from As DataGridViewTextBoxColumn
    Friend WithEvents Lead_time_mean As DataGridViewTextBoxColumn
    Friend WithEvents Lead_time_std_dev As DataGridViewTextBoxColumn
    Friend WithEvents Reorder_cost As DataGridViewTextBoxColumn
    Friend WithEvents btn_dependencies_inputs As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
End Class
