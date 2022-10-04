using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles
{
    [Table("Visite")]
    public class Visite
    {
        #region Attributs
        private int _id;
        private Adherent _leAdherent;
        private String _heure; // sous la forme hh:mm par exemple "09:00"
        private List<PrestationVisite> _lesPrestationsVisite;
        private List<Tournee> _lesTournees;

        #endregion

        #region Constructeurs

        public Visite()
        {
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }

        [ForeignKey(typeof(Adherent))]
        public int AdherentId { get; set; }
        [ManyToOne(nameof(AdherentId))]
        public Adherent LeAdherent { get => _leAdherent; set => _leAdherent = value; }
        public string Heure { get => _heure; set => _heure = value; }
        
        [OneToMany] 
        public List<PrestationVisite> LesPrestationsVisite { get => _lesPrestationsVisite; set => _lesPrestationsVisite = value; }

        [ManyToMany(typeof(Visiter))]
        public List<Tournee> LesTournees { get => _lesTournees; set => _lesTournees = value; }

        #endregion

        #region Methodes

        public Visite AjoutVisite(string heure,Adherent leAdherent)
        {
            this.LeAdherent = leAdherent;
            this.Heure = heure;
            this.LesPrestationsVisite = new List<PrestationVisite>();
            this.LesTournees = new List<Tournee>();

            return this;

        }

        public void AjoutLaTournee(Tournee uneTournee)
        {
            this.LesTournees.Add(uneTournee);
        }

        #endregion
    }
}
