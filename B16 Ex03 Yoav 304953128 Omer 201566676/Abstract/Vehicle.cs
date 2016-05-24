using System.Collections.Generic;

namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public abstract class Vehicle
    {
        protected readonly string m_ModelName;
        protected readonly string m_LicenseNumber;
        protected EnergySystem m_EnergyModule;
        protected Wheel[] m_Wheels;

        public string ModelName
        {
            get { return m_ModelName; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
        }

        public EnergySystem EnergyModule
        {
            get { return m_EnergyModule; }
        }

        public Wheel[] Wheels
        {
            get { return m_Wheels; }
            set { m_Wheels = value; }
        }

        public Vehicle(string i_ModelName, string i_LicenseNumber)
        {
            m_ModelName = i_ModelName;
            m_LicenseNumber = i_LicenseNumber;
        }
    }
}