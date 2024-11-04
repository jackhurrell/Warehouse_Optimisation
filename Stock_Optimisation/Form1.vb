
Imports Warehouse_Optimisation

Public Class Service_level_pred


    Private Warehouse_inputs As New List(Of Warehouse_inputs)
    Private Sub Service_level_pred_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Warehouse Network Service Level Predictor"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_save_inputs_Click(sender As Object, e As EventArgs) Handles btn_save_inputs.Click
        Warehouse_inputs.Clear() ' Clear previous inputs
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim warehouseInput As New Warehouse_inputs(
                    warehouse_id:=Convert.ToInt32(row.Cells("Warehouse_ID").Value),
                    initial_inventory:=Convert.ToInt32(row.Cells("Initial_inventory").Value),
                    demand_mean:=Convert.ToDouble(row.Cells("Demand_mean").Value),
                    demand_sd:=Convert.ToDouble(row.Cells("Demand_std_dev").Value),
                    reorder_point:=Convert.ToDouble(row.Cells("Reorder_point").Value),
                    reorder_amount:=Convert.ToInt32(row.Cells("Reorder_amount").Value),
                    lead_time_mean:=Convert.ToInt32(row.Cells("Lead_time_mean").Value),
                    lead_time_sd:=Convert.ToInt32(row.Cells("Lead_time_std_dev").Value),
                    site_type:=SiteType.Base_Warehouse,
                    profit_per_sale:=0,
                    holding_cost_per_pallet:=Convert.ToDouble(row.Cells("Storage_cost").Value),
                    items_per_pallet:=Convert.ToDouble(row.Cells("Items_per_pallet").Value),
                    reorder_cost:=Convert.ToDouble(row.Cells("Reorder_cost").Value)
                )
                Warehouse_inputs.Add(warehouseInput)
            End If
        Next
        MessageBox.Show("Inputs saved successfully!")
    End Sub
End Class
