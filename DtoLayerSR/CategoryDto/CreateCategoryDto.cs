using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayerSR.CategoryDto
{
    public class CreateCategoryDto
    {
        public string CategoryName { get; set; }

        public string? CategoryImageUrl { get; set; }

        public string? CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }
    }
}
