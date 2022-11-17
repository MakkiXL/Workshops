Public Class Workshop

    Private Sub Workshop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GrpWorkshop.Enter

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLocations.SelectedIndexChanged

    End Sub

    Private Sub ListBoxWorkshops_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxWorkshops.SelectedIndexChanged

    End Sub

    Private Sub ListBoxCosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCosts.SelectedIndexChanged

    End Sub

    Private Sub BntAddWorkshop_Click(sender As Object, e As EventArgs) Handles BtnAddWorkshop.Click
        Dim IntTotal As Integer 'Hold calculation of workshop, location, and lodging for location
        Dim IntFeesPerDay As Integer 'Holds the cost of lodging ofe each location 
        Dim IntRegistrionFee As Integer 'Holds cost of workshop
        Dim IntDays As Integer 'Holds the length of days a workshop is 

        'makes sure user has picked both class and location when pressing the add workshop button
        If ListBoxWorkshops.SelectedIndex < 0 Or ListBoxLocations.SelectedIndex < 0 Then
            ListBoxCosts.Items.Clear()
            MessageBox.Show(" must select both workshop and location")

        End If

        'makes sure user has Added at least one workshop to costs box before being able to use the calculation button 
        If ListBoxCosts.Items.Count >= 0 Then
            BtnCalcTotal.Enabled = True
        End If

        'User has to have selected both workshop and location before any calculations take place
        If ListBoxWorkshops.SelectedIndex > -1 And ListBoxLocations.SelectedIndex > -1 Then

            'lines 46-61 are the costs of the workshop and the length of the workshop
            If ListBoxWorkshops.SelectedIndex() = 0 Then
                IntRegistrionFee = 595
                IntDays = 3
            ElseIf ListBoxWorkshops.SelectedIndex() = 1 Then
                IntRegistrionFee = 695
                IntDays = 3
            ElseIf ListBoxWorkshops.SelectedIndex() = 2 Then
                IntRegistrionFee = 995
                IntDays = 3
            ElseIf ListBoxWorkshops.SelectedIndex() = 3 Then
                IntRegistrionFee = 1295
                IntDays = 5
            ElseIf ListBoxWorkshops.SelectedIndex() = 4 Then
                IntRegistrionFee = 395
                IntDays = 1
            End If

            'lines 63-81 are fees per day based off of which location was selected 
            If ListBoxLocations.SelectedIndex() = 0 Then
                IntFeesPerDay = 95

            ElseIf ListBoxLocations.SelectedIndex() = 1 Then
                IntFeesPerDay = 125

            ElseIf ListBoxLocations.SelectedIndex() = 2 Then
                IntFeesPerDay = 110

            ElseIf ListBoxLocations.SelectedIndex() = 3 Then
                IntFeesPerDay = 100

            ElseIf ListBoxLocations.SelectedIndex() = 4 Then
                IntFeesPerDay = 92

            ElseIf ListBoxLocations.SelectedIndex() = 5 Then
                IntFeesPerDay = 90

            End If

            'formula to calculate total price of the the lesson with workshop days length multiplied by fee per day plus registration
            IntTotal = IntFeesPerDay * IntDays + IntRegistrionFee

            'displays total cost of class in list of cost box
            ListBoxCosts.Items.Add(IntTotal)

        End If

    End Sub

    Private Sub BntExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BntReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        'Lines 78-81 resets the workshop,locations, and costs listbox back to default. total cost richtextbox to blank and Calculate Total to false 
        ListBoxWorkshops.ClearSelected()
        ListBoxLocations.ClearSelected()
        ListBoxCosts.Items.Clear()
        RtbTotalCost.Clear()
        BtnCalcTotal.Enabled = False

    End Sub

    Private Sub BntCalcTotal_Click(sender As Object, e As EventArgs) Handles BtnCalcTotal.Click
        Dim IntCostTotal As Integer 'Used to hold total amount in ListBoxCost
        Dim IntCount As Integer 'counter to stop while loop

        'lines 118-126 reads through  the list of items in ListBoxCosts and adds all of them up
        While IntCount < ListBoxCosts.Items.Count
            IntCostTotal += CInt(ListBoxCosts.Items(0 + IntCount))

            IntCount += 1

        End While
        'converts IntCostTotal to currency format 
        RtbTotalCost.Text = IntCostTotal.ToString("c")

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RtbTotalCost.TextChanged

    End Sub

End Class