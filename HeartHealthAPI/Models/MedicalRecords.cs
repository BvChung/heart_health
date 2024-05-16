namespace HeartHealthAPI.Models
{
    public readonly record struct MedicalRecords(int age, int anemia, int creatine_phosphokinase, int ejection_fraction, int platelets, float serumCreatinine, int serumSodium, int daysUntilFollowUp)
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
