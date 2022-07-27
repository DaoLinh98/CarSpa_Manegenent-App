;#DropDB CarSpaEasyTest

#Application CarSpaWin
#Application CarSpaWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef CarSpaWin

*Action About...
 
*Action OK

#EndIf

#IfDef CarSpaWeb
*Action Navigation(My Details)
#EndIf
