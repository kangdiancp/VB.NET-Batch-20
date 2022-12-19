Module ModuleDateTime
    Sub ShowDate()
        Dim date1 As Date = #12/15/2022 10:03:01 AM#

        Console.WriteLine("Date1 : " & date1)

        Dim currentDate As Date = Date.Now
        Console.WriteLine("Now: " & currentDate)
        currentDate = currentDate.AddDays(2)
        Console.WriteLine("Lusa : " & currentDate)

        Dim hari, bulan, tahun As Integer
        hari = Day(currentDate)
        bulan = Month(currentDate)
        tahun = Year(currentDate)

        Console.WriteLine("Hari : " & hari & "Bulan:" & bulan & "tahun:" & tahun)

    End Sub
End Module
