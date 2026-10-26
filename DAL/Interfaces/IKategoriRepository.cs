using Models;

namespace DAL.Interfaces
{
    public interface IKategoriRepository
    {
        Task<List<Kategori>> HamtaAllaKategorierAsync();
        Task LaggTillKategoriAsync(Kategori kategori);
        Task UppdateraKategoriNamnAsync(string id, string nyttNamn);
        Task TaBortKategoriAsync(string id);
    }
}
