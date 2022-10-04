using SQLite;
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

        #endregion

        #region Methodes
        public TypePrestation AjoutTypePrestation(string libelle,float prixForfaitaire)
        {
            this.Libelle = libelle;
            this.PrixForfaitaire = prixForfaitaire;

            return this;

        }

        #endregion
    }
}
