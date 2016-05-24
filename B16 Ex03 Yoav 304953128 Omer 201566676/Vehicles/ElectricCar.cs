namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class ElectricCar : Car
    {
        private const float s_MaxWheelAirPressure = 30f;
        private const float s_MaxBatteryCharge = 3.3f;

        public ElectricCar(string i_ModelName, string i_LicenseNumber, eCarDoorsNumber i_NumOfDoors, string i_WheelsManufacturer) 
            : base(i_ModelName, i_LicenseNumber, i_NumOfDoors)
        {
            m_EnergyModule = new ElectricEnergySystem(s_MaxBatteryCharge);
            m_Wheels = new Wheel[4] {
                new Wheel(i_WheelsManufacturer, s_MaxWheelAirPressure),
                new Wheel(i_WheelsManufacturer, s_MaxWheelAirPressure),
                new Wheel(i_WheelsManufacturer, s_MaxWheelAirPressure),
                new Wheel(i_WheelsManufacturer, s_MaxWheelAirPressure) };
        }    
    }
}