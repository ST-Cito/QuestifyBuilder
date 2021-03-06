Public Class SetOperations


    Public Shared Function Contains(Of T)(element As T, a As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As Boolean
        Dim containsElement As Boolean = False

        For Each elementInA As T In a
            If comparer.Equals(element, elementInA) Then
                containsElement = True
                Exit For
            End If
        Next
        Return containsElement
    End Function

    Public Shared Function ContainsAll(Of T)(elements As IEnumerable(Of T), a As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As Boolean
        Dim intersectSet As IList(Of T) = Intersect(elements, a, comparer)
        Dim difSet As IList(Of T) = Difference(elements, intersectSet, comparer)
        Dim result As Boolean = False

        If (difSet IsNot Nothing AndAlso intersectSet IsNot Nothing) AndAlso (intersectSet.Count > 0 AndAlso difSet.Count = 0) Then
            result = True
        End If

        Return result
    End Function

    Public Shared Function ContainsAny(Of T)(elements As IEnumerable(Of T), a As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As Boolean
        Dim intersectSet As IList(Of T) = CType(Intersect(elements, a, comparer), IList(Of T))
        Dim result As Boolean = False

        If intersectSet IsNot Nothing AndAlso intersectSet.Count >= 1 Then
            result = True
        End If

        Return result
    End Function

    Public Shared Function Difference(Of T)(A As IEnumerable(Of T), B As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As IList(Of T)
        Dim differenceSet As New List(Of T)

        For Each element As T In A
            If Not Contains(element, B, comparer) Then
                differenceSet.Add(element)
            End If
        Next

        Return differenceSet
    End Function

    Public Shared Function Intersect(Of T)(A As IEnumerable(Of T), b As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As IList(Of T)
        Dim interSectionSet As New List(Of T)

        For Each element As T In A
            If Contains(element, b, comparer) Then
                interSectionSet.Add(element)
            End If
        Next

        Return interSectionSet
    End Function


    Public Shared Function PowerSet(Of T)(A As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As IEnumerable(Of T)
        Throw New NotImplementedException
    End Function

    Public Shared Function Product(Of T)(A As IEnumerable(Of T), b As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As IList(Of T)
        Throw New NotImplementedException
    End Function

    Public Shared Function SymmetricDifference(Of T)(A As IEnumerable(Of T), b As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As IList(Of T)
        Dim unionSet As List(Of T) = CType(Union(A, b, comparer), List(Of T))
        Return Difference(unionSet, unionSet, comparer)
    End Function

    Public Shared Function Union(Of T)(A As IEnumerable(Of T), B As IEnumerable(Of T), comparer As IEqualityComparer(Of T)) As IList(Of T)
        Dim unionSet As New List(Of T)

        unionSet.AddRange(A)

        For Each element As T In B
            If Not Contains(element, unionSet, comparer) Then
                unionSet.Add(element)
            End If
        Next
        Return unionSet
    End Function


End Class