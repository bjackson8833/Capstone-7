<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.lblRolled = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTicks = New System.Windows.Forms.TextBox()
        Me.txtTrue = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.picWheel = New System.Windows.Forms.PictureBox()
        Me.picArrow = New System.Windows.Forms.PictureBox()
        Me.picW = New System.Windows.Forms.PictureBox()
        Me.lblTD = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.rtxtbox1 = New System.Windows.Forms.RichTextBox()
        Me.lstboxW = New System.Windows.Forms.ListBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.lblRd = New System.Windows.Forms.Label()
        Me.lblTwocount = New System.Windows.Forms.Label()
        Me.lblOnecount = New System.Windows.Forms.Label()
        Me.txtSolve = New System.Windows.Forms.TextBox()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.btnWheel = New System.Windows.Forms.Button()
        Me.picAD = New System.Windows.Forms.PictureBox()
        Me.btnG2 = New System.Windows.Forms.Button()
        Me.btnS2 = New System.Windows.Forms.Button()
        Me.lblWould = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtReset = New System.Windows.Forms.TextBox()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.txtSo = New System.Windows.Forms.TextBox()
        Me.btnSOLV = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1061, 592)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 37)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSpin
        '
        Me.btnSpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.Location = New System.Drawing.Point(26, 362)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(194, 100)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.Text = "&Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'lblRolled
        '
        Me.lblRolled.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblRolled.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRolled.Location = New System.Drawing.Point(955, 88)
        Me.lblRolled.Name = "lblRolled"
        Me.lblRolled.Size = New System.Drawing.Size(169, 124)
        Me.lblRolled.TabIndex = 5
        '
        'Timer1
        '
        '
        'txtTicks
        '
        Me.txtTicks.Location = New System.Drawing.Point(944, 468)
        Me.txtTicks.Name = "txtTicks"
        Me.txtTicks.Size = New System.Drawing.Size(100, 20)
        Me.txtTicks.TabIndex = 6
        Me.txtTicks.Text = "0"
        Me.txtTicks.Visible = False
        '
        'txtTrue
        '
        Me.txtTrue.Location = New System.Drawing.Point(944, 493)
        Me.txtTrue.Name = "txtTrue"
        Me.txtTrue.Size = New System.Drawing.Size(100, 20)
        Me.txtTrue.TabIndex = 7
        Me.txtTrue.Text = "0"
        Me.txtTrue.Visible = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'picWheel
        '
        Me.picWheel.BackColor = System.Drawing.Color.Transparent
        Me.picWheel.Image = Global.Capstone_7.My.Resources.Resources.c25
        Me.picWheel.Location = New System.Drawing.Point(274, -10)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(664, 523)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWheel.TabIndex = 2
        Me.picWheel.TabStop = False
        '
        'picArrow
        '
        Me.picArrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picArrow.Image = CType(resources.GetObject("picArrow.Image"), System.Drawing.Image)
        Me.picArrow.Location = New System.Drawing.Point(0, 150)
        Me.picArrow.Name = "picArrow"
        Me.picArrow.Size = New System.Drawing.Size(259, 137)
        Me.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrow.TabIndex = 1
        Me.picArrow.TabStop = False
        '
        'picW
        '
        Me.picW.BackColor = System.Drawing.Color.Transparent
        Me.picW.Location = New System.Drawing.Point(274, -10)
        Me.picW.Name = "picW"
        Me.picW.Size = New System.Drawing.Size(664, 523)
        Me.picW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW.TabIndex = 2
        Me.picW.TabStop = False
        '
        'lblTD
        '
        Me.lblTD.AutoSize = True
        Me.lblTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTD.Location = New System.Drawing.Point(944, 245)
        Me.lblTD.Name = "lblTD"
        Me.lblTD.Size = New System.Drawing.Size(225, 42)
        Me.lblTD.TabIndex = 8
        Me.lblTD.Text = "Total Points:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(955, 298)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(169, 124)
        Me.lblTotal.TabIndex = 9
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(420, 529)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(323, 100)
        Me.btnGuess.TabIndex = 10
        Me.btnGuess.Text = "&Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnGen
        '
        Me.btnGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGen.Location = New System.Drawing.Point(26, 12)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(200, 113)
        Me.btnGen.TabIndex = 11
        Me.btnGen.Text = "Generate Word"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'rtxtbox1
        '
        Me.rtxtbox1.Location = New System.Drawing.Point(1035, 12)
        Me.rtxtbox1.Name = "rtxtbox1"
        Me.rtxtbox1.Size = New System.Drawing.Size(100, 96)
        Me.rtxtbox1.TabIndex = 12
        Me.rtxtbox1.Text = ""
        Me.rtxtbox1.Visible = False
        '
        'lstboxW
        '
        Me.lstboxW.FormattingEnabled = True
        Me.lstboxW.Location = New System.Drawing.Point(951, 1)
        Me.lstboxW.Name = "lstboxW"
        Me.lstboxW.Size = New System.Drawing.Size(81, 30)
        Me.lstboxW.TabIndex = 13
        Me.lstboxW.Visible = False
        '
        'txtWord
        '
        Me.txtWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.Location = New System.Drawing.Point(289, 117)
        Me.txtWord.Multiline = True
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(624, 196)
        Me.txtWord.TabIndex = 14
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(289, 436)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(36, 23)
        Me.btnA.TabIndex = 15
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(331, 436)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(36, 23)
        Me.btnB.TabIndex = 16
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(373, 436)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(36, 23)
        Me.btnC.TabIndex = 17
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(415, 436)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(36, 23)
        Me.btnD.TabIndex = 18
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(457, 436)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(36, 23)
        Me.btnE.TabIndex = 19
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(499, 436)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(36, 23)
        Me.btnF.TabIndex = 20
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Location = New System.Drawing.Point(541, 436)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(36, 23)
        Me.btnG.TabIndex = 21
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Location = New System.Drawing.Point(583, 436)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(36, 23)
        Me.btnH.TabIndex = 22
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Location = New System.Drawing.Point(625, 436)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(36, 23)
        Me.btnI.TabIndex = 23
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Location = New System.Drawing.Point(667, 436)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(36, 23)
        Me.btnJ.TabIndex = 24
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.Location = New System.Drawing.Point(707, 436)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(36, 23)
        Me.btnK.TabIndex = 25
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.Location = New System.Drawing.Point(749, 465)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(36, 23)
        Me.btnY.TabIndex = 26
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.Location = New System.Drawing.Point(749, 436)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(36, 23)
        Me.btnL.TabIndex = 27
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.Location = New System.Drawing.Point(791, 436)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(36, 23)
        Me.btnM.TabIndex = 28
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.Location = New System.Drawing.Point(791, 465)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(36, 23)
        Me.btnZ.TabIndex = 29
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Location = New System.Drawing.Point(289, 465)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(36, 23)
        Me.btnN.TabIndex = 30
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Location = New System.Drawing.Point(331, 465)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(36, 23)
        Me.btnO.TabIndex = 31
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.Location = New System.Drawing.Point(373, 465)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(36, 23)
        Me.btnP.TabIndex = 32
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.Location = New System.Drawing.Point(415, 465)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(36, 23)
        Me.btnQ.TabIndex = 33
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(457, 465)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(36, 23)
        Me.btnR.TabIndex = 34
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(499, 465)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(36, 23)
        Me.btnS.TabIndex = 35
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(541, 465)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(36, 23)
        Me.btnT.TabIndex = 36
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Location = New System.Drawing.Point(583, 465)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(36, 23)
        Me.btnU.TabIndex = 37
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Location = New System.Drawing.Point(625, 465)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(36, 23)
        Me.btnV.TabIndex = 38
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Location = New System.Drawing.Point(667, 465)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(36, 23)
        Me.btnW.TabIndex = 39
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(709, 465)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(36, 23)
        Me.btnX.TabIndex = 40
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(26, 493)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(53, 20)
        Me.txtD.TabIndex = 41
        Me.txtD.Visible = False
        '
        'lblRd
        '
        Me.lblRd.AutoSize = True
        Me.lblRd.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRd.Location = New System.Drawing.Point(944, 31)
        Me.lblRd.Name = "lblRd"
        Me.lblRd.Size = New System.Drawing.Size(134, 42)
        Me.lblRd.TabIndex = 4
        Me.lblRd.Text = "Rolled:"
        '
        'lblTwocount
        '
        Me.lblTwocount.AutoSize = True
        Me.lblTwocount.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwocount.Location = New System.Drawing.Point(-7, 298)
        Me.lblTwocount.Name = "lblTwocount"
        Me.lblTwocount.Size = New System.Drawing.Size(0, 42)
        Me.lblTwocount.TabIndex = 42
        Me.lblTwocount.Visible = False
        '
        'lblOnecount
        '
        Me.lblOnecount.AutoSize = True
        Me.lblOnecount.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnecount.Location = New System.Drawing.Point(125, 317)
        Me.lblOnecount.Name = "lblOnecount"
        Me.lblOnecount.Size = New System.Drawing.Size(0, 42)
        Me.lblOnecount.TabIndex = 43
        Me.lblOnecount.Visible = False
        '
        'txtSolve
        '
        Me.txtSolve.Location = New System.Drawing.Point(828, 436)
        Me.txtSolve.Name = "txtSolve"
        Me.txtSolve.Size = New System.Drawing.Size(110, 20)
        Me.txtSolve.TabIndex = 44
        Me.txtSolve.Visible = False
        '
        'btnSolve
        '
        Me.btnSolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolve.Location = New System.Drawing.Point(833, 465)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(94, 41)
        Me.btnSolve.TabIndex = 45
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnWheel
        '
        Me.btnWheel.Location = New System.Drawing.Point(26, 317)
        Me.btnWheel.Name = "btnWheel"
        Me.btnWheel.Size = New System.Drawing.Size(93, 42)
        Me.btnWheel.TabIndex = 46
        Me.btnWheel.Text = "Wheel"
        Me.btnWheel.UseVisualStyleBackColor = True
        '
        'picAD
        '
        Me.picAD.Image = CType(resources.GetObject("picAD.Image"), System.Drawing.Image)
        Me.picAD.Location = New System.Drawing.Point(791, 272)
        Me.picAD.Name = "picAD"
        Me.picAD.Size = New System.Drawing.Size(186, 158)
        Me.picAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAD.TabIndex = 47
        Me.picAD.TabStop = False
        Me.picAD.Visible = False
        '
        'btnG2
        '
        Me.btnG2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG2.Location = New System.Drawing.Point(357, 323)
        Me.btnG2.Name = "btnG2"
        Me.btnG2.Size = New System.Drawing.Size(220, 107)
        Me.btnG2.TabIndex = 48
        Me.btnG2.Text = "Guess"
        Me.btnG2.UseVisualStyleBackColor = True
        '
        'btnS2
        '
        Me.btnS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS2.Location = New System.Drawing.Point(625, 323)
        Me.btnS2.Name = "btnS2"
        Me.btnS2.Size = New System.Drawing.Size(220, 107)
        Me.btnS2.TabIndex = 49
        Me.btnS2.Text = "Solve"
        Me.btnS2.UseVisualStyleBackColor = True
        '
        'lblWould
        '
        Me.lblWould.AutoSize = True
        Me.lblWould.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWould.Location = New System.Drawing.Point(150, 221)
        Me.lblWould.Name = "lblWould"
        Me.lblWould.Size = New System.Drawing.Size(985, 73)
        Me.lblWould.TabIndex = 50
        Me.lblWould.Text = "Would you like to guess or solve?"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(163, 104)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 53
        Me.txtSearch.Visible = False
        '
        'txtReset
        '
        Me.txtReset.Location = New System.Drawing.Point(144, 529)
        Me.txtReset.Name = "txtReset"
        Me.txtReset.Size = New System.Drawing.Size(100, 20)
        Me.txtReset.TabIndex = 54
        Me.txtReset.Visible = False
        '
        'lblP1
        '
        Me.lblP1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.Location = New System.Drawing.Point(955, 298)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(169, 124)
        Me.lblP1.TabIndex = 55
        Me.lblP1.Visible = False
        '
        'lblP2
        '
        Me.lblP2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.Location = New System.Drawing.Point(955, 298)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(169, 124)
        Me.lblP2.TabIndex = 56
        Me.lblP2.Visible = False
        '
        'txtSo
        '
        Me.txtSo.Location = New System.Drawing.Point(530, 310)
        Me.txtSo.Name = "txtSo"
        Me.txtSo.Size = New System.Drawing.Size(100, 20)
        Me.txtSo.TabIndex = 57
        Me.txtSo.Visible = False
        '
        'btnSOLV
        '
        Me.btnSOLV.Location = New System.Drawing.Point(43, 605)
        Me.btnSOLV.Name = "btnSOLV"
        Me.btnSOLV.Size = New System.Drawing.Size(75, 23)
        Me.btnSOLV.TabIndex = 58
        Me.btnSOLV.Text = "SOLVE"
        Me.btnSOLV.UseVisualStyleBackColor = True
        Me.btnSOLV.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1161, 641)
        Me.Controls.Add(Me.btnSOLV)
        Me.Controls.Add(Me.txtSo)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.txtReset)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblWould)
        Me.Controls.Add(Me.btnS2)
        Me.Controls.Add(Me.btnG2)
        Me.Controls.Add(Me.picAD)
        Me.Controls.Add(Me.btnWheel)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.txtSolve)
        Me.Controls.Add(Me.lblOnecount)
        Me.Controls.Add(Me.lblTwocount)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnW)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnQ)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnO)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.btnZ)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.btnL)
        Me.Controls.Add(Me.btnY)
        Me.Controls.Add(Me.btnK)
        Me.Controls.Add(Me.btnJ)
        Me.Controls.Add(Me.btnI)
        Me.Controls.Add(Me.btnH)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lstboxW)
        Me.Controls.Add(Me.rtxtbox1)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTD)
        Me.Controls.Add(Me.txtTrue)
        Me.Controls.Add(Me.txtTicks)
        Me.Controls.Add(Me.lblRolled)
        Me.Controls.Add(Me.lblRd)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picWheel)
        Me.Controls.Add(Me.picArrow)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMain"
        Me.Text = "Wheel Of Fortune"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents picArrow As PictureBox
    Friend WithEvents picWheel As PictureBox
    Friend WithEvents btnSpin As Button
    Friend WithEvents picW As PictureBox
    Friend WithEvents lblRolled As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtTicks As TextBox
    Friend WithEvents txtTrue As TextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTD As Label
    Friend WithEvents btnGuess As Button
    Friend WithEvents btnGen As Button
    Friend WithEvents rtxtbox1 As RichTextBox
    Friend WithEvents lstboxW As ListBox
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnX As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
    Friend WithEvents txtD As TextBox
    Friend WithEvents lblOnecount As Label
    Friend WithEvents lblTwocount As Label
    Friend WithEvents lblRd As Label
    Friend WithEvents txtSolve As TextBox
    Friend WithEvents btnSolve As Button
    Friend WithEvents btnWheel As Button
    Friend WithEvents picAD As PictureBox
    Friend WithEvents btnG2 As Button
    Friend WithEvents btnS2 As Button
    Friend WithEvents lblWould As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtReset As TextBox
    Friend WithEvents lblP2 As Label
    Friend WithEvents lblP1 As Label
    Friend WithEvents txtSo As TextBox
    Friend WithEvents btnSOLV As Button
End Class
