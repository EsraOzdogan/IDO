using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ido
{
    class idoController : IController
    {
        private IIdoModel model;
        private IControlView contView;
        public idoController(IControlView view, IIdoModel model)
        {
            this.contView = view;
            this.model = model;

        }


        public void SetNereye(string nereye)
        {

           string[] nereden ={ "Yalova","Bandırma"};
           string a,b;
           a = nereden[0];
           b = nereden[1];
        
            model.setNereye(nereye);
            //sınırlandır
          /*  if (bpm < 0) bpm = 0;
            else if (bpm > 120) bpm = 120;

            model.setNereye(nereye);*/
        }

        public void SetNEREYE(string nereye)
        {
            throw new NotImplementedException();
        }
    }
}
