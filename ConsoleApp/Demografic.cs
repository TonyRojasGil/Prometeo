using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    public class Demografic
    {
        public Meta meta { get; set; }
        public object[][] data { get; set; }
    }

    public class Meta
    {
        public View view { get; set; }
    }

    public class View
    {
        public string id { get; set; }
        public string name { get; set; }
        public string attribution { get; set; }
        public int averageRating { get; set; }
        public string category { get; set; }
        public int createdAt { get; set; }
        public string description { get; set; }
        public string displayType { get; set; }
        public int downloadCount { get; set; }
        public bool hideFromCatalog { get; set; }
        public bool hideFromDataJson { get; set; }
        public int indexUpdatedAt { get; set; }
        public bool newBackend { get; set; }
        public int numberOfComments { get; set; }
        public int oid { get; set; }
        public string provenance { get; set; }
        public bool publicationAppendEnabled { get; set; }
        public int publicationDate { get; set; }
        public int publicationGroup { get; set; }
        public string publicationStage { get; set; }
        public string rowClass { get; set; }
        public int rowsUpdatedAt { get; set; }
        public string rowsUpdatedBy { get; set; }
        public int tableId { get; set; }
        public int totalTimesRated { get; set; }
        public int viewCount { get; set; }
        public int viewLastModified { get; set; }
        public string viewType { get; set; }
        public Column[] columns { get; set; }
        public Grant[] grants { get; set; }
        public Metadata metadata { get; set; }
        public Owner owner { get; set; }
        public Query query { get; set; }
        public string[] rights { get; set; }
        public Tableauthor tableAuthor { get; set; }
        public string[] tags { get; set; }
        public string[] flags { get; set; }
    }

    public class Metadata
    {
        public string rdfSubject { get; set; }
        public string rdfClass { get; set; }
        public Attachment[] attachments { get; set; }
        public Custom_Fields custom_fields { get; set; }
        public string rowIdentifier { get; set; }
        public string rowLabel { get; set; }
    }

    public class Custom_Fields
    {
        public Update Update { get; set; }
        public LegislativeCompliance LegislativeCompliance { get; set; }
        public DatasetInformation DatasetInformation { get; set; }
    }

    public class Update
    {
        public string Automation { get; set; }
        public string UpdateFrequency { get; set; }
    }

    public class LegislativeCompliance
    {
        public string GeocodingAttached { get; set; }
    }

    public class DatasetInformation
    {
        public string Agency { get; set; }
    }

    public class Attachment
    {
        public string filename { get; set; }
        public string assetId { get; set; }
        public string name { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string profileImageUrlLarge { get; set; }
        public string profileImageUrlMedium { get; set; }
        public string profileImageUrlSmall { get; set; }
        public string screenName { get; set; }
        public string type { get; set; }
    }

    public class Query
    {
    }

    public class Tableauthor
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string screenName { get; set; }
        public string type { get; set; }
    }

    public class Column
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dataTypeName { get; set; }
        public string fieldName { get; set; }
        public int position { get; set; }
        public string renderTypeName { get; set; }
        public Format format { get; set; }
        public string[] flags { get; set; }
        public int tableColumnId { get; set; }
        public int width { get; set; }
        public Cachedcontents cachedContents { get; set; }
    }

    public class Format
    {
        public string precisionStyle { get; set; }
        public string noCommas { get; set; }
        public string align { get; set; }
    }

    public class Cachedcontents
    {
        public int non_null { get; set; }
        public string average { get; set; }
        public string largest { get; set; }
        public int _null { get; set; }
        public Top[] top { get; set; }
        public string smallest { get; set; }
        public string sum { get; set; }
    }

    public class Top
    {
        public string item { get; set; }
        public int count { get; set; }
    }

    public class Grant
    {
        public bool inherited { get; set; }
        public string type { get; set; }
        public string[] flags { get; set; }
    }

}
