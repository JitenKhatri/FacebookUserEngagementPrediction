using FacebookUserEngagementPrediction;

var sampleData = new FacebookUserEngagementPrediction.EngagementPrediction.ModelInput()
{
    Col0 = @"Yuuk!! found cockroach never visit again!!!"
};

var result = EngagementPrediction.Predict(sampleData);


if (result.PredictedLabel == 0)
{
    Console.WriteLine("The comment is negative");
} else
{
    Console.WriteLine("The comment is positive");
}


var sampleData2 = new FacebookUserEngagementPrediction.EngagementPrediction.ModelInput()
{
    Col0 = @"Best place to have lunch"
};

var result2 = EngagementPrediction.Predict(sampleData2);


if (result2.PredictedLabel == 0)
{
    Console.WriteLine("The comment is negative");
}
else
{
    Console.WriteLine("The comment is positive");
}