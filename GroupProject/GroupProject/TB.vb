Public Class TB
    Inherits Disease

    Public Overrides Function RateOfTransmission() As Double
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Mortality() As Double
        Throw New NotImplementedException()
    End Function


    Public Overrides Function GetTypeOfDisease() As String
        Return "I am TB"
    End Function
End Class
