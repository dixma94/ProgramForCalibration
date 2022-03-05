using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramForCalibration.Model
{
   public class HP3457_Model
    {
        GpibSession session;

        public HP3457_Model(GpibSession gpibSession)
        {
            session = gpibSession;
            
        }

        
       
    }
}
