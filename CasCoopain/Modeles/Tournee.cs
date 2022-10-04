using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles
{
    [Table("Tournee")]

    public class Tournee
    {
        #region Attributs
        private int _id;
        private DateTime _date;
        private int _kmRealises; // nombre de km effectués pendant la tournée
        private Inseminateur _leInseminateur;
        private List<Visite> _lesVisites;


        #endregion

        #region Constructeurs

        public Tournee()
        {
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int KmRealises { get => _kmRealises; set => _kmRealises = value; }
        [ForeignKey(typeof(Inseminateur))]
        public int InseminateurId { get; set; }
        
        [ManyToOne(nameof(InseminateurId))]
        public Inseminateur LeInseminateur { get => _leInseminateur; set => _leInseminateur = value; }
        
        [ManyToMany(typeof(Visiter))]
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }

        #endregion

        #region Methodes

        public Tournee AjoutUneTournee(DateTime date,int kmsRealises,Inseminateur leInseminateur)
        {
            this.LeInseminateur = leInseminateur;
            this.LesVisites = new List<Visite>();
            this.Date = date;
            this.KmRealises = kmsRealises;

            return this;

        }

        public Tournee AjoutUneVisiteALaTournee(Visite uneVisite)
        {
            this.LesVisites.Add(uneVisite);
            uneVisite.AjoutLaTournee(this);

            return this;

        }

        #endregion
    }
}
