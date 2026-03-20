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
    
    // Se il tuo CSV ha 15 o 16 colonne, assicurati che l'indice [14] o [15] sia quello giusto
    // Uso [14] come "Label" perché è l'obiettivo della regressione
    [LoadColumn(14), ColumnName("Label")] 
    public float Salario; 
}

public class SalaryPrediction
{
    // Nella regressione, il valore predetto finisce sempre in una colonna chiamata "Score"
    [ColumnName("Score")] 
    public float PredictedSalary; 
}