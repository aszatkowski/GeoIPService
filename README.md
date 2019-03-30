
<html>

</head>

<body lang=PL link=blue vlink="#954F72">

<div class=WordSection1>

<p class=MsoNormal align=center style='margin-top:0cm;margin-right:0cm;
margin-bottom:0cm;margin-left:1.6pt;margin-bottom:.0001pt;text-align:center;
line-height:normal'><span style='font-size:16.0pt'>ZALE�NO�CI PROJEKTOWE OD
BIBLIOTEK ZEWN�TRZNYCH NUGET</span></p>

<p class=MsoNormal align=center style='margin-top:0cm;margin-right:0cm;
margin-bottom:0cm;margin-left:1.6pt;margin-bottom:.0001pt;text-align:center;
line-height:normal'><span style='font-size:16.0pt'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpFirst style='margin-top:0cm;margin-right:0cm;
margin-bottom:0cm;margin-left:19.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;
line-height:normal'>1.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Newtonsoft.Json</p>

<p class=MsoListParagraphCxSpLast style='margin-top:0cm;margin-right:0cm;
margin-bottom:0cm;margin-left:19.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;
line-height:normal'>2.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>System.Net.Http</p>

<p class=MsoNormal align=center style='margin-top:0cm;margin-right:0cm;
margin-bottom:0cm;margin-left:1.6pt;margin-bottom:.0001pt;text-align:center;
line-height:normal'><span style='font-size:16.0pt'>&nbsp;</span></p>

<p class=MsoNormal align=center style='margin-top:0cm;margin-right:0cm;
margin-bottom:0cm;margin-left:1.6pt;margin-bottom:.0001pt;text-align:center;
line-height:normal'><span style='font-size:16.0pt'>INSTRUKCJA URUCHOMIENIA
MIKROSERWISU LOKALIZACJI IP.</span></p>

<p class=MsoNormal align=center style='margin-top:0cm;margin-right:0cm;
margin-bottom:0cm;margin-left:1.6pt;margin-bottom:.0001pt;text-align:center;
line-height:normal'>&nbsp;</p>

<h1>Za�o�enia:</h1>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>1.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Dane oparte o baz� danych: <a
href="https://geolite.maxmind.com/download/geoip/database/GeoLite2-City.tar.gz">https://geolite.maxmind.com/download/geoip/database/GeoLite2-City.tar.gz</a></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>2.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Wystawienie danych w oparciu o kontener docker: <a
href="https://hub.docker.com/r/klauspost/geoip-service">https://hub.docker.com/r/klauspost/geoip-service</a></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>3.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Aktualizacja bazy na zasadzie podgrania pliku *.mmdb</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:1.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<h1>Instrukcja uruchomienia:</h1>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:1.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<h2>Przygotowanie DOCKER:</h2>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>1.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Zainstalowany docker (testowane na wersji): </p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>Client: Docker
Engine - Community</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> Version:          
<b>18.09.3</b></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> API
version:       1.39</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> Go
version:        go1.10.8</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> Git
commit:        774a1f4</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> Built:            
Thu Feb 28 06:32:50 2019</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> OS/Arch:          
windows/amd64</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> Experimental:     
false</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>Server: Docker
Engine - Community</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> Engine:</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> 
Version:          <b>18.09.3</b></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>  API
version:      1.39 (minimum version 1.24)</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>  Go
version:       go1.10.8</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>  Git
commit:       774a1f4</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> 
Built:            Thu Feb 28 06:48:59 2019</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> 
OS/Arch:          windows/amd64</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'> 
Experimental:     true</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>2.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Ustawione proxy (patrz ustawienia docker).</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>3.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Doker ustawiony w tryb kontener�w linux.</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>4.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Doker z wskazanym mapowaniem dysk�w (patrz ustawienia docker).</p>

<p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal'>&nbsp;</p>

<h2>Uruchomienie kontenera</h2>

<p class=MsoNormal>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>5.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Pobranie kontenera //mo�e wymaga� za�o�enia konta na docker hub:</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>docker pull
klauspost/geoip-service</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>6.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Rozpakowanie <a
href="https://geolite.maxmind.com/download/geoip/database/GeoLite2-City.tar.gz">bazy
ip</a> na serwerze (lokalnej stacji) w lokalizacji:</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>C:\geoip\GeoLite2-City.mmdb</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>7.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Utworzenie kontenera:</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>docker run --rm -p
127.0.0.1:3000:5000 -v c:/geoip/GeoLite2-City.mmdb:/data/geodb.mmdb
klauspost/geoip-service</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>Poprawne
uruchomienie:</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><i><span
style='color:gray'>C:\Users\aszatkows&gt;docker run --rm -p 127.0.0.1:3000:5000
-v c:/geoip/GeoLite2-City.mmdb:/data/geodb.mmdb klauspost/geoip-service</span></i></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><i><span
style='color:gray'>2019/03/29 19:03:49 Loaded database /data/geodb.mmdb</span></i></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><i><span
style='color:gray'>2019/03/29 19:03:49 Listening on :5000</span></i></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><span
style='color:gray'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><i><span
style='color:gray'>C:\Users\aszatkows&gt;docker ps</span></i></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><i><span
style='color:gray'>CONTAINER ID        IMAGE                    
COMMAND                  CREATED             STATUS             
PORTS                      NAMES</span></i></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><i><span
style='color:gray'>cf39bc13720a        klauspost/geoip-service   &quot;app
-db=/data/geodb�&quot;   4 minutes ago       Up 4 minutes        127.0.0.1:3000-&gt;5000/tcp  
xenodochial_perlman</span></i></p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'>&nbsp;</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;text-indent:-18.0pt;line-height:normal;
vertical-align:middle'>8.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>U�ycie:</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal;vertical-align:
middle'><a href="http://localhost:3000/IP_ADDR">http://localhost:3000/IP_ADDR</a>,
przyk�ad</p>

<p class=MsoNormal style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:28.6pt;margin-bottom:.0001pt;line-height:normal'><a
href="http://localhost:3000/37.47.46.163">http://localhost:3000/37.47.46.163</a></p>

<p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal'>&nbsp;</p>

</div>

</body>

</html>
