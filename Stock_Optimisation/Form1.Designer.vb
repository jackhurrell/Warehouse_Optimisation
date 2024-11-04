<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Service_level_pred
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
        lblTitle = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Warehouse_ID = New DataGridViewTextBoxColumn()
        Demand_mean = New DataGridViewTextBoxColumn()
        Demand_std_dev = New DataGridViewTextBoxColumn()
        Reorder_point = New DataGridViewTextBoxColumn()
        Reorder_amount = New DataGridViewTextBoxColumn()
        lead_time_mean = New DataGridViewTextBoxColumn()
        Lead_time_std_dev = New DataGridViewTextBoxColumn()
        Reorder_cost = New DataGridViewTextBoxColumn()
        Profit_per_sale = New DataGridViewTextBoxColumn()
        Storage_cost = New DataGridViewTextBoxColumn()
        Items_per_pallet = New DataGridViewTextBoxColumn()
        Initial_inventory = New DataGridViewTextBoxColumn()
        btn_save_inputs = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.Top
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(153, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(414, 29)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Warehouse Network Service Levels"
        lblTitle.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(24, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 18)
        Label1.TabIndex = 1
        Label1.Text = "Enter Warehouse Inputs"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Warehouse_ID, Demand_mean, Demand_std_dev, Reorder_point, Reorder_amount, lead_time_mean, Lead_time_std_dev, Reorder_cost, Profit_per_sale, Storage_cost, Items_per_pallet, Initial_inventory})
        DataGridView1.Location = New Point(12, 108)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 192)
        DataGridView1.TabIndex = 2
        ' 
        ' Warehouse_ID
        ' 
        Warehouse_ID.HeaderText = "Warehouse_ID"
        Warehouse_ID.Name = "Warehouse_ID"
        ' 
        ' Demand_mean
        ' 
        Demand_mean.HeaderText = "Demand Mean"
        Demand_mean.Name = "Demand_mean"
        ' 
        ' Demand_std_dev
        ' 
        Demand_std_dev.HeaderText = "Demand Std Dev"
        Demand_std_dev.Name = "Demand_std_dev"
        ' 
        ' Reorder_point
        ' 
        Reorder_point.HeaderText = "Reorder Point"
        Reorder_point.Name = "Reorder_point"
        ' 
        ' Reorder_amount
        ' 
        Reorder_amount.HeaderText = "Reorder Amount"
        Reorder_amount.Name = "Reorder_amount"
        ' 
        ' lead_time_mean
        ' 
        lead_time_mean.HeaderText = "Lead Time Mean"
        lead_time_mean.Name = "lead_time_mean"
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
        ' Profit_per_sale
        ' 
        Profit_per_sale.HeaderText = "Profit Per Sale"
        Profit_per_sale.Name = "Profit_per_sale"
        ' 
        ' Storage_cost
        ' 
        Storage_cost.HeaderText = "Storage Cost "
        Storage_cost.Name = "Storage_cost"
        ' 
        ' Items_per_pallet
        ' 
        Items_per_pallet.HeaderText = "Items Per Pallet"
        Items_per_pallet.Name = "Items_per_pallet"
        ' 
        ' Initial_inventory
        ' 
        Initial_inventory.HeaderText = "Initial Inventory"
        Initial_inventory.Name = "Initial_inventory"
        ' 
        ' btn_save_inputs
        ' 
        btn_save_inputs.Location = New Point(12, 306)
        btn_save_inputs.Name = "btn_save_inputs"
        btn_save_inputs.Size = New Size(75, 23)
        btn_save_inputs.TabIndex = 3
        btn_save_inputs.Text = "Save Inputs"
        btn_save_inputs.UseVisualStyleBackColor = True
        ' 
        ' Service_level_pred
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_save_inputs)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "Service_level_pred"
        Text = "Warehouse Network Service Level Predictor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Warehouse_ID As DataGridViewTextBoxColumn
    Friend WithEvents Demand_mean As DataGridViewTextBoxColumn
    Friend WithEvents Demand_std_dev As DataGridViewTextBoxColumn
    Friend WithEvents Reorder_point As DataGridViewTextBoxColumn
    Friend WithEvents Reorder_amount As DataGridViewTextBoxColumn
    Friend WithEvents lead_time_mean As DataGridViewTextBoxColumn
    Friend WithEvents Lead_time_std_dev As DataGridViewTextBoxColumn
    Friend WithEvents Reorder_cost As DataGridViewTextBoxColumn
    Friend WithEvents Profit_per_sale As DataGridViewTextBoxColumn
    Friend WithEvents Storage_cost As DataGridViewTextBoxColumn
    Friend WithEvents Items_per_pallet As DataGridViewTextBoxColumn
    Friend WithEvents Initial_inventory As DataGridViewTextBoxColumn
    Friend WithEvents btn_save_inputs As Button

End Class
