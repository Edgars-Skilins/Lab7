using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class QualifLevel
    {
        public QualifLevel() { }
        public List<QualifLevel> GetData() { return Levels; }

        public static List<QualifLevel> Levels
        {
            get
            {
                if (_levels == null)
                {
                    _levels = new List<QualifLevel>()
                    {
                    new QualifLevel(0, "nav definēts"),
                    new QualifLevel(1, "pirmā līmeņa"),
                    new QualifLevel(2, "bakalaura"),
                    new QualifLevel(3, "maģistra"),
                    new QualifLevel(4, "doktora")
                    };
                }
                return _levels;
            }
        }
        private static List<QualifLevel> _levels;
        public const string ValueMember = "LevelId";
        public int LevelId { get { return _levelId; } }
        private int _levelId;
        public const string DisplayMember = "LevelDescription";
        public string LevelDescription { get { return _levelDescription; } }
        private string _levelDescription;
        private QualifLevel(int id, string descr)
        {
            _levelId = id;
            _levelDescription = descr;
        }

    }
}
