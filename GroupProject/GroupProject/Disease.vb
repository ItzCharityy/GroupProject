Public MustInherit Class Disease

    Private _Symptoms As String
    Private _Type As String
    Private _Transmission As String
    Private _TotalDeaths As Integer
    Private _TotalInfection As Integer


    Public Property Symptoms() As String
        Get
            Return _Symptoms
        End Get
        Set(value As String)
            _Symptoms = value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(value As String)
            _Type = value
        End Set
    End Property

    Public Property Transmission() As String
        Get
            Return _Transmission
        End Get
        Set(value As String)
            _Transmission = value
        End Set
    End Property

    Public Property TotalDeaths() As Integer
        Get
            Return _TotalDeaths
        End Get
        Set(value As Integer)
            _TotalDeaths = value
        End Set
    End Property

    Public Property TotalInfection() As Integer
        Get
            Return _TotalInfection
        End Get
        Set(value As Integer)
            _TotalInfection = value
        End Set
    End Property

    Public MustOverride Function RateOfTransmission() As Double
    Public MustOverride Function Mortality() As Double
    Public MustOverride Function GetTypeOfDisease() As String



End Class
