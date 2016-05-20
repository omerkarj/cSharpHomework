using System.Collections.Generic;

namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_EnergyPercentage;
        private List<Wheel> m_Wheels;
    }
}