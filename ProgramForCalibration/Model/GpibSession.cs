using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NationalInstruments.Visa;


namespace ProgramForCalibration.Model
{

    public class GpibSession
    {
        

        private MessageBasedSession mbSession;

        public MessageBasedSession MbSession
        {
            get { return mbSession; }
            set { mbSession = value; }
        }

        public int TimeoutMilliseconds { get; set; } = 20000;

        public void Write(string command)
        {
            MbSession.RawIO.Write(command);
        }

        public string Read(int bytes)
        {
            return  MbSession.RawIO.ReadString(bytes);
        }

        public void Connect(string resourceName)
        {
            if (resourceName!=null)
            {
                using (var rmSession = new ResourceManager())
                {
                    try
                    {

                        MbSession = (MessageBasedSession)rmSession.Open(resourceName);
                        MbSession.TimeoutMilliseconds = TimeoutMilliseconds;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
           
        }

    }
}
