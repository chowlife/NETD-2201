Option Strict On

''' <summary>
''' Author Name:    John Urdaneta
''' Project Name:   CarInventory
''' Program:        ListOfCars Class
''' Date:           20th March 2018
''' Reference:      Google, Prof Alfred's Sample Code, and the Murach VB 2015
''' Description:    Application to keep a list of cars and their information that makes them appealing to the buyer(s)
''' </summary>
Public Class ListOfCars

    ' Declaring Global Variables
    Private Shared carCount As Integer
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String
    Private carPrice As String
    Private carNewStatus As Boolean = False

    Public Sub New()

        carCount += 1                       ' Counter that increments by 1
        carIdentificationNumber = carCount  ' Give ID number

    End Sub

    Public Sub New(make As String, model As String, year As String, price As String, newstatus As Boolean)

        ' Call the constructor
        Me.New()

        ' Set the car make, model, year, price, and is it new?
        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        carNewStatus = newstatus

    End Sub

    ''' <summary>
    ''' Get the car count by Count()
    ''' then set it's value
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property
    ''' <summary>
    ''' Get the carIdentificationNumber count by IdentificationNumber
    ''' then set it's value
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property
    ''' <summary>
    ''' Get the carNewStatus count by NewStatus()
    ''' then set it's value
    ''' </summary>
    ''' <returns></returns>
    Public Property NewStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property
    ''' <summary>
    ''' Get the carMake count by Make()
    ''' then set it's value
    ''' </summary>
    ''' <returns></returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property
    ''' <summary>
    ''' Get the carModel count by Model()
    ''' then set it's value
    ''' </summary>
    ''' <returns></returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property
    ''' <summary>
    ''' Get the carYear count by Year()
    ''' then set it's value
    ''' </summary>
    ''' <returns></returns>
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property
    ''' <summary>
    ''' Get the carPrice count by Price()
    ''' then set it's value
    ''' </summary>
    ''' <returns></returns>
    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Function for outputing and displaying the information based on user's Input
    ''' </summary>
    ''' <returns></returns>
    Public Function GetInformation() As String

        Return "The car is a " & carYear & " " & carMake & " " & carModel & ", " & IIf(carNewStatus = True, "It is new", "It is used").ToString() & " and costs " & carPrice

    End Function
End Class
