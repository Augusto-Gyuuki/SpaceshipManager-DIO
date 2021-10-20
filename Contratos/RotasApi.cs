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
            public const string GetAll = Root + "/products";
            public const string Get = Root + "/products/{productId}";
        }

        public static class EspacoNave
        {
            public const string GetAll = Base + "/products";
            public const string Get = Base + "/products/{productId}";
        }

        public static class Piloto
        {
            public const string GetAll = Base + "/products";
            public const string Get = Base + "/products/{productId}";
            public const string Create = Base + "/products";
            public const string Update = Base + "/products/{productId}";
            public const string Delete = Base + "/products/{productId}";
        }

        public static class EspacoNavePiloto
        {
            public const string GetAll = Base + "/products";
            public const string Get = Base + "/products/{productId}";
            public const string Create = Base + "/products";
            public const string Update = Base + "/products/{productId}";
            public const string Delete = Base + "/products/{productId}";
        }
    }
}
