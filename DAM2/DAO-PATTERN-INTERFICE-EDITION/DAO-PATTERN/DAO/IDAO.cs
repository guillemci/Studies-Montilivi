using DAO_PATTERN.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO_PATTERN.DAO
{
    public interface IDAO
    {
        public int SelectByGenre(string genre, string outputFile);
        public RawTitle? SelectByIndex(int index);
        public RawTitle? SelectById(string id);
        public RawTitle[] ReadTitles(int index, int length);
        public void PreMerge(RawTitle[] titles, string outputFileName);
        public int Merge(string inputFileName1, string inputFilename2, string outputFileName);

    }
}
