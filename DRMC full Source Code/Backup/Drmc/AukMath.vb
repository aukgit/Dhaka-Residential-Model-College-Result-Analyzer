Public Class AukMath

    'Option Explicit

    '
    ' clsExpression - Mathematical Expression Parser
    ' By Elad Rosenheim
    '
    ' Read the readme.txt file first to have a grasp of
    ' what goes on in here.
    '
    ' I advise you to try the parser with many expressions,
    ' including ones with syntax errors in them.
    '

    Private Const PI As Double = 3.14159265358979

    ' A generic error text to raise when there's no specific text
    Private Const GENERIC_SYNTAX_ERR_MSG As String = "Syntax Error"

    ' Parser Error codes
    ' The values PERR_FIRST and PERR_LAST allow the client app
    ' to test whether the error is a parser error or VB error
    ' See the demo form
    Public Enum ParserErrors
        PERR_FIRST = vbObjectError + 513
        PERR_SYNTAX_ERROR = ParserErrors.PERR_FIRST
        PERR_DIVISION_BY_ZERO
        PERR_CLOSING_PARENTHESES_EXPECTED
        PERR_INVALID_CONST_NAME
        PERR_FUNCTION_DOES_NOT_EXIST
        PERR_RESERVED_WORD
        PERR_CONST_ALREADY_EXISTS
        PERR_CONST_DOES_NOT_EXIST
        PERR_LAST = ParserErrors.PERR_CONST_DOES_NOT_EXIST
    End Enum

    ' Tokens (Operators) supported by the parser.
    Private Enum ParserTokens
        TOK_UNKNOWN
        TOK_FIRST
        TOK_ADD = ParserTokens.TOK_FIRST
        TOK_SUBTRACT
        TOK_MULTIPLY
        TOK_DIVIDE
        TOK_OPEN_PARENTHESES
        TOK_CLOSE_PARENTHESES
        TOK_LAST = ParserTokens.TOK_CLOSE_PARENTHESES
    End Enum

    ' This array holds the symbols used to represent operators.
    ' You may change them. For example, if you add a "not equal"
    ' operator, you may use '!=' or '<>' symbols for it
    Private mTokenSymbols() As String

    Private mExpression As String
    ' Current position where the parser is in the expression
    Private mPosition As Integer
    Private mLastTokenLength As Integer

    ' Holds user-defined and built-in constants
    Private mConstants As Collection

    ' Holds the VB Project name - used by error handling code
    Private mProjectName As String

    ' This function is the top-level parsing function, exposed
    ' to the client. Its sole logic is to check that there's no
    ' garbage at the end of the expression, since ParseNumExp
    ' and all the lower level function return when they
    ' run into something they don't identify - That's what runs
    ' the whole magic
    Public Function ParseExpression(ByRef Expression As String) As Double
        On Error GoTo ParseExpression_ErrHandler

        Dim Value As Double
        'If Trim(Expression) = "" Then
        '    Expression = 0
        '    Exit Function
        'End If
        mExpression = Expression
        mPosition = 1

        SkipSpaces()
        Value = ParseNumExp()
        SkipSpaces()

        ' If ParseNumExp didn't parse the whole expression,
        ' it means there's some garbage at the end
        If mPosition <= Len(mExpression) Then
            Err.Raise(ParserErrors.PERR_SYNTAX_ERROR, , GENERIC_SYNTAX_ERR_MSG)
        End If

        ParseExpression = Value
        Exit Function

