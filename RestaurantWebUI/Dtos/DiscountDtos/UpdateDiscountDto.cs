﻿namespace RestaurantWebUI.Dtos.DiscountDtos
{
    public class UpdateDiscountDto
    {
        public int DiscountID { get; set; }

        public string DiscountName { get; set; }

        public string DiscountAmount { get; set; }

        public string DiscountDescription { get; set; }

        public string DiscountImageUrl { get; set; }
    }
}
