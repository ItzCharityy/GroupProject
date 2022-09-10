Public Class Disease_Managment_System
    Private Countries As Country

    Private Sub PT(a As Integer, b As Integer, c As String)
        grdMyGrid.Row = a
        grdMyGrid.Col = b
        grdMyGrid.Text = c

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grdMyGrid.Rows = 1
        grdMyGrid.Cols = 4

        PT(0, 1, "Covid-19")
        PT(0, 2, "Malaria")
        PT(0, 3, "TB")

        Countries = New Country
        Countries.Name = InputBox("Name")
        txtName.Text = Countries.Name

        Countries.Population = CInt(InputBox("Population"))
        txtPopulation.Text = CStr(Countries.Population)

        Dim EcoDevChoose As Integer = CInt(InputBox("Economic Development(Choose a Number) " & Environment.NewLine & "1) Developed " & Environment.NewLine & "2) Developing "))
        If EcoDevChoose = 1 Then
            Countries.EconomicDevelpment = "Developed"
            txtEcoDev.Text = Countries.EconomicDevelpment
        Else
            Countries.EconomicDevelpment = "Developing"
            txtEcoDev.Text = Countries.EconomicDevelpment
        End If

        '<<.................Up Casting.................>>

        Dim Choice As Integer
        For Choice = 1 To 3
            Select Case Choice
                Case 1

                    Dim covid_19 As Covid_19 = New Covid_19
                    'Get Infomation About Covid_19
                    '.........
                    '.........
                    '.........
                    Countries.Diseases(Choice) = covid_19
                Case 2
                    Dim malaria As Malaria = New Malaria
                    'Get Infomation About Malaria
                    '.........
                    '.........
                    '.........
                    Countries.Diseases(Choice) = malaria
                Case 3
                    Dim tb As TB = New TB
                    'Get Infomation About Covid_19
                    '.........
                    '.........
                    '.........
                    Countries.Diseases(Choice) = tb
            End Select

        Next Choice







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '<<.................PolyMophSm.................>>

        For A As Integer = 1 To 3
            MsgBox(Countries.Diseases(A).GetTypeOfDisease)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        '<<.................DownCasting.................>>

        Dim cause As Malaria
        For A As Integer = 1 To 3
            cause = TryCast(Countries.Diseases(A), Malaria)
            If Not (cause Is Nothing) Then
                MsgBox(cause.Caouse)

            End If
        Next

    End Sub


End Class
