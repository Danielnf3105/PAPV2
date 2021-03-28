VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   1590
   ClientLeft      =   6015
   ClientTop       =   4230
   ClientWidth     =   3720
   LinkTopic       =   "Form1"
   ScaleHeight     =   1590
   ScaleWidth      =   3720
   Begin VB.VScrollBar vsbCount 
      Height          =   735
      Left            =   2280
      Max             =   10
      Min             =   1
      TabIndex        =   1
      Top             =   300
      Value           =   1
      Width           =   255
   End
   Begin VB.Label lblCount 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   1140
      TabIndex        =   0
      Top             =   300
      Width           =   1215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub vsbCount_Change()
    lblCount.Caption = vsbCount.Value
End Sub
