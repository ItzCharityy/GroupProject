Public Class TB
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
            'NOTE THIS IS FOR TESTING AND DEBUGGING
        Return "I am TB"
    End Function
End Class
