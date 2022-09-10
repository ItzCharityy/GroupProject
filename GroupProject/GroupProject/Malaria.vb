Public Class Malaria
    Inherits Disease

    Public Overrides Function RateOfTransmission() As Double
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Mortality() As Double
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetTypeOfDisease() As String
        Return "I am malaria"
    End Function

    Public Function Caouse() As String
        Return "mosquito"
    End Function

End Class
