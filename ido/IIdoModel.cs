using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ido
{
    interface IIdoModel
    {
        void Initialize();
        void On();
        void Off();
        void setNereye(string nereye );
        int getNereye();

        // observer pattern methods
        //void registerObserver(BeatObserver observer);
        //void removeObserver(BeatObserver observer);
        void registerObserver(INereyeObserver observer);
        void removeObserver(INereyeObserver observer);
        /*void setNereye(string[] nereye);*/
       
    }
}
