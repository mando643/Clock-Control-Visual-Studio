'Armando Jimenez


Public Class Clock
    Public Enum Type
        Normal
        Timer
    End Enum

    Public Event Ring As EventHandler(Of EventArgs)
    Public mtype As Type = Type.Normal
    Private mIsActive As Boolean = False
    Private mHowLong As String = "0:0"

    Dim m As Integer
    Dim s As Integer

    Public Property ClockType As Type
        Get
            If mtype = Type.Normal Then
                lblClock.Text = Date.Now.ToLongTimeString
            Else
                lblClock.Text = HowLong.ToString
            End If
            Return mtype
        End Get
        Set(value As Type)
            mtype = value
            If mtype = Type.Normal Then
                lblClock.Text = Date.Now.ToLongTimeString
            Else
                lblClock.Text = HowLong.ToString
            End If
        End Set
    End Property

    Public Property HowLong As String
        Get
            Return mHowLong
        End Get
        Set(value As String)
            mHowLong = value
            If mHowLong IsNot vbNullString Then
                Dim str() As String = mHowLong.Split(":")
                m = Convert.ToInt32(str(0))
                s = Convert.ToInt32(str(1))
            End If
        End Set
    End Property

    Public Property AlwaysActive As Boolean
        Get
            If mIsActive = True And Me.DesignMode = True Then
                Timer1.Enabled = True
            ElseIf mIsActive = False And Me.DesignMode = True Then
                Timer1.Enabled = False
            End If
            Return mIsActive
        End Get
        Set(value As Boolean)
            mIsActive = value
            If mIsActive = True And Me.DesignMode = True Then
                Timer1.Enabled = True
            ElseIf mIsActive = False And Me.DesignMode = True Then
                Timer1.Enabled = False
            End If
        End Set
    End Property

    Private Sub CancelTimer()
        mtype = Type.Normal
        lblClock.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Clock_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
        Me.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mtype = Type.Normal Then
            lblClock.Text = Date.Now.ToLongTimeString
        ElseIf mtype = Type.Timer Then
            If mHowLong = "" Then
                m = 0
                s = 0
            End If
            If m = 0 And s = 0 Then
                CancelTimer()
                RaiseEvent Ring(Me, New EventArgs())
            End If
            If s = 0 Then
                m -= 1
                s = 60
            End If
            s -= 1
            lblClock.Text = String.Format("{0}:{1}", m.ToString(), s.ToString().PadLeft(2, "0"))
        End If
    End Sub

    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles Me.Load
        If mIsActive = True Then
            Timer1.Enabled = True
        ElseIf mIsActive = False Then
            Timer1.Enabled = True
        End If

        If (mtype = Type.Normal) Then
            lblClock.Text = Date.Now.ToLongTimeString
        ElseIf (mtype = Type.Timer) Then
            lblClock.Text = HowLong.ToString
        End If
    End Sub
End Class