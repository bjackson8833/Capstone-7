' Name:         Capstone Project
' Purpose:      Wheel of Fortune
' Programmer:   Bj Jackson on 

Option Explicit On
Option Strict On
Option Infer Off




Imports System.Net.Http.Headers
Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMain
    Dim word As Integer
    Dim word1 As Integer
    Dim rand As New Random
    Dim strWord As String
    Dim TurnState As Double
    Dim countOne As Double
    Dim countTwo As Double
    Dim dblValue As Double
    Public strShareword As String
    Dim strWordR As String



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnWheel.Visible = False
        txtWord.Visible = False
        txtSolve.Visible = False
        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False
        btnE.Visible = False
        btnF.Visible = False
        btnG.Visible = False
        btnH.Visible = False
        btnI.Visible = False
        btnJ.Visible = False
        btnK.Visible = False
        btnL.Visible = False
        btnM.Visible = False
        btnN.Visible = False
        btnO.Visible = False
        btnP.Visible = False
        btnQ.Visible = False
        btnR.Visible = False
        btnS.Visible = False
        btnT.Visible = False
        btnU.Visible = False
        btnV.Visible = False
        btnW.Visible = False
        btnX.Visible = False
        btnY.Visible = False
        btnZ.Visible = False
        btnSolve.Visible = False
        picWheel.Image = My.Resources.c25
        Timer1.Interval = 75

        txtD.Text = 2.ToString

        picAD.Visible = False
        btnS2.Visible = False
        btnG2.Visible = False
        lblWould.Visible = False




    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        picArrow.Visible = True
        picWheel.Visible = True
        btnSpin.Visible = True
        btnGuess.Visible = True
        lblRolled.Text = ""
        Timer1.Start()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picWheel.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        txtTicks.Text = (CDbl(txtTicks.Text) + 1).ToString
        txtTrue.Text = (CDbl(txtTrue.Text) + 1).ToString
        If CDbl(txtTrue.Text) = 50 Then
            Timer1.Stop()
            GetSpins()
        End If




        If CDbl(txtTicks.Text) = 1 Then
            picWheel.Image = My.Resources.c25
        ElseIf CDbl(txtTicks.Text) = 2 Then
            picWheel.Image = My.Resources.c2
        ElseIf CDbl(txtTicks.Text) = 3 Then
            picWheel.Image = My.Resources.c3
        ElseIf CDbl(txtTicks.Text) = 4 Then
            picWheel.Image = My.Resources.c4
        ElseIf CDbl(txtTicks.Text) = 5 Then
            picWheel.Image = My.Resources.c5
        ElseIf CDbl(txtTicks.Text) = 6 Then
            picWheel.Image = My.Resources.c6
        ElseIf CDbl(txtTicks.Text) = 7 Then
            picWheel.Image = My.Resources.c7
        ElseIf CDbl(txtTicks.Text) = 8 Then
            picWheel.Image = My.Resources.c8
        ElseIf CDbl(txtTicks.Text) = 9 Then
            picWheel.Image = My.Resources.c9
        ElseIf CDbl(txtTicks.Text) = 10 Then
            picWheel.Image = My.Resources.c10
        ElseIf CDbl(txtTicks.Text) = 11 Then
            picWheel.Image = My.Resources.c11
        ElseIf CDbl(txtTicks.Text) = 12 Then
            picWheel.Image = My.Resources.c12
        ElseIf CDbl(txtTicks.Text) = 13 Then
            picWheel.Image = My.Resources.c13
        ElseIf CDbl(txtTicks.Text) = 14 Then
            picWheel.Image = My.Resources.c14
        ElseIf CDbl(txtTicks.Text) = 15 Then
            picWheel.Image = My.Resources.c15
        ElseIf CDbl(txtTicks.Text) = 16 Then
            picWheel.Image = My.Resources.c16
        ElseIf CDbl(txtTicks.Text) = 17 Then
            picWheel.Image = My.Resources.c17
        ElseIf CDbl(txtTicks.Text) = 18 Then
            picWheel.Image = My.Resources.c18
        ElseIf CDbl(txtTicks.Text) = 19 Then
            picWheel.Image = My.Resources.c19
        ElseIf CDbl(txtTicks.Text) = 20 Then
            picWheel.Image = My.Resources.c20
        ElseIf CDbl(txtTicks.Text) = 21 Then
            picWheel.Image = My.Resources.c21
        ElseIf CDbl(txtTicks.Text) = 22 Then
            picWheel.Image = My.Resources.c22
        ElseIf CDbl(txtTicks.Text) = 23 Then
            picWheel.Image = My.Resources.c23
        ElseIf CDbl(txtTicks.Text) = 24 Then
            picWheel.Image = My.Resources.c24
        ElseIf CDbl(txtTicks.Text) = 25 Then
            picWheel.Image = My.Resources.c25


        ElseIf CDbl(txtTicks.Text) = 26 Then
            picWheel.Image = My.Resources.c2
        ElseIf CDbl(txtTicks.Text) = 27 Then
            picWheel.Image = My.Resources.c3
        ElseIf CDbl(txtTicks.Text) = 28 Then
            picWheel.Image = My.Resources.c4
        ElseIf CDbl(txtTicks.Text) = 29 Then
            picWheel.Image = My.Resources.c5
        ElseIf CDbl(txtTicks.Text) = 30 Then
            picWheel.Image = My.Resources.c6
        ElseIf CDbl(txtTicks.Text) = 31 Then
            picWheel.Image = My.Resources.c7
        ElseIf CDbl(txtTicks.Text) = 32 Then
            picWheel.Image = My.Resources.c8
        ElseIf CDbl(txtTicks.Text) = 33 Then
            picWheel.Image = My.Resources.c9
        ElseIf CDbl(txtTicks.Text) = 34 Then
            picWheel.Image = My.Resources.c10
        ElseIf CDbl(txtTicks.Text) = 35 Then
            picWheel.Image = My.Resources.c11
        ElseIf CDbl(txtTicks.Text) = 36 Then
            picWheel.Image = My.Resources.c12
        ElseIf CDbl(txtTicks.Text) = 37 Then
            picWheel.Image = My.Resources.c13
        ElseIf CDbl(txtTicks.Text) = 38 Then
            picWheel.Image = My.Resources.c14
        ElseIf CDbl(txtTicks.Text) = 39 Then
            picWheel.Image = My.Resources.c15
        ElseIf CDbl(txtTicks.Text) = 40 Then
            picWheel.Image = My.Resources.c16
        ElseIf CDbl(txtTicks.Text) = 41 Then
            picWheel.Image = My.Resources.c17
        ElseIf CDbl(txtTicks.Text) = 42 Then
            picWheel.Image = My.Resources.c18
        ElseIf CDbl(txtTicks.Text) = 43 Then
            picWheel.Image = My.Resources.c19
        ElseIf CDbl(txtTicks.Text) = 44 Then
            picWheel.Image = My.Resources.c20
        ElseIf CDbl(txtTicks.Text) = 45 Then
            picWheel.Image = My.Resources.c21
        ElseIf CDbl(txtTicks.Text) = 46 Then
            picWheel.Image = My.Resources.c22
        ElseIf CDbl(txtTicks.Text) = 47 Then
            picWheel.Image = My.Resources.c23
        ElseIf CDbl(txtTicks.Text) = 48 Then
            picWheel.Image = My.Resources.c24
        ElseIf CDbl(txtTicks.Text) = 49 Then
            picWheel.Image = My.Resources.c25
        End If



    End Sub
    Private Sub GetSpins()
        Me.Visible = False
        Form2.Visible = True



        word = rand.Next(1, 25)






        If word = 1 Then
            picWheel.Image = My.Resources.c1
        ElseIf word = 2 Then
            picWheel.Image = My.Resources.c2
        ElseIf word = 3 Then
            picWheel.Image = My.Resources.c3
        ElseIf word = 4 Then
            picWheel.Image = My.Resources.c4
        ElseIf word = 5 Then
            picWheel.Image = My.Resources.c5
        ElseIf word = 6 Then
            picWheel.Image = My.Resources.c6
        ElseIf word = 7 Then
            picWheel.Image = My.Resources.c7
        ElseIf word = 8 Then
            picWheel.Image = My.Resources.c8
        ElseIf word = 9 Then
            picWheel.Image = My.Resources.c9
        ElseIf word = 10 Then
            picWheel.Image = My.Resources.c10
        ElseIf word = 11 Then
            picWheel.Image = My.Resources.c11
        ElseIf word = 12 Then
            picWheel.Image = My.Resources.c12
        ElseIf word = 13 Then
            picWheel.Image = My.Resources.c13
        ElseIf word = 14 Then
            picWheel.Image = My.Resources.c14
        ElseIf word = 15 Then
            picWheel.Image = My.Resources.c15
        ElseIf word = 16 Then
            picWheel.Image = My.Resources.c16
        ElseIf word = 17 Then
            picWheel.Image = My.Resources.c17
        ElseIf word = 18 Then
            picWheel.Image = My.Resources.c18
        ElseIf word = 19 Then
            picWheel.Image = My.Resources.c19
        ElseIf word = 20 Then
            picWheel.Image = My.Resources.c20
        ElseIf word = 21 Then
            picWheel.Image = My.Resources.c21
        ElseIf word = 22 Then
            picWheel.Image = My.Resources.c22
        ElseIf word = 23 Then
            picWheel.Image = My.Resources.c23
        ElseIf word = 24 Then
            picWheel.Image = My.Resources.c24
        ElseIf word = 25 Then
            picWheel.Image = My.Resources.c25

        End If


        If word = 1 Then
            lblRolled.Text = (2000).ToString
        ElseIf word = 2 Then
            lblRolled.Text = (2000).ToString
        ElseIf word = 3 Then
            lblRolled.Text = "Turn Skipped"
        ElseIf word = 4 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 5 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 6 Then
            lblRolled.Text = "Bankrupt"
        ElseIf word = 7 Then
            lblRolled.Text = (10000).ToString
        ElseIf word = 8 Then
            lblRolled.Text = "Turn Skipped"
        ElseIf word = 9 Then
            lblRolled.Text = (5000).ToString
        ElseIf word = 10 Then
            lblRolled.Text = (2000).ToString
        ElseIf word = 11 Then
            lblRolled.Text = "Turn Skipped"
        ElseIf word = 12 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 13 Then
            lblRolled.Text = "Bankrupt"
        ElseIf word = 14 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 15 Then
            lblRolled.Text = "Turn Skipped"
        ElseIf word = 16 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 17 Then
            lblRolled.Text = (2000).ToString
        ElseIf word = 18 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 19 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 20 Then
            lblRolled.Text = "Turn Skipped"
        ElseIf word = 21 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 22 Then
            lblRolled.Text = (5000).ToString
        ElseIf word = 23 Then
            lblRolled.Text = (2000).ToString
        ElseIf word = 24 Then
            lblRolled.Text = (1000).ToString
        ElseIf word = 25 Then
            lblRolled.Text = (1000).ToString
        End If




        txtTicks.Text = (0).ToString
        txtTrue.Text = (0).ToString




    End Sub

    Private Sub GetGoS()
        lblWould.Visible = True
        btnG2.Visible = True
        btnS2.Visible = True


        btnWheel.Visible = False
        picArrow.Visible = False
        picWheel.Visible = False
        btnSpin.Visible = False
        btnGuess.Visible = False


        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnE.Enabled = False
        btnF.Enabled = False
        btnG.Enabled = False
        btnH.Enabled = False
        btnI.Enabled = False
        btnJ.Enabled = False
        btnK.Enabled = False
        btnL.Enabled = False
        btnM.Enabled = False
        btnN.Enabled = False
        btnO.Enabled = False
        btnP.Enabled = False
        btnQ.Enabled = False
        btnR.Enabled = False
        btnS.Enabled = False
        btnT.Enabled = False
        btnU.Enabled = False
        btnV.Enabled = False
        btnW.Enabled = False
        btnX.Enabled = False
        btnY.Enabled = False
        btnZ.Enabled = False


        txtWord.Visible = False
        txtSolve.Visible = False
        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False
        btnE.Visible = False
        btnF.Visible = False
        btnG.Visible = False
        btnH.Visible = False
        btnI.Visible = False
        btnJ.Visible = False
        btnK.Visible = False
        btnL.Visible = False
        btnM.Visible = False
        btnN.Visible = False
        btnO.Visible = False
        btnP.Visible = False
        btnQ.Visible = False
        btnR.Visible = False
        btnS.Visible = False
        btnT.Visible = False
        btnU.Visible = False
        btnV.Visible = False
        btnW.Visible = False
        btnX.Visible = False
        btnY.Visible = False
        btnZ.Visible = False
        btnSolve.Visible = False


    End Sub
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click

        lblRd.Visible = False
        lblRolled.Visible = False
        lblTD.Visible = False
        lblTotal.Visible = False
        btnGen.Visible = False

        GetGoS()




    End Sub

    Private Sub NewGame()


        txtWord.Text = String.Empty
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True



        If CDbl(txtD.Text) = 2 Then
            Dim intRandNum As Integer
            Dim Randgen As New Random
            Dim intUpper As Integer
            Dim randWord As String
            intUpper = IO.File.ReadAllLines("C:\Users\bjackson8833\Desktop\vb data files\7\Capstone 7\Capstone 7\txt.txt").Count
            If intUpper = 0 Then
                MsgBox("There are no words in this file")
            End If

            intRandNum = Randgen.Next(0, intUpper)
            randWord = IO.File.ReadAllLines("C:\Users\bjackson8833\Desktop\vb data files\7\Capstone 7\Capstone 7\txt.txt").ElementAt(intRandNum).ToString
            strWord = randWord
            strWordR = randWord
            For intIndex As Integer = 0 To randWord.Length - 1
                If randWord(intIndex) = Space(1) Then
                    txtWord.Text = txtWord.Text + " "
                Else
                    txtWord.Text = txtWord.Text + "_"
                End If
            Next
        End If
        TurnState = 1



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub CheckLetter(ByVal strinput As String)
        Dim strLetter As String
        Dim strResult As String
        strLetter = strinput.Trim.ToUpper
        strResult = txtWord.Text
        If strWord.Contains(strLetter) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex, 1)
                    strResult = strResult.Insert(intIndex, strLetter)
                End If
            Next
            ' Display the contents of strResult.
            txtWord.Text = strResult
            ' Determine whether strResult contains any hyphens.
            If TurnState = 1 Then
                lblOnecount.Text = countOne.ToString
                lblOnecount.Text = (countOne + dblValue).ToString("C2")
                countOne = CDbl(lblOnecount.Text)
            ElseIf TurnState = 2 Then
                lblTwocount.Text = countTwo.ToString
                lblTwocount.Text = (countTwo + dblValue).ToString("C2")
                countTwo = CDbl(lblTwocount.Text)
            End If
            If strResult.Contains("_") = False Then
                Winstate()
            End If
        Else
            If TurnState = 1 Then
                TurnState = 2
            ElseIf TurnState = 2 Then
                TurnState = 1
            End If
            changeTurn()
        End If




    End Sub




    Private Sub Winstate()
        If TurnState = 1 Then
            Dim dlgbutton As DialogResult
            dlgbutton = MessageBox.Show("Player 1 Won!The word/phrase was 
" + strWordR + "! Start a New Round?", "Wheel Of 
Fortune!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation)
            If dlgbutton = DialogResult.Yes Then
                NewGameN()
                NewGame()
            ElseIf dlgbutton = DialogResult.No Then
                frmExtra.Close()

                Me.Close()
            End If
        ElseIf TurnState = 2 Then
            Dim dlgbutton As DialogResult
            dlgbutton = MessageBox.Show("Player 2 Won!The word/phrase was 
" + strWordR + "! Start a New Round?", "Wheel Of 
Fortune!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation)
            If dlgbutton = DialogResult.Yes Then
                NewGameN()
                NewGame()
            ElseIf dlgbutton = DialogResult.No Then
                frmExtra.Close()

                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        txtD.Text = "2"
        NewGame()
    End Sub
    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Dim strSA As String = txtSolve.Text.ToString
        If strSA.ToString.ToUpper = strWord.ToUpper Then
            Winstate()
        ElseIf strSA.ToString.ToUpper <> strWord.ToUpper Then
            If TurnState = 1 Then
                TurnState = 2
                Winstate()
            Else
                TurnState = 1
                Winstate()
            End If
        End If
        txtSolve.Text = String.Empty
    End Sub


    Private Sub changeTurn()
        frmExtra.Visible = True
        If TurnState = 1 Then
            frmExtra.lblTitle.Text = "Hi Player 1, Would You like to.."
        ElseIf TurnState = 2 Then
            frmExtra.lblTitle.Text = "Hi Player 2, Would You like to.."
        End If
    End Sub


    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        btnA.Enabled = False
        CheckLetter("A")
    End Sub
    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        btnB.Enabled = False
        CheckLetter("B")
    End Sub
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnC.Enabled = False
        CheckLetter("C")
    End Sub
    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        btnD.Enabled = False
        CheckLetter("D")
    End Sub
    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        btnE.Enabled = False
        CheckLetter("E")
    End Sub
    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        btnF.Enabled = False
        CheckLetter("F")
    End Sub
    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        btnG.Enabled = False
        CheckLetter("G")
    End Sub
    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        btnH.Enabled = False
        CheckLetter("H")
    End Sub
    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        btnI.Enabled = False
        CheckLetter("I")
    End Sub
    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        btnJ.Enabled = False
        CheckLetter("J")
    End Sub
    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        btnK.Enabled = False
        CheckLetter("K")
    End Sub
    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        btnL.Enabled = False
        CheckLetter("L")
    End Sub
    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        btnM.Enabled = False
        CheckLetter("M")
    End Sub
    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        btnN.Enabled = False
        CheckLetter("N")
    End Sub
    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        btnO.Enabled = False
        CheckLetter("O")
    End Sub
    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        btnP.Enabled = False
        CheckLetter("P")
    End Sub
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        btnQ.Enabled = False
        CheckLetter("Q")
    End Sub
    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        btnR.Enabled = False
        CheckLetter("R")
    End Sub
    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        btnS.Enabled = False
        CheckLetter("S")
    End Sub
    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        btnT.Enabled = False
        CheckLetter("T")
    End Sub
    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        btnU.Enabled = False
        CheckLetter("U")
    End Sub
    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        btnV.Enabled = False
        CheckLetter("V")
    End Sub
    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        btnW.Enabled = False
        CheckLetter("W")
    End Sub
    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        btnX.Enabled = False
        CheckLetter("X")
    End Sub
    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        btnY.Enabled = False
        CheckLetter("Y")
    End Sub
    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        btnZ.Enabled = False
        CheckLetter("Z")
    End Sub

    Private Sub btnWheel_Click(sender As Object, e As EventArgs) Handles btnWheel.Click

        picAD.Visible = False
        btnWheel.Visible = False
        picArrow.Visible = True
        picWheel.Visible = True
        btnSpin.Visible = True
        btnGuess.Visible = True

        txtWord.Visible = False
        txtSolve.Visible = False
        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False
        btnE.Visible = False
        btnF.Visible = False
        btnG.Visible = False
        btnH.Visible = False
        btnI.Visible = False
        btnJ.Visible = False
        btnK.Visible = False
        btnL.Visible = False
        btnM.Visible = False
        btnN.Visible = False
        btnO.Visible = False
        btnP.Visible = False
        btnQ.Visible = False
        btnR.Visible = False
        btnS.Visible = False
        btnT.Visible = False
        btnU.Visible = False
        btnV.Visible = False
        btnW.Visible = False
        btnX.Visible = False
        btnY.Visible = False
        btnZ.Visible = False
        btnSolve.Visible = False
    End Sub


    Private Sub NewGameN()
        lblTotal.Text = ""
        lblRolled.Text = ""
        picArrow.Visible = True
        picWheel.Visible = True
        btnSpin.Visible = True
        btnGuess.Visible = True

        txtWord.Visible = False
        txtSolve.Visible = False
        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False
        btnE.Visible = False
        btnF.Visible = False
        btnG.Visible = False
        btnH.Visible = False
        btnI.Visible = False
        btnJ.Visible = False
        btnK.Visible = False
        btnL.Visible = False
        btnM.Visible = False
        btnN.Visible = False
        btnO.Visible = False
        btnP.Visible = False
        btnQ.Visible = False
        btnR.Visible = False
        btnS.Visible = False
        btnT.Visible = False
        btnU.Visible = False
        btnV.Visible = False
        btnW.Visible = False
        btnX.Visible = False
        btnY.Visible = False
        btnZ.Visible = False
        btnSolve.Visible = False
    End Sub

    Private Sub btnG2_Click(sender As Object, e As EventArgs) Handles btnG2.Click

        btnGen.Visible = True

        lblRd.Visible = True
        lblRolled.Visible = True
        lblTD.Visible = True
        lblTotal.Visible = True


        lblWould.Visible = False
        btnS2.Visible = False
        btnG2.Visible = False
        btnWheel.Visible = True
        picArrow.Visible = False
        picWheel.Visible = False
        btnSpin.Visible = False
        btnGuess.Visible = False


        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True


        txtWord.Visible = True
        txtSolve.Visible = True
        btnA.Visible = True
        btnB.Visible = True
        btnC.Visible = True
        btnD.Visible = True
        btnE.Visible = True
        btnF.Visible = True
        btnG.Visible = True
        btnH.Visible = True
        btnI.Visible = True
        btnJ.Visible = True
        btnK.Visible = True
        btnL.Visible = True
        btnM.Visible = True
        btnN.Visible = True
        btnO.Visible = True
        btnP.Visible = True
        btnQ.Visible = True
        btnR.Visible = True
        btnS.Visible = True
        btnT.Visible = True
        btnU.Visible = True
        btnV.Visible = True
        btnW.Visible = True
        btnX.Visible = True
        btnY.Visible = True
        btnZ.Visible = True
        btnSolve.Visible = True
    End Sub

    Private Sub btnS2_Click(sender As Object, e As EventArgs) Handles btnS2.Click



        picAD.Location = New Point(499, 365)
        txtSolve.Location = New Point(541, 545)
        btnSolve.Location = New Point(541, 571)







        btnGen.Visible = True

        lblRd.Visible = True
        lblRolled.Visible = True
        lblTD.Visible = True
        lblTotal.Visible = True

        lblWould.Visible = False
        btnG2.Visible = False
        btnS2.Visible = False

        txtWord.Visible = True
        txtSolve.Visible = True
        picAD.Visible = True
        btnWheel.Visible = True


        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False
        btnE.Visible = False
        btnF.Visible = False
        btnG.Visible = False
        btnH.Visible = False
        btnI.Visible = False
        btnJ.Visible = False
        btnK.Visible = False
        btnL.Visible = False
        btnM.Visible = False
        btnN.Visible = False
        btnO.Visible = False
        btnP.Visible = False
        btnQ.Visible = False
        btnR.Visible = False
        btnS.Visible = False
        btnT.Visible = False
        btnU.Visible = False
        btnV.Visible = False
        btnW.Visible = False
        btnX.Visible = False
        btnY.Visible = False
        btnZ.Visible = False
        btnSolve.Visible = True

    End Sub
End Class
