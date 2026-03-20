using Microsoft.ML.Data;

public class SalaryData
{
    [LoadColumn(0)] public float Age;
    [LoadColumn(1)] public string Workclass;
    [LoadColumn(2)] public float FNLWGT; // Cambiato in float
    [LoadColumn(3)] public string Education;
    [LoadColumn(4)] public float EducationNumber; // Cambiato in float
    [LoadColumn(5)] public string MaritalStatus;
    [LoadColumn(6)] public string Occupation;
    [LoadColumn(7)] public string Relationship;
    [LoadColumn(8)] public string Race;
    [LoadColumn(9)] public string Sex; // Cambiato in string per OneHotEncoding
    [LoadColumn(10)] public float CapitalGain; // Cambiato in float
    [LoadColumn(11)] public float CapitalLoss; // Cambiato in float
    [LoadColumn(12)] public float HoursWeek; // Cambiato in float
    [LoadColumn(13)] public string NativeCountry;
    [LoadColumn(14)] public string Salario;
}

public class SalaryPrediction
{
    // Nella classificazione binaria, ML.NET produce questi tre campi
    [ColumnName("PredictedLabel")] public bool Prediction; 
    public float Probability;
    public float Score;
}