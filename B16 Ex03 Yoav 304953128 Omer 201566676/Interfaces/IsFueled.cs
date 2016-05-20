namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public interface IsFueled
    {
        float FuelLitresLeft { get; set; }
        float MaxFuelLitres { get; set; }
        void AddFuel (int i_LitresAmount, eFuelType i_FuelType);
    }
}