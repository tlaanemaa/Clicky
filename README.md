# Clicky
This is a simple keyboard macro application writen in C#. The project came to be when I needed such application and decided to write my own so I can also learn some C# along the way.

It allows setting a hotkey to toggle the macro on and off. This is done via the GetAsyncKeyState method from user32.dll. It might raise an alarm in some antiviruses since this same method can be used to write keyloggers. If you would like to use the application but are worried about this then just read the source and compile it yourself if you find it to be OK.
