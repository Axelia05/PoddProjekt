using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace BL.Interfaces
{
    public interface IKategoriService
    {
        Task LaggTillKategoriAsync(string namn);
        Task<List<Kategori>> HamtaAllaKategorierAsync();
        Task UppdateraKategoriNamnAsync(string id, string nyttNamn);
        Task TaBortKategoriAsync(string id);
    }
}
