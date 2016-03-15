Imports System.IO
Imports System.IO.File


Public Class BillingData

    Private mClientFile As StreamReader
    Private mBillingFile As StreamWriter
    Private mClients As Collection

    Public ReadOnly Property Clients As Collection
        Get
            Return mClients
        End Get
    End Property

    Sub New()
        mClients = New Collection

        mClientFile = OpenText("..\..\client.txt")


        While Not mClientFile.EndOfStream
            mClients.Add(mClientFile.ReadLine())
        End While

        mClientFile.Close()

        'Write to billing file
        If Exists("..\..\billing.txt") Then
            mBillingFile = AppendText("..\..\billing.txt")
        Else
            mBillingFile = CreateText("..\..\billing.txt")
        End If

    End Sub

    Public Sub WriteBilling(ByVal record As String)
        mBillingFile.WriteLine(record)
    End Sub

    Public Sub CloseBilling()
        mBillingFile.Close()
    End Sub

End Class
