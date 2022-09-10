Public Class Country

    Private _Name As String
    Private _Population As Integer
    Private _Diseases() As Disease
    Private _EconomicDevelpment As String
   
    
    'NOTE THIS IS FOR TESTING AND DEBUGGING
    Public Sub New()
        ReDim _Diseases(3)
        '_Diseases(a) = New Disease
    End Sub
  
     'NOTE THIS IS FOR TESTING AND DEBUGGING   
    Public Sub New(Choice)
        ReDim Preserve _Diseases(Choice)
        '_Diseases(a) = New Disease
    End Sub


    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Population As Integer
        Get
            Return _Population
        End Get
        Set(value As Integer)
            _Population = value
        End Set
    End Property

    Public Property Diseases() As Disease()
        Get
            Return _Diseases
        End Get
        Set(value As Disease())
            _Diseases = value
        End Set
    End Property

    Public Property EconomicDevelpment() As String
        Get
            Return _EconomicDevelpment
        End Get
        Set(value As String)
            _EconomicDevelpment = value
        End Set
    End Property


    Public Function CalcDeathRate() As Double
        Return 0
    End Function





End Class
