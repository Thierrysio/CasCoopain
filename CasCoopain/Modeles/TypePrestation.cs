
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles
{
    [Table("TypePrestation")]

    public class TypePrestation
    {
        #region Attributs
        private int _id;
        private String _libelle;
        private float _prixForfaitaire;
        private List<PrestationVisite> _lesPrestationsVisites;

        #endregion

        #region Constructeurs

        public TypePrestation()
        {
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public float PrixForfaitaire { get => _prixForfaitaire; set => _prixForfaitaire = value; }
        [OneToMany]
        public List<PrestationVisite> LesPrestationsVisites { get => _lesPrestationsVisites; set => _lesPrestationsVisites = value; }

        #endregion

        #region Methodes
        public TypePrestation AjoutTypePrestation(string libelle,float prixForfaitaire)
        {
            this.Libelle = libelle;
            this.PrixForfaitaire = prixForfaitaire;
            this.LesPrestationsVisites = new List<PrestationVisite>();

            return this;

        }
        public void AjoutunePrestationVisite(PrestationVisite unePrestationVisite)
        {
            this.LesPrestationsVisites.Add(unePrestationVisite);
        }

        #endregion
    }
}
