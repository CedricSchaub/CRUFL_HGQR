.NET 4 assembly folder: C:\windows\Microsoft.NET\assembly\GAC_32 or \GAC_64 

1) CRUFL_HGQR.dll nach C:\Program Files (x86)\Business Objects\BusinessObjects Enterprise 11.5\win32_x86\ kopieren

2) Den Befehl "C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe" "C:\Program Files (x86)\Business Objects\BusinessObjects Enterprise 11.5\win32_x86\CRUFL_HGQR.dll" ausführen
-> Assembly in der Registry registrieren

3) Den Befehl gacutil /i "C:\Program Files (x86)\Business Objects\BusinessObjects Enterprise 11.5\win32_x86\CRUFL_HGQR.dll" ausführen
-> Assembly im Global Assembly Cache registrieren
