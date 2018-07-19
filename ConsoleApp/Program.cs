using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Entities;
using Newtonsoft.Json;

namespace ConsoleApp
{
    class Program
    {

        //Importante:
        //El siguiente ejemplo es una de las formas de como podemos consumir datos en formato json y como podemos descerializarlos para hacer nuestro análisis
        //Este ejemplo cuanta con ejemplos básicos y se irá robustenciendo para uso de toda la comunidad.
        //Fecha de actualización: 19/07/2018
        //Autor: Tony Rojas Gil @TonyRojasG
        //Email: datosabiertos@puebla.gob.mx


        //En los url publicados, 
        //puedes establecer el límite de información a obtener con el parámetro &limit=NroDeRegistros
        //Si deseas obtener todos los registros establece el parámetro en cero: &limit=0
        public const string UrlAfluenciaTuristica = "http://datos.puebla.gob.mx:8080/api/action/datastore/search.json?resource_id=54cbb77e-933f-4fe8-92df-1208cd98afaa&limit=0";

        //BestPractices: Crear una colección de 

        static void Main(string[] args)
        {
            Afluencia a = GetAfluenciaFrom(UrlAfluenciaTuristica);

            int TotalTuristas2010 = 0;

            foreach (Record r in a.result.records)
            {
                TotalTuristas2010 = TotalTuristas2010 + Convert.ToInt32(r.ANIO2010);
            }

            //Console.WriteLine("El total de turistas registrados en el año 2010 en {0} ciudades de Puebla es: {1}", a.result.records.Count(), TotalTuristas2010);

            // puedes dar formato para separar unidades de millar
            // en msdn, existen muchos string formats que puedes usar dependendiendo del valor que quieres mostrar
            Console.WriteLine("El total de turistas registrados en el año 2010 en {0} ciudades de Puebla es: {1}", a.result.records.Count(), string.Format("{0:n0}",TotalTuristas2010));


            Console.ReadLine();           
        }

        public static Afluencia GetAfluenciaFrom(string url)
        {
            
            Afluencia afluencia;
            string json;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
                afluencia = JsonConvert.DeserializeObject<Afluencia>(json);
            }

            return afluencia;
        }
    }
}
