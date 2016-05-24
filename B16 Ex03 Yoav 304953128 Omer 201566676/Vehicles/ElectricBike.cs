namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class ElectricBike : Bike
    {
        private const float s_MaxWheelAirPressure = 31f;
        private const float s_MaxBatteryCharge = 1.9f;

        public ElectricBike(string i_ModelName, string i_LicenseNumber, eBikeLicenseType i_LicenseType, int i_EngineCapacity, string i_WheelsManufacturer) 
            : base(i_ModelName, i_LicenseNumber, i_LicenseType, i_EngineCapacity)
        {
            m_EnergyModule = new ElectricEnergySystem(s_MaxBatteryCharge);
            m_Wheels = new Wheel[2] {
                new Wheel(i_WheelsManufacturer, s_MaxWheelAirPressure),
                new Wheel(i_WheelsManufacturer, s_MaxWheelAirPressure) };
        }   
    }
}