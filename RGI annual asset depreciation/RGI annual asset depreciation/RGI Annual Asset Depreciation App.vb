Public Class Form1
    Private Sub RGIassetAnnualMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For year As Integer = 3 To 20
            lstUsefulLife.Items.Add(year.ToString())
        Next
        lstUsefulLife.SelectedIndex = 0
    End Sub


    Private Sub btnDisplayDepreciationSchedules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayDepreciationSchedules.Click
        Dim assetCost As Decimal
        Dim salvageValue As Decimal
        Dim usefulLife As Integer


        Decimal.TryParse(txtAssetCost.Text, assetCost)
        Decimal.TryParse(txtSalvageValue.Text, salvageValue)
        Integer.TryParse(lstUsefulLife.SelectedItem.ToString(), usefulLife)


        lstDoubleDecliningBalance.Items.Clear()
        lstSumYearDigit.Items.Clear()
        lstDoubleDecliningBalance.Items.Add("Year" + vbTab + vbTab + "Depreciation")
        lstSumYearDigit.Items.Add("Year" + vbTab + vbTab + "Depreciation")
        For year As Integer = 1 To usefulLife
            Dim depreciation As Decimal = Financial.DDB(assetCost, salvageValue, usefulLife, year)
            lstDoubleDecliningBalance.Items.Add(year.ToString() + vbTab + vbTab + depreciation.ToString("N"))
            depreciation = Financial.SYD(assetCost, salvageValue, usefulLife, year)
            lstSumYearDigit.Items.Add(year.ToString() + vbTab + vbTab + depreciation.ToString("N"))
        Next


    End Sub
End Class
