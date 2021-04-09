# Instructions

## Instillation

StreamTimerApp is completely portable and can be moved around your computer with no issues. It can even be run off a USB device if you want to.

1. Download the latest release .zip file (the StreamTimerAppV#.zip file)
2. Unzip to chosen folder. Example: c:/program files/StreamTimerApp
![](https://github.com/Lethann/StreamTimerApp/blob/891d79627682415f53586cfb606b7a59e8994c6e/Screenshot%202021-04-09%20094435.png)
3. Run StreamTimerApp.exe
4. You may be prompted to install .Net Core if you don't have it already installed.

## Simple Timer

The Simple Timer is currently a single message, auto repeating timer that sends the countdown to a text file your Broadcasting Software (Obs/Slobs) can then read. Clicking on the "About" tab will give you simple instructions, and hovering over a text box will give a short description along the bottom.

![](https://user-images.githubusercontent.com/25929754/113521923-4d3b5600-9562-11eb-8b00-017cae87386d.png)

1. Output File: Click the "Browse" button and select or create your your EMPTY txt file. Example: c:/program files/StreamTimerApp/TimerSource.txt
![](https://github.com/Lethann/StreamTimerApp/blob/891d79627682415f53586cfb606b7a59e8994c6e/Screenshot%202021-04-09%20094436.png)

2. Minutes: Type the number of minutes you want the timer to last.
3. Message: Type the short message you wish to appear alongside your timer.
4. OPTIONAL End Sound: Click the "Browse" button and select a short wav file to play at the end of the timer. Note: There is 5 seconds after a timer finishes before it starts again. 
5. CLICK "START" to start the timer.
6. Click "STOP" to stop the timer at any time. It will empty out the txt file so it will not display anything in your broadcasting software. 

NOTE: The timer will NOT STOP until the Stop button is clicked. If the program is closed without clicking stop then the text file will not be cleared out.

## OBS/SLOBS Instructions

To help those who are using OBS/SLOBS here is how you get it to work in your software. (Screenshots are using SLOBS but both are pretty much the same.)

1. Open OBS/SLOBS
2. Click the "Scene" you want to add the timer to.
3. Add new source by clicking the + sign at the top of the "Sources" box.
4. Select TEXT (GDI+)
5. In the Properties window, you want to check "READ FROM FILE". Use the Browse button to find the text file or simply or copy the location from the Output File box in the App.  NOTE: Nothing will appear until you start the timer, so suggest setting up a test timer while you are setting this up. 
6. Use the settings avaliable in the properties window to customize the font, color, size of the timer text.
7. Click "DONE".
8. You should never have to change this unless you change the location of the Output Text File. 
