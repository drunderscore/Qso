using Newtonsoft.Json;
using Qso.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QsoClient
{
    public class RuneManager
    {
        public static readonly DirectoryInfo RUNE_PAGES_DIR = new DirectoryInfo( "runes" );
        public static List<PerkPageResource> Pages { get; } = new List<PerkPageResource>();

        public static void Populate()
        {
            Pages.Clear();
            if ( !RUNE_PAGES_DIR.Exists )
                RUNE_PAGES_DIR.Create();
            foreach ( FileInfo f in RUNE_PAGES_DIR.GetFiles( "*.json" ) )
            {
                var page = JsonConvert.DeserializeObject<PerkPageResource>( File.ReadAllText( f.FullName ) );
                if ( page != null )
                    Pages.Add( page );
            }
            Console.WriteLine( $"Repopulated saved perk pages with {Pages.Count} pages." );
        }
    }
}
