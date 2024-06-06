using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Path_to_succsess
{
    internal class Game
    {
        Player[] players;
        ushort day;

        internal byte DayOfWeek
        {
            get { return (byte)(day % 4 + 1); }
        }
        internal ushort Week
        {
            get { return (byte)(day / 4 + 1); }
        }

        Game(byte countPlayers, XmlNode xmlRoot)
        {
            List<Node> map = new List<Node>();
            players = new Player[countPlayers];
            day = 0;

        }
    }
}