ParseExpression_ErrHandler:
        ' The following call sets err.Source to the function
        ' name. If the error was raised by ParseNumExp, this
        ' function's name will be added to the existing
        ' err.Source, so the client can see exactly how the
        ' call stack looked like when the error occured
        SetErrSource("ParseExpression")
        Err.Raise(Err.Number)
    End Function

    ' This function handles -/+ binary operations
    Private Function ParseNumExp() As Double
        On Error GoTo ParseNumExp_ErrHandler

        Dim Value As Double
        Dim OtherValue As Double
        Dim CurrToken As ParserTokens

        ' ParseTerm knows how to handle * and / operators,
        ' which must be executed first
        Value = ParseTerm()

        ' While we didn't reach the expression's end,
        ' check for more +/- operators
        Do While mPosition <= Len(mExpression)

            ' GetToken just gives us a peek at the next token,
            ' It does not change the current position. We skip
            ' over the token ONLY IF WE CAN HANDLE IT in this
            ' function's scope
            CurrToken = GetToken()

            If CurrToken = ParserTokens.TOK_ADD Then
                ' We can handle the token, so let's skip over it
                ' and find the "other side" of the + operation
                SkipLastToken()
                OtherValue = ParseTerm()
                Value = Value + OtherValue
            ElseIf CurrToken = ParserTokens.TOK_SUBTRACT Then
                SkipLastToken()
                OtherValue = ParseTerm()
                Value = Value - OtherValue
            ElseIf CurrToken = ParserTokens.TOK_UNKNOWN Then
                Err.Raise(ParserErrors.PERR_SYNTAX_ERROR, , GENERIC_SYNTAX_ERR_MSG)
            Else
                ' The operator is one not in the responsibility
                ' of this function - we can return up
                ParseNumExp = Value
                Exit Function
            End If
        Loop

        ParseNumExp = Value
        Exit Function

ParseNumExp_ErrHandler:
        SetErrSource("ParseNumExp")
        Err.Raise(Err.Number)
    End Function

    ' This function handles -/+ binary operations
    ' It is almost exactly the same as ParseNumExp
    Private Function ParseTerm() As Double
        On Error GoTo ParseTerm_ErrHandler

        Dim Value As Double
        Dim OtherValue As Double
        Dim CurrToken As ParserTokens

        Value = ParseValue()

        ' While we didn't reach the expression's end,
        ' check for more * or / operators
        Do While mPosition <= Len(mExpression)

            CurrToken = GetToken()

            If CurrToken = ParserTokens.TOK_MULTIPLY Then
                SkipLastToken()

                OtherValue = ParseValue()
                Value = Value * OtherValue
            ElseIf CurrToken = ParserTokens.TOK_DIVIDE Then
                SkipLastToken()

                OtherValue = ParseValue()
                If OtherValue = 0 Then
                    Err.Raise(ParserErrors.PERR_DIVISION_BY_ZERO, , "Division by Zero!")
                End If

                Value = Value / OtherValue
            ElseIf CurrToken = ParserTokens.TOK_UNKNOWN Then
                Err.Raise(ParserErrors.PERR_SYNTAX_ERROR, , GENERIC_SYNTAX_ERR_MSG)
            Else
                ParseTerm = Value
                Exit Function
            End If
        Loop

        ParseTerm = Value

        Exit Function

ParseTerm_ErrHandler:
        SetErrSource("ParseTerm")
        Err.Raise(Err.Number)
    End Function

    ' This function reads a value that operators work on.
    ' The value can be a number, constant, function or a
    ' complete sub-expression (enclosed in parentheses (1+1) )
    Private Function ParseValue() As Double
        On Error GoTo ParseValue_ErrHandler

        Dim Sign As Double
        Dim CurrToken As ParserTokens
        Dim Value As Double
        Dim IsValue As Boolean

        Sign = 1

        CurrToken = GetToken()
        If CurrToken = ParserTokens.TOK_SUBTRACT Then
            ' We ran into an UNARY minus (like -1), so we
            ' have to multiply the next value with -1
            Sign = -1
            SkipLastToken()
        ElseIf CurrToken = ParserTokens.TOK_ADD Then
            ' Unary plus - no special meaning
            SkipLastToken()
        End If

        CurrToken = GetToken()
        If CurrToken = ParserTokens.TOK_OPEN_PARENTHESES Then
            ' A sub-expression
            SkipLastToken()
            ' Read the value of the sub-expression.
            ' When ParseNumExp runs into the closing parentheses,
            ' it will return (is the syntax is correct).
            Value = ParseNumExp()

            CurrToken = GetToken()
            If CurrToken = ParserTokens.TOK_CLOSE_PARENTHESES Then
                SkipLastToken()
            Else
                ' Where are those closing parentheses ?
                Err.Raise(ParserErrors.PERR_CLOSING_PARENTHESES_EXPECTED, , "')' Expected")
            End If
        Else
            ' No sub-expression - It's an atom
            Value = ParseAtom()
        End If

        ParseValue = Value * Sign
        Exit Function

