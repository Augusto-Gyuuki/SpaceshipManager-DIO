using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceshipManager.Contratos
{
    public static class RotasApi
    {
        public const string Root = "api";

        public static class Planetas
        {
            public const string GetAll = Root + "/planetas";
            public const string Get = Root + "/planetas/{planetaId}";
        }

        public static class EspacoNave
        {
            public const string GetAll = Root + "/naves";
            public const string Get = Root + "/naves/{naveId}";
        }

        public static class Piloto
        {
            public const string GetAll = Root + "/pilotos";
            public const string Get = Root + "/pilotos/{pilotoId}";
        }

        public static class HistoricoViagem
        {
            public const string GetAll = Root + "/historicos";
            public const string Create = Root + "/historicos";
            public const string Update = Root + "/historicos/{historicoId}";
            public const string Delete = Root + "/historicos/{historicoId}";
        }
    }
}
