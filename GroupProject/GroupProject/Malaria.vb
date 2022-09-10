Public Class Malaria
    Inherits Disease
 
    
    'NOTE THIS IS FOR TESTING AND DEBUGGING
    Public Overrides Function RateOfTransmission() As Double
        Throw New NotImplementedException()
    End Function

    'NOTE THIS IS FOR TESTING AND DEBUGGING
    Public Overrides Function Mortality() As Double
        Throw New NotImplementedException()
    End Function

    'NOTE THIS IS FOR TESTING AND DEBUGGING
    Public Overrides Function GetTypeOfDisease() As String
        Return "I am malaria"
    End Function

    
    'NOTE THIS IS FOR TESTING AND DEBUGGING
    Public Function Caouse() As String
        Return "mosquito"
    End Function

End Class
