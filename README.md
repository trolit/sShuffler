<p align="center"><img src="https://raw.githubusercontent.com/trolit/sShuffler/storage/images/logo.png" width="60%" alt="logo image"></p>

<p align="center"><a href="https://github.com/trolit/sShuffler/releases/download/v1.1/sShuffler_desktop.zip"><img src="https://raw.githubusercontent.com/trolit/sShuffler/storage/images/5.png" width="45%" alt="download image"></a></p>

Check for viruses <a href="https://www.virustotal.com/gui/url-analysis/u-9e728f005d4938ca844107d17563e5b59933ac5ece9509a575959eccd515ed14-1586804287/detection">here</a> with VirusTotal.

<h4>About</h4>

<p align="justify">sShuffler stands for song Shuffler. It is an open source, simple solution that gives playlists second life(literally) by randomly(well, pseudorandomly..) rearranging it. If you listen to the songs in the same order(especially while driving a car), sooner or later you will want to reorder it to make it unpredictable. What you can do is use random play function(if your car owns it).. but that might feel just too random(you don't want to get the same song N times) or.. try software that reorders playlist for you so you don't have to rename songs manually and loose time(I recommend Mp3Tag if you want to sort playlist freely). sShuffler generates output with leading zeros that order is strongly observed by most music players. Created for private purposes but maybe someone will find it useful too :) </p>

<h4>Consider the following situation</h4>

<p align="justify">You uploaded 15 songs on USB drive in 1..15 convention. Then you connected it to the music player. After first song ended, player launched track number 11. That's because music player found at first place number 1. If you switch next songs you will get 12, 13, 14, 15 and after 15 you will hear second track. Some of the players act like that. How to overcome this situation? Refer to car documentation and configure music player or... use quicker workaround by adding leading zeros.</p>

<p align="justify">If you use leading zeros for the mentioned 15 tracks, for e.g. 001 to 015, position of the 1 will matter so your music player after track 001 will launch 002!</p>

<h4>About app</h4>

<p align="justify">sShuffler generates output like this</p>

<p align="left"><img src="https://raw.githubusercontent.com/trolit/sShuffler/storage/images/3.png" width="40%" alt="generate from 1"></p>

<p align="justify">But if needed, you can set manually starting number(when for e.g. you got some new tracks that you want to put at the beginning of the playlist). Then new tracks order can also be automated but this time without specifying starting point:) </p>

<p align="left"><img src="https://raw.githubusercontent.com/trolit/sShuffler/storage/images/4.png" width="40%" alt="generate from N"></p>

<p align="justify">sShuffler interface looks like this</p>

<p align="center"><img src="https://raw.githubusercontent.com/trolit/sShuffler/storage/images/1.PNG" width="70%" alt="sShuffler interface"></p>

<p align="justify">In the Log area you will see messages that appear on certain events</p>

<p align="center"><img src="https://raw.githubusercontent.com/trolit/sShuffler/storage/images/2.PNG" width="70%" alt="sShuffler - log"></p>

<h4>Usage</h4>

<p align="justify">After downloading zip file, unpack and launch exe file, tool will popup. Check for help if you want to, drop songs you want to randomly(pseudorandomly) reorder and get the output. sShuffler does not overwrite source data. </p>

<br/>
<br/>
<br/>

Snake emoji used as logo belongs to Twitter and is licensed under CC BY 4.0 (<a href="https://iconify.design/icon-sets/twemoji/snake.html">source</a>)

Download icon belongs to icons8 (<a href="https://icons8.com/icons">source</a>)

sShuffler uses TagLib# to modify track number(<a href="https://github.com/mono/taglib-sharp">source</a>)

Loading icon used in progress panel(<a href="https://loading.io/">source</a>)

<br/>
<br/>

Template generated using <a href="https://github.com/trolit/EzGitDoc">EzGitDoc</a>
