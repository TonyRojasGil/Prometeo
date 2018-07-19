using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{


    #region Acerca de las clases y objetos Json
    // Toda información que se obtenga a través de la Datastore DKAN API que se publica en el portal de datos abiertos(datos.puebla.gob.mx) tiene la estructura principal de esta clase.
    // Únicamente cambia la clase Record según la información.
    // 
    // La información públicada en el portal tiene la estructura que establecida por los lineamientos que definen la información como datos abiertos, sin embargo, esta misma 
    // característica, es útil para ser descargada pero no siempre para ser analizada de manera automática.
    // Un ejemplo claro podemos ver que las columnas de los años de la afluencia de visitantes turísticos es número que representa el año, 2010, 2011, 2012...
    // Estos valores no pueden convertirse en propiedades de una clase ya que son números, para esto es necesario renombrar estas propiedades y asignarle el nombre real del archivo JSON
    // lo que permite que la librería que deserializa el archivo JSON deposite en información en la propiedad que queremos.
    //
    // El ejemplo lo puedes encontrar en la clase Record de este archivo de las líneas 49 a 68.
   
    #endregion

    public class Afluencia
    {
        //Si lo deseas, puedes omitir propiedades que no te interesan deserializar

        //public string help { get; set; }
        //public bool success { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        //public Field[] fields { get; set; }
        public string[] resource_id { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public Record[] records { get; set; }
        //public string sql { get; set; }
    }

    public class Field
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Record
    {
        public string Ciudad { get; set; }
        [JsonProperty("Pueblo Mágico")]
        public string PM { get; set; }
        [JsonProperty("2010")]
        public string ANIO2010 { get; set; }
        [JsonProperty("2011")]
        public string ANIO2011 { get; set; }
        [JsonProperty("2012")]
        public string ANIO2012 { get; set; }
        [JsonProperty("2013")]
        public string ANIO2013 { get; set; }
        [JsonProperty("2014")]
        public string ANIO2014 { get; set; }
        [JsonProperty("2015")]
        public string ANIO2015 { get; set; }
        [JsonProperty("2016")]
        public string ANIO2016 { get; set; }
    }

}
