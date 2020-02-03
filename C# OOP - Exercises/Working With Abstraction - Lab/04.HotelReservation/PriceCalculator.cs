namespace _04.HotelReservation
{
    public class PriceCalculator
    {
        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season, Discount discount)
        {
            this.PricePerDay = pricePerDay;
            this.NumberOfDays = numberOfDays;
            this.Season = season;
            this.Discount = discount;
        }

        public decimal PricePerDay { get; set; }

        public int NumberOfDays { get; set; }

        public Season Season { get; set; }

        public Discount Discount { get; set; }

        public decimal GetTotalPrice()
        {
            decimal multiplier = (decimal)this.Season;
            decimal discount = (decimal)this.Discount / 100;
            decimal priceWithoutDiscount = this.PricePerDay * NumberOfDays * multiplier;
            decimal priceDiscount = priceWithoutDiscount * discount;
            decimal totalPrice = priceWithoutDiscount - priceDiscount;
            return totalPrice;
        }
    }
}