ParseValue_ErrHandler:
        SetErrSource("ParseValue")
        Err.Raise(Err.Number)
    End Function

    ' ParseAtom knows how to handle numbers, constants
    ' and functions
    Private Function ParseAtom() As Double
        On Error GoTo ParseAtom_ErrHandler

        Dim CurrPosition As Integer
        Dim CurrToken As ParserTokens
        Dim SymbolName As String
        Dim ArgumentValue As Double
        Dim DecimalPointFound As Boolean
        Dim Value As Double
        Dim IsValue As Boolean

        If mPosition > Len(mExpression) Then
            Err.Raise(ParserErrors.PERR_SYNTAX_ERROR, , GENERIC_SYNTAX_ERR_MSG)
        End If

        CurrPosition = mPosition

        ' We didn't recoginze a valid value yet
        IsValue = False

        ' Check if the atom is a number typed in explicitly
        If IsNumeric(Mid(mExpression, CurrPosition, 1)) Then
            IsValue = True

            CurrPosition = CurrPosition + 1
            DecimalPointFound = False

            ' Read the rest of the number
            Do While IsNumeric(Mid(mExpression, CurrPosition, 1)) Or Mid(mExpression, CurrPosition, 1) = "."

                If Mid(mExpression, CurrPosition, 1) = "." Then
                    If Not DecimalPointFound Then
                        DecimalPointFound = True
                    Else
                        ' Can't have the decimal point twice!
                        Err.Raise(ParserErrors.PERR_SYNTAX_ERROR, , GENERIC_SYNTAX_ERR_MSG)
                    End If
                End If

                CurrPosition = CurrPosition + 1
            Loop

            Value = CDbl(Mid(mExpression, mPosition, CurrPosition - mPosition))

            mPosition = CurrPosition
            SkipSpaces()
        End If

        If Not IsValue Then
            ' Check if it's a constant/function name
            If IsLetter(Mid(mExpression, CurrPosition, 1)) Then
                CurrPosition = CurrPosition + 1

                ' Read the rest of the string. VB doesn't do
                ' "short-circuit" condition handling, so we have
                ' to put an If in the While loop
                Do While CurrPosition <= Len(mExpression)
                    If IsValidSymbolCharacter(Mid(mExpression, CurrPosition, 1)) Then
                        CurrPosition = CurrPosition + 1
                    Else
                        Exit Do
                    End If
                Loop

                SymbolName = Mid(mExpression, mPosition, CurrPosition - mPosition)
                mPosition = CurrPosition
                SkipSpaces()

                ' If there are openning parentheses, it's a
                ' function call
                CurrToken = GetToken()
                If CurrToken = ParserTokens.TOK_OPEN_PARENTHESES Then
                    SkipLastToken()
                    ' Get the argument to the function.
                    ' Multi-argument functions are very
                    ' easy to implement here.
                    ArgumentValue = ParseNumExp()

                    CurrToken = GetToken()
                    If CurrToken = ParserTokens.TOK_CLOSE_PARENTHESES Then
                        SkipLastToken()
                    Else
                        Err.Raise(ParserErrors.PERR_CLOSING_PARENTHESES_EXPECTED, , "')' Expected")
                    End If

                    Value = CallBuiltinFunction(SymbolName, ArgumentValue)
                    IsValue = True
                Else
                    ' The symbol is supposed to be a constant
                    ' name - check if it really exists
                    If ConstExists(SymbolName) Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object mConstants(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Value = mConstants.Item(SymbolName)
                        IsValue = True
                    Else
                        Err.Raise(ParserErrors.PERR_CONST_DOES_NOT_EXIST, , "Constant name " & SymbolName & " does not exist")
                    End If
                End If
            End If
        End If

        If Not IsValue Then
            ' We didn't recognize the value
            Err.Raise(ParserErrors.PERR_SYNTAX_ERROR, , GENERIC_SYNTAX_ERR_MSG)
        End If

        ParseAtom = Value
        Exit Function

ParseAtom_ErrHandler:
        SetErrSource("ParseAtom")
        Err.Raise(Err.Number)
    End Function

    Private Function GetToken() As ParserTokens
        Dim CurrToken As ParserTokens
        Dim i As ParserTokens

        If mPosition > Len(mExpression) Then
            GetToken = ParserTokens.TOK_UNKNOWN
            Exit Function
        End If

        CurrToken = ParserTokens.TOK_UNKNOWN
        mLastTokenLength = 0

        ' Iterate all known tokens and check if they match
        For i = ParserTokens.TOK_FIRST To ParserTokens.TOK_LAST
            If Mid(mExpression, mPosition, Len(mTokenSymbols(i))) = mTokenSymbols(i) Then
                CurrToken = i

                ' Save the token length so we can skip over it
                ' easily later
                mLastTokenLength = Len(mTokenSymbols(i))
                Exit For
            End If
        Next

        GetToken = CurrToken
    End Function

    Private Sub SkipLastToken()

        ' Skip over the last token, plus any spaces after it
        mPosition = mPosition + mLastTokenLength
        SkipSpaces()

    End Sub

    '''''''''''''''''''''''''''''''
    '
    ' Constants handling functions
    '
    '''''''''''''''''''''''''''''''

    ' Unlike the Scripting.Dictionary class, the Collection
    ' class has no method to check whether a key exists.
    ' This is HIGHLY inconvenient, so let's wrap it in a
    ' function
    Private Function ConstExists(ByRef Name As String) As Boolean
        Const ERR_KEY_NOT_FOUND As Short = 5
        Dim DummyValue As Double

        On Error Resume Next
        'UPGRADE_WARNING: Couldn't resolve default property of object mConstants(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        DummyValue = mConstants.Item(Name)

        If Err.Number = ERR_KEY_NOT_FOUND Then
            ConstExists = False
        Else
            ConstExists = True
        End If

    End Function

    Public Sub AddConstant(ByRef Name As String, ByRef Value As Double)
        Dim i As ParserTokens
        Dim TempName As String

        TempName = UCase(Trim(Name))

        ' Do all validity checks
        If Len(TempName) = 0 Then
            Err.Raise(ParserErrors.PERR_INVALID_CONST_NAME, , "Constant name cannot be null")
        End If

        If Not IsLetter(Left(TempName, 1)) Then
            Err.Raise(ParserErrors.PERR_INVALID_CONST_NAME, , "Constant name must begin with a letter")
        End If

        For i = 2 To Len(TempName)
            If Not IsValidSymbolCharacter(Mid(TempName, i, 1)) Then
                Err.Raise(ParserErrors.PERR_INVALID_CONST_NAME, , "Invalid constant name")
            End If
        Next

        If ConstExists(TempName) Then
            Err.Raise(ParserErrors.PERR_CONST_ALREADY_EXISTS, , "The constant already exists")
        End If

        If IsBuiltInFunction(TempName) Then
            Err.Raise(ParserErrors.PERR_RESERVED_WORD, , "The name is a reserved word")
        End If

        mConstants.Add(Value, TempName)

    End Sub

    Public Sub RemoveConstant(ByRef Name As String)
        Dim TempName As String

        TempName = UCase(Trim(Name))

        If ConstExists(TempName) Then
            mConstants.Remove(TempName)
        Else
            Err.Raise(ParserErrors.PERR_CONST_DOES_NOT_EXIST, , "Constant name " & TempName & " does not exist")
        End If

    End Sub


    '''''''''''''''''''''''''''''''''
    '
    ' 'Built-in function' functions...
    '
    '''''''''''''''''''''''''''''''''

    ' Check if a string name does stand for a supported built-in
    ' function - You may add as many as you like
    Private Function IsBuiltInFunction(ByRef Name As String) As Boolean
        Dim TempName As String

        TempName = UCase(Trim(Name))
        If TempName = "SIN" Or TempName = "COS" Or TempName = "ABS" Then

            IsBuiltInFunction = True
        Else
            IsBuiltInFunction = False
        End If

    End Function

    ' Execute the built-in function, and return its result
    Private Function CallBuiltinFunction(ByRef Name As String, ByRef Argument As Double) As Double
        On Error GoTo CallBuiltinFunction_ErrHandler

        Const DEGREES_TO_RADIANS As Double = PI / 180
        Dim TempName As String

        If Not IsBuiltInFunction(Name) Then
            Err.Raise(ParserErrors.PERR_FUNCTION_DOES_NOT_EXIST, , "Function " & Name & " Does not exist")
        End If

        TempName = UCase(Trim(Name))

        Select Case TempName
            Case "SIN"
                ' VB Trigonometric functions work with radians, so
                ' we need to convert the argument to radians
                CallBuiltinFunction = System.Math.Sin(Argument * DEGREES_TO_RADIANS)
            Case "COS"
                CallBuiltinFunction = System.Math.Cos(Argument * DEGREES_TO_RADIANS)
            Case "ABS"
                CallBuiltinFunction = System.Math.Abs(Argument)
        End Select

        Exit Function

CallBuiltinFunction_ErrHandler:
        SetErrSource("CallBuiltinFunction")
        Err.Raise(Err.Number)
    End Function

    '''''''''''''''''''
    '
    ' Helper functions
    '
    '''''''''''''''''''

    Private Sub SkipSpaces()

        ' Skip spaces/tabs in the expression
        Do While mPosition <= Len(mExpression) And (Mid(mExpression, mPosition, 1) = " " Or Mid(mExpression, mPosition, 1) = vbTab)
            mPosition = mPosition + 1
        Loop

    End Sub

    ' Check if a character is an english letter
    Private Function IsLetter(ByRef Character As String) As Boolean
        Dim CharAsciiCode As Integer

        CharAsciiCode = Asc(UCase(Character))
        If (CharAsciiCode >= Asc("A") And CharAsciiCode <= Asc("Z")) Then
            IsLetter = True
        Else
            IsLetter = False
        End If

    End Function

    ' Check if a character is an english letter / a number /
    ' an underscore
    Private Function IsValidSymbolCharacter(ByRef Character As String) As Boolean

        If IsLetter(Character) Or IsNumeric(Character) Or Character = "_" Then

            IsValidSymbolCharacter = True
        Else
            IsValidSymbolCharacter = False
        End If

    End Function

    '''''''''''''''''''''''''''
    '
    ' Error handling functions
    '
    '''''''''''''''''''''''''''

    ' Why do we need the project name? Well, when an error is
    ' first raised, the err.Source property is set to the project
    ' name. The SetErrSource function needs to know whether the error
    ' caught was generated in the "host" function, or propagated
    ' from a lower-level function. Checking the Source property
    ' is a good way to test it.
    Private Function GetProjectName() As String
        On Error Resume Next

        ' Quite a way to get the project name...
        Err.Raise(1, , " ")
        GetProjectName = Err.Source
        Err.Clear()

    End Function

    Private Sub SetErrSource(ByRef Name As String)

        If Err.Source = mProjectName Then
            ' Error was "just raised", the supplied function name
            ' is the lowest function in the call stack
            Err.Source = Name
        Else
            ' The error was propagated from a lower-level function.
            ' Add "this" function name to the call stack
            Err.Source = Name & "->" & Err.Source
        End If

    End Sub

    ' This property can tell the programmer where the
    ' parser raised an error - Note that the value returned
    ' may not be what you expected... Experiment with
    ' syntax errors
    Public ReadOnly Property LastErrorPosition() As Integer
        Get
            LastErrorPosition = mPosition
        End Get
    End Property

    '''''''''''''''''''''''''''
    '
    ' Initialization
    '
    '''''''''''''''''''''''''''

    'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Class_Initialize_Renamed()

        ' Initilalize token symbols
        'UPGRADE_WARNING: Lower bound of array mTokenSymbols was changed from TOK_FIRST to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
        ReDim mTokenSymbols(ParserTokens.TOK_LAST)

        mTokenSymbols(ParserTokens.TOK_ADD) = "+"
        mTokenSymbols(ParserTokens.TOK_SUBTRACT) = "-"
        mTokenSymbols(ParserTokens.TOK_MULTIPLY) = "*"
        mTokenSymbols(ParserTokens.TOK_DIVIDE) = "/"
        mTokenSymbols(ParserTokens.TOK_OPEN_PARENTHESES) = "("
        mTokenSymbols(ParserTokens.TOK_CLOSE_PARENTHESES) = ")"

        ' Initilalize constants collection &
        ' add built-in constants
        mConstants = New Collection
        mConstants.Add(PI, "PI")

        ' Get project name for proper error handling
        mProjectName = GetProjectName()

    End Sub

End Class
