﻿Imports NUnit.Framework

<TestFixture>
Public Class Tests

    <Test>
    Public Sub TestCardBuilding()
        Dim gameEngine = New MatchingGameEngine(GameSize.Small, GetSimulatedFormWithPictureBoxControls())
        gameEngine.StartNewGame()



    End Sub


    Private Function GetSimulatedFormWithPictureBoxControls() As Form1

        Dim form = New Form1
        For i As Integer = 1 To 12
            form.Controls.Add(New PictureBox())
        Next

        Return form

    End Function


End Class
