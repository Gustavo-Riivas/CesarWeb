namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("'A'BCDEFGHIJKLMNÑOPQRSTUVWXYZABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string abecedario= ("'z'yxwvutsrqpoñnmlkjihgfedcbazyxwvutsrqpoñnmlkjihgfedcba");
        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            int TAVO=0;
            int GUS=0;
            string igualar=Mensaje;
            for(TAVO=0;TAVO<Mensaje.Length;TAVO++){
                for(GUS=0;GUS<=52;GUS++){
                    if(Mensaje[TAVO]==ABECEDARIO[GUS]){
                        igualar=igualar.Replace(igualar[TAVO],ABECEDARIO[GUS-clave]);
                    }
                    if(Mensaje[TAVO]==abecedario[GUS]){
                        igualar=igualar.Replace(igualar[TAVO],abecedario[GUS-clave]);
                    }
                }
            }
            Mensaje=igualar;
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
            int G=0;
            int g=0;
            string comparacion=Mensaje;
            for(G=0;G<Mensaje.Length;G++){
                for(g=0;g<=52;g++){
                    if(Mensaje[G]==ABECEDARIO[g]){

                        comparacion=comparacion.Replace(comparacion[G],ABECEDARIO[g+clave]);
                    }
                    if(Mensaje[G]==abecedario[g]){
                        comparacion=comparacion.Replace(comparacion[G],abecedario[g-clave]);
                    }
                }
            }
            Mensaje=comparacion;
            return Mensaje;
        }
    }


}