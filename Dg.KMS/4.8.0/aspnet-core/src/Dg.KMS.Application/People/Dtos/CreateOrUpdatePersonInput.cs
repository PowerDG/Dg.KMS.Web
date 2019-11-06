

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dg.KMS.People;

namespace Dg.KMS.People.Dtos
{
    public class CreateOrUpdatePersonInput
    {
        [Required]
        public PersonEditDto Person { get; set; }

    }
}