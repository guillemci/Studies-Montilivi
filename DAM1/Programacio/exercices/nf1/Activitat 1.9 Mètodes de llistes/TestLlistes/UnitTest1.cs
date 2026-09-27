using Llistes;

namespace TestLlistes
{
    public class TestsMetodesLlistes
    {
        // Auxiliar per comparar llistes de llistes (Matrius)
        private bool MatriusIguals(List<List<int>> esperada, List<List<int>> actual)
        {
            if (esperada.Count != actual.Count) return false;
            for (int i = 0; i < esperada.Count; i++)
            {
                if (!esperada[i].SequenceEqual(actual[i])) return false;
            }
            return true;
        }

        [Fact]
        [Trait("Categoria", "L1.1")] // OmpleNaturals
        public void Test_OmpleNaturals()
        {
            Assert.Equal(new List<int> { 0, 1, 2 }, MetodesLlistes.OmpleNaturals(3));
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, MetodesLlistes.OmpleNaturals(10));
            Assert.Equal(new List<int> { 1 }, MetodesLlistes.OmpleNaturals(1));
            Assert.Empty(MetodesLlistes.OmpleNaturals(0));
        }

        [Fact]
        [Trait("Categoria", "L1.2")] // GeneraLlista
        public void Test_GeneraLlista()
        {
            var llista = MetodesLlistes.GeneraLlista(6,9);
            Assert.NotNull(llista);
            Assert.Equal(6, llista.Count);
            Assert.Equal(new List<int> { 72, 15, 92, 67, 82, 60 }, llista);
            Assert.Equal(new List<int> { 72, 15, 92 }, MetodesLlistes.GeneraLlista(3,6));
            Assert.Empty(MetodesLlistes.GeneraLlista(0,6));
            Assert.Equal(new List<int> { 72 }, MetodesLlistes.GeneraLlista(1, 6));
        }

