namespace TestArrays
{
    using Xunit;
    using ProjecteArrays; // Referencia el projecte de l'alumne
    using Arrays;
    using System.Collections;

    namespace ProjecteArrays.Tests
    {

        public class TestsMetodesArrays
        {
            public bool TaulesIguals<T>(T[] taula1, T[] taula2)
            {

                if (taula1.Length != taula2.Length)
                    return false;
                IEnumerator dit1 = taula1.GetEnumerator();
                IEnumerator dit2 = taula2.GetEnumerator();
                bool pucMoure1, pucMoure2;
                T elementActual1;
                T elementActual2;
                while (((pucMoure1 = dit1.MoveNext()) & (pucMoure2 = dit2.MoveNext())) &&
                    ((elementActual1 = (T)(dit1.Current)).Equals(
                    (elementActual2 = ((T)dit2.Current))))) ;
                return !pucMoure1 && !pucMoure2;
            }

            [Fact]
            [Trait("Categoria", "1.1")] // OmpleNaturals
            public void Test_OmpleNaturals()
            {
                Assert.True(TaulesIguals(new int[] { 1, 2, 3 }, MetodesArrays.OmpleNaturals(3)));
                Assert.True(TaulesIguals(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, MetodesArrays.OmpleNaturals(10))); ;
                Assert.True(TaulesIguals(new int[] { 1 }, MetodesArrays.OmpleNaturals(1)));
                Assert.True(TaulesIguals(new int[] { }, MetodesArrays.OmpleNaturals(0)));
            }

            [Fact]
            [Trait("Categoria", "1.2")] // OmpleNaturals
            public void Test_GeneraTaula()
            {
                Assert.True(TaulesIguals(new int[] { 45, 64, 54, 12, -59, 12 }, MetodesArrays.GeneraTaula(6)));
                Assert.True(TaulesIguals(new int[] { 45, 64, 54 }, MetodesArrays.GeneraTaula(3)));
                Assert.True(TaulesIguals(new int[] { 45 }, MetodesArrays.GeneraTaula(1)));
                Assert.True(TaulesIguals(new int[] { }, MetodesArrays.GeneraTaula(0)));
            }

            [Fact]
            [Trait("Categoria", "1.3")] // SumaTaula
            public void Test_SumaTaula()
            {
                Assert.Equal(60, MetodesArrays.SumaTaula(new int[] { 10, 20, 30 }));
                Assert.Equal(21, MetodesArrays.SumaTaula(new int[] { 1, 2, 3, 4, 5, 6 }));
                Assert.Equal(10, MetodesArrays.SumaTaula(new int[] { 10 }));
                Assert.Equal(0, MetodesArrays.SumaTaula(new int[] { }));
            }

            [Fact]
            [Trait("Categoria", "1.4")] // MinimTaula
            public void Test_MinimTaula()
            {
                Assert.Equal(10, MetodesArrays.MinimTaula(new int[] { 30, 10, 20 }));
                Assert.Equal(-60, MetodesArrays.MinimTaula(new int[] { 30, -60, 20 }));
                Assert.Equal(30, MetodesArrays.MinimTaula(new int[] { 30, 30, 30 }));
            }

            [Fact]
            [Trait("Categoria", "1.5")] // PosicioMinimTaula
            public void Test_PosicioMinimTaula()
            {
                Assert.Equal(1, MetodesArrays.PosicioMinimTaula(new int[] { 30, 10, 20 }));
                Assert.Equal(1, MetodesArrays.PosicioMinimTaula(new int[] { 30, -60, 20 }));
                Assert.Equal(0, MetodesArrays.PosicioMinimTaula(new int[] { 30, 30, 30 }));
            }

            [Fact]
            [Trait("Categoria", "1.6")] // MàximTaula
            public void Test_MaximTaula()
            {
                Assert.Equal(30, MetodesArrays.MaximTaula(new int[] { 30, 10, 20 }));
                Assert.Equal(30, MetodesArrays.MaximTaula(new int[] { -60, 30, 20 }));
                Assert.Equal(30, MetodesArrays.MaximTaula(new int[] { 30, 30, 30 }));
            }

            [Fact]
            [Trait("Categoria", "1.7")] // PromigTaula
            public void Test_PromigTaula()
            {
                Assert.Equal(20D, MetodesArrays.MitjanaTaula(new int[] { 30, 10, 20 }));
                Assert.Equal(-3D, MetodesArrays.MitjanaTaula(new int[] { 30, -60, 20 }));
                Assert.Equal(30D, MetodesArrays.MitjanaTaula(new int[] { 30, 30, 30 }));
            }

            [Fact]
            [Trait("Categoria", "1.8")] // CapgirarTaula (test d'un mètode void)
            public void Test_CapgiraTaula()
            {
                int[] taula = { 1, 2, 3, 4, 5 };
                MetodesArrays.CapgiraTaula(taula);
                Assert.True(TaulesIguals(new int[] { 5, 4, 3, 2, 1 }, taula));
            }

            [Fact]
            [Trait("Categoria", "1.9")] // PosicióDe
            public void Test_PosicioDe()
            {
                Assert.Equal(0, MetodesArrays.PosicioDe( new int[] { 30, 10, 20 }, 30));
                Assert.Equal(2, MetodesArrays.PosicioDe(new int[] { 30, 10, 20 }, 20));
                Assert.Equal(1, MetodesArrays.PosicioDe(new int[] { 30, 10, 20 }, 10));
                Assert.Equal(-1, MetodesArrays.PosicioDe(new int[] { 30, 10, 20 }, 15));
            }

