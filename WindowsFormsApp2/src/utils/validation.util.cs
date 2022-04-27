using System;
namespace utils
{
    public class Validation
    {
        public static int OnlyDoubles(int tecla)
        {
            
            if (tecla >= 48 && tecla <= 57) return tecla;

            if (tecla == 08 || tecla == 13 || tecla == 46 || tecla == 127) return tecla;

            return 0;
        }

        public static int OnlyLetters(int tecla)
        {
            if(tecla >= 65 && tecla <= 90) return tecla;

            if(tecla >= 97 && tecla <= 122) return tecla;            

            if(tecla == 08 || tecla == 13) return tecla;

            return 0;
        }

        public static int OnlyInts(int tecla)
        {

            if (tecla >= 48 && tecla <= 57) return tecla;

            if (tecla == 08 || tecla == 13 || tecla == 127) return tecla;

            return 0;
        }
    }
}


