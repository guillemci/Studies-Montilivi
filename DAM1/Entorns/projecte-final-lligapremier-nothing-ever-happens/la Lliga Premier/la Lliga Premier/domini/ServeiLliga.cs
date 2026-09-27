using la_Lliga_Premier.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_Lliga_Premier.domini
{
    internal class ServeiLliga
    {
        public List<Equip> Equips { get; set; }
        public List<Partit> Partits { get; set; }

        public void CarregarDades()
        {
            Equips = persistencia.Persistencia.CarregarEquips("EQUIPS.CSV");
            Partits = persistencia.Persistencia.CarregarPartits("PARTITS.CSV");

            foreach (var partit in Partits)
            {
                Equip local = ObtenirEquip(partit.LocalId);
                Equip visitant = ObtenirEquip(partit.VisitantId);

                if (local != null)
                {
                    local.Partits.Add(partit);
                }
                if (visitant != null)
                {
                    visitant.Partits.Add(partit);
                }
            }
        }

        public Equip ObtenirEquip(string equipId)
        {
            return Equips.FirstOrDefault(e => e.Id == equipId);
        }

        public int ObtenirGolsFavor(string equipId)
        {
            Equip equip = ObtenirEquip(equipId);
            if (equip == null) return 0;

            int golsLocal = equip.Partits.Where(p => p.LocalId == equipId).Sum(p => p.GolsLocal);
            int golsVisitant = equip.Partits.Where(p => p.VisitantId == equipId).Sum(p => p.GolsVisitant);
            return golsLocal + golsVisitant;
        }

        public int ObtenirGolsContra(string equipId)
        {
            Equip equip = ObtenirEquip(equipId);
            if (equip == null) return 0;

            int golsContraLocal = equip.Partits.Where(p => p.LocalId == equipId).Sum(p => p.GolsVisitant);
            int golsContraVisitant = equip.Partits.Where(p => p.VisitantId == equipId).Sum(p => p.GolsLocal);
            return golsContraLocal + golsContraVisitant;
        }

        public int ObtenirPuntsTotals(string equipId)
        {
            Equip equip = ObtenirEquip(equipId);
            if (equip == null) return 0;

            int punts = 0;

            foreach (var partit in equip.Partits)
            {
                if (partit.LocalId == equipId)
                {
                    if (partit.GolsLocal > partit.GolsVisitant) punts += 3;
                    else if (partit.GolsLocal == partit.GolsVisitant) punts += 1;
                }
                else if (partit.VisitantId == equipId)
                {
                    if (partit.GolsVisitant > partit.GolsLocal) punts += 3;
                    else if (partit.GolsLocal == partit.GolsVisitant) punts += 1;
                }
            }

            return punts;
        }

        public List<EquipClassificacio> GenerarClassificacio()
        {
            var llistaClassificacio = new List<EquipClassificacio>();

            foreach (var equip in Equips)
            {
                llistaClassificacio.Add(new EquipClassificacio(
                        equip.Nom,
                        ObtenirPuntsTotals(equip.Id),
                        ObtenirGolsFavor(equip.Id),
                        ObtenirGolsContra(equip.Id)));
            }
            return llistaClassificacio.OrderByDescending(c => c.Punts).ToList();
        }
    }
}
