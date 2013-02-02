Public Class Form1

    Private productService As New VidalProductService.productServiceClient
    Private cngService As New VidalCNGService.commonNameGroupServiceClient
    Private packService As New VidalPackService.packServiceClient
    Private ucdService As New VidalUcdService.ucdServiceClient
    Private prescriptionService As New PrescriptionServiceReference.drugPrescriptionAnalysisServiceClient



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        If ProductRadioButton.Checked Then
            Dim result As VidalProductService.ArrayOfProduct = productService.searchByNameAndType(TextBox1.Text, VidalProductService.ProductType.VIDAL)
            ListBox1.Items.AddRange(result.ToArray())
        ElseIf PackRadioButton.Checked Then
            Dim statuses As VidalPackService.ArrayOfMarketStatus = New VidalPackService.ArrayOfMarketStatus
            statuses.Add(VidalPackService.MarketStatus.AVAILABLE)
            statuses.Add(VidalPackService.MarketStatus.NEW)
            Dim types As VidalPackService.ArrayOfProductType = New VidalPackService.ArrayOfProductType
            types.Add(VidalPackService.ProductType.VIDAL)

            Dim result As VidalPackService.ArrayOfPack = packService.searchByNameTypesAndMarketStatuses(TextBox1.Text, types, statuses)
            ListBox1.Items.AddRange(result.ToArray())
        ElseIf DCIRadioButton.Checked Then
            Dim result As VidalCNGService.ArrayOfCommonNameGroup = cngService.searchByName(TextBox1.Text)
            ListBox1.Items.AddRange(result.ToArray())
        ElseIf UcdRadioButton.Checked Then
            Dim result As VidalUcdService.ArrayOfUcd = ucdService.searchByName(TextBox1.Text)
            ListBox1.Items.AddRange(result.ToArray())

        End If


        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prescriptionLine As String
        Dim dose As Double = 0.0
        
        Dim drugName As String = "?"
        Dim drugID As Integer

        Dim drugType As PrescriptionServiceReference.DrugType = PrescriptionServiceReference.DrugType.UNKNOWN
        If TypeOf ListBox1.SelectedItem Is VidalProductService.product Then
            Dim product As VidalProductService.product
            product = ListBox1.SelectedItem
            drugName = product.name
            drugID = product.id
            drugType = PrescriptionServiceReference.DrugType.PRODUCT
        ElseIf TypeOf ListBox1.SelectedItem Is VidalPackService.pack Then
            Dim pack As VidalPackService.pack
            pack = ListBox1.SelectedItem
            drugName = pack.name
            drugID = pack.id
            drugType = PrescriptionServiceReference.DrugType.PACK
        ElseIf TypeOf ListBox1.SelectedItem Is VidalCNGService.commonNameGroup Then
            Dim cng As VidalCNGService.commonNameGroup
            cng = ListBox1.SelectedItem
            drugName = cng.name
            drugID = cng.id
            drugType = PrescriptionServiceReference.DrugType.COMMON_NAME_GROUP
        ElseIf TypeOf ListBox1.SelectedItem Is VidalUcdService.ucd Then
            Dim ucd As VidalUcdService.ucd
            ucd = ListBox1.SelectedItem
            drugName = ucd.name
            drugID = ucd.id
            drugType = PrescriptionServiceReference.DrugType.UCD
        End If



        prescriptionLine = prescriptionService.prescriptionLineInDosesFromObjToJson(dose, Nothing,
                                                                 PrescriptionServiceReference.PosologyFrequencyType.PER_24_HOURS, New PrescriptionServiceReference.ArrayOfInt, New PrescriptionServiceReference.ArrayOfInt, drugID,
                                                                 drugType, 10, PrescriptionServiceReference.DurationType.DAY
                                                                 )

        DataGridView2.Rows.Add(Nothing, drugName, prescriptionLine)

        fireAnalyse()






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dateNaissance As New Date
        dateNaissance = DateTimePicker1.Value



        Label1.Text = prescriptionService.patientFromObjToJson(dateNaissance,
                                                 PrescriptionServiceReference.Gender.MALE,
                                                 80,
                                                 180,
                                                 Nothing,
                                                 Nothing,
        100,
        PrescriptionServiceReference.HepaticInsufficiency.NONE,
       New PrescriptionServiceReference.ArrayOfInt,
         New PrescriptionServiceReference.ArrayOfInt,
         New PrescriptionServiceReference.ArrayOfInt
                                                 )




    End Sub

    Private Sub fireAnalyse()
        Dim ordo As New PrescriptionServiceReference.ArrayOfString
        For Each row As DataGridViewRow In DataGridView2.Rows
            If (row.Cells("HiddenLine").Value IsNot Nothing) Then
                ordo.Add(row.Cells("HiddenLine").Value)
            End If
        Next
        
        Dim titi As String = prescriptionService.getAlertsAsHTML(Label1.Text, ordo)

        WebBrowser1.DocumentText = titi
    End Sub

End Class
