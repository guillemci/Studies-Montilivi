
using DAO_PATTERN_CONSOLE_EDITION.Model;

namespace DAO_PATTERN_CONSOLE_EDITION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connexio = "input.csv";
            IDAO dao = IDAOFactory.GetDAOService(Enums.EnumDTOImplementacio.CSV, connexio);

            RawTitle[] array = dao.ReadTitles(1, 10);
            RawTitle[] array2 = dao.ReadTitles(10, 10);

            dao.PreMerge(array, "outputEpic");
            dao.PreMerge(array2, "outputEpic2");

            dao.Merge("outputEpic.csv", "outputEpic2.csv", "sortidaDura");

            foreach (RawTitle p in array)
                Console.WriteLine($"{p._Id}:{p._Title}");

            //Console.WriteLine(dao.SelectByIndex(0)?._Title);
        }
    }
}
