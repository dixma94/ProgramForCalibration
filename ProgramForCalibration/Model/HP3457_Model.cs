using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramForCalibration.Model
{
    public interface IDevice
    {
        GpibSession Session { get; set; }
        string Name { get; set; }
    }
   public class HP3457_Model: IDevice
    {
         
        
        public GpibSession Session { get; set; }
        public string Name { get; set; } = "HP3457";



        public HP3457_Model(GpibSession gpibSession)
        {
            Session = gpibSession;
            
        }

        #region Commands
        public string Read()
        {

            return Session.Read(16);
        }
        public enum ACAL_type 
        {
            ALL=1,
            AC =2,
            OHMS =3
        }
        public void ACAL(ACAL_type type) 
        {
            Session.Write("ACAL "+type.ToString());
        }
        public void ACBAND(int freq) 
        {
            Session.Write("ACBAND " +freq.ToString());
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
                    Session.Write("ACDCI AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._30mA:
                    Session.Write("ACDCI .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._300mA:
                    Session.Write("ACDCI .3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._1A:
                    Session.Write("ACDCI 1," + resolution.ToString().Substring(1).Replace(",", "."));
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
                    Session.Write("ACDCV AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30mV:
                    Session.Write("ACDCV .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300mV:
                    Session.Write("ACDCV 0.3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._3V:
                    Session.Write("ACDCV 3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30V:
                    Session.Write("ACDCV 30," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300V:
                    Session.Write("ACDCV 300," + resolution.ToString().Substring(1).Replace(",", "."));
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
                    Session.Write("ACI AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._30mA:
                    Session.Write("ACI .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._300mA:
                    Session.Write("ACI .3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case I_type._1A:
                    Session.Write("ACI 1," + resolution.ToString().Substring(1).Replace(",", "."));
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
                    Session.Write("ACV AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30mV:
                    Session.Write("ACV .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300mV:
                    Session.Write("ACV 0.3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._3V:
                    Session.Write("ACV 3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30V:
                    Session.Write("ACV 30," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300V:
                    Session.Write("ACV 300," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                default:
                    break;
            }

        }
        public void ADDRESS( int adress)
        {
            Session.Write("ACBAND " + adress.ToString());
        }

        public enum Arange_type
        {
            OFF,
            ON
        }

        public void ARANGE(Arange_type type) 
        {
            Session.Write("ARANGE " + type.ToString());
        }

        public void AUXERR_() {
            Session.Write("AUXERR?");
        }
        public enum AZERO_type
        {
            OFF,
            ON,
            ONCE
        }
        public void AZERO(AZERO_type type) 
        {
            Session.Write("AZERO " + type.ToString());
        }
        public void AZERO_() { Session.Write("AZERO?"); }

        public enum Beep_type
        {
            OFF,
            ON,
            ONCE
        }
        public void BEEP(Beep_type type) { Session.Write("BEEP " + type.ToString()); }

        public void CALL(int subProgram) { Session.Write("CALL " + subProgram.ToString()); }

        public void CALNUM_() { Session.Write("CALNUM?"); }

        public void CHAN(int channel) { Session.Write("CHAN " + channel.ToString()); }

        public void CHAN_() { Session.Write("CHAN?"); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel">8 or 9</param>
        public void CLOSE(int channel) { Session.Write("CLOSE " + channel.ToString()); }

        public void CRESET() { Session.Write("CRESET"); }

        public void CSB() { Session.Write("CSB"); }

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
                    Session.Write("DCI AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._300uA:
                    Session.Write("DCI .0003," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._3mA:
                    Session.Write("DCI .003," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._30mA:
                    Session.Write("DCI .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._300mA:
                    Session.Write("DCI .3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case DCI_type._1_5A:
                    Session.Write("DCI 1.5," + resolution.ToString().Substring(1).Replace(",", "."));
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
                    Session.Write("DCV AUTO," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30mV:
                    Session.Write("DCV .03," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300mV:
                    Session.Write("DCV 0.3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._3V:
                    Session.Write("DCV 3," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._30V:
                    Session.Write("DCV 30," + resolution.ToString().Substring(1).Replace(",", "."));
                    break;
                case V_type._300V:
                    Session.Write("DCV 300," + resolution.ToString().Substring(1).Replace(",", "."));
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
            Session.Write("DELAY " + time.ToString().Replace(",", "."));
        }
        public void DELAY_() { Session.Write("DELAY?"); }

        public enum DISP_type
        {
            OFF,
            ON,
            MSG
        }
        public void DISP(DISP_type type, string message) { Session.Write("DISP " + type.ToString()+"," +message); }

        //public void EMASK() { }

        //public void END() { }

        public void ERR_() { Session.Write("ERR?"); }

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
            
            Session.Write(function.ToString());
        }

        public void FIXEDZ(bool On_off)
        {
            if (On_off)
            {
                Session.Write("FIXEDZ ON");
            }
            else
            {
                Session.Write("FIXEDZ OFF");
            }
        }

        public void FIXEDZ_() { Session.Write("FIXEDZ?"); }

        public void FREQ(double max_input) 
        {
            if (max_input >= 1)
            {
                Session.Write("FREQ " + max_input.ToString().Replace(",", "."));
            }
            else
            {
                Session.Write("FREQ " + max_input.ToString().Substring(1).Replace(",", "."));
            }

        }
        public enum FSOURCE_type
        {
            ACV,
            ACDCV,
            ACI,
            ACDCI
        }
        public void FSOURCE(FSOURCE_type type) { Session.Write("FSOURCE " + type.ToString()); }

        //public void FUNC() { }

        public void ID_() { Session.Write("ID?");  }

        public void INBUF(bool On_off)
        {
            if (On_off)
            {
                Session.Write("INBUF ON");
            }
            else
            {
                Session.Write("INBUF OFF");
            }
        }

        public void ISCALE_() { Session.Write("ISCALE?"); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="freq">50 or 60</param>
        public void LFREQ(int freq) { Session.Write("LFREQ "+freq.ToString()); }

        public void LFREQ_() { Session.Write("LFREQ?"); }

        public void LINE_() { Session.Write("LINE?"); }

        public void LOCK(bool On_Off)
        {
            if (On_Off)
            {
                Session.Write("LOCK ON");
            }
            else
            {
                Session.Write("LOCK OFF");
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
        public void NDIG(int value) { Session.Write("NDIG " + (value+1).ToString()); }

        public void NPLC(double powerLineCycles)
        {
            if (powerLineCycles>=1)
            {
                Session.Write("NPLC " + powerLineCycles.ToString().Replace(",","."));
            }
            else
            {
                Session.Write("NPLC " + powerLineCycles.ToString().Replace(",", ".").Substring(1));

            } }
       
        public void NPLC_() { Session.Write("NPLC?"); }

        public enum NRDGS_type
        {
            AUTO,
            EXT,
            SYN,
            TIMER
        }
        public void NRDGS(int count, NRDGS_type type ) 
        {
            Session.Write("NRDGS " + count.ToString() + "," + type.ToString());
        }

        public void NRDGS_() { Session.Write("NRDGS?"); }

        public void OCOMP(bool ON_OFF) {
            if (ON_OFF)
            {
                Session.Write("OCOMP ON");
            }
            else
            {
                Session.Write("OCOMP OFF");

            }
        }
        public void OCOMP_() { Session.Write("OCOMP?"); }
        public enum OFORMAT_type
        {
            ASCII,
            SINT,
            DINT,
            SREAL
        }
        public void OFORMAT(OFORMAT_type type) { Session.Write("OFORMAT " + type.ToString()); }
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
                    Session.Write("OHM AUTO" +","+ resolution.ToString());
                    break;
                case OHM_Range._30:
                    Session.Write("OHM 30" + "," + resolution.ToString());
                    break;
                case OHM_Range._300:
                    Session.Write("OHM 300" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E3:
                    Session.Write("OHM 3E3" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E4:
                    Session.Write("OHM 3E4" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E5:
                    Session.Write("OHM 3E5" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E6:
                    Session.Write("OHM 3E6" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E7:
                    Session.Write("OHM 3E7" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E9:
                    Session.Write("OHM 3E9" + "," + resolution.ToString());
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
                    Session.Write("OHMF AUTO" + "," + resolution.ToString());
                    break;
                case OHM_Range._30:
                    Session.Write("OHMF 30" + "," + resolution.ToString());
                    break;
                case OHM_Range._300:
                    Session.Write("OHMF 300" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E3:
                    Session.Write("OHMF 3E3" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E4:
                    Session.Write("OHMF 3E4" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E5:
                    Session.Write("OHMF 3E5" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E6:
                    Session.Write("OHMF 3E6" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E7:
                    Session.Write("OHMF 3E7" + "," + resolution.ToString());
                    break;
                case OHM_Range._3E9:
                    Session.Write("OHMF 3E9" + "," + resolution.ToString());
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
                Session.Write("OPEN " + chanell.ToString() + ",ON");
            }
            else
            {
                Session.Write("OPEN " + chanell.ToString() + ",OFF");
            }
            
        }

        public void OPT_() { Session.Write("OPT?"); }

        public void PAUSE() { Session.Write("PAUSE"); }

        //public void PER() { }

        public void PRESET() { Session.Write("PRESET"); }

        //public void R() { }
       // public void RANGE() { }

        public void RANGE_() { Session.Write("RANGE?"); }

        public void RESET() { Session.Write("RESET"); }


        //public void RMATH() { }
        //public void RMEM() { }
        //public void RQS() { }
        //public void RSTATE() { }
        //public void SADV() { }
        //public void SCRATCH() { }

        //public void SLIST() { }
        //public void SLIST_() { }
        //public void SMATH() { }
        
        public void SRQ() { Session.Write("SRQ"); }

        //public void SSTATE() { }

        public void STB_() { Session.Write("STB?"); }

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
        public void TARM(TARM_type type)
        {
            switch (type)
            {
                case TARM_type.AUTO:
                    Session.Write("TARM AUTO");
                    break;
                case TARM_type.EXT:
                    Session.Write("TARM EXT");
                    break;
                case TARM_type.SGL:
                    Session.Write("TARM SGL");
                    break;
                case TARM_type.HOLD:
                    Session.Write("TARM HOLD");
                    break;
                case TARM_type.SYN:
                    Session.Write("TARM SYN");
                    break;
                default:
                    break;
            }
        }
        public void TARM(TARM_type type, int number_arms)
        {
            switch (type)
            {
                case TARM_type.AUTO:
                    Session.Write("TARM AUTO," + number_arms.ToString()) ;
                    break;
                case TARM_type.EXT:
                    Session.Write("TARM EXT," + number_arms.ToString());
                    break;
                case TARM_type.SGL:
                    Session.Write("TARM SGL," + number_arms.ToString());
                    break;
                case TARM_type.HOLD:
                    Session.Write("TARM HOLD," + number_arms.ToString());
                    break;
                case TARM_type.SYN:
                    Session.Write("TARM SYN," + number_arms.ToString());
                    break;
                default:
                    break;
            }
        }
        public void TARM_() { Session.Write("TARM?"); }

        public void TBUFF(bool On_Off)
        {
            if (On_Off)
            {
                 Session.Write("TBUFF ON");
            }
            else
            {
                Session.Write("TBUFF OFF");
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
            Session.Write("TERM "+type.ToString());
        }
        public void TERM_() { Session.Write("TERM?" ); }

        public void TEST() { Session.Write("TEST"); }

        public void TIMER(int time) { Session.Write("TIMER "+time.ToString()); }
        public void TIMER_() { Session.Write("TIMER?"); }

        public void TONE(int frequency,int duration) { Session.Write("TONE "+frequency.ToString()+duration.ToString()); }

        public void TRIG(TARM_type type) { Session.Write("TRIG"+type.ToString()); }
        public void TRIG_() { Session.Write("TRIG?"); }
        public void _() { Session.Write("?"); }





        #endregion




    }
}
