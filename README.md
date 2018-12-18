# Torrent.NET
A C# based Bit torrent Client.  This is currently a <b><i>WIP</b></i> and there is much work needed to be done.

## Built With:
+ [BEncode.NET](https://www.nuget.org/packages/BencodeNET/) - Used for deciphering BEncoded Dictionaries 

## Completed Functionalty 
+ Setting Up General Structure for the GUI
+ Added Menu Options and Windows To Add Torrents
+ Parsing the metainfo when a user adds a torrent file
+ Sending an intial GET request with the torrent trackers and parsing the response

## Functionality  Needing to be implemented:
+ TCP Connection to IPEndpoint 
+ Setting up queuing algoithms to support multithreaded socket connections
+ Receiving responses from the peers
+ Reconstructing received bytes into a finalized format
+ Set up multithreading to handle multiple downloads
