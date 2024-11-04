Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Warehouse_Optimisation

<TestClass()> Public Class Data_structs_testing

    <TestMethod()> Public Sub Factory_inputs_testing()
        Dim test_factory_inputs As New Factory_inputs(1, 2, 3, 4, 5, 6, 7, 8, SiteType.Base_Factory, 9, 10, 11, 12)
        Assert.AreEqual(test_factory_inputs.factory_id, 1)
        Assert.AreEqual(test_factory_inputs.initial_inventory, 2)
        Assert.AreEqual(test_factory_inputs.demand_mean, 3)
        Assert.AreEqual(test_factory_inputs.demand_sd, 4)
        Assert.AreEqual(test_factory_inputs.reorder_point, 5)
        Assert.AreEqual(test_factory_inputs.reorder_amount, 6)
        Assert.AreEqual(test_factory_inputs.lead_time_mean, 7)
        Assert.AreEqual(test_factory_inputs.lead_time_sd, 8)
        Assert.AreEqual(test_factory_inputs.site_type, SiteType.Base_Factor)
        Assert.AreEqual(test_factory_inputs.profit_per_sale, 9)
        Assert.AreEqual(test_factory_inputs.holding_cost_per_pallet, 10)
        Assert.AreEqual(test_factory_inputs.items_per_pallet, 11)
        Assert.AreEqual(test_factory_inputs.reorder_cost, 12)
    End Sub




End Class