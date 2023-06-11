using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp5.Entity;

namespace WinFormsApp5
{
    public class MainMethods
    {
        Context contextMethods = new Context();
        public async Task solicitudBecaAyuda(string matricula, string correo, int promedio, int tipo, int ingreso)
        {
            await contextMethods.SolicitudBecaAyudaAsync(Sesion.Session.SessionName,
                               correo,
                               promedio,
                               tipo,
                               ingreso);
        }
        public async Task solicitudBecaDeportiva(string matricula, string correo, int promedio, int tipo, string club)
        {
            await contextMethods.solicitudBecaDeportivaAsync(Sesion.Session.SessionName,
                              correo,
                              promedio,
                              tipo,
                              club);
        }

        public async Task solicitudBecaExcelencia(string matricula, string correo, int promedio, int tipo) 
        {
            await contextMethods.SolicitudExcelenciaAsync(Sesion.Session.SessionName,
                           correo,
                           promedio,
                           tipo);
        }

        public async Task<int> existeBeca(string matricula)
        {
          return  await contextMethods.ExisteBecaAsync(matricula);
        }
    }
}
