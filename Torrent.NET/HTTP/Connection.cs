using BencodeNET.Torrents;
using System;
using System.Text;
using TorrentDotNet.Util;
using System.Net;
using BencodeNET.Parsing;
using BencodeNET.Objects;
using System.Net.Sockets;

namespace TorrentDotNet.HTTP
{
    class Connection
    {
        private StringBuilder url = new StringBuilder();
        private BDictionary trackerResponse;

        // Initiates an HTTP request for the torrent
        // returns a tracker response dictionary containg info on all the peers
        public Connection(Torrent torrent)
        { 
            url.Append(torrent.Trackers[0][0].ToString()+"?");

            string hash = torrent.GetInfoHash();
            hash = Formatter.HashToPercentEncoding(hash);

            string peerid = GeneratePeerID();
            string port = GeneratePort();
            string left = torrent.File.FileSize.ToString();

            url.Append("info_hash=" + hash +"&");
            url.Append("peer_id=" + peerid + "&");
            url.Append("port=" + port + "&");
            url.Append("left=" + left + "&");
            url.Append("uploaded=0&downloaded=0&compact=0&no_peer_id=&event=started");

            string URL = url.ToString();

            WebClient client = new WebClient();
            byte[] databuffer = client.DownloadData(URL);

            var parser = new BencodeParser();
            trackerResponse = parser.Parse<BDictionary>(databuffer);

            GetPeers();
        }

        // Must Be At Least 20 Characters Long
        private string GeneratePeerID()
        {
            /*
            var peerid = new StringBuilder();
            peerid.Append("-TN0001-");

            for (int i =0; i < 12; i++)
            {
                peerid.Append(new Random().Next(1,10));
                System.Threading.Thread.Sleep(10);
            }
            */

            var str = "";
            for (int i = 0; i < 20; i++)
            {
                str += ((char) (new Random().Next(1, 26) +64)).ToString();
            }


            return str;
        }

        // port 6881-6889 reserved for Bittorent

        private string GeneratePort()
        {
            return new Random().Next(6881, 6889).ToString();
        }

        private void GetPeers()
        {
            var test = trackerResponse.Value["peers"];
            byte[] arr = test.EncodeAsBytes();

            byte[] ip = { 0, 0, 0, 0 };
            byte[] port = { 0, 0 };

            // Network data is sent in Big Endian, converts to Little
            if (BitConverter.IsLittleEndian)
                Array.Reverse(arr);

            // reads first 4 bytes to get IP
            ip[0] = arr[0];
            ip[1] = arr[1];
            ip[2] = arr[2];
            ip[3] = arr[3];

            //reads first 5th and 6th bits to get the associated port number
            port[0] = arr[4];
            port[1] = arr[5];


            // 6 bytes total: || 1,2,3,4 || 5, 6 ||
            //                || --IP--- || port ||

            int PortNum = BitConverter.ToUInt16(port, 0);

            var addr = new IPAddress(ip);
            //addr.

            ConnectToPeer(ref addr, ref PortNum);
        }

        private void ConnectToPeer(ref IPAddress ipAddr, ref int port)
        {
            TcpClient client = new TcpClient();

            try
            {
                // Need to implement method to recieve the socket data
                client.Connect(ipAddr, port);

                NetworkStream stream = client.GetStream();

                stream.Close();
                client.Close();
            }

            catch (SocketException)
            {
                Console.WriteLine("Connection failed");
            }

        }
    }
}
