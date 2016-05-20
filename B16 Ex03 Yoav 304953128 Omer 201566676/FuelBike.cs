namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class FuelBike : Bike, IsFueled
    {
        public float FuelLitresLeft { get; set; }
        public float MaxFuelLitres { get; set; }

        public void AddFuel(int i_LitresAmount, eFuelType i_FuelType)
        {
            throw new System.NotImplementedException();
        }
    }
}