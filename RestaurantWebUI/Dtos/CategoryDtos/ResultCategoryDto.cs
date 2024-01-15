namespace RestaurantWebUI.Dtos.CategoryDtos
{
	public class ResultCategoryDto
	{
		public int CategoryID { get; set; }

		public string CategoryName { get; set; }

		public string? CategoryImageUrl { get; set; }

		public string? CategoryDescription { get; set; }

		public bool CategoryStatus { get; set; }
	}
}
