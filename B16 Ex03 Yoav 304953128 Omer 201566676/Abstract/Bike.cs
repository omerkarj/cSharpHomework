namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public abstract class Bike : Vehicle
    {
        protected readonly eBikeLicenseType m_LicenseType;
        protected readonly int m_EngineCapacity;

        public eBikeLicenseType LicenseType
        {
            get { return m_LicenseType; }
        }

        public int EngineCapacity
        {
            get { return m_EngineCapacity; }
        }

        protected Bike(string i_ModelName, string i_LicenseNumber, eBikeLicenseType i_LicenseType, int i_EngineCapacity) 
            : base(i_ModelName, i_LicenseNumber)
        {
            m_LicenseType = i_LicenseType;
            m_EngineCapacity = i_EngineCapacity;
        }
    }
}