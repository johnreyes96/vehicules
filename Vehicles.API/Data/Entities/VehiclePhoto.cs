﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Vehicles.API.Data.Entities
{
    public class VehiclePhoto
    {
        public int Id { get; set; }

        [JsonIgnore]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://vehiclesapijohn.azurewebsites.net/images/no-image.png"
            : $"https://vehiclesjohn.blob.core.windows.net/vehiclephotos/{ImageId}";
    }
}
