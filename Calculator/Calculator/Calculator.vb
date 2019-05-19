Public Class Calculator

  'Dim calcList As New ArrayList
  Dim numbers As New Queue(Of String)
  Dim output As New Stack

  Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    listMode.Items.Add("Binary")
    listMode.Items.Add("Hexadecimal")
    listMode.Items.Add("Octal")

    'Dim i As Integer = 0
    ' While i < calcList.Count

    'lblOutput.Text = lblOutput.Text & CType(outputList.Pop(), String)
    'i += 1
    'End While
  End Sub

  Sub updateOutput()
    lblOutput.Text = lblOutput.Text + CType(output.Pop(), String)

  End Sub

  Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

  End Sub

  Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
    output.Push("0")
    numbers.Enqueue("0")
    updateOutput()

  End Sub

  Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
    output.Push("1")
    numbers.Enqueue("1")
    updateOutput()
  End Sub

  Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
    output.Push("2")
    numbers.Enqueue("2")
    updateOutput()

  End Sub

  Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
    output.Push("3")
    numbers.Enqueue("3")
    updateOutput()
  End Sub

  Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
    output.Push("4")
    updateOutput()
  End Sub

  Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
    output.Push("5")
    updateOutput()
  End Sub

  Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
    output.Push("6")
    updateOutput()
  End Sub

  Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
    output.Push("7")

    updateOutput()
  End Sub

  Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
    output.Push("8")

    updateOutput()
  End Sub

  Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
    output.Push("9")

    updateOutput()
  End Sub

  Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
    output.Push("*")
    numbers.Enqueue("*")
    updateOutput()
  End Sub

  Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
    output.Push("-")
    numbers.Enqueue("-")
    updateOutput()
  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    output.Push("+")
    numbers.Enqueue("+")
    updateOutput()
  End Sub

  Private Sub btnEq_Click(sender As Object, e As EventArgs) Handles btnEq.Click
    Console.WriteLine("Clicked equals button")
    Dim i As Integer = 0
    Dim result As String = String.Empty

    While numbers.Count < 0

      result = result + CType(numbers.Dequeue(), String)
      Console.WriteLine(result)
      i -= 1
    End While

    Console.WriteLine("After while loop" & result)


    lblOutput.Text = CalcLogic.numCrunch(numbers)

  End Sub


End Class
