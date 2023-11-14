using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Mtg
{
    class Card
    {
        public string name { get; set; }
        public string mana_cost { get; set; }
       // public List<MyLibrary.Color> ColorIdentity { get; set; }
        public string type_line { get; set; }
        public string oracle_text { get; set; }
        //public Image image { get; set; }
        public ImageUris image_uris { get; set; }
        public int priority { get; set; }
        public CardFace[] card_faces { get; set; }

    }
    class ImageUris
    {
        //[JsonProperty("small")]
        //public string Small { get; set; }

        //[JsonProperty("normal")]
        //public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        //[JsonProperty("png")]
        //public string Png { get; set; }

        //[JsonProperty("art_crop")]
        //public string ArtCrop { get; set; }

        //[JsonProperty("border_crop")]
        //public string BorderCrop { get; set; }
    }
    class CardFace
    {
        public string Name { get; set; }
        public ImageUris image_uris { get; set; }
        public string oracle_text { get; set; }
        public string type_line { get; set; }
        public string mana_cost { get; set; }
    }
}
