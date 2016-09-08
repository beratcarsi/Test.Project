/*
 * Language Binding for BaseX.
 * Works with BaseX 7.0 and later
 *
 * Documentation: http://docs.basex.org/wiki/Clients
 *
 * (C) BaseX Team 2005-12, BSD License
 */

using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace Test.Project.BaseX
{
    public class BasexSession
    {
        private readonly byte[] _cache = new byte[4096];
        public NetworkStream Stream;
        private readonly TcpClient _socket;
        private string _info = "";
        private int _bpos;
        private int _bsize;

        public BasexSession(string host, int port, string username, string pw)
        {
            _socket = new TcpClient(host, port);
            Stream = _socket.GetStream();
            string[] response = Receive().Split(':');

            string nonce;
            string code;
            if (response.Length > 1)
            {
                code = username + ":" + response[0] + ":" + pw;
                nonce = response[1];
            }
            else
            {
                code = pw;
                nonce = response[0];
            }

            Send(username);
            Send(MD5(MD5(code) + nonce));
            if (Stream.ReadByte() != 0)
            {
                throw new IOException("Access denied.");
            }
        }

        public void Execute(string com, Stream ms)
        {
            Send(com);
            Init();
            Receive(ms);
            _info = Receive();
            if (!Ok())
            {
                throw new IOException(_info);
            }
        }

        public String Execute(string com)
        {
            MemoryStream ms = new MemoryStream();
            Execute(com, ms);
            return System.Text.Encoding.UTF8.GetString(ms.ToArray());
        }

        public Query Query(string q)
        {
            return new Query(this, q);
        }

        public void Create(string name, Stream s)
        {
            Stream.WriteByte(8);
            Send(name);
            Send(s);
        }

        public void Add(string path, Stream s)
        {
            Stream.WriteByte(9);
            Send(path);
            Send(s);
        }

        public void Replace(string path, Stream s)
        {
            Stream.WriteByte(12);
            Send(path);
            Send(s);
        }

        public void Store(string path, Stream s)
        {
            Stream.WriteByte(13);
            Send(path);
            Send(s);
        }

        public string Info
        {
            get
            {
                return _info;
            }
        }

        public void Close()
        {
            Send("exit");
            _socket.Close();
        }

        private void Init()
        {
            _bpos = 0;
            _bsize = 0;
        }

        public byte Read()
        {
            if (_bpos == _bsize)
            {
                _bsize = Stream.Read(_cache, 0, 4096);
                _bpos = 0;
            }
            return _cache[_bpos++];
        }

        private void Receive(Stream ms)
        {
            while (true)
            {
                byte b = Read();
                if (b == 0) break;
                // read next byte if 0xFF is received
                ms.WriteByte(b == 0xFF ? Read() : b);
            }
        }

        public string Receive()
        {
            MemoryStream ms = new MemoryStream();
            Receive(ms);
            return System.Text.Encoding.UTF8.GetString(ms.ToArray());
        }

        public void Send(string message)
        {
            byte[] msg = System.Text.Encoding.UTF8.GetBytes(message);
            Stream.Write(msg, 0, msg.Length);
            Stream.WriteByte(0);
        }

        private void Send(Stream s)
        {
            while (true)
            {
                int t = s.ReadByte();
                if (t == -1) break;
                if (t == 0x00 || t == 0xFF) Stream.WriteByte(Convert.ToByte(0xFF));
                Stream.WriteByte(Convert.ToByte(t));
            }
            Stream.WriteByte(0);
            _info = Receive();
            if (!Ok())
            {
                throw new IOException(_info);
            }
        }

        public bool Ok()
        {
            return Read() == 0;
        }

        private string MD5(string input)
        {
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            byte[] hash = MD5.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            foreach (byte h in hash)
            {
                sb.Append(h.ToString("x2"));
            }
            return sb.ToString();
        }
    }

    public class Query
    {
        private readonly BasexSession _basexSession;
        private readonly string _id;
        private ArrayList _cache;
        private int _pos;

        public Query(BasexSession s, string query)
        {
            _basexSession = s;
            _id = Exec(0, query);
        }

        public void Bind(string name, string value)
        {
            Bind(name, value, "");
        }

        public void Bind(string name, string value, string type)
        {
            _cache = null;
            Exec(3, _id + '\0' + name + '\0' + value + '\0' + type);
        }

        public void Context(string value)
        {
            Context(value, "");
        }

        public void Context(string value, string type)
        {
            _cache = null;
            Exec(14, _id + '\0' + value + '\0' + type);
        }

        public bool More()
        {
            if (_cache == null)
            {
                _basexSession.Stream.WriteByte(4);
                _basexSession.Send(_id);
                _cache = new ArrayList();
                while (_basexSession.Read() > 0)
                {
                    _cache.Add(_basexSession.Receive());
                }
                if (!_basexSession.Ok())
                {
                    throw new IOException(_basexSession.Receive());
                }
                _pos = 0;
            }
            if (_pos < _cache.Count) return true;
            _cache = null;
            return false;
        }

        public string Next()
        {
            if (More())
            {
                return _cache[_pos++] as string;
            }
            else
            {
                return null;
            }
        }

        public string Execute()
        {
            return Exec(5, _id);
        }

        public string Info()
        {
            return Exec(6, _id);
        }

        public string Options()
        {
            return Exec(7, _id);
        }

        public void Close()
        {
            Exec(2, _id);
        }

        private string Exec(byte cmd, string arg)
        {
            _basexSession.Stream.WriteByte(cmd);
            _basexSession.Send(arg);
            string s = _basexSession.Receive();
            bool ok = _basexSession.Ok();
            if (!ok)
            {
                throw new IOException(_basexSession.Receive());
            }
            return s;
        }

    }

}
