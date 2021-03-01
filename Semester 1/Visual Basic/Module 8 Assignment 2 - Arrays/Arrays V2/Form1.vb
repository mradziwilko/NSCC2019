'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
' Program: Arrays v2
' Date: 12/8/2019
' Author: Marshall Radziwilko
' Operation: 
' Add Data
'   Allow the user To enter an instructor name In one text box And a classroom In the 
'   second text box. When the Add button Is clicked, the Next available position In the 
'   arrays will be used To store the data. The same index In both arrays will be used 
'   To store the data. ex Dave MacDonald (Index 0 In array 1)  ,   B304 (Index 0 In array 2)    
'   Add a check To scan For the instructor name In the array prior To adding it To the 
'   array, If the instructor's name is found, a messagbox should be displayed informing the 
'   user the entry already exists informing them of the room number.
' Search Data
'   The second button And third text box should allow the user To search the array For entries. 
'   Use the radio button To allow either the Instructor name array Or the classroom array To be 
'   searched.If an entry Is found In one, a message box should be displayed containing the instructor 
'   name As well As what classroom they are assigned To For the day. If an entry Is Not found, 
'   show a corresponding message.' 
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'12/8/2019 - Created First Illituration - Marshall Radziwilko
'-----------------------------------------------------------------------------
Public Class Form1
    ' Declare Arrays
    Dim arrTeacher(9) As String
    Dim arrClass(9) As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Try
            ' Declare Local Variables
            Dim valTeacher As String = inpInstructor.Text
            Dim valClassroom As String = inpClassroom.Text
            Dim int_Index As Integer
            Dim int_LastValue As String = Nothing

            ' If Empty Show Errors
            If valTeacher = "" Then
                MsgBox("Teacher Empty")
                valTeacher = ""
                valClassroom = ""
                Return
            ElseIf valClassroom = "" Then
                MsgBox("Classroom Empty")
                valTeacher = ""
                valClassroom = ""
                Return
            Else
                ' Check if Teacher Exists
                Dim TeachFind As Boolean = chkExists(valTeacher, "t")

                If TeachFind = False Then
                    ' If False add teacher + Classroom to arrays
                    arrTeacher(int_Index) = valTeacher
                    arrClass(int_Index) = valClassroom
                    valTeacher = ""
                    valClassroom = ""
                    Return

                Else
                    ' Notify Teacher was found.
                    Dim ClassFind As String = FindClass(valTeacher)
                    MsgBox($"{valTeacher} was Found in class {ClassFind}.")
                End If



            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub




    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        'Variable declarations
        Dim idx_Search As Integer
        Dim searchArray(9) As String
        Dim SearchTxt As String = inpSearch.Text
        Dim SearchChk As Boolean = False
        Try

            ' Check if Item exist
            SearchChk = ChkSearch(SearchTxt)


            ' True = Add to temp array values, search array
            If SearchChk = True Then


                Select Case True
                    Case rbInstructor.Checked
                        arrTeacher.CopyTo(searchArray, 0)
                    Case rbClassroom.Checked
                        arrClass.CopyTo(searchArray, 0)
                End Select


                ' Search Array for current text, make sure very text is same. Can be lower or upper
                For idx_Search = 0 To searchArray.Count - 1
                    If Not (searchArray(idx_Search) = Nothing) Then
                        If SearchTxt.ToUpper = searchArray(idx_Search).ToUpper Then
                            MsgBox($"{arrTeacher(idx_Search)} is teaching in classroom {arrClass(idx_Search)}")

                            Exit For
                        ElseIf SearchTxt = "" Then
                            ' If empty Do nothing, already checked just eliminating it from choice.
                        Else
                            ' Say nothing found
                            MsgBox("Nothing was found.")

                        End If
                    End If
                Next

            End If


        Catch oorEx As IndexOutOfRangeException
            MsgBox("An invalid index was specified: " & oorEx.Message)
        Catch ex As Exception
            MsgBox("A General error occurred. We're looking into it")
        End Try


    End Sub



    '  Check if Person was found in array, if it was return True, else return always false.
    Function ChkSearch(srchText As String) As Boolean
        If Trim(srchText) = Nothing Then
            MsgBox("Please enter a search term")
            Me.inpSearch.Focus()
            Return False
        Else
            Return True
        End If
    End Function


    ' Initial Check if Teacher is in Database, or Class is in use.
    Function chkExists(Value As String, type As String) As Boolean
        Dim tmpBool As Boolean = False

        If type = "t" Then


            For int_Index = 0 To arrTeacher.Length - 1
                If arrTeacher(int_Index) = Value Then
                    tmpBool = True
                Else
                    tmpBool = False
                End If
                Exit For
            Next

        ElseIf type = "c" Then

            For int_Index = 0 To arrTeacher.Length - 1
                If arrClass(int_Index) = Value Then
                    tmpBool = True
                Else
                    tmpBool = False
                End If
                Exit For
            Next

        End If


        Return tmpBool
    End Function


    ' Return Class for teacher used when creating new entries in database.
    Function FindClass(teacher As String) As String
        Dim retInfo As String = "None"
        For int_Index = 0 To arrTeacher.Length - 1
            If arrTeacher(int_Index) = teacher Then
                retInfo = arrClass(int_Index)
            End If
            Exit For
        Next
        Return retInfo
    End Function



End Class
