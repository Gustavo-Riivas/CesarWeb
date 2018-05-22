using System.Text;
namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string abecedario= ("abcdefghijklmnñopqrstuvwxyz");
        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            StringBuilder desencripta=new StringBuilder();
            foreach(var y in Mensaje){
                if(char.IsLetter(y)){
                  for(int h=0;h<=26;h++){
                    if(y==ABECEDARIO[h]){
                         var clave2 = (h - clave) % ABECEDARIO.Length;
                         clave2 = clave2 < 0 ? clave2 = ABECEDARIO.Length + clave2 : clave2;
                        desencripta.Append(ABECEDARIO[clave2%27]);
                        }
                    else if(y==abecedario[h]){

                    /// Esto es lo mismo que un if(posLetraDesEnc < 0){posLetraDesEnc += ABECEDARIO.Length} else {posLetraDesEnc}
                    var clave2 = (h - clave) % ABECEDARIO.Length;
                    clave2 = clave2 < 0 ? clave2 = ABECEDARIO.Length + clave2 : clave2;
                        desencripta.Append(abecedario[clave2%27]);
                    }
                    }
                    } else{
                        desencripta.Append(y);
                    }

                  
            }
            Mensaje=desencripta.ToString();
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
               StringBuilder desencripta=new StringBuilder();
            foreach(var y in Mensaje){
                if(char.IsLetter(y)){
                  for(int h=0;h<=26;h++){
                    if(y==ABECEDARIO[h]){
                        desencripta.Append(ABECEDARIO[(clave+h)%27]);
                        }
                    else if(y==abecedario[h]){
                         desencripta.Append(abecedario[(clave+h)%27]);
                    }
                    }
                    } else{
                        desencripta.Append(y);
                    }

                  
            }
            Mensaje=desencripta.ToString();
            return Mensaje;
        }
    }


}