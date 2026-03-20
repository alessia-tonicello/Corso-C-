using Microsoft.ML;
using Microsoft.ML.Data;
using ScottPlot;

// Classe principale
class Program
{
    static void Main()
    {
        var context = new MLContext(seed: 0);
        
        var mappingData = new[]
        {
            new { ValoreTesto = ">50K", ValoreBool = true },
            new { ValoreTesto = "<=50K", ValoreBool = false }
        };
        var mappingView = context.Data.LoadFromEnumerable(mappingData);

        // --- 2. Caricamento Dati ---
        Console.WriteLine("Caricamento dati in corso...");
        IDataView dataView = context.Data.LoadFromTextFile<SalaryData>(
            "C:\\Users\\Administrator\\RiderProjects\\Intro\\Salary\\salary.csv", hasHeader: true, separatorChar: ',',
            trimWhitespace: true);
        var trainTestSplit = context.Data.TrainTestSplit(dataView, testFraction: 0.2);

        // --- 3. Pipeline di Trasformazione e Training ---
        var pipeline = context.Transforms.Categorical.OneHotEncoding("WorkclassEnc", nameof(SalaryData.Workclass))
            .Append(context.Transforms.Categorical.OneHotEncoding("EduEnc", nameof(SalaryData.Education)))
            .Append(context.Transforms.Categorical.OneHotEncoding("OccuEnc", nameof(SalaryData.Occupation)))
            .Append(context.Transforms.Categorical.OneHotEncoding("SexEnc", nameof(SalaryData.Sex)))

            .Append(context.Transforms.Conversion.MapValue(
                "Label", 
                mappingView, 
                mappingView.Schema["ValoreTesto"], 
                mappingView.Schema["ValoreBool"], 
                nameof(SalaryData.Salario)))
            
            // TRUCCO: Convertiamo i numeri in float esplicitamente e gestiamo i valori mancanti (NaN)
            .Append(context.Transforms.Concatenate("Features", 
                "WorkclassEnc", "EduEnc", "OccuEnc", "SexEnc", 
                nameof(SalaryData.Age), nameof(SalaryData.HoursWeek)))

            // Se ci sono ancora righe con "Features" vuote, le rimuoviamo anziché crashare
            .Append(context.BinaryClassification.Trainers.FastTree()); // Algoritmo basato su alberi di decisione

        Console.WriteLine("Addestramento del modello...");
        var model = pipeline.Fit(trainTestSplit.TrainSet);

        // --- 4. Valutazione ---
        var predictions = model.Transform(trainTestSplit.TestSet);
        var metrics = context.BinaryClassification.Evaluate(predictions);
        Console.WriteLine($"Accuratezza Modello: {metrics.Accuracy:P2}");

        // --- 5. Visualizzazione con ScottPlot ---
        VisualizzaRisultati(context, model, trainTestSplit.TestSet);
    }

    static void VisualizzaRisultati(MLContext context, ITransformer model, IDataView testData)
    {
        // Estraiamo i dati per il grafico (primi 50 campioni)
        var predictionsRaw = model.Transform(testData);
        var predictedList = context.Data.CreateEnumerable<SalaryPrediction>(predictionsRaw, reuseRowObject: false)
            .Take(50).ToArray();
        var actualList = context.Data.CreateEnumerable<SalaryData>(testData, reuseRowObject: false).Take(50)
            .ToArray();

        int count = predictedList.Length;
        double[] indices = Enumerable.Range(0, count).Select(x => (double)x).ToArray();
        
        double[] actuals = actualList.Select(x => x.Salario.Trim() == ">50K" ? 1.0 : 0.0).ToArray();
        double[] predicts = predictedList.Select(x => x.Prediction ? 1.0 : 0.0).ToArray();

        // --- NUOVA SINTASSI SCOTTPLOT 5 ---
        var plt = new ScottPlot.Plot(); // In SP5 le dimensioni si passano nel Save()

        // Add.Scatter ora restituisce un oggetto "Scatter"
        var s1 = plt.Add.Scatter(indices, actuals);
        s1.Label = "Reale (1=>50K, 0=<=50K)";
        s1.Color = Colors.Blue;

        var s2 = plt.Add.Scatter(indices, predicts);
        s2.Label = "Predetto";
        s2.Color = Colors.Red;

        // Titoli e Label
        plt.Title("Confronto Salario: Reale vs Predetto");
        plt.XLabel("WorkClass");
        plt.YLabel("Education");

        // La legenda ora si attiva così
        plt.ShowLegend();

        // Il salvataggio specifica qui la risoluzione
        plt.SavePng("RisultatoML.png", 800, 600);

        Console.WriteLine("Grafico generato con successo: RisultatoML.png");
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = "RisultatoML.png",
            UseShellExecute = true
        });

        Console.WriteLine("Grafico generato con successo: RisultatoML.png");
    }
}