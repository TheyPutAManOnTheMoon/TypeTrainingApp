Public Class zDataTable

    Private mRowArr As zDataRow()
    Private mRowCount As Integer = 5

    Private mLegend_ColorNormal As Color = Color.LightGray
    Private mLegend_ColorHighlight As Color = Color.FromArgb(148, 197, 133)
    Private mCells_ColorNormal As Color = Color.Gainsboro
    Private mCells_ColorHighlight As Color = Color.FromArgb(175, 232, 162)

    Private mRow_IsHighlightened As Boolean() = New Boolean(5) {}

    Private Function Index_IsValid(ByVal aIndex As Integer) As Boolean

        Return Not (aIndex < 0 Or aIndex > mRowCount)

    End Function
    Private Function RemoveRows(ByVal aQuantity As Integer) As Boolean

        Dim newQ As Integer = mRowCount - aQuantity
        If newQ < 1 Then Return False

        For i As Integer = mRowCount To newQ + 1 Step -1
            mRowArr(i).Dispose()
        Next

        ReDim Preserve mRowArr(newQ)
        ReDim Preserve mRow_IsHighlightened(newQ)

        TLP1.RowCount = newQ + 1
        mRowCount = newQ

        Return True

    End Function
    Private Function AddRows(ByVal aQuantity As Integer) As Boolean

        If aQuantity < 1 Then Return False

        Dim newQ As Integer = mRowCount + aQuantity

        TLP1.RowCount = newQ + 1
        ReDim Preserve mRowArr(newQ)
        ReDim Preserve mRow_IsHighlightened(newQ)

        For i As Integer = mRowCount + 1 To newQ

            TLP1.RowStyles.Insert(i, New RowStyle(TLP1.RowStyles.Item(1).SizeType))

            Dim l As New zDataRow
            Dim m As zDataRow = mRowArr(1)

            l.zCell0_Color = mLegend_ColorNormal
            l.zCell0_Width = m.zCell0_Width
            l.zCellQuantity = m.zCellQuantity
            l.zCells_Color = mCells_ColorNormal
            l.Margin = m.Margin
            l.Dock = m.Dock

            TLP1.Controls.Add(l, 0, i)
            mRowArr(i) = l

        Next

        For i As Integer = 0 To newQ
            TLP1.RowStyles.Item(i).Height = 100 / newQ
        Next

        mRowCount = newQ
        Return True

    End Function

    Public Property zColumnCount() As Integer
        Get
            Return zDataRow0.zCellQuantity
        End Get
        Set(ByVal value As Integer)

            If zDataRow0.zCellQuantity = value Then Exit Property

            For i As Integer = 0 To mRowCount
                mRowArr(i).zCellQuantity = value
            Next

        End Set
    End Property
    Public Property zRowCount() As Integer
        Get
            Return mRowCount
        End Get
        Set(ByVal value As Integer)

            If value < 1 Then Exit Property
            If mRowCount = value Then Exit Property

            If mRowCount < value Then
                AddRows(value - mRowCount)
            Else
                RemoveRows(mRowCount - value)
            End If

        End Set
    End Property

    Private Sub RefreshColors()

        mRowArr(0).zCell0_Color = mLegend_ColorNormal
        mRowArr(0).zCells_Color = mLegend_ColorNormal

        For i As Integer = 1 To mRowCount
            If mRow_IsHighlightened(i) = False Then
                mRowArr(i).zCell0_Color = mLegend_ColorNormal
                mRowArr(i).zCells_Color = mCells_ColorNormal
            Else
                mRowArr(i).zCell0_Color = mLegend_ColorHighlight
                mRowArr(i).zCells_Color = mCells_ColorHighlight
            End If
        Next

    End Sub

    Public Property zLegend_ColorNormal() As Color
        Get
            Return mLegend_ColorNormal
        End Get
        Set(ByVal value As Color)

            If mLegend_ColorNormal = value Then Exit Property
            mLegend_ColorNormal = value
            RefreshColors()

        End Set
    End Property
    Public Property zLegend_ColorHighlight() As Color
        Get
            Return mLegend_ColorHighlight
        End Get
        Set(ByVal value As Color)

            If mLegend_ColorHighlight = value Then Exit Property
            mLegend_ColorHighlight = value
            RefreshColors()

        End Set
    End Property
    Public Property zLegend_Text(ByVal aColumn As Integer) As String
        Get
            Return mRowArr(0).zCell_Text(aColumn)
        End Get
        Set(ByVal value As String)
            mRowArr(0).zCell_Text(aColumn) = value
        End Set
    End Property

    Public Property zCells_ColorNormal() As Color
        Get
            Return mCells_ColorNormal
        End Get
        Set(ByVal value As Color)

            If mCells_ColorNormal = value Then Exit Property
            mCells_ColorNormal = value
            RefreshColors()

        End Set
    End Property
    Public Property zCells_ColorHighlight() As Color
        Get
            Return mCells_ColorHighlight
        End Get
        Set(ByVal value As Color)

            If mCells_ColorHighlight = value Then Exit Property
            mCells_ColorHighlight = value
            RefreshColors()

        End Set
    End Property
    Public Property zCell_Text(ByVal r As Integer, ByVal c As Integer) As String
        Get

            If Index_IsValid(r) = False Then Return ""
            Return mRowArr(r).zCell_Text(c)

        End Get
        Set(ByVal value As String)

            If Index_IsValid(r) = False Then Exit Property
            mRowArr(r).zCell_Text(c) = value

        End Set
    End Property

    Public Property zRow_IsHighlightened(ByVal aRow As Integer) As Boolean
        Get
            Return mRow_IsHighlightened(aRow)
        End Get
        Set(ByVal value As Boolean)

            If value = 0 Then Exit Property
            If Index_IsValid(aRow) = False Then Exit Property
            If mRow_IsHighlightened(aRow) = value Then Exit Property

            mRow_IsHighlightened(aRow) = value
            RefreshColors()

        End Set
    End Property

    Sub New()

        InitializeComponent()
        mRowArr = New zDataRow() {zDataRow0, zDataRow1, zDataRow2, _
                                  zDataRow3, zDataRow4, zDataRow5}

    End Sub

End Class
