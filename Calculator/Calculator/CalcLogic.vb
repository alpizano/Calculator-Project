Public Class CalcLogic

  Shared Function numCrunch(q As Queue(Of String)) As String

    Dim result As String = String.Empty
    Dim i As Integer = 0


    While q.Count > 0

      result = result + CType(q.Dequeue(), String)
      i -= 1
    End While

    Console.WriteLine("Answer before evaluate: " & result)

    Dim tbl As New DataTable

    result = CType(tbl.Compute(result, Nothing), String)

    Console.WriteLine("Answer after evaluate: " & result)


    Return result
  End Function

End Class
