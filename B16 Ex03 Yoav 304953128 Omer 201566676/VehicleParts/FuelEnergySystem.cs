namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class FuelEnergySystem : EnergySystem
    {
        private readonly eFuelType m_FuelType;

        public eFuelType FuelType
        {
            get { return m_FuelType; }
        }

        public FuelEnergySystem(eFuelType i_FuelType, float i_MaxFillAmount) : base(i_MaxFillAmount)
        {
            m_FuelType = i_FuelType;
            base(i_MaxFillAmount);
        }

        public void AddFuel (eFuelType i_FuelType, float i_FuelAmount)
        {
            bool fuelTypeMatch = i_FuelType == m_FuelType;
            bool validFuelAmount = m_CurrentFillAmount + i_FuelAmount <= m_MaxFillAmount;
            
            if (fuelTypeMatch && validFuelAmount)
            {
                m_CurrentFillAmount += i_FuelAmount;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }
    }
}