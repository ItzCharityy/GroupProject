Public Class Covid_19
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
        Return "I am Covid"
    End Function

End Class
