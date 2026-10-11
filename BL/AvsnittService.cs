using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class AvsnittService
    {
        //Services ska använda DAL:s abstraktioner.
        private readonly IAvsnittRepository _avsnittRepo; 

        //Dependency Injection: tjänsten får sitt beroende via interfacet.
        public AvsnittService (IAvsnittRepository avsnittRepo)
        {
            _avsnittRepo = avsnittRepo;
        }
    }
}
