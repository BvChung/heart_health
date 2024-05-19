namespace HeartHealthAPI.Models
{
    public readonly record struct MedicalRecords(
        int Age,
        int Anemia,
        int CreatinePhosphokinase,
        int EjectionFraction,
        int Platelets,
        double SerumCreatinine,
        int SerumSodium,
        int DaysUntilFollowUp
        )
    {
        /*
         * class PatientMedicalRecords(BaseModel):
            age: int
            anemia: int
            creatine_phosphokinase: int
            ejection_fraction: int
            platelets: int
            serum_creatinine: float
            serum_sodium: int
            days_until_follow_up: int
         */
    }
}
