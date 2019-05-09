using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class MySummoner : Summoner
    {
        public override ChatUser GetChatUser()
        {
            throw new QsoException( "Use QsoApi#GetMyChatUser() instead." );
        }
    }
}