        [Fact]
        [Trait("Categoria", "L1.3")] // SumaLlista
        public void Test_SumaLlista()
        {
            Assert.Equal(60, MetodesLlistes.SumaLlista(new List<int> { 10, 20, 30 }));
            Assert.Equal(21, MetodesLlistes.SumaLlista(new List<int> { 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(0, MetodesLlistes.SumaLlista(new List<int>()));
        }

        [Fact]
        [Trait("Categoria", "L1.4")] // MinimLlista
        public void Test_MinimLlista()
        {
            Assert.Equal(10, MetodesLlistes.MinimLlista(new List<int> { 30, 10, 20 }));
            Assert.Equal(-60, MetodesLlistes.MinimLlista(new List<int> { 30, -60, 20 }));
            Assert.Equal(30, MetodesLlistes.MinimLlista(new List<int> { 30, 30, 30 }));
        }

        [Fact]
        [Trait("Categoria", "L1.5")] // PosicioMinimLlista
        public void Test_PosicioMinimLlista()
        {
            Assert.Equal(1, MetodesLlistes.PosicioMinimLlista(new List<int> { 30, 10, 20 }));
            Assert.Equal(1, MetodesLlistes.PosicioMinimLlista(new List<int> { 30, -60, 20 }));
            Assert.Equal(0, MetodesLlistes.PosicioMinimLlista(new List<int> { 30, 30, 30 }));
        }

        [Fact]
        [Trait("Categoria", "L1.6")] // MaximLlista
        public void Test_MaximLlista()
        {
            Assert.Equal(30, MetodesLlistes.MaximLlista(new List<int> { 30, 10, 20 }));
            Assert.Equal(30, MetodesLlistes.MaximLlista(new List<int> { -60, 30, 20 }));
            Assert.Equal(30, MetodesLlistes.MaximLlista(new List<int> { 30, 30, 30 }));
        }

        [Fact]
        [Trait("Categoria", "L1.7")] // MitjanaLlista
        public void Test_MitjanaLlista()
        {
            Assert.Equal(20D, MetodesLlistes.MitjanaLlista(new List<int> { 30, 10, 20 }));
            Assert.Equal(-10D, MetodesLlistes.MitjanaLlista(new List<int> { 10, -60, 20 }));
            Assert.Equal(5.5D, MetodesLlistes.MitjanaLlista(new List<int> { 0, 11 }));
        }

        [Fact]
        [Trait("Categoria", "L1.8")] // CapgiraLlista
        public void Test_CapgiraLlista()
        {
            List<int> llista = new List<int> { 1, 2, 3, 4, 5 };
            MetodesLlistes.CapgiraLlista(llista);
            Assert.Equal(new List<int> { 4, 3, 2, 1 }, llista);
            List<int> llista2 = new List<int> { 1, 2, 3, 4, 5 };
            MetodesLlistes.CapgiraLlista(llista2);
            Assert.Equal(new List<int> { 4, 3, 2, 1 }, llista2);
        }

        [Fact]
        [Trait("Categoria", "L1.9")] // PosicioDe
        public void Test_PosicioDe()
        {
            Assert.Equal(0, MetodesLlistes.PosicioDe(new List<int> { 30, 10, 20 }, 30));
            Assert.Equal(2, MetodesLlistes.PosicioDe(new List<int> { 30, 10, 20 }, 20));
            Assert.Equal(-1, MetodesLlistes.PosicioDe(new List<int> { 30, 10, 20 }, 15));
        }

        [Fact]
        [Trait("Categoria", "L1.10")] // Conte
        public void Test_Conte()
        {
            Assert.True(MetodesLlistes.Conte(new List<int> { 30, 10, 20 }, 30));
            Assert.False(MetodesLlistes.Conte(new List<int> { 30, 10, 20 }, 15));
        }

        [Fact]
        [Trait("Categoria", "L1.11")] // ConteEnRang
        public void Test_ConteEnRang()
        {
            var llista = new List<int> { 30, 10, 20, -15, 100, 0, -18 };
            Assert.True(MetodesLlistes.ConteEnRang(llista, -15, 0, 3));
            Assert.False(MetodesLlistes.ConteEnRang(llista, -15, 0, 2));
        }

        [Fact]
        [Trait("Categoria", "L1.12")] // LlistaAString
        public void Test_LlistaAString()
        {
            string esperat = "Index 0: 10\nIndex 1: 20";
            Assert.Equal(esperat, MetodesLlistes.LlistaAString(new List<int> { 10, 20 }));
        }

        [Fact]
        [Trait("Categoria", "L1.13")] // ComunsOrdenades
        public void Test_ComunsOrdenades()
        {
            var l1 = new List<int> { 1, 3, 5, 7, 9 };
            var l2 = new List<int> { 3, 4, 5, 6, 10 };
            // Els comuns són 3 i 5
            var esperat = new List<int> { 3, 5 };

            Assert.Equal(esperat, MetodesLlistes.ComunsOrdenades(l1, l2));
        }

        [Fact]
        [Trait("Categoria", "L1.14")] // NoComunsOrdenades
        public void Test_NoComunsOrdenades()
        {
            var l1 = new List<int> { 1, 3, 5, 7 };
            var l2 = new List<int> { 3, 4, 5, 6 };
            // No comuns: 1, 7 (de l1) i 4, 6 (de l2) -> Ordenats: 1, 4, 6, 7
            var esperat = new List<int> { 1, 4, 6, 7 };

            Assert.Equal(esperat, MetodesLlistes.NoComunsOrdenades(l1, l2));
        }

        [Fact]
        [Trait("Categoria", "L1.15")] // FusioOrdenades
        public void Test_FusioOrdenades()
        {
            var l1 = new List<int> { 1, 3, 4, 5 };
            var l2 = new List<int> { 2, 3, 4, 6 };
            // Fusió ordenada: 1, 2, 3, 4, 5, 6
            var esperat = new List<int> { 1, 2, 3, 4, 5, 6 };

            Assert.Equal(esperat, MetodesLlistes.FusioOrdenades(l1, l2));
        }

        [Fact]
        [Trait("Categoria", "L1.16")] // OmpleMatriuPerFiles
        public void Test_OmpleMatriuPerFiles()
        {
            var esperat = new List<List<int>> {
                new List<int> { 1, 1 },
                new List<int> { 2, 2 }
            };
            var resultat = MetodesLlistes.OmpleMatriuPerFiles(2, 2);
            Assert.True(MatriusIguals(esperat, resultat));
        }

        [Fact]
        [Trait("Categoria", "L1.17")] // OmpleMatriuPerColumnes
        public void Test_OmpleMatriuPerColumnes()
        {
            var esperat = new List<List<int>> {
                new List<int> { 1, 2 },
                new List<int> { 1, 2 }
            };
            var resultat = MetodesLlistes.OmpleMatriuPerColumnes(2, 2);
            Assert.True(MatriusIguals(esperat, resultat));
        }

        [Fact]
        [Trait("Categoria", "L1.18")] // OmpleMatriuConsecutius
        public void Test_OmpleMatriuConsecutius()
        {
            var esperat = new List<List<int>> {
                new List<int> { 1, 2 },
                new List<int> { 3, 4 }
            };
            var resultat = MetodesLlistes.OmpleMatriuConsecutius(2, 2);
            Assert.True(MatriusIguals(esperat, resultat));
        }

        [Fact]
        [Trait("Categoria", "L1.19")] // OmpleMatriuConsecutiusInvers
        public void Test_OmpleMatriuConsecutiusInvers()
        {
            var esperat = new List<List<int>> {
                new List<int> { 4, 3 },
                new List<int> { 2, 1 }
            };
            var resultat = MetodesLlistes.OmpleMatriuConsecutiusInvers(2, 2);
            Assert.True(MatriusIguals(esperat, resultat));
        }

        [Fact]
        [Trait("Categoria", "L1.20")] // OmpleMatriuIdentitat
        public void Test_OmpleMatriuIdentitat()
        {
            var esperat = new List<List<int>> {
                new List<int> { 1, 0 },
                new List<int> { 0, 1 }
            };
            var resultat = MetodesLlistes.OmpleMatriuIdentitat(2);
            Assert.True(MatriusIguals(esperat, resultat));
        }

        [Fact]
        [Trait("Categoria", "L1.21")] // MinimMatriu
        public void Test_MinimMatriu()
        {
            var matriu = new List<List<int>> {
                new List<int> { 10, 50 },
                new List<int> { 5, 20 }
            };
            Assert.Equal(5, MetodesLlistes.MinimMatriu(matriu));
        }

        [Fact]
        [Trait("Categoria", "L1.22")] // PosicioMinimMatriu
        public void Test_PosicioMinimMatriu()
        {
            var matriu = new List<List<int>> {
                new List<int> { 10, 50 },
                new List<int> { 5, 20 }
            };
            int[] esperat = { 1, 0 }; // Fila 1, Columna 0
            Assert.Equal(esperat, MetodesLlistes.PosicioMinimMatriu(matriu));
        }
    }
}