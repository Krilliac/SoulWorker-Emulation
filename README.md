# SoulWorker-Emulation
Collective resource of information to maybe one day emulate the MMORPG SoulWorker

Might be a good idea to dig around a bit and look for existing up to date emulators that are already available (If they are updated...) 

# Running "Without Steam"

Select SoulWorker.exe, right click and create a shortcut with the following Command Line Parameters.

--ip 194.187.19.129 --port 10000 --steam

# Information
WireShark required to actually obtain all data

These filter seems to work nicely..

tcp and net 194.187.19.0/24 or net 206.253.173.62 or net 40.71.184.97

ip.dst == 194.187.19.129 or ip.dst == 206.253.173.62 or ip.dst == 40.71.184.97

# Server's in correspondence with the IP's

    ip from gameforge authentication service
    194.187.19.129:10000


    ip from the game authentication service
    206.253.173.62:10102


    ip from the game world service
    40.71.184.97:11021

# Server DNS

    194.187.19.129 -> ns1.gfsrv.net (GameForge)
    206.253.173.62 -> ns1.datanap.net (Volico) aka (ns2.gfsrv.net)
    40.71.184.0/24 -> prd4.azuredns-cloud.net (Main Game Dedicated Host)
