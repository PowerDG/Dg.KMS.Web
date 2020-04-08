

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DgKMS.Cube.CubeCore;

namespace DgKMS.Cube.CubeCore.Dtos
{
    public class CreateOrUpdateEvernoteTagInput
    {
        [Required]
        public EvernoteTagEditDto EvernoteTag { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}