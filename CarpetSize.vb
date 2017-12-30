Public Class CarpetSize
    '=============================================================================================================
    ' Author:      Holly Eaton
    ' 
    ' Program:     Carpet Size
    ' 
    ' Dev Env:     Visual Studio
    ' 
    ' Description:
    '  Purpose:    Project that will determine: The area of carpet needed for a room.
    '  
    '  Input:      The length and witdth of the room. 
    '
    '  Process:    Calculate the area of the room.
    '
    '  Output:     Displays the area of the room.
    ' 
    '=============================================================================================================== 

    Private Sub btnCalcArea_Click(sender As Object, e As EventArgs) Handles btnCalcArea.Click

        'Calculates the area of the floor 

        'Dimension the variables
        Dim dblLength As Double
        Dim dblWidth As Double
        Dim dblArea As Double

        'Store the length and witdth entered by the user in dblLength and dblWidth.
        dblLength = txtLength.Text
        dblWidth = txtWidth.Text

        'Multiply length by width and store it in dblArea.
        dblArea = txtLength.Text * txtWidth.Text
        'Im not really sure if I am using dblLength and dblWidth here???

        'Display the value of dblArea in lblArea's text property.
        lblArea.Text = dblArea

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes Carpet Size application
        Me.Close()
    End Sub
End Class