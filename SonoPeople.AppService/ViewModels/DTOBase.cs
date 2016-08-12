using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.AppService.ViewModels
{
    public class VMBase
    {
        public int Id { get; set; }  

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// We need to override Equals so that we can use the DTO for certain
        /// UI funcationalities such as comboBox.Items.IndexOf to work correctly
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            var other = obj as VMBase;
            if (other == null) return false;
            return Id == other.Id;
        }
    }
}
