@ECHO off
:menu
cls
ECHO **************************************************
ECHO *                     Vz Loader                  *
ECHO **************************************************
ECHO.
ECHO.
ECHO 1. Decklink Component + Guten Morgen Filstal
ECHO 2. Decklink Component + Guten Morgen Filstal ohne Logging
ECHO 3. Decklink SDI + Guten Morgen Filstal
ECHO 4. Decklink SDI + Guten Morgen Filstal ohne Logging
ECHO 5. keine Videoausgabe + Guten Morgen Filstal (Entwicklung)
ECHO.
ECHO 0. Beenden
ECHO.
ECHO.
set /p _choice=Bitte Config auswaehlen:
if %_choice%==0 goto end
if %_choice%==1 goto choice1
if %_choice%==2 goto choice2
if %_choice%==3 goto choice3
if %_choice%==4 goto choice4
if %_choice%==5 goto choice5
:choice1
ECHO starte Decklink Component + Guten Morgen Filstal
vz.exe -f ./projects/guten-morgen-filstal/guten-morgen-filstal.xml -c ./decklink-component.conf
goto end
:choice2
ECHO starte Decklink Component + Guten Morgen Filstal ohne Logging
vz.exe -f ./projects/guten-morgen-filstal/guten-morgen-filstal.xml -c ./decklink-component.conf
del vz.log*
goto end
:choice3
ECHO starte Decklink SDI + Guten Morgen Filstal
vz.exe -f ./projects/guten-morgen-filstal/guten-morgen-filstal.xml -c ./decklink-sdi.conf
goto end
:choice4
ECHO starte Decklink SDI + Guten Morgen Filstal ohne Logging
vz.exe -f ./projects/guten-morgen-filstal/guten-morgen-filstal.xml -c ./decklink-sdi.conf
del vz.log*
goto end
:choice5
ECHO starte Keine Videoausgabe + Guten Morgen Filstal (Entwicklungsumgebung !)
vz.exe -f ./projects/guten-morgen-filstal/guten-morgen-filstal.xml -c ./no_video.conf
del vz.log*
goto end

:end