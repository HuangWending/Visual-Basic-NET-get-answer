Imports System

Module Program
    Sub Main()
        Dim question As String
        Dim answer As String

        Console.WriteLine("你好！")
        question = Console.ReadLine()

        If question = "你好" Then
            answer = "你好！"
        ElseIf question = "你的名字是什么" Then
            answer = "黄文定"
        ElseIf question = "你的生日是什么时候" Then
            answer = "2009年7月18日"
        ElseIf question = "你是中国人吗" Then
            answer = "我是中国人"
        ElseIf question = "台湾是中国的吗" Then
            answer = "台湾是中国的"
        ElseIf question = "你爱我吗" Then
            answer = "这是一个由我决定的选项，我需要认真，但是我还是爱着你"
        ElseIf question = "你喜欢去哪里" Then
            answer = "中国大陆和中国台湾"
        ElseIf question = "你有朋友吗" Then
            answer = "没有"
        ElseIf question = "你的心情怎么样" Then
            answer = "自卑，孤独"
        Else
            answer = "抱歉，我无法理解你的问题"
        End If

        Console.WriteLine(answer)
        Console.ReadLine()
    End Sub
End Module
