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

        #region Commands
        public enum ACAL_type 
        {
            ALL=1,
            AC =2,
            OHMS =3
        }
        public void ACAL(ACAL_type type) 
        {
            session.Write("ACAL "+type.ToString());
        }
        public void ACBAND(int freq) 
        {
            session.Write("ACBAND " +freq.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="max_input"> -1_autorange, 0-0.03-30mA , 0.03-0.3-300mA , 0.3-1-1A</param>
        /// <param name="resolution">0.1 =0.1%</param>
        public void ACDCI(double max_input, double resolution) 
        {
            
        }

        public void ACDCV() { }
        public void ACI() { }
        public void ACV() { }
        public void ADDRESS() { }
        public void ARANGE() { }
        public void AUXERR_() { }
        public void AZERO() { }
        public void AZERO_() { }
        public void BEEP() { }
        public void CAL() { }
        public void CALL() { }
        public void CALNUM_() { }
        public void CHAN() { }
        public void CHAN_() { }
        public void CLOSE() { }
        public void CRESET() { }
        public void CSB() { }
        public void DCI() { }
        public void DCV() { }
        public void DELAY() { }
        public void DELAY_() { }
        public void DIAGNOSTIC() { }
        public void DISP() { }
        public void EMASK() { }
        public void END() { }
        public void ERR_() { }
        public void F() { }
        public void FIXEDZ() { }
        public void FIXEDZ_() { }
        public void FREQ() { }
        public void FSOURCE() { }
        public void FUNC() { }
        public void ID_() { }
        public void INBUF() { }
        public void ISCALE_() { }
        public void LFREQ() { }
        public void LFREQ_() { }
        public void LINE_() { }
        public void LOCK() { }
        public void MATH() { }
        public void MATH_() { }
        public void MCOUNT_() { }
        public void MEM() { }
        public void MFORMAT() { }
        public void MSIZE() { }
        public void MSIZE_() { }
        public void NDIG() { }
        public void NPLC() { }
        public void NPLC_() { }
        public void NRDGS() { }
        public void NRDGS_() { }
        public void OCOMP() { }
        public void OCOMP_() { }
        public void OFORMAT() { }
        public void OHM() { }
        public void OHMF() { }
        public void OPEN() { }
        public void OPT_() { }
        public void PAUSE() { }
        public void PER() { }
        public void PRESET() { }
        public void R() { }
        public void RANGE() { }
        public void RANGE_() { }
        public void RESET() { }
        public void REV_() { }
        public void RMATH() { }
        public void RMEM() { }
        public void RQS() { }
        public void RSTATE() { }
        public void SADV() { }
        public void SCRATCH() { }
        public void SECURE() { }
        public void SLIST() { }
        public void SLIST_() { }
        public void SMATH() { }
        public void SRQ() { }
        public void SSTATE() { }
        public void STB_() { }
        public void SUB() { }
        public void SUBEND() { }
        public void T() { }
        public void TARM() { }
        public void TARM_() { }
        public void TBUFF() { }
        public void TERM() { }
        public void TERM_() { }
        public void TEST() { }
        public void TIMER() { }
        public void TIMER_() { }
        public void TONE() { }
        public void TRIG() { }
        public void TRIG_() { }
        public void _() { }





        #endregion




    }
}
