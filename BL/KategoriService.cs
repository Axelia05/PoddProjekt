using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class KategoriService
    {
        //Services ska använda DAL:s abstraktioner.
        private readonly IKategoriRepository _kategoriRepo;

        //Dependency Injection: tjänsten får sitt beroende via interfacet.
        public KategoriService (IKategoriRepository kategoriRepo)
        {
            _kategoriRepo = kategoriRepo;
        }
    }
}
