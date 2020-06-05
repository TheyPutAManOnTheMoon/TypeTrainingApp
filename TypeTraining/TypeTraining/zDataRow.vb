Public Class zDataRow

    Private mLabelArr As Label()
    Private mCellCount As Integer = 4

    Private Function Index_IsValid(ByVal aIndex As Integer) As Boolean

        Return Not (aIndex < 0 Or aIndex > mCellCount)

    End Function
    Private Function RemoveCells(ByVal aQuantity As Integer) As Boolean

        Dim newQ As Integer = mCellCount - aQuantity
        If newQ < 1 Then Return False

        For i As Integer = mCellCount To newQ + 1 Step -1
            mLabelArr(i).Dispose()
        Next

        ReDim Preserve mLabelArr(newQ)
        TLP1.ColumnCount = newQ + 1
        mCellCount = newQ

        Return True

    End Function
    Private Function AddCells(ByVal aQuantity As Integer) As Boolean

        If aQuantity < 1 Then Return False

        Dim newQ As Integer = mCellCount + aQuantity

        TLP1.ColumnCount = newQ + 1
        ReDim Preserve mLabelArr(newQ)

        For i As Integer = mCellCount + 1 To newQ

            TLP1.ColumnStyles.Insert(i, New ColumnStyle(TLP1.ColumnStyles.Item(1).SizeType))

            Dim l As New Label

            l.TextAlign = ContentAlignment.MiddleCenter
            l.Text = i
            l.AutoSize = False
            l.BackColor = Label1.BackColor
            l.Dock = DockStyle.Fill
            l.Margin = Label1.Margin

            TLP1.Controls.Add(l, i, 0)
            mLabelArr(i) = l

        Next

        For i As Integer = 1 To newQ
            TLP1.ColumnStyles.Item(i).Width = 100 / newQ
        Next

        mCellCount = newQ
        Return True

    End Function

    Public Property zCell0_Color() As Color
        Get
            Return Label0.BackColor
        End Get
        Set(ByVal value As Color)
            If Label0.BackColor <> value Then Label0.BackColor = value
        End Set
    End Property
    Public Property zCell0_Width() As Integer
        Get
            Return TLP1.ColumnStyles.Item(0).Width
        End Get
        Set(ByVal value As Integer)
            TLP1.ColumnStyles.Item(0).Width = value
        End Set
    End Property

    Public Property zCells_Color() As Color
        Get
            Return Label1.BackColor
        End Get
        Set(ByVal value As Color)

            For i As Integer = 1 To mCellCount
                If mLabelArr(i).BackColor <> value Then mLabelArr(i).BackColor = value
            Next

        End Set
    End Property
    Public Property zCell_Text(ByVal aIndex As Integer) As String
        Get

            If Index_IsValid(aIndex) = False Then Return ""
            Return mLabelArr(aIndex).Text

        End Get
        Set(ByVal value As String)

            If Index_IsValid(aIndex) = False Then Exit Property
            mLabelArr(aIndex).Text = value

        End Set
    End Property
    Public Property zCellQuantity() As Integer
        Get
            Return mCellCount
        End Get
        Set(ByVal value As Integer)

            If value < 1 Then Exit Property
            If mCellCount = value Then Exit Property

            If mCellCount < value Then
                AddCells(value - mCellCount)
            Else
                RemoveCells(mCellCount - value)
            End If

        End Set
    End Property

    Sub New()

        InitializeComponent()
        mLabelArr = New Label() {Label0, Label1, Label2, Label3, Label4}

    End Sub

End Class
