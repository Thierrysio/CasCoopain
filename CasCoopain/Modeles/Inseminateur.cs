using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles
{
    [Table("Inseminateur")]
    public class Inseminateur
    {
        #region Attributs
        private int _id;
        private String _nom;
        private String _prenom;
        private String _telPortable;
        private String _login;
        private String _password;

        #endregion

        #region Constructeurs

        public Inseminateur()
        {
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string TelPortable { get => _telPortable; set => _telPortable = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }

        #endregion

        #region Methodes
        public Inseminateur AjoutInseminateur(string nom, string prenom, string telPortable, string login, string password)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.TelPortable = telPortable;
            this.Login = login;
            this.Password = password;

            return this;


        }
        #endregion
    }
}
