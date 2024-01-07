using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Sessions
{
    internal class ConnectedAdherent
    {
        public static int CurrentAdherentId { get; set; }

        // Method to set the current adherent's ID when they log in
        public static void SetCurrentAdherentId(int adherentId)
        {
            CurrentAdherentId = adherentId;
        }
        // Method to clear the current adherent's ID when they log out
        public static void ClearSession()
        {
            CurrentAdherentId = 0;
        }
    }
}
