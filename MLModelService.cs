using Microsoft.ML;

namespace CGenius
{
    public class MLModelService
    {
        private readonly MLContext _mlContext;
        private readonly ITransformer _model;

        public MLModelService()
        {
            _mlContext = new MLContext();
            _model = TrainModel();
        }

        private ITransformer TrainModel()
        {
            var data = _mlContext.Data.LoadFromTextFile<ModelInput>("customer_product_data.csv", hasHeader: true, separatorChar: ',');
            var pipeline = _mlContext.Transforms.Conversion.MapValueToKey("Label")
                            .Append(_mlContext.Transforms.Text.FeaturizeText("Features", "TextColumn"))
                            .Append(_mlContext.Transforms.Concatenate("Features", new[] { "Features" }))
                            .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"))
                            .Append(_mlContext.BinaryClassification.Trainers.SdcaLogisticRegression());

            return pipeline.Fit(data);
        }

        public float Predict(string text)
        {
            var predictionEngine = _mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(_model);
            var input = new ModelInput { TextColumn = text };
            var result = predictionEngine.Predict(input);
            return result.Score;
        }
    }

    public class ModelInput
    {
        public string TextColumn { get; set; }
        public float Label { get; set; }
    }

    public class ModelOutput
    {
        public float Score { get; set; }
    }

}
