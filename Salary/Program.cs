using Microsoft.ML;
using Microsoft.ML.Data;
using ScottPlot;

// Classe principale
class Program
{
    static void Main()
    {
        var context = new MLContext(seed: 0);
        var mapping = context.Data.LoadFromEnumerable(new[]
        {
            new { Value = ">50K", Label = true },
            new { Value = "<=50K", Label = false }
        });

        // --- 2. Caricamento Dati ---
        Console.WriteLine("Caricamento dati in corso...");
        IDataView dataView = context.Data.LoadFromTextFile<SalaryData>(
            "C:\\Users\\Administrator\\RiderProjects\\Intro\\Salary\\salary.csv", hasHeader: true, separatorChar: ',',
            trimWhitespace: true);
        var trainTestSplit = context.Data.TrainTestSplit(dataView, testFraction: 0.2);

        // --- 3. Pipeline di Trasformazione e Training ---
        var pipeline = context.Transforms.Categorical.OneHotEncoding("ClassEncoded", nameof(SalaryData.Workclass))
            .Append(context.Transforms.Categorical.OneHotEncoding("EducationEncoded", nameof(SalaryData.Education)))
            .Append(context.Transforms.Categorical.OneHotEncoding("MaritalEncoded", nameof(SalaryData.MaritalStatus)))
            .Append(context.Transforms.Categorical.OneHotEncoding("OccupationEncoded", nameof(SalaryData.Occupation)))
            .Append(context.Transforms.Categorical.OneHotEncoding("RelationshipEncoded",
                nameof(SalaryData.Relationship)))
            .Append(context.Transforms.Categorical.OneHotEncoding("RaceEncoded", nameof(SalaryData.Race)))
            .Append(context.Transforms.Categorical.OneHotEncoding("SexEncoded", nameof(SalaryData.Sex)))
            .Append(context.Transforms.Categorical.OneHotEncoding("NativeCountryEncoded",
                nameof(SalaryData.NativeCountry)))
            .Append(context.Transforms.Conversion.MapValue(
                "Label", mapping, mapping.Schema["Value"], mapping.Schema["Label"], nameof(SalaryData.Salario)))

            // TRUCCO: Convertiamo i numeri in float esplicitamente e gestiamo i valori mancanti (NaN)
            .Append(context.Transforms.Concatenate("Features",
                "ClassEncoded", "EducationEncoded", "MaritalEncoded",
                "OccupationEncoded", "RelationshipEncoded", "RaceEncoded",
                "SexEncoded", "NativeCountryEncoded", nameof(SalaryData.Age), nameof(SalaryData.HoursWeek)))

            // Se ci sono ancora righe con "Features" vuote, le rimuoviamo anziché crashare
            .Append(context.Regression.Trainers.FastTree()); // Algoritmo basato su alberi di decisione

        Console.WriteLine("Addestramento del modello...");
        var model = pipeline.Fit(trainTestSplit.TrainSet);

        // --- 4. Valutazione ---
        var predictions = model.Transform(trainTestSplit.TestSet);
        var metrics = context.Regression.Evaluate(predictions);
        Console.WriteLine(
            $"Metriche Modello:\n - R-Squared: {metrics.RSquared:0.##}\n - MAE (Errore Medio): {metrics.MeanAbsoluteError:0.##} $");

        // --- 5. Visualizzazione con ScottPlot ---
        VisualizzaRisultati(context, model, trainTestSplit.TestSet);
    }

    static void VisualizzaRisultati(MLContext context, ITransformer model, IDataView testData)
    {
        // Estraiamo i dati per il grafico (primi 50 campioni)
        var predictionsRaw = model.Transform(testData);
        var predictedEnumerable = context.Data.CreateEnumerable<SalaryPrediction>(predictionsRaw, reuseRowObject: false)
            .Take(50).ToArray();
        var actualEnumerable = context.Data.CreateEnumerable<SalaryData>(testData, reuseRowObject: false).Take(50)
            .ToArray();

        double[] indices = Enumerable.Range(0, 50).Select(x => (double)x).ToArray();
        double[] actuals = actualEnumerable.Select(x => (double)x.Salario).ToArray();
        double[] predicts = predictedEnumerable.Select(x => (double)x.PredictedSalary).ToArray();

        // --- NUOVA SINTASSI SCOTTPLOT 5 ---
        var plt = new ScottPlot.Plot(); // In SP5 le dimensioni si passano nel Save()

        // Add.Scatter ora restituisce un oggetto "Scatter"
        var s1 = plt.Add.Scatter(indices, actuals);
        s1.Label = "Reale";
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