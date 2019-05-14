using Qso;
using Qso.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QsoClient.Windows
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            if ( !AttemptInitializeQso() )
                return;
#if DEBUG
            QsoApi.VeryVerbose = true;
#endif
            Application.Run( new MainWindow() );
        }

        private static bool AttemptInitializeQso()
        {
            try
            {
                QsoApi.Initialize();
            }
            catch ( QsoException e )
            {
                if ( MessageBox.Show( e.Message, "Exception initializing Qso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error ) == DialogResult.Retry )
                    return AttemptInitializeQso();
                else
                    return false;
            }
            return true;
        }
    }
}
