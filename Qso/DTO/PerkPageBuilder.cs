using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class PerkPageBuilder
    {
        private PerkPageResource _page;
        private long id;

        public PerkPageBuilder( long id )
        {
            this.id = id;
            _page = QsoApi.GetRunePageByID( id );
        }

        public PerkPageResource Build()
        {
            return QsoApi.GetDTO<PerkPageResource>( "/lol-perks/v1/pages/{0}", HttpMethod.Put, JsonConvert.SerializeObject( _page ), id );
        }

        public PerkPageBuilder WithName( string name )
        {
            _page.Name = name;
            return this;
        }

        public PerkPageBuilder WithPrimaryStyle( int style )
        {
            _page.PrimaryStyle = style;
            return this;
        }

        public PerkPageBuilder WithSubStyle( int style )
        {
            _page.SubStyle = style;
            return this;
        }

        public PerkPageBuilder WithPerks( int[] perks )
        {
            _page.SelectedPerks = perks;
            return this;
        }

        public PerkPageBuilder AsCurrent()
        {
            _page.Current = true;
            return this;
        }

        public PerkPageBuilder WithOrder( int order )
        {
            _page.Order = order;
            return this;
        }
    }
}
