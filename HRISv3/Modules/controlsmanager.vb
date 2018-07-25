

Module controlsmanager

#Region "---------------------------------------------------Editemployee---------------------------------------------------"

    Public Sub enablecontrols()
        'profile
        Editemployee.txt1.Enabled = True
        Editemployee.txt2.Enabled = True
        Editemployee.Txt3.Enabled = True
        Editemployee.txt4.Enabled = True
        Editemployee.txt5.Enabled = True
        Editemployee.txt6.Enabled = True
        Editemployee.txt7.Enabled = True
        Editemployee.txt8.Enabled = True
        Editemployee.txt9.Enabled = True

        'education
        Editemployee.edu1.Enabled = True
        Editemployee.edu2.Enabled = True

        'payroll info
        Editemployee.pay1.Enabled = True
        Editemployee.pay2.Enabled = True
        Editemployee.pay3.Enabled = True
        Editemployee.pay4.Enabled = True

        'medical
        Editemployee.med1.Enabled = True
        Editemployee.med2.Enabled = True
        Editemployee.med3.Enabled = True
        Editemployee.med4.Enabled = True
        Editemployee.med5.Enabled = True
        Editemployee.med6.Enabled = True
    End Sub
    Public Sub disablecontrols()
        'profile
        Editemployee.txt1.Enabled = False
        Editemployee.txt2.Enabled = False
        Editemployee.Txt3.Enabled = False
        Editemployee.txt4.Enabled = False
        Editemployee.txt5.Enabled = False
        Editemployee.txt6.Enabled = False
        Editemployee.txt7.Enabled = False
        Editemployee.txt8.Enabled = False
        Editemployee.txt9.Enabled = False

        'education
        Editemployee.edu1.Enabled = False
        Editemployee.edu2.Enabled = False

        'payroll info
        Editemployee.pay1.Enabled = False
        Editemployee.pay2.Enabled = False
        Editemployee.pay3.Enabled = False
        Editemployee.pay4.Enabled = False

        'medical
        Editemployee.med1.Enabled = False
        Editemployee.med2.Enabled = False
        Editemployee.med3.Enabled = False
        Editemployee.med4.Enabled = False
        Editemployee.med5.Enabled = False
        Editemployee.med6.Enabled = False
    End Sub

#End Region
End Module
