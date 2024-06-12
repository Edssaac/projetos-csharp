using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace BitlyAPI
{
    public class BitlyAPI
    {
        //Token de Acesso Bitly: 1cd35a402bd973cd3eca322c6a2404a14f085143
        private string _bitlyAPI_Token; //Recebe o Token para ser usado na API;
        private string _bitlyAPI_Url; //Recebe a URL da API;

        public BitlyAPI() //Intânciando nossas variáveis sempre que a classe for declarada:
        {
            _bitlyAPI_Token = ConfigurationManager.AppSettings["BitlyAPI_Token"]; //Passando o Token;
            _bitlyAPI_Url = ConfigurationManager.AppSettings["BitlyAPI_Url"]; //Passando a URL;
        }


        //Método Assíncrono:
        public async Task<string> ShortenAsync(string long_url)
        {
            return await Task.Run(() => Shorten(long_url)); //Esperando o processamento;
        }

        //Método encurtador de URL's:
        private string Shorten(string long_url)
        {
            //O Token é válido?
            if ( CheckAccessToken() ) //Se sim:
            {
                using (HttpClient client = new HttpClient())
                {
                    //Formatando a URL da API: token de acesso + url a ser encurtada:
                    string temp = string.Format(_bitlyAPI_Url, _bitlyAPI_Token, WebUtility.UrlEncode(long_url));

                    //Verificando se a url é valida:
                    var response = client.GetAsync(temp).Result;

                    //Pegando o conteúdo da URL convertida:
                    var message = response.Content.ReadAsStringAsync().Result;

                    //Passando para um JSON:
                    dynamic obj = JsonConvert.DeserializeObject(message);

                    //Foi sucesso?

                    //Se não for válido:
                    if (obj.errorCode == 500)
                    {
                        return "INVALID_URI";
                    }
                    else //Se for válido:
                    {
                        //Acessando o JSON e devolvendo o shortUrl:
                        return obj.results[long_url].shortUrl; //Retornando a URL encurtada;
                    }
                }
            }
            else //Se não:
            {
                return "INVALID_ACCESS_TOKEN";
            }

        }


        //Método que verifica se o Token de Acesso é válido:
        private bool CheckAccessToken()
        {
            //Verificando se o Token está vazio ou é nulo:
            if ( string.IsNullOrEmpty(_bitlyAPI_Token) )
            {
                return false;
            }

            //Formatando o URL da API, com o token e a url a ser encurtada: 
            string temp = string.Format(_bitlyAPI_Url, _bitlyAPI_Token, "google.com");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(temp).Result; //Verificando se o token é válido;

                //Pegando o conteúdo da URL convertida:
                var message = response.Content.ReadAsStringAsync().Result;

                //Passando para um JSON:
                dynamic obj = JsonConvert.DeserializeObject(message);

                //Se o código de erro indicar o token incorreto:
                if ( obj.errorCode == 403 )
                {
                    return false;
                }

                return response.IsSuccessStatusCode; //Retornando Sucesso;
            }

        }


    }
}
