using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Backend.Infrastructure
{
    public class Configuration
    {
        public static string JWTSecret { get; set; } = "EaiPessoalTudoBemAquiQuemFalaÉOEduGaleraEstamosAquiParaJogarONovoRedDead3";

        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
        }
    }
}
