using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ido
{
    class IdoModel : IIdoModel
    {
       /* private ArrayList idoObservers = new ArrayList();
        private ArrayList nereyeObservers = new ArrayList();*/
        private string nereye;
        public string[] c = { "pendik", "kadıköy" };
        public string[] d;
      /*  public string[] c */
        public int getNereye()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        internal void registerObserver(View view)
        {
            throw new NotImplementedException();
        }

        public void On()
        {
            throw new NotImplementedException();
        }

        public void registerObserver(INereyeObserver observer)
        {
            nereyeObservers.Add(observer);
        }

        public void removeObserver(INereyeObserver observer)
        {
           nereyeObservers.Remove(observer);
        }

        public void setNereye(string nereye)
        {
            if (this.nereye == "Yalova")
            {
                d = c;

                notifyidoObservers();
            }
        }

        private void notifyidoObservers()
        {
            throw new NotImplementedException();
        }

        public void setNereye(string[] nereye)
        {
            throw new NotImplementedException();
        }
        #region Observer Pattern Methods
        #endregion

        #region Midi Generation Methods via NAudio 1.3
        #endregion
    }
}
        

