using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCoopain.Modeles
{
    [Table("PrestationVisite")]
    public class PrestationVisite
    {
        #region Attributs
        private int _id;
        Visite _laVisite;
        private TypePrestation _leTypePrestation; // le type de prestation effectuée durant la visite
        private int _nombreActes;
        #endregion

        #region Constructeurs

        public PrestationVisite()
        {
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public int NombreActes { get => _nombreActes; set => _nombreActes = value; }

        [ForeignKey(typeof(TypePrestation))]
        public int LeTypePrestationId { get; set; }

        [ManyToOne(nameof(LeTypePrestationId))] 
        public TypePrestation LeTypePrestation { get => _leTypePrestation; set => _leTypePrestation = value; }
        
        [ForeignKey(typeof(Visite))]
        public int VisiteId { get; set; }
        [ManyToOne(nameof(VisiteId))]
        public Visite LaVisite { get => _laVisite; set => _laVisite = value; }
        #endregion

        #region Methodes

        public PrestationVisite AjoutTypePrestation(int nombreActe,TypePrestation leTypePrestation)
        {
            this.LeTypePrestation = leTypePrestation;
            this.NombreActes = nombreActe;

            return this;

        }

        #endregion
    }
}
