Imports System
Imports VbAppConsole.PartTwo

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")

        'call method SayMyName
        'SayMyName()

        'call method from ModuleVariables
        'ModuleVariables.StoreVariable()
        'ModuleVariables.SwapTwoVariable()
        'ModuleMath.OperationMath()
        'ModuleMath.BagiSisa()
        'ModuleDecision.OddEvenNumber()
        'ModuleDecision.Grade()
        'ModuleDecision.GradeCase()
        'ModuleDecision.WhoIsTheGreatest()
        'ModuleDateTime.ShowDate()
        'ModuleIteration.DoWhile(10)
        'ModuleIteration.DoWhileExit(10)
        'ModuleIteration.ForLoop()
        'ModuleIteration.KotakBintang(5)
        ModulePartTwo.InitEmployee()




    End Sub

    Sub SayMyName()
        'declaration variable
        Dim myName As String
        Console.Write("Enter your name : ")

        'use readline to accept value
        myName = Console.ReadLine()

        'display result with concat
        Console.WriteLine("Your name :" & myName)
    End Sub
End Module
