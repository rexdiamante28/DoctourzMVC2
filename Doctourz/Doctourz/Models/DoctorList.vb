Public Class DoctorList
    Public Property docId() As String
        Get
            Return m_docId
        End Get
        Set(value As String)
            m_docId = value
        End Set
    End Property
    Private m_docId As String

    Public Property docName() As String
        Get
            Return m_docName
        End Get
        Set(value As String)
            m_docName = value
        End Set
    End Property
    Private m_docName As String

    Public Property docSpecialization() As String
        Get
            Return m_docSpecialization
        End Get
        Set(value As String)
            m_docSpecialization = value
        End Set
    End Property
    Private m_docSpecialization As String

    Public Property docLocation() As String
        Get
            Return m_docLocation
        End Get
        Set(value As String)
            m_docLocation = value
        End Set
    End Property
    Private m_docLocation As String

    Public Property docGender() As String
        Get
            Return m_docGender
        End Get
        Set(value As String)
            m_docGender = value
        End Set
    End Property
    Private m_docGender As String
End Class
