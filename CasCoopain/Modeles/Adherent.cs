using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles
{
    [Table("Adherent")]
    public class Adherent
    {
        #region Attributs
        private int _id;
        private String _nom;
        private String _prenom;
        private String _telPortable;
        private String _latitude;
        private String _longitude;
        #endregion

        #region Constructeurs

        public Adherent()
        {
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string TelPortable { get => _telPortable; set => _telPortable = value; }
        public string Latitude { get => _latitude; set => _latitude = value; }
        public string Longitude { get => _longitude; set => _longitude = value; }

        #endregion

        #region Methodes

        public Adherent AjoutAdherent(string nom,string prenom,string telPortable,string latitude,string longitude)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.TelPortable = telPortable;
            this.Latitude = latitude;
            this.Longitude = longitude;

            return this;
        }

        #endregion
    }
}
