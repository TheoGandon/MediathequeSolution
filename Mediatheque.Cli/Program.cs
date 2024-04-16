using Mediatheque.Core;
using Mediatheque.Core.DAL;
using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using System;

namespace Mediatheque.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext applicationDBContext = new ApplicationDbContext();

            INotationService notationService = null;

            MediathequeService mediatheque = new MediathequeService(applicationDBContext, notationService);

            var cd1 = mediatheque.AddCd("Smell like teen Spirit", "Nirvana");
            var cd2 = mediatheque.AddCd("Unplee @ NY", "Nirvana");
            var cd3 = mediatheque.AddCd("Smash", "Offstring");
            var cd4 = mediatheque.AddCd("Blo", "13Block");
            var cd5 = mediatheque.AddCd("Le lapin", "Chantal Goya");

            var cds = mediatheque.GetCDs();

            mediatheque.EditCd(cd2.Id, "Unplugged @NY");

            var cd2edit = mediatheque.GetCdById(cd2.Id);

            var test = (cd2edit == cd2);

            mediatheque.DeleteCD(cd5.Id);
            var cdsSansCd5 = mediatheque.GetCDs();

            var cdsNirvana = mediatheque.GetCdsByGroupe("Nirvana");
        }
    }
}