            [Fact]
            [Trait("Categoria", "1.10")] // Conté
            public void Test_Conté()
            {
                Assert.True(MetodesArrays.Conte(new int[] { 30, 10, 20 }, 30));
                Assert.True(MetodesArrays.Conte(new int[] { 30, 10, 20 }, 20));
                Assert.True(MetodesArrays.Conte(new int[] { 30, 10, 20 }, 10));
                Assert.False(MetodesArrays.Conte(new int[] { 30, 10, 20 }, 15));
            }

            [Fact]
            [Trait("Categoria", "1.11")] // ContéEnRang
            public void Test_ConteEnRang()
            {
                Assert.True(MetodesArrays.ConteEnRang(new int[] { 30, 10, 20 , -15, 100, 0, -18 }, -15, 0, 3));
                Assert.True(MetodesArrays.ConteEnRang(new int[] { 30, 10, 20, -15, 100, 0, -18 }, -15, 0, 6));
                Assert.True(MetodesArrays.ConteEnRang(new int[] { 30, 10, 20, -15, 100, 0, -18 }, -15, 2, 4));
                Assert.False(MetodesArrays.ConteEnRang(new int[] { 30, 10, 20, -15, 100, 0, -18 }, -15, 0, 2));
            }
            [Fact]
            [Trait("Categoria", "1.12")] // TaulaAString
            public void Test_TaulaAString()
            {
                string esperat = "Index 0: 10\nIndex 1: 20";
                Assert.Equal(esperat, MetodesArrays.TaulaAString(new int[] { 10, 20 }));
            }

            [Fact]
            [Trait("Categoria", "1.16")] // OmplirMatriuPerFiles
            public void Test_OmpleMatriuPerFiles()
            {
                int[,] esperat = { { 1, 2 }, { 2, 2 } };
                Assert.Equal(esperat[0, 0], MetodesArrays.OmpleMatriuPerFiles(2, 2)[0, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuPerFiles(2, 2)[0, 1]);
                Assert.Equal(esperat[1, 0], MetodesArrays.OmpleMatriuPerFiles(2, 2)[1, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuPerFiles(2, 2)[0, 1]);
            }

            [Fact]
            [Trait("Categoria", "1.17")] // OmplirMatriuPerFiles
            public void Test_OmpleMatriuPerColumnes()
            {
                int[,] esperat = { { 1, 1 }, { 2, 2 } };
                Assert.Equal(esperat[0, 0], MetodesArrays.OmpleMatriuPerColumnes(2, 2)[0, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuPerColumnes(2, 2)[0, 1]);
                Assert.Equal(esperat[1, 0], MetodesArrays.OmpleMatriuPerColumnes(2, 2)[1, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuPerColumnes(2, 2)[0, 1]);
            }

            [Fact]
            [Trait("Categoria", "1.18")] // OmplirMatriuNaturals
            public void Test_OmpleMatriuConsecutius()
            {
                int[,] esperat = { { 1, 3 }, { 2, 4 } };
                Assert.Equal(esperat[0, 0], MetodesArrays.OmpleMatriuConsecutius(2, 2)[0, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuConsecutius(2, 2)[0, 1]);
                Assert.Equal(esperat[1, 0], MetodesArrays.OmpleMatriuConsecutius(2, 2)[1, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuConsecutius(2, 2)[0, 1]);
            }

            [Fact]
            [Trait("Categoria", "1.19")] // OmpleMatriuNaturals
            public void Test_OmpleMatriuConsecutiusInvers()
            {
                int[,] esperat = { { 4, 2 }, { 3, 1 } };
                Assert.Equal(esperat[0,0], MetodesArrays.OmpleMatriuConsecutiusInvers(2, 2)[0,0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuConsecutiusInvers(2, 2)[0, 1]);
                Assert.Equal(esperat[1, 0], MetodesArrays.OmpleMatriuConsecutiusInvers(2, 2)[1, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuConsecutiusInvers(2, 2)[0, 1]);
            }

            [Fact]
            [Trait("Categoria", "1.20")] // OmpleMatriuIdentitat
            public void Test_OmpleMatriuIdentitat()
            {
                int[,] esperat = { { 1, 0 }, { 0, 1 } };
                Assert.Equal(esperat[0, 0], MetodesArrays.OmpleMatriuIdentitat(2)[0, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuIdentitat(2)[0, 1]);
                Assert.Equal(esperat[1, 0], MetodesArrays.OmpleMatriuIdentitat(2)[1, 0]);
                Assert.Equal(esperat[0, 1], MetodesArrays.OmpleMatriuIdentitat(2)[0, 1]);
            }

            [Fact]
            [Trait("Categoria", "1.21")] // PosicioMinimMatriu
            public void Test_MinimMatriu()
            {
                int[,] matriu = { { 10, 50 }, { 5, 20 } };
                Assert.Equal(5, MetodesArrays.MinimMatriu(matriu));
            }

            [Fact]
            [Trait("Categoria", "1.22")] // PosicioMinimMatriu
            public void Test_PosicioMinimMatriu()
            {
                int[,] matriu = { { 10, 50 }, { 5, 20 } };
                int[] esperat = { 1, 0 }; // Fila 1, Columna 0
                Assert.True(TaulesIguals<int>(esperat, MetodesArrays.PosicioMinimMatriu(matriu)));
            }
        }
    }
}
