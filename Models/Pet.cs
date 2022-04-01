using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType
    {
        Shepherd,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }
    public enum PetColorType
    {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted
    }
    public class Pet
    {
        [Required]
        public string name { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType color { get; set; }

        public DateTime checkedInAt { get; set; }

        [ForeignKey("petOwnerId")]
        public int petOwnerId { get; set; }

        public int id { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType breed { get; set; }
    }
}
