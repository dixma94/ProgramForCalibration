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

        public enum I_type
        {
            AUTO,
            _30mA,
            _300mA,
            _1A
        }
        public void ACDCI(I_type type, double resolution) 
        {
            switch (type)
            {
                case I_type.AUTO:
                    session.Write("ACDCI AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._30mA:
                    session.Write("ACDCI .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._300mA:
                    session.Write("ACDCI .3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._1A:
                    session.Write("ACDCI 1," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                default:
                    break;
            }
           
            
        }
        public enum V_type
        {
            AUTO,
            _30mV,
            _300mV,
            _3V,
            _30V,
            _300V

        }
        public void ACDCV(V_type type, double resolution) 
        {
            switch (type)
            {
                case V_type.AUTO:
                    session.Write("ACDCV AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30mV:
                    session.Write("ACDCV .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300mV:
                    session.Write("ACDCV 0.3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._3V:
                    session.Write("ACDCV 3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30V:
                    session.Write("ACDCV 30," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300V:
                    session.Write("ACDCV 300," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                default:
                    break;
            }
            
        }
        /// <summary>

        public void ACI(I_type type, double resolution)
        {
            switch (type)
            {
                case I_type.AUTO:
                    session.Write("ACI AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._30mA:
                    session.Write("ACI .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._300mA:
                    session.Write("ACI .3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._1A:
                    session.Write("ACI 1," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                default:
                    break;
            }


        }
        public void ACV(V_type type, double resolution)
        {
            switch (type)
            {
                case V_type.AUTO:
                    session.Write("ACV AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30mV:
                    session.Write("ACV .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300mV:
                    session.Write("ACV 0.3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._3V:
                    session.Write("ACV 3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30V:
                    session.Write("ACV 30," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300V:
                    session.Write("ACV 300," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                default:
                    break;
            }

        }
        public void ADDRESS( int adress)
        {
            session.Write("ACBAND " + adress.ToString());
        }

        public enum Arange_type
        {
            OFF,
            ON
        }

        public void ARANGE(Arange_type type) 
        {
            session.Write("ARANGE " + type.ToString());
        }

        public void AUXERR_() {
            session.Write("AUXERR?");
        }
        public enum AZERO_type
        {
            OFF,
            ON,
            ONCE
        }
        public void AZERO(AZERO_type type) 
        {
            session.Write("AZERO " + type.ToString());
        }
        public void AZERO_() { session.Write("AZERO?"); }

        public enum Beep_type
        {
            OFF,
            ON,
            ONCE
        }
        public void BEEP(Beep_type type) { session.Write("BEEP " + type.ToString()); }

        public void CALL(int subProgram) { session.Write("CALL " + subProgram.ToString()); }

        public void CALNUM_() { session.Write("CALNUM?"); }

        public void CHAN(int channel) { session.Write("CHAN " + channel.ToString()); }

        public void CHAN_() { session.Write("CHAN?"); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel">8 or 9</param>
        public void CLOSE(int channel) { session.Write("CLOSE " + channel.ToString()); }

        public void CRESET() { session.Write("CRESET"); }

        public void CSB() { session.Write("CSB"); }

       public enum DCI_type
        {
            AUTO,
            _300uA,
            _3mA,
            _30mA,
            _300mA,
            _1_5A,
        }
        public void DCI(DCI_type type, double resolution) 
        {
            switch (type)
            {
                case DCI_type.AUTO:
                    session.Write("DCI AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._300uA:
                    session.Write("DCI .0003," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._3mA:
                    session.Write("DCI .003," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._30mA:
                    session.Write("DCI .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._300mA:
                    session.Write("DCI .3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._1_5A:
                    session.Write("DCI 1.5," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                default:
                    break;
            }
          
        }
        public void DCV(V_type type, double resolution)
        {
            switch (type)
            {
                case V_type.AUTO:
                    session.Write("DCV AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30mV:
                    session.Write("DCV .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300mV:
                    session.Write("DCV 0.3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._3V:
                    session.Write("DCV 3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30V:
                    session.Write("DCV 30," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300V:
                    session.Write("DCV 300," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time">1us to 2100s</param>
        public void DELAY(double time) 
        {
            session.Write("DELAY " + time.ToString().Replace(",", "."));
        }
        public void DELAY_() { session.Write("DELAY?"); }

        public enum DISP_type
        {
            OFF,
            ON,
            MSG
        }
        public void DISP(DISP_type type, string message) { session.Write("DISP " + type.ToString()+"," +message); }

        //public void EMASK() { }

        //public void END() { }

        public void ERR_() { session.Write("ERR?"); }

        public enum Function_type
        {
            /// <summary>
            /// DC Autorange
            /// </summary>
            F10 =10,
            /// <summary>
            /// DC 30mV
            /// </summary>
            F11 = 11,
            /// <summary>
            /// DC 300mV
            /// </summary>
            F12 = 12,
            /// <summary>
            /// DC 3V
            /// </summary>
            F13 = 13,
            /// <summary>
            /// DC 30V
            /// </summary>
            F14 = 14,
            /// <summary>
            /// DC 300V
            /// </summary>
            F15 = 15,
            /// <summary>
            /// 2 Ohms Autorange
            /// </summary>
            F40 = 40,
            /// <summary>
            /// 2 Ohms 30
            /// </summary>
            F41 = 41,
            /// <summary>
            /// 2 Ohms 300
            /// </summary>
            F42 = 42,
            /// <summary>
            /// 2 Ohms 3k
            /// </summary>
            F43 = 43,
            /// <summary>
            /// 2 Ohms 30k
            /// </summary>
            F44 = 44,
            /// <summary>
            /// 2 Ohms 300k
            /// </summary>
            F45 = 45,
            /// <summary>
            /// 2 Ohms 3M
            /// </summary>
            F46 = 46,
            /// <summary>
            /// 2 Ohms 30M
            /// </summary>
            F47 = 47,
            /// <summary>
            /// 2 Ohms 3G
            /// </summary>
            F48 = 48,
            /// <summary>
            /// 4 Ohms Autorange
            /// </summary>
            F50 = 50,
            /// <summary>
            /// 4 Ohms 30
            /// </summary>
            F51 = 51,
            /// <summary>
            /// 4 Ohms 300
            /// </summary>
            F52 = 52,
            /// <summary>
            /// 4 Ohms 3k
            /// </summary>
            F53 = 53,
            /// <summary>
            /// 4 Ohms 30k
            /// </summary>
            F54 = 54,
            /// <summary>
            /// 4 Ohms 300k
            /// </summary>
            F55 = 55,
            /// <summary>
            /// 4 Ohms 3M
            /// </summary>
            F56 = 56,
            /// <summary>
            /// 4 Ohms 30M
            /// </summary>
            F57 = 57,
            /// <summary>
            /// 4 Ohms 3G
            /// </summary>
            F58 = 58,

        }
        public void F(Function_type function)
        {
            
            session.Write(function.ToString());
        }

        public void FIXEDZ(bool On_off)
        {
            if (On_off)
            {
                session.Write("FIXEDZ ON");
            }
            else
            {
                session.Write("FIXEDZ OFF");
            }
        }

        public void FIXEDZ_() { session.Write("FIXEDZ?"); }

        public void FREQ(double max_input) 
        {
            if (max_input >= 1)
            {
                session.Write("FREQ " + max_input.ToString().Replace(",", "."));
            }
            else
            {
                session.Write("FREQ " + max_input.ToString().Substring(1).Replace(",", "."));
            }

        }
        public enum FSOURCE_type
        {
            ACV,
            ACDCV,
            ACI,
            ACDCI
        }
        public void FSOURCE(FSOURCE_type type) { session.Write("FSOURCE " + type.ToString()); }

        //public void FUNC() { }

        public void ID_() { session.Write("ID?");  }

        public void INBUF(bool On_off)
        {
            if (On_off)
            {
                session.Write("INBUF ON");
            }
            else
            {
                session.Write("INBUF OFF");
            }
        }

        public void ISCALE_() { session.Write("ISCALE?"); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="freq">50 or 60</param>
        public void LFREQ(int freq) { session.Write("LFREQ "+freq.ToString()); }

        public void LFREQ_() { session.Write("LFREQ?"); }

        public void LINE_() { session.Write("LINE?"); }

        public void LOCK(bool On_Off)
        {
            if (On_Off)
            {
                session.Write("LOCK ON");
            }
            else
            {
                session.Write("LOCK OFF");
            }
        }

        //public void MATH() { }
        //public void MATH_() { }
        //public void MCOUNT_() { }
        //public void MEM() { }
        //public void MFORMAT() { }
        //public void MSIZE() { }
        //public void MSIZE_() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void NDIG(int value) { session.Write("NDIG " + (value+1).ToString()); }

        public void NPLC(double powerLineCycles)
        {
            if (powerLineCycles>=1)
            {
                session.Write("NPLC " + powerLineCycles.ToString().Replace(",","."));
            }
            else
            {
                session.Write("NPLC " + powerLineCycles.ToString().Replace(",", ".").Substring(1));

            } }
       
        public void NPLC_() { session.Write("NPLC?"); }

        public enum NRDGS_type
        {
            AUTO,
            EXT,
            SYN,
            TIMER
        }
        public void NRDGS(int count, NRDGS_type type ) 
        {
            session.Write("NRDGS " + count.ToString() + "," + type.ToString());
        }

        public void NRDGS_() { session.Write("NRDGS?"); }

        public void OCOMP(bool ON_OFF) {
            if (ON_OFF)
            {
                session.Write("OCOMP ON");
            }
            else
            {
                session.Write("OCOMP OFF");

            }
        }
        public void OCOMP_() { session.Write("OCOMP?"); }
        public enum OFORMAT_type
        {
            ASCII,
            SINT,
            DINT,
            SREAL
        }
        public void OFORMAT(OFORMAT_type type) { session.Write("OFORMAT " + type.ToString()); }
        public enum OHM_Range
        {
            AUTO,
            _30,
            _300,
            _3E3,
            _3E4,
            _3E5,
            _3E6,
            _3E7,
            _3E9

        }
        public void OHM(OHM_Range range,double resolution) {
            switch (range)
            {
                case OHM_Range.AUTO:
                    session.Write("OHM AUTO" +","+ resolution.ToString());
                    break;
                case OHM_Range._30:
                    session.Write("OHM 30" + "," + resolution.ToString());
                    break;
                case OHM_Range._300:
                    session.Write("OHM 300" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E3:
                    session.Write("OHM 3E3" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E4:
                    session.Write("OHM 3E4" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E5:
                    session.Write("OHM 3E5" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E6:
                    session.Write("OHM 3E6" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E7:
                    session.Write("OHM 3E7" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E9:
                    session.Write("OHM 3E9" + "," + resolution.ToString());
                    break;
                default:
                    break;
            }
        }

        public void OHMF(OHM_Range range, double resolution)
        {
            switch (range)
            {
                case OHM_Range.AUTO:
                    session.Write("OHMF AUTO" + "," + resolution.ToString());
                    break;
                case OHM_Range._30:
                    session.Write("OHMF 30" + "," + resolution.ToString());
                    break;
                case OHM_Range._300:
                    session.Write("OHMF 300" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E3:
                    session.Write("OHMF 3E3" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E4:
                    session.Write("OHMF 3E4" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E5:
                    session.Write("OHMF 3E5" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E6:
                    session.Write("OHMF 3E6" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E7:
                    session.Write("OHMF 3E7" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E9:
                    session.Write("OHMF 3E9" + "," + resolution.ToString());
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chanell">8 or 9</param>
        /// <param name="On_Off"></param>
        public void OPEN(int chanell, bool On_Off) {
            if (On_Off)
            {
                session.Write("OPEN " + chanell.ToString() + ",ON");
            }
            else
            {
                session.Write("OPEN " + chanell.ToString() + ",OFF");
            }
            
        }

        public void OPT_() { session.Write("OPT?"); }

        public void PAUSE() { session.Write("PAUSE"); }

        //public void PER() { }

        public void PRESET() { session.Write("PRESET"); }

        //public void R() { }
       // public void RANGE() { }

        public void RANGE_() { session.Write("RANGE?"); }

        public void RESET() { session.Write("RESET"); }


        //public void RMATH() { }
        //public void RMEM() { }
        //public void RQS() { }
        //public void RSTATE() { }
        //public void SADV() { }
        //public void SCRATCH() { }

        //public void SLIST() { }
        //public void SLIST_() { }
        //public void SMATH() { }
        
        public void SRQ() { session.Write("SRQ"); }

        //public void SSTATE() { }

        public void STB_() { session.Write("STB?"); }

        //public void SUB() { }
        //public void SUBEND() { }

        public enum TARM_type
        {
            AUTO,
            EXT,
            SGL,
            HOLD,
            SYN
        }
        public void TARM(TARM_type type, int number_arms)
        {
            switch (type)
            {
                case TARM_type.AUTO:
                    session.Write("TARM AUTO," + number_arms.ToString()) ;
                    break;
                case TARM_type.EXT:
                    session.Write("TARM EXT," + number_arms.ToString());
                    break;
                case TARM_type.SGL:
                    session.Write("TARM SGL," + number_arms.ToString());
                    break;
                case TARM_type.HOLD:
                    session.Write("TARM HOLD," + number_arms.ToString());
                    break;
                case TARM_type.SYN:
                    session.Write("TARM SYN," + number_arms.ToString());
                    break;
                default:
                    break;
            }
        }
        public void TARM_() { session.Write("TARM?"); }

        public void TBUFF(bool On_Off)
        {
            if (On_Off)
            {
                 session.Write("TBUFF ON");
            }
            else
            {
                session.Write("TBUFF OFF");
            }
        }
        public enum TERM_type
        {
            OPEN,
            FRONT,
            REAR,
            SCANNER
        }
        public void TERM(TERM_type type)
        {
            session.Write("TERM "+type.ToString());
        }
        public void TERM_() { session.Write("TERM?" ); }

        public void TEST() { session.Write("TEST"); }

        public void TIMER(int time) { session.Write("TIMER "+time.ToString()); }
        public void TIMER_() { session.Write("TIMER?"); }

        public void TONE(int frequency,int duration) { session.Write("TONE "+frequency.ToString()+duration.ToString()); }

        public void TRIG(TARM_type type) { session.Write("TRIG"+type.ToString()); }
        public void TRIG_() { session.Write("TRIG?"); }
        public void _() { session.Write("?"); }





        #endregion




    }
}
