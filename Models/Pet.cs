using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel.Models
{
  public class Pet
  {
    public int id { get; set; }
    public string name { get; set; }

    public DateTime checkedInAt { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public PetBreedType breed { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public PetColorType color { get; set; }

    [ForeignKey("petOwner")]
    public int petOwnerId { get; set; }

    public PetOwner OwnedBy { get; set; }
  }
}
