Public Class Member

    Private m_Id As Integer
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set
            m_Id = Value
        End Set
    End Property

    Private m_Name As String
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set
            m_Name = Value
        End Set
    End Property

    Private m_Salary As Integer
    Public Property Salary() As Integer
        Get
            Return m_Salary
        End Get
        Set
            m_Salary = Value
        End Set
    End Property

    Private m_Position As String
    Public Property Position() As String
        Get
            Return m_Position
        End Get
        Set
            m_Position = Value
        End Set
    End Property

End Class

