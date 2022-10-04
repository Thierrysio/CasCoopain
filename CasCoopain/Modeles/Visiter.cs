using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles
{
    [Table("Visiter")]
    public class Visiter
    {
        #region Attributs


        #endregion

        #region Constructeurs

        public Visiter()
        {
        }

        #endregion

        #region Getters/Setters
        [ForeignKey(typeof(Tournee))]
        public int TourneeId { get; set; }
        [ForeignKey(typeof(Visite))]
        public int VisiteId { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
