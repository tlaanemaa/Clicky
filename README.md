# Clicky
This is a simple keyboard macro application writen in C#. The project came to be when I needed such application and decided to write my own so I can also learn some C# along the way.

It allows setting a hotkey to toggle the macro on and off. This is done via the GetAsyncKeyState method from user32.dll. It might raise an alarm in some antiviruses since this same method can be used to write keyloggers. If you would like to use the application but are worried about this then just read the source and compile it yourself if you find it to be OK.

<h3>Sample commands</h3>
<ul>
  <li><b>*end</b> - Stops execution</li>
  <li><b>*sleep 200</b> - Makes the application sleep for 200ms</li>
  <li><b>*mouse move 300 400</b> - Moves mouse to position x=300, y=400 on the screen</li>
  <li><b>*mouse key left down</b> - Sets mouse left-click key to "down" state in current location</li>
  <li><b>*mouse key left up</b> - Releases mouse left-click key in current location</li>
  <li><b>*mouse key left down 400 500</b> - Sets mouse left-click key to "down" state at x=400 y=500</li>
  <li><b>I like cookies</b> - Sends keyboard events to write out "I like cookies" via SendKeys</li>
</ul>
